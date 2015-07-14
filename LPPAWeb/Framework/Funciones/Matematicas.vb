Imports FW.FFlores2014.Excepciones

Namespace Funciones
    ''' <summary>
    ''' Numero Aleatorio:
    ''' Recibe un numero minimo y maximo
    ''' Devuelve un numero Aleatorio Tipo Integer
    '''
    ''' Promedio:
    ''' Recibe un array de Doubles
    ''' Devuelve el Promedio Tipo Double
    '''
    ''' Obtener Porcentaje:
    ''' Recibe el Valor Actual y el Valor Total
    ''' Devuelve el porcentaje Tipo Double
    '''
    ''' Obtener Valor Del Porcentaje:
    ''' Recive Valor Total y PorcentajeRequerido
    ''' Devuelve el valor como Resultado en Tipo Double
    '''
    ''' </summary>
    ''' <remarks></remarks>

    Public Class Matematicas

        Public Function Promedio(ParamArray valores() As Double) As Double 'el param array se re copa y te deja poner muchos variables

            Dim acumulador As Double

            For Each valor In valores
                acumulador += valor
            Next
            Return acumulador / valores.Length 'Valores.Lenght es la cantidad de items

        End Function

        Private Shared numeroAleatorio As New Random
        Public Function ObtenerNumeroAleatorio(valorDesde As Integer, valorHasta As Integer) As Integer

            ' Return numeroAleatorio.Next(valorDesde, valorHasta + 1)
            Return ObtenerNumeroAleatorio(CDbl(valorDesde), CDbl(valorHasta)) 'llama a la que tiene mas parametros

        End Function

        Public Function ObtenerNumeroAleatorio(valorDesde As Double, valorHasta As Double) As Integer

            If valorDesde > valorHasta Then 'si el user puso los valores mal llama a la excepcion

                Throw New FrameworkException(New Exception("ElValor desde es menor al HAsta!"))

            End If

            Return numeroAleatorio.Next(valorDesde, valorHasta + 1)

        End Function

        Public Function ObtenerPorcentaje(valorEvaluar As Double, valorTotal As Double) As Double

            Return (valorEvaluar * valorTotal) / 100

        End Function

        Public Function ObtenerValorDelPorcentaje(valorPorcentaje As Double, valorTotal As Double) As Double

            Return (valorTotal * 100) / valorPorcentaje

        End Function

    End Class
End Namespace