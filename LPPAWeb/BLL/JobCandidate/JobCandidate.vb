Public Class JobCandidate
    Implements IJobCandidate

    Public Sub AddJobCandidate(EJobCandidate As Entitys.JobCandidate) Implements IJobCandidate.AddJobCandidate
        'Dim GestorJobCandidate As New DAO.DAOJobCandidate
        Dim GestorJobCandidate = New Core.DAOJobCandidate
        GestorJobCandidate.AddJobCandidate(EJobCandidate)
    End Sub

    Public Function GetAllJobCandidate() As DataSet Implements IJobCandidate.GetAllJobCandidate
        'Dim GestorJobCandidate As New DAO.DAOJobCandidate
        Dim GestorJobCandidate = New Core.DAOJobCandidate
        Return GestorJobCandidate.GetAllJobCandidate()
    End Function

    Public Function GetOneJobCandidate(JobCandidateID As Integer) As DataSet Implements IJobCandidate.GetOneJobCandidate
        'Dim GestorJobCandidate As New DAO.DAOJobCandidate
        Dim GestorJobCandidate = New Core.DAOJobCandidate
        Return GestorJobCandidate.GetOneJobCandidate(JobCandidateID)

    End Function

    Public Sub RemoveJobCandidate(JobCandidateID As Integer) Implements IJobCandidate.RemoveJobCandidate
        'Dim GestorJobCandidate As New DAO.DAOJobCandidate
        Dim GestorJobCandidate = New Core.DAOJobCandidate
        GestorJobCandidate.RemoveJobCandidate(JobCandidateID)

    End Sub

    Public Sub UpdateJobCandidate(EJobCandidate As Entitys.JobCandidate) Implements IJobCandidate.UpdateJobCandidate
        'Dim GestorJobCandidate As New DAO.DAOJobCandidate
        Dim GestorJobCandidate = New Core.DAOJobCandidate
        GestorJobCandidate.UpdateJobCandidate(EJobCandidate)

    End Sub

    Public Function GetAllJobCandidateLast() As DataSet Implements IJobCandidate.GetAllJobCandidateLast
        Dim GestorJobCandidate = New Core.DAOJobCandidate
        Return GestorJobCandidate.GetAllJobCandidateLast()
    End Function
End Class