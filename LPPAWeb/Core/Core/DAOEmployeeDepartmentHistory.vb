Imports System.Data.SqlClient
Public Class DAOEmployeeDepartmentHistory

    Public Sub AddEDH(ByVal EDH As Entitys.EmployeeDepartmentHistory)
        Dim con As New SqlConnection("Data Source=DMC-NOTEBOOK\SQLEXPRESS;Initial Catalog=AdventureWorks2008;Integrated Security=True")
        Dim sp As String = "sp_Add_EDHistory"
        con.Open()
        Dim comm As New SqlCommand(sp, con)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@BussinessEntityID", EDH.BusinessEntityID)
        comm.Parameters.AddWithValue("@DepartmentId", EDH.DepartmentID)
        comm.Parameters.AddWithValue("@StartDate", EDH.StartDate)
        comm.Parameters.AddWithValue("@EndDate", EDH.EndDate)
        comm.ExecuteNonQuery()
        con.Close()

        'Dim MyType As Type = Type.GetType("JobCandidate")
        'Dim Mymemberinfoarray As MemberInfo() = MyType.GetMembers()
        'Dim Mymemberinfo As MemberInfo
        'For Each Mymemberinfo In Mymemberinfoarray
        '    If Mymemberinfo.MemberType = MemberTypes.Property Then

        '        comm.Parameters.AddWithValue(

        '    End If

        'Next Mymemberinfo

    End Sub
    Public Function GetAllEDH()
        Dim ds As New DataSet
        Dim con As New SqlConnection("Data Source=DMC-NOTEBOOK\SQLEXPRESS;Initial Catalog=AdventureWorks2008;Integrated Security=True")
        Dim sp As String = "GetAll_EDHistory"
        con.Open()
        Dim comm As New SqlCommand(sp, con)
        comm.CommandType = CommandType.StoredProcedure
        comm.ExecuteNonQuery()
        Dim sa As New SqlDataAdapter(comm)
        sa.Fill(ds)
        con.Close()

        Return ds
    End Function

    Public Function GetOneEDH(ByVal EDHID As Integer, ByVal departmentid As Integer, ByVal startdate As Date)
        Dim ds As New DataSet
        Dim con As New SqlConnection("Data Source=DMC-NOTEBOOK\SQLEXPRESS;Initial Catalog=AdventureWorks2008;Integrated Security=True")
        Dim sp As String = "sp_GetOne_EDHistory"
        con.Open()
        Dim comm As New SqlCommand(sp, con)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@BussinessEntityID", EDHID)
        comm.Parameters.AddWithValue("@DepartmentId", departmentid)
        comm.Parameters.AddWithValue("@StartDate", startdate)
        comm.ExecuteNonQuery()

        Dim sa As New SqlDataAdapter(comm)
        sa.Fill(ds)
        con.Close()
        Return ds
    End Function

    Public Sub RemoveEDH(ByVal EDHID As Integer, ByVal departmentid As Integer, ByVal startdate As Date)
        Dim con As New SqlConnection("Data Source=DMC-NOTEBOOK\SQLEXPRESS;Initial Catalog=AdventureWorks2008;Integrated Security=True")
        Dim sp As String = "sp_Remove_EDHistory"
        con.Open()
        Dim comm As New SqlCommand(sp, con)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@BussinessEntityID", EDHID)
        comm.Parameters.AddWithValue("@DepartmentId", departmentid)
        comm.Parameters.AddWithValue("@StartDate", startdate)
        comm.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Sub UpdateEDH(ByVal EDH As Entitys.EmployeeDepartmentHistory)
        Dim con As New SqlConnection("Data Source=DMC-NOTEBOOK\SQLEXPRESS;Initial Catalog=AdventureWorks2008;Integrated Security=True")
        Dim sp As String = "sp_Update_EDHistory"
        con.Open()
        Dim comm As New SqlCommand(sp, con)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@BussinessEntityID", EDH.BusinessEntityID)
        comm.Parameters.AddWithValue("@DepartmentId", EDH.DepartmentID)
        comm.Parameters.AddWithValue("@StartDate", EDH.StartDate)
        comm.Parameters.AddWithValue("@EndDate", EDH.EndDate)
        comm.ExecuteNonQuery()
        con.Close()
    End Sub

End Class