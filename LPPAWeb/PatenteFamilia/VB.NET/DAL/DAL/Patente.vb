Imports Entity
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports SL
Imports System
Imports System.Data
Imports System.Data.Common

Namespace DAL
    Friend Class Patente
        ' Methods
        Public Shared Sub Delete(ByVal _object As Entity.Patente)
            Dim myDatabase As Database = DatabaseFactory.CreateDatabase
            Dim myCommand As DbCommand = myDatabase.GetStoredProcCommand("Patente_Delete")
            myDatabase.AddInParameter(myCommand, "@IdPatente", DbType.String, _object.IdFamiliaElement)
            myDatabase.ExecuteNonQuery(myCommand)
        End Sub

        Public Shared Sub Insert(ByVal _object As Entity.Patente)
            Dim myDatabase As Database = DatabaseFactory.CreateDatabase
            Dim myCommand As DbCommand = myDatabase.GetStoredProcCommand("Patente_Insert")
            myDatabase.AddInParameter(myCommand, "@IdPatente", DbType.String, _object.IdFamiliaElement)
            myDatabase.AddInParameter(myCommand, "@Nombre", DbType.String, _object.Nombre)
            myDatabase.ExecuteNonQuery(myCommand)
        End Sub

        Public Shared Function [Select](ByVal IdFamiliaElement As String) As DataSet
            Dim varDataTable As DataSet
            Try 
                Dim myDatabase As Database = DatabaseFactory.CreateDatabase
                Dim myCommand As DbCommand = myDatabase.GetStoredProcCommand("Patente_Select")
                myDatabase.AddInParameter(myCommand, "@IdPatente", DbType.String, IdFamiliaElement)
                varDataTable = myDatabase.ExecuteDataSet(myCommand)
            Catch ex As Exception
                ExceptionLogging.HandleException(ex)
                Throw
            End Try
            Return varDataTable
        End Function

        Public Shared Function SelectAll() As DataSet
            Dim varDataTable As DataSet
            Try 
                Dim myDatabase As Database = DatabaseFactory.CreateDatabase
                Dim myCommand As DbCommand = myDatabase.GetStoredProcCommand("Patente_SelectAll")
                varDataTable = myDatabase.ExecuteDataSet(myCommand)
            Catch ex As Exception
                ExceptionLogging.HandleException(ex)
                Throw
            End Try
            Return varDataTable
        End Function

        Public Shared Sub Update(ByVal _object As Entity.Patente)
            Dim myDatabase As Database = DatabaseFactory.CreateDatabase
            Dim myCommand As DbCommand = myDatabase.GetStoredProcCommand("Patente_Update")
            myDatabase.AddInParameter(myCommand, "@IdPatente", DbType.String, _object.IdFamiliaElement)
            myDatabase.AddInParameter(myCommand, "@Nombre", DbType.String, _object.Nombre)
            myDatabase.ExecuteNonQuery(myCommand)
        End Sub

    End Class
End Namespace

