Namespace Funciones
    ''' <summary>
    ''' Unir Lista:
    ''' Recibe una lista de Tipo String
    ''' Devuelve una variable String con la lista unida, separada por ";"
    ''' 
    ''' Separar Lista:
    ''' Recibe un texto, ejemplo “bart|lisa|homero”
    ''' Recibe un carácter separador = “|”
    ''' El resultado es una lista, que dentro tenga {bart, lisa, homero}
    ''' El carácter separador desaparece.
    ''' Devuelve Tipo Lista(String)
    ''' 
    ''' Decorar Lista:
    ''' Recibe una lista de tipo String
    ''' Le agrega a la lista "-->" al comienzo de cada item
    ''' Devuelve Tipo Lista(String)
    ''' 
    ''' Reemplazar:
    ''' Reemplazar(cadenaOriginal, cadenaBuscar, cadenaReemplazar)
    ''' Recibe un texto original ej: “el teclado es negro”
    ''' Recibe una cadena a buscar: ejemplo “e”
    ''' Recibe el valor que debe reemplazar en el texto buscado, ejemplo: “@”
    ''' El resultado es: “@l t@clado @s n@gro”
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Cadenas

        Public Function Reemplazar(cadenaOriginal As String, CadenaBuscar As String, cadenaReemplazar As String) As String

            Dim cadenaReemplazada As String = ""

            cadenaReemplazada = cadenaOriginal.Replace(CadenaBuscar, cadenaReemplazar)

            Return cadenaReemplazada

        End Function

        Public Function SepararLista() As String()

            Dim cadenaOriginal As String = "bart|lisa|maggie|Homero"

            Dim palabra As String() = cadenaOriginal.Split(New Char() {"|"c})
            'solo pude poner un caracter de separador :(
            Return palabra

        End Function

        Public Function UnirLista(ListaRecibida As List(Of String)) As String

            Dim cadenaNueva As String = String.Join("", ListaRecibida)

            Return cadenaNueva

        End Function

        Public Function DecorarLista(listaRecibida As List(Of String)) As List(Of String)

            Dim valorLista As List(Of String) = New List(Of String)

            For Each s In listaRecibida
                valorLista.Add("-->" & s)
            Next

            Return valorLista

        End Function

    End Class
End Namespace
