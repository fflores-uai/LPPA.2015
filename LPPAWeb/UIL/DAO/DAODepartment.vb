Imports System.Data.SqlClient
Public Class DAODepartment

  
    Public Function GetAllDepartment()
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

    Public Function GetOneDepartment(ByVal idepartment As Integer)
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
