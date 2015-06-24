Namespace Entities
    Public Class ResumeCandidate

        Property NameCandidate As NameCandidate
        Property Employeements As IEnumerable(Of Employeement)
        Property Education As IEnumerable(Of Education)
        Property Addresses As IEnumerable(Of Address)
        Property Telephones As IEnumerable(Of Telephone)
    End Class

    Public Class NameCandidate
        Property First As String
        Property Prefix As String
        Property Middle As String
        Property Last As String
        Property Suffix As String
    End Class

    Public Class Employeement
        Property StartDate As DateTime
        Property EndDate As DateTime
        Property Orgname As String
        Property JobTitle As String
        Property Responsability As String
        Property FunctionCategory As String
        Property IndustryCategory As String
        Property Location As Location
    End Class

    Public Class Location
        Property CountryRegion As String
        Property State As String
        Property City As String
    End Class

    Public Class Education
        Property Level As String
        Property StartDate As DateTime
        Property EndDate As DateTime
        Property Degree As String
        Property Major As String
        Property Minor As String
        Property GPA As Double
        Property GPAScale As Double
        Property School As String
        Property Location As Location

    End Class

    Public Class Address
        Property Type As String
        Property Street As String
        Property Location As Location
        Property PostalCode As String
    End Class

    Public Class Telephone
        Property Type As String
        Property IntlCode As Integer
        Property AreaCode As Integer
        Property Number As String
    End Class

End Namespace