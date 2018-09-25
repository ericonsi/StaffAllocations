Imports EH_DataUtilities
Imports EH_DataUtilities.GeneralDataFunctions
Imports Staff_Allocations_MiddleTier.mt_LookUps
Imports System.Windows.Forms
Imports Staff_Allocations_MiddleTier.mt_Exceptions.Exception_Messages
Imports Staff_Allocations_MiddleTier.mt_Exceptions.mt_Routines
Imports Staff_Allocations_MiddleTier.mt_Exceptions.Traces
Namespace mt_Exceptions
    Public Class Exception_Messages
        Public Shared Function EXCEPTION_MESSAGE_InvalidCastException() As String

            Return "The data you entered isn't valid. You can only enter numbers here, without any letters or" & _
                        " characters.  Correct the entry or" & _
                        " delete it."
        End Function
        Public Shared Function EXCEPTION_MESSAGE_Concurrency() As String

            Return "Someone else is trying to edit this record.  Exit out and try again."

        End Function
        Public Shared Function EXCEPTION_MESSAGE_Standard() As String

            Return "There's been an error of some kind.  You may be able to correct it by hitting the escape key.  If the error persists, inform your DB administrator."

        End Function
        Public Shared Function EXCEPTION_MESSAGE_ProblemInDatagridview1() As String

            Return "Exception raised in Datagridview1.dataerror.  Possible problem: "

        End Function
        Public Shared Function EXCEPTION_MESSAGE_Global() As String

            Return "There is a problem with this application.  It's probably nothing serious.  However, the application is going to shut down.  A copy of the error is being sent to a file where your DB Administrator can examine it." & _
                "  Please inform your DB Administrator:" & Environment.NewLine & Environment.NewLine

        End Function
    End Class
    Public Class Traces
        Inherits EH_ExceptionTrapping.TraceDebugMethods
        Public Shared Sub LOG_Exception(e As Exception, sMessage As String, b As Boolean)

            Dim x As New EH_ExceptionTrapping.TraceDebugMethods

            x.EH_WindowsTraceLogMessage(e, sMessage, LOOKUP_TraceFileLocation, LOOKUP_System_User, b)

        End Sub
    End Class
    Public Class mt_Routines
        Public Sub HANDLE_EXCEPTION_Standard(ex As Exception)

            MessageBox.Show(EXCEPTION_MESSAGE_Standard() & Environment.NewLine & Environment.NewLine & ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            LOG_Exception(ex, ex.ToString, True)

        End Sub
        Public Sub HANDLE_EXCEPTION_Concurrency(ex As Exception)

            MessageBox.Show(EXCEPTION_MESSAGE_Concurrency() & ": " & ex.Message)
            LOG_Exception(ex, ex.ToString, True)

        End Sub
        Public Sub HANDLE_EXCEPTION_InvalidCast(ex As Exception)

            MessageBox.Show(EXCEPTION_MESSAGE_InvalidCastException() & Environment.NewLine & Environment.NewLine & ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            LOG_Exception(ex, ex.ToString, True)

        End Sub
        Public Sub HANDLE_EXCEPTION_InvalidCastInDataError(e As DataGridViewDataErrorEventArgs, sender As Object)

            MessageBox.Show(EXCEPTION_MESSAGE_InvalidCastException(), "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            LOG_Exception(e.Exception, e.Context & "  " & EXCEPTION_MESSAGE_ProblemInDatagridview1() & _
                          "InvalidCast --- " & e.Exception.ToString & ">< " & sender.ToString, LOOKUP_RunConditionalTrace)

        End Sub
        Public Sub HANDLE_EXCEPTION_FormCloseInDataError(e As DataGridViewDataErrorEventArgs, sender As Object)

            MessageBox.Show("Theres been an error. Hit the escape key and try again.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            LOG_Exception(e.Exception, e.Context & "  " & EXCEPTION_MESSAGE_ProblemInDatagridview1() & "Closing Form on InvalidCast --- " & e.Exception.ToString & ">< " & sender.ToString, LOOKUP_RunConditionalTrace)
        End Sub
    End Class
End Namespace