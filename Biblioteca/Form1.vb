Public Class Form1
    ''' <summary>
    ''' Variable que representará la biblioteca
    ''' </summary>
    Dim biblioteca As Biblioteca
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Instanciamos un nuevo objeto Biblioteca
        biblioteca = New Biblioteca
    End Sub

    Private Sub AceptarButton_Click(sender As Object, e As EventArgs) Handles AceptarButton.Click
        'Creamos un nuevo objeto Libro con los datos proporcionados por el usuario
        Dim libro As New Libro(IsbnTextBox.Text, TituloTextBox.Text, AutorTextBox.Text, CShort(AñoTextBox.Text))

        'Se comprueba si el libro ya existe en la biblioteca
        If biblioteca.ExisteLibro(libro) Then
            'SI ya existe, se informa al usuario
            MessageBox.Show("El libro ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'Si no existe, se añade a la biblioteca, se actualiza la interfaz y se informa al usuario
            biblioteca.AñadirLibro(libro)
            ActualizarListBox()
            MessageBox.Show("El libro se ha añadido", "Añadir libro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarCampos()
        End If

    End Sub

    Private Sub VaciarButton_Click(sender As Object, e As EventArgs) Handles VaciarButton.Click
        'Eliminamos todos los elementos de la lista
        biblioteca.LimpiarLista()

        'Actualizamos el listado de libros en el formulario
        ActualizarListBox()
        'Informamos al usuario
        MessageBox.Show("Lista vaciada", "Vaciar lista", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ExportarButton_Click(sender As Object, e As EventArgs) Handles ExportarButton.Click
        'Configuramos el diálogo
        SaveFileDialog1.Filter = "Ficheros de texto (*.txt)|*.txt|Todos los ficheros (*.*)|*.*"

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                'Si el usuario ha seleccionado un fichero, exportamos en él el contenido de la biblioteca
                biblioteca.ExportarLibros(SaveFileDialog1.FileName)
                'Informamos al usuario
                MessageBox.Show("Listado exportado con éxito", "Exportar lista", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                'Si se produce algún error durante la exportación, informamos al usuario
                MessageBox.Show("Error al exportar el listado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub ImportarButton_Click(sender As Object, e As EventArgs) Handles ImportarButton.Click
        'Configuramos el diálogo
        OpenFileDialog1.Filter = "Ficheros de texto (*.txt)|*.txt|Todos los ficheros (*.*)|*.*"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                'Si el usuario ha seleccionado un fichero, importamos su contenido en la biblioteca
                biblioteca.ImportarLibros(OpenFileDialog1.FileName)
                'Actualizamos el listado de libros en el formulario
                ActualizarListBox()
                'Informamos al usuario
                MessageBox.Show("Listado importado con éxito", "Importar lista", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                'Si se produce algún error durante la exportación, informamos al usuario
                MessageBox.Show("Error al importar el listado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub LimpiarButton_Click(sender As Object, e As EventArgs) Handles LimpiarButton.Click
        'Reseteamos todos los campos del formulario
        LimpiarCampos()
    End Sub

    Private Sub ActualizarListBox()
        'Eliminamos todos los elementos del ListBox
        LibrosListBox.Items.Clear()

        'Añadimos cada libro de la biblioteca al ListBox
        For Each libro In biblioteca.libros
            LibrosListBox.Items.Add(libro.ToString())
        Next
    End Sub

    Private Sub LimpiarCampos()
        'Reseteamos cada campo del formulario
        IsbnTextBox.Clear()
        AutorTextBox.Clear()
        TituloTextBox.Clear()
        AñoTextBox.Clear()

        'Establecemos el foco en el campo del ISBN
        IsbnTextBox.Focus()
    End Sub


End Class
