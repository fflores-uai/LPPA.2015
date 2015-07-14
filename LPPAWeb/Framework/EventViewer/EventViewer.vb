Imports System.Diagnostics.EventLog

Public Class EventViewer

    Public Shared Sub LogInfomacion(origen As String, mensaje As String)
        EventLog.WriteEntry(origen, mensaje, EventLogEntryType.Information)

    End Sub

    Public Shared Sub LogCritico(origen As String, mensaje As String)

        EventLog.WriteEntry(origen, mensaje, EventLogEntryType.Error)

    End Sub

    Public Shared Sub LogWarning(origen As String, mensaje As String)

        EventLog.WriteEntry(origen, mensaje, EventLogEntryType.Warning)
    End Sub

End Class