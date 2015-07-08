Imports System
Imports System.Runtime.CompilerServices

Namespace Entity
    Public MustInherit Class FamiliaElement
        ' Methods
        Public Sub New()
            Me.IdFamiliaElement = Guid.NewGuid.ToString
        End Sub

        Public MustOverride Sub Add(ByVal d As FamiliaElement)

        Public MustOverride Sub Remove(ByVal d As FamiliaElement)

        ' Properties
        Public MustOverride ReadOnly Property ChildrenCount As Integer


        Private idFamiliaElemento As String
        Public Property IdFamiliaElement() As String
            Get
                Return idFamiliaElemento
            End Get
            Set(ByVal value As String)
                idFamiliaElemento = value
            End Set
        End Property

        Private nombreN As String
        Public Property Nombre() As String
            Get
                Return nombreN
            End Get
            Set(ByVal value As String)
                nombreN = value
            End Set
        End Property
    End Class
End Namespace

