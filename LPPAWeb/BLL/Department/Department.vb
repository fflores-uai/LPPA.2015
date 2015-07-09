Public Class Department
    Implements IDepartment

    Public Function GetAllDepartment() As DataSet Implements IDepartment.GetAllDepartment
        Dim GestorDepartment As New DAO.DAODepartment
        Return GestorDepartment.GetAllDepartment

    End Function

    Public Function GetOneDepartment(idepartment As Integer) As DataSet Implements IDepartment.GetOneDepartment
        Dim GestorDepartment As New DAO.DAODepartment
        Return GestorDepartment.GetOneDepartment(idepartment)
    End Function
End Class
