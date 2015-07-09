Public Interface IPerson
    Sub AddPerson(ByVal EPerson As Entitys.Person)
    Function GetAllPerson() As DataSet
    Function GetOnePerson(ByVal PersonId As Integer) As DataSet
    Sub RemovePerson(ByVal PersonID As Integer)
    Sub UpdatePerson(ByVal EPerson As Entitys.Person)
    
End Interface
