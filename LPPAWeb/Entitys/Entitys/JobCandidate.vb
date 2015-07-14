Public Class JobCandidate

    Public Property JobCandidateID As Integer
    Public Property BusinessEntityID As Nullable(Of Integer)
    Public Property [Resume] As String
    Public Property ModifiedDate As Date
    Public Overridable Property Employee As Employee

End Class