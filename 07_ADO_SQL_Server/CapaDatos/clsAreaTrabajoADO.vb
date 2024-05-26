Imports CapaEntidades
Imports System.Data.SqlClient

Public Class clsAreaTrabajoADO
    Public Sub agregar_PA(obj As clsAreaTrabajo)
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String

        Try
            sql = "pa_agregarareatrabajo"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            'agregar los parametros
            cmd.Parameters.Add("@descripcion", SqlDbType.Text).Value = obj.descripcion
            cmd.Parameters.Add("@nombJefe", SqlDbType.Text).Value = obj.nombJefe
            cmd.ExecuteNonQuery()
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub modificar(obj As clsAreaTrabajo)
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim sql As String

        Try
            sql = "Update AreaTrabajo" &
                  " set descripcion = '" & obj.descripcion & "'," &
                  " nombreJefe = '" & obj.nombJefe & "'" &
                  " where idArea = " & obj.idArea
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
            da = New SqlDataAdapter("select * from AreaTrabajo", cn.getConexion)
            da.Fill(dt)
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function
End Class
