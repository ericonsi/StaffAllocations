Imports System.Windows
Imports System.Data
Imports System.Windows.Forms
Imports EH_DataUtilities.EH_LookUp
Imports Staff_Allocations_MiddleTier.mt_LookUps
Namespace mt_Winforms_Utilities
    Public Class mt_Controls
        Inherits EH_Winforms_Utilities.Control_Functions
        'Presentation tier uses this class - may add customization later
    End Class
    Public Class mt_Styles
        Inherits EH_Winforms_Utilities.EH_StyleSheets
    End Class
    Public Class mt_DataGridViewFunctions
        Inherits EH_Winforms_Utilities.EH_DatagridViewFunctions

        Public Sub Standard_DataGridView_ErrorHandling(e As DataGridViewDataErrorEventArgs, sender As Object)

            Dim mter As New Staff_Allocations_MiddleTier.mt_Exceptions.mt_Routines
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            Dim HandleInvalidCastException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.InvalidCastHandler

            If (e.Context = 4864) Then
                HandleInvalidCastException.HANDLE_EXCEPTION(e.Exception, LOOKUP_CondtionalTraceSetting)

            ElseIf (e.Context = 2816) Then
                HandleStandardException.HANDLE_EXCEPTION(e.Exception, LOOKUP_CondtionalTraceSetting)

            Else
                HandleStandardException.HANDLE_EXCEPTION(e.Exception, sender)
            End If

            e.ThrowException = False

        End Sub

    End Class
    Public Class mt_CrosstabColumnUnits
        Public Class mt_Months
            Implements mt_ICrosstabColumnUnits

            Public Property cmbColumnUnitDisplayMember As String = "DateConcatenate" _
                Implements mt_ICrosstabColumnUnits.cmbColumnUnitDisplayMember
            Public Property cmbColumnValueMember As String = "Date_Ordinal" _
                Implements mt_ICrosstabColumnUnits.cmbColumnValueMember
            Public Property CrosstabColumnNumber As Integer = 12 _
                Implements mt_ICrosstabColumnUnits.CrosstabColumnNumber
            Public Property lblColumnUnitText As String = "Months:" _
                Implements mt_ICrosstabColumnUnits.lblColumnUnitText
            Public Property SeeAllButtonText As String = "See All Months" _
            Implements mt_ICrosstabColumnUnits.SeeAllButtonText
            Public Property SeeAllButtonText_Alternative As String = "See 12 Months" _
                Implements mt_ICrosstabColumnUnits.SeeAllButtonText_Alternative
            Public Function LOOKUP_CrosstabColumnHeader(i As Integer) As String Implements mt_ICrosstabColumnUnits.LOOKUP_CrosstabColumnHeader

                Return Standard_Lookup("Date_Ordinal", "DateConcatenate", "tblMonths", i)

            End Function
        End Class
        Public Class mt_PayPeriods

            Implements mt_ICrosstabColumnUnits

            Public Property cmbColumnUnitDisplayMember As String = "PayPeriod" _
                Implements mt_ICrosstabColumnUnits.cmbColumnUnitDisplayMember
            Public Property cmbColumnValueMember As String = "Date_Ordinal" _
                Implements mt_ICrosstabColumnUnits.cmbColumnValueMember
            Public Property CrosstabColumnNumber As Integer = 13 _
                Implements mt_ICrosstabColumnUnits.CrosstabColumnNumber
            Public Property lblColumnUnitText As String = "Pay Periods:" _
                Implements mt_ICrosstabColumnUnits.lblColumnUnitText
            Public Property SeeAllButtonText As String = "See All Pay Periods" _
            Implements mt_ICrosstabColumnUnits.SeeAllButtonText
            Public Property SeeAllButtonText_Alternative As String = "See 13 Pay Periods" _
                Implements mt_ICrosstabColumnUnits.SeeAllButtonText_Alternative

            Public Function LOOKUP_CrosstabColumnHeader(i As Integer) As String Implements mt_ICrosstabColumnUnits.LOOKUP_CrosstabColumnHeader

                Dim s As String = Standard_Lookup("Date_Ordinal", "PayPeriod", "tblMonths", i)

                If IsDBNull(s) Or s = "" Then
                    Return ""
                Else
                    s = Left(s, InStr(s, " ") - 1)
                    s = Left(s, Len(s) - 4) & Right(s, 2)
                    Return s
                End If
            End Function

        End Class
        Public Class mt_OtherValues
            Implements mt_ICrosstabColumnUnits

            Public Property cmbColumnUnitDisplayMember As String = "Other_Value" _
                Implements mt_ICrosstabColumnUnits.cmbColumnUnitDisplayMember
            Public Property cmbColumnValueMember As String = "Date_Ordinal" _
                Implements mt_ICrosstabColumnUnits.cmbColumnValueMember
            Public Property CrosstabColumnNumber As Integer = 6 _
                Implements mt_ICrosstabColumnUnits.CrosstabColumnNumber
            Public Property lblColumnUnitText As String = "Other Stuff:" _
                Implements mt_ICrosstabColumnUnits.lblColumnUnitText
            Public Property SeeAllButtonText As String = "See All Periods" _
            Implements mt_ICrosstabColumnUnits.SeeAllButtonText
            Public Property SeeAllButtonText_Alternative As String = "See 6 Periods" _
                Implements mt_ICrosstabColumnUnits.SeeAllButtonText_Alternative

            Public Function LOOKUP_CrosstabColumnHeader(i As Integer) As String Implements mt_ICrosstabColumnUnits.LOOKUP_CrosstabColumnHeader
                Return Standard_Lookup("Date_Ordinal", "Other_Value", "tblMonths", i)
            End Function
        End Class
        Public Class mt_Years
            Implements mt_ICrosstabColumnUnits

            Public Property cmbColumnUnitDisplayMember As String = "sYear" _
                Implements mt_ICrosstabColumnUnits.cmbColumnUnitDisplayMember
            Public Property cmbColumnValueMember As String = "Date_Ordinal" _
                Implements mt_ICrosstabColumnUnits.cmbColumnValueMember
            Public Property CrosstabColumnNumber As Integer = 10 _
                Implements mt_ICrosstabColumnUnits.CrosstabColumnNumber
            Public Property lblColumnUnitText As String = "Years" _
                Implements mt_ICrosstabColumnUnits.lblColumnUnitText
            Public Property SeeAllButtonText As String = "See All Years" _
                Implements mt_ICrosstabColumnUnits.SeeAllButtonText
            Public Property SeeAllButtonText_Alternative As String = "See 10 Years" _
                Implements mt_ICrosstabColumnUnits.SeeAllButtonText_Alternative

            Public Function LOOKUP_CrosstabColumnHeader(i As Integer) As String Implements mt_ICrosstabColumnUnits.LOOKUP_CrosstabColumnHeader
                Return Standard_Lookup("Date_Ordinal", "sYear", "tblMonths", i)
            End Function
        End Class
    End Class
    Public Class PasswordPrompts
        Public Function DeleteStaffOrProgramFromList() As Boolean

            If LOOKUP_PasswordForDeletingStaffOrProgramFromList() = "" Then
                Return True

            ElseIf InputBox("Deleting a staff member or program from the list requires a password." &
                  "  Please input it here: ") = LOOKUP_PasswordForDeletingStaffOrProgramFromList() Then
                Return True

            Else
                MessageBox.Show("Password Incorrect.")
                Return False

            End If

        End Function
    End Class
End Namespace
