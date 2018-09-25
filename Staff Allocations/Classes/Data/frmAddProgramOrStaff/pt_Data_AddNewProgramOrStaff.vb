Imports Staff_Allocations_MiddleTier.mt_LookUps
Public Class pt_Data_AddNewProgramOrStaff
    Public Sub SET_Defaults(dgv As DataGridView, sToggle As String)

        Dim CSS As New Staff_Allocations_MiddleTier.mt_Winforms_Utilities.mt_DataGridViewFunctions

        Try

            If sToggle = "Staff" Then
                If IsDBNull(dgv.CurrentRow.Cells("Active").Value) Then dgv.CurrentRow.Cells("Active").Value = 1
                If IsDBNull(dgv.CurrentRow.Cells("Site").Value) Then dgv.CurrentRow.Cells("Site").Value = "To Be Determined"
                If IsDBNull(dgv.CurrentRow.Cells("PercentOfFT").Value) Then dgv.CurrentRow.Cells("PercentOfFT").Value = 100
            ElseIf sToggle = "Program" Then
                If IsDBNull(dgv.CurrentRow.Cells("Active").Value) Then dgv.CurrentRow.Cells("Active").Value = 1
            End If


        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, LOOKUP_CondtionalTraceSetting)

        End Try

    End Sub
End Class
