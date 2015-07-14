Partial Public Class EmployeeDepartmentHistory
    Public Property BusinessEntityID As Integer
    Public Property DepartmentID As Short
    Public Property ShiftID As Byte
    Public Property StartDate As Date
    Public Property EndDate As Nullable(Of Date)
    Public Property ModifiedDate As Date

    Public Overridable Property Department As Department
    Public Overridable Property Employee As Employee

End Class