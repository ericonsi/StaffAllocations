Imports Staff_Allocations_MiddleTier.mt_LookUps
Public Class frmExtras
    Private Sub TblExtrasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblExtrasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Staff_AllocationsDataSet)

    End Sub

    Private Sub frmExtras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TblExtrasTableAdapter.Fill(Me.Staff_AllocationsDataSet.tblExtras)

    End Sub

    Private Sub DOUBLECLICK_ON_SELECTION_Extras_DatagridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Extras_DatagridView.CellDoubleClick
        Try

            Dim Retrieve_Extra_Type As String = Me.Extras_DatagridView.Rows(e.RowIndex).Cells("Extra_Type").Value
            Dim Retrieve_Extra_Name As String = Me.Extras_DatagridView.Rows(e.RowIndex).Cells("Extra_Name").Value

            Select Case Retrieve_Extra_Type
                Case "Form"

                    Dim sFull_form_name_including_assembly As String = "Staff_Allocations." & Retrieve_Extra_Name
                    GetFormByName(sFull_form_name_including_assembly).Show()

                Case "Function"

                    Dim TCls As New EXTRA_CALLABLE_FUNCTIONS
                    CallByName(TCls, Retrieve_Extra_Name, CallType.Method)
                    TCls = Nothing

            End Select

        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, LOOKUP_CondtionalTraceSetting)
        End Try

    End Sub
    Private Function GetFormByName(ByVal FormName As String) As Form
        Try

            Dim T As Type = Type.GetType(FormName, True, True)
            Return CType(Activator.CreateInstance(T), Form)

        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, LOOKUP_CondtionalTraceSetting)
        End Try

    End Function
    Private Class EXTRA_CALLABLE_FUNCTIONS

        Public Sub Decrease_the_toolstrip_font_size()
            Try

                Dim ptw As New Staff_Allocations.pt_WinForm_frmMain
                ptw.CHANGE_DISPLAY_frmMain_Reduce_Toolstrip_Font_Size()

            Catch ex As Exception
                Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
                HandleStandardException.HANDLE_EXCEPTION(ex, LOOKUP_CondtionalTraceSetting)
            End Try

        End Sub

    End Class
End Class