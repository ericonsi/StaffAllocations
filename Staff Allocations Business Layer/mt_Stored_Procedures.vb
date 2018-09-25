Public Class mt_Stored_Procedures
    Public Event DB_Updating()
    Public Event DB_Updated()
    Public Event DB_Deleting()
    Public Event Comments_Updating()
    Public Function SP_DATATABLE_CREATION_CROSSTAB_EXECUTE(iOrdinal_Start As Integer, iOrdinal_End As Integer, sToggle As String, iToggle_ID_Value As Integer) As DataTable

        Dim EHSP As New EH_DataUtilities.EH_SQLSERVER_StoredProcedures

        EHSP.ASSIGN_PROCEDURE_NAME("sprBasicCrosstab_" & sToggle)
        EHSP.ADD_PARAMETER("month_start", SqlDbType.Int, ParameterDirection.Input, iOrdinal_Start)
        EHSP.ADD_PARAMETER("month_end", SqlDbType.Int, ParameterDirection.Input, iOrdinal_End)
        EHSP.ADD_PARAMETER(sToggle & "ID", SqlDbType.Int, ParameterDirection.Input, iToggle_ID_Value)

        Return EHSP.ATTACH_TO_DATATABLE

    End Function
    Public Function SP_DATATABLE_CREATION_CROSSTAB_EXECUTE1(iOrdinal_Start As Integer, iOrdinal_End As Integer, sToggle As String, iToggle_ID_Value As Integer, AllocToggle As String) As DataTable

        'appears to be for approved, need to merge with the above in sql server

        Dim EHSP As New EH_DataUtilities.EH_SQLSERVER_StoredProcedures

        EHSP.ASSIGN_PROCEDURE_NAME("sprBasicCrosstab1_" & sToggle)
        EHSP.ADD_PARAMETER("month_start", SqlDbType.Int, ParameterDirection.Input, iOrdinal_Start)
        EHSP.ADD_PARAMETER("month_end", SqlDbType.Int, ParameterDirection.Input, iOrdinal_End)
        EHSP.ADD_PARAMETER(sToggle & "ID", SqlDbType.Int, ParameterDirection.Input, iToggle_ID_Value)
        EHSP.ADD_PARAMETER("AppOrAll", SqlDbType.NVarChar, ParameterDirection.Input, AllocToggle)

        Return EHSP.ATTACH_TO_DATATABLE

    End Function
    Public Sub SP_UPDATE_DATATABLE_TO_DATABASE_EXECUTE(dValue As Decimal, ProgramID As String, StaffID As String, iDateID As Integer, AllocToggle As String)

        RaiseEvent DB_Updating()

        Dim EHSP As New EH_DataUtilities.EH_SQLSERVER_StoredProcedures

        Dim Value As String = Convert.ToString(dValue)

        EHSP.ASSIGN_PROCEDURE_NAME("sprUpdateAllocations")
        EHSP.ADD_PARAMETER("AllocOrAppro", SqlDbType.NVarChar, ParameterDirection.Input, AllocToggle)
        EHSP.ADD_PARAMETER("Value", SqlDbType.Decimal, ParameterDirection.Input, Value)
        EHSP.ADD_PARAMETER("DateID", SqlDbType.Int, ParameterDirection.Input, iDateID)
        EHSP.ADD_PARAMETER("ProgramID", SqlDbType.Int, ParameterDirection.Input, ProgramID)
        EHSP.ADD_PARAMETER("StaffID", SqlDbType.Int, ParameterDirection.Input, StaffID)
        EHSP.EXECUTE_PROCEDURE()

        RaiseEvent DB_Updated()

    End Sub
    Public Sub SP_DELETE_ALLOCATION_IF_BOTH_ALLOC_AND_APPRO_ARE_0(ProgramID As String, StaffID As String, iDateID As Integer)

        RaiseEvent DB_Deleting()

        Dim EHSP As New EH_DataUtilities.EH_SQLSERVER_StoredProcedures

        EHSP.ASSIGN_PROCEDURE_NAME("sprDeleteAllocations")
        EHSP.ADD_PARAMETER("DateID", SqlDbType.Int, ParameterDirection.Input, iDateID)
        EHSP.ADD_PARAMETER("ProgramID", SqlDbType.Int, ParameterDirection.Input, ProgramID)
        EHSP.ADD_PARAMETER("StaffID", SqlDbType.Int, ParameterDirection.Input, StaffID)
        EHSP.EXECUTE_PROCEDURE()

        RaiseEvent DB_Updated()

    End Sub
    Public Sub SP_UPDATE_COMMENTS(sToggle As String, SPID As Integer, Comments As String)

        RaiseEvent Comments_Updating()

        Dim EHSP As New EH_DataUtilities.EH_SQLSERVER_StoredProcedures

        EHSP.ASSIGN_PROCEDURE_NAME("sprUpdateComments")
        EHSP.ADD_PARAMETER("Toggle", SqlDbType.NVarChar, ParameterDirection.Input, sToggle)
        EHSP.ADD_PARAMETER("SPID", SqlDbType.Int, ParameterDirection.Input, SPID)
        EHSP.ADD_PARAMETER("Comments", SqlDbType.NVarChar, ParameterDirection.Input, Comments)
        EHSP.EXECUTE_PROCEDURE()

        RaiseEvent DB_Updated()
    End Sub
End Class
