<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistraTarea
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
        Me.gbEmpleado = New System.Windows.Forms.GroupBox()
        Me.btnValidar = New System.Windows.Forms.Button()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTarea = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpHoraSalida = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraEntrada = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbAreaTrabajo = New System.Windows.Forms.ComboBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnConcluir = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.gbEmpleado.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbEmpleado
        '
        Me.gbEmpleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gbEmpleado.Controls.Add(Me.btnValidar)
        Me.gbEmpleado.Controls.Add(Me.txtNombres)
        Me.gbEmpleado.Controls.Add(Me.Label2)
        Me.gbEmpleado.Controls.Add(Me.txtDNI)
        Me.gbEmpleado.Controls.Add(Me.Label1)
        Me.gbEmpleado.Location = New System.Drawing.Point(12, 12)
        Me.gbEmpleado.Name = "gbEmpleado"
        Me.gbEmpleado.Size = New System.Drawing.Size(684, 187)
        Me.gbEmpleado.TabIndex = 0
        Me.gbEmpleado.TabStop = False
        Me.gbEmpleado.Text = "Datos Empleado"
        '
        'btnValidar
        '
        Me.btnValidar.Location = New System.Drawing.Point(357, 38)
        Me.btnValidar.Name = "btnValidar"
        Me.btnValidar.Size = New System.Drawing.Size(130, 45)
        Me.btnValidar.TabIndex = 8
        Me.btnValidar.Text = "Validar"
        Me.btnValidar.UseVisualStyleBackColor = True
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(144, 87)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(339, 39)
        Me.txtNombres.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 32)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombres"
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(144, 44)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(207, 39)
        Me.txtDNI.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 32)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "DNI"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.txtTarea)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dtpHoraSalida)
        Me.GroupBox1.Controls.Add(Me.dtpHoraEntrada)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbAreaTrabajo)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 205)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(529, 317)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Tarea Asignada"
        '
        'txtTarea
        '
        Me.txtTarea.Location = New System.Drawing.Point(144, 225)
        Me.txtTarea.Multiline = True
        Me.txtTarea.Name = "txtTarea"
        Me.txtTarea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTarea.Size = New System.Drawing.Size(364, 79)
        Me.txtTarea.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 32)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Tarea"
        '
        'dtpHoraSalida
        '
        Me.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraSalida.Location = New System.Drawing.Point(224, 179)
        Me.dtpHoraSalida.Name = "dtpHoraSalida"
        Me.dtpHoraSalida.Size = New System.Drawing.Size(232, 39)
        Me.dtpHoraSalida.TabIndex = 7
        '
        'dtpHoraEntrada
        '
        Me.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraEntrada.Location = New System.Drawing.Point(224, 138)
        Me.dtpHoraEntrada.Name = "dtpHoraEntrada"
        Me.dtpHoraEntrada.Size = New System.Drawing.Size(232, 39)
        Me.dtpHoraEntrada.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(175, 32)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Hora Salida"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(195, 32)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Hora Entrada"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(241, 32)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = " Area de Trabajo"
        '
        'cmbAreaTrabajo
        '
        Me.cmbAreaTrabajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAreaTrabajo.FormattingEnabled = True
        Me.cmbAreaTrabajo.Location = New System.Drawing.Point(261, 92)
        Me.cmbAreaTrabajo.Name = "cmbAreaTrabajo"
        Me.cmbAreaTrabajo.Size = New System.Drawing.Size(247, 40)
        Me.cmbAreaTrabajo.TabIndex = 2
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(119, 47)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(232, 39)
        Me.dtpFecha.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 32)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Fecha"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(547, 205)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(149, 53)
        Me.btnRegistrar.TabIndex = 2
        Me.btnRegistrar.Text = "Registra"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnConcluir
        '
        Me.btnConcluir.Location = New System.Drawing.Point(547, 264)
        Me.btnConcluir.Name = "btnConcluir"
        Me.btnConcluir.Size = New System.Drawing.Size(149, 53)
        Me.btnConcluir.TabIndex = 3
        Me.btnConcluir.Text = "Concluir"
        Me.btnConcluir.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(547, 323)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(149, 53)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmRegistraTarea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 534)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnConcluir)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbEmpleado)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frmRegistraTarea"
        Me.Text = "buscar"
        Me.gbEmpleado.ResumeLayout(False)
        Me.gbEmpleado.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbEmpleado As GroupBox
    Friend WithEvents btnValidar As Button
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtTarea As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpHoraSalida As DateTimePicker
    Friend WithEvents dtpHoraEntrada As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbAreaTrabajo As ComboBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnConcluir As Button
    Friend WithEvents btnSalir As Button
End Class
