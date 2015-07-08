Imports DAL
Imports Entity
Imports System
Imports System.Collections.Generic
Imports System.Data

Namespace BLL
    Public Class Patente
        ' Methods
        Public Shared Sub Delete(ByVal _object As Entity.Patente)
            Try
                PatenteFacade.Delete(_object)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Function GetAdapted(ByVal IdFamiliaElement As String) As Entity.Patente
            Dim var As Entity.Patente
            Try
                var = PatenteFacade.GetAdapted(IdFamiliaElement)
            Catch ex As Exception
                Throw
            End Try
            Return var
        End Function

        Public Shared Function GetAllAdapted() As List(Of Entity.Patente)
            Dim var As List(Of Entity.Patente)
            Try
                var = PatenteFacade.GetAllAdapted
            Catch ex As Exception
                Throw
            End Try
            Return var
        End Function

        Public Shared Sub Insert(ByVal _object As Entity.Patente)
            Try
                PatenteFacade.Insert(_object)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Function [Select](ByVal IdFamiliaElement As String) As DataRow
            Dim var As DataRow
            Try 
                var = PatenteFacade.Select(IdFamiliaElement)
            Catch ex As Exception
                Throw
            End Try
            Return var
        End Function

        Public Shared Function SelectAll() As DataTable
            Dim var As DataTable
            Try 
                var = PatenteFacade.SelectAll
            Catch ex As Exception
                Throw
            End Try
            Return var
        End Function

        Public Shared Sub Update(ByVal _object As Entity.Patente)
            Try
                PatenteFacade.Update(_object)
            Catch ex As Exception
                Throw
            End Try
        End Sub

    End Class
End Namespace

