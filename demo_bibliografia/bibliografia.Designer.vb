<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bibliografia
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bibliografia))
        Me.tbcPrincipal = New System.Windows.Forms.TabControl()
        Me.tbpMantenimiento = New System.Windows.Forms.TabPage()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.nudAnho = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboPromocion = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboMateria = New System.Windows.Forms.ComboBox()
        Me.lblFacultad = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnHabilitarDetalle = New System.Windows.Forms.Button()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbxLibro = New System.Windows.Forms.GroupBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.cboLibro = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nudBibliografiaID = New System.Windows.Forms.NumericUpDown()
        Me.lblMaterialID = New System.Windows.Forms.Label()
        Me.tbpConsulta = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtMateriaBuscar = New System.Windows.Forms.TextBox()
        Me.lblChapa = New System.Windows.Forms.Label()
        Me.dgvConsulta = New System.Windows.Forms.DataGridView()
        Me.tbcPrincipal.SuspendLayout()
        Me.tbpMantenimiento.SuspendLayout()
        CType(Me.nudAnho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxLibro.SuspendLayout()
        CType(Me.nudBibliografiaID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpConsulta.SuspendLayout()
        CType(Me.dgvConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tbcPrincipal.Size = New System.Drawing.Size(1203, 704)
        Me.tbcPrincipal.TabIndex = 5
        '
        'tbpMantenimiento
        '
        Me.tbpMantenimiento.Controls.Add(Me.btnSalir)
        Me.tbpMantenimiento.Controls.Add(Me.nudAnho)
        Me.tbpMantenimiento.Controls.Add(Me.Label1)
        Me.tbpMantenimiento.Controls.Add(Me.cboPromocion)
        Me.tbpMantenimiento.Controls.Add(Me.Label2)
        Me.tbpMantenimiento.Controls.Add(Me.cboMateria)
        Me.tbpMantenimiento.Controls.Add(Me.lblFacultad)
        Me.tbpMantenimiento.Controls.Add(Me.btnAceptar)
        Me.tbpMantenimiento.Controls.Add(Me.btnCancelar)
        Me.tbpMantenimiento.Controls.Add(Me.btnHabilitarDetalle)
        Me.tbpMantenimiento.Controls.Add(Me.dgvDetalle)
        Me.tbpMantenimiento.Controls.Add(Me.txtDescripcion)
        Me.tbpMantenimiento.Controls.Add(Me.Label4)
        Me.tbpMantenimiento.Controls.Add(Me.gbxLibro)
        Me.tbpMantenimiento.Controls.Add(Me.nudBibliografiaID)
        Me.tbpMantenimiento.Controls.Add(Me.lblMaterialID)
        Me.tbpMantenimiento.Location = New System.Drawing.Point(4, 25)
        Me.tbpMantenimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.tbpMantenimiento.Name = "tbpMantenimiento"
        Me.tbpMantenimiento.Padding = New System.Windows.Forms.Padding(4)
        Me.tbpMantenimiento.Size = New System.Drawing.Size(1195, 675)
        Me.tbpMantenimiento.TabIndex = 0
        Me.tbpMantenimiento.Text = "Mantenimiento"
        Me.tbpMantenimiento.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(1094, 17)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 56
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'nudAnho
        '
        Me.nudAnho.Location = New System.Drawing.Point(159, 148)
        Me.nudAnho.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudAnho.Name = "nudAnho"
        Me.nudAnho.Size = New System.Drawing.Size(120, 22)
        Me.nudAnho.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-78, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 17)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Anho"
        '
        'cboPromocion
        '
        Me.cboPromocion.FormattingEnabled = True
        Me.cboPromocion.Location = New System.Drawing.Point(159, 109)
        Me.cboPromocion.Margin = New System.Windows.Forms.Padding(4)
        Me.cboPromocion.Name = "cboPromocion"
        Me.cboPromocion.Size = New System.Drawing.Size(565, 24)
        Me.cboPromocion.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-78, 89)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 17)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Promocion"
        '
        'cboMateria
        '
        Me.cboMateria.FormattingEnabled = True
        Me.cboMateria.Location = New System.Drawing.Point(159, 64)
        Me.cboMateria.Margin = New System.Windows.Forms.Padding(4)
        Me.cboMateria.Name = "cboMateria"
        Me.cboMateria.Size = New System.Drawing.Size(565, 24)
        Me.cboMateria.TabIndex = 51
        '
        'lblFacultad
        '
        Me.lblFacultad.AutoSize = True
        Me.lblFacultad.Location = New System.Drawing.Point(-78, 41)
        Me.lblFacultad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFacultad.Name = "lblFacultad"
        Me.lblFacultad.Size = New System.Drawing.Size(55, 17)
        Me.lblFacultad.TabIndex = 50
        Me.lblFacultad.Text = "Materia"
        '
        'btnAceptar
        '
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(573, 569)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(119, 54)
        Me.btnAceptar.TabIndex = 49
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(707, 569)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(116, 54)
        Me.btnCancelar.TabIndex = 48
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnHabilitarDetalle
        '
        Me.btnHabilitarDetalle.Location = New System.Drawing.Point(701, 17)
        Me.btnHabilitarDetalle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHabilitarDetalle.Name = "btnHabilitarDetalle"
        Me.btnHabilitarDetalle.Size = New System.Drawing.Size(144, 28)
        Me.btnHabilitarDetalle.TabIndex = 47
        Me.btnHabilitarDetalle.Text = "Habilitar Detalle"
        Me.btnHabilitarDetalle.UseVisualStyleBackColor = True
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Location = New System.Drawing.Point(21, 250)
        Me.dgvDetalle.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.RowHeadersWidth = 51
        Me.dgvDetalle.Size = New System.Drawing.Size(1161, 185)
        Me.dgvDetalle.TabIndex = 46
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(190, 180)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(534, 22)
        Me.txtDescripcion.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 17)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Descripcion de Detalle"
        '
        'gbxLibro
        '
        Me.gbxLibro.Controls.Add(Me.btnEliminar)
        Me.gbxLibro.Controls.Add(Me.btnAgregar)
        Me.gbxLibro.Controls.Add(Me.cboLibro)
        Me.gbxLibro.Controls.Add(Me.Label5)
        Me.gbxLibro.Enabled = False
        Me.gbxLibro.Location = New System.Drawing.Point(21, 461)
        Me.gbxLibro.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxLibro.Name = "gbxLibro"
        Me.gbxLibro.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxLibro.Size = New System.Drawing.Size(810, 100)
        Me.gbxLibro.TabIndex = 43
        Me.gbxLibro.TabStop = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.Location = New System.Drawing.Point(743, 23)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(59, 54)
        Me.btnEliminar.TabIndex = 25
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(655, 23)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(59, 54)
        Me.btnAgregar.TabIndex = 24
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'cboLibro
        '
        Me.cboLibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLibro.FormattingEnabled = True
        Me.cboLibro.Location = New System.Drawing.Point(23, 53)
        Me.cboLibro.Margin = New System.Windows.Forms.Padding(4)
        Me.cboLibro.Name = "cboLibro"
        Me.cboLibro.Size = New System.Drawing.Size(555, 24)
        Me.cboLibro.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 23)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 17)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Libro"
        '
        'nudBibliografiaID
        '
        Me.nudBibliografiaID.Location = New System.Drawing.Point(159, 28)
        Me.nudBibliografiaID.Margin = New System.Windows.Forms.Padding(4)
        Me.nudBibliografiaID.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.nudBibliografiaID.Name = "nudBibliografiaID"
        Me.nudBibliografiaID.ReadOnly = True
        Me.nudBibliografiaID.Size = New System.Drawing.Size(160, 22)
        Me.nudBibliografiaID.TabIndex = 42
        '
        'lblMaterialID
        '
        Me.lblMaterialID.AutoSize = True
        Me.lblMaterialID.Location = New System.Drawing.Point(18, 28)
        Me.lblMaterialID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaterialID.Name = "lblMaterialID"
        Me.lblMaterialID.Size = New System.Drawing.Size(118, 17)
        Me.lblMaterialID.TabIndex = 41
        Me.lblMaterialID.Text = "ID BIBLIOGRAFIA"
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
        Me.tbpConsulta.Size = New System.Drawing.Size(1195, 597)
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
        Me.Label3.Size = New System.Drawing.Size(211, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Consulta por nombre de materia"
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
        Me.lblChapa.Size = New System.Drawing.Size(55, 17)
        Me.lblChapa.TabIndex = 7
        Me.lblChapa.Text = "Materia"
        '
        'dgvConsulta
        '
        Me.dgvConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsulta.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvConsulta.Location = New System.Drawing.Point(4, 337)
        Me.dgvConsulta.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvConsulta.Name = "dgvConsulta"
        Me.dgvConsulta.RowHeadersWidth = 51
        Me.dgvConsulta.Size = New System.Drawing.Size(1187, 256)
        Me.dgvConsulta.TabIndex = 2
        '
        'bibliografia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1203, 704)
        Me.ControlBox = False
        Me.Controls.Add(Me.tbcPrincipal)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "bibliografia"
        Me.Text = "bibliografia"
        Me.tbcPrincipal.ResumeLayout(False)
        Me.tbpMantenimiento.ResumeLayout(False)
        Me.tbpMantenimiento.PerformLayout()
        CType(Me.nudAnho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxLibro.ResumeLayout(False)
        Me.gbxLibro.PerformLayout()
        CType(Me.nudBibliografiaID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpConsulta.ResumeLayout(False)
        Me.tbpConsulta.PerformLayout()
        CType(Me.dgvConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcPrincipal As TabControl
    Friend WithEvents tbpMantenimiento As TabPage
    Friend WithEvents btnSalir As Button
    Friend WithEvents nudAnho As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents cboPromocion As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboMateria As ComboBox
    Friend WithEvents lblFacultad As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnHabilitarDetalle As Button
    Friend WithEvents dgvDetalle As DataGridView
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents gbxLibro As GroupBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents cboLibro As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents nudBibliografiaID As NumericUpDown
    Friend WithEvents lblMaterialID As Label
    Friend WithEvents tbpConsulta As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtMateriaBuscar As TextBox
    Friend WithEvents lblChapa As Label
    Friend WithEvents dgvConsulta As DataGridView
End Class
