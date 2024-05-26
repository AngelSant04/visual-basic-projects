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
        Me.OPCIonesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REGISTRARUNAREAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REGISTRARUNEMPLEADOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.LISTADODEEMPLEADOSDEUNAREAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MODIFICARAREADEEMPLEADOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPCIonesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(488, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OPCIonesToolStripMenuItem
        '
        Me.OPCIonesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REGISTRARUNAREAToolStripMenuItem, Me.REGISTRARUNEMPLEADOToolStripMenuItem, Me.ToolStripMenuItem1, Me.LISTADODEEMPLEADOSDEUNAREAToolStripMenuItem, Me.ToolStripMenuItem2, Me.MODIFICARAREADEEMPLEADOToolStripMenuItem, Me.ToolStripMenuItem3, Me.SALIRToolStripMenuItem})
        Me.OPCIonesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCIonesToolStripMenuItem.Name = "OPCIonesToolStripMenuItem"
        Me.OPCIonesToolStripMenuItem.Size = New System.Drawing.Size(118, 29)
        Me.OPCIonesToolStripMenuItem.Text = "OPCIONES"
        '
        'REGISTRARUNAREAToolStripMenuItem
        '
        Me.REGISTRARUNAREAToolStripMenuItem.Name = "REGISTRARUNAREAToolStripMenuItem"
        Me.REGISTRARUNAREAToolStripMenuItem.Size = New System.Drawing.Size(484, 30)
        Me.REGISTRARUNAREAToolStripMenuItem.Text = "REGISTRAR UN AREA"
        '
        'REGISTRARUNEMPLEADOToolStripMenuItem
        '
        Me.REGISTRARUNEMPLEADOToolStripMenuItem.Name = "REGISTRARUNEMPLEADOToolStripMenuItem"
        Me.REGISTRARUNEMPLEADOToolStripMenuItem.Size = New System.Drawing.Size(484, 30)
        Me.REGISTRARUNEMPLEADOToolStripMenuItem.Text = "REGISTRAR UN EMPLEADO Y ASIGNAR AREA"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(481, 6)
        '
        'LISTADODEEMPLEADOSDEUNAREAToolStripMenuItem
        '
        Me.LISTADODEEMPLEADOSDEUNAREAToolStripMenuItem.Name = "LISTADODEEMPLEADOSDEUNAREAToolStripMenuItem"
        Me.LISTADODEEMPLEADOSDEUNAREAToolStripMenuItem.Size = New System.Drawing.Size(484, 30)
        Me.LISTADODEEMPLEADOSDEUNAREAToolStripMenuItem.Text = "LISTADO DE EMPLEADOS DE UN AREA"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(481, 6)
        '
        'MODIFICARAREADEEMPLEADOToolStripMenuItem
        '
        Me.MODIFICARAREADEEMPLEADOToolStripMenuItem.Name = "MODIFICARAREADEEMPLEADOToolStripMenuItem"
        Me.MODIFICARAREADEEMPLEADOToolStripMenuItem.Size = New System.Drawing.Size(484, 30)
        Me.MODIFICARAREADEEMPLEADOToolStripMenuItem.Text = "MODIFICAR AREA DE EMPLEADO"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(481, 6)
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(484, 30)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 266)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
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
    Friend WithEvents OPCIonesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REGISTRARUNAREAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REGISTRARUNEMPLEADOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents LISTADODEEMPLEADOSDEUNAREAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents MODIFICARAREADEEMPLEADOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
End Class
