Imports System.Data
Imports System.Data.Sql
Imports System.Windows.Forms
Imports Staff_Allocations.pt_RetrievePresentationVariables
Imports Staff_Allocations_MiddleTier.mt_Exceptions.Exception_Messages
Imports Staff_Allocations_MiddleTier.mt_Exceptions.Traces
Imports Staff_Allocations_MiddleTier.mt_LookUps
Imports EH_DataUtilities.GeneralDataFunctions
Imports EH_Winforms_Utilities.EH_DatagridViewFunctions
Imports Staff_Allocations_MiddleTier.mt_Validation.mt_Routines
Public Class frmAddProgramOrStaff
    Public Event OpenfrmEditDropDowns()
    Private Property UpdatePending As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FILL_TABLES()
        Me.radStaff.Checked = True

    End Sub
    Private Sub radStaff_CheckedChanged(sender As Object, e As EventArgs) Handles radStaff.CheckedChanged
        Try

            Dim SetFormToStaffOrProgram As New pt_Winform_frmAddProgramOrStaff
            SetFormToStaffOrProgram.SETFORM_frmAddProgramOrStaff("Staff", Me)


        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, LOOKUP_CondtionalTraceSetting)

        End Try

    End Sub

    Private Sub radProgram_CheckedChanged(sender As Object, e As EventArgs) Handles radProgram.CheckedChanged

        Try

            Dim SetFormToStaffOrProgram As New pt_Winform_frmAddProgramOrStaff
            SetFormToStaffOrProgram.SETFORM_frmAddProgramOrStaff("Program", Me)
        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, LOOKUP_CondtionalTraceSetting)

        End Try

    End Sub
    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click

        Try

            Dim mtw_PasswordCorrect As New Staff_Allocations_MiddleTier.mt_Winforms_Utilities.PasswordPrompts

            If mtw_PasswordCorrect.DeleteStaffOrProgramFromList() Then

                Dim result1 As DialogResult = MessageBox.Show("Are you sure you want to DELETE this item? YOU WILL LOSE ALL THE DATA FOR THIS ITEM, INCLUDING PAST DATA!  If you want to retain their past data but remove them for the present, mark them as inactive.",
                              "ALERT",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If result1 = Windows.Forms.DialogResult.Yes Then
                    Me.bnBindingNavigator.BindingSource.RemoveCurrent()
                End If

            End If

        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, LOOKUP_CondtionalTraceSetting)

        End Try

    End Sub

    Private Sub frmAddProgramOrStaff_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If Me.Add_Datagridview.IsCurrentRowDirty Then

                Me.Validate()
                Me.Add_Datagridview.EndEdit()

            End If

            AUTO_SAVE()

        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, LOOKUP_CondtionalTraceSetting)

        End Try

    End Sub
    Private Sub AUTO_SAVE()

        Try

            Dim mtv As New Staff_Allocations_MiddleTier.mt_Validation.mt_Routines


            Add_Datagridview.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Staff_AllocationsDataSet)


            frmMain.TblProgramsTableAdapter.FillActiveOnly(frmMain.Staff_AllocationsDataSet.tblPrograms)
            frmMain.TblStaffTableAdapter.FillActiveOnly(frmMain.Staff_AllocationsDataSet.tblStaff)


        Catch dbcx As Data.DBConcurrencyException

            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(dbcx, LOOKUP_CondtionalTraceSetting)


        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, LOOKUP_CondtionalTraceSetting)

        End Try

    End Sub
    Private Sub frmAddProgramOrStaff_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        frmMain.TblStaffTableAdapter.FillActiveOnly(frmMain.Staff_AllocationsDataSet.tblStaff)
        frmMain.TblProgramsTableAdapter.FillActiveOnly(frmMain.Staff_AllocationsDataSet.tblPrograms)


        Dim ptw As New pt_WinForm_frmMain
        Dim ptd As New pt_Data_BuildDgvDataTables

        ptw.SETFORM_frmMain_SwapControlsDependingOnToggle()
        ptd.CREATE_LimitedPeriodsDataTable()



    End Sub

    Private Sub Add_Datagridview_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles Add_Datagridview.RowValidating

        Dim mtv As New Staff_Allocations_MiddleTier.mt_Validation.mt_Routines
        Dim CurrentDGVRow As DataGridViewRow = Me.Add_Datagridview.CurrentRow
        Dim ptd As New pt_Data_AddNewProgramOrStaff
        Dim sFirstName As String
        Dim sLastName As String

        Try

            If Me.Add_Datagridview.IsCurrentRowDirty And Not CurrentDGVRow.IsNewRow Then

                If Me.radStaff.Checked Then

                    If IsDBNull(CurrentDGVRow.Cells("FirstName").Value) Then
                        sFirstName = ""
                    Else
                        sFirstName = CurrentDGVRow.Cells("FirstName").Value
                    End If

                    If IsDBNull(CurrentDGVRow.Cells("LastName").Value) Then
                        sLastName = ""
                    Else
                        sLastName = CurrentDGVRow.Cells("LastName").Value
                    End If

                    'using first and last name here is not a mistake
                Else
                    If IsDBNull(CurrentDGVRow.Cells("Department").Value) Then
                        sFirstName = ""
                    Else
                        sFirstName = CurrentDGVRow.Cells("Department").Value
                    End If

                    If IsDBNull(CurrentDGVRow.Cells("ProgramName").Value) Then
                        sLastName = ""
                    Else
                        sLastName = CurrentDGVRow.Cells("ProgramName").Value
                    End If

                End If

                If mtv.VALIDATE_ThatStaffOrProgramIsNotAlreadyInTable(Me.radStaff.Checked, sLastName, sFirstName, Me.Add_Datagridview, CurrentDGVRow) Then
                    ptd.SET_Defaults(Me.Add_Datagridview, RETRIEVE_AddProgramOrStaff_Toggle(Me))
                Else
                    e.Cancel = True
                End If

            End If

        Catch ex As Exception

            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, LOOKUP_CondtionalTraceSetting)
        End Try
    End Sub
    Public Sub FILL_TABLES()
        Try

            Dim aaa As New Object
            Dim bbb As New Object

            SyncLock aaa
                SyncLock bbb

                    Me.TblStaffTableAdapter1.Fill(Me.Staff_AllocationsDataSet.tblStaff)
                    Me.TblProgramsTableAdapter.Fill(Me.Staff_AllocationsDataSet.tblPrograms)

                End SyncLock
            End SyncLock

        Catch ex As Exception

            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, LOOKUP_CondtionalTraceSetting)

        End Try

    End Sub
    Private Sub Add_DataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Add_Datagridview.DataError
        Try

            Dim mtw As New Staff_Allocations_MiddleTier.mt_Winforms_Utilities.mt_DataGridViewFunctions
            mtw.Standard_DataGridView_ErrorHandling(e, sender)

        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, LOOKUP_CondtionalTraceSetting)
        End Try

    End Sub

    ' Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs)
    'If IsDBNull(Me.Add_Datagridview.CurrentRow.Cells("Active").Value) Then Me.Add_Datagridview.CurrentRow.Cells("Active").Value = 1
    'Prevents error on repeatedly clicking add row
    'End Sub
    Private Sub OPEN_frmEditDropdowns_ProgramName(sender As Object, e As EventArgs) Handles btnAddNewProgramName.Click
        Try

            RaiseEvent OpenfrmEditDropDowns()
            Dim ptd As pt_Data_EditDropDowns.IDropDownEditor = New pt_Data_EditDropDowns.DropDownEditors.DropDownEditor_ProgramNames

            Dim f As New frmEditDropdown(ptd)
            f.ShowDialog()

            FILL_TABLES()
            Dim SetFormToStaffOrProgram As New pt_Winform_frmAddProgramOrStaff
            SetFormToStaffOrProgram.SETFORM_frmAddProgramOrStaff("Programs", Me)

        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, LOOKUP_CondtionalTraceSetting)
        End Try
    End Sub
    Private Sub OPEN_frmEditDropDowns_Site(sender As Object, e As EventArgs) Handles btnAddNewSite.Click
        Try

            RaiseEvent OpenfrmEditDropDowns()
            Dim ptd As pt_Data_EditDropDowns.IDropDownEditor = New pt_Data_EditDropDowns.DropDownEditors.DropDownEditor_Sites
            Dim f As New frmEditDropdown(ptd)
            f.ShowDialog()

            FILL_TABLES()
            Dim SetFormToStaffOrProgram As New pt_Winform_frmAddProgramOrStaff
            SetFormToStaffOrProgram.SETFORM_frmAddProgramOrStaff("Staff", Me)

        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, LOOKUP_CondtionalTraceSetting)
        End Try
    End Sub

    Private Sub OPEN_frmEditDropDowns_Department(sender As Object, e As EventArgs) Handles btnAddNewDepartment.Click
        Try

            RaiseEvent OpenfrmEditDropDowns()
            Dim ptd As pt_Data_EditDropDowns.IDropDownEditor = New pt_Data_EditDropDowns.DropDownEditors.DropDownEditor_Departments

            Dim f As New frmEditDropdown(ptd)
            f.ShowDialog()

            FILL_TABLES()
            Dim SetFormToStaffOrProgram As New pt_Winform_frmAddProgramOrStaff
            SetFormToStaffOrProgram.SETFORM_frmAddProgramOrStaff("Programs", Me)


        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, LOOKUP_CondtionalTraceSetting)
        End Try
    End Sub

    Private Sub OPEN_frmEditDropDown_DepartmentHead(sender As Object, e As EventArgs) Handles btnAddNewDepartmentHead.Click
        Try

            RaiseEvent OpenfrmEditDropDowns()
            Dim ptd As pt_Data_EditDropDowns.IDropDownEditor = New pt_Data_EditDropDowns.DropDownEditors.DropDownEditor_DepartmentHeads
            Dim f As New frmEditDropdown(ptd)
            f.ShowDialog()

            FILL_TABLES()
            Dim SetFormToStaffOrProgram As New pt_Winform_frmAddProgramOrStaff
            SetFormToStaffOrProgram.SETFORM_frmAddProgramOrStaff("Staff", Me)

        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, LOOKUP_CondtionalTraceSetting)
        End Try
    End Sub
    Private Sub ON_OpenfrmEditDropDowns() Handles Me.OpenfrmEditDropDowns

        MessageBox.Show("When you edit existing entries the new wording is updated throughout the databse for all records. So edit existing entries to fix spelling errors or modify wording.  " & Environment.NewLine & Environment.NewLine & "IF YOU WANT A NEW ENTRY, DO NOT OVERWRITE AN EXISTING ENTRY. ADD A NEW ENTRY.")

    End Sub

End Class