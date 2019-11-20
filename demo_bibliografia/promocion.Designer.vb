<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class promocion
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
        Me.nudPromocionID = New System.Windows.Forms.NumericUpDown()
        Me.lblMaterialID = New System.Windows.Forms.Label()
        Me.txtPromo = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblFacultad = New System.Windows.Forms.Label()
        Me.tbpConsulta = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.lblMateria = New System.Windows.Forms.Label()
        Me.dgvConsulta = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudAnho = New System.Windows.Forms.NumericUpDown()
        Me.nudNroPromo = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbcPrincipal.SuspendLayout()
        Me.tbpMantenimiento.SuspendLayout()
        CType(Me.nudPromocionID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpConsulta.SuspendLayout()
        CType(Me.dgvConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAnho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNroPromo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tbcPrincipal.TabIndex = 5
        '
        'tbpMantenimiento
        '
        Me.tbpMantenimiento.Controls.Add(Me.nudNroPromo)
        Me.tbpMantenimiento.Controls.Add(Me.Label3)
        Me.tbpMantenimiento.Controls.Add(Me.nudAnho)
        Me.tbpMantenimiento.Controls.Add(Me.Label1)
        Me.tbpMantenimiento.Controls.Add(Me.nudPromocionID)
        Me.tbpMantenimiento.Controls.Add(Me.lblMaterialID)
        Me.tbpMantenimiento.Controls.Add(Me.txtPromo)
        Me.tbpMantenimiento.Controls.Add(Me.btnSalir)
        Me.tbpMantenimiento.Controls.Add(Me.btnEliminar)
        Me.tbpMantenimiento.Controls.Add(Me.btnAceptar)
        Me.tbpMantenimiento.Controls.Add(Me.lblFacultad)
        Me.tbpMantenimiento.Location = New System.Drawing.Point(4, 25)
        Me.tbpMantenimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.tbpMantenimiento.Name = "tbpMantenimiento"
        Me.tbpMantenimiento.Padding = New System.Windows.Forms.Padding(4)
        Me.tbpMantenimiento.Size = New System.Drawing.Size(792, 421)
        Me.tbpMantenimiento.TabIndex = 0
        Me.tbpMantenimiento.Text = "Mantenimiento"
        Me.tbpMantenimiento.UseVisualStyleBackColor = True
        '
        'nudPromocionID
        '
        Me.nudPromocionID.Location = New System.Drawing.Point(131, 7)
        Me.nudPromocionID.Margin = New System.Windows.Forms.Padding(4)
        Me.nudPromocionID.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.nudPromocionID.Name = "nudPromocionID"
        Me.nudPromocionID.ReadOnly = True
        Me.nudPromocionID.Size = New System.Drawing.Size(160, 22)
        Me.nudPromocionID.TabIndex = 9
        '
        'lblMaterialID
        '
        Me.lblMaterialID.AutoSize = True
        Me.lblMaterialID.Location = New System.Drawing.Point(12, 9)
        Me.lblMaterialID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaterialID.Name = "lblMaterialID"
        Me.lblMaterialID.Size = New System.Drawing.Size(110, 17)
        Me.lblMaterialID.TabIndex = 8
        Me.lblMaterialID.Text = "ID PROMOCION"
        '
        'txtPromo
        '
        Me.txtPromo.Location = New System.Drawing.Point(131, 137)
        Me.txtPromo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPromo.MaxLength = 100
        Me.txtPromo.Name = "txtPromo"
        Me.txtPromo.Size = New System.Drawing.Size(545, 22)
        Me.txtPromo.TabIndex = 7
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(552, 273)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(100, 28)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(111, 273)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(100, 28)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(111, 210)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(100, 28)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lblFacultad
        '
        Me.lblFacultad.AutoSize = True
        Me.lblFacultad.Location = New System.Drawing.Point(12, 137)
        Me.lblFacultad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFacultad.Name = "lblFacultad"
        Me.lblFacultad.Size = New System.Drawing.Size(82, 17)
        Me.lblFacultad.TabIndex = 2
        Me.lblFacultad.Text = "Descripcion"
        '
        'tbpConsulta
        '
        Me.tbpConsulta.Controls.Add(Me.Label2)
        Me.tbpConsulta.Controls.Add(Me.btnBuscar)
        Me.tbpConsulta.Controls.Add(Me.txtBuscar)
        Me.tbpConsulta.Controls.Add(Me.lblMateria)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(153, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Consulta de Promocion"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(439, 42)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(117, 28)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(84, 44)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBuscar.MaxLength = 20
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(345, 22)
        Me.txtBuscar.TabIndex = 5
        '
        'lblMateria
        '
        Me.lblMateria.AutoSize = True
        Me.lblMateria.Location = New System.Drawing.Point(12, 48)
        Me.lblMateria.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMateria.Name = "lblMateria"
        Me.lblMateria.Size = New System.Drawing.Size(75, 17)
        Me.lblMateria.TabIndex = 4
        Me.lblMateria.Text = "Promocion"
        '
        'dgvConsulta
        '
        Me.dgvConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsulta.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvConsulta.Location = New System.Drawing.Point(4, 96)
        Me.dgvConsulta.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvConsulta.Name = "dgvConsulta"
        Me.dgvConsulta.RowHeadersWidth = 51
        Me.dgvConsulta.Size = New System.Drawing.Size(784, 321)
        Me.dgvConsulta.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Anho"
        '
        'nudAnho
        '
        Me.nudAnho.Location = New System.Drawing.Point(131, 47)
        Me.nudAnho.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudAnho.Name = "nudAnho"
        Me.nudAnho.Size = New System.Drawing.Size(160, 22)
        Me.nudAnho.TabIndex = 11
        '
        'nudNroPromo
        '
        Me.nudNroPromo.Location = New System.Drawing.Point(131, 87)
        Me.nudNroPromo.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudNroPromo.Name = "nudNroPromo"
        Me.nudNroPromo.Size = New System.Drawing.Size(160, 22)
        Me.nudNroPromo.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label3.Location = New System.Drawing.Point(9, 92)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Nro. Promo"
        '
        'promocion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tbcPrincipal)
        Me.Name = "promocion"
        Me.Text = "promocion"
        Me.tbcPrincipal.ResumeLayout(False)
        Me.tbpMantenimiento.ResumeLayout(False)
        Me.tbpMantenimiento.PerformLayout()
        CType(Me.nudPromocionID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpConsulta.ResumeLayout(False)
        Me.tbpConsulta.PerformLayout()
        CType(Me.dgvConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAnho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNroPromo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcPrincipal As TabControl
    Friend WithEvents tbpMantenimiento As TabPage
    Friend WithEvents nudPromocionID As NumericUpDown
    Friend WithEvents lblMaterialID As Label
    Friend WithEvents txtPromo As TextBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents lblFacultad As Label
    Friend WithEvents tbpConsulta As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents lblMateria As Label
    Friend WithEvents dgvConsulta As DataGridView
    Friend WithEvents nudAnho As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents nudNroPromo As NumericUpDown
    Friend WithEvents Label3 As Label
End Class
