Imports Capa_Entidades
Imports System.Data.SqlClient
Public Class clsComprobanteADO
    Public Sub agregarComprobante_PA(obj As clsComprobante, cn As clsConexion)

        Dim cmd As SqlCommand
        Dim sql As String
        Try
            sql = "pa_agregarComprobante"
            cmd = New SqlCommand(sql, cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            'AGREGAR PARAMETROS
            cmd.Parameters.Add("@numComprobante", SqlDbType.Int).Value = obj.numComprobante
            cmd.Parameters.Add("@tipoCombronate", SqlDbType.Text).Value = obj.tipoComprobante
            cmd.Parameters.Add("@idVenta", SqlDbType.Int).Value = obj.idVenta
            cmd.Parameters.Add("@numTalonario", SqlDbType.Int).Value = obj.numTalonario
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
