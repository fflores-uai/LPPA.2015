Imports Entity
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports SL
Imports System
Imports System.Data
Imports System.Data.Common

Namespace DAL
    Friend Class Familia_Patente
        ' Methods
        Public Shared Sub Delete(ByVal _object As FamiliaElement)
            Dim myDatabase As Database = DatabaseFactory.CreateDatabase
            Dim myCommand As DbCommand = myDatabase.GetStoredProcCommand("Familia_Patente_Delete")
            myDatabase.AddInParameter(myCommand, "@IdFamilia", DbType.String, _object.get_IdFamiliaElement)
            myDatabase.ExecuteNonQuery(myCommand)
        End Sub

        Public Shared Sub DeleteAccesos(ByVal _object As Familia)
            Dim myDatabase As Database = DatabaseFactory.CreateDatabase
            Dim myCommand As DbCommand = myDatabase.GetStoredProcCommand("Familia_Patente_Delete")
            myDatabase.AddInParameter(myCommand, "@IdFamilia", DbType.String, _object.get_IdFamiliaElement)
            myDatabase.ExecuteNonQuery(myCommand)
        End Sub

        Public Shared Function GetAccesos(ByVal IdFamiliaElement As String) As DataTable
            Dim CS$1$0000 As DataTable
            Try 
                Dim myDatabase As Database = DatabaseFactory.CreateDatabase
                Dim myCommand As DbCommand = myDatabase.GetStoredProcCommand("Familia_Patente_Select")
                myDatabase.AddInParameter(myCommand, "@IdFamilia", DbType.String, IdFamiliaElement)
                CS$1$0000 = myDatabase.ExecuteDataSet(myCommand).Tables.Item(0)
            Catch ex As Exception
                ExceptionLogging.HandleException(ex)
                Throw
            End Try
            Return CS$1$0000
        End Function

        Public Shared Sub Insert(ByVal _object As FamiliaElement)
            Dim myDatabase As Database = DatabaseFactory.CreateDatabase
            Dim myCommand As DbCommand = myDatabase.GetStoredProcCommand("Familia_Patente_Insert")
            myDatabase.AddInParameter(myCommand, "@IdFamilia", DbType.String, _object.get_IdFamiliaElement)
            myDatabase.AddInParameter(myCommand, "@Nombre", DbType.String, _object.get_Nombre)
            myDatabase.ExecuteNonQuery(myCommand)
        End Sub

        Public Shared Function [Select](ByVal IdFamiliaElement As String) As DataSet
            Dim CS$1$0000 As DataSet
            Try 
                Dim myDatabase As Database = DatabaseFactory.CreateDatabase
                Dim myCommand As DbCommand = myDatabase.GetStoredProcCommand("Familia_Patente_Select")
                myDatabase.AddInParameter(myCommand, "@IdFamilia", DbType.String, IdFamiliaElement)
                CS$1$0000 = myDatabase.ExecuteDataSet(myCommand)
            Catch ex As Exception
                ExceptionLogging.HandleException(ex)
                Throw
            End Try
            Return CS$1$0000
        End Function

        Public Shared Function SelectAll() As DataSet
            Dim CS$1$0000 As DataSet
            Try 
                Dim myDatabase As Database = DatabaseFactory.CreateDatabase
                Dim myCommand As DbCommand = myDatabase.GetStoredProcCommand("Familia_Patente_SelectAll")
                CS$1$0000 = myDatabase.ExecuteDataSet(myCommand)
            Catch ex As Exception
                ExceptionLogging.HandleException(ex)
                Throw
            End Try
            Return CS$1$0000
        End Function

        Public Shared Sub Update(ByVal _object As FamiliaElement)
            Dim myDatabase As Database = DatabaseFactory.CreateDatabase
            Dim myCommand As DbCommand = myDatabase.GetStoredProcCommand("Familia_Patente_Update")
            myDatabase.AddInParameter(myCommand, "@IdFamilia", DbType.String, _object.get_IdFamiliaElement)
            myDatabase.AddInParameter(myCommand, "@Nombre", DbType.String, _object.get_Nombre)
            myDatabase.ExecuteNonQuery(myCommand)
        End Sub

    End Class
End Namespace

