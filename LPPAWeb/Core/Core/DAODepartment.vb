Option Strict On
Option Explicit On
Imports System.Data.SqlClient
Imports System.Data

Public Class DAODepartment

    Dim oConexion As New SqlConnection(ConfigurationManager.ConnectionStrings.Item("ConexionAW").ToString())

    Public Function GetAllDepartment() As DataSet

        Dim ds As New DataSet

        Dim sp As String = "sp_GetAll_Department"
        oConexion.Open()
        Dim comm As New SqlCommand(sp, oConexion)
        comm.CommandType = CommandType.StoredProcedure
        comm.ExecuteNonQuery()
        Dim sa As New SqlDataAdapter(comm)
        sa.Fill(ds)
        oConexion.Close()

        Return ds
    End Function

    Public Function GetOneDepartment(ByVal idepartment As Integer) As DataSet

        Dim ds As New DataSet

        Dim sp As String = "sp_GetOne_Department"
        oConexion.Open()
        Dim comm As New SqlCommand(sp, oConexion)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@DeparmentId", idepartment)
        comm.ExecuteNonQuery()
        Dim sa As New SqlDataAdapter(comm)
        sa.Fill(ds)
        oConexion.Close()

        Return ds

    End Function

End Class