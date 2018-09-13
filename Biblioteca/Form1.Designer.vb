<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.IsbnTextBox = New System.Windows.Forms.TextBox()
        Me.AñoTextBox = New System.Windows.Forms.TextBox()
        Me.AutorTextBox = New System.Windows.Forms.TextBox()
        Me.TituloTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LimpiarButton = New System.Windows.Forms.Button()
        Me.AceptarButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LibrosListBox = New System.Windows.Forms.ListBox()
        Me.ExportarButton = New System.Windows.Forms.Button()
        Me.ImportarButton = New System.Windows.Forms.Button()
        Me.VaciarButton = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'IsbnTextBox
        '
        Me.IsbnTextBox.Location = New System.Drawing.Point(68, 39)
        Me.IsbnTextBox.Name = "IsbnTextBox"
        Me.IsbnTextBox.Size = New System.Drawing.Size(179, 22)
        Me.IsbnTextBox.TabIndex = 0
        '
        'AñoTextBox
        '
        Me.AñoTextBox.Location = New System.Drawing.Point(326, 85)
        Me.AñoTextBox.Name = "AñoTextBox"
        Me.AñoTextBox.Size = New System.Drawing.Size(73, 22)
        Me.AñoTextBox.TabIndex = 3
        '
        'AutorTextBox
        '
        Me.AutorTextBox.Location = New System.Drawing.Point(326, 37)
        Me.AutorTextBox.Name = "AutorTextBox"
        Me.AutorTextBox.Size = New System.Drawing.Size(189, 22)
        Me.AutorTextBox.TabIndex = 1
        '
        'TituloTextBox
        '
        Me.TituloTextBox.Location = New System.Drawing.Point(68, 87)
        Me.TituloTextBox.Name = "TituloTextBox"
        Me.TituloTextBox.Size = New System.Drawing.Size(179, 22)
        Me.TituloTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ISBN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Título"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(281, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Autor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(281, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Año"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LimpiarButton)
        Me.GroupBox1.Controls.Add(Me.AceptarButton)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(548, 194)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Añadir libro"
        '
        'LimpiarButton
        '
        Me.LimpiarButton.Location = New System.Drawing.Point(107, 141)
        Me.LimpiarButton.Name = "LimpiarButton"
        Me.LimpiarButton.Size = New System.Drawing.Size(84, 31)
        Me.LimpiarButton.TabIndex = 5
        Me.LimpiarButton.Text = "Limpiar"
        Me.LimpiarButton.UseVisualStyleBackColor = True
        '
        'AceptarButton
        '
        Me.AceptarButton.Location = New System.Drawing.Point(17, 141)
        Me.AceptarButton.Name = "AceptarButton"
        Me.AceptarButton.Size = New System.Drawing.Size(84, 31)
        Me.AceptarButton.TabIndex = 4
        Me.AceptarButton.Text = "Aceptar"
        Me.AceptarButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LibrosListBox)
        Me.GroupBox2.Controls.Add(Me.ExportarButton)
        Me.GroupBox2.Controls.Add(Me.ImportarButton)
        Me.GroupBox2.Controls.Add(Me.VaciarButton)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 238)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(548, 307)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de libros"
        '
        'LibrosListBox
        '
        Me.LibrosListBox.FormattingEnabled = True
        Me.LibrosListBox.ItemHeight = 16
        Me.LibrosListBox.Location = New System.Drawing.Point(17, 38)
        Me.LibrosListBox.Name = "LibrosListBox"
        Me.LibrosListBox.Size = New System.Drawing.Size(490, 212)
        Me.LibrosListBox.TabIndex = 11
        Me.LibrosListBox.TabStop = False
        '
        'ExportarButton
        '
        Me.ExportarButton.Location = New System.Drawing.Point(107, 259)
        Me.ExportarButton.Name = "ExportarButton"
        Me.ExportarButton.Size = New System.Drawing.Size(84, 31)
        Me.ExportarButton.TabIndex = 7
        Me.ExportarButton.Text = "Exportar"
        Me.ExportarButton.UseVisualStyleBackColor = True
        '
        'ImportarButton
        '
        Me.ImportarButton.Location = New System.Drawing.Point(197, 259)
        Me.ImportarButton.Name = "ImportarButton"
        Me.ImportarButton.Size = New System.Drawing.Size(84, 31)
        Me.ImportarButton.TabIndex = 8
        Me.ImportarButton.Text = "Importar"
        Me.ImportarButton.UseVisualStyleBackColor = True
        '
        'VaciarButton
        '
        Me.VaciarButton.Location = New System.Drawing.Point(17, 259)
        Me.VaciarButton.Name = "VaciarButton"
        Me.VaciarButton.Size = New System.Drawing.Size(84, 31)
        Me.VaciarButton.TabIndex = 6
        Me.VaciarButton.Text = "Vaciar"
        Me.VaciarButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 557)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TituloTextBox)
        Me.Controls.Add(Me.AutorTextBox)
        Me.Controls.Add(Me.AñoTextBox)
        Me.Controls.Add(Me.IsbnTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Bilbioteca"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IsbnTextBox As TextBox
    Friend WithEvents AñoTextBox As TextBox
    Friend WithEvents AutorTextBox As TextBox
    Friend WithEvents TituloTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AceptarButton As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LibrosListBox As ListBox
    Friend WithEvents ExportarButton As Button
    Friend WithEvents ImportarButton As Button
    Friend WithEvents VaciarButton As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents LimpiarButton As Button
End Class
