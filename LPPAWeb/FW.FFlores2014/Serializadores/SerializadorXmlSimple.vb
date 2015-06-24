
Imports System.Xml
Imports System.Text
Namespace Serializadores


    Public Class SerializadorXmlSimple
        Implements ISerializador
        Dim documentoXml As XmlWriter

        Public Function DeSerializar(Of T As New)(unObjetoSerializado As String) As List(Of T) Implements ISerializador.DeSerializar

            '1 Crea una instacia del resuiltado
            Dim resultado As New List(Of T)

            '2 Parsear XML
            Dim xdoc = XDocument.Parse(unObjetoSerializado)

            '3 ForEach del Objeto
            Dim nodoRaiz As XElement = xdoc.LastNode

            For Each nodo As XElement In nodoRaiz.Nodes
                For Each elementosDelNodo As XElement In nodo.Nodes

                    Dim nombreProperty As String = elementosDelNodo.Name.ToString
                    Dim valorProperty As Object = elementosDelNodo.Value

                    '4 Reflection por cada ELEMENTO
                    Dim unObjetoMapeado As New T
                    Dim pp = unObjetoMapeado.GetType.GetProperty(nombreProperty)

                    '5 Mapear el elemento hacia la property

                    pp.SetValue(unObjetoMapeado, valorProperty)

                    resultado.Add(unObjetoMapeado)

                Next
            Next

            'Ultimo deberia return del resultado
            Return resultado

        End Function

        Public Function Serializar(unObjeto As List(Of Object)) As String Implements ISerializador.Serializar
            'ABRO
            Dim configuracionXml As New XmlWriterSettings()
            configuracionXml.Indent = 2

            Dim sb As New StringBuilder

            documentoXml = XmlWriter.Create(sb, configuracionXml)
            documentoXml.WriteStartDocument(True)

            'GENERO LA RAIZ
            documentoXml.WriteStartElement(unObjeto.First.GetType.Name.ToString + "s")

            'RECORRO LA LISTA DE OBJETOS
            For Each item In unObjeto

                documentoXml.WriteStartElement(item.GetType.Name)
                For Each pp In item.GetType().GetProperties()
                    Dim valor = pp.GetValue(item)
                    documentoXml.WriteElementString(pp.Name, valor)
                Next
                'CIERRO RAIZ
                documentoXml.WriteEndElement()
            Next

            'CIERRO XML
            documentoXml.WriteEndDocument()
            documentoXml.Close()

            Return sb.ToString()

        End Function
    End Class
End Namespace