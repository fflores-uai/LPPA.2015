Option Strict On
Option Explicit On
Imports Entitys

Public Interface IJobCandidate

    Sub AddJobCandidate(ByVal EJobCandidate As Entitys.JobCandidate)

    Function GetAllJobCandidate() As DataSet

    Function GetOneJobCandidate(ByVal JobCandidateID As Integer) As DataSet

    Sub RemoveJobCandidate(ByVal JobCandidateID As Integer)

    Sub UpdateJobCandidate(ByVal EJobCandidate As Entitys.JobCandidate)

    Function GetAllJobCandidateLast() As DataSet

    Function GetJobCandidateResume(jobCandidateId As Integer) As String

End Interface