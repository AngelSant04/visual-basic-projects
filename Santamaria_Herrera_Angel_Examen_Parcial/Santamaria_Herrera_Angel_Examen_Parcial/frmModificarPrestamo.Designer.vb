<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarPrestamo
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
        Me.lstDatos = New System.Windows.Forms.ListBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDevolucion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbMotivoPE = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbTipoConstruccion = New System.Windows.Forms.ComboBox()
        Me.cmbTipoEstudio = New System.Windows.Forms.ComboBox()
        Me.cmbMotivoPP = New System.Windows.Forms.ComboBox()
        Me.cmbTipoEmprendimiento = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.labelestudio = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstDatos
        '
        Me.lstDatos.FormattingEnabled = True
        Me.lstDatos.ItemHeight = 24
        Me.lstDatos.Location = New System.Drawing.Point(22, 22)
        Me.lstDatos.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.lstDatos.Name = "lstDatos"
        Me.lstDatos.Size = New System.Drawing.Size(1455, 268)
        Me.lstDatos.TabIndex = 0
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(289, 323)
        Me.txtMonto.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(417, 29)
        Me.txtMonto.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 323)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Monto de Prestamo"
        '
        'txtDevolucion
        '
        Me.txtDevolucion.Location = New System.Drawing.Point(289, 375)
        Me.txtDevolucion.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtDevolucion.Name = "txtDevolucion"
        Me.txtDevolucion.Size = New System.Drawing.Size(417, 29)
        Me.txtDevolucion.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 369)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(181, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Años de Devolucion"
        '
        'cmbMotivoPE
        '
        Me.cmbMotivoPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMotivoPE.FormattingEnabled = True
        Me.cmbMotivoPE.Items.AddRange(New Object() {"--Seleccion Opcion--", "Ampliar Locales de Empresa", "Mejorar Cadena de Produccion", "Inversiones Nacionales o Internacionales"})
        Me.cmbMotivoPE.Location = New System.Drawing.Point(289, 432)
        Me.cmbMotivoPE.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cmbMotivoPE.Name = "cmbMotivoPE"
        Me.cmbMotivoPE.Size = New System.Drawing.Size(417, 32)
        Me.cmbMotivoPE.TabIndex = 20
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(46, 426)
        Me.Label15.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 24)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Motivo"
        '
        'cmbTipoConstruccion
        '
        Me.cmbTipoConstruccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoConstruccion.FormattingEnabled = True
        Me.cmbTipoConstruccion.Items.AddRange(New Object() {"--Seleccion Opcion--", "Acabados de la casa", "Construccion de un Area"})
        Me.cmbTipoConstruccion.Location = New System.Drawing.Point(1060, 443)
        Me.cmbTipoConstruccion.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cmbTipoConstruccion.Name = "cmbTipoConstruccion"
        Me.cmbTipoConstruccion.Size = New System.Drawing.Size(417, 32)
        Me.cmbTipoConstruccion.TabIndex = 30
        '
        'cmbTipoEstudio
        '
        Me.cmbTipoEstudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoEstudio.FormattingEnabled = True
        Me.cmbTipoEstudio.Items.AddRange(New Object() {"--Seleccion Opcion--", "Pregrado", "Postgrado"})
        Me.cmbTipoEstudio.Location = New System.Drawing.Point(1060, 372)
        Me.cmbTipoEstudio.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cmbTipoEstudio.Name = "cmbTipoEstudio"
        Me.cmbTipoEstudio.Size = New System.Drawing.Size(417, 32)
        Me.cmbTipoEstudio.TabIndex = 29
        '
        'cmbMotivoPP
        '
        Me.cmbMotivoPP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMotivoPP.FormattingEnabled = True
        Me.cmbMotivoPP.Items.AddRange(New Object() {"--Seleccion Opcion--", "Estudios", "Ampliacion o Mejora de Casa", "Construcciones o Emprendimiento"})
        Me.cmbMotivoPP.Location = New System.Drawing.Point(1060, 302)
        Me.cmbMotivoPP.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cmbMotivoPP.Name = "cmbMotivoPP"
        Me.cmbMotivoPP.Size = New System.Drawing.Size(417, 32)
        Me.cmbMotivoPP.TabIndex = 28
        '
        'cmbTipoEmprendimiento
        '
        Me.cmbTipoEmprendimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoEmprendimiento.FormattingEnabled = True
        Me.cmbTipoEmprendimiento.Items.AddRange(New Object() {"--Seleccion Opcion--", "Pequeña Empresa", "Emprendimiento Individual"})
        Me.cmbTipoEmprendimiento.Location = New System.Drawing.Point(1060, 513)
        Me.cmbTipoEmprendimiento.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cmbTipoEmprendimiento.Name = "cmbTipoEmprendimiento"
        Me.cmbTipoEmprendimiento.Size = New System.Drawing.Size(417, 32)
        Me.cmbTipoEmprendimiento.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(831, 517)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(220, 24)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Tipo de Emprendimiento"
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(822, 440)
        Me.label.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(191, 24)
        Me.label.TabIndex = 25
        Me.label.Text = "Tipo de Construccion"
        '
        'labelestudio
        '
        Me.labelestudio.AutoSize = True
        Me.labelestudio.Location = New System.Drawing.Point(822, 380)
        Me.labelestudio.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.labelestudio.Name = "labelestudio"
        Me.labelestudio.Size = New System.Drawing.Size(143, 24)
        Me.labelestudio.TabIndex = 24
        Me.labelestudio.Text = "Tipo de Estudio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(842, 323)
        Me.Label11.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 24)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Motivo"
        '
        'btnModificar
        '
        Me.btnModificar.AutoSize = True
        Me.btnModificar.Location = New System.Drawing.Point(373, 540)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(86, 24)
        Me.btnModificar.TabIndex = 31
        Me.btnModificar.Text = "Modificar"
        '
        'frmModificarPrestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1517, 616)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.cmbTipoConstruccion)
        Me.Controls.Add(Me.cmbTipoEstudio)
        Me.Controls.Add(Me.cmbMotivoPP)
        Me.Controls.Add(Me.cmbTipoEmprendimiento)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.labelestudio)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmbMotivoPE)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtDevolucion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lstDatos)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "frmModificarPrestamo"
        Me.Text = "frmModificarPrestamo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstDatos As ListBox
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDevolucion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbMotivoPE As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cmbTipoConstruccion As ComboBox
    Friend WithEvents cmbTipoEstudio As ComboBox
    Friend WithEvents cmbMotivoPP As ComboBox
    Friend WithEvents cmbTipoEmprendimiento As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents label As Label
    Friend WithEvents labelestudio As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnModificar As Label
End Class
