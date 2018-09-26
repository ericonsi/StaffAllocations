Imports System.Data
Imports System.Windows.Forms
Imports Staff_Allocations.pt_RetrievePresentationVariables
Imports Staff_Allocations_MiddleTier.mt_LookUps
Public Class frmEditDropdown
    Dim DataSourceForDGVEditDropDowns As BindingSource
    Dim mtw_dgv As New Staff_Allocations_MiddleTier.mt_Winforms_Utilities.mt_DataGridViewFunctions
    Private edd As pt_Data_EditDropDowns.IDropDownEditor
    Dim oldValue As String
    Dim newValue As String
    Public Sub New(idd As pt_Data_EditDropDowns.IDropDownEditor)
        InitializeComponent()

        edd = idd
        Me.dgvEditDropDowns.Columns.Clear()

        edd.frm = Me
        edd.ASSIGN_BindingSource_To_DGV(dgvEditDropDowns)
        edd.ADD_Columns()

    End Sub

    Private Sub frmEditDropDowns_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TblDropDownsForDepartmentHeadsTableAdapter.Fill(Me.Staff_AllocationsDataSet.tblDropDownsForDepartmentHeads)
        Me.TblDepartmentDetailsTableAdapter.Fill(Me.Staff_AllocationsDataSet.tblDepartmentDetails)
        Me.TblProgramNameDetailsTableAdapter.Fill(Me.Staff_AllocationsDataSet.tblProgramNameDetails)
        Me.TblDropDownsForSitesTableAdapter.Fill(Me.Staff_AllocationsDataSet.tblDropDownsForSites)

    End Sub
    Private Sub Save()

        Me.Validate()
        Me.TblDropDownsForSitesBindingSource.EndEdit()
        Me.TblProgramNameDetailsBindingSource.EndEdit()
        Me.TblDepartmentDetailsBindingSource.EndEdit()
        Me.TblDropDownsForDepartmentHeadsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Staff_AllocationsDataSet)


    End Sub

    Private Sub frmEditDropDown_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Save()

    End Sub

    Private Sub dgvEditDropDowns_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgvEditDropDowns.CellValidating

        If IsDBNull(dgvEditDropDowns(e.ColumnIndex, e.RowIndex).Value) Then
            oldValue = ""
        Else
            oldValue = dgvEditDropDowns(e.ColumnIndex, e.RowIndex).Value
        End If

            If IsDBNull(e.FormattedValue) Then
            e.Cancel = True
            Exit Sub
        Else
            newValue = e.FormattedValue
        End If

    End Sub

    Private Sub dgvEditDropDowns_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEditDropDowns.CellValidated
        If dgvEditDropDowns.Columns(e.ColumnIndex).Name = edd.DropDownTableColumn Then

            If oldValue <> newValue Then
                edd.UpdateOriginalTableWhenDropdownChanges(newValue, oldValue)
            End If

        End If

    End Sub
    Private Sub dgvEditDropDowns_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvEditDropDowns.DataError
        Try

            Dim mtw As New Staff_Allocations_MiddleTier.mt_Winforms_Utilities.mt_DataGridViewFunctions
            mtw.Standard_DataGridView_ErrorHandling(e, sender)

        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, LOOKUP_CondtionalTraceSetting)
        End Try

    End Sub

End Class