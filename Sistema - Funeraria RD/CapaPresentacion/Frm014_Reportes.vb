Imports CapaLogicaNegocio

Public Class Frm014_Reportes
    Dim CR As New ClsCredito 'Instanciamos la clase clsUsuario de la Capa Logica de Negocio para usar sus funciones
    Dim C As New clsContratos 'Instanciamos la clase clsUsuario de la Capa Logica de Negocio para usar sus funciones
    Public frm_inicio As Frm_menu = New Frm_menu
    Private Sub ckbConsultar_CheckedChanged(sender As Object, e As EventArgs) Handles ckbConsultar.CheckedChanged
        If (ckbConsultar.Checked = True) Then
            dtpFechaInicial.Enabled = True
            dtpFechaFinal.Enabled = True

        Else
            dtpFechaInicial.Enabled = False
            dtpFechaFinal.Enabled = False

        End If
    End Sub

    Private Sub cb_tipo_reporte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_tipo_reporte.SelectedIndexChanged
        Select Case cb_tipo_reporte.SelectedItem
            Case "Historial de pagos"
                ch_dato.Enabled = True
                ckbConsultar.Enabled = True
                ch_dato.Text = "N° Contrato"

            Case "Reporte de recibos Recaudados Alfa"
                ch_dato.Enabled = True
                ckbConsultar.Enabled = True
                ch_dato.Text = "N° Contrato"
            Case "Reporte de recibos Recaudados University"
                ch_dato.Enabled = True
                ckbConsultar.Enabled = True
                ch_dato.Text = "N° Contrato"

            Case "Reporte de recibos cargados a cobro Alfa"
                ch_dato.Enabled = True
                ckbConsultar.Enabled = True
                ch_dato.Text = "N° Contrato"


            Case "Reporte de recibos cargados a cobro University"
                ch_dato.Enabled = True
                ckbConsultar.Enabled = True
                ch_dato.Text = "N° Contrato"
            Case "Servicios Brindados"
                ckbConsultar.Enabled = False
                ch_dato.Text = "N° Contrato"
        End Select





    End Sub
    Dim items As New ArrayList
    Private Sub cb_modulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_modulo.SelectedIndexChanged

        If (cb_modulo.SelectedItem = "Personal") Then
            cb_tipo_reporte.Items.Clear()

            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")

        ElseIf (cb_modulo.SelectedItem = "Productos y Servicios") Then
            cb_tipo_reporte.Items.Clear()
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")

        ElseIf (cb_modulo.SelectedItem = "Cotizaciones") Then
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Clear()
        ElseIf (cb_modulo.SelectedItem = "Clientes") Then
            cb_tipo_reporte.Items.Clear()
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")

        ElseIf (cb_modulo.SelectedItem = "Difunto") Then
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Clear()
        ElseIf (cb_modulo.SelectedItem = "Provedores") Then
            cb_tipo_reporte.Items.Clear()
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")

        ElseIf (cb_modulo.SelectedItem = "Compras") Then
            cb_tipo_reporte.Items.Clear()
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")

        ElseIf (cb_modulo.SelectedItem = "Ventas") Then
            cb_tipo_reporte.Items.Clear()
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")

        ElseIf (cb_modulo.SelectedItem = "Credito y Cobro") Then
            cb_tipo_reporte.Items.Clear()
            cb_tipo_reporte.Items.Add("Historial de pagos")
            cb_tipo_reporte.Items.Add("Reporte de recibos Recaudados Alfa")
            cb_tipo_reporte.Items.Add("Reporte de recibos cargados a cobro Alfa")
            cb_tipo_reporte.Items.Add("Reporte de recibos Recaudados University")
            cb_tipo_reporte.Items.Add("Reporte de recibos cargados a cobro University")

            cb_tipo_reporte.SelectedIndex = 0
        ElseIf (cb_modulo.SelectedItem = "Contratos") Then
            cb_tipo_reporte.Items.Clear()

            cb_tipo_reporte.Items.Add("Servicios Brindados")
            cb_tipo_reporte.Items.Add("Estado de Cuenta")
            cb_tipo_reporte.Items.Add("Contratos Cancelados Pendientes")
            cb_tipo_reporte.Items.Add("Contratos Activos Pendientes")
            cb_tipo_reporte.Items.Add("Contratos Anulados")
            cb_tipo_reporte.Items.Add("Contratos Morosos Pendientes")




        Else
            MsgBox("error" + cb_modulo.SelectedItem)







        End If
    End Sub

    Private Sub txtDatos_TextChanged(sender As Object, e As EventArgs) Handles txtDatos.TextChanged

    End Sub

    Private Sub btn_abonar_Click(sender As Object, e As EventArgs) Handles btn_abonar.Click
        If (cb_modulo.SelectedItem = "Personal") Then


            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Clear()
        ElseIf (cb_modulo.SelectedItem = "Productos y Servicios") Then
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Clear()
        ElseIf (cb_modulo.SelectedItem = "Cotizaciones") Then
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Clear()
        ElseIf (cb_modulo.SelectedItem = "Clientes") Then
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Clear()
        ElseIf (cb_modulo.SelectedItem = "Difunto") Then
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Clear()
        ElseIf (cb_modulo.SelectedItem = "Provedores") Then
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Clear()
        ElseIf (cb_modulo.SelectedItem = "Compras") Then
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Clear()
        ElseIf (cb_modulo.SelectedItem = "Ventas") Then
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Clear()
        ElseIf (cb_modulo.SelectedItem = "Credito y Cobro") Then

            Select Case cb_tipo_reporte.SelectedItem
                Case "Historial de pagos"
                    If ch_dato.Checked And txtDatos.Text <> "" Then
                        If (ckbConsultar.Checked = True) Then
                            CR.ncontrato = txtDatos.Text
                            CR.fecha1 = CDate(dtpFechaInicial.Value.Date)
                            CR.fecha2 = CDate(dtpFechaFinal.Value.Date)
                            dgv_reportes.DataSource = CR.RPT_Listar_Creditos_por_cliente()
                        Else
                            CR.ncontrato = txtDatos.Text
                            CR.fecha1 = CDate("1964-03-05 00:00:00")
                            CR.fecha2 = DateTime.Now
                            dgv_reportes.DataSource = CR.RPT_Listar_Creditos_por_cliente()


                        End If
                    Else
                        MsgBox("Es necesario insertar un numero de contrato")
                    End If
                Case "Reporte de recibos Recaudados Alfa"
                    If ckbConsultar.Checked = True Then

                        If (txtDatos.Text <> "") Then
                            CR.ncontrato = txtDatos.Text
                            CR.fecha1 = CDate(dtpFechaInicial.Value.Date)
                            CR.fecha2 = CDate(dtpFechaFinal.Value.Date)
                            dgv_reportes.DataSource = CR.RPT_Reporte_de_recibos_Recaudados_Alfa()
                        Else
                            CR.ncontrato = 0
                            CR.fecha1 = CDate(dtpFechaInicial.Value.Date)
                            CR.fecha2 = CDate(dtpFechaFinal.Value.Date)
                            dgv_reportes.DataSource = CR.RPT_Reporte_de_recibos_Recaudados_Alfa()

                        End If

                    Else
                        clsMensaje.mostrar_mensaje("Debe seleccionar una fecha", "error")
                    End If
                Case "Reporte de recibos Recaudados University"
                    If ckbConsultar.Checked = True Then

                        If (txtDatos.Text <> "") Then
                            CR.ncontrato = txtDatos.Text
                            CR.fecha1 = CDate(dtpFechaInicial.Value.Date)
                            CR.fecha2 = CDate(dtpFechaFinal.Value.Date)
                            dgv_reportes.DataSource = CR.RPT_Reporte_de_recibos_Recaudados_University()
                        Else
                            CR.ncontrato = 0
                            CR.fecha1 = CDate(dtpFechaInicial.Value.Date.Date)
                            CR.fecha2 = CDate(dtpFechaFinal.Value.Date.Date)
                            dgv_reportes.DataSource = CR.RPT_Reporte_de_recibos_Recaudados_University()

                        End If

                    Else
                        clsMensaje.mostrar_mensaje("Debe seleccionar una fecha", "error")
                    End If

                Case "Reporte de recibos cargados a cobro Alfa"
                    If ckbConsultar.Checked = True Then

                        If (txtDatos.Text <> "") Then
                            CR.ncontrato = txtDatos.Text
                            CR.fecha1 = CDate(dtpFechaInicial.Value.Date)
                            CR.fecha2 = CDate(dtpFechaFinal.Value.Date)
                            dgv_reportes.DataSource = CR.RPT_Reporte_de_recibos_agregados_a_cobro_Alfa()
                        Else
                            CR.ncontrato = 0
                            CR.fecha1 = CDate(dtpFechaInicial.Value.Date.Date)
                            CR.fecha2 = CDate(dtpFechaFinal.Value.Date.Date)
                            dgv_reportes.DataSource = CR.RPT_Reporte_de_recibos_agregados_a_cobro_Alfa()

                        End If

                    Else
                        clsMensaje.mostrar_mensaje("Debe seleccionar una fecha", "error")
                    End If


                Case "Reporte de recibos cargados a cobro University"
                    If ckbConsultar.Checked = True Then

                        If (txtDatos.Text <> "") Then
                            CR.ncontrato = txtDatos.Text
                            CR.fecha1 = CDate(dtpFechaInicial.Value.Date)
                            CR.fecha2 = CDate(dtpFechaFinal.Value.Date)
                            dgv_reportes.DataSource = CR.RPT_Reporte_de_recibos_agregados_a_cobro_University()
                        Else
                            CR.ncontrato = 0
                            CR.fecha1 = CDate(dtpFechaInicial.Value.Date.Date)
                            CR.fecha2 = CDate(dtpFechaFinal.Value.Date.Date)
                            dgv_reportes.DataSource = CR.RPT_Reporte_de_recibos_agregados_a_cobro_University()

                        End If

                    Else
                        clsMensaje.mostrar_mensaje("Debe seleccionar una fecha", "error")
                    End If
            End Select


        ElseIf (cb_modulo.SelectedItem = "Contratos") Then

            Select Case cb_tipo_reporte.SelectedItem
                Case "Servicios Brindados"
                    If (txtDatos.Text <> "") Then
                        CR.ncontrato = txtDatos.Text
                        dgv_reportes.DataSource = CR.RPT_SERVICIOS_BRINDADOS()

                    End If
                Case "Estado de Cuenta"
                    If (txtDatos.Text <> "") Then
                        C.RPTcontratos = txtDatos.Text
                        dgv_reportes.DataSource = C.RPT_ESTADO_CUENTA

                    End If
            End Select

        End If
    End Sub

    Private Sub lkbCerrar_Click(sender As Object, e As EventArgs) Handles lkbCerrar.Click
        frm_inicio.pn_principal.Controls.Clear()
        frm_inicio.pn_principal.Hide()

        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_exportar.Click
        If (cb_modulo.SelectedItem = "Personal") Then


            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Clear()
        ElseIf (cb_modulo.SelectedItem = "Productos y Servicios") Then
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Clear()
        ElseIf (cb_modulo.SelectedItem = "Cotizaciones") Then
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Clear()
        ElseIf (cb_modulo.SelectedItem = "Clientes") Then
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Clear()
        ElseIf (cb_modulo.SelectedItem = "Difunto") Then
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Clear()
        ElseIf (cb_modulo.SelectedItem = "Provedores") Then
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Clear()
        ElseIf (cb_modulo.SelectedItem = "Compras") Then
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Clear()
        ElseIf (cb_modulo.SelectedItem = "Ventas") Then
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Add("")
            cb_tipo_reporte.Items.Clear()
        ElseIf (cb_modulo.SelectedItem = "Credito y Cobro") Then
            Select Case cb_tipo_reporte.SelectedItem
                Case "Historial de pagos"
                    If txtDatos.Text <> "" Then
                        Dim reporte As New Frm_reporte001_Historial__de__pagos
                        If (ckbConsultar.Checked = True) Then
                            reporte.contrato = txtDatos.Text
                            reporte.fecha1 = CDate(dtpFechaInicial.Value.Date)
                            reporte.fecha2 = CDate(dtpFechaFinal.Value.Date)
                        Else
                            reporte.contrato = txtDatos.Text

                        End If
                        reporte.ShowDialog()


                    End If
                Case "Reporte de recibos Recaudados Alfa"
                    If ckbConsultar.Checked = True Then
                        Dim reporte As New Reporte_de_recibos_Recaudados_Alfa
                        If (txtDatos.Text <> "") Then
                            reporte.contrato = txtDatos.Text
                            reporte.fecha1 = CDate(dtpFechaInicial.Value.Date)
                            reporte.fecha2 = CDate(dtpFechaFinal.Value.Date)
                        Else
                            reporte.contrato = 0
                            reporte.fecha1 = CDate(dtpFechaInicial.Value.Date)
                            reporte.fecha2 = CDate(dtpFechaFinal.Value.Date)

                        End If
                        reporte.ShowDialog()

                    End If
                Case "Reporte de recibos Recaudados University"
                    If ckbConsultar.Checked = True Then
                        Dim reporte As New Reporte_de_recibos_Recaudados_University
                        If (txtDatos.Text <> "") Then
                            reporte.contrato = txtDatos.Text
                            reporte.fecha1 = CDate(dtpFechaInicial.Value.Date)
                            reporte.fecha2 = CDate(dtpFechaFinal.Value.Date)
                        Else
                            reporte.contrato = 0
                            reporte.fecha1 = CDate(dtpFechaInicial.Value.Date)
                            reporte.fecha2 = CDate(dtpFechaFinal.Value.Date)

                        End If
                        reporte.ShowDialog()

                    End If
                Case "Reporte de recibos cargados a cobro Alfa"
                    If ckbConsultar.Checked = True Then
                        Dim reporte As New Reporte_de_recibos_agregados_a_cobro_Alfa
                        If (txtDatos.Text <> "") Then
                            reporte.contrato = txtDatos.Text
                            reporte.fecha1 = CDate(dtpFechaInicial.Value.Date)
                            reporte.fecha2 = CDate(dtpFechaFinal.Value.Date)
                        Else
                            reporte.contrato = 0
                            reporte.fecha1 = CDate(dtpFechaInicial.Value.Date)
                            reporte.fecha2 = CDate(dtpFechaFinal.Value.Date)

                        End If
                        reporte.ShowDialog()

                    End If

                Case "Reporte de recibos cargados a cobro University"
                    If ckbConsultar.Checked = True Then
                        Dim reporte As New Reporte_de_recibos_agregados_a_cobro_University
                        If (txtDatos.Text <> "") Then
                            reporte.contrato = txtDatos.Text
                            reporte.fecha1 = CDate(dtpFechaInicial.Value.Date)
                            reporte.fecha2 = CDate(dtpFechaFinal.Value.Date)
                        Else

                            reporte.contrato = 0
                            reporte.fecha1 = CDate(dtpFechaInicial.Value.Date)
                            reporte.fecha2 = CDate(dtpFechaFinal.Value.Date)

                        End If
                        reporte.ShowDialog()

                    End If
            End Select


        ElseIf (cb_modulo.SelectedItem = "Contratos") Then
            Select Case cb_tipo_reporte.SelectedItem
                Case "Servicios Brindados"
                    Dim reporte As New Reporte_Servicios_Brindados
                    If (txtDatos.Text <> "") Then
                        reporte.contrato = txtDatos.Text
                        reporte.ShowDialog()
                    End If
                Case "Estado de Cuenta"
                    If (txtDatos.Text <> "") Then
                        Dim reporte As New Frm_reporte001_estado_cuentas
                        reporte.contrato = txtDatos.Text
                        reporte.ShowDialog()

                    End If
            End Select
        End If
    End Sub

    Private Sub Busqueda_Enter(sender As Object, e As EventArgs) Handles Busqueda.Enter

    End Sub

    Private Sub Frm014_Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_modulo.SelectedIndex = 0
        Me.SetBounds(58, 0, Screen.PrimaryScreen.Bounds.Width - 60, Screen.PrimaryScreen.Bounds.Height - 100)
    End Sub

    Private Sub ch_dato_CheckedChanged(sender As Object, e As EventArgs) Handles ch_dato.CheckedChanged
        If (ch_dato.Checked = True) Then
            txtDatos.Enabled = True


        Else
            txtDatos.Enabled = False
            txtDatos.Clear()

        End If
    End Sub
End Class