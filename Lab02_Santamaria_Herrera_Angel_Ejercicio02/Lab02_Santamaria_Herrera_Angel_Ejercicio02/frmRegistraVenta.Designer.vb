<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistraVenta
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gboVenta = New System.Windows.Forms.GroupBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbTipoVenta = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gboCelular = New System.Windows.Forms.GroupBox()
        Me.txtMeses = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gboConectividad = New System.Windows.Forms.GroupBox()
        Me.gboCable = New System.Windows.Forms.GroupBox()
        Me.txtPuntos = New System.Windows.Forms.TextBox()
        Me.txtCanales = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gboInternet = New System.Windows.Forms.GroupBox()
        Me.txtGigas = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbServicio = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Label()
        Me.lstDatos = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbDNI = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.gboVenta.SuspendLayout()
        Me.gboCelular.SuspendLayout()
        Me.gboConectividad.SuspendLayout()
        Me.gboCable.SuspendLayout()
        Me.gboInternet.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Controls.Add(Me.txtNumero)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-9, -5)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1576, 75)
        Me.Panel1.TabIndex = 1
        '
        'txtNumero
        '
        Me.txtNumero.Enabled = False
        Me.txtNumero.Location = New System.Drawing.Point(1335, 23)
        Me.txtNumero.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(204, 26)
        Me.txtNumero.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1118, 15)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "N° de Venta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(369, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REGISTRO DE VENTA"
        '
        'gboVenta
        '
        Me.gboVenta.Controls.Add(Me.txtMonto)
        Me.gboVenta.Controls.Add(Me.Label4)
        Me.gboVenta.Controls.Add(Me.cmbTipoVenta)
        Me.gboVenta.Controls.Add(Me.Label3)
        Me.gboVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboVenta.Location = New System.Drawing.Point(14, 92)
        Me.gboVenta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gboVenta.Name = "gboVenta"
        Me.gboVenta.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gboVenta.Size = New System.Drawing.Size(788, 243)
        Me.gboVenta.TabIndex = 2
        Me.gboVenta.TabStop = False
        Me.gboVenta.Text = "Datos De Venta"
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(238, 157)
        Me.txtMonto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(100, 40)
        Me.txtMonto.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 162)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 33)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Monto"
        '
        'cmbTipoVenta
        '
        Me.cmbTipoVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoVenta.FormattingEnabled = True
        Me.cmbTipoVenta.Items.AddRange(New Object() {"--Seleccione Opcion--", "Venta de Celular", "Servicio de Conectividad"})
        Me.cmbTipoVenta.Location = New System.Drawing.Point(238, 82)
        Me.cmbTipoVenta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbTipoVenta.Name = "cmbTipoVenta"
        Me.cmbTipoVenta.Size = New System.Drawing.Size(511, 41)
        Me.cmbTipoVenta.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 94)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 33)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tipo de Venta"
        '
        'gboCelular
        '
        Me.gboCelular.Controls.Add(Me.txtMeses)
        Me.gboCelular.Controls.Add(Me.Label7)
        Me.gboCelular.Controls.Add(Me.txtDescripcion)
        Me.gboCelular.Controls.Add(Me.txtMarca)
        Me.gboCelular.Controls.Add(Me.Label5)
        Me.gboCelular.Controls.Add(Me.Label6)
        Me.gboCelular.Enabled = False
        Me.gboCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboCelular.Location = New System.Drawing.Point(810, 92)
        Me.gboCelular.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gboCelular.Name = "gboCelular"
        Me.gboCelular.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gboCelular.Size = New System.Drawing.Size(722, 243)
        Me.gboCelular.TabIndex = 5
        Me.gboCelular.TabStop = False
        Me.gboCelular.Text = "Datos De Venta Celular"
        '
        'txtMeses
        '
        Me.txtMeses.Location = New System.Drawing.Point(238, 175)
        Me.txtMeses.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMeses.Name = "txtMeses"
        Me.txtMeses.Size = New System.Drawing.Size(472, 40)
        Me.txtMeses.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 180)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(189, 33)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Cant. Meses"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(238, 58)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(472, 40)
        Me.txtDescripcion.TabIndex = 5
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(238, 117)
        Me.txtMarca.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(472, 40)
        Me.txtMarca.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 122)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 33)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Marca"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 63)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(180, 33)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Descripcion"
        '
        'gboConectividad
        '
        Me.gboConectividad.Controls.Add(Me.gboCable)
        Me.gboConectividad.Controls.Add(Me.gboInternet)
        Me.gboConectividad.Controls.Add(Me.cmbServicio)
        Me.gboConectividad.Controls.Add(Me.Label9)
        Me.gboConectividad.Enabled = False
        Me.gboConectividad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboConectividad.Location = New System.Drawing.Point(14, 354)
        Me.gboConectividad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gboConectividad.Name = "gboConectividad"
        Me.gboConectividad.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gboConectividad.Size = New System.Drawing.Size(855, 317)
        Me.gboConectividad.TabIndex = 6
        Me.gboConectividad.TabStop = False
        Me.gboConectividad.Text = "Datos De Venta Conectividad"
        '
        'gboCable
        '
        Me.gboCable.Controls.Add(Me.txtPuntos)
        Me.gboCable.Controls.Add(Me.txtCanales)
        Me.gboCable.Controls.Add(Me.Label11)
        Me.gboCable.Controls.Add(Me.Label10)
        Me.gboCable.Location = New System.Drawing.Point(447, 126)
        Me.gboCable.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gboCable.Name = "gboCable"
        Me.gboCable.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gboCable.Size = New System.Drawing.Size(392, 169)
        Me.gboCable.TabIndex = 4
        Me.gboCable.TabStop = False
        Me.gboCable.Text = "Datos de Servicio Cable"
        '
        'txtPuntos
        '
        Me.txtPuntos.Location = New System.Drawing.Point(282, 108)
        Me.txtPuntos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPuntos.Name = "txtPuntos"
        Me.txtPuntos.Size = New System.Drawing.Size(80, 40)
        Me.txtPuntos.TabIndex = 8
        '
        'txtCanales
        '
        Me.txtCanales.Location = New System.Drawing.Point(282, 49)
        Me.txtCanales.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCanales.Name = "txtCanales"
        Me.txtCanales.Size = New System.Drawing.Size(80, 40)
        Me.txtCanales.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(32, 112)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(194, 33)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Cant. Puntos"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(32, 49)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(212, 33)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Cant. Canales"
        '
        'gboInternet
        '
        Me.gboInternet.Controls.Add(Me.txtGigas)
        Me.gboInternet.Controls.Add(Me.Label8)
        Me.gboInternet.Location = New System.Drawing.Point(15, 126)
        Me.gboInternet.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gboInternet.Name = "gboInternet"
        Me.gboInternet.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gboInternet.Size = New System.Drawing.Size(406, 169)
        Me.gboInternet.TabIndex = 3
        Me.gboInternet.TabStop = False
        Me.gboInternet.Text = "Datos de Servicio Internet"
        '
        'txtGigas
        '
        Me.txtGigas.Location = New System.Drawing.Point(278, 68)
        Me.txtGigas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtGigas.Name = "txtGigas"
        Me.txtGigas.Size = New System.Drawing.Size(80, 40)
        Me.txtGigas.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(48, 72)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(180, 33)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Cant. Gigas"
        '
        'cmbServicio
        '
        Me.cmbServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbServicio.FormattingEnabled = True
        Me.cmbServicio.Items.AddRange(New Object() {"--Seleccione Opcion--", "Servicio de Internet", "Servicio de Cable"})
        Me.cmbServicio.Location = New System.Drawing.Point(350, 51)
        Me.cmbServicio.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbServicio.Name = "cmbServicio"
        Me.cmbServicio.Size = New System.Drawing.Size(400, 41)
        Me.cmbServicio.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(96, 55)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(241, 33)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Tipo de Servicio"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.AutoSize = True
        Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.Location = New System.Drawing.Point(1353, 702)
        Me.btnRegistrar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(134, 33)
        Me.btnRegistrar.TabIndex = 7
        Me.btnRegistrar.Text = "Registrar"
        '
        'btnNuevo
        '
        Me.btnNuevo.AutoSize = True
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(1353, 772)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(99, 33)
        Me.btnNuevo.TabIndex = 8
        Me.btnNuevo.Text = "Nuevo"
        '
        'btnCerrar
        '
        Me.btnCerrar.AutoSize = True
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(1359, 902)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(98, 33)
        Me.btnCerrar.TabIndex = 9
        Me.btnCerrar.Text = "Cerrar"
        '
        'lstDatos
        '
        Me.lstDatos.FormattingEnabled = True
        Me.lstDatos.ItemHeight = 33
        Me.lstDatos.Location = New System.Drawing.Point(15, 54)
        Me.lstDatos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstDatos.Name = "lstDatos"
        Me.lstDatos.Size = New System.Drawing.Size(1225, 169)
        Me.lstDatos.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstDatos)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 680)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1251, 258)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de Ventas"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbDNI)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtTelefono)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtNombres)
        Me.GroupBox2.Controls.Add(Me.txtDireccion)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(878, 354)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(654, 317)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos De Venta Celular"
        '
        'cmbDNI
        '
        Me.cmbDNI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDNI.FormattingEnabled = True
        Me.cmbDNI.Items.AddRange(New Object() {"--Seleccione Opcion--"})
        Me.cmbDNI.Location = New System.Drawing.Point(237, 55)
        Me.cmbDNI.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbDNI.Name = "cmbDNI"
        Me.cmbDNI.Size = New System.Drawing.Size(400, 41)
        Me.cmbDNI.TabIndex = 9
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(22, 63)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 33)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "DNI"
        '
        'txtTelefono
        '
        Me.txtTelefono.Enabled = False
        Me.txtTelefono.Location = New System.Drawing.Point(237, 251)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(404, 40)
        Me.txtTelefono.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 258)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(136, 33)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Telefono"
        '
        'txtNombres
        '
        Me.txtNombres.Enabled = False
        Me.txtNombres.Location = New System.Drawing.Point(237, 131)
        Me.txtNombres.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(404, 40)
        Me.txtNombres.TabIndex = 5
        '
        'txtDireccion
        '
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(237, 194)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(404, 40)
        Me.txtDireccion.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(22, 198)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(147, 33)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Direccion"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(22, 135)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(141, 33)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Nombres"
        '
        'frmRegistraVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1544, 958)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.gboConectividad)
        Me.Controls.Add(Me.gboCelular)
        Me.Controls.Add(Me.gboVenta)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmRegistraVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmRegistraVenta"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gboVenta.ResumeLayout(False)
        Me.gboVenta.PerformLayout()
        Me.gboCelular.ResumeLayout(False)
        Me.gboCelular.PerformLayout()
        Me.gboConectividad.ResumeLayout(False)
        Me.gboConectividad.PerformLayout()
        Me.gboCable.ResumeLayout(False)
        Me.gboCable.PerformLayout()
        Me.gboInternet.ResumeLayout(False)
        Me.gboInternet.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents gboVenta As GroupBox
    Friend WithEvents cmbTipoVenta As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents gboCelular As GroupBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMeses As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents gboConectividad As GroupBox
    Friend WithEvents gboCable As GroupBox
    Friend WithEvents gboInternet As GroupBox
    Friend WithEvents cmbServicio As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPuntos As TextBox
    Friend WithEvents txtCanales As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtGigas As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnRegistrar As Label
    Friend WithEvents btnNuevo As Label
    Friend WithEvents btnCerrar As Label
    Friend WithEvents lstDatos As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbDNI As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
End Class
