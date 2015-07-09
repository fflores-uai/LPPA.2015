Option Strict On
Option Explicit On

Imports BLL

Public Class Test
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim GestorJC = New BLL.JobCandidate


        JobCandidateTable.DataSource = GestorJC.GetAllJobCandidate()
        JobCandidateTable.DataBind()

    End Sub

    Protected Sub btnViewJobCandidate_Click(sender As Object, e As EventArgs) Handles btnViewJobCandidate.Click
        JobCandidateDetail.idCandidate = Convert.ToInt16(txtNumber.Text)

        Response.Redirect("..\RRHH\JobCandidateDetail.aspx")
    End Sub
End Class