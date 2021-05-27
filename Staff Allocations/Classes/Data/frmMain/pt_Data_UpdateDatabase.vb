Imports Staff_Allocations.pt_RetrievePresentationVariables
Imports Staff_Allocations_MiddleTier.mt_LookUps
'Call Order: UpdateDatabase, GET_ParameterValuesForUpdateSPs, GetParameterValues, EXECUTE_SpsToUpdateTheDB
Public Interface IGetParameterValuesToUpdateDB

    Property AllocToggle As String
    Property strProgramID As String
    Property strStaffID As String
    Property dValue As Decimal
    Property iDateID As Integer
    Sub GetParameterValues()

End Interface
Public Class Implement_IGetParameterValuesToUpdateDB_For_Allocation
    Implements Staff_Allocations.IGetParameterValuesToUpdateDB

    Public Property AllocToggle As String = "Allocation" Implements Staff_Allocations.IGetParameterValuesToUpdateDB.AllocToggle
    Public Property dValue As Decimal Implements Staff_Allocations.IGetParameterValuesToUpdateDB.dValue
    Public Property iDateID As Integer = LOOKUP_DateID_From_DateOrd(frmMain.DataGridView1.Columns(frmMain.DataGridView1.CurrentCell.ColumnIndex).Name) _
        Implements Staff_Allocations.IGetParameterValuesToUpdateDB.iDateID
    Public Property strProgramID As String Implements Staff_Allocations.IGetParameterValuesToUpdateDB.strProgramID
    Public Property strStaffID As String Implements Staff_Allocations.IGetParameterValuesToUpdateDB.strStaffID
    Public Sub GetParameterValues() Implements Staff_Allocations.IGetParameterValuesToUpdateDB.GetParameterValues

        If RETRIEVE_Toggle() = "Staff" Then
            strStaffID = Convert.ToString(frmMain.cmbStaffOrPrograms.SelectedValue)
            strProgramID = Convert.ToString(LOOKUP_ProgramID_From_ProgramName(frmMain.DataGridView1.CurrentRow.Cells(0).Value))
        Else
            strProgramID = Convert.ToString(frmMain.cmbStaffOrPrograms.SelectedValue)
            strStaffID = Convert.ToString(LOOKUP_StaffID_From_StaffName(frmMain.DataGridView1.CurrentRow.Cells(0).Value))
        End If

        If IsDBNull(RETRIEVE_Datgridview1CurrentCell) Then
            dValue = 0
        Else
            dValue = RETRIEVE_Datgridview1CurrentCell()
        End If

        Dim ptd As New pt_Data_UpdateDatabase
        ptd.EXECUTE_SpsToUpdateTheDB(Me)



    End Sub
