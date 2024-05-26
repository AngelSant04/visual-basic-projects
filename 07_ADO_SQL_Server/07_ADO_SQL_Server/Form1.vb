Imports CapaDatos
Imports CapaEntidades
Public Class Form1
    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        Dim conexion As New clsConexion
        Dim objAD As New clsProfesionADO
        Try
            conexion.Conectar()
            objAD.agregar(New clsProfesion(0, "Ing.EPICI"))
            MsgBox("Profesion Agregada")
            conexion.Desconectar()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
