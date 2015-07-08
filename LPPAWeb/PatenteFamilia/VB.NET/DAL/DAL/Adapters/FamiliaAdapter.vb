Imports DAL
Imports Entity
Imports System
Imports System.Data

Namespace DAL.Adapters
    Public Class FamiliaAdapter
        ' Methods
        Public Sub New(ByVal row As DataRow)
            Me.row = row
        End Sub

        Public Sub Fill(ByVal _object As Entity.Familia)
            _object.IdFamiliaElement = (CStr(Me.row.Item("IdFamilia")))
            _object.Nombre = (CStr(Me.row.Item("Nombre")))
            Dim relacionesFamilia As DataTable = Familia.GetAccesos(_object.IdFamiliaElement)
            Dim rowAccesos As DataRow

            For Each rowAccesos In relacionesFamilia.Rows
                _object.Add(FamiliaFacade.GetAdapted(CStr(rowAccesos.Item("IdFamiliaHijo"))))
            Next

            Dim relacionesPatentes As DataTable = Familia_Patente.GetAccesos(_object.IdFamiliaElement)

            For Each rowAccesos In relacionesPatentes.Rows
                _object.Add(PatenteFacade.GetAdapted(CStr(rowAccesos.Item("IdPatente"))))
            Next
        End Sub


        ' Fields
        Private row As DataRow
    End Class
End Namespace

