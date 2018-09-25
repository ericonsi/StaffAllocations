Imports System.Data
Imports System.Windows.Forms
Imports EH_DataUtilities.EH_LookUp
Public Class mt_LookUps
    Inherits EH_DataUtilities.EH_LookUp

    'These functions derive functionality from EH_lookup in EH_DataUtilities.  Standard lookup always return a string 
    '   so convert if an integer is to be returned (e.g. dim i as integer = ctype(standard_lookup(a,a,a,a) as integer/Return i)

    Public Shared Function LOOKUP_Date_From_DateOrd(iOrd As Integer) As String
        Try

            Return Standard_Lookup("Date_Ordinal", "LegDate", "LegMonth", iOrd)

        Catch ex As Exception
            Dim mter As New Staff_Allocations_MiddleTier.mt_Exceptions.mt_Routines
            mter.HANDLE_EXCEPTION_Standard(ex)
        End Try

    End Function
    Public Shared Function LOOKUP_ProgramID_From_ProgramName(sProgramName As String) As Integer

            Dim i As Integer = CType(Standard_Lookup("Program", "ProgramID", "tblPrograms", sProgramName), Integer)
            Return i

    End Function
    Public Shared Function LOOKUP_StaffID_From_StaffName(sStaffName As String) As Integer

            Dim i As Integer = CType(Standard_Lookup("Staff", "StaffID", "tblStaff", sStaffName), Integer)
            Return i


    End Function
    Public Shared Function LOOKUP_DateID_From_DateOrd(iOrd As Integer) As Integer

        Try

            Dim i As Integer = CType(Standard_Lookup("Date_Ordinal", "DateID", "LegMonth", iOrd), Integer)
            Return i

        Catch ex As Exception
            Dim mter As New Staff_Allocations_MiddleTier.mt_Exceptions.mt_Routines
            mter.HANDLE_EXCEPTION_Standard(ex)
        End Try

    End Function
    Public Shared Function LOOKUP_Min_DateOrd() As Integer
        Try

            Return Min_Lookup("Date_Ordinal", "tblMonths")

        Catch ex As Exception
            Dim mter As New Staff_Allocations_MiddleTier.mt_Exceptions.mt_Routines
            mter.HANDLE_EXCEPTION_Standard(ex)
        End Try

    End Function
    Public Shared Function LOOKUP_Max_DateOrd() As Integer

        Try

            Return Max_Lookup("Date_Ordinal", "tblMonths")

        Catch ex As Exception
            Dim mter As New Staff_Allocations_MiddleTier.mt_Exceptions.mt_Routines
            mter.HANDLE_EXCEPTION_Standard(ex)
        End Try

    End Function
    Public Shared Function LOOKUP_ReportServerUrl() As String

        Try

            Return Standard_Lookup("Setting_Type", "Setting", "tblSettings", "Report_Server_URL")

        Catch ex As Exception
            Dim mter As New Staff_Allocations_MiddleTier.mt_Exceptions.mt_Routines
            mter.HANDLE_EXCEPTION_Standard(ex)
        End Try

    End Function
    Public Shared Function LOOKUP_PasswordForDeletingStaffOrProgramFromList() As String

        Try

            Return Standard_Lookup("Setting_Type", "Setting", "tblSettings", "DeletePassword")

        Catch ex As Exception
            Dim mter As New Staff_Allocations_MiddleTier.mt_Exceptions.mt_Routines
            mter.HANDLE_EXCEPTION_Standard(ex)
        End Try

    End Function
    Public Shared Function LOOKUP_RunConditionalTrace() As Boolean

        Try
            Return Convert.ToBoolean(Standard_Lookup("Setting_Type", "Setting", "tblSettings", "RunConditionalTrace"))
        Catch ex As Exception
            Dim mter As New Staff_Allocations_MiddleTier.mt_Exceptions.mt_Routines
            mter.HANDLE_EXCEPTION_Standard(ex)
        End Try

    End Function
    Public Shared Function LOOKUP_CrosstabColumnUnits() As String

        Return Standard_Lookup("Setting_Type", "Setting", "tblSettings", "CrosstabColumnUnits")
 
    End Function
    Public Shared Function LOOKUP_CrosstabStyleInterfaceImplementation()

        Dim s As String
        s = LOOKUP_CrosstabColumnUnits()

        If s = "Months" Then
            Dim ccu As New Staff_Allocations_MiddleTier.mt_Winforms_Utilities.mt_CrosstabColumnUnits.mt_Months
            Return ccu
        ElseIf s = "Pay Periods" Then
            Dim ccu As New Staff_Allocations_MiddleTier.mt_Winforms_Utilities.mt_CrosstabColumnUnits.mt_PayPeriods
            Return ccu
        ElseIf s = "OtherValues" Then
            Dim ccu As New Staff_Allocations_MiddleTier.mt_Winforms_Utilities.mt_CrosstabColumnUnits.mt_OtherValues
            Return ccu
        ElseIf s = "Years" Then
            Dim ccu As New Staff_Allocations_MiddleTier.mt_Winforms_Utilities.mt_CrosstabColumnUnits.mt_Years
            Return ccu
        Else
            Throw New System.Exception("You have not properly set the CrosstabColumnUnits setting.")
            Application.Exit()
        End If
    End Function
    Public Shared Function LOOKUP_frmMainStyleInterfaceImplementation() As String

        Return Standard_Lookup("Setting_Type", "Setting", "tblSettings", "FormStyle")

    End Function
    Public Shared Function LOOKUP_AdminPassword() As String

        Try
            Return Standard_Lookup("Setting_Type", "Setting", "tblSettings", "Password")

        Catch ex As Exception
            Dim HandleStandardError As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardError.HANDLE_EXCEPTION(ex, LOOKUP_CondtionalTraceSetting)

        End Try

    End Function
    Public Shared Function LOOKUP_frmAddProgramOrStaff_SiteComboSource() As DataTable
        Try
            Dim dt As DataTable
            Dim ehq As New EH_DataUtilities.EH_QueryBuilder

            ehq.ADD_TO_SELECT("Entry")
            ehq.ASSIGN_FROM_STATEMENT("tbldropdownsforsites")
            ehq.ADD_TO_ORDERBY("Entry")
            dt = ehq.ATTACH_TO_DATATABLE
            Return dt

        Catch ex As Exception
            Dim HandleStandardError As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardError.HANDLE_EXCEPTION(ex, LOOKUP_CondtionalTraceSetting)

        End Try

    End Function
    Public Shared Function LOOKUP_frmAddProgramOrStaff_ProgramComboSource() As DataTable
        Try
            Dim dt As DataTable
            Dim ehq As New EH_DataUtilities.EH_QueryBuilder

            ehq.ADD_TO_SELECT("ProgramName")
            ehq.ASSIGN_FROM_STATEMENT("tblProgramNameDetails")
            ehq.ADD_TO_ORDERBY("ProgramName")
            dt = ehq.ATTACH_TO_DATATABLE
            Return dt

        Catch ex As Exception
            Dim HandleStandardError As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardError.HANDLE_EXCEPTION(ex, LOOKUP_CondtionalTraceSetting)

        End Try

    End Function
    Public Shared Function LOOKUP_frmAddProgramOrStaff_DepartmentComboSource() As DataTable
        Try
            Dim dt As DataTable
            Dim ehq As New EH_DataUtilities.EH_QueryBuilder

            ehq.ADD_TO_SELECT("Department")
            ehq.ASSIGN_FROM_STATEMENT("tblDepartmentDetails")
            ehq.ADD_TO_ORDERBY("Department")
            dt = ehq.ATTACH_TO_DATATABLE
            Return dt

        Catch ex As Exception
            Dim HandleStandardError As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardError.HANDLE_EXCEPTION(ex, LOOKUP_CondtionalTraceSetting)

        End Try

    End Function
    Public Shared Function LOOKUP_frmAddProgramOrStaff_ADD_Datagridview_Source() As DataTable
        Try
            Dim dt As DataTable
            Dim ehq As New EH_DataUtilities.EH_QueryBuilder

            ehq.ADD_TO_SELECT("StaffID, Active, LastName, FirstName, Middle, Site, GL_Code, Salary, JobTitle, Comments")
            ehq.ASSIGN_FROM_STATEMENT("tblStaff")
            ehq.ADD_TO_ORDERBY("LastName")
            ehq.ADD_TO_ORDERBY("FirstName")
            ehq.ADD_TO_ORDERBY("Middle")
            ehq.ADD_TO_WHERE("LastName is not null")
            dt = ehq.ATTACH_TO_DATATABLE
            Return dt

        Catch ex As Exception
            Dim HandleStandardError As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardError.HANDLE_EXCEPTION(ex, LOOKUP_CondtionalTraceSetting)

        End Try

    End Function
End Class
