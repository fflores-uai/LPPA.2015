Public Class Person
    Implements IPerson

    Public Sub AddPerson(EPerson As Entitys.Person) Implements IPerson.AddPerson
        Dim GestorPerson As New DAO.DAOPerson
        GestorPerson.AddPerson(EPerson)
    End Sub

    Public Function GetAllPerson() As DataSet Implements IPerson.GetAllPerson
        Dim GestorPerson As New DAO.DAOPerson
        Return GestorPerson.GetAllPerson()

    End Function

    Public Function GetOnePerson(PersonId As Integer) As DataSet Implements IPerson.GetOnePerson
        Dim GestorPerson As New DAO.DAOPerson
        Return GestorPerson.GetOnePerson(PersonId)
    End Function

    Public Sub RemovePerson(PersonID As Integer) Implements IPerson.RemovePerson
        Dim GestorPerson As New DAO.DAOPerson
        GestorPerson.RemovePerson(PersonID)
    End Sub

    Public Sub UpdatePerson(EPerson As Entitys.Person) Implements IPerson.UpdatePerson
        Dim GestorPerson As New DAO.DAOPerson
        GestorPerson.UpdatePerson(EPerson)
    End Sub
End Class
