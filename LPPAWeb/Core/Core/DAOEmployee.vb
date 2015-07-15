Option Strict On
Option Explicit On
Imports System.Data.SqlClient
Imports System.Data

Public Class DAOEmployee

    Dim oConexion As New SqlConnection(ConfigurationManager.ConnectionStrings.Item("ConexionAW").ToString())

    Public Sub AddEmployee(ByVal EEmployee As Entitys.Employee)

        Dim sp As String = "sp_add_Employee"
        oConexion.Open()
        Dim comm As New SqlCommand(sp, oConexion)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@BussinessEntityID", EEmployee.BusinessEntityID)
        comm.Parameters.AddWithValue("@NationalIDNumber", EEmployee.NationalIDNumber)
        comm.Parameters.AddWithValue("@LoginID", EEmployee.LoginID)
        comm.Parameters.AddWithValue("@JobTitle", EEmployee.JobTitle)
        comm.Parameters.AddWithValue("@BirthDate", EEmployee.BirthDate)
        comm.Parameters.AddWithValue("@MaritalStatus", EEmployee.MaritalStatus)
        comm.Parameters.AddWithValue("@Gender", EEmployee.Gender)
        comm.Parameters.AddWithValue("@HireDate", EEmployee.HireDate)
        comm.Parameters.AddWithValue("@SalariedFlag", EEmployee.SalariedFlag)
        comm.Parameters.AddWithValue("@VacationHours", EEmployee.VacationHours)
        comm.Parameters.AddWithValue("@SickLeaveHours", EEmployee.SickLeaveHours)
        comm.Parameters.AddWithValue("@CurrentFlag", EEmployee.CurrentFlag)
        comm.ExecuteNonQuery()
        oConexion.Close()

        'Dim MyType As Type = Type.GetType("JobCandidate")
        'Dim Mymemberinfoarray As MemberInfo() = MyType.GetMembers()
        'Dim Mymemberinfo As MemberInfo
        'For Each Mymemberinfo In Mymemberinfoarray
        '    If Mymemberinfo.MemberType = MemberTypes.Property Then

        '        comm.Parameters.AddWithValue(

        '    End If

        'Next Mymemberinfo

    End Sub
    Public Function GetAllEmployee() As DataSet
        Dim ds As New DataSet

        Dim sp As String = "sp_GetAll_Employee"
        oConexion.Open()
        Dim comm As New SqlCommand(sp, oConexion)
        comm.CommandType = CommandType.StoredProcedure
        comm.ExecuteNonQuery()
        Dim sa As New SqlDataAdapter(comm)
        sa.Fill(ds)
        oConexion.Close()

        Return ds
    End Function

    Public Function GetOneEmployee(ByVal EmployeeId As Integer) As DataSet
        Dim ds As New DataSet

        Dim sp As String = "sp_GetOne_Employee"
        oConexion.Open()
        Dim comm As New SqlCommand(sp, oConexion)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@BussinessEntityID", EmployeeId)
        comm.ExecuteNonQuery()
        Dim sa As New SqlDataAdapter(comm)
        sa.Fill(ds)
        oConexion.Close()
        Return ds
    End Function

    Public Sub RemoveEmployee(ByVal EmployeeId As Integer)

        Dim sp As String = "sp_remove_Employee"
        oConexion.Open()
        Dim comm As New SqlCommand(sp, oConexion)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@BussinessEntityID", EmployeeId)
        comm.ExecuteNonQuery()
        oConexion.Close()

    End Sub
    Public Sub UpdateEmployee(ByVal EEmployee As Entitys.Employee)

        Dim sp As String = "sp_Update_Employee"
        oConexion.Open()
        Dim comm As New SqlCommand(sp, oConexion)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@BussinessEntityID", EEmployee.BusinessEntityID)
        comm.Parameters.AddWithValue("@NationalIDNumber", EEmployee.NationalIDNumber)
        comm.Parameters.AddWithValue("@LoginID", EEmployee.LoginID)
        comm.Parameters.AddWithValue("@JobTitle", EEmployee.JobTitle)
        comm.Parameters.AddWithValue("@BirthDate", EEmployee.BirthDate)
        comm.Parameters.AddWithValue("@MaritalStatus", EEmployee.MaritalStatus)
        comm.Parameters.AddWithValue("@Gender", EEmployee.Gender)
        comm.Parameters.AddWithValue("@HireDate", EEmployee.HireDate)
        comm.Parameters.AddWithValue("@SalariedFlag", EEmployee.SalariedFlag)
        comm.Parameters.AddWithValue("@VacationHours", EEmployee.VacationHours)
        comm.Parameters.AddWithValue("@SickLeaveHours", EEmployee.SickLeaveHours)
        comm.Parameters.AddWithValue("@CurrentFlag", EEmployee.CurrentFlag)
        comm.ExecuteNonQuery()
        oConexion.Close()

    End Sub

End Class