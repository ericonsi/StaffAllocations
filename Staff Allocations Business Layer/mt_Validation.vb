Imports EH_Validation
Imports EH_Validation.Validating_Routines
Imports System.Windows.Forms
Public Class mt_Validation

    Public Class mt_Routines
        Public Function VALIDATE_ThatTheNumberIsWithinRange(dValue As Object) As Boolean
            Dim EHV As New EH_Validation.Validating_Routines

            'Properties
            Dim dMINIMUM As Decimal = 0
            Dim dMAXIMUM As Decimal = 100
            Dim sMessage As String = "You may only enter a number between " & dMINIMUM & " and " & dMAXIMUM & "." & _
                                "  The number you entered will not be saved."
            ''


            If EHV.NumberRange(dValue, dMINIMUM, dMAXIMUM) Then
                Return True
            Else
                MessageBox.Show(sMessage, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

        End Function
        Public Function VALIDATE_ThatTheDatagridviewHasRows(dgv As DataGridView) As Boolean

            If dgv.RowCount > 0 Then
                Return True
            Else
                Return False
            End If

        End Function
        Public Function VALIDATE_ThatTheCurrentColumnIsNotStaffOrProgram(dgv As DataGridView) As Boolean

            If dgv.CurrentCell.ColumnIndex <> 0 Then
                Return True
            Else
                Return False
            End If
        End Function
        Public Function VALIDATE_ThatTheValueIsNotNullOrAnEmptyString(dgvCell As Object) As Boolean


            If dgvCell.GetType = GetType(String) Then

                If String.IsNullOrEmpty(dgvCell) Then
                    Return False
                Else
                    Return True
                End If

            End If

            Return True

        End Function
        Public Function VALIDATE_ThatTheValueIsADecimal(dgvCell As Object) As Boolean

            Dim d As Decimal
            If Not Decimal.TryParse(dgvCell.ToString, d) Then

                Return False

            End If

            Return True

        End Function
        Public Function VALIDATE_ThatTheValueIsNotANonEmptyNonNullString(dgvCell As Object) As Boolean

            Dim d As Decimal
            If Decimal.TryParse(dgvCell.ToString, d) Then

                Return True

            End If

            If Len(dgvCell.ToString) > 0 Then
                MessageBox.Show("You may only enter numbers here.")
                Return False
            Else
                Return True
            End If

            Return True

        End Function
        Public Function VALIDATE_ThatStaffOrProgramAreNotAlreadyAdded(sToggle As String, dt As DataTable, sProgramOrStaff As String) As Boolean
            Dim EHV As New EH_Validation.Validating_Routines

            'Properties
            Dim sMessage As String = "You are trying to add a row which is already in your table."
            ''

            Dim ehq As New EH_DataUtilities.EH_QueryBuilder

            For Each row As DataRow In dt.Rows

                If sToggle = "Staff" Then
                    For Each c As DataColumn In dt.Columns
                        If c.ColumnName = "Staff" Then
                            Return True
                        End If
                    Next

                    If row("Program") = sProgramOrStaff Then
                        MessageBox.Show(sMessage)
                        Return False
                    End If

                Else

                    For Each c1 As DataColumn In dt.Columns
                        If c1.ColumnName = "Program" Then
                            Return True
                        End If
                    Next

                    If row("Staff") = sProgramOrStaff Then
                        MessageBox.Show(sMessage)
                        Return False
                    End If

                End If
            Next

            Return True
        End Function
        Public Function VALIDATE_ThatStaffOrProgramIsNotAlreadyInTable(sToggleIsStaff As Boolean, sNewLast As String, sNewFirst As String, dgv As DataGridView, CurrentDGVRow As DataGridViewRow) As Boolean

            Dim sMessage As String = "This record matches another record already in this table. Click 'OK' to continue with it. Click 'Cancel' to edit it, or 'Cancel' and then the escape key to eliminate it."
            Dim ehq As New EH_DataUtilities.EH_QueryBuilder
            Dim dt As New DataTable
            Dim sOldLast As String = ""
            Dim sOldFirst As String = ""
            Dim CountOfMatchingRecords As Integer = 0
            Dim sCurrentFirst As String = ""
            Dim sCurrentLast As String = ""


            'EHX - doesn't allow duplicate first and last even if middle name is different - neccessary because they only appear in the dropdowns with first and last

            For Each row As DataGridViewRow In dgv.Rows

                If row.IsNewRow Then
                    Return True
                End If

                If sToggleIsStaff Then
                    sCurrentFirst = "FirstName"
                    sCurrentLast = "LastName"
                Else
                    sCurrentFirst = "Department"
                    sCurrentLast = "ProgramName"
                End If

                If Not IsDBNull(row.Cells(sCurrentLast).Value) Then sOldLast = row.Cells(sCurrentLast).Value.ToString
                If Not IsDBNull(row.Cells(sCurrentFirst).Value) Then sOldFirst = row.Cells(sCurrentFirst).Value.ToString

                If sOldLast = sNewLast And sOldFirst = sNewFirst Then
                    CountOfMatchingRecords = CountOfMatchingRecords + 1
                    If CountOfMatchingRecords > 1 Then
                        If MessageBox.Show(sMessage, "WARNING", MessageBoxButtons.OKCancel) = DialogResult.Cancel Then
                            Return False
                        Else
                            Return True
                        End If
                    End If
                End If


            Next

            Return True

        End Function

        Public Function VALIDATE_ThatTheNumberIsAWholeNumber(nNumber As Decimal) As Boolean

            'EHx - why no return statement?

            Dim ehv As New EH_Validation.Validations.Validation_Handlers.ThatNumberIsAWholeNumber
            ehv.CheckForWholeNumber(nNumber)

        End Function

        Public Function VALIDATE_ThatTheRecordHasAFirstName(FirstName As String) As Boolean

            If IsDBNull(FirstName) Then
                Return False
            Else
                Return True
            End If

        End Function
    End Class

End Class
