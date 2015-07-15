﻿Option Explicit On
Option Strict On
Imports System.Data
Imports System.Data.SqlClient
Imports System.Reflection

Public Class DAOJobCandidate

    Dim oConexion As New SqlConnection(ConfigurationManager.ConnectionStrings.Item("ConexionAW").ToString())

    Public Sub AddJobCandidate(ByVal EJobCandidate As Entitys.JobCandidate)

        Dim sp As String = "sp_add_JobCandidate"
        oConexion.Open()
        Dim comm As New SqlCommand(sp, oConexion)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@BussinessEntityID", EJobCandidate.BusinessEntityID)
        comm.Parameters.AddWithValue("@Resume", EJobCandidate.Resume)
        comm.ExecuteNonQuery()
        oConexion.Close()


    End Sub

    Public Function GetAllJobCandidate() As DataSet

        Dim ds = New DataSet
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

    Public Function GetJobCandidateDetail(jobcandidateId As Integer) As String

        Dim consulta = String.Format("select [Resume] from HumanResources.JobCandidate where JobCandidateID = {0}", jobcandidateId)

        Dim oCommand = New SqlCommand()

        Return Nothing

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

    Public Function GetOneJobCandidate(ByVal JobCandidateID As Integer) As DataSet
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