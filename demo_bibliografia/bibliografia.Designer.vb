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
        Me.nudBibliografiaID = New System.Windows.Forms.NumericUpDown()
        Me.lblMaterialID = New System.Windows.Forms.Label()
        Me.gbxLibro = New System.Windows.Forms.GroupBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.cboLibro = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.btnHabilitarDetalle = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.cboMateria = New System.Windows.Forms.ComboBox()
        Me.lblFacultad = New System.Windows.Forms.Label()
        Me.cboPromocion = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudAnho = New System.Windows.Forms.NumericUpDown()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.nudBibliografiaID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxLibro.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAnho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nudBibliografiaID
        '
        Me.nudBibliografiaID.Location = New System.Drawing.Point(167, 28)
        Me.nudBibliografiaID.Margin = New System.Windows.Forms.Padding(4)
        Me.nudBibliografiaID.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.nudBibliografiaID.Name = "nudBibliografiaID"
        Me.nudBibliografiaID.ReadOnly = True
        Me.nudBibliografiaID.Size = New System.Drawing.Size(160, 22)
        Me.nudBibliografiaID.TabIndex = 11
        '
        'lblMaterialID
        '
        Me.lblMaterialID.AutoSize = True
        Me.lblMaterialID.Location = New System.Drawing.Point(26, 28)
        Me.lblMaterialID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaterialID.Name = "lblMaterialID"
        Me.lblMaterialID.Size = New System.Drawing.Size(118, 17)
        Me.lblMaterialID.TabIndex = 10
        Me.lblMaterialID.Text = "ID BIBLIOGRAFIA"
        '
        'gbxLibro
        '
        Me.gbxLibro.Controls.Add(Me.btnEliminar)
        Me.gbxLibro.Controls.Add(Me.btnAgregar)
        Me.gbxLibro.Controls.Add(Me.cboLibro)
        Me.gbxLibro.Controls.Add(Me.Label4)
        Me.gbxLibro.Enabled = False
        Me.gbxLibro.Location = New System.Drawing.Point(29, 461)
        Me.gbxLibro.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxLibro.Name = "gbxLibro"
        Me.gbxLibro.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxLibro.Size = New System.Drawing.Size(810, 100)
        Me.gbxLibro.TabIndex = 27
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 23)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 17)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Libro"
        '
        'Label1
        '
        Me.Label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 17)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Descripcion de Detalle"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(198, 180)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(534, 22)
        Me.txtDescripcion.TabIndex = 29
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Location = New System.Drawing.Point(29, 250)
        Me.dgvDetalle.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.RowHeadersWidth = 51
        Me.dgvDetalle.Size = New System.Drawing.Size(1161, 185)
        Me.dgvDetalle.TabIndex = 30
        '
        'btnHabilitarDetalle
        '
        Me.btnHabilitarDetalle.Location = New System.Drawing.Point(709, 17)
        Me.btnHabilitarDetalle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHabilitarDetalle.Name = "btnHabilitarDetalle"
        Me.btnHabilitarDetalle.Size = New System.Drawing.Size(144, 28)
        Me.btnHabilitarDetalle.TabIndex = 31
        Me.btnHabilitarDetalle.Text = "Habilitar Detalle"
        Me.btnHabilitarDetalle.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(581, 569)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(119, 54)
        Me.btnAceptar.TabIndex = 33
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
        Me.btnCancelar.Location = New System.Drawing.Point(715, 569)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(116, 54)
        Me.btnCancelar.TabIndex = 32
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'cboMateria
        '
        Me.cboMateria.FormattingEnabled = True
        Me.cboMateria.Location = New System.Drawing.Point(167, 64)
        Me.cboMateria.Margin = New System.Windows.Forms.Padding(4)
        Me.cboMateria.Name = "cboMateria"
        Me.cboMateria.Size = New System.Drawing.Size(565, 24)
        Me.cboMateria.TabIndex = 35
        '
        'lblFacultad
        '
        Me.lblFacultad.AutoSize = True
        Me.lblFacultad.Location = New System.Drawing.Point(26, 64)
        Me.lblFacultad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFacultad.Name = "lblFacultad"
        Me.lblFacultad.Size = New System.Drawing.Size(55, 17)
        Me.lblFacultad.TabIndex = 34
        Me.lblFacultad.Text = "Materia"
        '
        'cboPromocion
        '
        Me.cboPromocion.FormattingEnabled = True
        Me.cboPromocion.Location = New System.Drawing.Point(167, 109)
        Me.cboPromocion.Margin = New System.Windows.Forms.Padding(4)
        Me.cboPromocion.Name = "cboPromocion"
        Me.cboPromocion.Size = New System.Drawing.Size(565, 24)
        Me.cboPromocion.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 112)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 17)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Promocion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 17)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Anho"
        '
        'nudAnho
        '
        Me.nudAnho.Location = New System.Drawing.Point(167, 148)
        Me.nudAnho.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudAnho.Name = "nudAnho"
        Me.nudAnho.Size = New System.Drawing.Size(120, 22)
        Me.nudAnho.TabIndex = 39
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(1102, 17)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 40
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'bibliografia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1203, 626)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.nudAnho)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboPromocion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboMateria)
        Me.Controls.Add(Me.lblFacultad)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnHabilitarDetalle)
        Me.Controls.Add(Me.dgvDetalle)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbxLibro)
        Me.Controls.Add(Me.nudBibliografiaID)
        Me.Controls.Add(Me.lblMaterialID)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "bibliografia"
        Me.Text = "bibliografia"
        CType(Me.nudBibliografiaID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxLibro.ResumeLayout(False)
        Me.gbxLibro.PerformLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAnho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nudBibliografiaID As NumericUpDown
    Friend WithEvents lblMaterialID As Label
    Friend WithEvents gbxLibro As GroupBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents cboLibro As ComboBox
    Friend WithEvents dgvDetalle As DataGridView
    Friend WithEvents btnHabilitarDetalle As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents cboMateria As ComboBox
    Friend WithEvents lblFacultad As Label
    Friend WithEvents cboPromocion As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents nudAnho As NumericUpDown
    Friend WithEvents btnSalir As Button
End Class
