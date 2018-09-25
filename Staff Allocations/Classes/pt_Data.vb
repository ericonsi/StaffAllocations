Imports System.Windows
Imports System.Windows.Forms
Imports Staff_Allocations_MiddleTier.mt_LookUps
Imports Staff_Allocations.pt_RetrievePresentationVariables
Imports Staff_Allocations.Staff_AllocationsDataSet
Imports Staff_Allocations_MiddleTier.mt_Exceptions.Exception_Messages
Imports Staff_Allocations_MiddleTier.mt_Exceptions.Traces
Imports Staff_Allocations_MiddleTier.mt_Validation
Imports Staff_Allocations.pt_data.pt_UpdateDatabase
Namespace pt_data
    Public Class pt_CreateDataTable
        Public Event EH_DataTableChanged()
        Private WithEvents EH_TraceIT As Staff_Allocations_MiddleTier.mt_Exceptions.Traces
        Public Sub New()

            Dim VALIDATION As New Staff_Allocations_MiddleTier.mt_Validation
            EH_TraceIT = New Staff_Allocations_MiddleTier.mt_Exceptions.Traces

        End Sub
        Private Sub CREATE_datatable(iStart As Integer, iEnd As Integer, sToggle As String, iID As Integer)

            'Create datatable for Datagridview
            Try

                Dim pv As New pt_RetrievePresentationVariables
                Dim sp As New Staff_Allocations_MiddleTier.mt_Stored_Procedures
                Dim dt As New DataTable
                Dim dt2 As New DataTable
                Dim i As Integer = iStart
                iEnd = iEnd - 1


                '1. Run stored_procedure crosstab to generate the basic table

                frmMain.DataGridView1.DataSource = dt 'initializes datagridview table - otherwise it was appending columns, not starting from scratch (may not be needed)
                dt = sp.SP_DATATABLE_CREATION_CROSSTAB_EXECUTE(iStart, iEnd, sToggle, iID)
                dt2 = sp.SP_DATATABLE_CREATION_CROSSTAB_EXECUTE1(iStart, iEnd, sToggle, iID, "Approved")

                '2. Create columns for dt if they didn't exist so that all columns exist from start ord to end ord
                frmMain.DataGridView1.DataSource = CreateDatatable_FillOutDt(dt, iStart, iEnd, sToggle)
                frmMain.DataGridView2.DataSource = CreateDatatable_FillOutDt(dt2, iStart, iEnd, sToggle)

                '3. set column styles
                CreateDatatable_SetColumnStyles(frmMain.DataGridView1, iStart, iEnd)
                CreateDatatable_SetColumnStyles(frmMain.DataGridView2, iStart, iEnd)

                RaiseEvent EH_DataTableChanged()

            Catch ex As Exception
                MessageBox.Show(EXCEPTION_MESSAGE_Standard() & ex.Message)
                EH_TraceIt1(ex, ex.ToString, LOOKUP_RunConditionalTrace)
            End Try

        End Sub
        Private Function CreateDatatable_FillOutDt(dt As DataTable, start_ord As Integer, end_ord As Integer, toggle As String) As DataTable

            ' fills in any missing columns between start and end - does not add rows
            Try
                Dim exists As Boolean
                Dim exists2 As Boolean
                Dim i As Integer = start_ord

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

            Catch ex As Exception
                MessageBox.Show(EXCEPTION_MESSAGE_Standard() & ex.Message)
                EH_TraceIt1(ex, ex.ToString, LOOKUP_RunConditionalTrace)
            End Try

        End Function
        Private Sub CreateDatatable_SetColumnStyles(dgv As DataGridView, iStart As Integer, iEnd As Integer)

            Dim ptw As New pt_WinForm_Functions
            Dim iColumnIndex As Integer
            Dim i As Integer = iStart

            With dgv.Columns(0)
                .Width = 150
                .ReadOnly = True
                .Frozen = True
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            End With

            Do While i <= iEnd

                iColumnIndex = i - iStart + 1
                With dgv
                    .Columns(Convert.ToString(i)).DisplayIndex = iColumnIndex
                    .Columns(Convert.ToString(i)).HeaderText = LOOKUP_CrosstabStyleInterface.LOOKUP_CrosstabColumnHeader(i)
                    .Columns(iColumnIndex).Width = 52
                End With
                i = i + 1
            Loop

        End Sub
        Public Sub EH_DataTableChanged_Handler() Handles Me.EH_DataTableChanged

            'Swaps (or not) "See All Months" button when Datatable is refreshed

            Dim Ehm As New Staff_Allocations_MiddleTier.mt_Winforms_Utilities.mt_Controls
            Dim Ccu As New Staff_Allocations_MiddleTier.mt_Winforms_Utilities.mt_CrosstabColumnUnits
            Dim ptw As New pt_WinForm_Functions

            Dim sText As String = LOOKUP_CrosstabStyleInterface.SeeAllButtonText
            Dim sAltText As String = LOOKUP_CrosstabStyleInterface.SeeAllButtonText_Alternative

            Ehm.Swapper(frmMain.Button1, "Text", Not RETRIEVE_SeeAllMonths_Mode(), sText, sAltText)

        End Sub
        Public Sub CREATE_Standard_Datatable()

            Dim ehCT As New pt_data.pt_CreateDataTable

            ehCT.CREATE_datatable(RETRIEVE_Ord, RETRIEVE_Ord() + LOOKUP_CrosstabStyleInterface.CrosstabColumnNumber,
                                  RETRIEVE_Toggle, RETRIEVE_StaffOrProgramID)

        End Sub
        Public Sub CREATE_SeeAllMonths_Datatable()

            Dim ehCT As New pt_data.pt_CreateDataTable

                EhCT.CREATE_DATATABLE(LOOKUP_Min_DateOrd, LOOKUP_Max_DateOrd() + 1, RETRIEVE_Toggle, RETRIEVE_StaffOrProgramID)

        End Sub
    End Class

    Public Class pt_UpdateDatabase
        Public Class pt_RecieveCallFromMain
            Public Sub Update_Insert_Delete_EnteredData(AllocToggle As String)

                ' Called from frmMain, updates Allocations or Approveds depending on parameter
                ' This class also contains 'ExecuteSps' which executes the actual Standard Procedures at 
                ' the end of the process.

                If AllocToggle = "Allocation" Then
                    Dim s As New pt_data.pt_UpdateDatabase.UpdateDB_Allocation
                    s.SendParametersToSPs()
                Else
                    Dim s As New pt_data.pt_UpdateDatabase.UpdateDB_Approved
                    s.SendParametersToSPs()
                End If

            End Sub
            Public Sub ExecuteDB_SPs(mti As Staff_Allocations_MiddleTier.mt_IUpdateDB)

                Try

                    Dim sp As New Staff_Allocations_MiddleTier.mt_Stored_Procedures
                    Dim VALIDATION As New Staff_Allocations_MiddleTier.mt_Validation.mt_Routines

                    If mti.dValue = 0 Then
                        sp.SP_DELETE_ALLOCATION(mti.strProgramID, mti.strStaffID, mti.iDateID)
                    Else
                        If VALIDATION.mt_NumberRange(mti.dValue) Then
                            sp.SP_UPDATE_DATATABLE_TO_DATABASE_EXECUTE(mti.dValue, mti.strProgramID, mti.strStaffID, mti.iDateID, mti.AllocToggle)
                        End If
                    End If

                Catch ex As Exception
                    MessageBox.Show(EXCEPTION_MESSAGE_Standard() & ex.Message)
                    EH_TraceIt1(ex, ex.ToString, LOOKUP_RunConditionalTrace)
                End Try
            End Sub
        End Class
        Public Class UpdateDB_Allocation
            Implements Staff_Allocations_MiddleTier.mt_IUpdateDB

            Public Property AllocToggle As String = "Allocation" _
                Implements Staff_Allocations_MiddleTier.mt_IUpdateDB.AllocToggle

            Public Property dValue As Decimal _
                Implements Staff_Allocations_MiddleTier.mt_IUpdateDB.dValue

            Public Property iDateID As Integer = LOOKUP_DateID_From_DateOrd(frmMain.DataGridView1.Columns _
                                                            (frmMain.DataGridView1.CurrentCell.ColumnIndex).Name) _
                Implements Staff_Allocations_MiddleTier.mt_IUpdateDB.iDateID

            Public Property strProgramID As String _
                Implements Staff_Allocations_MiddleTier.mt_IUpdateDB.strProgramID

            Public Property strStaffID As String _
                Implements Staff_Allocations_MiddleTier.mt_IUpdateDB.strStaffID
            Public Sub SendParametersToSPs() Implements Staff_Allocations_MiddleTier.mt_IUpdateDB.SendParametersToSPs

                If RETRIEVE_Toggle() = "Staff" Then
                    strStaffID = Convert.ToString(frmMain.cmbStaffOrPrograms.SelectedValue)
                    strProgramID = Convert.ToString(LOOKUP_ProgramID_From_ProgramName(frmMain.DataGridView1.CurrentRow.Cells(0).Value))
                Else
                    strProgramID = Convert.ToString(frmMain.cmbStaffOrPrograms.SelectedValue)
                    strStaffID = Convert.ToString(LOOKUP_StaffID_From_StaffName(frmMain.DataGridView1.CurrentRow.Cells(0).Value))
                End If

                If IsDBNull(frmMain.DataGridView1.CurrentCell.Value) Then
                    dValue = 0
                Else
                    dValue = frmMain.DataGridView1.CurrentCell.Value
                End If

                Dim ptd As New pt_data.pt_UpdateDatabase.pt_RecieveCallFromMain
                ptd.ExecuteDB_SPs(Me)

            End Sub
        End Class
        Public Class UpdateDB_Approved
            Implements Staff_Allocations_MiddleTier.mt_IUpdateDB

            Public Property AllocToggle As String = "Approved" _
            Implements Staff_Allocations_MiddleTier.mt_IUpdateDB.AllocToggle

            Public Property dValue As Decimal _
                Implements Staff_Allocations_MiddleTier.mt_IUpdateDB.dValue

            Public Property iDateID As Integer _
                Implements Staff_Allocations_MiddleTier.mt_IUpdateDB.iDateID

            Public Property strProgramID As String _
                Implements Staff_Allocations_MiddleTier.mt_IUpdateDB.strProgramID

            Public Property strStaffID As String _
                Implements Staff_Allocations_MiddleTier.mt_IUpdateDB.strStaffID
            Public Sub SendParametersToSPs() Implements Staff_Allocations_MiddleTier.mt_IUpdateDB.SendParametersToSPs

                Dim i As Integer

                For i = 0 To frmMain.DataGridView1.SelectedCells.Count - 1

                    If frmMain.DataGridView1.SelectedCells(i).ColumnIndex = 0 Then
                        Continue For
                    End If

                    Dim ri As Integer = frmMain.DataGridView1.SelectedCells(i).RowIndex
                    If RETRIEVE_Toggle() = "Staff" Then
                        strStaffID = Convert.ToString(frmMain.cmbStaffOrPrograms.SelectedValue)
                        strProgramID = Convert.ToString(LOOKUP_ProgramID_From_ProgramName(frmMain.DataGridView1.Rows(ri).Cells(0).Value))
                    Else
                        strProgramID = Convert.ToString(frmMain.cmbStaffOrPrograms.SelectedValue)
                        strStaffID = Convert.ToString(LOOKUP_StaffID_From_StaffName(frmMain.DataGridView1.Rows(ri).Cells(0).Value))
                    End If


                    If frmMain.DataGridView1.IsCurrentCellDirty Then
                        frmMain.DataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)
                    End If

                    If IsDBNull(frmMain.DataGridView1.SelectedCells(i).Value) Then
                        dValue = 0
                    Else
                        dValue = frmMain.DataGridView1.SelectedCells(i).Value
                    End If

                    iDateID = LOOKUP_DateID_From_DateOrd(frmMain.DataGridView1.Columns(frmMain.DataGridView1.SelectedCells(i).ColumnIndex).Name)

                    Dim ptd As New pt_data.pt_UpdateDatabase.pt_RecieveCallFromMain
                    ptd.ExecuteDB_SPs(Me)
                Next
            End Sub
        End Class
    End Class
    Public Class Perform_Data_Binding

        Public Sub FILL_TableAdapters()

            frmMain.TblStaffTableAdapter.Fill(frmMain.Staff_AllocationsDataSet.tblStaff)
            frmMain.LegMonthTableAdapter.Fill(frmMain.Staff_AllocationsDataSet.LegMonth)
            frmMain.TblMonthsTableAdapter.Fill(frmMain.Staff_AllocationsDataSet.tblMonths)
            frmMain.TblProgramsTableAdapter.Fill(frmMain.Staff_AllocationsDataSet.tblPrograms)

        End Sub

    End Class
End Namespace