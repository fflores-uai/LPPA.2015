Option Strict On
Option Explicit On

Public Class JobCandidateDetail
    Inherits System.Web.UI.Page

    Public Shared Property idCandidate As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim GestorJC = New BLL.JobCandidate

        xmlResume.InnerText = GestorJC.GetJobCandidateResume(idCandidate)

        JobCandidateTable.DataSource = GestorJC.GetOneJobCandidate(idCandidate)
        JobCandidateTable.DataBind()

    End Sub

End Class