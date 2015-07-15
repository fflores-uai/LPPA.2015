Option Strict On
Option Explicit On
Imports System.Data.SqlClient
Imports System.Data

Public Class DAOPerson

    Dim oConexion As New SqlConnection(ConfigurationManager.ConnectionStrings.Item("ConexionAW").ToString())

    Public Sub AddPerson(ByVal EPerson As Entitys.Person)

        Dim sp As String = "sp_add_JobCandidate"
        oConexion.Open()
        Dim comm As New SqlCommand(sp, oConexion)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@BussinessEntityID", EPerson.BusinessEntityID)
        comm.Parameters.AddWithValue("@PersonType", EPerson.PersonType)
        comm.Parameters.AddWithValue("@NameStyle", EPerson.NameStyle)
        comm.Parameters.AddWithValue("@Title", EPerson.Title)
        comm.Parameters.AddWithValue("@FirstName", EPerson.FirstName)
        comm.Parameters.AddWithValue("@MiddleName", EPerson.MiddleName)
        comm.Parameters.AddWithValue("@LastName", EPerson.LastName)
        comm.Parameters.AddWithValue("@Suffix", EPerson.Suffix)
        comm.Parameters.AddWithValue("@EmailPromotion", EPerson.EmailPromotion)
        comm.Parameters.AddWithValue("@AdditionalContactInfo", EPerson.AdditionalContactInfo)
        comm.Parameters.AddWithValue("@Demographics", EPerson.Demographics)
        comm.ExecuteNonQuery()
        oConexion.Close()

        'Dim MyType As Type = Type.GetType("JobCandidate")
        'Dim Mymemberinfoarray As MemberInfo() = MyType.GetMembers()
        'Dim Mymemberinfo As MemberInfo
        'For Each Mymemberinfo In Mymemberinfoarray
        '    If Mymemberinfo.MemberType = MemberTypes.Property Then

        '        comm.Parameters.AddWithValue(

        '    End If

        'Next Mymemberinfo

    End Sub

    Public Function GetAllPerson() As DataSet
        Dim ds As New DataSet

        Dim sp As String = "sp_GetAll_Person"
        oConexion.Open()
        Dim comm As New SqlCommand(sp, oConexion)
        comm.CommandType = CommandType.StoredProcedure
        comm.ExecuteNonQuery()
        Dim sa As New SqlDataAdapter(comm)
        sa.Fill(ds)
        oConexion.Close()

        Return ds
    End Function

    Public Function GetOnePerson(ByVal PersonId As Integer) As DataSet
        Dim ds As New DataSet

        Dim sp As String = "sp_GetOne_Person"
        oConexion.Open()
        Dim comm As New SqlCommand(sp, oConexion)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@BussinessEntityID", PersonId)
        comm.ExecuteNonQuery()
        Dim sa As New SqlDataAdapter(comm)
        sa.Fill(ds)
        oConexion.Close()
        Return ds
    End Function

    Public Sub RemovePerson(ByVal PersonID As Integer)

        Dim sp As String = "sp_remove_Person"
        oConexion.Open()
        Dim comm As New SqlCommand(sp, oConexion)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@BussinessEntityID", PersonID)
        comm.ExecuteNonQuery()
        oConexion.Close()
    End Sub

    Public Sub UpdatePerson(ByVal EPerson As Entitys.Person)

        Dim sp As String = "sp_Update_JobCandidate"
        oConexion.Open()
        Dim comm As New SqlCommand(sp, oConexion)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@BussinessEntityID", EPerson.BusinessEntityID)
        comm.Parameters.AddWithValue("@PersonType", EPerson.PersonType)
        comm.Parameters.AddWithValue("@NameStyle", EPerson.NameStyle)
        comm.Parameters.AddWithValue("@Title", EPerson.Title)
        comm.Parameters.AddWithValue("@FirstName", EPerson.FirstName)
        comm.Parameters.AddWithValue("@MiddleName", EPerson.MiddleName)
        comm.Parameters.AddWithValue("@LastName", EPerson.LastName)
        comm.Parameters.AddWithValue("@Suffix", EPerson.Suffix)
        comm.Parameters.AddWithValue("@EmailPromotion", EPerson.EmailPromotion)
        comm.Parameters.AddWithValue("@AdditionalContactInfo", EPerson.AdditionalContactInfo)
        comm.Parameters.AddWithValue("@Demographics", EPerson.Demographics)

        comm.ExecuteNonQuery()
        oConexion.Close()
    End Sub

End Class