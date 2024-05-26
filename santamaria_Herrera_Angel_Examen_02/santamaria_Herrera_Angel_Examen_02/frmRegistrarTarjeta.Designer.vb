<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrarTarjeta
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDosis = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.gpvDatosTarjeta = New System.Windows.Forms.GroupBox()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.gpbDatosCiudadano = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbVacuna = New System.Windows.Forms.ComboBox()
        Me.gpvDatosTarjeta.SuspendLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbDatosCiudadano.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(533, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 29)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "N° Dosis"
        '
        'txtDosis
        '
        Me.txtDosis.Enabled = False
        Me.txtDosis.Location = New System.Drawing.Point(653, 24)
        Me.txtDosis.Name = "txtDosis"
        Me.txtDosis.Size = New System.Drawing.Size(106, 35)
        Me.txtDosis.TabIndex = 4
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(130, 47)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 35)
        Me.dtpFecha.TabIndex = 5
        '
        'gpvDatosTarjeta
        '
        Me.gpvDatosTarjeta.Controls.Add(Me.dtpFecha)
        Me.gpvDatosTarjeta.Controls.Add(Me.Label2)
        Me.gpvDatosTarjeta.Location = New System.Drawing.Point(12, 160)
        Me.gpvDatosTarjeta.Name = "gpvDatosTarjeta"
        Me.gpvDatosTarjeta.Size = New System.Drawing.Size(497, 90)
        Me.gpvDatosTarjeta.TabIndex = 6
        Me.gpvDatosTarjeta.TabStop = False
        Me.gpvDatosTarjeta.Text = "Datos Tarjeta"
        '
        'dgvDatos
        '
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Location = New System.Drawing.Point(12, 256)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.RowHeadersWidth = 62
        Me.dgvDatos.RowTemplate.Height = 28
        Me.dgvDatos.Size = New System.Drawing.Size(884, 249)
        Me.dgvDatos.TabIndex = 7
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(634, 190)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(177, 46)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'gpbDatosCiudadano
        '
        Me.gpbDatosCiudadano.Controls.Add(Me.btnBuscar)
        Me.gpbDatosCiudadano.Controls.Add(Me.txtNombres)
        Me.gpbDatosCiudadano.Controls.Add(Me.Label4)
        Me.gpbDatosCiudadano.Controls.Add(Me.txtDNI)
        Me.gpbDatosCiudadano.Controls.Add(Me.Label1)
        Me.gpbDatosCiudadano.Location = New System.Drawing.Point(12, 12)
        Me.gpbDatosCiudadano.Name = "gpbDatosCiudadano"
        Me.gpbDatosCiudadano.Size = New System.Drawing.Size(497, 142)
        Me.gpbDatosCiudadano.TabIndex = 7
        Me.gpbDatosCiudadano.TabStop = False
        Me.gpbDatosCiudadano.Text = "Datos Ciudadano"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(354, 38)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(112, 46)
        Me.btnBuscar.TabIndex = 14
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(145, 94)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(321, 35)
        Me.txtNombres.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 29)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Nombres"
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(145, 47)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(185, 35)
        Me.txtDNI.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "DNI"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(533, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 29)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Vacuna"
        '
        'cmbVacuna
        '
        Me.cmbVacuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVacuna.FormattingEnabled = True
        Me.cmbVacuna.Location = New System.Drawing.Point(653, 75)
        Me.cmbVacuna.Name = "cmbVacuna"
        Me.cmbVacuna.Size = New System.Drawing.Size(243, 37)
        Me.cmbVacuna.TabIndex = 13
        '
        'frmRegistrarTarjeta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 509)
        Me.Controls.Add(Me.cmbVacuna)
        Me.Controls.Add(Me.gpbDatosCiudadano)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.gpvDatosTarjeta)
        Me.Controls.Add(Me.txtDosis)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmRegistrarTarjeta"
        Me.Text = "frmRegistrarTarjeta"
        Me.gpvDatosTarjeta.ResumeLayout(False)
        Me.gpvDatosTarjeta.PerformLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbDatosCiudadano.ResumeLayout(False)
        Me.gpbDatosCiudadano.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDosis As TextBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents gpvDatosTarjeta As GroupBox
    Friend WithEvents dgvDatos As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents gpbDatosCiudadano As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbVacuna As ComboBox
    Friend WithEvents btnBuscar As Button
End Class
