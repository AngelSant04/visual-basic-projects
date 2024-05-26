<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrarPrestamo
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbTipoPrestamo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtInteres = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDevolucion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gboPP = New System.Windows.Forms.GroupBox()
        Me.cmbTipoConstruccion = New System.Windows.Forms.ComboBox()
        Me.cmbTipoEstudio = New System.Windows.Forms.ComboBox()
        Me.cmbMotivoPP = New System.Windows.Forms.ComboBox()
        Me.cmbDNIPP = New System.Windows.Forms.ComboBox()
        Me.cmbTipoEmprendimiento = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.labelestudio = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.gboPE = New System.Windows.Forms.GroupBox()
        Me.txtCapital = New System.Windows.Forms.TextBox()
        Me.cmbGarantia = New System.Windows.Forms.ComboBox()
        Me.cmbMotivoPE = New System.Windows.Forms.ComboBox()
        Me.cmbDNIPE = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lstDatos = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.gboPP.SuspendLayout()
        Me.gboPE.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbTipoPrestamo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.DtpFecha)
        Me.GroupBox1.Controls.Add(Me.txtInteres)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDevolucion)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(441, 258)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales de Prestamo"
        '
        'cmbTipoPrestamo
        '
        Me.cmbTipoPrestamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoPrestamo.FormattingEnabled = True
        Me.cmbTipoPrestamo.Items.AddRange(New Object() {"--Seleccion Opcion--", "Prestamo Personal", "Prestamo Empresarial"})
        Me.cmbTipoPrestamo.Location = New System.Drawing.Point(204, 216)
        Me.cmbTipoPrestamo.Name = "cmbTipoPrestamo"
        Me.cmbTipoPrestamo.Size = New System.Drawing.Size(229, 32)
        Me.cmbTipoPrestamo.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 24)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Tipo de Prestamo"
        '
        'DtpFecha
        '
        Me.DtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(205, 71)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(228, 29)
        Me.DtpFecha.TabIndex = 10
        '
        'txtInteres
        '
        Me.txtInteres.Location = New System.Drawing.Point(204, 179)
        Me.txtInteres.Name = "txtInteres"
        Me.txtInteres.Size = New System.Drawing.Size(229, 29)
        Me.txtInteres.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 24)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Interes"
        '
        'txtDevolucion
        '
        Me.txtDevolucion.Location = New System.Drawing.Point(205, 144)
        Me.txtDevolucion.Name = "txtDevolucion"
        Me.txtDevolucion.Size = New System.Drawing.Size(229, 29)
        Me.txtDevolucion.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(181, 24)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Años de Devolucion"
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(205, 109)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(229, 29)
        Me.txtMonto.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Monto de Prestamo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(205, 36)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(229, 29)
        Me.txtCodigo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Codigo"
        '
        'gboPP
        '
        Me.gboPP.Controls.Add(Me.cmbTipoConstruccion)
        Me.gboPP.Controls.Add(Me.cmbTipoEstudio)
        Me.gboPP.Controls.Add(Me.cmbMotivoPP)
        Me.gboPP.Controls.Add(Me.cmbDNIPP)
        Me.gboPP.Controls.Add(Me.cmbTipoEmprendimiento)
        Me.gboPP.Controls.Add(Me.Label7)
        Me.gboPP.Controls.Add(Me.label)
        Me.gboPP.Controls.Add(Me.labelestudio)
        Me.gboPP.Controls.Add(Me.Label11)
        Me.gboPP.Controls.Add(Me.Label12)
        Me.gboPP.Enabled = False
        Me.gboPP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboPP.Location = New System.Drawing.Point(459, 22)
        Me.gboPP.Name = "gboPP"
        Me.gboPP.Size = New System.Drawing.Size(479, 230)
        Me.gboPP.TabIndex = 13
        Me.gboPP.TabStop = False
        Me.gboPP.Text = "Datos de Prestamo Personal"
        '
        'cmbTipoConstruccion
        '
        Me.cmbTipoConstruccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoConstruccion.FormattingEnabled = True
        Me.cmbTipoConstruccion.Items.AddRange(New Object() {"--Seleccion Opcion--", "Acabados de la casa", "Construccion de un Area"})
        Me.cmbTipoConstruccion.Location = New System.Drawing.Point(234, 147)
        Me.cmbTipoConstruccion.Name = "cmbTipoConstruccion"
        Me.cmbTipoConstruccion.Size = New System.Drawing.Size(229, 32)
        Me.cmbTipoConstruccion.TabIndex = 16
        '
        'cmbTipoEstudio
        '
        Me.cmbTipoEstudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoEstudio.FormattingEnabled = True
        Me.cmbTipoEstudio.Items.AddRange(New Object() {"--Seleccion Opcion--", "Pregrado", "Postgrado"})
        Me.cmbTipoEstudio.Location = New System.Drawing.Point(234, 109)
        Me.cmbTipoEstudio.Name = "cmbTipoEstudio"
        Me.cmbTipoEstudio.Size = New System.Drawing.Size(229, 32)
        Me.cmbTipoEstudio.TabIndex = 15
        '
        'cmbMotivoPP
        '
        Me.cmbMotivoPP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMotivoPP.FormattingEnabled = True
        Me.cmbMotivoPP.Items.AddRange(New Object() {"--Seleccion Opcion--", "Estudios", "Ampliacion o Mejora de Casa", "Construcciones o Emprendimiento"})
        Me.cmbMotivoPP.Location = New System.Drawing.Point(234, 71)
        Me.cmbMotivoPP.Name = "cmbMotivoPP"
        Me.cmbMotivoPP.Size = New System.Drawing.Size(229, 32)
        Me.cmbMotivoPP.TabIndex = 14
        '
        'cmbDNIPP
        '
        Me.cmbDNIPP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDNIPP.FormattingEnabled = True
        Me.cmbDNIPP.Items.AddRange(New Object() {"--Seleccion Opcion--"})
        Me.cmbDNIPP.Location = New System.Drawing.Point(234, 33)
        Me.cmbDNIPP.Name = "cmbDNIPP"
        Me.cmbDNIPP.Size = New System.Drawing.Size(229, 32)
        Me.cmbDNIPP.TabIndex = 13
        '
        'cmbTipoEmprendimiento
        '
        Me.cmbTipoEmprendimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoEmprendimiento.FormattingEnabled = True
        Me.cmbTipoEmprendimiento.Items.AddRange(New Object() {"--Seleccion Opcion--", "Pequeña Empresa", "Emprendimiento Individual"})
        Me.cmbTipoEmprendimiento.Location = New System.Drawing.Point(234, 185)
        Me.cmbTipoEmprendimiento.Name = "cmbTipoEmprendimiento"
        Me.cmbTipoEmprendimiento.Size = New System.Drawing.Size(229, 32)
        Me.cmbTipoEmprendimiento.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(220, 24)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Tipo de Emprendimiento"
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(8, 147)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(191, 24)
        Me.label.TabIndex = 6
        Me.label.Text = "Tipo de Construccion"
        '
        'labelestudio
        '
        Me.labelestudio.AutoSize = True
        Me.labelestudio.Location = New System.Drawing.Point(8, 112)
        Me.labelestudio.Name = "labelestudio"
        Me.labelestudio.Size = New System.Drawing.Size(143, 24)
        Me.labelestudio.TabIndex = 4
        Me.labelestudio.Text = "Tipo de Estudio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 24)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Motivo"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 24)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "DNI"
        '
        'gboPE
        '
        Me.gboPE.Controls.Add(Me.txtCapital)
        Me.gboPE.Controls.Add(Me.cmbGarantia)
        Me.gboPE.Controls.Add(Me.cmbMotivoPE)
        Me.gboPE.Controls.Add(Me.cmbDNIPE)
        Me.gboPE.Controls.Add(Me.Label8)
        Me.gboPE.Controls.Add(Me.Label14)
        Me.gboPE.Controls.Add(Me.Label15)
        Me.gboPE.Controls.Add(Me.Label16)
        Me.gboPE.Enabled = False
        Me.gboPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboPE.Location = New System.Drawing.Point(12, 278)
        Me.gboPE.Name = "gboPE"
        Me.gboPE.Size = New System.Drawing.Size(479, 194)
        Me.gboPE.TabIndex = 17
        Me.gboPE.TabStop = False
        Me.gboPE.Text = "Datos de Prestamo Empresarial"
        '
        'txtCapital
        '
        Me.txtCapital.Location = New System.Drawing.Point(234, 149)
        Me.txtCapital.Name = "txtCapital"
        Me.txtCapital.Size = New System.Drawing.Size(229, 29)
        Me.txtCapital.TabIndex = 16
        Me.txtCapital.Text = "0"
        '
        'cmbGarantia
        '
        Me.cmbGarantia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGarantia.FormattingEnabled = True
        Me.cmbGarantia.Items.AddRange(New Object() {"--Seleccion Opcion--", "Resolución de Formacion", "Escritura Publica de la Empresa", "Capital"})
        Me.cmbGarantia.Location = New System.Drawing.Point(234, 109)
        Me.cmbGarantia.Name = "cmbGarantia"
        Me.cmbGarantia.Size = New System.Drawing.Size(229, 32)
        Me.cmbGarantia.TabIndex = 15
        '
        'cmbMotivoPE
        '
        Me.cmbMotivoPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMotivoPE.FormattingEnabled = True
        Me.cmbMotivoPE.Items.AddRange(New Object() {"--Seleccion Opcion--", "Ampliar Locales de Empresa", "Mejorar Cadena de Produccion", "Inversiones Nacionales o Internacionales"})
        Me.cmbMotivoPE.Location = New System.Drawing.Point(234, 71)
        Me.cmbMotivoPE.Name = "cmbMotivoPE"
        Me.cmbMotivoPE.Size = New System.Drawing.Size(229, 32)
        Me.cmbMotivoPE.TabIndex = 14
        '
        'cmbDNIPE
        '
        Me.cmbDNIPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDNIPE.FormattingEnabled = True
        Me.cmbDNIPE.Items.AddRange(New Object() {"--Seleccion Opcion--"})
        Me.cmbDNIPE.Location = New System.Drawing.Point(234, 33)
        Me.cmbDNIPE.Name = "cmbDNIPE"
        Me.cmbDNIPE.Size = New System.Drawing.Size(229, 32)
        Me.cmbDNIPE.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 24)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Capital"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 112)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 24)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Garantia"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 79)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 24)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Motivo"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 41)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(41, 24)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "DNI"
        '
        'btnCerrar
        '
        Me.btnCerrar.AutoSize = True
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(639, 413)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(68, 24)
        Me.btnCerrar.TabIndex = 20
        Me.btnCerrar.Text = "Cerrar"
        '
        'btnNuevo
        '
        Me.btnNuevo.AutoSize = True
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(636, 351)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(71, 24)
        Me.btnNuevo.TabIndex = 19
        Me.btnNuevo.Text = "Nuevo"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.AutoSize = True
        Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.Location = New System.Drawing.Point(636, 296)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(93, 24)
        Me.btnRegistrar.TabIndex = 18
        Me.btnRegistrar.Text = "Registrar"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lstDatos)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 478)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(925, 168)
        Me.GroupBox4.TabIndex = 21
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Listado de Prestamos"
        '
        'lstDatos
        '
        Me.lstDatos.FormattingEnabled = True
        Me.lstDatos.ItemHeight = 24
        Me.lstDatos.Location = New System.Drawing.Point(10, 35)
        Me.lstDatos.Name = "lstDatos"
        Me.lstDatos.Size = New System.Drawing.Size(909, 124)
        Me.lstDatos.TabIndex = 10
        '
        'frmRegistrarPrestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 618)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.gboPE)
        Me.Controls.Add(Me.gboPP)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmRegistrarPrestamo"
        Me.Text = "frmRegistrarPrestamo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gboPP.ResumeLayout(False)
        Me.gboPP.PerformLayout()
        Me.gboPE.ResumeLayout(False)
        Me.gboPE.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDevolucion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtInteres As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DtpFecha As DateTimePicker
    Friend WithEvents cmbTipoPrestamo As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents gboPP As GroupBox
    Friend WithEvents cmbTipoEmprendimiento As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents label As Label
    Friend WithEvents labelestudio As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbTipoConstruccion As ComboBox
    Friend WithEvents cmbTipoEstudio As ComboBox
    Friend WithEvents cmbMotivoPP As ComboBox
    Friend WithEvents cmbDNIPP As ComboBox
    Friend WithEvents gboPE As GroupBox
    Friend WithEvents cmbGarantia As ComboBox
    Friend WithEvents cmbMotivoPE As ComboBox
    Friend WithEvents cmbDNIPE As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtCapital As TextBox
    Friend WithEvents btnCerrar As Label
    Friend WithEvents btnNuevo As Label
    Friend WithEvents btnRegistrar As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lstDatos As ListBox
End Class
