Public Interface mt_IUpdateDB

    Property AllocToggle As String
    Property strProgramID As String
    Property strStaffID As String
    Property dValue As Decimal
    Property iDateID As Integer

    Sub COLLECT_CollectTheParameterValuesForTheSPs()

End Interface
Public Interface mt_ICrosstabColumnUnits

    Property lblColumnUnitText As String
    Property SeeAllButtonText As String
    Property SeeAllButtonText_Alternative As String
    Property CrosstabColumnNumber As Integer
    Property cmbColumnUnitDisplayMember As String
    Property cmbColumnValueMember As String

    Function LOOKUP_CrosstabColumnHeader(i As Integer) As String

End Interface


