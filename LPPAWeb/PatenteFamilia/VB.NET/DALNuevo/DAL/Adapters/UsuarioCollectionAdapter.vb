﻿Imports Entity
Imports System
Imports System.Collections.Generic
Imports System.Data

Namespace DAL.Adapters
    Public Class UsuarioCollectionAdapter
        ' Methods
        Public Sub New(ByVal datosDT As DataTable)
            Me.datosDT = datosDT
        End Sub

        Public Sub Fill(ByVal collection As List(Of Usuario))
            Dim row As DataRow
            For Each row In Me.datosDT.Rows
                Dim _object As New Usuario
                New UsuarioAdapter(row).Fill(_object)
                collection.Add(_object)
            Next
        End Sub


        ' Fields
        Private datosDT As DataTable
    End Class
End Namespace

