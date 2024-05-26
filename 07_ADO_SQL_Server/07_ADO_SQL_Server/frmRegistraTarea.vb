Imports CapaDatos
Imports CapaEntidades
Public Class frmRegistraTarea
    Private objTarea As clsAsignacionTarea = Nothing
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim objADO As New clsAsignacionADO
        Dim obj As clsAsignacionTarea
        Dim hora As TimeSpan

        Try
            'Validar el ingreso de datos
            hora = New TimeSpan(dtpHoraEntrada.Value.Hour, dtpHoraEntrada.Value.Minute, dtpHoraEntrada.Value.Second)
            obj = New clsAsignacionTarea(0, dtpFecha.Value, hora, hora, txtTarea.Text, txtDNI.Text, CInt(cmbAreaTrabajo.SelectedIndex), 1)
            'objADO.agregar(obj)
            objADO.agregar_PA(obj)
            MsgBox("Tarea Agregada")
            'limpiar()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        Dim objAdo As New clsEmpleadoADO
        Dim objAdo_Asig As New clsAsignacionADO
        Dim obj As clsEmpleado
        Try
            obj = objAdo.verificaDNI_conDatos(txtDNI.Text)
            If Not obj Is Nothing Then
                MsgBox("DNI es Valido")
                txtNombres.Text = obj.nombres & "" & obj.apPaterno & "" & obj.apMaterno
                objTarea = objAdo_Asig.verificarTareaPorConcluir(txtDNI.Text, dtpFecha.Value)
                If Not objTarea Is Nothing Then
                    Dim fecha As Date = New Date(1970, 1, 1, 0, 0, 0, 0)
                    dtpHoraEntrada.Value = fecha.AddSeconds(objTarea.horaEntrada.TotalSeconds)
                    txtTarea.Text = objTarea.tareaAsignada
                    cambiarEstado(False)
                    btnRegistrar.Enabled = False
                    btnConcluir.Enabled = True
                Else
                    btnRegistrar.Enabled = True
                    btnConcluir.Enabled = False
                End If
            Else
                MsgBox("DNI no existe")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub cambiarEstado(valor As Boolean)
        gbEmpleado.Enabled = valor
        dtpFecha.Enabled = valor
        dtpHoraEntrada.Enabled = valor
        dtpHoraSalida.Enabled = valor
        cmbAreaTrabajo.Enabled = valor
        txtTarea.Enabled = valor
    End Sub

    Private Sub btnConcluir_Click(sender As Object, e As EventArgs) Handles btnConcluir.Click
        Dim objADO As New clsAsignacionADO
        Dim obj As clsAsignacionTarea
        Dim hora As TimeSpan
        Try
            hora = New TimeSpan(dtpHoraEntrada.Value.Hour, dtpHoraEntrada.Value.Minute, dtpHoraSalida.Value.Second)
            obj = New clsAsignacionTarea(objTarea.idAsignacion, dtpFecha.Value, hora, hora, txtTarea.Text, txtDNI.Text, CInt(cmbAreaTrabajo.SelectedIndex), 1)
            'objADO.agregar(obj)
            objADO.concluirTarea_PA(obj)
            MsgBox("Tarea Concluida")
            'limpiar()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
End Class