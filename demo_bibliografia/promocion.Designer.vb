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
        Me.nudNroPromo = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudAnho = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.tbcPrincipal.SuspendLayout()
        Me.tbpMantenimiento.SuspendLayout()
        CType(Me.nudNroPromo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAnho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPromocionID, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tbcPrincipal.Name = "tbcPrincipal"
        Me.tbcPrincipal.SelectedIndex = 0
        Me.tbcPrincipal.Size = New System.Drawing.Size(600, 366)
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
        Me.tbpMantenimiento.Location = New System.Drawing.Point(4, 22)
        Me.tbpMantenimiento.Name = "tbpMantenimiento"
        Me.tbpMantenimiento.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tbpMantenimiento.Size = New System.Drawing.Size(592, 340)
        Me.tbpMantenimiento.TabIndex = 0
        Me.tbpMantenimiento.Text = "Mantenimiento"
        Me.tbpMantenimiento.UseVisualStyleBackColor = True
        '
        'nudNroPromo
        '
        Me.nudNroPromo.Location = New System.Drawing.Point(98, 71)
        Me.nudNroPromo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nudNroPromo.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudNroPromo.Name = "nudNroPromo"
        Me.nudNroPromo.Size = New System.Drawing.Size(120, 20)
        Me.nudNroPromo.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label3.Location = New System.Drawing.Point(7, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Nro. Promo"
        '
        'nudAnho
        '
        Me.nudAnho.Location = New System.Drawing.Point(98, 38)
        Me.nudAnho.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nudAnho.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudAnho.Name = "nudAnho"
        Me.nudAnho.Size = New System.Drawing.Size(120, 20)
        Me.nudAnho.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Anho"
        '
        'nudPromocionID
        '
        Me.nudPromocionID.Location = New System.Drawing.Point(98, 6)
        Me.nudPromocionID.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.nudPromocionID.Name = "nudPromocionID"
        Me.nudPromocionID.ReadOnly = True
        Me.nudPromocionID.Size = New System.Drawing.Size(120, 20)
        Me.nudPromocionID.TabIndex = 9
        '
        'lblMaterialID
        '
        Me.lblMaterialID.AutoSize = True
        Me.lblMaterialID.Location = New System.Drawing.Point(9, 7)
        Me.lblMaterialID.Name = "lblMaterialID"
        Me.lblMaterialID.Size = New System.Drawing.Size(87, 13)
        Me.lblMaterialID.TabIndex = 8
        Me.lblMaterialID.Text = "ID PROMOCION"
        '
        'txtPromo
        '
        Me.txtPromo.Location = New System.Drawing.Point(98, 111)
        Me.txtPromo.MaxLength = 100
        Me.txtPromo.Name = "txtPromo"
        Me.txtPromo.Size = New System.Drawing.Size(410, 20)
        Me.txtPromo.TabIndex = 7
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(414, 222)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(83, 222)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(83, 171)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lblFacultad
        '
        Me.lblFacultad.AutoSize = True
        Me.lblFacultad.Location = New System.Drawing.Point(9, 111)
        Me.lblFacultad.Name = "lblFacultad"
        Me.lblFacultad.Size = New System.Drawing.Size(63, 13)
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
        Me.tbpConsulta.Location = New System.Drawing.Point(4, 22)
        Me.tbpConsulta.Name = "tbpConsulta"
        Me.tbpConsulta.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tbpConsulta.Size = New System.Drawing.Size(592, 340)
        Me.tbpConsulta.TabIndex = 1
        Me.tbpConsulta.Text = "Consulta"
        Me.tbpConsulta.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(115, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Consulta de Promocion"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(329, 34)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(88, 23)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(63, 36)
        Me.txtBuscar.MaxLength = 20
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(260, 20)
        Me.txtBuscar.TabIndex = 5
        '
        'lblMateria
        '
        Me.lblMateria.AutoSize = True
        Me.lblMateria.Location = New System.Drawing.Point(9, 39)
        Me.lblMateria.Name = "lblMateria"
        Me.lblMateria.Size = New System.Drawing.Size(57, 13)
        Me.lblMateria.TabIndex = 4
        Me.lblMateria.Text = "Promocion"
        '
        'dgvConsulta
        '
        Me.dgvConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsulta.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvConsulta.Location = New System.Drawing.Point(3, 76)
        Me.dgvConsulta.Name = "dgvConsulta"
        Me.dgvConsulta.RowHeadersWidth = 51
        Me.dgvConsulta.Size = New System.Drawing.Size(586, 261)
        Me.dgvConsulta.TabIndex = 1
        '
        'promocion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.tbcPrincipal)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "promocion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "promocion"
        Me.tbcPrincipal.ResumeLayout(False)
        Me.tbpMantenimiento.ResumeLayout(False)
        Me.tbpMantenimiento.PerformLayout()
        CType(Me.nudNroPromo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAnho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPromocionID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpConsulta.ResumeLayout(False)
        Me.tbpConsulta.PerformLayout()
        CType(Me.dgvConsulta, System.ComponentModel.ISupportInitialize).EndInit()
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
