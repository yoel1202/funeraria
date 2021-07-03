Imports CapaLogicaNegocio

Public Class Frm013i_actualizarfecha_recibos
    Dim CR As New ClsCredito 'Instanciamos la clase clsUsuario de la Capa Logica de Negocio para usar sus funciones
    Private Sub txt_recibo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_recibo.KeyDown
        If e.KeyCode = Keys.Enter Then
            CR.Serie = txt_recibo.Text
            Dim dt As DataTable = CR.listar_recibos_creditos_fecha

            If dt.Rows.Count > 0 Then
                lb_mensaje.Text = ""
                CR.codigoabono = CInt(dt.Rows(0)(0).ToString())
                CR.CodigoContrato = CInt(dt.Rows(0)(1).ToString())
                Dim dt2 As DataTable = CR.listar_recibos_creditos_fecha_contrato
                txt_Cliente.Text = dt2.Rows(0)(0).ToString()
                txt_numero_C.Text = dt2.Rows(0)(1).ToString()
                txt_monto_contrato.Text = CDec(dt2.Rows(0)(2).ToString())
                tb_monto_abono.Text = CDec(dt.Rows(0)(7).ToString())
                txt_direccion.Text = dt2.Rows(0)(5).ToString()
                dtpFechaInicial.Value = CDate(dt.Rows(0)(3).ToString())
                txt_ahorrado.Text = CDec(CR.Devolver_monto_credito())
                txt_periodo.Text = devoverperiodo(CR.Periodos_Recibos())
                txt_cuotas_ahorradas.Text = Math.Floor((CDec(txt_ahorrado.Text) / CDec(tb_monto_abono.Text)))
                txt_saldo_cuotas.Text = Math.Floor(CDec(dt2.Rows(0)(3).ToString()) - (CDec(txt_ahorrado.Text) / CDec(tb_monto_abono.Text)))
            Else
                lb_mensaje.Text = "No se ha encontrado ningun recibo con este numero:" + txt_recibo.Text
            End If

        End If
    End Sub
    Function devoverperiodo(periodo As String) As String

        Dim periodos = ""
        Dim isValidDate = CDate(periodo).ToString("MMMM yyyy")
        If (periodo <> "") Then
            Dim cadena As Integer = CInt(CDate(isValidDate).ToString("yyyy"))

            Dim suma = cadena + 1
            Select Case LCase(isValidDate)
                Case "enero " + cadena.ToString()
                    periodos = "Febrero " + cadena.ToString()
                Case "febrero " + cadena.ToString()
                    periodos = "Marzo " + cadena.ToString()
                Case "marzo " + cadena.ToString()
                    periodos = "Abril " + cadena.ToString()
                Case "abril " + cadena.ToString()
                    periodos = "Mayo " + cadena.ToString()
                Case "mayo " + cadena.ToString()
                    periodos = "Junio " + cadena.ToString()
                Case "junio " + cadena.ToString()
                    periodos = "Julio " + cadena.ToString()
                Case "julio " + cadena.ToString()
                    periodos = "Agosto " + cadena.ToString()
                Case "agosto " + cadena.ToString()
                    periodos = "Septiembre " + cadena.ToString()
                Case "septiembre " + cadena.ToString()
                    periodos = "Octubre " + cadena.ToString()
                Case "octubre " + cadena.ToString()
                    periodos = "Noviembre " + cadena.ToString()
                Case "noviembre " + cadena.ToString()
                    periodos = "Diciembre " + cadena.ToString()
                Case "diciembre " + cadena.ToString()
                    periodos = "Enero " + suma.ToString()
            End Select
        End If

        Return periodos
    End Function

    Private Sub btn_abonar_Click(sender As Object, e As EventArgs) Handles btn_abonar.Click
        Dim messaje As String = ""
        CR.Fecha = CDate(dtpFechaInicial.Value)
        CR.MontoAbono = CDec(tb_monto_abono.Text)
        messaje = CR.Actualizar_fecha_Creditos()
        clsMensaje.mostrar_mensaje(messaje, "ok")
    End Sub

    Private Sub lkb_cerrar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lkb_cerrar.LinkClicked
        Me.Close()
    End Sub

    Private Sub txt_recibo_TextChanged(sender As Object, e As EventArgs) Handles txt_recibo.TextChanged

    End Sub
End Class