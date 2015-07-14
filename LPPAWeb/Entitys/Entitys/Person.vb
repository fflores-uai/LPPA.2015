Public Class Person

    Property PersonPhone As Long
    Public Property BusinessEntityID As Integer
    Public Property PersonType As String
    Public Property NameStyle As Boolean
    Public Property Title As String
    Public Property FirstName As String
    Public Property MiddleName As String
    Public Property LastName As String
    Public Property Suffix As String
    Public Property EmailPromotion As Integer
    Public Property AdditionalContactInfo As String
    Public Property Demographics As String
    Public Property rowguid As System.Guid
    Public Property ModifiedDate As Date

    Public Overridable Property Employee As Employee

End Class