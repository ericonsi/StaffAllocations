Imports Staff_Allocations_MiddleTier.mt_Exceptions.Exception_Messages
Imports Staff_Allocations_MiddleTier.mt_Exceptions.Traces
Imports Staff_Allocations_MiddleTier.mt_LookUps
Public Class pt_RetrievePresentationVariables
    Public Shared Function RETRIEVE_Toggle() As String
        Try
            If frmMain.radProgram.Checked Then
                Return "Program"
            Else
                Return "Staff"
            End If

        Catch ex As Exception
            MessageBox.Show(EXCEPTION_MESSAGE_Standard() & ex.Message)
            EH_TraceIt1(ex, ex.ToString, LOOKUP_RunConditionalTrace)
        End Try

    End Function
    Public Shared Function RETRIEVE_Toggle_Value() As String

        Try

            Return frmMain.cmbStaffOrPrograms.Text

        Catch ex As Exception
            MessageBox.Show(EXCEPTION_MESSAGE_Standard() & ex.Message)
            EH_TraceIt1(ex, ex.ToString, LOOKUP_RunConditionalTrace)
        End Try

    End Function
    Public Shared Function RETRIEVE_Ord() As Integer

        Try

            Return frmMain.cmbLegMonth.SelectedValue

        Catch ex As Exception
            MessageBox.Show(EXCEPTION_MESSAGE_Standard() & ex.Message)
            EH_TraceIt1(ex, ex.ToString, LOOKUP_RunConditionalTrace)
        End Try

    End Function
    Public Shared Function RETRIEVE_Comments() As String

        Try

            If RETRIEVE_Toggle() = "Staff" Then

                Return frmMain.rtbStaffComments.Text
            Else
                Return frmMain.rtbProgramComments.Text
            End If

        Catch ex As Exception
            MessageBox.Show(EXCEPTION_MESSAGE_Standard() & ex.Message)
            EH_TraceIt1(ex, ex.ToString, LOOKUP_RunConditionalTrace)
        End Try

    End Function
    Public Shared Function RETRIEVE_Other_Toggle() As String

        Try
            If RETRIEVE_Toggle() = "Staff" Then
                Return "Program"
            Else
                Return "Staff"

            End If

        Catch ex As Exception
            MessageBox.Show(EXCEPTION_MESSAGE_Standard() & ex.Message)
            EH_TraceIt1(ex, ex.ToString, LOOKUP_RunConditionalTrace)
        End Try

    End Function
    Public Shared Function RETRIEVE_StaffOrProgramID() As Integer

        Try
            Return frmMain.cmbStaffOrPrograms.SelectedValue

        Catch ex As Exception
            MessageBox.Show(EXCEPTION_MESSAGE_Standard() & ex.Message)
            EH_TraceIt1(ex, ex.ToString, LOOKUP_RunConditionalTrace)
        End Try

    End Function
    Public Shared Function RETRIEVE_AddCombo_StaffOrProgram() As String

        Try

            Return frmMain.cmbAdd.Text

        Catch ex As Exception
            MessageBox.Show(EXCEPTION_MESSAGE_Standard() & ex.Message)
            EH_TraceIt1(ex, ex.ToString, LOOKUP_RunConditionalTrace)
        End Try

    End Function
    Public Shared Function RETRIEVE_SeeAllMonths_Mode() As Boolean

        Dim i As Integer = LOOKUP_Max_DateOrd() - LOOKUP_Min_DateOrd() + 2
        If frmMain.DataGridView1.ColumnCount = i Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
