Imports System.Data.SqlClient

Public Class clsConexion
    Private _cn As SqlConnection

    Sub New()
        Dim cadConexion As String

        'cadConexion = "Data Source = ANGEL-PC; " &
        '    "Initial Catalog = BD_Empleados_2020_II; " &
        '    "Integrated Security = true"  -> ESTE METODO ES PARA AUTENTICACION WINDOWS

        cadConexion = "Data Source = (local); " &  '-> Puedes ponerle el local o . o el nombre del servidor (ANGEL-PC)
            "Initial Catalog = BD_Empleados_2020_II; " &
            "User Id = sa; password = angelunprg"
        _cn = New SqlConnection(cadConexion)
    End Sub

    Public Sub Conectar()
        Try
            'Codigo fuente, que podría tener errores
            If _cn.State <> ConnectionState.Open Then
                _cn.Open()
            End If
        Catch ex As Exception
            'Captura del error que se produce en el try
            Throw ex
        End Try
    End Sub
    Public Sub Desconectar()
        Try
            'Codigo fuente, que podría tener errores
            If _cn.State = ConnectionState.Open Then
                _cn.Close()
            End If
        Catch ex As Exception
            'Captura del error que se produce en el try
            Throw ex
        End Try
    End Sub

    Public ReadOnly Property getConexion As SqlConnection
        Get
            Return _cn
        End Get
    End Property
End Class
