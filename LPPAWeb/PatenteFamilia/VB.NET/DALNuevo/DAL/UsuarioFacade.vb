Imports DAL.Adapters
Imports Entity
Imports System
Imports System.Collections.Generic
Imports System.Data

Namespace DAL
    Public Class UsuarioFacade
        ' Methods
        Public Shared Sub Delete(ByVal _object As Usuario)
            Try 
                Usuario.Delete(_object)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Sub DeleteFamilias(ByVal _object As Usuario)
            Try 
                Usuario.DeleteFamilias(_object)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Sub DeletePatentes(ByVal _object As Usuario)
            Try 
                Usuario.DeletePatentes(_object)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Function GetAdapted(ByVal IdUsuario As String) As Usuario
            Dim CS$1$0000 As Usuario
            Try 
                Dim adapter As New UsuarioAdapter(UsuarioFacade.Select(IdUsuario))
                Dim _object As New Usuario
                adapter.Fill(_object)
                CS$1$0000 = _object
            Catch ex As Exception
                Throw
            End Try
            Return CS$1$0000
        End Function

        Public Shared Function GetAllAdapted() As List(Of Usuario)
            Dim CS$1$0000 As List(Of Usuario)
            Try 
                Dim adapter As New UsuarioCollectionAdapter(UsuarioFacade.SelectAll)
                Dim collection As New List(Of Usuario)
                adapter.Fill(collection)
                CS$1$0000 = collection
            Catch ex As Exception
                Throw
            End Try
            Return CS$1$0000
        End Function

        Public Shared Sub Insert(ByVal _object As Usuario)
            Try 
                Usuario.Insert(_object)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Function [Select](ByVal IdUsuario As String) As DataRow
            Dim CS$1$0000 As DataRow
            Try 
                CS$1$0000 = Usuario.Select(IdUsuario).Tables.Item(0).Rows.Item(0)
            Catch ex As Exception
                Throw
            End Try
            Return CS$1$0000
        End Function

        Public Shared Function SelectAll() As DataTable
            Dim CS$1$0000 As DataTable
            Try 
                CS$1$0000 = Usuario.SelectAll.Tables.Item(0)
            Catch ex As Exception
                Throw
            End Try
            Return CS$1$0000
        End Function

        Public Shared Sub Update(ByVal _object As Usuario)
            Try 
                Usuario.Update(_object)
            Catch ex As Exception
                Throw
            End Try
        End Sub

    End Class
End Namespace

