Imports System.Xml.Serialization

Public Class SerializadorXmlComplejo

    Public Function Deserealizar(Of T As New)(unObjetoSerializado As String) As T

        Dim xs As New XmlSerializer(GetType(T))

        Dim resultado = xs.Deserialize(New System.IO.MemoryStream(CadenaABytes(unObjetoSerializado)))

        Return resultado

    End Function

    Public Function Serializar(unObjeto As Object) As String

        Dim xs As New XmlSerializer(unObjeto.GetType())

        Dim unStream As System.IO.Stream = New System.IO.MemoryStream()

        xs.Serialize(unStream, unObjeto)

        Return StreamACadena(unStream)

    End Function

    Private Function CadenaABytes(unObjetoSerializado As String) As Byte()

        Return System.Text.Encoding.ASCII.GetBytes(unObjetoSerializado)

    End Function

    Private Function StreamACadena(unStream As IO.Stream) As String

        Dim bytes As Byte() = New Byte(CInt(unStream.Length)) {}
        unStream.Position = 0
        unStream.Read(bytes, 0, CType(unStream.Length, Integer))

        Return System.Text.Encoding.ASCII.GetString(bytes)

    End Function

End Class