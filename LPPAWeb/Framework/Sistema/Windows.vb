Namespace Sistema
    ''' <summary>
    ''' Apagar:
    ''' Apaga la PC
    '''
    ''' Reiniciar:
    ''' Reinicia la PC
    '''
    ''' Cerrar Sesion:
    ''' Cierra la sesion
    '''
    ''' </summary>
    ''' <remarks></remarks>
    '''

    Public Class Windows

        Public Sub Apagar()
            System.Diagnostics.Process.Start("shutdown.exe", "-s -f -t 1")
        End Sub

        Public Sub Reiniciar()
            System.Diagnostics.Process.Start("shutdown.exe", "-s -f -t 1")
        End Sub

        Public Sub CerrarSesion()
            System.Diagnostics.Process.Start("shutdown.exe", "-s -f -t 1")
        End Sub

    End Class

End Namespace