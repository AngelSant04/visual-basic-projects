Imports CapaEntidades
Imports System.Data.SqlClient
Public Class clsEmpleadoADO
    Public Sub agregar_PA(obj As clsEmpleado)
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String

        Try
            sql = "pa_agregararempleado"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            'agregar los parametros
            cmd.Parameters.Add("@dni", SqlDbType.Text).Value = obj.DNI
            cmd.Parameters.Add("@nombres", SqlDbType.Text).Value = obj.nombres
            cmd.Parameters.Add("@apPaterno", SqlDbType.Text).Value = obj.apPaterno
            cmd.Parameters.Add("@apMaterno", SqlDbType.Text).Value = obj.apMaterno
            cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = obj.fechaNac
            cmd.Parameters.Add("@estado", SqlDbType.Int).Value = obj.estado
            cmd.Parameters.Add("@usuario", SqlDbType.Text).Value = obj.usuario
            cmd.Parameters.Add("@clave", SqlDbType.Text).Value = obj.clave
            cmd.Parameters.Add("@idProf", SqlDbType.Int).Value = obj.idProfesion
            cmd.Parameters.Add("@tipo", SqlDbType.Int).Value = obj.tipo
            cmd.ExecuteNonQuery()
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub modificar(obj As clsEmpleado)
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String

        Try
            sql = "Update Empleado" &
                  " set nombres = '" & obj.nombres & "'," &
                  " apPaterno = '" & obj.apPaterno & "'," &
                  " apMaterno = '" & obj.apMaterno & "'," &
                  " fechaNac = '" & obj.fechaNac & "'," &
                  " estado = " & CInt(obj.estado) & "," &
                  " usuario = '" & obj.usuario & "'," &
                  " clave = '" & obj.clave & "'," &
                  " idProfesion = " & obj.idProfesion & "'," &
                  " tipo = " & obj.tipo & "" &
                  " where DNI = '" & obj.DNI & "'"

            'sql = "Update Profesion" &
            '      " set descripcion = '" & obj.descripcion & "'" &
            '      " where idProfesion = " & obj.idProfesion
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.ExecuteNonQuery()
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function buscarUsuario(usuario As String, clave As String) As DataTable
        Dim cn As New clsConexion
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            cn.Conectar()
            da = New SqlDataAdapter("select * from Empleado where usuario = '" & usuario & "' and clave = '" & clave & "'", cn.getConexion)
            da.Fill(dt)
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function

    Public Function listado() As DataTable
        Dim cn As New clsConexion
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            cn.Conectar()
            da = New SqlDataAdapter("select * from Empleado", cn.getConexion)
            da.Fill(dt)
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function
    Public Function verificaDNI_conDatos(dni As String) As clsEmpleado
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Dim dr As SqlDataReader
        Dim obj As clsEmpleado = Nothing

        Try
            sql = "select * from Empleado where DNI = '" & dni & "'"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                obj = New clsEmpleado(dr.GetString(0), dr.GetString(1),
                            dr.GetString(2), dr.GetString(3), dr.GetDateTime(4),
                            dr.GetBoolean(5), dr.GetString(6), dr.GetString(7), dr.GetInt32(8), dr.GetInt32(9))
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return obj
    End Function
End Class
