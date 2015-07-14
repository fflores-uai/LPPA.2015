Namespace Serializadores


    Public Interface ISerializador

        Function Serializar(unObjeto As List(Of Object)) As String
        Function DeSerializar(Of T As New)(unObjetoSerializado As String) As List(Of T)

    End Interface
End Namespace
