Imports BLL
Imports System
Imports System.Collections.Generic
Imports System.Runtime.InteropServices

Module Module1
    ' Methods
    Sub Main()


        Dim familiaObject As New Entity.Familia
        familiaObject = BLL.Familia.GetAdapted("a8a483e6-baab-42fb-a7be-c0e8093a77ab")

        Dim patenteConsulta As New Entity.Patente With { _
            .Nombre = "Pantalla de Consulta de Ventas 2" _
        }

        Patente.Insert(patenteConsulta)
        Dim familiaConsulta As New Entity.Familia With { _
            .Nombre = "Rol de Consulta de Ventas" _
        }

        familiaConsulta.Add(patenteConsulta)
        Familia.Insert(familiaConsulta)
        Dim patenteVentas As New Entity.Patente With { _
            .Nombre = "Pantalla de Ventas" _
        }

        Patente.Insert(patenteVentas)
        Dim familiaVentas As New Entity.Familia With { _
            .Nombre = "Rol Ventas" _
        }

        familiaVentas.Add(patenteVentas)
        familiaVentas.Add(familiaConsulta)
        Familia.Insert(familiaVentas)

        Dim patentePantallaUsuario As New Entity.Patente With { _
            .Nombre = "Pantalla de Administración de Perfil del Usuario" _
        }

        Patente.Insert(patentePantallaUsuario)
        Dim user As New Entity.Usuario With { _
            .Nombre = "Pedro Rodriguez" _
        }

        user.Permisos.Add(familiaVentas)
        user.Permisos.Add(patentePantallaUsuario)

        BLL.Usuario.Insert(user)
        Dim usuario As Entity.Usuario = BLL.Usuario.GetAdapted(user.IdUsuario)

        Console.WriteLine(String.Format("El usuario {0} tiene los siguientes permisos:", usuario.Nombre))
        MostrarEstructura(usuario.Permisos, "-")
        Console.ReadLine()
    End Sub

    Private Sub MostrarEstructura(ByVal familia As List(Of Entity.FamiliaElement), Optional ByVal nivel As String = "-")
        Dim siguienteNivel As String = String.Format("{0}-", nivel)
        Dim element As Entity.FamiliaElement
        For Each element In familia
            Console.WriteLine(String.Format("{0}{1}: {2}", nivel, element.GetType.Name, element.Nombre))
            If (element.ChildrenCount > 0) Then
                MostrarEstructura(TryCast(element, Entity.Familia).Accesos, siguienteNivel)
            End If
        Next
    End Sub

End Module