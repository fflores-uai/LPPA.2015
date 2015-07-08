Imports DAL
Imports Entity
Imports System
Imports System.Data

Namespace DAL.Adapters
    Public Class UsuarioAdapter
        ' Methods
        Public Sub New(ByVal row As DataRow)
            Me.row = row
        End Sub

        Public Sub Fill(ByVal _object As Usuario)
            Dim Permisos As FamiliaElement
            _object.set_IdUsuario(CStr(Me.row.Item("IdUsuario")))
            _object.set_Nombre(CStr(Me.row.Item("Nombre")))
            Dim relacionesFamilia As DataTable = Usuario.GetFamilias(_object.get_IdUsuario)
            Dim rowPermisos As DataRow
            For Each rowPermisos In relacionesFamilia.Rows
                Permisos = FamiliaFacade.GetAdapted(CStr(rowPermisos.Item("IdFamilia")))
                _object.get_Permisos.Add(Permisos)
            Next
            Dim relacionesPatente As DataTable = Usuario.GetPatentes(_object.get_IdUsuario)
            Dim rowPermisos As DataRow
            For Each rowPermisos In relacionesPatente.Rows
                Permisos = PatenteFacade.GetAdapted(CStr(rowPermisos.Item("IdPatente")))
                _object.get_Permisos.Add(Permisos)
            Next
        End Sub


        ' Fields
        Private row As DataRow
    End Class
End Namespace

