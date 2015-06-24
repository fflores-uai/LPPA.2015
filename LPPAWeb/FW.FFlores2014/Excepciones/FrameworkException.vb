Namespace Excepciones
    ''' <summary>
    ''' 
    ''' Manejo de Excepciones
    ''' FrameworkException
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Class FrameworkException
        Inherits Exception

        Public Sub New()

        End Sub

        Public Sub New(excepcionInterna As Exception)

            MyBase.New("", excepcionInterna)

        End Sub

        Public Overrides ReadOnly Property Message As String
            Get
                Return "Ha ocurrido un error en el Framework :P (puede fallar)"
            End Get
        End Property

    End Class

End Namespace
