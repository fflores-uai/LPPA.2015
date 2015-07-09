Public Class Employee
    Implements IEmployee

    Public Sub AddEmployee(EEmployee As Entitys.Employee) Implements IEmployee.AddEmployee
        Dim GestorEmployee As New DAO.DAOEmployee
        GestorEmployee.AddEmployee(EEmployee)
    End Sub

    Public Function GetAllEmployee() As DataSet Implements IEmployee.GetAllEmployee
        Dim GestorEmployee As New DAO.DAOEmployee
        Return GestorEmployee.GetAllEmployee

    End Function

    Public Function GetOneEmployee(EmployeeId As Integer) As DataSet Implements IEmployee.GetOneEmployee
        Dim GestorEmployee As New DAO.DAOEmployee
        Return GestorEmployee.GetOneEmployee(EmployeeId)
    End Function

    Public Sub RemoveEmployee(EmployeeId As Integer) Implements IEmployee.RemoveEmployee
        Dim GestorEmployee As New DAO.DAOEmployee
        GestorEmployee.RemoveEmployee(EmployeeId)
    End Sub

    Public Sub UpdateEmployee(EEmployee As Entitys.Employee) Implements IEmployee.UpdateEmployee
        Dim GestorEmployee As New DAO.DAOEmployee
        GestorEmployee.UpdateEmployee(EEmployee)
    End Sub
End Class
