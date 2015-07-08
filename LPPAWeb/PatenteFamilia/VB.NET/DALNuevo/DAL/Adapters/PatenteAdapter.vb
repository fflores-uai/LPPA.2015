Imports Entity
Imports System
Imports System.Data

Namespace DAL.Adapters
    Public Class PatenteAdapter
        ' Methods
        Public Sub New(ByVal row As DataRow)
            Me.row = row
        End Sub

        Public Sub Fill(ByVal _object As Patente)
            _object.set_IdFamiliaElement(CStr(Me.row.Item("IdPatente")))
            _object.set_Nombre(CStr(Me.row.Item("Nombre")))
        End Sub


        ' Fields
        Private row As DataRow
    End Class
End Namespace

