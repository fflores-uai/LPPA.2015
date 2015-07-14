Public Interface IConexion

    Sub ConexionIniciar(servidor As String, catalogo As String)
    Sub ConexionFinalizar()

    Sub TransaccionIniciar()
    Sub TransaccionAceptar()
    Sub TransaccionCancelar()

    Sub EjecutarSinResultado(consulta As String, parametros As Dictionary(Of String, Object))
    Function EjecutarEscalar(consulta As String, parametros As Dictionary(Of String, Object)) As Object
    Function EjecutarTupla(Of T As {New, IConexionEjecutarResultado})(consulta As String, parametros As Dictionary(Of String, Object)) As List(Of T)

End Interface
