<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tsmInicio = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmMateria = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmFacultad = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmLibro = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEdicion = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEditorial = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmAutor = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmPromocion = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmProcesos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmBibliografia = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmInicio, Me.tsmProcesos, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "mstMenu"
        '
        'tsmInicio
        '
        Me.tsmInicio.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmMateria, Me.tsmFacultad, Me.tsmLibro, Me.tsmAutor})
        Me.tsmInicio.Name = "tsmInicio"
        Me.tsmInicio.Size = New System.Drawing.Size(48, 20)
        Me.tsmInicio.Text = "Inicio"
        '
        'tsmMateria
        '
        Me.tsmMateria.Name = "tsmMateria"
        Me.tsmMateria.Size = New System.Drawing.Size(180, 22)
        Me.tsmMateria.Text = "Materia"
        '
        'tsmFacultad
        '
        Me.tsmFacultad.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmPromocion})
        Me.tsmFacultad.Name = "tsmFacultad"
        Me.tsmFacultad.Size = New System.Drawing.Size(180, 22)
        Me.tsmFacultad.Text = "Facultad"
        '
        'tsmLibro
        '
        Me.tsmLibro.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmEdicion, Me.tsmEditorial})
        Me.tsmLibro.Name = "tsmLibro"
        Me.tsmLibro.Size = New System.Drawing.Size(180, 22)
        Me.tsmLibro.Text = "Libro"
        '
        'tsmEdicion
        '
        Me.tsmEdicion.Name = "tsmEdicion"
        Me.tsmEdicion.Size = New System.Drawing.Size(117, 22)
        Me.tsmEdicion.Text = "Edicion"
        '
        'tsmEditorial
        '
        Me.tsmEditorial.Name = "tsmEditorial"
        Me.tsmEditorial.Size = New System.Drawing.Size(117, 22)
        Me.tsmEditorial.Text = "Editorial"
        '
        'tsmAutor
        '
        Me.tsmAutor.Name = "tsmAutor"
        Me.tsmAutor.Size = New System.Drawing.Size(180, 22)
        Me.tsmAutor.Text = "Autor"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'tsmPromocion
        '
        Me.tsmPromocion.Name = "tsmPromocion"
        Me.tsmPromocion.Size = New System.Drawing.Size(180, 22)
        Me.tsmPromocion.Text = "Promocion"
        '
        'tsmProcesos
        '
        Me.tsmProcesos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmBibliografia})
        Me.tsmProcesos.Name = "tsmProcesos"
        Me.tsmProcesos.Size = New System.Drawing.Size(66, 20)
        Me.tsmProcesos.Text = "Procesos"
        '
        'tsmBibliografia
        '
        Me.tsmBibliografia.Name = "tsmBibliografia"
        Me.tsmBibliografia.Size = New System.Drawing.Size(180, 22)
        Me.tsmBibliografia.Text = "Bibiliografia"
        '
        'menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = Global.demo_bibliografia.My.Resources.Resources.Logo_de_la_UAA
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents tsmInicio As ToolStripMenuItem
    Friend WithEvents tsmMateria As ToolStripMenuItem
    Friend WithEvents tsmFacultad As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmLibro As ToolStripMenuItem
    Friend WithEvents tsmEdicion As ToolStripMenuItem
    Friend WithEvents tsmEditorial As ToolStripMenuItem
    Friend WithEvents tsmAutor As ToolStripMenuItem
    Friend WithEvents tsmPromocion As ToolStripMenuItem
    Friend WithEvents tsmProcesos As ToolStripMenuItem
    Friend WithEvents tsmBibliografia As ToolStripMenuItem
End Class
