''' <summary>
''' Clase que representa un libro de la bilbioteca
''' </summary>
Public Class Libro
    Implements IEquatable(Of Libro)

    ''' <summary>
    ''' Propiedad autoimplementada para el ISBN del libro
    ''' </summary>
    ''' <returns>ISBN del libro</returns>
    Public Property Isbn As String

    ''' <summary>
    ''' Propiedad autoimplementada para el título del libro
    ''' </summary>
    ''' <returns>Título del libro</returns>
    Public Property Titulo As String

    ''' <summary>
    ''' Propiedad autoimplementada para el autor del libro
    ''' </summary>
    ''' <returns>Autor del libro</returns>
    Public Property Autor As String

    ''' <summary>
    ''' Propiedad autoimplementada para el año de publicación del libro
    ''' </summary>
    ''' <returns>Año de publicación del libro</returns>
    Public Property Año As Short

    ''' <summary>
    ''' Constructor por defecto
    ''' </summary>
    Public Sub New()
        Isbn = ""
        Titulo = ""
        Autor = ""
        Año = 0
    End Sub

    ''' <summary>
    ''' Constructor con parámetros
    ''' </summary>
    ''' <param name="isbn">ISBN del libro</param>
    ''' <param name="titulo">Título del libro</param>
    ''' <param name="autor">Autor del libro</param>
    ''' <param name="año">Año de publicación del libro</param>
    Public Sub New(isbn As String, titulo As String, autor As String, año As Short)
        Me.Isbn = isbn
        Me.Titulo = titulo
        Me.Autor = autor
        Me.Año = año
    End Sub

    ''' <summary>
    ''' Sobrescritura del método ToString
    ''' </summary>
    ''' <returns></returns>
    Public Overrides Function ToString() As String
        Return String.Format("{0};{1};{2};{3}", Isbn, Titulo, Autor, Año.ToString())
    End Function

    ''' <summary>
    ''' Implementación de la interfaz IEquatable
    ''' </summary>
    ''' <param name="other">Libro con el que se compara</param>
    ''' <returns></returns>
    Public Function Equals(other As Libro) As Boolean Implements IEquatable(Of Libro).Equals
        Return IIf(Isbn = other.Isbn, True, False)
    End Function
End Class
