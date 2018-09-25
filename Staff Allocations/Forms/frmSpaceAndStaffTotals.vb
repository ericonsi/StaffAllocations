Imports Staff_Allocations_MiddleTier.mt_LookUps
Public Class frmSpaceAndStaffTotals
    Private Sub TblSpaceAndStaffTotalsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblSpaceAndStaffTotalsBindingNavigatorSaveItem.Click
        AUTO_SAVE()
    End Sub

    Private Sub frmSpaceAndStaffTotals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Staff_AllocationsDataSet.tblSpaceAndStaffTotals' table. You can move, or remove it, as needed.
        Me.TblSpaceAndStaffTotalsTableAdapter.Fill(Me.Staff_AllocationsDataSet.tblSpaceAndStaffTotals)

    End Sub

    Private Sub AUTO_SAVE()

        Try
            Me.Validate()
            Me.TblSpaceAndStaffTotalsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Staff_AllocationsDataSet)

        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, LOOKUP_CondtionalTraceSetting)
        End Try

    End Sub

    Private Sub frmSpaceAndStaffTotals_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        AUTO_SAVE()

    End Sub

    Private Sub TblSpaceAndStaffTotalsDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles TblSpaceAndStaffTotalsDataGridView.DataError

        Dim mtw As New Staff_Allocations_MiddleTier.mt_Winforms_Utilities.mt_DataGridViewFunctions
        mtw.Standard_DataGridView_ErrorHandling(e, sender)

    End Sub
End Class