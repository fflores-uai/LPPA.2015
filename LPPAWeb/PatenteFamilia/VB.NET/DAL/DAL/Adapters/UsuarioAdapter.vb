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

        Public Sub Fill(ByVal _object As Entity.Usuario)
            Dim Permisos As FamiliaElement
            _object.IdUsuario = (CStr(Me.row.Item("IdUsuario")))
            _object.Nombre = (CStr(Me.row.Item("Nombre")))
            Dim relacionesFamilia As DataTable = Usuario.GetFamilias(_object.IdUsuario)
            Dim rowPermisos As DataRow

            For Each rowPermisos In relacionesFamilia.Rows
                Permisos = FamiliaFacade.GetAdapted(CStr(rowPermisos.Item("IdFamilia")))
                _object.Permisos.Add(Permisos)
            Next
            Dim relacionesPatente As DataTable = Usuario.GetPatentes(_object.IdUsuario)

            For Each rowPermisos In relacionesPatente.Rows
                Permisos = PatenteFacade.GetAdapted(CStr(rowPermisos.Item("IdPatente")))
                _object.Permisos.Add(Permisos)
            Next
        End Sub


        ' Fields
        Private row As DataRow
    End Class
End Namespace

