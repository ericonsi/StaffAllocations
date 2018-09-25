Imports Staff_Allocations_MiddleTier.mt_LookUps
Imports Staff_Allocations_MiddleTier.mt_Stored_Procedures
Imports Staff_Allocations.pt_RetrievePresentationVariables
Public Class pt_Data_BuildDgvDataTables
    Private StartMonth As Integer
    Private EndMonth As Integer
    Private Toggle As String
    Private ToggleID As Integer
    Private dtAllocationsDataTable As New DataTable
    Private dtApprovedDataTable As New DataTable
    Public Event EH_DataTableChanged()
    Public Sub CREATE_LimitedPeriodsDataTable()

        CREATE_DataTables(RETRIEVE_Ord, RETRIEVE_Ord() + LOOKUP_CrosstabStyleInterfaceImplementation.CrosstabColumnNumber,
                    RETRIEVE_Toggle, RETRIEVE_StaffOrProgramID)

    End Sub
    Public Sub CREATE_SeeAllMonthsDataTable()

        CREATE_DataTables(LOOKUP_Min_DateOrd, LOOKUP_Max_DateOrd() + 1, RETRIEVE_Toggle, RETRIEVE_StaffOrProgramID)

    End Sub
    Private Sub CREATE_DataTables(iStartMonthOrd As Integer, iEndMonthOrdFromCosstabStyle As Integer, sToggle As String, iToggleID As Integer)

        StartMonth = iStartMonthOrd
        EndMonth = iEndMonthOrdFromCosstabStyle
        Toggle = sToggle
        ToggleID = iToggleID

        REVISE_EndMonthIfItExceedsLastPossibleMonth(EndMonth)
        CREATE_DataTableFromCrosstabUsingSP(StartMonth, EndMonth, Toggle, ToggleID)
        FILLIN_DataTableColumnsIfMissingFromCrosstab(StartMonth, EndMonth, Toggle, ToggleID)
        SET_DatagridviewColumnProperties(StartMonth, EndMonth)

        RaiseEvent EH_DataTableChanged()

    End Sub
    Private Sub REVISE_EndMonthIfItExceedsLastPossibleMonth(ByRef EndMonth)
        If EndMonth > LOOKUP_Max_DateOrd() Then
            EndMonth = LOOKUP_Max_DateOrd()
        Else
            EndMonth = EndMonth - 1
        End If
    End Sub
    Private Sub CREATE_DataTableFromCrosstabUsingSP(StartMonth As Integer, EndMonth As Integer, Toggle As String, ToggleID As Integer)

        Dim RunStoredProcedure As New Staff_Allocations_MiddleTier.mt_Stored_Procedures

        ''''This code is neccessary to save dirty entries to the datatable, don't know why
        Dim dt As New DataTable
        frmMain.DataGridView1.DataSource = dt
        '''''

        dtAllocationsDataTable = RunStoredProcedure.SP_DATATABLE_CREATION_CROSSTAB_EXECUTE(StartMonth, EndMonth, Toggle, ToggleID)
        dtApprovedDataTable = RunStoredProcedure.SP_DATATABLE_CREATION_CROSSTAB_EXECUTE1(StartMonth, EndMonth, Toggle, ToggleID, "Approved")

    End Sub
    Private Sub FILLIN_DataTableColumnsIfMissingFromCrosstab(StartMonth As Integer, EndMonth As Integer, Toggle As String, ToggleID As Integer)

        frmMain.DataGridView1.DataSource = FillInMissingColumns(dtAllocationsDataTable, StartMonth, EndMonth, Toggle)
        frmMain.DataGridView2.DataSource = FillInMissingColumns(dtApprovedDataTable, StartMonth, EndMonth, Toggle)
        FILL_IN_dgvAllocatedTotals(frmMain.DataGridView1.DataSource)


    End Sub
    Private Function FillInMissingColumns(ByRef dt As DataTable, start_ord As Integer, end_ord As Integer, toggle As String) As DataTable

        ' fills in any missing columns between start and end - does not add rows

        Dim exists As Boolean
        Dim exists2 As Boolean
        Dim i As Integer = start_ord

        If end_ord > LOOKUP_Max_DateOrd() Then end_ord = LOOKUP_Max_DateOrd()

        For Each c1 As DataColumn In dt.Columns
            If c1.ColumnName = "Staff" Or c1.ColumnName = "Program" Then
                exists2 = True
            End If
        Next

        If Not exists2 Then
            If toggle = "Staff" Then
                dt.Columns.Add("Program")
            Else
                dt.Columns.Add("Staff")
            End If
        End If

        exists = False
        Do While i <= end_ord
            For Each c As DataColumn In dt.Columns

                If c.ColumnName = Convert.ToString(i) Then
                    exists = True
                End If
            Next

            If Not exists Then
                dt.Columns.Add(Convert.ToString(i))
            End If

            i = i + 1
            exists = False
        Loop

        Return dt

    End Function
    Private Sub SET_DatagridviewColumnProperties(StartMonth As Integer, EndMonth As Integer)

        SetColumnProperties(frmMain.DataGridView1, StartMonth, EndMonth)
        SetColumnProperties(frmMain.DataGridView2, StartMonth, EndMonth)

    End Sub
    Private Sub SetColumnProperties(dgv As DataGridView, StartMonth As Integer, EndMonth As Integer)

        SetToggleColumnProperties(dgv, StartMonth, EndMonth)
        SetValueColumnProperties(dgv, StartMonth, EndMonth)

    End Sub
    Private Sub SetToggleColumnProperties(dgv As DataGridView, StartMonth As Integer, EndMonth As Integer)

        With dgv.Columns(0)
            .Width = 150
            .ReadOnly = True
            .Frozen = True
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .ValueType = GetType(String)
        End With

    End Sub
    Private Sub SetValueColumnProperties(dgv As DataGridView, StartMonth As Integer, EndMonth As Integer)

        Dim iColumnIndex As Integer
        Dim i As Integer = StartMonth

        Do While i <= EndMonth

            iColumnIndex = i - StartMonth + 1
            With dgv
                .Columns(Convert.ToString(i)).DisplayIndex = iColumnIndex
                .Columns(Convert.ToString(i)).HeaderText = LOOKUP_CrosstabStyleInterfaceImplementation.LOOKUP_CrosstabColumnHeader(i)
                .Columns(iColumnIndex).Width = 52
                .Columns(iColumnIndex).ValueType = GetType(Decimal)
            End With
            i = i + 1
        Loop

    End Sub
    Private Sub EH_DataTableChanged_Handler() Handles Me.EH_DataTableChanged

        Dim SetSeeAllMonthsModeButtonText As New Staff_Allocations_MiddleTier.mt_Winforms_Utilities.mt_Controls
        Dim sText As String = LOOKUP_CrosstabStyleInterfaceImplementation.SeeAllButtonText
        Dim sAltText As String = LOOKUP_CrosstabStyleInterfaceImplementation.SeeAllButtonText_Alternative

        SetSeeAllMonthsModeButtonText.Swapper(frmMain.Button1, "Text", Not RETRIEVE_SeeAllMonths_Mode(), sText, sAltText)

    End Sub
    Public Sub FILL_IN_dgvAllocatedTotals(dt As DataTable)

        Try

            Dim dt2 As New DataTable
            If RETRIEVE_Toggle() = "Staff" And Not RETRIEVE_SeeAllMonths_Mode() And dt.Rows.Count > 0 Then
                frmMain.dgvAllocatedTotals.Visible = True
                frmMain.dgvAllocatedTotals.ColumnHeadersVisible = False
                frmMain.dgvAllocatedTotals.DataSource = Get_Column_Totals_From_DataTable(dt)

            Else
                frmMain.dgvAllocatedTotals.Visible = False
            End If

        Catch ex As Exception

            frmMain.dgvAllocatedTotals.Visible = False

        End Try

    End Sub
    Private Function Get_Column_Totals_From_DataTable(dt As DataTable) As DataTable


        'The logic needs to take into account the fact that the columns in the data table are not in the right order, since columns with a null value are added at the end.  
        ' However, the column names are integers which do form a series in the correct order - this fact is used to add the correct column values in the correct locations

        Dim arrTotals(13) As Decimal
        Dim table As New DataTable
        Dim iColumnNameAsInteger As Integer
        arrTotals(0) = 0

        If dt.Rows.Count > 0 Then

            table.Columns.Add("Column1", GetType(String))

            For Each c As DataColumn In dt.Columns
                If c.ColumnName <> "Staff" And c.ColumnName <> "Program" Then
                    iColumnNameAsInteger = Convert.ToInt64(c.ColumnName) - Get_First_Column_Name_As_Integer(dt) + 1
                    table.Columns.Add("Column" & iColumnNameAsInteger + 1, GetType(Decimal))
                    arrTotals(iColumnNameAsInteger) = 0.00
                    For Each DRow As DataRow In dt.Rows
                        If Not IsDBNull(DRow.Item(iColumnNameAsInteger)) Then
                            arrTotals(iColumnNameAsInteger) = arrTotals(iColumnNameAsInteger) + ((DRow.Item(iColumnNameAsInteger)))
                        End If
                    Next
                End If
            Next

            table.Rows.Add("Allocated Totals:", arrTotals(1), arrTotals(2), arrTotals(3), arrTotals(4), arrTotals(5), arrTotals(6), arrTotals(7), arrTotals(8), arrTotals(9), arrTotals(10), arrTotals(11), arrTotals(12))

            Return table

        End If

    End Function
    Private Function Get_First_Column_Name_As_Integer(dt As DataTable) As Integer

        'The logic needs to take into account the fact that the columns in the data table are not in the right order, since columns with a null value are added at the end.  
        ' However, the column names are integers which do form a series in the correct order - this fact is used to add the correct column values in the correct locations

        Dim iFirstColumnName As Integer = 100000000
        For Each c As DataColumn In dt.Columns
            If c.ColumnName <> "Staff" And c.ColumnName <> "Program" Then
                If Convert.ToInt64(c.ColumnName) < iFirstColumnName Then
                    iFirstColumnName = Convert.ToInt64(c.ColumnName)
                End If
            End If
        Next

        Return iFirstColumnName

    End Function
End Class

