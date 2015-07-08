Imports System
Imports System.Collections.Generic

Namespace Entities
    Public Class Familia
        Inherits FamiliaElement
        ' Methods
        Public Overrides Sub Add(ByVal d As FamiliaElement)
            Me._accesos.Add(d)
        End Sub

        Public Overrides Sub Remove(ByVal d As FamiliaElement)
            Me._accesos.Remove(d)
        End Sub


        ' Properties
        Public Property Accesos As List(Of FamiliaElement)
            Get
                Return Me._accesos
            End Get
            Set(ByVal value As List(Of FamiliaElement))
                Me._accesos = value
            End Set
        End Property

        Public Overrides ReadOnly Property ChildrenCount As Integer
            Get
                Return Me.Accesos.Count
            End Get
        End Property


        ' Fields
        Private _accesos As List(Of FamiliaElement) = New List(Of FamiliaElement)
    End Class
End Namespace

