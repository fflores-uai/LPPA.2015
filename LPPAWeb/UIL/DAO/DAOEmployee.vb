Imports System.Data.SqlClient

Public Class DAOEmployee

    Public Sub AddEmployee(ByVal EEmployee As Entitys.Employee)
        Dim con As New SqlConnection("Data Source=DMC-NOTEBOOK\SQLEXPRESS;Initial Catalog=AdventureWorks2008;Integrated Security=True")
        Dim sp As String = "sp_add_Employee"
        con.Open()
        Dim comm As New SqlCommand(sp, con)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@BussinessEntityID", EEmployee.BusinessEntityID)
        comm.Parameters.AddWithValue("@NationalIDNumber", EEmployee.NationalIDNumber)
        comm.Parameters.AddWithValue("@LoginID", EEmployee.LoginID)
        comm.Parameters.AddWithValue("@JobTitle", EEmployee.JobTitle)
        comm.Parameters.AddWithValue("@BirthDate", EEmployee.BirthDate)
        comm.Parameters.AddWithValue("@MaritalStatus", EEmployee.MaritalStatus)
        comm.Parameters.AddWithValue("@Gender", EEmployee.Gender)
        comm.Parameters.AddWithValue("@HireDate", EEmployee.HireDate)
        comm.Parameters.AddWithValue("@SalariedFlag", EEmployee.SalariedFlag)
        comm.Parameters.AddWithValue("@VacationHours", EEmployee.VacationHours)
        comm.Parameters.AddWithValue("@SickLeaveHours", EEmployee.SickLeaveHours)
        comm.Parameters.AddWithValue("@CurrentFlag", EEmployee.CurrentFlag)
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
    Public Function GetAllEmployee()
        Dim ds As New DataSet
        Dim con As New SqlConnection("Data Source=DMC-NOTEBOOK\SQLEXPRESS;Initial Catalog=AdventureWorks2008;Integrated Security=True")
        Dim sp As String = "sp_GetAll_Employee"
        con.Open()
        Dim comm As New SqlCommand(sp, con)
        comm.CommandType = CommandType.StoredProcedure
        comm.ExecuteNonQuery()
        Dim sa As New SqlDataAdapter(comm)
        sa.Fill(ds)
        con.Close()

        Return ds
    End Function

    Public Function GetOneEmployee(ByVal EmployeeId As Integer)
        Dim ds As New DataSet
        Dim con As New SqlConnection("Data Source=DMC-NOTEBOOK\SQLEXPRESS;Initial Catalog=AdventureWorks2008;Integrated Security=True")
        Dim sp As String = "sp_GetOne_Employee"
        con.Open()
        Dim comm As New SqlCommand(sp, con)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@BussinessEntityID", EmployeeId)
        comm.ExecuteNonQuery()
        Dim sa As New SqlDataAdapter(comm)
        sa.Fill(ds)
        con.Close()
        Return ds
    End Function

    Public Sub RemoveEmployee(ByVal EmployeeId As Integer)
        Dim con As New SqlConnection("Data Source=DMC-NOTEBOOK\SQLEXPRESS;Initial Catalog=AdventureWorks2008;Integrated Security=True")
        Dim sp As String = "sp_remove_Employee"
        con.Open()
        Dim comm As New SqlCommand(sp, con)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@BussinessEntityID", EmployeeId)
        comm.ExecuteNonQuery()
        con.Close()

    End Sub
    Public Sub UpdateEmployee(ByVal EEmployee As Entitys.Employee)
        Dim con As New SqlConnection("Data Source=DMC-NOTEBOOK\SQLEXPRESS;Initial Catalog=AdventureWorks2008;Integrated Security=True")
        Dim sp As String = "sp_Update_Employee"
        con.Open()
        Dim comm As New SqlCommand(sp, con)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@BussinessEntityID", EEmployee.BusinessEntityID)
        comm.Parameters.AddWithValue("@NationalIDNumber", EEmployee.NationalIDNumber)
        comm.Parameters.AddWithValue("@LoginID", EEmployee.LoginID)
        comm.Parameters.AddWithValue("@JobTitle", EEmployee.JobTitle)
        comm.Parameters.AddWithValue("@BirthDate", EEmployee.BirthDate)
        comm.Parameters.AddWithValue("@MaritalStatus", EEmployee.MaritalStatus)
        comm.Parameters.AddWithValue("@Gender", EEmployee.Gender)
        comm.Parameters.AddWithValue("@HireDate", EEmployee.HireDate)
        comm.Parameters.AddWithValue("@SalariedFlag", EEmployee.SalariedFlag)
        comm.Parameters.AddWithValue("@VacationHours", EEmployee.VacationHours)
        comm.Parameters.AddWithValue("@SickLeaveHours", EEmployee.SickLeaveHours)
        comm.Parameters.AddWithValue("@CurrentFlag", EEmployee.CurrentFlag)
        comm.ExecuteNonQuery()
        con.Close()


    End Sub

End Class
