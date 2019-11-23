<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class libro
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
        Me.tbcPrincipal = New System.Windows.Forms.TabControl()
        Me.tbpMantenimiento = New System.Windows.Forms.TabPage()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboEdicion = New System.Windows.Forms.ComboBox()
        Me.nudLibroID = New System.Windows.Forms.NumericUpDown()
        Me.lblMaterialID = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtIbsn = New System.Windows.Forms.TextBox()
        Me.lblFacultad = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.tbpConsulta = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtMateriaBuscar = New System.Windows.Forms.TextBox()
        Me.lblChapa = New System.Windows.Forms.Label()
        Me.dgvConsulta = New System.Windows.Forms.DataGridView()
        Me.cboEditorial = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboAutor = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nudAnho = New System.Windows.Forms.NumericUpDown()
        Me.tbcPrincipal.SuspendLayout()
        Me.tbpMantenimiento.SuspendLayout()
        CType(Me.nudLibroID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpConsulta.SuspendLayout()
        CType(Me.dgvConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAnho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcPrincipal
        '
        Me.tbcPrincipal.Controls.Add(Me.tbpMantenimiento)
        Me.tbcPrincipal.Controls.Add(Me.tbpConsulta)
        Me.tbcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tbcPrincipal.Margin = New System.Windows.Forms.Padding(4)
        Me.tbcPrincipal.Name = "tbcPrincipal"
        Me.tbcPrincipal.SelectedIndex = 0
        Me.tbcPrincipal.Size = New System.Drawing.Size(800, 450)
        Me.tbcPrincipal.TabIndex = 4
        '
        'tbpMantenimiento
        '
        Me.tbpMantenimiento.Controls.Add(Me.nudAnho)
        Me.tbpMantenimiento.Controls.Add(Me.Label6)
        Me.tbpMantenimiento.Controls.Add(Me.cboAutor)
        Me.tbpMantenimiento.Controls.Add(Me.Label5)
        Me.tbpMantenimiento.Controls.Add(Me.cboEditorial)
        Me.tbpMantenimiento.Controls.Add(Me.Label4)
        Me.tbpMantenimiento.Controls.Add(Me.txtTitulo)
        Me.tbpMantenimiento.Controls.Add(Me.Label2)
        Me.tbpMantenimiento.Controls.Add(Me.cboEdicion)
        Me.tbpMantenimiento.Controls.Add(Me.nudLibroID)
        Me.tbpMantenimiento.Controls.Add(Me.lblMaterialID)
        Me.tbpMantenimiento.Controls.Add(Me.btnSalir)
        Me.tbpMantenimiento.Controls.Add(Me.btnEliminar)
        Me.tbpMantenimiento.Controls.Add(Me.btnAceptar)
        Me.tbpMantenimiento.Controls.Add(Me.txtIbsn)
        Me.tbpMantenimiento.Controls.Add(Me.lblFacultad)
        Me.tbpMantenimiento.Controls.Add(Me.label1)
        Me.tbpMantenimiento.Location = New System.Drawing.Point(4, 25)
        Me.tbpMantenimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.tbpMantenimiento.Name = "tbpMantenimiento"
        Me.tbpMantenimiento.Padding = New System.Windows.Forms.Padding(4)
        Me.tbpMantenimiento.Size = New System.Drawing.Size(792, 421)
        Me.tbpMantenimiento.TabIndex = 0
        Me.tbpMantenimiento.Text = "Mantenimiento"
        Me.tbpMantenimiento.UseVisualStyleBackColor = True
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(153, 86)
        Me.txtTitulo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTitulo.MaxLength = 100
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(565, 22)
        Me.txtTitulo.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 90)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Titulo"
        '
        'cboEdicion
        '
        Me.cboEdicion.FormattingEnabled = True
        Me.cboEdicion.Location = New System.Drawing.Point(153, 127)
        Me.cboEdicion.Margin = New System.Windows.Forms.Padding(4)
        Me.cboEdicion.Name = "cboEdicion"
        Me.cboEdicion.Size = New System.Drawing.Size(565, 24)
        Me.cboEdicion.TabIndex = 10
        '
        'nudLibroID
        '
        Me.nudLibroID.Location = New System.Drawing.Point(153, 9)
        Me.nudLibroID.Margin = New System.Windows.Forms.Padding(4)
        Me.nudLibroID.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.nudLibroID.Name = "nudLibroID"
        Me.nudLibroID.ReadOnly = True
        Me.nudLibroID.Size = New System.Drawing.Size(160, 22)
        Me.nudLibroID.TabIndex = 9
        '
        'lblMaterialID
        '
        Me.lblMaterialID.AutoSize = True
        Me.lblMaterialID.Location = New System.Drawing.Point(12, 9)
        Me.lblMaterialID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaterialID.Name = "lblMaterialID"
        Me.lblMaterialID.Size = New System.Drawing.Size(66, 17)
        Me.lblMaterialID.TabIndex = 8
        Me.lblMaterialID.Text = "ID LIBRO"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(618, 372)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(100, 28)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(69, 372)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(100, 28)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(69, 336)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(100, 28)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtIbsn
        '
        Me.txtIbsn.Location = New System.Drawing.Point(153, 44)
        Me.txtIbsn.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIbsn.MaxLength = 100
        Me.txtIbsn.Name = "txtIbsn"
        Me.txtIbsn.Size = New System.Drawing.Size(295, 22)
        Me.txtIbsn.TabIndex = 3
        '
        'lblFacultad
        '
        Me.lblFacultad.AutoSize = True
        Me.lblFacultad.Location = New System.Drawing.Point(11, 130)
        Me.lblFacultad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFacultad.Name = "lblFacultad"
        Me.lblFacultad.Size = New System.Drawing.Size(54, 17)
        Me.lblFacultad.TabIndex = 2
        Me.lblFacultad.Text = "Edicion"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(11, 48)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(39, 17)
        Me.label1.TabIndex = 0
        Me.label1.Text = "IBSN"
        '
        'tbpConsulta
        '
        Me.tbpConsulta.Controls.Add(Me.Label3)
        Me.tbpConsulta.Controls.Add(Me.btnBuscar)
        Me.tbpConsulta.Controls.Add(Me.txtMateriaBuscar)
        Me.tbpConsulta.Controls.Add(Me.lblChapa)
        Me.tbpConsulta.Controls.Add(Me.dgvConsulta)
        Me.tbpConsulta.Location = New System.Drawing.Point(4, 25)
        Me.tbpConsulta.Margin = New System.Windows.Forms.Padding(4)
        Me.tbpConsulta.Name = "tbpConsulta"
        Me.tbpConsulta.Padding = New System.Windows.Forms.Padding(4)
        Me.tbpConsulta.Size = New System.Drawing.Size(792, 421)
        Me.tbpConsulta.TabIndex = 1
        Me.tbpConsulta.Text = "Consulta"
        Me.tbpConsulta.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(159, 26)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Consulta Libro "
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(441, 43)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(117, 28)
        Me.btnBuscar.TabIndex = 9
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtMateriaBuscar
        '
        Me.txtMateriaBuscar.Location = New System.Drawing.Point(87, 46)
        Me.txtMateriaBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMateriaBuscar.MaxLength = 20
        Me.txtMateriaBuscar.Name = "txtMateriaBuscar"
        Me.txtMateriaBuscar.Size = New System.Drawing.Size(345, 22)
        Me.txtMateriaBuscar.TabIndex = 8
        '
        'lblChapa
        '
        Me.lblChapa.AutoSize = True
        Me.lblChapa.Location = New System.Drawing.Point(15, 49)
        Me.lblChapa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblChapa.Name = "lblChapa"
        Me.lblChapa.Size = New System.Drawing.Size(40, 17)
        Me.lblChapa.TabIndex = 7
        Me.lblChapa.Text = "Libro"
        '
        'dgvConsulta
        '
        Me.dgvConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsulta.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvConsulta.Location = New System.Drawing.Point(4, 93)
        Me.dgvConsulta.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvConsulta.Name = "dgvConsulta"
        Me.dgvConsulta.RowHeadersWidth = 51
        Me.dgvConsulta.Size = New System.Drawing.Size(784, 324)
        Me.dgvConsulta.TabIndex = 2
        '
        'cboEditorial
        '
        Me.cboEditorial.FormattingEnabled = True
        Me.cboEditorial.Location = New System.Drawing.Point(154, 173)
        Me.cboEditorial.Margin = New System.Windows.Forms.Padding(4)
        Me.cboEditorial.Name = "cboEditorial"
        Me.cboEditorial.Size = New System.Drawing.Size(565, 24)
        Me.cboEditorial.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 176)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Editorial"
        '
        'cboAutor
        '
        Me.cboAutor.FormattingEnabled = True
        Me.cboAutor.Location = New System.Drawing.Point(154, 225)
        Me.cboAutor.Margin = New System.Windows.Forms.Padding(4)
        Me.cboAutor.Name = "cboAutor"
        Me.cboAutor.Size = New System.Drawing.Size(565, 24)
        Me.cboAutor.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 228)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Autor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 285)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 17)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Anho Publicacion"
        '
        'nudAnho
        '
        Me.nudAnho.Location = New System.Drawing.Point(154, 285)
        Me.nudAnho.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudAnho.Name = "nudAnho"
        Me.nudAnho.Size = New System.Drawing.Size(120, 22)
        Me.nudAnho.TabIndex = 18
        '
        'libro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tbcPrincipal)
        Me.Name = "libro"
        Me.Text = "libro"
        Me.tbcPrincipal.ResumeLayout(False)
        Me.tbpMantenimiento.ResumeLayout(False)
        Me.tbpMantenimiento.PerformLayout()
        CType(Me.nudLibroID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpConsulta.ResumeLayout(False)
        Me.tbpConsulta.PerformLayout()
        CType(Me.dgvConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAnho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcPrincipal As TabControl
    Friend WithEvents tbpMantenimiento As TabPage
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboEdicion As ComboBox
    Friend WithEvents nudLibroID As NumericUpDown
    Friend WithEvents lblMaterialID As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents txtIbsn As TextBox
    Friend WithEvents lblFacultad As Label
    Friend WithEvents label1 As Label
    Friend WithEvents tbpConsulta As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtMateriaBuscar As TextBox
    Friend WithEvents lblChapa As Label
    Friend WithEvents dgvConsulta As DataGridView
    Friend WithEvents cboEditorial As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboAutor As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents nudAnho As NumericUpDown
End Class
