Imports Capa_Datos
Imports Capa_Entidades
Imports System.Runtime.InteropServices
Public Class frmLogin
    Private band As Integer
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        band = 0
        txtClave.Focus()
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If band = 0 Then
            txtUsuario.UseSystemPasswordChar = False
            band = 1
        Else
            txtUsuario.UseSystemPasswordChar = True
            band = 0
        End If
    End Sub
    Private Sub ingresar()
        Dim objDAO As New clsUsuarioADO
        Dim objDAOE As New clsEmpleadoADO
        Dim obj As clsUsuario
        Dim objE As clsEmpleado
        Try
            If txtClave.Text.Trim.Length > 0 And txtUsuario.Text.Trim.Length > 0 Then
                obj = objDAO.buscarUsuario(txtUsuario.Text, txtClave.Text)
                If obj Is Nothing Then
                    MsgBox("Usuario o Clave Incorrecta", 16)
                Else
                    objE = objDAOE.buscarEmpleado(obj.idEmpleado)
                    MsgBox("Bienvenido " & objE.nombres & " " & objE.apPaterno & " " & objE.apMaterno, 64, "Acceso Correcto")
                    idCategoria = obj.idCategoriaUsuario
                    Dim ventana As New frmPrincipal
                    ventana.Show()
                    Me.Hide()
                End If
            Else
                MsgBox("Falta Ingresar Valores", 16)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        ingresar()
    End Sub

    Private Sub txtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsuario.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txtClave.Focus()
        End If
    End Sub

    Private Sub txtClave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtClave.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            ingresar()
        End If
    End Sub
End Class