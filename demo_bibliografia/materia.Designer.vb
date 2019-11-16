<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMateria
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
        Me.txtMateria = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboFacultad = New System.Windows.Forms.ComboBox()
        Me.nudMateriaID = New System.Windows.Forms.NumericUpDown()
        Me.lblMaterialID = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtCodeMateria = New System.Windows.Forms.TextBox()
        Me.lblFacultad = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.tbpConsulta = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtMateriaBuscar = New System.Windows.Forms.TextBox()
        Me.lblChapa = New System.Windows.Forms.Label()
        Me.dgvConsulta = New System.Windows.Forms.DataGridView()
        Me.tbcPrincipal.SuspendLayout()
        Me.tbpMantenimiento.SuspendLayout()
        CType(Me.nudMateriaID, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tbcPrincipal.Size = New System.Drawing.Size(650, 309)
        Me.tbcPrincipal.TabIndex = 3
        '
        'tbpMantenimiento
        '
        Me.tbpMantenimiento.Controls.Add(Me.txtMateria)
        Me.tbpMantenimiento.Controls.Add(Me.Label2)
        Me.tbpMantenimiento.Controls.Add(Me.cboFacultad)
        Me.tbpMantenimiento.Controls.Add(Me.nudMateriaID)
        Me.tbpMantenimiento.Controls.Add(Me.lblMaterialID)
        Me.tbpMantenimiento.Controls.Add(Me.btnSalir)
        Me.tbpMantenimiento.Controls.Add(Me.btnEliminar)
        Me.tbpMantenimiento.Controls.Add(Me.btnAceptar)
        Me.tbpMantenimiento.Controls.Add(Me.txtCodeMateria)
        Me.tbpMantenimiento.Controls.Add(Me.lblFacultad)
        Me.tbpMantenimiento.Controls.Add(Me.label1)
        Me.tbpMantenimiento.Location = New System.Drawing.Point(4, 22)
        Me.tbpMantenimiento.Name = "tbpMantenimiento"
        Me.tbpMantenimiento.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpMantenimiento.Size = New System.Drawing.Size(642, 283)
        Me.tbpMantenimiento.TabIndex = 0
        Me.tbpMantenimiento.Text = "Mantenimiento"
        Me.tbpMantenimiento.UseVisualStyleBackColor = True
        '
        'txtMateria
        '
        Me.txtMateria.Location = New System.Drawing.Point(115, 70)
        Me.txtMateria.MaxLength = 100
        Me.txtMateria.Name = "txtMateria"
        Me.txtMateria.Size = New System.Drawing.Size(425, 20)
        Me.txtMateria.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Descripcion Materia"
        '
        'cboFacultad
        '
        Me.cboFacultad.FormattingEnabled = True
        Me.cboFacultad.Location = New System.Drawing.Point(115, 103)
        Me.cboFacultad.Name = "cboFacultad"
        Me.cboFacultad.Size = New System.Drawing.Size(425, 21)
        Me.cboFacultad.TabIndex = 10
        '
        'nudMateriaID
        '
        Me.nudMateriaID.Location = New System.Drawing.Point(115, 7)
        Me.nudMateriaID.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.nudMateriaID.Name = "nudMateriaID"
        Me.nudMateriaID.ReadOnly = True
        Me.nudMateriaID.Size = New System.Drawing.Size(120, 20)
        Me.nudMateriaID.TabIndex = 9
        '
        'lblMaterialID
        '
        Me.lblMaterialID.AutoSize = True
        Me.lblMaterialID.Location = New System.Drawing.Point(9, 7)
        Me.lblMaterialID.Name = "lblMaterialID"
        Me.lblMaterialID.Size = New System.Drawing.Size(69, 13)
        Me.lblMaterialID.TabIndex = 8
        Me.lblMaterialID.Text = "ID MATERIA"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(465, 239)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(115, 239)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(115, 185)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtCodeMateria
        '
        Me.txtCodeMateria.Location = New System.Drawing.Point(115, 36)
        Me.txtCodeMateria.MaxLength = 100
        Me.txtCodeMateria.Name = "txtCodeMateria"
        Me.txtCodeMateria.Size = New System.Drawing.Size(222, 20)
        Me.txtCodeMateria.TabIndex = 3
        '
        'lblFacultad
        '
        Me.lblFacultad.AutoSize = True
        Me.lblFacultad.Location = New System.Drawing.Point(8, 106)
        Me.lblFacultad.Name = "lblFacultad"
        Me.lblFacultad.Size = New System.Drawing.Size(88, 13)
        Me.lblFacultad.TabIndex = 2
        Me.lblFacultad.Text = "Nombre Facultad"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(8, 39)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(78, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Codigo Materia"
        '
        'tbpConsulta
        '
        Me.tbpConsulta.Controls.Add(Me.Label3)
        Me.tbpConsulta.Controls.Add(Me.btnBuscar)
        Me.tbpConsulta.Controls.Add(Me.txtMateriaBuscar)
        Me.tbpConsulta.Controls.Add(Me.lblChapa)
        Me.tbpConsulta.Controls.Add(Me.dgvConsulta)
        Me.tbpConsulta.Location = New System.Drawing.Point(4, 22)
        Me.tbpConsulta.Name = "tbpConsulta"
        Me.tbpConsulta.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpConsulta.Size = New System.Drawing.Size(642, 283)
        Me.tbpConsulta.TabIndex = 1
        Me.tbpConsulta.Text = "Consulta"
        Me.tbpConsulta.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(119, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Consulta por nombre de materia"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(331, 35)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(88, 23)
        Me.btnBuscar.TabIndex = 9
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtMateriaBuscar
        '
        Me.txtMateriaBuscar.Location = New System.Drawing.Point(65, 37)
        Me.txtMateriaBuscar.MaxLength = 20
        Me.txtMateriaBuscar.Name = "txtMateriaBuscar"
        Me.txtMateriaBuscar.Size = New System.Drawing.Size(260, 20)
        Me.txtMateriaBuscar.TabIndex = 8
        '
        'lblChapa
        '
        Me.lblChapa.AutoSize = True
        Me.lblChapa.Location = New System.Drawing.Point(11, 40)
        Me.lblChapa.Name = "lblChapa"
        Me.lblChapa.Size = New System.Drawing.Size(42, 13)
        Me.lblChapa.TabIndex = 7
        Me.lblChapa.Text = "Materia"
        '
        'dgvConsulta
        '
        Me.dgvConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsulta.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvConsulta.Location = New System.Drawing.Point(3, 72)
        Me.dgvConsulta.Name = "dgvConsulta"
        Me.dgvConsulta.Size = New System.Drawing.Size(636, 208)
        Me.dgvConsulta.TabIndex = 2
        '
        'frmMateria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 309)
        Me.Controls.Add(Me.tbcPrincipal)
        Me.Name = "frmMateria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Materia"
        Me.tbcPrincipal.ResumeLayout(False)
        Me.tbpMantenimiento.ResumeLayout(False)
        Me.tbpMantenimiento.PerformLayout()
        CType(Me.nudMateriaID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpConsulta.ResumeLayout(False)
        Me.tbpConsulta.PerformLayout()
        CType(Me.dgvConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcPrincipal As TabControl
    Friend WithEvents tbpMantenimiento As TabPage
    Friend WithEvents nudMateriaID As NumericUpDown
    Friend WithEvents lblMaterialID As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents txtCodeMateria As TextBox
    Friend WithEvents lblFacultad As Label
    Friend WithEvents label1 As Label
    Friend WithEvents tbpConsulta As TabPage
    Friend WithEvents cboFacultad As ComboBox
    Friend WithEvents txtMateria As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvConsulta As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtMateriaBuscar As TextBox
    Friend WithEvents lblChapa As Label
    Friend WithEvents Label3 As Label
End Class
