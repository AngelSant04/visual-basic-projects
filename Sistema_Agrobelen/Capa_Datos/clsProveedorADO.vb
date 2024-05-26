Imports Capa_Entidades
Imports System.Data.SqlClient
Public Class clsProveedorADO
    Private sentencia As String = "select P.idProveedor AS ID, P.nombre As 'RAZON SOCIAL',P.tipoDocumento AS 'PERSONA', " &
"P.direccion AS 'DIRECCIÓN', P.correo AS CORREO,P.telefono AS TELEFONO, P.estado AS ESTADO from Proveedor P "
    Public Sub agregarProveedor_PA(obj As clsProveedor)
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Try

            sql = "pa_agregarProveedor" 'Nombre de mi procedimiento almacenado
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            'AGREGAR PARAMETROS
            cmd.Parameters.Add("@idProveedor", SqlDbType.Text).Value = obj.idProveedor
            cmd.Parameters.Add("@nombres", SqlDbType.Text).Value = obj.nombre
            cmd.Parameters.Add("@tipoDocumento", SqlDbType.Text).Value = obj.tipoDocumento
            cmd.Parameters.Add("@direccion", SqlDbType.Text).Value = obj.direccion
            cmd.Parameters.Add("@correo", SqlDbType.Text).Value = obj.correo
            cmd.Parameters.Add("@telefono", SqlDbType.Text).Value = obj.telefono
            cmd.Parameters.Add("@estado", SqlDbType.Text).Value = obj.estado
            cmd.ExecuteNonQuery()
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub modificarProveedor_PA(obj As clsProveedor)
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Try

            sql = "pa_modificarProveedor"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            'AGREGAR PARAMETROS
            cmd.Parameters.Add("@idProveedor", SqlDbType.Text).Value = obj.idProveedor
            cmd.Parameters.Add("@nombres", SqlDbType.Text).Value = obj.nombre
            cmd.Parameters.Add("@tipoDocumento", SqlDbType.Text).Value = obj.tipoDocumento
            cmd.Parameters.Add("@direccion", SqlDbType.Text).Value = obj.direccion
            cmd.Parameters.Add("@correo", SqlDbType.Text).Value = obj.correo
            cmd.Parameters.Add("@telefono", SqlDbType.Text).Value = obj.telefono
            cmd.Parameters.Add("@estado", SqlDbType.Text).Value = obj.estado
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
            da = New SqlDataAdapter(sentencia, cn.getConexion)
            da.Fill(dt)
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function

    Public Function buscarProveedor(idProveedor As String) As clsProveedor
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Dim dr As SqlDataReader
        Dim obj As clsProveedor = Nothing

        Try
            sql = "select * from Proveedor where idProveedor= '" & idProveedor & "'"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                obj = New clsProveedor(dr.GetString(0), dr.GetString(1), dr.GetString(2),
                                     dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6))
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
            sql = sentencia & "where P.idProveedor like '" & texto & "%'"
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
            sql = sentencia & "where P.nombre like '" & texto & "%'"
            da = New SqlDataAdapter(sql, cn.getConexion)
            da.Fill(dt)
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function
End Class
