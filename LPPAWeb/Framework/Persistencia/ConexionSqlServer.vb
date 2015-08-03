Imports System.Data.SqlClient
Imports System.Reflection

Public Class ConexionSqlServer
    Implements IConexion

    Private _sqlConnection As SqlConnection
    Dim _unaTransaccion As SqlTransaction

    Public Sub ConexionIniciar(servidor As String, catalogo As String) Implements IConexion.ConexionIniciar

        Dim connectionString As String = ObtenerConnectionString(servidor, catalogo)

        _sqlConnection = New SqlConnection(connectionString)

        _sqlConnection.Open()

    End Sub
    Public Sub Conexioniniciar(con As String)

        _sqlConnection = New SqlConnection(con)

        _sqlConnection.Open()

    End Sub


    Public Sub ConexionIniciar(server As String, base As String, usuario As String, pass As String)

        Dim connectionString As String = "Server=" + server + ";Database=" + base + ";User Id= " + usuario + "; Password=" + pass + ";"

        _sqlConnection = New SqlConnection(connectionString)

        _sqlConnection.Open()

    End Sub

    Public Sub ConexionFinalizar() Implements IConexion.ConexionFinalizar

        _sqlConnection.Close()

    End Sub

    Public Sub TransaccionAceptar() Implements IConexion.TransaccionAceptar

        _unaTransaccion.Commit()

    End Sub

    Public Sub TransaccionCancelar() Implements IConexion.TransaccionCancelar

        _unaTransaccion.Rollback()

    End Sub

    Public Sub TransaccionIniciar() Implements IConexion.TransaccionIniciar

        _unaTransaccion = _sqlConnection.BeginTransaction()

    End Sub

    Private Function ObtenerConnectionString(servidor As String, catalogo As String) As String

        Return "Server=" + servidor + ";Database=" + catalogo + ";Trusted_Connection=True;"

    End Function



    Public Function EjecutarEscalar(consulta As String, parametros As Dictionary(Of String, Object)) As Object Implements IConexion.EjecutarEscalar

        Dim unComando As New SqlCommand()

        '1) La conexion abierta.
        unComando.Connection = _sqlConnection
        unComando.Transaction = _unaTransaccion

        '2) Texto de la consulta.
        unComando.CommandText = consulta

        For Each p In parametros
            unComando.Parameters.AddWithValue(p.Key, p.Value)
        Next

        '3) Tipo de consulta.
        unComando.CommandType = CommandType.Text

        '4) Ejecutar y esperar el resultado.
        Return unComando.ExecuteScalar()

    End Function

    Public Sub EjecutarSinResultado(consulta As String, parametros As Dictionary(Of String, Object)) Implements IConexion.EjecutarSinResultado

        Dim unComando As New SqlCommand()

        '1) La conexion abierta.
        unComando.Connection = _sqlConnection
        unComando.Transaction = _unaTransaccion

        '2) Texto de la consulta.
        unComando.CommandText = consulta

        For Each p In parametros
            unComando.Parameters.AddWithValue(p.Key, p.Value)
        Next

        '3) Tipo de consulta.
        unComando.CommandType = CommandType.Text

        '4) Ejecutar y esperar el resultado.
        unComando.ExecuteNonQuery()
    End Sub

    Public Function EjecutarTupla(Of T As {New, IConexionEjecutarResultado})(consulta As String, parametros As Dictionary(Of String, Object)) As List(Of T) Implements IConexion.EjecutarTupla

        Dim unComando As New SqlCommand()

        '1) La conexion abierta.
        unComando.Connection = _sqlConnection
        unComando.Transaction = _unaTransaccion

        '2) Texto de la consulta.
        unComando.CommandText = consulta

        For Each p In parametros
            unComando.Parameters.AddWithValue(p.Key, p.Value)
        Next

        '3) Tipo de consulta.
        unComando.CommandType = CommandType.Text

        '4) Ejecutar y esperar el resultado.
        Dim resultadoDataReader = unComando.ExecuteReader()

        Dim resultadoFinal As New List(Of T)

        Do While resultadoDataReader.Read()

            Dim resultadoObjeto As New T

            For i = 0 To resultadoDataReader.FieldCount - 1

                Dim nombreColumna As String = resultadoDataReader.GetName(i)
                Dim valorColumna As Object = resultadoDataReader(i)

                Dim pi As PropertyInfo = resultadoObjeto.GetType().GetProperty(nombreColumna)
                pi.SetValue(resultadoObjeto, valorColumna)

            Next

            resultadoFinal.Add(resultadoObjeto)
        Loop

        resultadoDataReader.Close()

        Return resultadoFinal

    End Function

End Class