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
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistraEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistraVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ListadoDeVentasParaEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TotalesAcumuladosDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(469, 38)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistraEmpleadoToolStripMenuItem, Me.RegistraVentaToolStripMenuItem, Me.ToolStripMenuItem1, Me.ListadoDeVentasParaEmpleadoToolStripMenuItem, Me.TotalesAcumuladosDeEmpleadosToolStripMenuItem, Me.ToolStripMenuItem2, Me.SalirToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(116, 34)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'RegistraEmpleadoToolStripMenuItem
        '
        Me.RegistraEmpleadoToolStripMenuItem.Name = "RegistraEmpleadoToolStripMenuItem"
        Me.RegistraEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(424, 34)
        Me.RegistraEmpleadoToolStripMenuItem.Text = "Registra Empleado"
        '
        'RegistraVentaToolStripMenuItem
        '
        Me.RegistraVentaToolStripMenuItem.Name = "RegistraVentaToolStripMenuItem"
        Me.RegistraVentaToolStripMenuItem.Size = New System.Drawing.Size(424, 34)
        Me.RegistraVentaToolStripMenuItem.Text = "Registra Venta"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(421, 6)
        '
        'ListadoDeVentasParaEmpleadoToolStripMenuItem
        '
        Me.ListadoDeVentasParaEmpleadoToolStripMenuItem.Name = "ListadoDeVentasParaEmpleadoToolStripMenuItem"
        Me.ListadoDeVentasParaEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(424, 34)
        Me.ListadoDeVentasParaEmpleadoToolStripMenuItem.Text = "Listado de Ventas para Empleado"
        '
        'TotalesAcumuladosDeEmpleadosToolStripMenuItem
        '
        Me.TotalesAcumuladosDeEmpleadosToolStripMenuItem.Name = "TotalesAcumuladosDeEmpleadosToolStripMenuItem"
        Me.TotalesAcumuladosDeEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(424, 34)
        Me.TotalesAcumuladosDeEmpleadosToolStripMenuItem.Text = "Totales Acumulados de Empleados"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(421, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(424, 34)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 307)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistraEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistraVentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ListadoDeVentasParaEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TotalesAcumuladosDeEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
