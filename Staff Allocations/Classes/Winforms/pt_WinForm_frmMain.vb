Imports System.Windows
Imports Staff_Allocations_MiddleTier.mt_LookUps
Imports Staff_Allocations.pt_RetrievePresentationVariables
Imports Staff_Allocations.Staff_AllocationsDataSet
Imports Staff_Allocations_MiddleTier.mt_Exceptions.Exception_Messages
Imports Staff_Allocations_MiddleTier.mt_Exceptions.Traces
Imports Staff_Allocations_MiddleTier.mt_Validation
Public Class pt_WinForm_frmMain
    Public Sub New()

        Dim VALIDATION As New Staff_Allocations_MiddleTier.mt_Validation

    End Sub
    Public Sub SETFORM_frmMain_SwapControlsDependingOnToggle()

        Try

            Dim EHW As New Staff_Allocations_MiddleTier.mt_Winforms_Utilities.mt_Controls

            Dim StaffvsProgram As String = RETRIEVE_Toggle()
            Dim bsProg As BindingSource = frmMain.TblProgramsComboBox.DataSource
            Dim bsStaff As BindingSource = frmMain.TblStaffComboBox.DataSource

            EHW.Swapper(frmMain.lblStaff, "Text", StaffvsProgram = "Staff", "Staff:", "Program:")
            EHW.Swapper(frmMain.lblAdd, "Text", StaffvsProgram = "Staff", "Add Program: ", "Add Staff: ")
            EHW.Swapper(frmMain.lblAllocations, "Text", StaffvsProgram = "Staff", "Program Allocations For:  " & RETRIEVE_Toggle_Value(), "Staff Allocations For:  " & RETRIEVE_Toggle_Value())
            EHW.Swapper(frmMain.cmbAdd, "DataSource", StaffvsProgram = "Staff", bsProg, bsStaff)
            EHW.Swapper(frmMain.cmbAdd, "DisplayMember", StaffvsProgram = "Staff", "Program", "Staff")
            EHW.Swapper(frmMain.cmbAdd, "ValueMember", StaffvsProgram = "Staff", "ProgramID", "StaffID")
            EHW.Swapper(frmMain.cmbStaffOrPrograms, "DataSource", StaffvsProgram = "Staff", bsStaff, bsProg)
            EHW.Swapper(frmMain.cmbStaffOrPrograms, "DisplayMember", StaffvsProgram = "Staff", "Staff", "Program")
            EHW.Swapper(frmMain.cmbStaffOrPrograms, "ValueMember", StaffvsProgram = "Staff", "StaffID", "ProgramID")
            EHW.Swapper(frmMain.rtbStaffComments, "Visible", StaffvsProgram = "Staff", "True", "False")
            EHW.Swapper(frmMain.rtbProgramComments, "Visible", StaffvsProgram = "Staff", "False", "True")

        Catch ex As Exception

            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, LOOKUP_CondtionalTraceSetting)

        End Try

    End Sub
    Public Sub SETFORM__frmMain_SetControlsRelatedToCrosstabColumns(obj As Staff_Allocations_MiddleTier.mt_ICrosstabColumnUnits)

        frmMain.lblMonth.Text = obj.lblColumnUnitText
        frmMain.Button1.Text = obj.SeeAllButtonText
        frmMain.cmbLegMonth.DisplayMember = obj.cmbColumnUnitDisplayMember
        frmMain.cmbLegMonth.ValueMember = obj.cmbColumnValueMember

    End Sub
    Public Sub PROGRAMFLOW_EndEditForDataGridView1()

        Try
            frmMain.DataGridView1.EndEdit()

        Catch ex As Exception

            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, LOOKUP_CondtionalTraceSetting)
        End Try
    End Sub
    Public Sub CHANGE_DISPLAY_frmMain_Reduce_Toolstrip_Font_Size()

        Try

            Dim tObj As ToolStripItem
            For Each tObj In frmMain.ToolStrip1.Items
                tObj.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            Next

        Catch ex As System.Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, LOOKUP_CondtionalTraceSetting)
        End Try

    End Sub
    Public Sub RESET_DATAGRIDVIEW1_frmMain_Set_Labels_And_Recreate_Datatable()
        Dim ptw As New pt_WinForm_frmMain
        Dim ptd As New pt_Data_BuildDgvDataTables

        ptw.SETFORM_frmMain_SwapControlsDependingOnToggle()
        ptd.CREATE_LimitedPeriodsDataTable()

    End Sub
    Public Sub UPDATE_Datagridview1_Cell_Value_to_Database()


        Try

            Dim ee As DataGridViewCellEventArgs
            Dim sender2 As Object

            frmMain.UpdateDataGridview1CellToDatabase(sender2, ee)

        Catch ex As System.Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, LOOKUP_CondtionalTraceSetting)
        End Try


    End Sub
End Class
