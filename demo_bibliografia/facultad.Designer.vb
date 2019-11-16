<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacultad
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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.tbcPrincipal = New System.Windows.Forms.TabControl()
        Me.tbpMantenimiento = New System.Windows.Forms.TabPage()
        Me.nudFacultadID = New System.Windows.Forms.NumericUpDown()
        Me.lblMaterialID = New System.Windows.Forms.Label()
        Me.txtFacultad = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtCodeFacultad = New System.Windows.Forms.TextBox()
        Me.lblFacultad = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.tbpConsulta = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtFacultadBuscar = New System.Windows.Forms.TextBox()
        Me.lblMateria = New System.Windows.Forms.Label()
        Me.dgvConsulta = New System.Windows.Forms.DataGridView()
        Me.tbcPrincipal.SuspendLayout()
        Me.tbpMantenimiento.SuspendLayout()
        CType(Me.nudFacultadID, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tbcPrincipal.Size = New System.Drawing.Size(525, 418)
        Me.tbcPrincipal.TabIndex = 2
        '
        'tbpMantenimiento
        '
        Me.tbpMantenimiento.Controls.Add(Me.nudFacultadID)
        Me.tbpMantenimiento.Controls.Add(Me.lblMaterialID)
        Me.tbpMantenimiento.Controls.Add(Me.txtFacultad)
        Me.tbpMantenimiento.Controls.Add(Me.btnSalir)
        Me.tbpMantenimiento.Controls.Add(Me.btnEliminar)
        Me.tbpMantenimiento.Controls.Add(Me.btnAceptar)
        Me.tbpMantenimiento.Controls.Add(Me.txtCodeFacultad)
        Me.tbpMantenimiento.Controls.Add(Me.lblFacultad)
        Me.tbpMantenimiento.Controls.Add(Me.label1)
        Me.tbpMantenimiento.Location = New System.Drawing.Point(4, 22)
        Me.tbpMantenimiento.Name = "tbpMantenimiento"
        Me.tbpMantenimiento.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpMantenimiento.Size = New System.Drawing.Size(517, 392)
        Me.tbpMantenimiento.TabIndex = 0
        Me.tbpMantenimiento.Text = "Mantenimiento"
        Me.tbpMantenimiento.UseVisualStyleBackColor = True
        '
        'nudFacultadID
        '
        Me.nudFacultadID.Location = New System.Drawing.Point(98, 6)
        Me.nudFacultadID.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.nudFacultadID.Name = "nudFacultadID"
        Me.nudFacultadID.ReadOnly = True
        Me.nudFacultadID.Size = New System.Drawing.Size(120, 20)
        Me.nudFacultadID.TabIndex = 9
        '
        'lblMaterialID
        '
        Me.lblMaterialID.AutoSize = True
        Me.lblMaterialID.Location = New System.Drawing.Point(9, 7)
        Me.lblMaterialID.Name = "lblMaterialID"
        Me.lblMaterialID.Size = New System.Drawing.Size(77, 13)
        Me.lblMaterialID.TabIndex = 8
        Me.lblMaterialID.Text = "ID FACULTAD"
        '
        'txtFacultad
        '
        Me.txtFacultad.Location = New System.Drawing.Point(99, 80)
        Me.txtFacultad.MaxLength = 100
        Me.txtFacultad.Name = "txtFacultad"
        Me.txtFacultad.Size = New System.Drawing.Size(410, 20)
        Me.txtFacultad.TabIndex = 7
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(410, 196)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(83, 196)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(83, 136)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtCodeFacultad
        '
        Me.txtCodeFacultad.Location = New System.Drawing.Point(98, 36)
        Me.txtCodeFacultad.MaxLength = 100
        Me.txtCodeFacultad.Name = "txtCodeFacultad"
        Me.txtCodeFacultad.Size = New System.Drawing.Size(228, 20)
        Me.txtCodeFacultad.TabIndex = 3
        '
        'lblFacultad
        '
        Me.lblFacultad.AutoSize = True
        Me.lblFacultad.Location = New System.Drawing.Point(8, 83)
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
        Me.label1.Size = New System.Drawing.Size(84, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Codigo Facultad"
        '
        'tbpConsulta
        '
        Me.tbpConsulta.Controls.Add(Me.Label2)
        Me.tbpConsulta.Controls.Add(Me.btnBuscar)
        Me.tbpConsulta.Controls.Add(Me.txtFacultadBuscar)
        Me.tbpConsulta.Controls.Add(Me.lblMateria)
        Me.tbpConsulta.Controls.Add(Me.dgvConsulta)
        Me.tbpConsulta.Location = New System.Drawing.Point(4, 22)
        Me.tbpConsulta.Name = "tbpConsulta"
        Me.tbpConsulta.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpConsulta.Size = New System.Drawing.Size(517, 392)
        Me.tbpConsulta.TabIndex = 1
        Me.tbpConsulta.Text = "Consulta"
        Me.tbpConsulta.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(115, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Consulta por nombre de Facultad"
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
        'txtFacultadBuscar
        '
        Me.txtFacultadBuscar.Location = New System.Drawing.Point(63, 36)
        Me.txtFacultadBuscar.MaxLength = 20
        Me.txtFacultadBuscar.Name = "txtFacultadBuscar"
        Me.txtFacultadBuscar.Size = New System.Drawing.Size(260, 20)
        Me.txtFacultadBuscar.TabIndex = 5
        '
        'lblMateria
        '
        Me.lblMateria.AutoSize = True
        Me.lblMateria.Location = New System.Drawing.Point(9, 39)
        Me.lblMateria.Name = "lblMateria"
        Me.lblMateria.Size = New System.Drawing.Size(48, 13)
        Me.lblMateria.TabIndex = 4
        Me.lblMateria.Text = "Facultad"
        '
        'dgvConsulta
        '
        Me.dgvConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsulta.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvConsulta.Location = New System.Drawing.Point(3, 83)
        Me.dgvConsulta.Name = "dgvConsulta"
        Me.dgvConsulta.Size = New System.Drawing.Size(511, 306)
        Me.dgvConsulta.TabIndex = 1
        '
        'frmFacultad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 418)
        Me.Controls.Add(Me.tbcPrincipal)
        Me.Name = "frmFacultad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facultad"
        Me.tbcPrincipal.ResumeLayout(False)
        Me.tbpMantenimiento.ResumeLayout(False)
        Me.tbpMantenimiento.PerformLayout()
        CType(Me.nudFacultadID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpConsulta.ResumeLayout(False)
        Me.tbpConsulta.PerformLayout()
        CType(Me.dgvConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents tbcPrincipal As TabControl
    Friend WithEvents tbpMantenimiento As TabPage
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents txtCodeFacultad As TextBox
    Friend WithEvents lblFacultad As Label
    Friend WithEvents label1 As Label
    Friend WithEvents tbpConsulta As TabPage
    Friend WithEvents txtFacultad As TextBox
    Friend WithEvents nudFacultadID As NumericUpDown
    Friend WithEvents lblMaterialID As Label
    Friend WithEvents dgvConsulta As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtFacultadBuscar As TextBox
    Friend WithEvents lblMateria As Label
    Friend WithEvents Label2 As Label
End Class
