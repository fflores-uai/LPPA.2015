Imports Entity
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports SL
Imports System
Imports System.Data
Imports System.Data.Common

Namespace DAL
    Friend Class Usuario
        ' Methods
        Public Shared Sub Delete(ByVal _object As Entity.Usuario)
            If (Not _object.Permisos Is Nothing) Then
                Usuario.DeleteFamilias(_object)
                Usuario.DeletePatentes(_object)
            End If
            Dim myDatabase As Database = DatabaseFactory.CreateDatabase
            Dim myCommand As DbCommand = myDatabase.GetStoredProcCommand("Usuario_Delete")
            myDatabase.AddInParameter(myCommand, "@IdUsuario", DbType.String, _object.IdUsuario)
            myDatabase.ExecuteNonQuery(myCommand)
        End Sub

        Public Shared Sub DeleteFamilias(ByVal _object As Entity.Usuario)
            Dim myDatabase As Database = DatabaseFactory.CreateDatabase
            Dim myCommand As DbCommand = myDatabase.GetStoredProcCommand("Usuario_Familia_DeleteParticular")
            myDatabase.AddInParameter(myCommand, "@IdUsuario", DbType.String, _object.IdUsuario)
            myDatabase.ExecuteNonQuery(myCommand)
        End Sub

        Public Shared Sub DeletePatentes(ByVal _object As Entity.Usuario)
            Dim myDatabase As Database = DatabaseFactory.CreateDatabase
            Dim myCommand As DbCommand = myDatabase.GetStoredProcCommand("Usuario_Patente_DeleteParticular")
            myDatabase.AddInParameter(myCommand, "@IdUsuario", DbType.String, _object.IdUsuario)
            myDatabase.ExecuteNonQuery(myCommand)
        End Sub

        Public Shared Function GetFamilias(ByVal IdUsuario As String) As DataTable
            Dim myDatabase As Database = DatabaseFactory.CreateDatabase
            Dim myCommand As DbCommand = myDatabase.GetStoredProcCommand("Usuario_Familia_SelectParticular")
            myDatabase.AddInParameter(myCommand, "@IdUsuario", DbType.String, IdUsuario)
            Return myDatabase.ExecuteDataSet(myCommand).Tables.Item(0)
        End Function

        Public Shared Function GetPatentes(ByVal IdUsuario As String) As DataTable
            Dim myDatabase As Database = DatabaseFactory.CreateDatabase
            Dim myCommand As DbCommand = myDatabase.GetStoredProcCommand("Usuario_Patente_SelectParticular")
            myDatabase.AddInParameter(myCommand, "@IdUsuario", DbType.String, IdUsuario)
            Return myDatabase.ExecuteDataSet(myCommand).Tables.Item(0)
        End Function

        Public Shared Sub Insert(ByVal _object As Entity.Usuario)
            Dim myDatabase As Database = DatabaseFactory.CreateDatabase
            Dim myCommand As DbCommand = myDatabase.GetStoredProcCommand("Usuario_Insert")
            myDatabase.AddInParameter(myCommand, "@IdUsuario", DbType.String, _object.IdUsuario)
            myDatabase.AddInParameter(myCommand, "@Nombre", DbType.String, _object.Nombre)
            myDatabase.ExecuteNonQuery(myCommand)
            If (Not _object.Permisos Is Nothing) Then
                Usuario.DeleteFamilias(_object)
                Usuario.DeletePatentes(_object)
                Dim _tipo As FamiliaElement
                For Each _tipo In _object.Permisos
                    Dim myCommandAccesos As DbCommand
                    If (_tipo.GetType.Name = "Familia") Then
                        myCommandAccesos = myDatabase.GetStoredProcCommand("Usuario_Familia_Insert")
                        myDatabase.AddInParameter(myCommandAccesos, "@IdUsuario", DbType.String, _object.IdUsuario)
                        myDatabase.AddInParameter(myCommandAccesos, "@IdFamilia", DbType.String, _tipo.IdFamiliaElement)
                        myDatabase.ExecuteNonQuery(myCommandAccesos)
                    Else
                        myCommandAccesos = myDatabase.GetStoredProcCommand("Usuario_Patente_Insert")
                        myDatabase.AddInParameter(myCommandAccesos, "@IdUsuario", DbType.String, _object.IdUsuario)
                        myDatabase.AddInParameter(myCommandAccesos, "@IdPatente", DbType.String, _tipo.IdFamiliaElement)
                        myDatabase.ExecuteNonQuery(myCommandAccesos)
                    End If
                Next
            End If
        End Sub

        Public Shared Function [Select](ByVal IdUsuario As String) As DataSet
            Dim varDataTable As DataSet
            Try
                Dim myDatabase As Database = DatabaseFactory.CreateDatabase
                Dim myCommand As DbCommand = myDatabase.GetStoredProcCommand("Usuario_Select")
                myDatabase.AddInParameter(myCommand, "@IdUsuario", DbType.String, IdUsuario)
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
                Dim myCommand As DbCommand = myDatabase.GetStoredProcCommand("Usuario_SelectAll")
                varDataTable = myDatabase.ExecuteDataSet(myCommand)
            Catch ex As Exception
                ExceptionLogging.HandleException(ex)
                Throw
            End Try
            Return varDataTable
        End Function

        Public Shared Sub Update(ByVal _object As Entity.Usuario)
            Dim myDatabase As Database = DatabaseFactory.CreateDatabase
            Dim myCommand As DbCommand = myDatabase.GetStoredProcCommand("Usuario_Update")
            myDatabase.AddInParameter(myCommand, "@IdUsuario", DbType.String, _object.IdUsuario)
            myDatabase.AddInParameter(myCommand, "@Nombre", DbType.String, _object.Nombre)
            myDatabase.ExecuteNonQuery(myCommand)
            If (Not _object.Permisos Is Nothing) Then
                Usuario.DeleteFamilias(_object)
                Usuario.DeletePatentes(_object)
                Dim _tipo As FamiliaElement
                For Each _tipo In _object.Permisos
                    Dim myCommandAccesos As DbCommand
                    If (_tipo.GetType.Name = "Familia") Then
                        myCommandAccesos = myDatabase.GetStoredProcCommand("Usuario_Familia_Insert")
                        myDatabase.AddInParameter(myCommandAccesos, "@IdUsuario", DbType.String, _object.IdUsuario)
                        myDatabase.AddInParameter(myCommandAccesos, "@IdFamilia", DbType.String, _tipo.IdFamiliaElement)
                        myDatabase.ExecuteNonQuery(myCommandAccesos)
                    Else
                        myCommandAccesos = myDatabase.GetStoredProcCommand("Usuario_Patente_Insert")
                        myDatabase.AddInParameter(myCommandAccesos, "@IdUsuario", DbType.String, _object.IdUsuario)
                        myDatabase.AddInParameter(myCommandAccesos, "@IdPatente", DbType.String, _tipo.IdFamiliaElement)
                        myDatabase.ExecuteNonQuery(myCommandAccesos)
                    End If
                Next
            End If
        End Sub

    End Class
End Namespace

