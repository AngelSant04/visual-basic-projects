Public Class frmPrincipal
    Private formActual As Form = Nothing
    Private Sub abrirFormHijo(formHijo As Form)
        If Not IsNothing(formActual) Then
            formActual.Close()
        End If
        formActual = formHijo
        formHijo.TopLevel = False
        formHijo.FormBorderStyle = FormBorderStyle.None
        formHijo.Dock = DockStyle.Fill
        panelContenedor.Controls.Add(formHijo)
        panelContenedor.Tag = formHijo
        formHijo.BringToFront()
        formHijo.Show()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ocultarTools()
    End Sub
    Private Sub ocultarTools()
        If idCategoria = 2 Then
            buttonCompra.Visible = False
            buttonUsuario.Visible = False
        Else
            buttonUsuario.Visible = True
            buttonCompra.Visible = True
        End If
        tlSubMante.Visible = False
        tlSubVenta.Visible = False
        tlSubAlmacen.Visible = False
        tlsCompras.Visible = False
    End Sub
    Private Sub mostrarTools(toolmenu As ToolStrip)
        If toolmenu.Visible = False Then
            ocultarTools()
            toolmenu.Visible = True
        Else
            toolmenu.Visible = False

        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        mostrarTools(tlSubMante)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        mostrarTools(tlSubVenta)
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        mostrarTools(tlSubAlmacen)
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles buttonUsuario.Click
        abrirFormHijo(New frmEmpleado)
        ocultarTools()
    End Sub

    Private Sub frmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim ventana As New frmLogin
        ventana.Show()
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        abrirFormHijo(New frmProveedor)
        ocultarTools()
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        abrirFormHijo(New frmCliente)
        ocultarTools()
    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        abrirFormHijo(New frmProducto)
        ocultarTools()
    End Sub

    Private Sub ToolStripButton14_Click(sender As Object, e As EventArgs) Handles ToolStripButton14.Click
        Dim ventana As New frmAlmacen
        ventana.Show()
        ocultarTools()
    End Sub

    Private Sub ToolStripButton15_Click(sender As Object, e As EventArgs) Handles ToolStripButton15.Click
        Dim ventana As New frmCategoriaProducto
        ventana.Show()
        ocultarTools()
    End Sub
    Private Sub ToolStripButton12_Click(sender As Object, e As EventArgs) Handles ToolStripButton12.Click
        abrirFormHijo(New frmModificarVenta)
        ocultarTools()
    End Sub
    Private Sub ToolStripButton18_Click(sender As Object, e As EventArgs)
        abrirFormHijo(New frmModificarCompra)
        ocultarTools()
    End Sub

    Private Sub ToolStripButton16_Click(sender As Object, e As EventArgs) Handles ToolStripButton16.Click
        Dim ventana As New frmMantCompra
        ventana.Show()
        ocultarTools()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles buttonCompra.Click
        mostrarTools(tlsCompras)
    End Sub

    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs) Handles ToolStripButton10.Click
        Dim ventana As New frmVenta
        ventana.Show()
        ocultarTools()
    End Sub

    Private Sub ToolStripButton13_Click(sender As Object, e As EventArgs) Handles ToolStripButton13.Click
        abrirFormHijo(New dgvDatos2)
        ocultarTools()
    End Sub

    Private Sub ToolStripButton17_Click(sender As Object, e As EventArgs) Handles ToolStripButton17.Click
        abrirFormHijo(New frmModificarCompra)
        ocultarTools()
    End Sub

    Private Sub ToolStripButton11_Click(sender As Object, e As EventArgs) Handles ToolStripButton11.Click
        abrirFormHijo(New frmEntrada)
        ocultarTools()
    End Sub
End Class
