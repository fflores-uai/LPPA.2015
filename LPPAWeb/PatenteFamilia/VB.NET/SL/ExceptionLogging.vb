Imports Microsoft.Practices.EnterpriseLibrary.Logging
Imports Microsoft.Practices.EnterpriseLibrary.ExceptionHandling

Public Class ExceptionLogging

    Public Shared Sub HandleException(ByVal ex As Exception)
        'ExceptionLogging.LogWriter(ex.Message)
        'ExceptionPolicy.HandleException(ex, "Exception Policy")
    End Sub


    Public Shared Sub LogWriter(ByVal message As String)
        'Dim logentry As New LogEntry With { _
        '                                   .Message = message, _
        '                                   .Title = "Program", _
        '                                   .TimeStamp = DateTime.Now _
        '                               }
        'Logger.Write(logentry)
    End Sub

End Class
