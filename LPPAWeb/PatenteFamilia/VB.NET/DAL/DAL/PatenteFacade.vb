Imports DAL.Adapters
Imports Entity
Imports System
Imports System.Collections.Generic
Imports System.Data

Namespace DAL
    Public Class PatenteFacade
        ' Methods
        Public Shared Sub Delete(ByVal _object As Entity.Patente)
            Try
                Patente.Delete(_object)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Function GetAdapted(ByVal IdFamiliaElement As String) As Entity.Patente
            Dim varDataTable As Entity.Patente
            Try
                Dim adapter As New PatenteAdapter(PatenteFacade.Select(IdFamiliaElement))
                Dim _object As New Entity.Patente
                adapter.Fill(_object)
                varDataTable = _object
            Catch ex As Exception
                Throw
            End Try
            Return varDataTable
        End Function

        Public Shared Function GetAllAdapted() As List(Of Entity.Patente)
            Dim varDataTable As List(Of Entity.Patente)
            Try
                Dim adapter As New PatenteCollectionAdapter(PatenteFacade.SelectAll)
                Dim collection As New List(Of Entity.Patente)
                adapter.Fill(collection)
                varDataTable = collection
            Catch ex As Exception
                Throw
            End Try
            Return varDataTable
        End Function

        Public Shared Sub Insert(ByVal _object As Entity.Patente)
            Try
                Patente.Insert(_object)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Function [Select](ByVal IdFamiliaElement As String) As DataRow
            Dim varDataTable As DataRow
            Try 
                varDataTable = Patente.Select(IdFamiliaElement).Tables.Item(0).Rows.Item(0)
            Catch ex As Exception
                Throw
            End Try
            Return varDataTable
        End Function

        Public Shared Function SelectAll() As DataTable
            Dim varDataTable As DataTable
            Try 
                varDataTable = Patente.SelectAll.Tables.Item(0)
            Catch ex As Exception
                Throw
            End Try
            Return varDataTable
        End Function

        Public Shared Sub Update(ByVal _object As Entity.Patente)
            Try
                Patente.Update(_object)
            Catch ex As Exception
                Throw
            End Try
        End Sub

    End Class
End Namespace

