Imports System.Text.RegularExpressions

Public Class ExpresionRegular

    Public Function ValidarRegex(laExpresion As String, laCadena As String) As Boolean

        Dim patron As New Regex(laExpresion)

        Dim valor = patron.IsMatch(laCadena)

        Return valor
    End Function



End Class
