Imports DAL
Imports Entity
Imports System
Imports System.Collections.Generic
Imports System.Data

Namespace BLL
    Public Class Usuario
        ' Methods
        Public Shared Sub Delete(ByVal _object As Entity.Usuario)
            Try
                UsuarioFacade.Delete(_object)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Function GetAdapted(ByVal IdUsuario As String) As Entity.Usuario
            Dim var As Entity.Usuario
            Try
                var = UsuarioFacade.GetAdapted(IdUsuario)
            Catch ex As Exception
                Throw
            End Try
            Return var
        End Function

        Public Shared Function GetAllAdapted() As List(Of Entity.Usuario)
            Dim var As List(Of Entity.Usuario)
            Try
                var = UsuarioFacade.GetAllAdapted
            Catch ex As Exception
                Throw
            End Try
            Return var
        End Function

        Public Shared Sub Insert(ByVal _object As Entity.Usuario)
            Try
                UsuarioFacade.Insert(_object)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Function [Select](ByVal IdUsuario As String) As DataRow
            Dim var As DataRow
            Try 
                var = UsuarioFacade.Select(IdUsuario)
            Catch ex As Exception
                Throw
            End Try
            Return var
        End Function

        Public Shared Function SelectAll() As DataTable
            Dim var As DataTable
            Try 
                var = UsuarioFacade.SelectAll
            Catch ex As Exception
                Throw
            End Try
            Return var
        End Function

        Public Shared Sub Update(ByVal _object As Entity.Usuario)
            Try
                UsuarioFacade.Update(_object)
            Catch ex As Exception
                Throw
            End Try
        End Sub

    End Class
End Namespace

