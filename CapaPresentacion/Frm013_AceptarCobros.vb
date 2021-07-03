Imports CapaLogicaNegocio

Public Class Frm013_AceptarCobros
    Dim Codigo_contrato As Integer
    Dim CR As New ClsCredito 'Instanciamos la clase clsUsuario de la Capa Logica de Negocio para usar sus funciones
    Dim U As New clsUsuario 'Instanciamos la clase clsUsuario de la Capa Logica de Negocio para usar sus funciones
    Private Sub txt_recibo_TextChanged(sender As Object, e As EventArgs) Handles txt_recibo.TextChanged

    End Sub

    Private Sub lkb_cerrar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lkb_cerrar.LinkClicked
        Close()
    End Sub
    Private Sub abonar()
        U.CodigoPersona = CStr(Codigo_Personal_Online)
        U.tipo = "personal"
        Dim permiso As String = U.Devolver_permisos()

        If (permiso = "Todos") Then
            ErrorProvider1.Clear()

            If (tb_monto_abono.Text.Trim() = "") Then
                ErrorProvider1.SetError(tb_monto_abono, "Debe Ingresar el Monto del Abono")
                'ElseIf (tb_monto_actual.Text.Trim() = "") Then
                '    ErrorProvider1.SetError(tb_monto_actual, "Debe Ingresar monto actual")
                'ElseIf (tb_comprobante.Text.Trim() = "") Then
                '    ErrorProvider1.SetError(tb_comprobante, "Debe Ingresar Número de Comprobante")


            Else
                Dim periodoc As String
                Dim periodoc2 As String
                Dim fecha As Date
                periodoc = CDate(CR.Periodos_Recibos()).ToString("MMMM yyyy")
                fecha = CDate(txt_periodo.Text).ToString("dd/MM/yyyy")
                periodoc2 = DateAdd("m", -1, fecha).ToString("MMMM yyyy")

                Dim Mensaje As String = ""
                    Try
                    If (periodoc2 = periodoc) Then
                        Dim resultado = 0

                        resultado = CDec(CR.Devolver_ultimo_monto_credito()) - CDec(tb_monto_abono.Text)
                        If (resultado >= 0) Then
                            CR.MontoAbono = tb_monto_abono.Text

                            CR.MontoActual = resultado
                            CR.Fecha = CDate(dtpFechaInicial.Value)
                            CR.Periodo = txt_periodo.Text
                            CR.CuotasAhorradas = txt_cuotas_ahorradas.Text
                            CR.Ahorrado = txt_ahorrado.Text
                            CR.SaldoCuotas = txt_saldo_cuotas.Text

                            Mensaje = CR.Registrar_Creditos_Carga()


                            If (Mensaje = "Recibo ya se registro") Then
                                clsMensaje.mostrar_mensaje(Mensaje, "error")
                            ElseIf (Mensaje = "Recibo no Existe") Then
                                clsMensaje.mostrar_mensaje(Mensaje, "error")
                            Else
                                clsMensaje.mostrar_mensaje(Mensaje, "ok")
                            End If
                            Limpiar_controles()

                        Else
                            clsMensaje.mostrar_mensaje("el monto del abono supera el monto actual o verifique el estado del contrato", "error")
                        End If
                    Else
                        clsMensaje.mostrar_mensaje("el recibo no se puede cancelar por que existe un recibo a cobro", "error")
                    End If
                Catch ex As Exception
                        clsMensaje.mostrar_mensaje(ex.Message, "error")
                    End Try



                End If

            End If
        btn_abonar.Enabled = True
    End Sub
    Private Sub btn_abonar_Click(sender As Object, e As EventArgs) Handles btn_abonar.Click
        btn_abonar.Enabled = False
        abonar()
    End Sub
    Private Sub Limpiar_controles()
        txt_numero_C.Text = ""
        txt_Cliente.Text = ""
        txt_direccion.Text = ""

        txt_periodo.Clear()

        txt_recibo.Clear()
        txt_monto_contrato.Clear()
        'CodigoProducto = 0

        txt_cuotas_ahorradas.Clear()
        txt_recibo.Clear()
        tb_monto_abono.Clear()


        txt_saldo_cuotas.Clear()
    End Sub

    Private Sub Frm013_AceptarCobros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_recibo.Focus()
        txt_recibo.Select()
    End Sub

    Private Sub txt_recibo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_recibo.KeyDown

        If e.KeyCode = Keys.Enter Then
            CR.Serie = txt_recibo.Text
            Dim dt As DataTable = CR.Listar_Recibos_Carga
            If dt.Rows.Count > 0 Then
                lb_mensaje.Text = ""

                If (CDec(dt.Rows(0)(9).ToString()) <> 10) Then

                    CR.CodigoContrato = CInt(dt.Rows(0)(0).ToString())
                    CR.codigocarga = CInt(dt.Rows(0)(7).ToString())
                    CR.Serie = CInt(dt.Rows(0)(8).ToString())
                    Codigo_contrato = CInt(dt.Rows(0)(0).ToString())
                    txt_Cliente.Text = dt.Rows(0)(1).ToString()
                    txt_numero_C.Text = dt.Rows(0)(2).ToString()
                    txt_monto_contrato.Text = CDec(dt.Rows(0)(3).ToString())
                    tb_monto_abono.Text = CDec(dt.Rows(0)(5).ToString())
                    txt_direccion.Text = dt.Rows(0)(6).ToString()

                    txt_ahorrado.Text = CDec(dt.Rows(0)(9).ToString())
                    txt_periodo.Text = dt.Rows(0)(12).ToString()
                    txt_cuotas_ahorradas.Text = dt.Rows(0)(11).ToString()
                    txt_saldo_cuotas.Text = dt.Rows(0)(10).ToString()
                Else

                    CR.CodigoContrato = CInt(dt.Rows(0)(0).ToString())
                    CR.codigocarga = CInt(dt.Rows(0)(7).ToString())
                    CR.Serie = CInt(dt.Rows(0)(8).ToString())
                    Codigo_contrato = CInt(dt.Rows(0)(0).ToString())
                    txt_Cliente.Text = dt.Rows(0)(1).ToString()
                    txt_numero_C.Text = dt.Rows(0)(2).ToString()
                    txt_monto_contrato.Text = CDec(dt.Rows(0)(3).ToString())
                    tb_monto_abono.Text = CDec(dt.Rows(0)(5).ToString())
                    txt_direccion.Text = dt.Rows(0)(6).ToString()

                    txt_ahorrado.Text = CDec(CR.Devolver_monto_credito()) + CDec(dt.Rows(0)(5).ToString())
                    txt_periodo.Text = devoverperiodo(CR.Periodos_Recibos())
                    txt_cuotas_ahorradas.Text = Math.Floor((CDec(txt_ahorrado.Text) / CDec(tb_monto_abono.Text)))
                    txt_saldo_cuotas.Text = Math.Floor(CDec(dt.Rows(0)(4).ToString()) - (CDec(txt_ahorrado.Text) / CDec(tb_monto_abono.Text)))
                End If
                Dim result As DialogResult = MessageBox.Show("Desea Abonar?",
                                  "Abonos",
                                  MessageBoxButtons.OKCancel)
                    If (result = DialogResult.OK) Then
                        abonar()
                    End If
                Else
                    lb_mensaje.Text = "No se ha encontrado ningun recibo con este numero:" + txt_recibo.Text
            End If
            'Dim result As DialogResult = MessageBox.Show("Desea Abonar?",
            '                  "Abonos",
            '                  MessageBoxButtons.OKCancel)
            'If (result = DialogResult.OK) Then
            '    abonar()
            'End If
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
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        CR.Serie = txt_recibo.Text
        Dim dt As DataTable = CR.Listar_Recibos
        If dt.Rows.Count > 0 Then
            CR.CodigoContrato = CInt(dt.Rows(0)(0).ToString())
            Codigo_contrato = CInt(dt.Rows(0)(0).ToString())
            txt_Cliente.Text = dt.Rows(0)(1).ToString()
            txt_numero_C.Text = dt.Rows(0)(2).ToString()
            txt_monto_contrato.Text = CDec(dt.Rows(0)(3).ToString())
            tb_monto_abono.Text = CDec(dt.Rows(0)(5).ToString())
            txt_direccion.Text = dt.Rows(0)(6).ToString()

            txt_ahorrado.Text = CDec(CR.Devolver_monto_credito())
            txt_periodo.Text = CDate(CR.Devolver_periodo()).ToString("MMMM yyyy")
            txt_saldo_cuotas.Text = Math.Floor((CDec(txt_ahorrado.Text) / CDec(tb_monto_abono.Text)))
            txt_cuotas_ahorradas.Text = Math.Floor(CDec(dt.Rows(0)(4).ToString()) - (CDec(txt_ahorrado.Text) / CDec(tb_monto_abono.Text)))
        End If
    End Sub


End Class