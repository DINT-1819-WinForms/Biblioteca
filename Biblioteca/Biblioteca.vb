''' <summary>
''' Clase que representa una biblioteca de libros
''' </summary>
Public Class Biblioteca
    ''' <summary>
    ''' Atributo que almacenará la lista genérica de libros
    ''' </summary>
    Private listaLibros As List(Of Libro)

    ''' <summary>
    ''' Propiedad de solo lectura para acceder al listado de libros
    ''' </summary>
    ''' <returns>Lista genérica con los libros</returns>
    Public ReadOnly Property libros As List(Of Libro)
        Get
            Return listaLibros
        End Get
    End Property

    ''' <summary>
    ''' Constructor por defecto
    ''' </summary>
    Public Sub New()
        listaLibros = New List(Of Libro)
    End Sub

    ''' <summary>
    ''' Método para añadir un libro a la biblioteca
    ''' </summary>
    ''' <param name="libro">Libro a añadir</param>
    Public Sub AñadirLibro(libro As Libro)
        listaLibros.Add(libro)
    End Sub

    ''' <summary>
    ''' Método que comprueba si un libro ya existe en la biblioteca
    ''' </summary>
    ''' <param name="libro">Libro que se comprueba</param>
    ''' <returns>True si el libro ya existe en la bilbioteca, False en caso contrario</returns>
    Public Function ExisteLibro(libro As Libro) As Boolean
        Return listaLibros.Contains(libro)
    End Function

    ''' <summary>
    ''' Método para exportar el contenido de la biblioteca a un fichero de texto
    ''' </summary>
    ''' <param name="path">Ruta completa del fichero de exportación</param>
    Public Sub ExportarLibros(path As String)
        Dim writer = New System.IO.StreamWriter(path)

        If (writer IsNot Nothing) Then
            For Each libro In listaLibros
                writer.WriteLine(libro.ToString)
            Next
            writer.Close()
        End If
    End Sub

    ''' <summary>
    ''' Método para importar el contenido de un fichero de texto en la bilbioteca
    ''' </summary>
    ''' <param name="path">Ruta completa del fichero de importación</param>
    Public Sub ImportarLibros(path As String)
        Dim reader = New System.IO.StreamReader(path)
        Dim linea As String

        linea = reader.ReadLine()
        Do Until linea Is Nothing
            Dim campos As String()

            campos = linea.Split(";")
            Dim libro As New Libro(campos(0), campos(1), campos(2), campos(3))
            listaLibros.Add(libro)

            linea = reader.ReadLine
        Loop

    End Sub

    ''' <summary>
    ''' Método para eliminar todos los libros de la biblioteca
    ''' </summary>
    Public Sub LimpiarLista()
        listaLibros.Clear()
    End Sub
End Class
