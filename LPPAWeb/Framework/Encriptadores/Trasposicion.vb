Namespace Encriptadores
    ''' <summary>
    ''' Encriptar:
    ''' Recibe una variable tipo String;
    ''' Suma 32 posiciones ASCII a cada caracter;
    ''' Devuelve variable tipo String con la palabra "encriptada".
    ''' 
    ''' Desencriptar:
    ''' Recibe una variable tipo String;
    ''' Resta 32 posiciones ASCII a cada caracter;
    ''' Devuelve variable tipo String con la palabra "desencriptada".
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Trasposicion

        Public Function Encriptar(texto As String) As String

            Dim resultado As String = ""

            For Each s In texto

                Dim letraAscii As Integer = Asc(s) + 32

                resultado = resultado & Chr(letraAscii).ToString()

            Next

            Return resultado

        End Function


        Public Function Desencriptar(texto As String) As String

            Dim resultado As String = ""

            For Each s In texto

                Dim letraAscii As Integer = Asc(s) - 32

                resultado = resultado & Chr(letraAscii).ToString()

            Next

            Return resultado

        End Function

    End Class

End Namespace
