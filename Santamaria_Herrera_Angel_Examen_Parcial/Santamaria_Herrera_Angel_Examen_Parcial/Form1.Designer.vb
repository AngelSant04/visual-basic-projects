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
        Me.RegistrarUnClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarUnPrestamoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CalculoDeCuotasDePrestamosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ListadoTotalDeUnTipoDePrestamoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ModificarPrestamoDeUnClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(608, 38)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarUnClienteToolStripMenuItem, Me.RegistrarUnPrestamoToolStripMenuItem, Me.ToolStripMenuItem1, Me.CalculoDeCuotasDePrestamosToolStripMenuItem, Me.ToolStripMenuItem2, Me.ListadoTotalDeUnTipoDePrestamoToolStripMenuItem, Me.ToolStripMenuItem3, Me.ModificarPrestamoDeUnClienteToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(116, 34)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'RegistrarUnClienteToolStripMenuItem
        '
        Me.RegistrarUnClienteToolStripMenuItem.Name = "RegistrarUnClienteToolStripMenuItem"
        Me.RegistrarUnClienteToolStripMenuItem.Size = New System.Drawing.Size(445, 34)
        Me.RegistrarUnClienteToolStripMenuItem.Text = "Registrar un Cliente"
        '
        'RegistrarUnPrestamoToolStripMenuItem
        '
        Me.RegistrarUnPrestamoToolStripMenuItem.Name = "RegistrarUnPrestamoToolStripMenuItem"
        Me.RegistrarUnPrestamoToolStripMenuItem.Size = New System.Drawing.Size(445, 34)
        Me.RegistrarUnPrestamoToolStripMenuItem.Text = "Registrar un Prestamo"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(442, 6)
        '
        'CalculoDeCuotasDePrestamosToolStripMenuItem
        '
        Me.CalculoDeCuotasDePrestamosToolStripMenuItem.Name = "CalculoDeCuotasDePrestamosToolStripMenuItem"
        Me.CalculoDeCuotasDePrestamosToolStripMenuItem.Size = New System.Drawing.Size(445, 34)
        Me.CalculoDeCuotasDePrestamosToolStripMenuItem.Text = "Calculo de Cuotas de Prestamos"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(442, 6)
        '
        'ListadoTotalDeUnTipoDePrestamoToolStripMenuItem
        '
        Me.ListadoTotalDeUnTipoDePrestamoToolStripMenuItem.Name = "ListadoTotalDeUnTipoDePrestamoToolStripMenuItem"
        Me.ListadoTotalDeUnTipoDePrestamoToolStripMenuItem.Size = New System.Drawing.Size(445, 34)
        Me.ListadoTotalDeUnTipoDePrestamoToolStripMenuItem.Text = "Listado total de un tipo de Prestamo"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(442, 6)
        '
        'ModificarPrestamoDeUnClienteToolStripMenuItem
        '
        Me.ModificarPrestamoDeUnClienteToolStripMenuItem.Name = "ModificarPrestamoDeUnClienteToolStripMenuItem"
        Me.ModificarPrestamoDeUnClienteToolStripMenuItem.Size = New System.Drawing.Size(445, 34)
        Me.ModificarPrestamoDeUnClienteToolStripMenuItem.Text = "Modificar Prestamo de un Cliente"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 347)
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
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarUnClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarUnPrestamoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents CalculoDeCuotasDePrestamosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents ListadoTotalDeUnTipoDePrestamoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents ModificarPrestamoDeUnClienteToolStripMenuItem As ToolStripMenuItem
End Class
