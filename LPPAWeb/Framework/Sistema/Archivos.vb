Imports FW.FFlores2014.Interfaces


Namespace Sistema
    ''' <summary>
    ''' GuardarArchivo:
    ''' Recibe "path completo del archivo" y texto a grabar
    ''' Guarda texto en el archivo linea por linea
    ''' 
    ''' GuardarAppendArchivo:
    ''' Recibe "path completo del archivo" y texto a grabar
    ''' Agrega al archivo el texto recibido en una linea nueva
    ''' 
    ''' GuardarArchivoConfiguracion':
    ''' Recibe "path completo del archivo" y contenido a grabar
    ''' Guarda "un dato:texto" y hace linea nueva
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Archivos

        Public Shared Sub GuardarArchivo(contenido As String, nombreArchivo As String)

            System.IO.File.WriteAllText(nombreArchivo, contenido)

        End Sub

        Public Shared Sub GuardarAppendArchivo(contenido As String, nombreArchivo As String)

            System.IO.File.AppendAllText(nombreArchivo, contenido)

        End Sub

        Public Shared Sub GuardarArchivoConfiguracion(UnaConfiguracion As IArchivoConfiguracion, nombreArchivo As String)

            Dim acumuladora As String = ""

            For Each renglon In UnaConfiguracion.Contenido

                acumuladora += renglon.Key & ":" & renglon.Value + Environment.NewLine 'el env.newlines es como un /n en C++

            Next

            GuardarArchivo(acumuladora, nombreArchivo)

        End Sub

        Public Function ListarArchivos(directorio As String) As List(Of String)

            Dim listaArchivos As List(Of String) = New List(Of String)

            Dim folder As New System.IO.DirectoryInfo(directorio)

            For Each file As System.IO.FileInfo In folder.GetFiles()
                '  MsgBox(file.Name)
                listaArchivos.Add(file.Name)
            Next

            Return listaArchivos

        End Function


        Public Shared Function AbrirArchivo(NombreArchivo As String)

            Dim texto As String = System.IO.File.ReadAllText(NombreArchivo)

            Return texto

        End Function

    End Class
End Namespace