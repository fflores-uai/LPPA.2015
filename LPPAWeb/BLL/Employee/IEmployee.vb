Public Interface IEmployee
    Sub AddEmployee(ByVal EEmployee As Entitys.Employee)
    Function GetAllEmployee() As DataSet
    Function GetOneEmployee(ByVal EmployeeId As Integer) As DataSet
    Sub RemoveEmployee(ByVal EmployeeId As Integer)
    Sub UpdateEmployee(ByVal EEmployee As Entitys.Employee)

End Interface