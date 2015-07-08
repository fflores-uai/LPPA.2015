Imports DAL.Adapters
Imports Entity
Imports System
Imports System.Collections.Generic
Imports System.Data

Namespace DAL
    Public Class PatenteFacade
        ' Methods
        Public Shared Sub Delete(ByVal _object As Patente)
            Try 
                Patente.Delete(_object)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Function GetAdapted(ByVal IdFamiliaElement As String) As Patente
            Dim CS$1$0000 As Patente
            Try 
                Dim adapter As New PatenteAdapter(PatenteFacade.Select(IdFamiliaElement))
                Dim _object As New Patente
                adapter.Fill(_object)
                CS$1$0000 = _object
            Catch ex As Exception
                Throw
            End Try
            Return CS$1$0000
        End Function

        Public Shared Function GetAllAdapted() As List(Of Patente)
            Dim CS$1$0000 As List(Of Patente)
            Try 
                Dim adapter As New PatenteCollectionAdapter(PatenteFacade.SelectAll)
                Dim collection As New List(Of Patente)
                adapter.Fill(collection)
                CS$1$0000 = collection
            Catch ex As Exception
                Throw
            End Try
            Return CS$1$0000
        End Function

        Public Shared Sub Insert(ByVal _object As Patente)
            Try 
                Patente.Insert(_object)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Function [Select](ByVal IdFamiliaElement As String) As DataRow
            Dim CS$1$0000 As DataRow
            Try 
                CS$1$0000 = Patente.Select(IdFamiliaElement).Tables.Item(0).Rows.Item(0)
            Catch ex As Exception
                Throw
            End Try
            Return CS$1$0000
        End Function

        Public Shared Function SelectAll() As DataTable
            Dim CS$1$0000 As DataTable
            Try 
                CS$1$0000 = Patente.SelectAll.Tables.Item(0)
            Catch ex As Exception
                Throw
            End Try
            Return CS$1$0000
        End Function

        Public Shared Sub Update(ByVal _object As Patente)
            Try 
                Patente.Update(_object)
            Catch ex As Exception
                Throw
            End Try
        End Sub

    End Class
End Namespace