End Class
Public Class Implement_IGetParameterValuesToUpdateDB_For_Approved
    Implements Staff_Allocations.IGetParameterValuesToUpdateDB

    Public Property AllocToggle As String = "Approved" Implements Staff_Allocations.IGetParameterValuesToUpdateDB.AllocToggle
    Public Property dValue As Decimal Implements Staff_Allocations.IGetParameterValuesToUpdateDB.dValue
    Public Property iDateID As Integer Implements Staff_Allocations.IGetParameterValuesToUpdateDB.iDateID
    Public Property strProgramID As String Implements Staff_Allocations.IGetParameterValuesToUpdateDB.strProgramID
    Public Property strStaffID As String Implements Staff_Allocations.IGetParameterValuesToUpdateDB.strStaffID
    Public Sub GetParameterValues() Implements Staff_Allocations.IGetParameterValuesToUpdateDB.GetParameterValues

        Try

            Dim iPreviousMonth As Integer = RETRIEVE_MonthOrdinalofToday() - 1


            Dim i As Integer
            Dim sCurrentColName As String
            Dim sProgramName As String = ""

            For i = 0 To frmMain.DataGridView1.SelectedCells.Count - 1

                'This code prevents approval for the first column  (which is program names) AND also for entries more than one month ago

                sCurrentColName = frmMain.DataGridView1.Columns(frmMain.DataGridView1.SelectedCells(i).ColumnIndex).Name

                If frmMain.DataGridView1.SelectedCells(i).ColumnIndex = 0 Then
                    sProgramName = frmMain.DataGridView1.SelectedCells(i).Value
                    Continue For
                ElseIf Convert.ToInt32(sCurrentColName) < iPreviousMonth Then
                    MessageBox.Show("The date '" & LOOKUP_Date_From_DateOrd(Convert.ToInt32(sCurrentColName)) & "' for program '" & sProgramName & "'  is not authorized for approval.")
                    Continue For
                End If

                Dim ri As Integer = frmMain.DataGridView1.SelectedCells(i).RowIndex
                If RETRIEVE_Toggle() = "Staff" Then
                    strStaffID = Convert.ToString(frmMain.cmbStaffOrPrograms.SelectedValue)
                    strProgramID = Convert.ToString(LOOKUP_ProgramID_From_ProgramName(frmMain.DataGridView1.Rows(ri).Cells(0).Value))
                Else
                    strProgramID = Convert.ToString(frmMain.cmbStaffOrPrograms.SelectedValue)
                    strStaffID = Convert.ToString(LOOKUP_StaffID_From_StaffName(frmMain.DataGridView1.Rows(ri).Cells(0).Value))
                End If

                If frmMain.DataGridView1.IsCurrentCellDirty Then
                    frmMain.DataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)
                End If

                If IsDBNull(frmMain.DataGridView1.SelectedCells(i).GetEditedFormattedValue(frmMain.DataGridView1.SelectedCells(i).RowIndex, DataGridViewDataErrorContexts.CurrentCellChange)) Then
                    dValue = 0
                    'ElseIf frmMain.DataGridView1.SelectedCells(i).ValueType = GetType(String) And frmMain.DataGridView1.se = "" Then
                    '   dValue = Convert.ToDecimal(frmMain.DataGridView1.SelectedCells(i).GetEditedFormattedValue(frmMain.DataGridView1.SelectedCells(i).RowIndex, DataGridViewDataErrorContexts.CurrentCellChange))
                ElseIf frmMain.DataGridView1.SelectedCells(i).GetEditedFormattedValue _
                                (frmMain.DataGridView1.SelectedCells(i).RowIndex, DataGridViewDataErrorContexts.CurrentCellChange) = "" Then
                    dValue = 0
                Else

                    dValue = frmMain.DataGridView1.SelectedCells(i).GetEditedFormattedValue(frmMain.DataGridView1.SelectedCells(i).RowIndex, DataGridViewDataErrorContexts.CurrentCellChange)
                End If

                iDateID = LOOKUP_DateID_From_DateOrd(frmMain.DataGridView1.Columns(frmMain.DataGridView1.SelectedCells(i).ColumnIndex).Name)


                Dim ptq As New pt_Data_UpdateDatabase
                ptq.EXECUTE_SpsToUpdateTheDB(Me)

            Next

        Catch ex As Exception

            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, LOOKUP_RunConditionalTrace, "Please look over your data to see if there are any illegal characters or letters", "Possible InvalidCast")
        End Try
    End Sub
End Class
Public Class pt_Data_UpdateDatabase
    Public Sub UpdateDatabase(AllocToggle As String)

        GET_ParameterValuesForUpdateSPs(AllocToggle)

    End Sub
    Public Sub UpdateDatabase(AllocToggle As String, CellValue As Integer, iDateID As Integer, strStaffID As String, strProgramID As String)

        Dim sp As New Staff_Allocations_MiddleTier.mt_Stored_Procedures

        sp.SP_UPDATE_DATATABLE_TO_DATABASE_EXECUTE(CellValue, strProgramID, strStaffID, iDateID, AllocToggle)

    End Sub
    Private Function GET_ParameterValuesForUpdateSPs(AllocToggle As String) As Staff_Allocations.IGetParameterValuesToUpdateDB

        If AllocToggle = "Allocation" Then
            Dim s As New Staff_Allocations.Implement_IGetParameterValuesToUpdateDB_For_Allocation
            s.GetParameterValues()
            Return s

        Else
            Dim s As New Staff_Allocations.Implement_IGetParameterValuesToUpdateDB_For_Approved
            s.GetParameterValues()
            Return s
        End If

    End Function
    Friend Sub EXECUTE_SpsToUpdateTheDB(ParameterValues As Staff_Allocations.IGetParameterValuesToUpdateDB)

        Try

            Dim sp As New Staff_Allocations_MiddleTier.mt_Stored_Procedures
            Dim mtv As New Staff_Allocations_MiddleTier.mt_Validation.mt_Routines

            'dValue is the value in the cell. If it's null, change it to zero. Then update the database with the zero because if only
            '   the alloc or the approv are zero the value should remain. Then run delete -the sp will only delete the record if both are zero.

            If IsDBNull(ParameterValues.dValue) Then ParameterValues.dValue = 0

            sp.SP_UPDATE_DATATABLE_TO_DATABASE_EXECUTE(ParameterValues.dValue, ParameterValues.strProgramID, ParameterValues.strStaffID, ParameterValues.iDateID, ParameterValues.AllocToggle)

            If ParameterValues.dValue = 0 Then sp.SP_DELETE_ALLOCATION_IF_BOTH_ALLOC_AND_APPRO_ARE_0(ParameterValues.strProgramID, ParameterValues.strStaffID, ParameterValues.iDateID)



        Catch ex As Exception

            Dim HandleStandardProcedure As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardProcedure.HANDLE_EXCEPTION(ex, LOOKUP_CondtionalTraceSetting)

        End Try
    End Sub
End Class


