Imports Staff_Allocations_MiddleTier.mt_LookUps
Imports Staff_Allocations.pt_RetrievePresentationVariables
Public Class pt_Data_AddNewProgramOrStaffToDgv

    Public Sub New()

    End Sub
    Public Function MODIFY_CrosstabTable_PrepareFirstRowWhenCrosstabTableHasNoRows() As DataTable

        Dim dt As New DataTable
        Dim i As Integer = 0

        dt.Columns.Add(RETRIEVE_Other_Toggle)

        Dim EndOrd As Integer = LOOKUP_CrosstabStyleInterfaceImplementation.CrosstabColumnNumber - 1
        Do While i <= EndOrd
            dt.Columns.Add(RETRIEVE_Ord() + i)

            If i >= 1 Then
                dt.Columns(i).DataType = GetType(Decimal)
            End If

            i = i + 1
        Loop


        Return dt

    End Function
    Public Sub MODIFY_CrosstabTable_AddNewProgramOrStaff(dt As DataTable)

        dt.Rows.Add(frmMain.cmbAdd.Text)
        frmMain.DataGridView1.DataSource = dt

    End Sub
End Class
