Imports Entity
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports SL
Imports System
Imports System.Data
Imports System.Data.Common

Namespace DAL
    Friend Class Familia
        ' Methods
        Public Shared Sub Delete(ByVal _object As Entity.Familia)
            If (Not _object.Accesos Is Nothing) Then
                Familia.DeleteAccesos(_object)
            End If
            Dim myDatabase As Database = DatabaseFactory.CreateDatabase
            Dim myCommand As DbCommand = myDatabase.GetStoredProcCommand("Familia_Delete")
            myDatabase.AddInParameter(myCommand, "@IdFamilia", DbType.String, _object.IdFamiliaElement)
            myDatabase.ExecuteNonQuery(myCommand)
        End Sub

        Public Shared Sub DeleteAccesos(ByVal _object As Entity.Familia)
            Dim myDatabase As Database = DatabaseFactory.CreateDatabase
            Dim myCommand As DbCommand = myDatabase.GetStoredProcCommand("Familia_Familia_DeleteParticular")
            myDatabase.AddInParameter(myCommand, "@IdFamilia", DbType.String, _object.IdFamiliaElement)
            myDatabase.ExecuteNonQuery(myCommand)
        End Sub

        Public Shared Function GetAccesos(ByVal IdFamiliaElement As String) As DataTable
            Dim myDatabase As Database = DatabaseFactory.CreateDatabase
            Dim myCommand As DbCommand = myDatabase.GetStoredProcCommand("Familia_Familia_SelectParticular")
            myDatabase.AddInParameter(myCommand, "@IdFamilia", DbType.String, IdFamiliaElement)
            Return myDatabase.ExecuteDataSet(myCommand).Tables.Item(0)
        End Function

        Public Shared Sub Insert(ByVal _object As Entity.Familia)
            Dim myDatabase As Database = DatabaseFactory.CreateDatabase
            Dim myCommand As DbCommand = myDatabase.GetStoredProcCommand("Familia_Insert")
            myDatabase.AddInParameter(myCommand, "@IdFamilia", DbType.String, _object.IdFamiliaElement)
            myDatabase.AddInParameter(myCommand, "@Nombre", DbType.String, _object.Nombre)
            myDatabase.ExecuteNonQuery(myCommand)
            If (Not _object.Accesos Is Nothing) Then
                Familia.DeleteAccesos(_object)
                Familia_Patente.DeleteAccesos(_object)
                Dim _tipo As FamiliaElement
                For Each _tipo In _object.Accesos
                    Dim myCommandAccesos As DbCommand
                    If (_tipo.GetType.Name = "Familia") Then
                        myCommandAccesos = myDatabase.GetStoredProcCommand("Familia_Familia_Insert")
                        myDatabase.AddInParameter(myCommandAccesos, "@IdFamilia", DbType.String, _object.IdFamiliaElement)
                        myDatabase.AddInParameter(myCommandAccesos, "@IdFamiliaHijo", DbType.String, _tipo.IdFamiliaElement)
                        myDatabase.ExecuteNonQuery(myCommandAccesos)
                    Else
                        myCommandAccesos = myDatabase.GetStoredProcCommand("Familia_Patente_Insert")
                        myDatabase.AddInParameter(myCommandAccesos, "@IdFamilia", DbType.String, _object.IdFamiliaElement)
                        myDatabase.AddInParameter(myCommandAccesos, "@IdPatente", DbType.String, _tipo.IdFamiliaElement)
                        myDatabase.ExecuteNonQuery(myCommandAccesos)
                    End If
                Next
            End If
        End Sub

        Public Shared Function [Select](ByVal IdFamiliaElement As String) As DataSet
            Dim varDataTable As DataSet
            Try
                Dim myDatabase As Database = DatabaseFactory.CreateDatabase
                Dim myCommand As DbCommand = myDatabase.GetStoredProcCommand("Familia_Select")
                myDatabase.AddInParameter(myCommand, "@IdFamilia", DbType.String, IdFamiliaElement)
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
                Dim myCommand As DbCommand = myDatabase.GetStoredProcCommand("Familia_SelectAll")
                varDataTable = myDatabase.ExecuteDataSet(myCommand)
            Catch ex As Exception
                ExceptionLogging.HandleException(ex)
                Throw
            End Try
            Return varDataTable
        End Function

        Public Shared Sub Update(ByVal _object As Entity.Familia)
            Dim myDatabase As Database = DatabaseFactory.CreateDatabase
            Dim myCommand As DbCommand = myDatabase.GetStoredProcCommand("Familia_Update")
            myDatabase.AddInParameter(myCommand, "@IdFamilia", DbType.String, _object.IdFamiliaElement)
            myDatabase.AddInParameter(myCommand, "@Nombre", DbType.String, _object.Nombre)
            myDatabase.ExecuteNonQuery(myCommand)
            If (Not _object.Accesos Is Nothing) Then
                Familia.DeleteAccesos(_object)
                Familia_Patente.DeleteAccesos(_object)
                Dim _tipo As FamiliaElement
                For Each _tipo In _object.Accesos
                    Dim myCommandAccesos As DbCommand
                    If (_tipo.GetType.Name = "Familia") Then
                        myCommandAccesos = myDatabase.GetStoredProcCommand("Familia_Familia_Insert")
                        myDatabase.AddInParameter(myCommandAccesos, "@IdFamilia", DbType.String, _object.IdFamiliaElement)
                        myDatabase.AddInParameter(myCommandAccesos, "@IdFamiliaHijo", DbType.String, _tipo.IdFamiliaElement)
                        myDatabase.ExecuteNonQuery(myCommandAccesos)
                    Else
                        myCommandAccesos = myDatabase.GetStoredProcCommand("Familia_Patente_Insert")
                        myDatabase.AddInParameter(myCommandAccesos, "@IdFamilia", DbType.String, _object.IdFamiliaElement)
                        myDatabase.AddInParameter(myCommandAccesos, "@IdPatente", DbType.String, _tipo.IdFamiliaElement)
                        myDatabase.ExecuteNonQuery(myCommandAccesos)
                    End If
                Next
            End If
        End Sub

    End Class
End Namespace

