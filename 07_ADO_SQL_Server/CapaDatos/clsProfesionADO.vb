Imports CapaEntidades
Imports System.Data.SqlClient
Public Class clsProfesionADO
    'Envia SENTENCIAS a la BD: Insert, Update, Select, Delete

    Public Sub agregar(obj As clsProfesion)
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String

        Try
            sql = "INSERT INTO Profesion Values('" & obj.descripcion & "')"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.ExecuteNonQuery()
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub agregar_PA(obj As clsProfesion)
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String

        Try
            sql = "pa_agregarprofesion"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            'agregar los parametros
            cmd.Parameters.Add("@desc", SqlDbType.Text).Value = obj.descripcion
            cmd.ExecuteNonQuery()
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub modificar(obj As clsProfesion)
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String

        Try
            sql = "Update Profesion" &
                  " set descripcion = '" & obj.descripcion & "'" &
                  " where idProfesion = " & obj.idProfesion
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.ExecuteNonQuery()
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function listado() As DataTable
        Dim cn As New clsConexion
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            cn.Conectar()
            da = New SqlDataAdapter("select * from Profesion", cn.getConexion)
            da.Fill(dt)
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function

    Public Function nuevoListado() As ArrayList

    End Function
End Class
