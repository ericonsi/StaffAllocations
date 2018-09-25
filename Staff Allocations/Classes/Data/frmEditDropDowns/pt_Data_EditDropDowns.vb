Imports System.Windows.Forms
Namespace pt_Data_EditDropDowns
    'xxxxxxxxxxxxxxxxxxxxxxxxx
    Public Interface IDropDownEditor
        Property OriginalTable As String
        Property OriginalColumn As String
        Property DropDownTableColumn As String
        Property mtw_dgv As Staff_Allocations_MiddleTier.mt_Winforms_Utilities.mt_DataGridViewFunctions
        Property frm As frmEditDropdown
        Sub ASSIGN_BindingSource_To_DGV(dgv As DataGridView)
        Sub ADD_Columns()
        Sub UpdateOriginalTableWhenDropdownChanges(newValue As String, oldValue As String)

    End Interface
    'xxxxxxxxxxxxxxxxxxxxxxxxxxxxx
    Public Class DropDownEditors
        Public MustInherit Class DropDownEditior_Abstract
            Implements IDropDownEditor
            Overridable Property OriginalTable As String = "" Implements IDropDownEditor.OriginalTable
            Overridable Property OriginalColumn As String = "" Implements IDropDownEditor.OriginalColumn
            Overridable Property DropdownTableColumn As String = "" Implements IDropDownEditor.DropDownTableColumn
            Overridable Property mtw_dgv As New Staff_Allocations_MiddleTier.mt_Winforms_Utilities.mt_DataGridViewFunctions Implements IDropDownEditor.mtw_dgv
            Overridable Property frm As frmEditDropdown Implements IDropDownEditor.frm
            Public Overridable Sub ASSIGN_BindingSource_To_DGV(dgv As DataGridView) Implements IDropDownEditor.ASSIGN_BindingSource_To_DGV
            End Sub
            Public Overridable Sub ADD_Columns() Implements IDropDownEditor.ADD_Columns
            End Sub
            Public Overridable Sub UpdateOriginalTableWhenDropdownChanges(newValue As String, oldValue As String) Implements IDropDownEditor.UpdateOriginalTableWhenDropdownChanges

                Dim ehq As New EH_DataUtilities.EH_QueryBuilder
                ehq.ASSIGN_FIRST_LINE("UPDATE " & OriginalTable & " SET " & OriginalTable & "." & OriginalColumn & "  = '" & newValue & "'")
                ehq.ADD_TO_WHERE(OriginalTable & "." & OriginalColumn & " = '" & oldValue & "'")
                ehq.EXECUTE_NONQUERY()

            End Sub
        End Class
        '--------------------------------------------
        Public Class DropDownEditor_Sites
            Inherits DropDownEditior_Abstract
            Implements IDropDownEditor

            Overrides Property OriginalTable As String = "tblStaff"
            Overrides Property OriginalColumn As String = "Site"
            Public Overrides Property DropdownTableColumn As String = "Entry"
            Public Overrides Sub ASSIGN_BindingSource_To_DGV(dgv As DataGridView)
                dgv.DataSource = frm.TblDropDownsForSitesBindingSource
            End Sub
            Public Overrides Sub ADD_Columns()
                mtw_dgv.Column_Textbox_Add(frm.dgvEditDropDowns, True, "Entry", "Site", "Entry")
            End Sub

        End Class
        Public Class DropDownEditor_Departments
            Inherits DropDownEditior_Abstract
            Implements IDropDownEditor
            Overrides Property OriginalTable As String = "tblPrograms" Implements IDropDownEditor.OriginalTable
            Overrides Property OriginalColumn As String = "Department" Implements IDropDownEditor.OriginalColumn
            Public Overrides Sub ASSIGN_BindingSource_To_DGV(dgv As DataGridView)
                dgv.DataSource = frm.TblDepartmentDetailsBindingSource
            End Sub
            Public Overrides Sub ADD_Columns()
                mtw_dgv.Column_Textbox_Add(frm.dgvEditDropDowns, True, "Department", "Grant", "Department")
                mtw_dgv.Column_Textbox_Add(frm.dgvEditDropDowns, True, "DepartmentFullName", "Grant Full Name", "DepartmentFullName", 300)
            End Sub
            Public Overrides Sub UpdateOriginalTableWhenDropdownChanges(newValue As String, oldValue As String) Implements IDropDownEditor.UpdateOriginalTableWhenDropdownChanges
            End Sub
        End Class
        Public Class DropDownEditor_ProgramNames
            Inherits DropDownEditior_Abstract
            Implements IDropDownEditor
            Overrides Property OriginalTable As String = "tblPrograms" Implements IDropDownEditor.OriginalTable
            Overrides Property OriginalColumn As String = "ProgramName" Implements IDropDownEditor.OriginalColumn
            Public Overrides Sub ASSIGN_BindingSource_To_DGV(dgv As DataGridView)
                dgv.DataSource = frm.TblProgramNameDetailsBindingSource
            End Sub
            Public Overrides Sub ADD_Columns()
                mtw_dgv.Column_Textbox_Add(frm.dgvEditDropDowns, True, "ProgramName", "Funder", "ProgramName")
                mtw_dgv.Column_Textbox_Add(frm.dgvEditDropDowns, True, "ProgramFullName", "Funder Full Name", "ProgramFullName", 300)
            End Sub
            Public Overrides Sub UpdateOriginalTableWhenDropdownChanges(newValue As String, oldValue As String) Implements IDropDownEditor.UpdateOriginalTableWhenDropdownChanges
            End Sub
        End Class
    End Class
End Namespace
