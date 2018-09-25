Imports System.Windows
Imports System.Windows.Forms
Imports Staff_Allocations_MiddleTier.mt_LookUps
Imports Staff_Allocations.pt_RetrievePresentationVariables
Imports Staff_Allocations.Staff_AllocationsDataSet
Imports Staff_Allocations_MiddleTier.mt_Exceptions.Exception_Messages
Imports Staff_Allocations_MiddleTier.mt_Exceptions.Traces
Imports Staff_Allocations_MiddleTier.mt_Validation
Public Class pt_WinForm_Functions
    Private WithEvents EH_TraceIT As Staff_Allocations_MiddleTier.mt_Exceptions.Traces
    Public Sub New()

        Dim VALIDATION As New Staff_Allocations_MiddleTier.mt_Validation
        EH_TraceIT = New Staff_Allocations_MiddleTier.mt_Exceptions.Traces

    End Sub
    Public Sub SwapMainControls()

        Try

            Dim EHW As New Staff_Allocations_MiddleTier.mt_Winforms_Utilities.mt_Controls

            Dim StaffvsProgram As String = RETRIEVE_Toggle()
            Dim bsProg As BindingSource = frmMain.TblProgramsComboBox.DataSource
            Dim bsStaff As BindingSource = frmMain.TblStaffComboBox.DataSource

            EHW.Swapper(frmMain.lblStaff, "Text", StaffvsProgram = "Staff", "Staff", "Program")
            EHW.Swapper(frmMain.lblStaff, "Text", StaffvsProgram = "Staff", "Staff", "Program")
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
            MessageBox.Show(EXCEPTION_MESSAGE_Standard() & ex.Message)
            EH_TraceIT.EH_WindowsTraceLogMessage(ex, ex.ToString, LOOKUP_TraceFileLocation, LOOKUP_System_User, LOOKUP_RunConditionalTrace)
        End Try

    End Sub
    Public Sub SETFORM__CrosstabColumnUnits_SetControls(obj As Staff_Allocations_MiddleTier.mt_ICrosstabColumnUnits)

        frmMain.lblMonth.Text = obj.lblColumnUnitText
        frmMain.Button1.Text = obj.SeeAllButtonText
        frmMain.cmbLegMonth.DisplayMember = obj.cmbColumnUnitDisplayMember
        frmMain.cmbLegMonth.ValueMember = obj.cmbColumnValueMember

    End Sub
    Public Sub SETFORM_frmMain_Style(f As Form, ehs As EH_Winforms_Utilities.EH_IStyles)

        Dim ehw As New EH_Winforms_Utilities.EH_StyleSheets.EH_SetStyle
        ehw.SetStyle(f, ehs)

    End Sub
End Class
