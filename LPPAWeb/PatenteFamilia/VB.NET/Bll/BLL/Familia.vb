Imports DAL
Imports Entity
Imports System
Imports System.Collections.Generic
Imports System.Data

Namespace BLL
    Public Class Familia
        ' Methods
        Public Shared Sub Delete(ByVal _object As Entity.Familia)
            Try
                FamiliaFacade.Delete(_object)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Shared Sub DeleteAccesos(ByVal _object As Entity.Familia)
            Try
                FamiliaFacade.DeleteAccesos(_object)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Shared Function GetAdapted(ByVal IdFamiliaElement As String) As Entity.Familia
            Dim var As Entity.Familia
            Try
                var = FamiliaFacade.GetAdapted(IdFamiliaElement)
            Catch ex As Exception
                Throw ex
            End Try
            Return var
        End Function

        Public Shared Function GetAllAdapted() As List(Of Entity.Familia)
            Dim var As List(Of Entity.Familia)
            Try
                var = FamiliaFacade.GetAllAdapted
            Catch ex As Exception
                Throw ex
            End Try
            Return var
        End Function

        Public Shared Sub Insert(ByVal _object As Entity.Familia)
            Try
                FamiliaFacade.Insert(_object)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Shared Function [Select](ByVal IdFamiliaElement As String) As DataRow
            Dim var As DataRow
            Try
                var = FamiliaFacade.Select(IdFamiliaElement)
            Catch ex As Exception
                Throw ex
            End Try
            Return var
        End Function

        Public Shared Function SelectAll() As DataTable
            Dim var As DataTable
            Try 
                var = FamiliaFacade.SelectAll
            Catch ex As Exception
                Throw ex
            End Try
            Return var
        End Function

        Public Shared Sub Update(ByVal _object As Entity.Familia)
            Try
                FamiliaFacade.Update(_object)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

    End Class
End Namespace

