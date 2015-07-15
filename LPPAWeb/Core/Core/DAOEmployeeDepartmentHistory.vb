Option Strict On
Option Explicit On
Imports System.Data.SqlClient
Imports System.Data

Public Class DAOEmployeeDepartmentHistory

    Dim oConexion As New SqlConnection(ConfigurationManager.ConnectionStrings.Item("ConexionAW").ToString())

    Public Sub AddEDH(ByVal EDH As Entitys.EmployeeDepartmentHistory)

        Dim sp As String = "sp_Add_EDHistory"
        oConexion.Open()
        Dim comm As New SqlCommand(sp, oConexion)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@BussinessEntityID", EDH.BusinessEntityID)
        comm.Parameters.AddWithValue("@DepartmentId", EDH.DepartmentID)
        comm.Parameters.AddWithValue("@StartDate", EDH.StartDate)
        comm.Parameters.AddWithValue("@EndDate", EDH.EndDate)
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
    Public Function GetAllEDH() As DataSet
        Dim ds As New DataSet

        Dim sp As String = "GetAll_EDHistory"
        oConexion.Open()
        Dim comm As New SqlCommand(sp, oConexion)
        comm.CommandType = CommandType.StoredProcedure
        comm.ExecuteNonQuery()
        Dim sa As New SqlDataAdapter(comm)
        sa.Fill(ds)
        oConexion.Close()

        Return ds
    End Function

    Public Function GetOneEDH(ByVal EDHID As Integer, ByVal departmentid As Integer, ByVal startdate As Date) As DataSet
        Dim ds As New DataSet

        Dim sp As String = "sp_GetOne_EDHistory"
        oConexion.Open()
        Dim comm As New SqlCommand(sp, oConexion)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@BussinessEntityID", EDHID)
        comm.Parameters.AddWithValue("@DepartmentId", departmentid)
        comm.Parameters.AddWithValue("@StartDate", startdate)
        comm.ExecuteNonQuery()

        Dim sa As New SqlDataAdapter(comm)
        sa.Fill(ds)
        oConexion.Close()
        Return ds
    End Function

    Public Sub RemoveEDH(ByVal EDHID As Integer, ByVal departmentid As Integer, ByVal startdate As Date)

        Dim sp As String = "sp_Remove_EDHistory"
        oConexion.Open()
        Dim comm As New SqlCommand(sp, oConexion)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@BussinessEntityID", EDHID)
        comm.Parameters.AddWithValue("@DepartmentId", departmentid)
        comm.Parameters.AddWithValue("@StartDate", startdate)
        comm.ExecuteNonQuery()
        oConexion.Close()
    End Sub
    Public Sub UpdateEDH(ByVal EDH As Entitys.EmployeeDepartmentHistory)

        Dim sp As String = "sp_Update_EDHistory"
        oConexion.Open()
        Dim comm As New SqlCommand(sp, oConexion)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@BussinessEntityID", EDH.BusinessEntityID)
        comm.Parameters.AddWithValue("@DepartmentId", EDH.DepartmentID)
        comm.Parameters.AddWithValue("@StartDate", EDH.StartDate)
        comm.Parameters.AddWithValue("@EndDate", EDH.EndDate)
        comm.ExecuteNonQuery()
        oConexion.Close()
    End Sub

End Class