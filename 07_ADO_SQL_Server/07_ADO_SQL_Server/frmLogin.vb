Imports CapaDatos
Imports CapaEntidades
Public Class frmLogin
    Private band As Integer
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        band = 0
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If band = 0 Then
            txtClave.UseSystemPasswordChar = False
            band = 1
        Else
            txtClave.UseSystemPasswordChar = True
            band = 0
        End If
    End Sub

    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        Dim objAdo As New clsEmpleadoADO
        Dim dt As DataTable

        Try
            dt = objAdo.buscarUsuario(txtUsuario.Text, txtClave.Text)
            If dt.Rows.Count = 0 Then
                MsgBox("Usuario no encontrado")
            Else

                Dim ventana As New frmPrincipal
                ventana.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
End Class