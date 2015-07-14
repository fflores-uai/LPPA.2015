Public Interface IEDHistory

    Sub AddEDH(ByVal EDH As Entitys.EmployeeDepartmentHistory)
    Function GetAllEDH() As DataSet
    Function GetOneEDH(ByVal EDHID As Integer, ByVal departmentid As Integer, ByVal startdate As Date) As DataSet
    Sub RemoveEDH(ByVal EDHID As Integer, ByVal departmentid As Integer, ByVal startdate As Date)
    Sub UpdateEDH(ByVal EDH As Entitys.EmployeeDepartmentHistory)

End Interface