Imports Staff_Allocations_MiddleTier.mt_LookUps
Imports System.Windows.Forms
Namespace My

    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.

    Partial Friend Class MyApplication
        Private Sub MyApplication_Startup(sender As Object, e As ApplicationServices.StartupEventArgs) Handles Me.Startup

            Dim StandardTrace As EH_ExceptionTrapping.EH_Exceptions.Exception_Loggers.StandardTrace = EH_ExceptionTrapping.EH_Exceptions.Exception_Loggers.StandardTrace.GetStandardTrace
            StandardTrace.INITIALIZE_Logger(LOOKUP_TraceFileLocation, LOOKUP_System_User)

        End Sub
        Private Sub MyApplication_UnhandledException(sender As Object, e As ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            Dim HandleGlobalException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.GlobalHandler
            HandleGlobalException.HANDLE_EXCEPTION(e.Exception, True, "", "***APPLICATION SHUTDOWN***")
            e.ExitApplication = True
        End Sub
    End Class

End Namespace

