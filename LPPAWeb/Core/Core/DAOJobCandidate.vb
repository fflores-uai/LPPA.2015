Imports System.Data.SqlClient
Imports System.Reflection

Public Class DAOJobCandidate

    Dim oConexion As New SqlConnection(ConfigurationManager.ConnectionStrings.Item("ConexionAW").ToString())

    Public Sub AddJobCandidate(ByVal EJobCandidate As Entitys.JobCandidate)
        'Dim con As New SqlConnection("Data Source=DMC-NOTEBOOK\SQLEXPRESS;Initial Catalog=AdventureWorks2008;Integrated Security=True")
        Dim sp As String = "sp_add_JobCandidate"
        oConexion.Open()
        Dim comm As New SqlCommand(sp, oConexion)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@BussinessEntityID", EJobCandidate.BusinessEntityID)
        comm.Parameters.AddWithValue("@Resume", EJobCandidate.Resume)
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
    Public Function GetAllJobCandidate()

        Dim ds As New DataSet
        Dim sp As String = "sp_GetAll_JobCandidate"

        oConexion.Open()

        Dim comm As New SqlCommand(sp, oConexion)
        comm.CommandType = CommandType.StoredProcedure
        comm.ExecuteNonQuery()
        Dim sa As New SqlDataAdapter(comm)
        sa.Fill(ds)

        oConexion.Close()

        Return ds

    End Function

    Public Function GetAllJobCandidateLast() As DataSet

        Dim ds As New DataSet
        Dim sp As String = "sp_GetAll_JobCandidate_TopLast"

        oConexion.Open()

        Dim comm As New SqlCommand(sp, oConexion)
        comm.CommandType = CommandType.StoredProcedure
        comm.ExecuteNonQuery()
        Dim sa As New SqlDataAdapter(comm)
        sa.Fill(ds)

        oConexion.Close()

        Return ds

    End Function

    Public Function GetOneJobCandidate(ByVal JobCandidateID As Integer)
        Dim ds As New DataSet

        Dim sp As String = "sp_GetOne_JobCandidate"
        oConexion.Open()
        Dim comm As New SqlCommand(sp, oConexion)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@BussinessEntityID", JobCandidateID)
        comm.ExecuteNonQuery()
        Dim sa As New SqlDataAdapter(comm)
        sa.Fill(ds)
        oConexion.Close()
        Return ds
    End Function

    Public Sub RemoveJobCandidate(ByVal JobCandidateID As Integer)

        Dim sp As String = "sp_remove_JobCandidate"
        oConexion.Open()
        Dim comm As New SqlCommand(sp, oConexion)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@BussinessEntityID", JobCandidateID)
        comm.ExecuteNonQuery()
        oConexion.Close()
    End Sub
    Public Sub UpdateJobCandidate(ByVal EJobCandidate As Entitys.JobCandidate)

        Dim sp As String = "sp_Update_JobCandidate"
        oConexion.Open()
        Dim comm As New SqlCommand(sp, oConexion)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@BussinessEntityID", EJobCandidate.BusinessEntityID)
        comm.Parameters.AddWithValue("@Resume", EJobCandidate.Resume)
        comm.ExecuteNonQuery()
        oConexion.Close()
    End Sub

End Class