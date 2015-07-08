Imports System
Imports System.Data

Namespace DAL
    Public Class FamiliaPatenteFacade
        ' Methods
        Public Shared Function [Select](ByVal IdFamiliaElement As String) As DataRow
            Dim varDataTable As DataRow
            Try 
                varDataTable = Familia_Patente.Select(IdFamiliaElement).Tables.Item(0).Rows.Item(0)
            Catch ex As Exception
                Throw
            End Try
            Return varDataTable
        End Function

    End Class
End Namespace

