Imports Newtonsoft.Json

Namespace Serializadores
    Public Class SerializadorXmlJSon
        Implements ISerializador

        Public Function DeSerializar(Of T As New)(unObjetoSerializado As String) As List(Of T) Implements ISerializador.DeSerializar

            Return Nothing

        End Function

        Public Function Serializar(unObjeto As List(Of Object)) As String Implements ISerializador.Serializar

            Return Nothing
        End Function
    End Class
End Namespace