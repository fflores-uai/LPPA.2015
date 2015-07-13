Option Strict On
Option Explicit On
Imports System.Data.SqlClient
Imports System.Data

Public Class DAODepartment

    'Dim oConexion As New SqlConnection(C)

    Public Function GetAllDepartment() As DataSet
        'Dim oCon As New SqlConnection()
        'oCon = ConfigurationManager.ConnectionStrings.Item("conexionLppa").ToString()

        Dim ds As New DataSet
        Dim con As New SqlConnection("Data Source=DMC-NOTEBOOK\SQLEXPRESS;Initial Catalog=AdventureWorks2008;Integrated Security=True")
        Dim sp As String = "sp_GetAll_Department"
        con.Open()
        Dim comm As New SqlCommand(sp, con)
        comm.CommandType = CommandType.StoredProcedure
        comm.ExecuteNonQuery()
        Dim sa As New SqlDataAdapter(comm)
        sa.Fill(ds)
        con.Close()

        Return ds
    End Function

    Public Function GetOneDepartment(ByVal idepartment As Integer) As DataSet

        Dim ds As New DataSet
        Dim con As New SqlConnection("Data Source=DMC-NOTEBOOK\SQLEXPRESS;Initial Catalog=AdventureWorks2008;Integrated Security=True")
        Dim sp As String = "sp_GetOne_Department"
        con.Open()
        Dim comm As New SqlCommand(sp, con)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@DeparmentId", idepartment)
        comm.ExecuteNonQuery()
        Dim sa As New SqlDataAdapter(comm)
        sa.Fill(ds)
        con.Close()

        Return ds

    End Function

End Class