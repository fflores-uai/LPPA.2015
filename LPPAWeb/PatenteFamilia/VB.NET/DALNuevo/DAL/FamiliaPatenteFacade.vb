Imports System
Imports System.Data

Namespace DAL
    Public Class FamiliaPatenteFacade
        ' Methods
        Public Shared Function [Select](ByVal IdFamiliaElement As String) As DataRow
            Dim CS$1$0000 As DataRow
            Try 
                CS$1$0000 = Familia_Patente.Select(IdFamiliaElement).Tables.Item(0).Rows.Item(0)
            Catch ex As Exception
                Throw
            End Try
            Return CS$1$0000
        End Function

    End Class
End Namespace

