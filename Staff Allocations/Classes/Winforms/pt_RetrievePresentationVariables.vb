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
            LOG_Exception(ex, ex.ToString, True)
        End Try

    End Function
    Public Shared Function RETRIEVE_AddProgramOrStaff_Toggle(frm As frmAddProgramOrStaff) As String
        Try
            If frm.radProgram.Checked Then
                Return "Program"
            ElseIf frm.radStaff.Checked Then
                Return "Staff"
            Else MessageBox.Show("Program button is: " & frmAddProgramOrStaff.radProgram.Checked & ":" & frmAddProgramOrStaff.radStaff.Checked)
            End If

        Catch ex As Exception
            MessageBox.Show(EXCEPTION_MESSAGE_Standard() & ex.Message)
            LOG_Exception(ex, ex.ToString, True)
        End Try

    End Function
    Public Shared Function RETRIEVE_Toggle_Value() As String

        Try

            Return frmMain.cmbStaffOrPrograms.Text

        Catch ex As Exception
            MessageBox.Show(EXCEPTION_MESSAGE_Standard() & ex.Message)
            LOG_Exception(ex, ex.ToString, True)
        End Try

    End Function
    Public Shared Function RETRIEVE_Ord() As Integer

        Try

            Return frmMain.cmbLegMonth.SelectedValue

        Catch ex As Exception
            MessageBox.Show(EXCEPTION_MESSAGE_Standard() & ex.Message)
            LOG_Exception(ex, ex.ToString, True)
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
            LOG_Exception(ex, ex.ToString, True)
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
            LOG_Exception(ex, ex.ToString, True)
        End Try

    End Function
    Public Shared Function RETRIEVE_StaffOrProgramID() As Integer

        Try
            Return frmMain.cmbStaffOrPrograms.SelectedValue

        Catch ex As Exception
            MessageBox.Show(EXCEPTION_MESSAGE_Standard() & ex.Message)
            LOG_Exception(ex, ex.ToString, True)
        End Try

    End Function
    Public Shared Function RETRIEVE_AddCombo_StaffOrProgram() As String

        Try

            Return frmMain.cmbAdd.Text

        Catch ex As Exception
            MessageBox.Show(EXCEPTION_MESSAGE_Standard() & ex.Message)
            LOG_Exception(ex, ex.ToString, True)
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
    Public Shared Function RETRIEVE_Datgridview1CurrentCell() As Decimal

        Return frmMain.DataGridView1.CurrentCell.Value

    End Function
    Public Shared Function RETRIEVE_MonthOrdinalofToday() As Integer

        Dim MonthsSinceJan04 As Long
        MonthsSinceJan04 = DateDiff(DateInterval.Month, #1/1/2014#, Now) + 1

        Return MonthsSinceJan04

    End Function
End Class
