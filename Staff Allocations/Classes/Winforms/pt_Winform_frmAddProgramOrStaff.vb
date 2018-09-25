Imports Staff_Allocations_MiddleTier.mt_LookUps

Public Class pt_Winform_frmAddProgramOrStaff
    Public Sub SETFORM_frmAddProgramOrStaff(Toggle As String, frm As frmAddProgramOrStaff)

        SETFORM_frmAddProgramOrStaff_SwapControlsDependingOnToggle(Toggle, frm)
        SETFORM_frmAddProgramOrStaff_PrepareDatagridviewColumns(Toggle, frm)

    End Sub
    Private Sub SETFORM_frmAddProgramOrStaff_SwapControlsDependingOnToggle(Toggle As String, frm As frmAddProgramOrStaff)
        Try
            Dim EHW As New Staff_Allocations_MiddleTier.mt_Winforms_Utilities.mt_Controls

            Dim StaffvsProgram As String = Toggle
            Dim bsProg As BindingSource = frm.TblProgramsDataGridView.DataSource
            Dim bsStaff As BindingSource = frm.TblStaffDataGridView.DataSource

            EHW.Swapper(frm.GroupBox1, "BackColor", StaffvsProgram = "Staff", Color.LightSalmon, Color.PowderBlue)
            EHW.Swapper(frm, "BackColor", StaffvsProgram = "Staff", Color.LightSalmon, Color.PowderBlue)
            EHW.Swapper(frm.Add_Datagridview, "DataSource", StaffvsProgram = "Staff", bsStaff, bsProg)
            EHW.Swapper(frm.radProgram, "BackColor", StaffvsProgram = "Staff", Color.LightSalmon, Color.PowderBlue)
            EHW.Swapper(frm.radStaff, "BackColor", StaffvsProgram = "Staff", Color.LightSalmon, Color.PowderBlue)
            EHW.Swapper(frm.bnBindingNavigator, "BindingSource", StaffvsProgram = "Staff", bsStaff, bsProg)
            EHW.Swapper(frm.btnAddNewProgramName, "Visible", StaffvsProgram = "Staff", False, True)
            EHW.Swapper(frm.btnAddNewDepartment, "Visible", StaffvsProgram = "Staff", False, True)
            EHW.Swapper(frm.btnAddNewSite, "Visible", StaffvsProgram = "Staff", True, False)

        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, LOOKUP_CondtionalTraceSetting)

        End Try
    End Sub
    Private Sub SETFORM_frmAddProgramOrStaff_PrepareDatagridviewColumns(Toggle As String, frm As frmAddProgramOrStaff)

        Dim CSS As New Staff_Allocations_MiddleTier.mt_Winforms_Utilities.mt_DataGridViewFunctions

        Try
            'If frm.Add_Datagridview.ColumnCount > 0 Then
            If Toggle = "Staff" Then


                RemoveAllColumns(frm.Add_Datagridview)

                CSS.Column_Textbox_Add(frm.Add_Datagridview, False, "StaffID", "StaffID", "StaffID", 75)
                CSS.Column_CheckBox_Add(frm.Add_Datagridview, True, "Active", "Active", "Active", 75, False)
                CSS.Column_Textbox_Add(frm.Add_Datagridview, True, "LastName", "Last Name", "LastName")
                CSS.Column_Textbox_Add(frm.Add_Datagridview, True, "FirstName", "First Name", "FirstName")
                CSS.Column_Textbox_Add(frm.Add_Datagridview, True, "Middle", "Middle", "Middle", 50)
                CSS.Column_Textbox_Add(frm.Add_Datagridview, True, "PercentOfFT", "Percent of FT", "PercentOfFT")
                CSS.Column_ComboBox_Add(frm.Add_Datagridview, True, "Site", "Site", "Site", 100, LOOKUP_frmAddProgramOrStaff_SiteComboSource, "Entry", "Entry")
                CSS.Column_Textbox_Add(frm.Add_Datagridview, True, "GL_Code", "GL Code", "GL_Code")
                CSS.Column_Textbox_Add(frm.Add_Datagridview, True, "Salary", "Salary", "Salary")
                CSS.Column_Textbox_Add(frm.Add_Datagridview, True, "JobTitle", "Job Title", "JobTitle")
                CSS.Column_Textbox_Add(frm.Add_Datagridview, True, "Comments", "Comments", "Comments", 300)

                'Not clear why this is needed since the add method sets visibility to false.
                frm.Add_Datagridview.Columns("StaffID").Visible = False

            Else

                RemoveAllColumns(frm.Add_Datagridview)

                CSS.Column_Textbox_Add(frm.Add_Datagridview, False, "ProgramID", "ProgramID", "ProgramID", 75)
                CSS.Column_CheckBox_Add(frm.Add_Datagridview, True, "Active", "Active", "Active", 75, False)
                CSS.Column_ComboBox_Add(frm.Add_Datagridview, True, "ProgramName", "Funder", "ProgramName", 100, LOOKUP_frmAddProgramOrStaff_ProgramComboSource, "ProgramName", "ProgramName")
                CSS.Column_ComboBox_Add(frm.Add_Datagridview, True, "Department", "Grant", "Department", 100, LOOKUP_frmAddProgramOrStaff_DepartmentComboSource, "Department", "Department")
                CSS.Column_Textbox_Add(frm.Add_Datagridview, True, "Comments", "Comments", "Comments", 300)

                'Not clear why this is needed since the add method sets visibility to false.
                frm.Add_Datagridview.Columns("ProgramID").Visible = False

            End If
            'End If

        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, LOOKUP_CondtionalTraceSetting)

        End Try

    End Sub

    Private Sub RemoveAllColumns(dgv As DataGridView)
        dgv.Columns.Clear()
    End Sub
End Class
