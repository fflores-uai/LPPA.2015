Public Class JobCandidate


    Public Sub AddJobCandidate(EJobCandidate As Entitys.JobCandidate)
        'Dim GestorJobCandidate As New DAO.DAOJobCandidate
        Dim GestorJobCandidate = New Core.DAOJobCandidate
        GestorJobCandidate.AddJobCandidate(EJobCandidate)
    End Sub

    Public Function GetAllJobCandidate() As DataSet
        'Dim GestorJobCandidate As New DAO.DAOJobCandidate
        Dim GestorJobCandidate = New Core.DAOJobCandidate
        Return GestorJobCandidate.GetAllJobCandidate()
    End Function

    Public Function GetOneJobCandidate(JobCandidateID As Integer) As DataSet
        'Dim GestorJobCandidate As New DAO.DAOJobCandidate
        Dim GestorJobCandidate = New Core.DAOJobCandidate
        Return GestorJobCandidate.GetOneJobCandidate(JobCandidateID)

    End Function

    Public Sub RemoveJobCandidate(JobCandidateID As Integer)
        'Dim GestorJobCandidate As New DAO.DAOJobCandidate
        Dim GestorJobCandidate = New Core.DAOJobCandidate
        GestorJobCandidate.RemoveJobCandidate(JobCandidateID)

    End Sub

    Public Sub UpdateJobCandidate(EJobCandidate As Entitys.JobCandidate)
        'Dim GestorJobCandidate As New DAO.DAOJobCandidate
        Dim GestorJobCandidate = New Core.DAOJobCandidate
        GestorJobCandidate.UpdateJobCandidate(EJobCandidate)

    End Sub

    Public Function GetAllJobCandidateLast() As DataSet

        Dim GestorJobCandidate = New Core.DAOJobCandidate
        Return GestorJobCandidate.GetAllJobCandidateLast()

    End Function

    Public Function GetJobCandidateResume(jobCandidateId As Integer) As String

        Dim ManagerJobCandidate = New Core.DAOJobCandidate
        Return ManagerJobCandidate.GetJobCandidateDetail(jobCandidateId)
        Return Nothing

    End Function


End Class