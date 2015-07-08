﻿Imports DAL.Adapters
Imports Entity
Imports System
Imports System.Collections.Generic
Imports System.Data

Namespace DAL
    Public Class FamiliaFacade
        ' Methods
        Public Shared Sub Delete(ByVal _object As Familia)
            Try 
                Familia.Delete(_object)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Sub DeleteAccesos(ByVal _object As Familia)
            Try 
                Familia.DeleteAccesos(_object)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Function GetAdapted(ByVal IdFamiliaElement As String) As Familia
            Dim CS$1$0000 As Familia
            Try 
                Dim adapter As New FamiliaAdapter(FamiliaFacade.Select(IdFamiliaElement))
                Dim _object As New Familia
                adapter.Fill(_object)
                CS$1$0000 = _object
            Catch ex As Exception
                Throw
            End Try
            Return CS$1$0000
        End Function

        Public Shared Function GetAllAdapted() As List(Of Familia)
            Dim CS$1$0000 As List(Of Familia)
            Try 
                Dim adapter As New FamiliaCollectionAdapter(FamiliaFacade.SelectAll)
                Dim collection As New List(Of Familia)
                adapter.Fill(collection)
                CS$1$0000 = collection
            Catch ex As Exception
                Throw
            End Try
            Return CS$1$0000
        End Function

        Public Shared Sub Insert(ByVal _object As Familia)
            Try 
                Familia.Insert(_object)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Function [Select](ByVal IdFamiliaElement As String) As DataRow
            Dim CS$1$0000 As DataRow
            Try 
                CS$1$0000 = Familia.Select(IdFamiliaElement).Tables.Item(0).Rows.Item(0)
            Catch ex As Exception
                Throw
            End Try
            Return CS$1$0000
        End Function

        Public Shared Function SelectAll() As DataTable
            Dim CS$1$0000 As DataTable
            Try 
                CS$1$0000 = Familia.SelectAll.Tables.Item(0)
            Catch ex As Exception
                Throw
            End Try
            Return CS$1$0000
        End Function

        Public Shared Sub Update(ByVal _object As Familia)
            Try 
                Familia.Update(_object)
            Catch ex As Exception
                Throw
            End Try
        End Sub

    End Class
End Namespace

