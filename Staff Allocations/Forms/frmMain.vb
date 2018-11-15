Imports System.Data
Imports System.Windows.Forms
Imports Staff_Allocations_MiddleTier.mt_LookUps
Imports Staff_Allocations.pt_RetrievePresentationVariables
Imports Staff_Allocations_MiddleTier.mt_Exceptions.Exception_Messages
Imports Staff_Allocations_MiddleTier.mt_Exceptions.Traces
Imports Staff_Allocations_MiddleTier.mt_Validation.mt_Routines
Public Class frmMain
    Public Datagridview1CellValueBeforeEdit As Decimal
    Public Event DataGridView1EditEndingRaisedAnException()
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ptw As New pt_WinForm_frmMain
        Dim SetStyle As New EH_Winforms_Utilities.EH_StyleSheets.EH_SetStyle

        Me.BINDDATA_FILLTableAdapters()
        SetStyle.Assign_Style(Me, LOOKUP_frmMainStyleInterfaceImplementation)
        ptw.SETFORM__frmMain_SetControlsRelatedToCrosstabColumns(LOOKUP_CrosstabStyleInterfaceImplementation)
        Me.cmbLegMonth.SelectedValue = RETRIEVE_MonthOrdinalofToday()

    End Sub
    Private Sub Initialize_frmMain_on_Opening(sender As Object, e As EventArgs) Handles MyBase.Shown

        Dim ptw As New pt_WinForm_frmMain
        ptw.RESET_DATAGRIDVIEW1_frmMain_Set_Labels_And_Recreate_Datatable()

    End Sub
    Private Sub ProgramOrStaffToggled(sender As Object, e As EventArgs) Handles radStaff.CheckedChanged, radProgram.CheckedChanged

        'swap controls and create datatable whenever Staff/Program toggle changes -
        ' controls and datable creation don't always happen together - sometimes they interfere so only one is done or the other

        Dim ptw As New pt_WinForm_frmMain
        ptw.RESET_DATAGRIDVIEW1_frmMain_Set_Labels_And_Recreate_Datatable()

    End Sub

    Private Sub AddNewProgramOrStaffToDatatable(sender As Object, e As EventArgs) Handles cmbAdd.SelectionChangeCommitted

        'Adds a new program or staff to the datatable

        Dim dt As New DataTable
        Dim sp As New Staff_Allocations_MiddleTier.mt_Stored_Procedures
        Dim mtv As New Staff_Allocations_MiddleTier.mt_Validation.mt_Routines
        Dim ptd As New Staff_Allocations.pt_Data_AddNewProgramOrStaffToFrmMainDgv


        Dim i As Integer = 0

        If mtv.VALIDATE_ThatTheDatagridviewHasRows(Me.DataGridView1) Then

            dt = TryCast(Me.DataGridView1.DataSource, DataTable)

            If Not mtv.VALIDATE_ThatStaffOrProgramAreNotAlreadyAdded(RETRIEVE_Toggle, dt, RETRIEVE_AddCombo_StaffOrProgram) Then
                Exit Sub
            End If

        Else

            dt = ptd.MODIFY_CrosstabTable_PrepareFirstRowWhenCrosstabTableHasNoRows()

        End If

        ptd.MODIFY_CrosstabTable_AddNewProgramOrStaff(dt)


    End Sub
    Private Sub SelectNewStartingMonth(sender As Object, e As EventArgs) Handles cmbLegMonth.SelectedIndexChanged

        'Changes selected starting Month

        Dim ptd As New pt_Data_BuildDgvDataTables
        ptd.CREATE_LimitedPeriodsDataTable()

    End Sub

    Private Sub SelectNewProgramOrStaff(sender As Object, e As EventArgs) Handles cmbStaffOrPrograms.SelectedIndexChanged

        Dim ptw As New pt_WinForm_frmMain

        ptw.RESET_DATAGRIDVIEW1_frmMain_Set_Labels_And_Recreate_Datatable()



    End Sub
    Private Sub Reset_datagridview1_When_cmbStaffOrPrograms_Closed_to_Prevent_Odd_Behavior_on_Tabbing(sender As Object, e As EventArgs) Handles cmbStaffOrPrograms.DropDownClosed

        Dim ptd As New Staff_Allocations.pt_WinForm_frmMain
        ptd.RESET_DATAGRIDVIEW1_frmMain_Set_Labels_And_Recreate_Datatable()

    End Sub
    Public Sub UpdateDataGridview1CellToDatabase(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit

        'Commits new value to database

        Try

            Dim mtv As New Staff_Allocations_MiddleTier.mt_Validation.mt_Routines
            Dim ptq As New pt_Data_UpdateDatabase

            If mtv.VALIDATE_ThatTheDatagridviewHasRows(Me.DataGridView1) Then
                If mtv.VALIDATE_ThatTheCurrentColumnIsNotStaffOrProgram(Me.DataGridView1) Then

                    Try

                        ptq.UpdateDatabase("Allocation")

                        Dim ptd As New pt_Data_BuildDgvDataTables
                        Dim dt As New DataTable
                        dt = DataGridView1.DataSource
                        ptd.Fill_In_dgvAllocatedTotals(dt)


                    Catch ex1 As InvalidCastException

                        Dim HandleInvalidCastException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.InvalidCastHandler
                        Dim LogOnly As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.TraceOnlyHandler
                        Dim mtv1 As New Staff_Allocations_MiddleTier.mt_Validation.mt_Routines

                        If IsDBNull(Me.DataGridView1.CurrentCell.Value) Or Not mtv1.VALIDATE_ThatTheValueIsNotNullOrAnEmptyString(Me.DataGridView1) Then
                            Me.DataGridView1.CurrentCell.ValueType = GetType(Decimal)
                            Me.DataGridView1.CurrentCell.Value = 0
                            ptq.UpdateDatabase("Allocation")

                            LogOnly.HANDLE_EXCEPTION(ex1, False, , "*** INVALID CAST IN CELLENDEDIT.  NO USER MESSAGE.  THIS GENERALLY OCCURS WHEN THERE IS AN INVALID ENTRY IN A BLANK CELL. THE CELL TYPE IS MADE A DECIMAL AND THE VALUE IS CHANGED TO ZERO - THE ERROR OCCURS WHEN THE BLANK CELL IS MADE A DECIMAL.*** ")

                            Exit Try
                        End If

                        HandleInvalidCastException.HANDLE_EXCEPTION(ex1, LOOKUP_RunConditionalTrace)

                        RaiseEvent DataGridView1EditEndingRaisedAnException()

                    End Try
                End If
            End If

        Catch ex As Exception

            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, LOOKUP_CondtionalTraceSetting)

            RaiseEvent DataGridView1EditEndingRaisedAnException()

        End Try

    End Sub

    Private Sub ChangeSeeAllMonthsToggle(sender As Object, e As EventArgs) Handles Button1.Click

        'Create datatable based on whether in SeeAll mode


        Dim ptd As New pt_Data_BuildDgvDataTables

        If RETRIEVE_SeeAllMonths_Mode() Then
            ptd.CREATE_LimitedPeriodsDataTable()

        Else
            ptd.CREATE_SeeAllMonthsDataTable()
        End If

    End Sub

    Private Sub OpenAdminForm(sender As Object, e As EventArgs) Handles ToolStripButton4.Click

        'Opens Admin Form

        Try

            If InputBox("Password?") = LOOKUP_AdminPassword() Then
                Dim f As New frmAdmin
                f.ShowDialog()
            Else
                MessageBox.Show("Password Incorrect.")
            End If

        Catch ex As Exception
            Dim mter As New Staff_Allocations_MiddleTier.mt_Exceptions.mt_Routines
            mter.HANDLE_EXCEPTION_Standard(ex)
        End Try

    End Sub

    Private Sub OpenReportServer(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

        'Opens reports

        Try

            Process.Start(LOOKUP_ReportServerUrl)

        Catch ex As Exception
            Dim mter As New Staff_Allocations_MiddleTier.mt_Exceptions.mt_Routines
            mter.HANDLE_EXCEPTION_Standard(ex)
        End Try

    End Sub

    Private Sub OpenStaffAndProgramLists(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        'Opens form to edit Staff or Program lists
        Dim mtv As New Staff_Allocations_MiddleTier.mt_Validation.mt_Routines

        Try
            If Me.DataGridView1.IsCurrentCellDirty = True Then
                '
                Dim ptw As New pt_WinForm_frmMain
                ptw.UPDATE_Datagridview1_Cell_Value_to_Database()
                ptw.RESET_DATAGRIDVIEW1_frmMain_Set_Labels_And_Recreate_Datatable()

            End If

            Dim f As New frmAddProgramOrStaff
            MessageBox.Show("Please be aware that when you add a new staff member or a new program your entry will automatically move to the top of the list.")
            f.ShowDialog()

        Catch ex As Exception
            Dim mter As New Staff_Allocations_MiddleTier.mt_Exceptions.mt_Routines
            mter.HANDLE_EXCEPTION_Standard(ex)

            Exit Sub

        End Try

    End Sub
    Private Sub Update_Comments(sender As Object, e As EventArgs) Handles rtbStaffComments.TextChanged, rtbProgramComments.TextChanged

        Dim mter As New Staff_Allocations_MiddleTier.mt_Exceptions.mt_Routines
        Dim sp As New Staff_Allocations_MiddleTier.mt_Stored_Procedures

        Try

            'Me.TblStaffTableAdapter.Update(Staff_AllocationsDataSet.tblStaff)
            'Me.TblProgramsTableAdapter.Update(Staff_AllocationsDataSet.tblPrograms)

            sp.SP_UPDATE_COMMENTS(RETRIEVE_Toggle, RETRIEVE_StaffOrProgramID, RETRIEVE_Comments)
            'Me.TblProgramsTableAdapter.Fill(Staff_AllocationsDataSet.tblPrograms)
            'Me.TblStaffTableAdapter.Fill(Staff_AllocationsDataSet.tblStaff)

        Catch dbcx As Data.DBConcurrencyException
            mter.HANDLE_EXCEPTION_Concurrency(dbcx)

        Catch ex As Exception
            mter.HANDLE_EXCEPTION_Standard(ex)


        End Try

    End Sub

    Private Sub DataGridView1_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError

        Dim mtw As New Staff_Allocations_MiddleTier.mt_Winforms_Utilities.mt_DataGridViewFunctions
        mtw.Standard_DataGridView_ErrorHandling(e, sender)

    End Sub
    Private Sub ApproveCells(sender As Object, e As EventArgs) Handles ToolStripButton3.Click


        Dim ptw As New pt_WinForm_frmMain
        Dim ptq As New pt_Data_UpdateDatabase
        Dim mtv As New Staff_Allocations_MiddleTier.mt_Validation.mt_Routines


        Try

            If Me.DataGridView1.CurrentCell.FormattedValueType = GetType(System.String) Then

                If String.IsNullOrEmpty(Me.DataGridView1.CurrentCell.GetEditedFormattedValue(Me.DataGridView1.CurrentCell.RowIndex, _
                                                                      DataGridViewDataErrorContexts.CurrentCellChange)) Then
                    Try

                        Me.DataGridView1.CurrentCell.Value = 0
                        ptq.UpdateDatabase("Allocation")


                    Catch ex As Exception
                        Dim LogExceptionOnly As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.TraceOnlyHandler
                        LogExceptionOnly.HANDLE_EXCEPTION(ex, LOOKUP_CondtionalTraceSetting, , "*** INVALID CAST IN APPROVECELLS.  NO USER MESSAGE.  THIS GENERALLY OCCURS WHEN THERE IS AN INVALID ENTRY IN A BLANK CELL. THE VALUE IS CHANGED TO ZERO - THE ERROR OCCURS WHEN THE BLANK CELL IS MADE A DECIMAL.***")
                        Exit Sub
                    End Try

                End If
            End If


            If MessageBox.Show("Are you sure you want to approve the selected cells?  Please review your selection to make sure.", "Approve Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

            Try

                If RETRIEVE_SeeAllMonths_Mode() Then
                    MessageBox.Show("You cannot approve cells when using '" & LOOKUP_CrosstabStyleInterfaceImplementation.SeeAllButtonText & "'." & _
                        "  Click the '" & LOOKUP_CrosstabStyleInterfaceImplementation.SeeAllButtonText_Alternative & "' button below to approve your selection.")
                    Exit Sub
                End If

                If mtv.VALIDATE_ThatTheValueIsADecimal(Me.DataGridView1.CurrentCell.GetEditedFormattedValue(Me.DataGridView1.CurrentCell.RowIndex, _
                                                    DataGridViewDataErrorContexts.CurrentCellChange)) Then
                    If Not mtv.VALIDATE_ThatTheNumberIsWithinRange((Me.DataGridView1.CurrentCell.GetEditedFormattedValue(Me.DataGridView1.CurrentCell.RowIndex, _
                                                    DataGridViewDataErrorContexts.CurrentCellChange))) Then Exit Sub
                Else
                    If Not Me.DataGridView1.CurrentCell.ColumnIndex = 0 And mtv.VALIDATE_ThatTheValueIsNotNullOrAnEmptyString(Me.DataGridView1.CurrentCell.GetEditedFormattedValue(Me.DataGridView1.CurrentCell.RowIndex, _
                                                   DataGridViewDataErrorContexts.CurrentCellChange)) Then
                        MessageBox.Show("You may only enter numbers here.")
                        Exit Sub
                    End If
                End If

                ptq.UpdateDatabase("Approved")
                Dim ptd As New pt_Data_BuildDgvDataTables
                ptd.CREATE_LimitedPeriodsDataTable()

            Catch ex As Exception

                Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
                HandleStandardException.HANDLE_EXCEPTION(ex, LOOKUP_CondtionalTraceSetting)

            End Try
        Catch ex2 As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex2, LOOKUP_CondtionalTraceSetting)
        End Try

    End Sub

    Private Sub SelectAllCells(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Try

            Me.DataGridView1.SelectAll()

        Catch ex As Exception
            MessageBox.Show(EXCEPTION_MESSAGE_Standard() & ex.Message)
            LOG_Exception(ex, ex.ToString, True)
        End Try

    End Sub
    Private Sub SuppressEscapeKey(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown

        If e.KeyCode = Keys.Escape Then
            e.SuppressKeyPress = True

        End If
    End Sub

    Private Sub ValidateDataGridView1BeforeValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DataGridView1.CellValidating

        Dim mtv As New Staff_Allocations_MiddleTier.mt_Validation.mt_Routines

        'If value is null or empty make it 0
        If Not mtv.VALIDATE_ThatTheValueIsNotNullOrAnEmptyString(e.FormattedValue) Then
            Me.DataGridView1.CurrentCell.Value = 0
            Exit Sub

        Else

            If Me.DataGridView1.CurrentCell.ColumnIndex <> 0 Then

                If mtv.VALIDATE_ThatTheValueIsADecimal(e.FormattedValue) Then
                    If Not mtv.VALIDATE_ThatTheNumberIsWithinRange(e.FormattedValue) Then
                        'if value is decimal and falls outside the range then cancel

                        e.Cancel = True

                    End If
                Else
                    If Not mtv.VALIDATE_ThatTheValueIsNotANonEmptyNonNullString(e.FormattedValue) Then
                        'if value is a non-null and non-empty string, then cancel

                        e.Cancel = True
                    End If
                End If

                'If we move to 0 place decimal, include the line below.
                'mtv.VALIDATE_ThatTheNumberIsAWholeNumber(e.FormattedValue)

            End If
        End If

    End Sub
    Private Sub BINDDATA_FILLTableAdapters()

        Me.TblStaffTableAdapter.FillActiveOnly(Me.Staff_AllocationsDataSet.tblStaff)
        Me.LegMonthTableAdapter.Fill(Me.Staff_AllocationsDataSet.LegMonth)
        Me.TblMonthsTableAdapter.Fill(Me.Staff_AllocationsDataSet.tblMonths)
        Me.TblProgramsTableAdapter.FillActiveOnly(Me.Staff_AllocationsDataSet.tblPrograms)

    End Sub

    Private Sub REFRESH_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click

        Dim ptw As New pt_WinForm_frmMain

        ptw.UPDATE_Datagridview1_Cell_Value_to_Database()
        ptw.RESET_DATAGRIDVIEW1_frmMain_Set_Labels_And_Recreate_Datatable()

    End Sub

    Private Sub EXTRAS_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click

        Try

            Dim f As New frmExtras
            f.ShowDialog()

        Catch ex As Exception

            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, LOOKUP_CondtionalTraceSetting)

        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) 'Handles DataGridView1.CellDoubleClick

        'disabled - to enable finish code and reattach handle

        Try

            Dim NumberOfMonthsToPasteCopyOfCell As Integer = InputBox("Paste the current cell value in this row for the next how many months?")
            Dim ValueOfCurrentCell As Integer = RETRIEVE_Datgridview1CurrentCell()

            If NumberOfMonthsToPasteCopyOfCell > 11 Then
                MessageBox.Show("The number needs to be 11 or less.")
                Exit Sub
            End If

            Dim ptq As New pt_Data_UpdateDatabase
            Dim i As Integer = 1

            ptq.UpdateDatabase("allocation")

            Do While i <= NumberOfMonthsToPasteCopyOfCell

                ptq.UpdateDatabase("allocation", RETRIEVE_Datgridview1CurrentCell, 26 + i, "14", "33")

                i = i + 1

            Loop

            Dim ptd As New pt_Data_BuildDgvDataTables
            ptd.CREATE_LimitedPeriodsDataTable()

        Catch ex As Exception

            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, LOOKUP_CondtionalTraceSetting)

        End Try

    End Sub

End Class