Public Class EDHistory
    Implements IEDHistory

    Public Sub AddEDH(EDH As Entitys.EmployeeDepartmentHistory) Implements IEDHistory.AddEDH
        Dim GestorEDH As New DAO.DAOEmployeeDepartmentHistory
        GestorEDH.AddEDH(EDH)
    End Sub

    Public Function GetAllEDH() As DataSet Implements IEDHistory.GetAllEDH
        Dim GestorEDH As New DAO.DAOEmployeeDepartmentHistory
        Return GestorEDH.GetAllEDH()
    End Function

    Public Function GetOneEDH(EDHID As Integer, departmentid As Integer, startdate As Date) As DataSet Implements IEDHistory.GetOneEDH
        Dim GestorEDH As New DAO.DAOEmployeeDepartmentHistory
        Return GestorEDH.GetOneEDH(EDHID, departmentid, startdate)
    End Function

    Public Sub RemoveEDH(EDHID As Integer, departmentid As Integer, startdate As Date) Implements IEDHistory.RemoveEDH
        Dim GestorEDH As New DAO.DAOEmployeeDepartmentHistory
        GestorEDH.RemoveEDH(EDHID, departmentid, startdate)
    End Sub

    Public Sub UpdateEDH(EDH As Entitys.EmployeeDepartmentHistory) Implements IEDHistory.UpdateEDH
        Dim GestorEDH As New DAO.DAOEmployeeDepartmentHistory
        GestorEDH.UpdateEDH(EDH)
    End Sub
End Class