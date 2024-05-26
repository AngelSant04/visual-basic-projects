Imports System.Data.SqlClient
Public Class clsConexion
    Private _cn As SqlConnection
    Sub New()
        Dim CadConexion As String
        CadConexion = "Data Source=(local); " &
            "Initial Catalog=BD_Examen_Progra_III; " &
           "Integrated Security=true"
        _cn = New SqlConnection(CadConexion)
    End Sub

    Public Sub Conectar()
        Try
            'Codigo fuente , que podria tener errores
            If _cn.State <> ConnectionState.Open Then
                _cn.Open()
            End If
        Catch ex As Exception
            'Captura del error que se produce en el Try
            Throw ex

        End Try
    End Sub
    Public Sub Desconectar()
        Try
            'Codigo fuente , que podria tener errores
            If _cn.State = ConnectionState.Open Then
                _cn.Close()
            End If
        Catch ex As Exception
            'Captura del error que se produce en el Try
            Throw ex

        End Try
    End Sub
    Public ReadOnly Property getConexion As SqlConnection
        Get
            Return _cn
        End Get
    End Property
End Class
