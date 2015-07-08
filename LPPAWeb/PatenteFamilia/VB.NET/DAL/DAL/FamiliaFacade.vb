Imports DAL.Adapters
Imports Entity
Imports System
Imports System.Collections.Generic
Imports System.Data

Namespace DAL
    Public Class FamiliaFacade
        ' Methods
        Public Shared Sub Delete(ByVal _object As Entity.Familia)
            Try
                Familia.Delete(_object)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Sub DeleteAccesos(ByVal _object As Entity.Familia)
            Try
                Familia.DeleteAccesos(_object)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Function GetAdapted(ByVal IdFamiliaElement As String) As Entity.Familia
            Dim varDataTable As Entity.Familia
            Try
                Dim adapter As New FamiliaAdapter(FamiliaFacade.Select(IdFamiliaElement))
                Dim _object As New Entity.Familia
                adapter.Fill(_object)
                varDataTable = _object
            Catch ex As Exception
                Throw
            End Try
            Return varDataTable
        End Function

        Public Shared Function GetAllAdapted() As List(Of Entity.Familia)
            Dim varDataTable As List(Of Entity.Familia)
            Try
                Dim adapter As New FamiliaCollectionAdapter(FamiliaFacade.SelectAll)
                Dim collection As New List(Of Entity.Familia)
                adapter.Fill(collection)
                varDataTable = collection
            Catch ex As Exception
                Throw
            End Try
            Return varDataTable
        End Function

        Public Shared Sub Insert(ByVal _object As Entity.Familia)
            Try
                Familia.Insert(_object)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Function [Select](ByVal IdFamiliaElement As String) As DataRow
            Dim varDataTable As DataRow
            Try 
                varDataTable = Familia.Select(IdFamiliaElement).Tables.Item(0).Rows.Item(0)
            Catch ex As Exception
                Throw
            End Try
            Return varDataTable
        End Function

        Public Shared Function SelectAll() As DataTable
            Dim varDataTable As DataTable
            Try 
                varDataTable = Familia.SelectAll.Tables.Item(0)
            Catch ex As Exception
                Throw
            End Try
            Return varDataTable
        End Function

        Public Shared Sub Update(ByVal _object As Entity.Familia)
            Try
                Familia.Update(_object)
            Catch ex As Exception
                Throw
            End Try
        End Sub

    End Class
End Namespace

