Namespace Funciones
    ''' <summary>
    ''' Hoy:
    ''' Devuelve Fecha Actual en variable Tipo String
    '''
    ''' Ahora:
    ''' Devuelve Fecha y Hora Actual en variable Tipo String
    '''
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Fechas

        Public Function Hoy() As String

            Return Date.Today.Date

        End Function

        Public Function Ahora() As String

            Return Date.Now

        End Function

    End Class

End Namespace