Imports Staff_Allocations_MiddleTier.mt_Exceptions.Exception_Messages
Imports Staff_Allocations_MiddleTier.mt_Exceptions.Traces
Imports Staff_Allocations_MiddleTier.mt_LookUps
Imports EH_DataUtilities.GeneralDataFunctions
Public Class frmAdmin
    Private Sub TblSettingsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblSettingsBindingNavigatorSaveItem.Click
        Try

            Me.Validate()
            Me.TblSettingsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Staff_AllocationsDataSet)

        Catch ex As Exception
            MessageBox.Show(EXCEPTION_MESSAGE_Standard() & ex.Message)
            LOG_Exception(ex, ex.ToString, True)
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Me.TblSettingsTableAdapter.Fill(Me.Staff_AllocationsDataSet.tblSettings)

        Catch ex As Exception
            MessageBox.Show(EXCEPTION_MESSAGE_Standard() & ex.Message)
            LOG_Exception(ex, ex.ToString, True)

        End Try

    End Sub
End Class