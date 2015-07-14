Partial Public Class Department
    Public Property DepartmentID As Short
    Public Property Name As String
    'Public Property GroupName As String
    'Public Property ModifiedDate As Date

    Public Overridable Property EmployeeDepartmentHistory As ICollection(Of EmployeeDepartmentHistory) = New HashSet(Of EmployeeDepartmentHistory)

End Class