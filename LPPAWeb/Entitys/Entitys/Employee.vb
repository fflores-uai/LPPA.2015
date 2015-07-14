Partial Public Class Employee
    Public Property BusinessEntityID As Integer
    Public Property NationalIDNumber As String
    Public Property LoginID As String
    'Public Property OrganizationLevel As Nullable(Of Short)
    Public Property JobTitle As String
    Public Property BirthDate As Date
    Public Property MaritalStatus As String
    Public Property Gender As String
    Public Property HireDate As Date
    Public Property SalariedFlag As Boolean
    Public Property VacationHours As Short
    Public Property SickLeaveHours As Short
    Public Property CurrentFlag As Boolean
    Public Property rowguid As System.Guid
    Public Property ModifiedDate As Date

    Public Overridable Property EmployeeDepartmentHistory As ICollection(Of EmployeeDepartmentHistory) = New HashSet(Of EmployeeDepartmentHistory)
    Public Overridable Property JobCandidate As ICollection(Of JobCandidate) = New HashSet(Of JobCandidate)

End Class