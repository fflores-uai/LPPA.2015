Imports System
Imports System.Collections.Generic

Namespace Entities
    Public Class Usuario
        ' Properties
        Public Property IdUsuario As String
            Get
                Return Me._idUsuario
            End Get
            Set(ByVal value As String)
                Me._idUsuario = value
            End Set
        End Property

        Public Property Nombre As String
            Get
                Return Me._nombre
            End Get
            Set(ByVal value As String)
                Me._nombre = value
            End Set
        End Property

        Public Property Permisos As List(Of FamiliaElement)
            Get
                Return Me._permisos
            End Get
            Set(ByVal value As List(Of FamiliaElement))
                Me._permisos = value
            End Set
        End Property


        ' Fields
        Private _idUsuario As String = Guid.NewGuid.ToString
        Private _nombre As String
        Private _permisos As List(Of FamiliaElement) = New List(Of FamiliaElement)
    End Class
End Namespace

