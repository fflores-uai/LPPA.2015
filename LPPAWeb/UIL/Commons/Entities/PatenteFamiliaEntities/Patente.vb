Imports System

Namespace Entities
    Public Class Patente
        Inherits FamiliaElement
        ' Methods
        Public Overrides Sub Add(ByVal d As FamiliaElement)
            Throw New Exception("No se puede agregar una patente")
        End Sub

        Public Overrides Sub Remove(ByVal d As FamiliaElement)
            Throw New Exception("No se puede quitar una patente")
        End Sub


        ' Properties
        Public Overrides ReadOnly Property ChildrenCount As Integer
            Get
                Return 0
            End Get
        End Property

    End Class
End Namespace

