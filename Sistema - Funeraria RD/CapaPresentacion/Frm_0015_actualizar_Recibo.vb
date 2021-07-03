Imports CapaLogicaNegocio

Public Class Frm_0015_actualizar_Recibo
    Dim CR As New ClsCredito
    Dim U As New clsUsuario
    Public TipoAjuste As String

    Private Sub btn_abonar_Click(sender As Object, e As EventArgs) Handles btn_abonar.Click
        If (lblcodigoSerie.Text.Length() > 0) Then
            Dim messaje As String = ""
            CR.Periodo = txt_periodo.Text
            CR.Serie = lblcodigoSerie.Text
            CR.Ahorrado = txt_ahorrado.Text
            CR.SaldoCuotas = txt_saldo_cuotas.Text
            CR.CuotasAhorradas = txt_cuotas_ahorradas.Text
            messaje = CR.Actualizar_recibo()
            clsMensaje.mostrar_mensaje("Actualizado", "ok")
            U.CodigoPersona = CStr(Codigo_Personal_Online)
            U.Accion = "SE ACTUALIZÓ EL RECIBO # " + txtCodigoRecibo.Text
            U.fechas = DateTime.Now
            U.Registra_Acciones()
        End If
    End Sub

    Private Sub lkb_cerrar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lkb_cerrar.LinkClicked
        Me.Close()
    End Sub

    Private Sub txt_ahorrado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ahorrado.KeyPress
        Validar.Numeros(e)
    End Sub

    Private Sub txt_ahorrado_TextChanged(sender As Object, e As EventArgs) Handles txt_ahorrado.TextChanged
        If (txt_monto_contrato.Text.Length() > 0 And txt_ahorrado.Text.Length() > 0) Then
            txt_saldo_contrato.Text = Convert.ToString(Convert.ToDouble(txt_monto_contrato.Text) - Convert.ToDouble(txt_ahorrado.Text))
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Frm_0014_actualizarcontrato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (txt_monto_contrato.Text.Length() > 0 And txt_ahorrado.Text.Length() > 0) Then
            txt_saldo_contrato.Text = Convert.ToString(Convert.ToDouble(txt_monto_contrato.Text) - Convert.ToDouble(txt_ahorrado.Text))
        End If
    End Sub

    Private Sub dtpFechaInicial_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaInicial.ValueChanged
        txt_periodo.Text = TomarPeriodo(dtpFechaInicial.Value.ToShortDateString.ToString())
    End Sub

    Function TomarPeriodo(periodo As String) As String
        Dim periodos = ""
        Dim isValidDate = CDate(periodo).ToString("MMMM yyyy")
        If (periodo <> "") Then
            Dim cadena As Integer = CInt(CDate(isValidDate).ToString("yyyy"))
            Dim suma = cadena + 1
            Select Case LCase(isValidDate)
                Case "enero " + cadena.ToString()
                    periodos = "Enero " + cadena.ToString()
                Case "febrero " + cadena.ToString()
                    periodos = "Febrero " + cadena.ToString()
                Case "marzo " + cadena.ToString()
                    periodos = "Marzo " + cadena.ToString()
                Case "abril " + cadena.ToString()
                    periodos = "Abril " + cadena.ToString()
                Case "mayo " + cadena.ToString()
                    periodos = "Mayo " + cadena.ToString()
                Case "junio " + cadena.ToString()
                    periodos = "Junio " + cadena.ToString()
                Case "julio " + cadena.ToString()
                    periodos = "Julio " + cadena.ToString()
                Case "agosto " + cadena.ToString()
                    periodos = "Agosto " + cadena.ToString()
                Case "septiembre " + cadena.ToString()
                    periodos = "Septiembre " + cadena.ToString()
                Case "octubre " + cadena.ToString()
                    periodos = "Octubre " + cadena.ToString()
                Case "noviembre " + cadena.ToString()
                    periodos = "Noviembre " + cadena.ToString()
                Case "diciembre " + cadena.ToString()
                    periodos = "Diciembre " + suma.ToString()
            End Select
        End If
        Return periodos
    End Function

    Private Sub txtCodigoContrado_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigoRecibo.KeyDown
        If e.KeyCode = Keys.Enter Then
            CR.Serie = txtCodigoRecibo.Text
            Dim dt As DataTable = CR.Listar_actualizar_recibo
            lblcodigoSerie.Text = ""
            If dt.Rows.Count > 0 Then
                lblcodigoSerie.Text = dt.Rows(0)(1).ToString()
                txt_Contrato.Text = dt.Rows(0)(2).ToString()
                txt_Cliente.Text = dt.Rows(0)(3).ToString()
                txt_direccion.Text = dt.Rows(0)(4).ToString()
                txt_cuotas_ahorradas.Text = dt.Rows(0)(5).ToString()
                txt_monto_abono.Text = dt.Rows(0)(6).ToString()
                txt_saldo_cuotas.Text = dt.Rows(0)(7).ToString()
                txt_periodo.Text = dt.Rows(0)(8).ToString()
                txt_monto_contrato.Text = dt.Rows(0)(9).ToString()
                txt_ahorrado.Text = dt.Rows(0)(10).ToString()
            End If
        Else
            lb_mensaje.Text = "No se ha encontrado ningun recibo con este numero:" + txtCodigoRecibo.Text
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        lblcodigoSerie.Text = ""
        If (txtCodigoRecibo.Text <> "") Then
            CR.Serie = txtCodigoRecibo.Text
            Dim dt As DataTable = CR.Listar_actualizar_recibo
            If dt.Rows.Count > 0 Then
                lblcodigoSerie.Text = dt.Rows(0)(1).ToString()
                txt_Contrato.Text = dt.Rows(0)(2).ToString()
                txt_Cliente.Text = dt.Rows(0)(3).ToString()
                txt_direccion.Text = dt.Rows(0)(4).ToString()
                txt_cuotas_ahorradas.Text = dt.Rows(0)(5).ToString()
                txt_monto_abono.Text = dt.Rows(0)(6).ToString()
                txt_saldo_cuotas.Text = dt.Rows(0)(7).ToString()
                txt_periodo.Text = dt.Rows(0)(8).ToString()
                txt_monto_contrato.Text = dt.Rows(0)(9).ToString()
                txt_ahorrado.Text = dt.Rows(0)(10).ToString()
            Else
                lb_mensaje.Text = "No se ha encontrado ningun recibo con este numero:" + txtCodigoRecibo.Text
            End If
        Else
            lb_mensaje.Text = "Esta en Blanco el campo"
        End If
    End Sub

    Private Sub txt_saldo_cuotas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_saldo_cuotas.KeyPress
        Validar.Numeros(e)
    End Sub

    Private Sub txt_monto_abono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_monto_abono.KeyPress
        Validar.Numeros(e)
    End Sub

    Private Sub txt_cuotas_ahorradas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cuotas_ahorradas.KeyPress
        Validar.Numeros(e)
    End Sub
End Class