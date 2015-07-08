Imports DAL.Adapters
Imports Entity
Imports System
Imports System.Collections.Generic
Imports System.Data

Namespace DAL
    Public Class UsuarioFacade
        ' Methods
        Public Shared Sub Delete(ByVal _object As Entity.Usuario)
            Try
                Usuario.Delete(_object)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Sub DeleteFamilias(ByVal _object As Entity.Usuario)
            Try
                Usuario.DeleteFamilias(_object)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Sub DeletePatentes(ByVal _object As Entity.Usuario)
            Try
                Usuario.DeletePatentes(_object)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Function GetAdapted(ByVal IdUsuario As String) As Entity.Usuario
            Dim varDataTable As Entity.Usuario
            Try
                Dim adapter As New UsuarioAdapter(UsuarioFacade.Select(IdUsuario))
                Dim _object As New Entity.Usuario
                adapter.Fill(_object)
                varDataTable = _object
            Catch ex As Exception
                Throw
            End Try
            Return varDataTable
        End Function

        Public Shared Function GetAllAdapted() As List(Of Entity.Usuario)
            Dim varDataTable As List(Of Entity.Usuario)
            Try
                Dim adapter As New UsuarioCollectionAdapter(UsuarioFacade.SelectAll)
                Dim collection As New List(Of Entity.Usuario)
                adapter.Fill(collection)
                varDataTable = collection
            Catch ex As Exception
                Throw
            End Try
            Return varDataTable
        End Function

        Public Shared Sub Insert(ByVal _object As Entity.Usuario)
            Try
                Usuario.Insert(_object)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Function [Select](ByVal IdUsuario As String) As DataRow
            Dim varDataTable As DataRow
            Try 
                varDataTable = Usuario.Select(IdUsuario).Tables.Item(0).Rows.Item(0)
            Catch ex As Exception
                Throw
            End Try
            Return varDataTable
        End Function

        Public Shared Function SelectAll() As DataTable
            Dim varDataTable As DataTable
            Try 
                varDataTable = Usuario.SelectAll.Tables.Item(0)
            Catch ex As Exception
                Throw
            End Try
            Return varDataTable
        End Function

        Public Shared Sub Update(ByVal _object As Entity.Usuario)
            Try
                Usuario.Update(_object)
            Catch ex As Exception
                Throw
            End Try
        End Sub

    End Class
End Namespace

