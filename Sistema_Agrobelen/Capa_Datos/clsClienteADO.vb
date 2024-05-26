Imports Capa_Entidades
Imports System.Data.SqlClient
Public Class clsClienteADO
    Private sentencia As String = "select C.idCliente as ID, C.nombres+ ' ' +C.apPaterno+ ' ' +c.apMaterno AS 'NOMBRES COMPLETOS', " &
    "C.telefono AS TELEFONO, C.correo AS CORREO, C.direccion AS 'DIRECCIÓN',C.tipoDocumento AS 'TIPO DE PERSONA'  from Cliente C "
    Public Sub agregarCliente_PA(obj As clsCliente)
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Try

            sql = "pa_agregarCliente"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            'AGREGAR PARAMETROS
            cmd.Parameters.Add("@idCliente", SqlDbType.Text).Value = obj.idCliente
            cmd.Parameters.Add("@nombres", SqlDbType.Text).Value = obj.nombres
            cmd.Parameters.Add("@apPaterno", SqlDbType.Text).Value = obj.apPaterno
            cmd.Parameters.Add("@apMaterno", SqlDbType.Text).Value = obj.apMaterno
            cmd.Parameters.Add("@telefono", SqlDbType.Text).Value = obj.telefono
            cmd.Parameters.Add("@correo", SqlDbType.Text).Value = obj.correo
            cmd.Parameters.Add("@direccion", SqlDbType.Text).Value = obj.direccion
            cmd.Parameters.Add("@tipoDocumento", SqlDbType.Text).Value = obj.tipoDocumento
            cmd.ExecuteNonQuery()
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub modificarCliente_PA(obj As clsCliente)
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Try

            sql = "pa_modificarCliente"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            'AGREGAR PARAMETROS
            cmd.Parameters.Add("@idCliente", SqlDbType.Text).Value = obj.idCliente
            cmd.Parameters.Add("@nombres", SqlDbType.Text).Value = obj.nombres
            cmd.Parameters.Add("@apPaterno", SqlDbType.Text).Value = obj.apPaterno
            cmd.Parameters.Add("@apMaterno", SqlDbType.Text).Value = obj.apMaterno
            cmd.Parameters.Add("@telefono", SqlDbType.Text).Value = obj.telefono
            cmd.Parameters.Add("@correo", SqlDbType.Text).Value = obj.correo
            cmd.Parameters.Add("@direccion", SqlDbType.Text).Value = obj.direccion
            cmd.Parameters.Add("@tipoDocumento", SqlDbType.Text).Value = obj.tipoDocumento
            cmd.ExecuteNonQuery()
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function buscarCliente(idCliente As String) As clsCliente
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Dim dr As SqlDataReader
        Dim obj As clsCliente = Nothing

        Try
            sql = "select * from Cliente where idCliente= '" & idCliente & "'"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                obj = New clsCliente(dr.GetString(0), dr.GetString(1), dr.GetString(2),
                                     dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetString(7))
            End If
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return obj
    End Function
    ''LISTADO BASICO O GENERICO
    Public Function listado() As DataTable
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
    ''VARIANTE DEL LISTADO BASICO
    Public Function listadoXletra(texto) As DataTable
        Dim cn As New clsConexion
        Dim dt As New DataTable
        Dim sql As String
        Dim da As SqlDataAdapter
        Try
            cn.Conectar()
            sql = sentencia & "where C.idCliente like '" & texto & "%'"
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
            sql = sentencia & "where C.nombres like '" & texto & "%'"
            da = New SqlDataAdapter(sql, cn.getConexion)
            da.Fill(dt)
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function
End Class
