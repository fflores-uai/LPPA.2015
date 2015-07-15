Namespace Entitys

    Public Class ResumeXML



    End Class

    Public Class Employement

        Property StartDate As Date
        Property EndDate As Date
        Property OrgName As String
        Property JobTitle As String
        Property Responsibility As String
        Property FunctionCategory As String
        Property IndustryCategory As String
        Property Location As Location
    End Class

    Public Class Education

        Property Level As String
        Property StartDate As Date
        Property EndDate As Date
        Property Degree As String
        Property Major As String
        Property Minor As String
        Property GPA As Double
        Property GPAScale As Double
        Property School As String

    End Class


    Public Class Location

        Property CountryRegion As String
        Property State As String
        Property City As String

    End Class

    Public Class Telephone

        Property Type As String
        Property IntCode As Integer
        Property AreaCode As Integer
        Property Number As String

    End Class

End Namespace