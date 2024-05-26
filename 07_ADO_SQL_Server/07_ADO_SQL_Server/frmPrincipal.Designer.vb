<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.MantenimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfesionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AreasDeTrabajoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarTareaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConcluirTareaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnularTareaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarTareasSemanalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosYSusTareasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientosToolStripMenuItem, Me.OperacionesToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(683, 46)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MantenimientosToolStripMenuItem
        '
        Me.MantenimientosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfesionesToolStripMenuItem, Me.AreasDeTrabajoToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.MantenimientosToolStripMenuItem.Name = "MantenimientosToolStripMenuItem"
        Me.MantenimientosToolStripMenuItem.Size = New System.Drawing.Size(249, 42)
        Me.MantenimientosToolStripMenuItem.Text = "Mantenimientos"
        '
        'ProfesionesToolStripMenuItem
        '
        Me.ProfesionesToolStripMenuItem.Name = "ProfesionesToolStripMenuItem"
        Me.ProfesionesToolStripMenuItem.Size = New System.Drawing.Size(342, 46)
        Me.ProfesionesToolStripMenuItem.Text = "Profesiones"
        '
        'AreasDeTrabajoToolStripMenuItem
        '
        Me.AreasDeTrabajoToolStripMenuItem.Name = "AreasDeTrabajoToolStripMenuItem"
        Me.AreasDeTrabajoToolStripMenuItem.Size = New System.Drawing.Size(342, 46)
        Me.AreasDeTrabajoToolStripMenuItem.Text = "Areas de Trabajo"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(342, 46)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(339, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(342, 46)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'OperacionesToolStripMenuItem
        '
        Me.OperacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarTareaToolStripMenuItem, Me.ConcluirTareaToolStripMenuItem, Me.AnularTareaToolStripMenuItem, Me.LimpiarTareasSemanalesToolStripMenuItem})
        Me.OperacionesToolStripMenuItem.Name = "OperacionesToolStripMenuItem"
        Me.OperacionesToolStripMenuItem.Size = New System.Drawing.Size(194, 42)
        Me.OperacionesToolStripMenuItem.Text = "Operaciones"
        '
        'RegistrarTareaToolStripMenuItem
        '
        Me.RegistrarTareaToolStripMenuItem.Name = "RegistrarTareaToolStripMenuItem"
        Me.RegistrarTareaToolStripMenuItem.Size = New System.Drawing.Size(460, 46)
        Me.RegistrarTareaToolStripMenuItem.Text = "Registrar Tarea"
        '
        'ConcluirTareaToolStripMenuItem
        '
        Me.ConcluirTareaToolStripMenuItem.Name = "ConcluirTareaToolStripMenuItem"
        Me.ConcluirTareaToolStripMenuItem.Size = New System.Drawing.Size(460, 46)
        Me.ConcluirTareaToolStripMenuItem.Text = "Concluir Tarea"
        '
        'AnularTareaToolStripMenuItem
        '
        Me.AnularTareaToolStripMenuItem.Name = "AnularTareaToolStripMenuItem"
        Me.AnularTareaToolStripMenuItem.Size = New System.Drawing.Size(460, 46)
        Me.AnularTareaToolStripMenuItem.Text = "Anular Tarea"
        '
        'LimpiarTareasSemanalesToolStripMenuItem
        '
        Me.LimpiarTareasSemanalesToolStripMenuItem.Name = "LimpiarTareasSemanalesToolStripMenuItem"
        Me.LimpiarTareasSemanalesToolStripMenuItem.Size = New System.Drawing.Size(460, 46)
        Me.LimpiarTareasSemanalesToolStripMenuItem.Text = "Limpiar Tareas Semanales"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadoDeEmpleadosToolStripMenuItem, Me.EmpleadosYSusTareasToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(149, 42)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ListadoDeEmpleadosToolStripMenuItem
        '
        Me.ListadoDeEmpleadosToolStripMenuItem.Name = "ListadoDeEmpleadosToolStripMenuItem"
        Me.ListadoDeEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(428, 46)
        Me.ListadoDeEmpleadosToolStripMenuItem.Text = "Listado de Empleados"
        '
        'EmpleadosYSusTareasToolStripMenuItem
        '
        Me.EmpleadosYSusTareasToolStripMenuItem.Name = "EmpleadosYSusTareasToolStripMenuItem"
        Me.EmpleadosYSusTareasToolStripMenuItem.Size = New System.Drawing.Size(428, 46)
        Me.EmpleadosYSusTareasToolStripMenuItem.Text = "Empleados y sus Tareas"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 285)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.Text = "frmPrincipal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MantenimientosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfesionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AreasDeTrabajoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OperacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarTareaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConcluirTareaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnularTareaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarTareasSemanalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosYSusTareasToolStripMenuItem As ToolStripMenuItem
End Class
