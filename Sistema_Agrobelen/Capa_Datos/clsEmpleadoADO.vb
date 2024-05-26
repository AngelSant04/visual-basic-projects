Imports Capa_Entidades
Imports System.Data.SqlClient
Public Class clsEmpleadoADO
    Private sentencia As String = "select E.idEmpleado AS ID, E.nombres+' '+ E.apPaterno +' '+ E.apMaterno AS 'NOMBRES COMPLETOS', " &
"E.fechaIngreso AS 'FECHA DE INGRESO', E.sueldo AS SUELDO, U.estado AS ESTADO, " &
"U.idUsuario AS 'ID USUARIO', U.clave AS CLAVE from Empleado E JOIN Usuario U ON U.idEmpleado=E.idEmpleado "
    Private sentenciaCombo As String = "select E.idEmpleado AS ID, E.nombres+' '+ E.apPaterno +' '+ E.apMaterno AS 'NOMBRES COMPLETOS', 
E.fechaIngreso AS 'FECHA DE INGRESO', E.sueldo AS SUELDO, U.estado AS ESTADO, 
U.idUsuario AS 'ID USUARIO', U.clave AS CLAVE from Empleado E JOIN Usuario U ON U.idEmpleado=E.idEmpleado where estado = 'ACTIVO'"
    Public Function listadoTOTAL() As DataTable
        Dim cn As New clsConexion
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            cn.Conectar()
            da = New SqlDataAdapter(sentencia, cn.getConexion)
            da.Fill(dt)
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function
    Public Function listadoActivo() As DataTable
        Dim cn As New clsConexion
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            cn.Conectar()
            da = New SqlDataAdapter(sentenciaCombo, cn.getConexion)
            da.Fill(dt)
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function
    Public Sub agregarEmpleado_PA(obj As clsEmpleado)
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Try

            sql = "pa_agregarEmpleado"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            'AGREGAR PARAMETROS
            cmd.Parameters.Add("@idEmpleado", SqlDbType.Text).Value = obj.idEmpleado
            cmd.Parameters.Add("@nombres", SqlDbType.Text).Value = obj.nombres
            cmd.Parameters.Add("@apPaterno", SqlDbType.Text).Value = obj.apPaterno
            cmd.Parameters.Add("@apMaterno", SqlDbType.Text).Value = obj.apMaterno
            cmd.Parameters.Add("@fechaIngreso", SqlDbType.Date).Value = obj.fechaIngreso
            cmd.Parameters.Add("@sueldo", SqlDbType.Float).Value = obj.sueldo
            cmd.ExecuteNonQuery()
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub modificarEmpleado_PA(obj As clsEmpleado)
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Try

            sql = "pa_modificarEmpleado"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            'AGREGAR PARAMETROS
            cmd.Parameters.Add("@idEmpleado", SqlDbType.Text).Value = obj.idEmpleado
            cmd.Parameters.Add("@nombres", SqlDbType.Text).Value = obj.nombres
            cmd.Parameters.Add("@apPaterno", SqlDbType.Text).Value = obj.apPaterno
            cmd.Parameters.Add("@apMaterno", SqlDbType.Text).Value = obj.apMaterno
            cmd.Parameters.Add("@fechaIngreso", SqlDbType.Date).Value = obj.fechaIngreso
            cmd.Parameters.Add("@sueldo", SqlDbType.Float).Value = obj.sueldo
            cmd.ExecuteNonQuery()
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function buscarEmpleado(idEmpleado As String) As clsEmpleado
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Dim dr As SqlDataReader
        Dim obj As clsEmpleado = Nothing

        Try
            sql = "select * from Empleado where idEmpleado= '" & idEmpleado & "'"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                obj = New clsEmpleado(dr.GetString(0), dr.GetString(1), dr.GetString(2),
                                     dr.GetString(3), dr.GetDateTime(4), dr.GetDouble(5))
            End If
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return obj
    End Function
    Public Function listadoXletra(texto) As DataTable
        Dim cn As New clsConexion
        Dim dt As New DataTable
        Dim sql As String
        Dim da As SqlDataAdapter
        Try
            cn.Conectar()
            sql = sentencia & "where E.idEmpleado like '" & texto & "%'"
            da = New SqlDataAdapter(sql, cn.getConexion)
            da.Fill(dt)
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function
    Public Function listadoXnombre(texto) As DataTable
        Dim cn As New clsConexion
        Dim dt As New DataTable
        Dim sql As String
        Dim da As SqlDataAdapter
        Try
            cn.Conectar()
            sql = sentencia & "where E.nombres like '" & texto & "%'"
            da = New SqlDataAdapter(sql, cn.getConexion)
            da.Fill(dt)
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function
End Class
