Public Interface IDepartment
    Function GetAllDepartment() As DataSet
    Function GetOneDepartment(ByVal idepartment As Integer) As DataSet
End Interface