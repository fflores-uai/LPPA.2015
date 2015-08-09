Option Strict On
Option Explicit On
Imports System.Data.SqlClient
Imports System.Data
Imports FW.FFlores2014

Public Class DAOResources

    Dim oCon As New ConexionSqlServer()

    Dim oConexion As New SqlConnection(ConfigurationManager.ConnectionStrings.Item("ConexionAW").ToString())

    Public Function GetIdioma(nombreControl As String, idIdioma As Integer) As String


        oConexion.Open()

        Dim valor As String = ""


        Return valor

    End Function

End Class
