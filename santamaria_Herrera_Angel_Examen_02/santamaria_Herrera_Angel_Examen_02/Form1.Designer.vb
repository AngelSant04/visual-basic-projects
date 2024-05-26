<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarVacunasDisponiblesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarTarjetaDeVacunacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeTodosLosCiudadanosVacunadosPorDistritoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeTarjetasParaUnCiudadanoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 48)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RegistroToolStripMenuItem
        '
        Me.RegistroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarVacunasDisponiblesToolStripMenuItem, Me.RegistrarTarjetaDeVacunacionToolStripMenuItem})
        Me.RegistroToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistroToolStripMenuItem.Name = "RegistroToolStripMenuItem"
        Me.RegistroToolStripMenuItem.Size = New System.Drawing.Size(141, 42)
        Me.RegistroToolStripMenuItem.Text = "Registro"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadoDeTodosLosCiudadanosVacunadosPorDistritoToolStripMenuItem, Me.ListadoDeTarjetasParaUnCiudadanoToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(149, 42)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'RegistrarVacunasDisponiblesToolStripMenuItem
        '
        Me.RegistrarVacunasDisponiblesToolStripMenuItem.Name = "RegistrarVacunasDisponiblesToolStripMenuItem"
        Me.RegistrarVacunasDisponiblesToolStripMenuItem.Size = New System.Drawing.Size(535, 46)
        Me.RegistrarVacunasDisponiblesToolStripMenuItem.Text = "Registrar Vacunas Disponibles"
        '
        'RegistrarTarjetaDeVacunacionToolStripMenuItem
        '
        Me.RegistrarTarjetaDeVacunacionToolStripMenuItem.Name = "RegistrarTarjetaDeVacunacionToolStripMenuItem"
        Me.RegistrarTarjetaDeVacunacionToolStripMenuItem.Size = New System.Drawing.Size(535, 46)
        Me.RegistrarTarjetaDeVacunacionToolStripMenuItem.Text = "Registrar Tarjeta de Vacunacion"
        '
        'ListadoDeTodosLosCiudadanosVacunadosPorDistritoToolStripMenuItem
        '
        Me.ListadoDeTodosLosCiudadanosVacunadosPorDistritoToolStripMenuItem.Name = "ListadoDeTodosLosCiudadanosVacunadosPorDistritoToolStripMenuItem"
        Me.ListadoDeTodosLosCiudadanosVacunadosPorDistritoToolStripMenuItem.Size = New System.Drawing.Size(843, 46)
        Me.ListadoDeTodosLosCiudadanosVacunadosPorDistritoToolStripMenuItem.Text = "Listado de todos los ciudadanos vacunados por distrito"
        '
        'ListadoDeTarjetasParaUnCiudadanoToolStripMenuItem
        '
        Me.ListadoDeTarjetasParaUnCiudadanoToolStripMenuItem.Name = "ListadoDeTarjetasParaUnCiudadanoToolStripMenuItem"
        Me.ListadoDeTarjetasParaUnCiudadanoToolStripMenuItem.Size = New System.Drawing.Size(843, 46)
        Me.ListadoDeTarjetasParaUnCiudadanoToolStripMenuItem.Text = "Listado de tarjetas para un ciudadano"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RegistroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarVacunasDisponiblesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarTarjetaDeVacunacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeTodosLosCiudadanosVacunadosPorDistritoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeTarjetasParaUnCiudadanoToolStripMenuItem As ToolStripMenuItem
End Class
