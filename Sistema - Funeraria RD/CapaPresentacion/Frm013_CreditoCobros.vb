Imports System.Drawing.Imaging
Imports System.IO
Imports CapaLogicaNegocio
Imports iTextSharp.text.pdf

Public Class Frm013_CreditoCobros
    Public frm_inicio As Frm_menu = New Frm_menu
    Dim U As New clsUsuario 'Instanciamos la clase clsUsuario de la Capa Logica de Negocio para usar sus funciones
    Dim C As New clsContratos 'Instanciamos la clase clsUsuario de la Capa Logica de Negocio para usar sus funciones
    Dim CR As New ClsCredito 'Instanciamos la clase clsUsuario de la Capa Logica de Negocio para usar sus funciones
    Dim Codigo_contrato As Integer
    Dim selecionar_credito As Boolean
    Dim estados As String = ""
    Private Sub txtDatos_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub Listar_Cobros_por_cliente()
        Llenar_Grilla_cobros_asignados(CR.Listar_Cobros_por_cliente())
    End Sub
    Private Sub Listar_Cobros()
        Llenar_Grilla_cobros_asignados(CR.Listar_Carga())
    End Sub
    Private Sub Listar_Recibos()
        Llenar_Grilla_Recibos(CR.Listar_recibos_creditos())
    End Sub
    Private Sub Listar_Impresos()
        Llenar_Grilla_cobros_impresos(CR.Listar_recibos_impresos())
    End Sub
    Private Sub Listar_contratos_Cobros()
        Llenar_Grilla_cobros(C.Listar_Contratos_Cobros())
    End Sub
    Private Sub Listar_Contratos()
        Llenar_Grilla(C.Listar_Contratos_creditos(), Dgv_contratos)
    End Sub
    Private Sub Listar_orden()
        Llenar_Grilla_orden(C.Listar_Contratos_orden(), dgv_orden)
    End Sub
    Private Sub Listar_Creditos()
        Llenar_Grilla(C.Listar_Contratos_creditos(), dgv_lista_creditos)
    End Sub
    Private Sub Llenar_Grilla_cobros_impresos(ByVal dt As DataTable)
        Try
            dgv_impresos.Rows.Clear()

            For i = 0 To dt.Rows.Count - 1
                dgv_impresos.Rows.Add(dt.Rows(i)(0))
                dgv_impresos.Rows(i).Cells(0).Value = CInt(dt.Rows(i)(0).ToString())
                dgv_impresos.Rows(i).Cells(1).Value = dt.Rows(i)(1).ToString()
                dgv_impresos.Rows(i).Cells(2).Value = dt.Rows(i)(2).ToString()
                dgv_impresos.Rows(i).Cells(3).Value = dt.Rows(i)(3).ToString()
                dgv_impresos.Rows(i).Cells(4).Value = CDec(dt.Rows(i)(4).ToString())
                dgv_impresos.Rows(i).Cells(5).Value = CInt(dt.Rows(i)(5).ToString())

                dgv_impresos.Rows(i).Cells(6).Value = CDec(dt.Rows(i)(6).ToString())




                dgv_impresos.Rows(i).Cells(7).Value = dt.Rows(i)(7).ToString()
                dgv_impresos.Rows(i).Cells(8).Value = dt.Rows(i)(8).ToString()
                dgv_impresos.Rows(i).Cells(9).Value = dt.Rows(i)(9).ToString()
                dgv_impresos.Rows(i).Cells(10).Value = dt.Rows(i)(10).ToString()

                dgv_impresos.Rows(i).Cells(11).Value = Format(dt.Rows(i)(11), "dd/MM/yyyy")

                dgv_impresos.Rows(i).Cells(12).Value = dt.Rows(i)(12).ToString()
                dgv_impresos.Rows(i).Cells(13).Value = dt.Rows(i)(13).ToString()
                dgv_impresos.Rows(i).Cells(14).Value = dt.Rows(i)(14).ToString()
                dgv_impresos.Rows(i).Cells(15).Value = dt.Rows(i)(15).ToString()


            Next
            Me.dgv_impresos.ClearSelection()

        Catch ex As Exception
            clsMensaje.mostrar_mensaje(ex.Message, "error")
        End Try

    End Sub
    Private Sub Llenar_Grilla_orden(ByVal dt As DataTable, ByVal dgv As DataGridView)
        Try
            dgv.Rows.Clear()

            For i = 0 To dt.Rows.Count - 1
                dgv.Rows.Add(dt.Rows(i)(0))
                dgv.Rows(i).Cells(0).Value = CInt(dt.Rows(i)(0).ToString())
                dgv.Rows(i).Cells(1).Value = dt.Rows(i)(1).ToString()
                dgv.Rows(i).Cells(2).Value = dt.Rows(i)(2).ToString()
                dgv.Rows(i).Cells(3).Value = dt.Rows(i)(3).ToString()
                dgv.Rows(i).Cells(4).Value = dt.Rows(i)(4).ToString()
                dgv.Rows(i).Cells(5).Value = dt.Rows(i)(5).ToString()
                dgv.Rows(i).Cells(6).Value = dt.Rows(i)(6).ToString()


                If (dt.Rows(i)(6).ToString() = "LIQUIDADO" Or dt.Rows(i)(6).ToString() = "TRASLADO") Then 'Si el Stock es menor a Cero

                    dgv.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(255, 128, 128) 'Pintamos toda la fila de color rojo claro 
                    dgv.Rows(i).DefaultCellStyle.ForeColor = Color.White 'Asiganmos color blanco al texto
                ElseIf dt.Rows(i)(6).ToString() = "MOROSO PENDIENTE" Or dt.Rows(i)(6).ToString() = "ANULADO" Then
                    dgv.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(176, 149, 7) 'Pintamos toda la fila de color rojo claro 
                    dgv.Rows(i).DefaultCellStyle.ForeColor = Color.Black 'Asiganmos color blanco al texto
                ElseIf dt.Rows(i)(6).ToString() = "CANCELADO PENDIENTE" Then
                    dgv.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(10, 36, 9) 'Pintamos toda la fila de color rojo claro 
                    dgv.Rows(i).DefaultCellStyle.ForeColor = Color.White 'Asiganmos color blanco al texto

                End If


            Next
            dgv.ClearSelection()

        Catch ex As Exception
            clsMensaje.mostrar_mensaje(ex.Message, "error")
        End Try

    End Sub
    Private Sub Llenar_Grilla(ByVal dt As DataTable, ByVal dgv As DataGridView)
        Try
            dgv.Rows.Clear()

            For i = 0 To dt.Rows.Count - 1
                dgv.Rows.Add(dt.Rows(i)(0))
                dgv.Rows(i).Cells(0).Value = CInt(dt.Rows(i)(0).ToString())
                dgv.Rows(i).Cells(1).Value = dt.Rows(i)(1).ToString()
                dgv.Rows(i).Cells(2).Value = dt.Rows(i)(2).ToString()
                dgv.Rows(i).Cells(3).Value = dt.Rows(i)(3).ToString()
                dgv.Rows(i).Cells(4).Value = CDec(dt.Rows(i)(4).ToString())
                dgv.Rows(i).Cells(5).Value = CInt(dt.Rows(i)(5).ToString())
                dgv.Rows(i).Cells(6).Value = CDec(dt.Rows(i)(6).ToString())
                dgv.Rows(i).Cells(7).Value = dt.Rows(i)(7).ToString()
                dgv.Rows(i).Cells(8).Value = dt.Rows(i)(8).ToString()
                dgv.Rows(i).Cells(9).Value = dt.Rows(i)(9).ToString()
                dgv.Rows(i).Cells(10).Value = Format(dt.Rows(i)(10), "dd/MM/yyyy")
                dgv.Rows(i).Cells(11).Value = dt.Rows(i)(11).ToString()


                If (dt.Rows(i)(11).ToString() = "LIQUIDADO" Or dt.Rows(i)(11).ToString() = "TRASLADO") Then 'Si el Stock es menor a Cero

                    dgv.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(255, 128, 128) 'Pintamos toda la fila de color rojo claro 
                    dgv.Rows(i).DefaultCellStyle.ForeColor = Color.White 'Asiganmos color blanco al texto
                ElseIf dt.Rows(i)(11).ToString() = "MOROSO PENDIENTE" Or dt.Rows(i)(11).ToString() = "ANULADO" Then
                    dgv.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(176, 149, 7) 'Pintamos toda la fila de color rojo claro 
                    dgv.Rows(i).DefaultCellStyle.ForeColor = Color.Black 'Asiganmos color blanco al texto
                ElseIf dt.Rows(i)(11).ToString() = "CANCELADO PENDIENTE" Then
                    dgv.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(10, 36, 9) 'Pintamos toda la fila de color rojo claro 
                    dgv.Rows(i).DefaultCellStyle.ForeColor = Color.White 'Asiganmos color blanco al texto

                End If
                dgv.Rows(i).Cells(12).Value = dt.Rows(i)(12).ToString()

            Next
            dgv.ClearSelection()

        Catch ex As Exception
            clsMensaje.mostrar_mensaje(ex.Message, "error")
        End Try

    End Sub
    Private Sub Llenar_Grilla_cobros(ByVal dt As DataTable)
        Try
            dgv_cobros.Rows.Clear()

            For i = 0 To dt.Rows.Count - 1


                dgv_cobros.Rows.Add(dt.Rows(i)(0))
                dgv_cobros.Rows(i).Cells(0).Value = CInt(dt.Rows(i)(0).ToString())
                dgv_cobros.Rows(i).Cells(2).Value = dt.Rows(i)(1).ToString()
                dgv_cobros.Rows(i).Cells(3).Value = dt.Rows(i)(2).ToString()
                dgv_cobros.Rows(i).Cells(4).Value = dt.Rows(i)(3).ToString()
                dgv_cobros.Rows(i).Cells(5).Value = CDec(dt.Rows(i)(4).ToString())
                dgv_cobros.Rows(i).Cells(6).Value = CInt(dt.Rows(i)(5).ToString())
                dgv_cobros.Rows(i).Cells(7).Value = CDec(dt.Rows(i)(6).ToString())
                dgv_cobros.Rows(i).Cells(8).Value = dt.Rows(i)(7).ToString()
                dgv_cobros.Rows(i).Cells(9).Value = dt.Rows(i)(8).ToString()
                dgv_cobros.Rows(i).Cells(10).Value = dt.Rows(i)(9).ToString()
                dgv_cobros.Rows(i).Cells(11).Value = dt.Rows(i)(10).ToString()
                dgv_cobros.Rows(i).Cells(12).Value = dt.Rows(i)(11).ToString()

                If dt.Rows(i)(11).ToString() = "MOROSO PENDIENTE" Or dt.Rows(i)(11).ToString() = "ANULADO" Then
                    dgv_cobros.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 51) 'Pintamos toda la fila de color rojo claro 
                    dgv_cobros.Rows(i).DefaultCellStyle.ForeColor = Color.Black 'Asiganmos color blanco al texto
                ElseIf dt.Rows(i)(11).ToString() = "CANCELADO PENDIENTE" Then
                    dgv_cobros.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(0, 153, 0) 'Pintamos toda la fila de color rojo claro 
                    dgv_cobros.Rows(i).DefaultCellStyle.ForeColor = Color.White 'Asiganmos color blanco al texto

                End If


            Next
            Me.dgv_cobros.ClearSelection()

        Catch ex As Exception
            clsMensaje.mostrar_mensaje(ex.Message, "error")
        End Try

    End Sub

    Private Sub Llenar_Grilla_cobros_asignados(ByVal dt As DataTable)
        Try
            dgv_agregar_cobro.Rows.Clear()

            For i = 0 To dt.Rows.Count - 1
                dgv_agregar_cobro.Rows.Add(dt.Rows(i)(0))
                dgv_agregar_cobro.Rows(i).Cells(0).Value = CInt(dt.Rows(i)(0).ToString())
                dgv_agregar_cobro.Rows(i).Cells(2).Value = dt.Rows(i)(1).ToString()
                dgv_agregar_cobro.Rows(i).Cells(3).Value = dt.Rows(i)(2).ToString()
                dgv_agregar_cobro.Rows(i).Cells(4).Value = dt.Rows(i)(3).ToString()
                dgv_agregar_cobro.Rows(i).Cells(5).Value = CDec(dt.Rows(i)(4).ToString())
                dgv_agregar_cobro.Rows(i).Cells(6).Value = CInt(dt.Rows(i)(5).ToString())

                dgv_agregar_cobro.Rows(i).Cells(7).Value = CDec(dt.Rows(i)(6).ToString())



                dgv_agregar_cobro.Rows(i).Cells(8).Value = dt.Rows(i)(7).ToString()
                dgv_agregar_cobro.Rows(i).Cells(9).Value = dt.Rows(i)(8).ToString()
                dgv_agregar_cobro.Rows(i).Cells(10).Value = dt.Rows(i)(9).ToString()
                dgv_agregar_cobro.Rows(i).Cells(11).Value = dt.Rows(i)(10).ToString()

                dgv_agregar_cobro.Rows(i).Cells(12).Value = Format(dt.Rows(i)(11), "dd/MM/yyyy")
                dgv_agregar_cobro.Rows(i).Cells(13).Value = "Aceptar Cobros"
                dgv_agregar_cobro.Rows(i).Cells(14).Value = "Eliminar"
                dgv_agregar_cobro.Rows(i).Cells(15).Value = dt.Rows(i)(12).ToString()
                dgv_agregar_cobro.Rows(i).Cells(16).Value = dt.Rows(i)(13).ToString()
                dgv_agregar_cobro.Rows(i).Cells(17).Value = dt.Rows(i)(14).ToString()
                dgv_agregar_cobro.Rows(i).Cells(18).Value = dt.Rows(i)(15).ToString()

                dgv_agregar_cobro.Rows(i).Cells(19).Value = dt.Rows(i)(16).ToString()
                dgv_agregar_cobro.Rows(i).Cells(20).Value = dt.Rows(i)(17).ToString()
                dgv_agregar_cobro.Rows(i).Cells(21).Value = dt.Rows(i)(18).ToString()
                dgv_agregar_cobro.Rows(i).Cells(22).Value = dt.Rows(i)(19).ToString()
                dgv_agregar_cobro.Rows(i).Cells(23).Value = dt.Rows(i)(20).ToString()

                asignar_color_boton()
                asignar_color_boton_aceptar()
            Next
            Me.dgv_agregar_cobro.ClearSelection()

        Catch ex As Exception
            clsMensaje.mostrar_mensaje(ex.Message, "error")
        End Try

    End Sub
    Private Sub Llenar_Grilla_Recibos(ByVal dt As DataTable)
        Try
            dgv_recibos.Rows.Clear()
            Dim dt2 As DataTable
            For i = 0 To dt.Rows.Count - 1
                dgv_recibos.Rows.Add(dt.Rows(i)(0))
                dgv_recibos.Rows(i).Cells(0).Value = CInt(dt.Rows(i)(0).ToString())
                C.CodigoContratorecibos = CInt(dt.Rows(i)(6).ToString())
                dt2 =C.Buscar_recibos_Creditos_contratos
                dgv_recibos.Rows(i).Cells(1).Value = dt2.Rows(i)(0).ToString()
                dgv_recibos.Rows(i).Cells(2).Value = dt2.Rows(i)(1).ToString()
                dgv_recibos.Rows(i).Cells(3).Value = dt.Rows(i)(1).ToString()
                dgv_recibos.Rows(i).Cells(4).Value = dt2.Rows(i)(2).ToString()
                dgv_recibos.Rows(i).Cells(5).Value = dt2.Rows(i)(3).ToString()
                dgv_recibos.Rows(i).Cells(6).Value = dt2.Rows(i)(4).ToString()


                dgv_recibos.Rows(i).Cells(7).Value = dt2.Rows(i)(5).ToString()
                dgv_recibos.Rows(i).Cells(8).Value = Format(dt.Rows(i)(2), "dd/MM/yyyy")
                dgv_recibos.Rows(i).Cells(9).Value = dt2.Rows(i)(6).ToString()
                dgv_recibos.Rows(i).Cells(10).Value = dt.Rows(i)(3).ToString()

                dgv_recibos.Rows(i).Cells(11).Value = dt.Rows(i)(4).ToString()
                dgv_recibos.Rows(i).Cells(12).Value = dt.Rows(i)(5).ToString()



            Next
            Me.dgv_recibos.ClearSelection()

        Catch ex As Exception
            clsMensaje.mostrar_mensaje(ex.Message, "error")
        End Try

    End Sub
    Private Sub asignar_color_boton()
        For Each row As DataGridViewRow In dgv_agregar_cobro.Rows
            Dim button1 As DataGridViewButtonCell = CType(row.Cells(14), DataGridViewButtonCell)
            button1.Style.BackColor = Color.FromArgb(217, 83, 79)
            button1.Style.ForeColor = Color.White
            button1.Style.Font = New Font("Arial", 9, FontStyle.Bold)
        Next
    End Sub
    Private Sub asignar_color_boton_aceptar()
        For Each row As DataGridViewRow In dgv_agregar_cobro.Rows
            Dim button1 As DataGridViewButtonCell = CType(row.Cells(13), DataGridViewButtonCell)
            button1.Style.BackColor = Color.FromArgb(92, 184, 92)
            button1.Style.ForeColor = Color.White
            button1.Style.Font = New Font("Arial", 9, FontStyle.Bold)
        Next
    End Sub
    Private Sub asignar_color_boton_generar()
        For Each row As DataGridViewRow In dgv_creditos_cliente.Rows
            Dim button1 As DataGridViewButtonCell = CType(row.Cells(14), DataGridViewButtonCell)
            button1.Style.BackColor = Color.FromArgb(92, 184, 92)
            button1.Style.ForeColor = Color.White
            button1.Style.Font = New Font("Arial", 9, FontStyle.Bold)
        Next
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtDatos.TextChanged
        If (txtDatos.Text.Trim() <> "") Then
            Try
                C.dato = CStr(txtDatos.Text)
                Llenar_Grilla(C.Buscar_contrato_credito(), Dgv_contratos)
            Catch ex As Exception
                clsMensaje.mostrar_mensaje(ex.Message, "error")
            End Try
        Else
            Listar_Contratos()
        End If
    End Sub

    Private Sub Frm013_CreditoCobros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar_Contratos()
        Listar_orden()
        ''Listar_contratos_Cobros()
        'Listar_Cobros()
        Listar_Creditos()
        Listar_Impresos()
        'Listar_Recibos()
        tb_fecha.Text = DateTime.Now
        cb_zona.SelectedIndex = 0
        cb_reconocimiento.SelectedIndex = 0
        cb_zona_cargados.SelectedIndex = 0
        cb_provicional.SelectedIndex = 0
        Me.SetBounds(58, 0, Screen.PrimaryScreen.Bounds.Width - 60, Screen.PrimaryScreen.Bounds.Height - 100)
    End Sub

    Private Sub Dgv_contratos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_contratos.CellContentClick
        Try
            Codigo_contrato = Dgv_contratos.CurrentRow.Cells(0).Value.ToString()
            'MsgBox(Dgv_contratos.CurrentRow.Cells(0).Value.ToString())
            tb_monto_abono.Text = CDec(Dgv_contratos.CurrentRow.Cells(6).Value).ToString("###,###,###.00")
            txt_direccion.Text = Dgv_contratos.CurrentRow.Cells(12).Value.ToString()
            txt_Cliente.Text = Dgv_contratos.CurrentRow.Cells(1).Value.ToString()
            txt_numero_C.Text = Dgv_contratos.CurrentRow.Cells(2).Value.ToString()
            txt_monto_contrato.Text = Dgv_contratos.CurrentRow.Cells(4).Value.ToString()
            lb_total.Text = Dgv_contratos.CurrentRow.Cells(4).Value.ToString()
            lb_subtotal.Text = CDec(Dgv_contratos.CurrentRow.Cells(4).Value.ToString()) / 1.13
            lb_iva.Text = (CDec(Dgv_contratos.CurrentRow.Cells(4).Value.ToString()) / 1.13) * 0.13
            CR.CodigoContrato = Dgv_contratos.CurrentRow.Cells(0).Value.ToString()
            txt_ahorrado.Text = CDec(CR.Devolver_monto_credito())
            txt_periodo_total.Text = CDate(CR.Devolver_periodo()).ToString("MMMM yyyy")
            txt_saldo_cuotas.Text = Math.Floor(CDec(Dgv_contratos.CurrentRow.Cells(5).Value.ToString()) - Math.Floor((CDec(txt_ahorrado.Text) / CDec(tb_monto_abono.Text))))
            txt_cuotas_ahorradas.Text = Math.Floor((CDec(txt_ahorrado.Text) / CDec(tb_monto_abono.Text)))
            txt_periodo.Text = CDate(CR.Periodos_Recibos()).ToString("MMMM yyyy")
            Generar_Serie()
            estados = Dgv_contratos.CurrentRow.Cells(11).Value.ToString()
            selecionar_credito = True
            'End If
        Catch ex As Exception
            clsMensaje.mostrar_mensaje(ex.Message, "error")
        End Try
    End Sub
    Private Sub Generar_Serie()
        Try

            txt_recibo.Text = CR.Generar_Serie()
        Catch ex As Exception
            clsMensaje.mostrar_mensaje(ex.Message, "error")
        End Try
    End Sub
    Private Sub btn_abonar_Click(sender As Object, e As EventArgs) Handles btn_abonar.Click
        btn_abonar.Enabled = False
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

            ElseIf (Dgv_contratos.Rows.Count < 1) Then
                clsMensaje.mostrar_mensaje("No hay ningún Ítem agregado al carrito de Compra", "error")
            Else
                If (selecionar_credito) Then
                    Dim Mensaje As String = ""
                    Try
                        Dim resultado = 0
                        resultado = CDec(CR.Devolver_ultimo_monto_credito()) - Decimal.Parse(tb_monto_abono.Text.Substring(0, tb_monto_abono.Text.Length - 3))
                        If (resultado >= 0 And estados <> "LIQUIDADO" And estados <> "TRASLADO") Then
                            CR.MontoAbono = Decimal.Parse(tb_monto_abono.Text.Substring(0, tb_monto_abono.Text.Length - 3))
                            CR.MontoActual = resultado
                            CR.Fecha = CDate(tb_fecha.Text)
                            CR.Serie = txt_recibo.Text
                            CR.Periodo = txt_periodo.Text
                            CR.CuotasAhorradas = txt_cuotas_ahorradas.Text
                            CR.Ahorrado = txt_ahorrado.Text
                            CR.SaldoCuotas = txt_saldo_cuotas.Text
                            CR.reconocimiento = cb_reconocimiento.SelectedItem
                            CR.observaciones = rtb_observacion.Text
                            Mensaje = CR.Registrar_Credito()

                            clsMensaje.mostrar_mensaje(Mensaje, "ok")
                            Limpiar_controles()
                        Else
                            clsMensaje.mostrar_mensaje("el monto del abono supera el monto actual o verifique el estado del contrato", "error")
                        End If

                    Catch ex As Exception
                        clsMensaje.mostrar_mensaje(ex.Message, "error")
                    End Try
                End If

            End If

        End If
        btn_abonar.Enabled = True
    End Sub
    Private Sub Limpiar_controles()
        txt_numero_C.Text = ""
        txt_Cliente.Text = ""
        txt_direccion.Text = ""

        txt_periodo_total.Clear()


        txt_monto_contrato.Clear()
        'CodigoProducto = 0

        txt_cuotas_ahorradas.Clear()
        txt_recibo.Clear()
        tb_monto_abono.Clear()

        tb_fecha.Text = DateTime.Now
        txt_saldo_cuotas.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Panel_cabecera_Paint(sender As Object, e As PaintEventArgs) Handles Panel_cabecera.Paint

    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Dim Mensajes As String = ""
        Dim montocuota As Decimal = 0
        Dim nrecibos As Integer = 0
        Dim periodoc As Date
        Dim periodoactual As Date
        For Each dr As DataGridViewRow In Me.dgv_cobros.Rows
            If Not dr.Cells("Escoger").Value Is Nothing Then
                If dr.Cells("Escoger").Value.ToString() = "True" Then
                    CR.CodigoContrato = CInt(dr.Cells(0).Value.ToString())

                    nrecibos = CR.Devolver_n_recibos()
                    montocuota = CDec(dr.Cells(7).Value) * CDec(nrecibos)
                    CR.Estado = "Cargado"
                    CR.Fecha = DateTime.Now
                    CR.ahorradorecibo = CDec(CR.Devolver_monto_credito()) + montocuota
                    CR.Scuotas = Math.Floor(CDec(dr.Cells(6).Value.ToString()) - Math.Floor((CDec(CR.ahorradorecibo) / CDec(dr.Cells(7).Value))))
                    CR.Acuotas = Math.Floor((CDec(CR.ahorradorecibo) / CDec(dr.Cells(7).Value)))
                    periodoc = CDate(CR.Periodos_Recibos()).ToString("dd/MM/yyyy")
                    periodoactual = DateAdd("m", nrecibos, periodoc)

                    CR.periodosrecibo = periodoactual.ToString("MMMM yyyy")
                    CR.tiporecibo = cb_provicional.SelectedItem

                    Mensajes = CR.Registrar_Carga()
                    CR.CodigoContrato = 0
                End If
            End If
        Next
        clsMensaje.mostrar_mensaje(Mensajes, "ok")
        Listar_Cobros()
        Listar_contratos_Cobros()
    End Sub

    Private Sub seleccionar_CheckedChanged(sender As Object, e As EventArgs) Handles seleccionar.CheckedChanged
        If (seleccionar.Checked) Then
            'Necessary to end the edit mode of the Cell.
            dgv_cobros.EndEdit()

            'Loop and check and uncheck all row CheckBoxes based on Header Cell CheckBox.
            For Each row As DataGridViewRow In dgv_cobros.Rows
                Dim checkBox As DataGridViewCheckBoxCell = (TryCast(row.Cells("Escoger"), DataGridViewCheckBoxCell))
                checkBox.Value = True
            Next
        Else
            dgv_cobros.EndEdit()

            'Loop and check and uncheck all row CheckBoxes based on Header Cell CheckBox.
            For Each row As DataGridViewRow In dgv_cobros.Rows
                Dim checkBox As DataGridViewCheckBoxCell = (TryCast(row.Cells("Escoger"), DataGridViewCheckBoxCell))
                checkBox.Value = False
            Next
        End If
    End Sub

    Private Sub dgv_agregar_cobro_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_agregar_cobro.CellContentClick
        Try

            If (Me.dgv_agregar_cobro.Columns(e.ColumnIndex).Name.Equals("Opcion")) Then

                CR.CodigoCobros = dgv_agregar_cobro.CurrentRow.Cells(0).Value.ToString()
                Dim mensaje As String = CR.Eliminar_Cobro()
                clsMensaje.mostrar_mensaje(mensaje, "ok")

                Listar_Cobros()
            Else
                If (Me.dgv_agregar_cobro.Columns(e.ColumnIndex).Name.Equals("Aceptar")) Then

                    Dim value As String = dgv_agregar_cobro.CurrentRow.Cells(6).Value.ToString()

                    If clsMensaje.InputBox("Monto del cobro", "Inserte Monto de cuota:", value) = DialogResult.OK Then
                        U.CodigoPersona = CStr(Codigo_Personal_Online)
                        U.tipo = "personal"
                        Dim permiso As String = U.Devolver_permisos()

                        If (permiso = "Todos") Then

                            If (clsMensaje.GetValue.Trim() = "" Or clsMensaje.GetValue <= 0) Then
                                clsMensaje.mostrar_mensaje("Debe Ingresar el Monto del Abono correcto", "error")

                            Else

                                Dim Mensaje As String = ""
                                Try

                                    CR.CodigoContrato = dgv_agregar_cobro.CurrentRow.Cells(14).Value.ToString()

                                    Dim ahorrado = CR.Devolver_monto_credito()
                                    Dim resultado = 0
                                    resultado = CDec(ahorrado) - CDec(clsMensaje.GetValue())
                                    If (resultado >= 0) Then

                                        CR.CodigoCobros = dgv_agregar_cobro.CurrentRow.Cells(0).Value.ToString()
                                        CR.MontoAbono = clsMensaje.GetValue()
                                        CR.MontoActual = resultado
                                        CR.Fecha = DateTime.Now
                                        CR.Serie = CR.ObtenerCodigoSerie
                                        CR.Periodo = CDate(dgv_agregar_cobro.CurrentRow.Cells(11).Value.ToString()).ToString("MMMM yyyy")
                                        CR.Ahorrado = CStr(CDec(dgv_agregar_cobro.CurrentRow.Cells(4).Value.ToString()) - CDec(CR.Devolver_monto_credito()))
                                        CR.SaldoCuotas = Math.Floor((CDec(CR.Ahorrado) / CDec(CR.MontoAbono)))
                                        CR.CuotasAhorradas = Math.Floor(CDec(dgv_agregar_cobro.CurrentRow.Cells(5).Value.ToString()) - (CDec(CR.Ahorrado) / CDec(CR.MontoAbono)))
                                        Mensaje = CR.Aceptar_Cobros()
                                        If (Mensaje = "Abono Registrado correctamente") Then
                                            CR.Actualizar_Cobro()
                                            Listar_Cobros()
                                        End If
                                        clsMensaje.mostrar_mensaje(Mensaje, "ok")
                                        Limpiar_controles()
                                    Else
                                        clsMensaje.mostrar_mensaje("el monto del abono supera el monto actual", "error")
                                    End If
                                    CR.CodigoContrato = 0
                                Catch ex As Exception
                                    clsMensaje.mostrar_mensaje(ex.Message, "error")
                                End Try
                            End If
                        End If
                    End If
                End If

            End If
        Catch ex As Exception
            clsMensaje.mostrar_mensaje(ex.Message, "error")
        End Try
    End Sub

    Private Sub dgv_agregar_cobro_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_agregar_cobro.CellContentDoubleClick

    End Sub

    Private Sub dgv_cobros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cobros.CellContentClick

    End Sub

    Private Sub dgv_cobros_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cobros.CellContentDoubleClick
        If e.RowIndex = -1 Then
            Return
        End If

        ''Obtenemos el row en el cual se hizo doble Click
        Dim row As DataGridViewRow = dgv_cobros.Rows(e.RowIndex)

        'Instanciamos la clase ECliente para cargar los datos tomandolos de las celdas del row
        'Recuerde convertir al tipo de dato correcto
        'Convert.ToInt32(row.Cells("Codigo").Value)

        CR.CodigoContrato = row.Cells(0).Value.ToString()
        Listar_Cobros_por_cliente()
        CR.CodigoContrato = 0
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Listar_Cobros()
    End Sub

    Private Sub SeleccionarCobros_CheckedChanged(sender As Object, e As EventArgs) Handles SeleccionarCobros.CheckedChanged
        If (SeleccionarCobros.Checked) Then
            'Necessary to end the edit mode of the Cell.
            dgv_agregar_cobro.EndEdit()

            'Loop and check and uncheck all row CheckBoxes based on Header Cell CheckBox.
            For Each row As DataGridViewRow In dgv_agregar_cobro.Rows
                Dim checkBox As DataGridViewCheckBoxCell = (TryCast(row.Cells("Escogers"), DataGridViewCheckBoxCell))
                checkBox.Value = True
            Next
        Else
            dgv_agregar_cobro.EndEdit()

            'Loop and check and uncheck all row CheckBoxes based on Header Cell CheckBox.
            For Each row As DataGridViewRow In dgv_agregar_cobro.Rows
                Dim checkBox As DataGridViewCheckBoxCell = (TryCast(row.Cells("Escogers"), DataGridViewCheckBoxCell))
                checkBox.Value = False
            Next
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim frm As New frm_recibo()
        'Usamos las propiedades publicas del formulario, aqui es donde enviamos el valor
        'que se mostrara en los parametros creados en el LocalReport, para este ejemplo
        'estamos Seteando los valores directamente pero usted puede usar algun control


        'Usamos el metod Add porque Invoice es una lista e invoice es una entidad simple
        frm.Titulo = "Recibo de pago"
        frm.Empresa = "Funeraria Alfa & Omega"
        frm.Direccion = "Enfrente Megasuper - Corredores Ciudad Neily"
        frm.Telefonos = "Teléfono: 27833753 / Celular: 87077545 "

        'Enviamos el detalle de la Factura, como Detail es una lista e invoide.Details tambien
        'es un lista del tipo EArticulo bastara con igualarla

        frm.ShowDialog()
    End Sub

    Private Sub dgv_lista_creditos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_lista_creditos.CellContentClick
        Try

            'If (Me.dgv_creditos.Columns(e.ColumnIndex).Name.Equals("Opción")) Then
            '    Dim frm As Frm009iiii_Listado_abonos_Ventas = New Frm009iiii_Listado_abonos_Ventas
            '    frm.V.CodigoVentass = dgv_creditos.CurrentRow.Cells(0).Value.ToString()
            '    frm.Show()
            'Else

            CR.CodigoContrato = dgv_lista_creditos.CurrentRow.Cells(0).Value.ToString()
            Listar_Creditos_cliente()
            CR.CodigoContrato = 0
            'End If
        Catch ex As Exception
            clsMensaje.mostrar_mensaje(ex.Message, "error")
        End Try
    End Sub

    Private Sub Listar_Creditos_cliente()
        Llenar_Grilla_creditos(CR.Listar_Creditos_por_cliente(), dgv_creditos_cliente)
    End Sub
    Private Sub Llenar_Grilla_creditos(ByVal dt As DataTable, ByVal dgv As DataGridView)
        Try
            dgv.Rows.Clear()

            For i = 0 To dt.Rows.Count - 1
                dgv.Rows.Add(dt.Rows(i)(0))
                dgv.Rows(i).Cells(0).Value = CInt(dt.Rows(i)(0).ToString())
                dgv.Rows(i).Cells(1).Value = dt.Rows(i)(1).ToString()
                dgv.Rows(i).Cells(2).Value = dt.Rows(i)(2).ToString()
                dgv.Rows(i).Cells(3).Value = dt.Rows(i)(3).ToString()
                dgv.Rows(i).Cells(4).Value = CDate(dt.Rows(i)(4).ToString()).ToString("MMMM yyyy")
                dgv.Rows(i).Cells(5).Value = dt.Rows(i)(5).ToString()
                dgv.Rows(i).Cells(6).Value = dt.Rows(i)(6).ToString()
                dgv.Rows(i).Cells(7).Value = dt.Rows(i)(7).ToString()
                dgv.Rows(i).Cells(8).Value = dt.Rows(i)(8).ToString()
                dgv.Rows(i).Cells(9).Value = dt.Rows(i)(9).ToString()

                dgv.Rows(i).Cells(10).Value = dt.Rows(i)(10).ToString()
                dgv.Rows(i).Cells(11).Value = dt.Rows(i)(11).ToString()
                dgv.Rows(i).Cells(12).Value = dt.Rows(i)(12).ToString()
                dgv.Rows(i).Cells(13).Value = dt.Rows(i)(13).ToString()
                dgv.Rows(i).Cells(14).Value = "Generar Recibo"

                'CDec(dt.Rows(i)(3).ToString())




            Next
            asignar_color_boton_generar()
            dgv.ClearSelection()

        Catch ex As Exception
            clsMensaje.mostrar_mensaje(ex.Message, "error")
        End Try

    End Sub

    Private Sub dgv_agregar_cobro_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_agregar_cobro.CellClick

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim detalles As New List(Of ERecibos)()
        Dim seleccionar As Boolean = False
        For Each row As DataGridViewRow In dgv_agregar_cobro.Rows
            If Not row.Cells("Escogers").Value Is Nothing Then
                If row.Cells("Escogers").Value.ToString() = "True" Then
                    seleccionar = True

                    Dim article As New ERecibos()
                    If CDec(row.Cells(19).Value.ToString) = 10 Then

                        'Vamos tomando los valores de las celdas del row que estamos 
                        'recorriendo actualmente y asignamos su valor a la propiedad de la clase intanciada
                        CR.CodigoContrato = row.Cells(15).Value
                        article.codigocontrato = row.Cells(15).Value
                        article.CodigoCarga = row.Cells(0).Value
                        article.Contrato = CStr(row.Cells(3).Value)
                        article.Nombre = CStr(row.Cells(2).Value)
                        article.Periodo = devoverperiodo(CR.Periodos_Recibos())
                        article.Direcion = row.Cells(16).Value
                        article.Contratado = row.Cells(5).Value
                        article.Ahorrado = CDec(CR.Devolver_monto_credito()) + CDec(row.Cells(7).Value)
                        If (CR.Devolver_tipo_contrato() = "Alfa") Then
                            article.tipocontrato = "Alfa"
                        End If

                        article.SaldoCtas = Math.Floor(CDec(row.Cells(6).Value.ToString()) - (CDec(article.Ahorrado) / CDec(row.Cells(7).Value.ToString())))

                        article.FechaImpresion = Date.Now.ToString("dd-MM-yyyy")
                        CR.CodigoCobros = row.Cells(0).Value
                        article.NRecibo = CR.Obtener_Serie()
                        article.MtoCtas = row.Cells(7).Value
                        article.CTASAhorradas = Math.Floor((CDec(article.Ahorrado) / CDec(row.Cells(7).Value)))
                        article.Telefono = row.Cells(17).Value
                        article.Zona = row.Cells(8).Value.ToString.Substring(0, 2)
                        article.Cobrar = CStr(row.Cells(10).Value)
                        article.Logo = GetBytes(generarcodigo(article.NRecibo))
                    Else
                        CR.CodigoContrato = row.Cells(15).Value
                        article.codigocontrato = row.Cells(15).Value
                        article.CodigoCarga = row.Cells(0).Value
                        article.Contrato = CStr(row.Cells(3).Value)
                        article.Nombre = CStr(row.Cells(2).Value)
                        article.Periodo = row.Cells(22).Value
                        article.Direcion = row.Cells(16).Value
                        article.Contratado = row.Cells(5).Value
                        article.Ahorrado = row.Cells(19).Value
                        If (CR.Devolver_tipo_contrato() = "Alfa") Then
                            article.tipocontrato = "Alfa"
                        End If

                        article.SaldoCtas = row.Cells(20).Value
                        article.FechaImpresion = Date.Now.ToString("dd-MM-yyyy")
                        CR.CodigoCobros = row.Cells(0).Value
                        article.NRecibo = CR.Obtener_Serie()
                        article.MtoCtas = row.Cells(7).Value
                        article.CTASAhorradas = row.Cells(21).Value
                        article.Telefono = row.Cells(17).Value
                        article.Zona = row.Cells(8).Value.ToString.Substring(0, 2)
                        article.Cobrar = CStr(row.Cells(10).Value)
                        article.Logo = GetBytes(generarcodigo(article.NRecibo))
                    End If

                    'Vamos agregando el Item a la lista del detalle
                    detalles.Add(article)
                    'U.CodigoPersona = CStr(Codigo_Personal_Online)
                    'U.Accion = "Se imprimio el : " + article.NRecibo + " con contrato: " + article.Contrato
                    'U.fechas = DateTime.Now
                    'U.Registra_Acciones()
                    'CR.fechaimpreso = CDate(DateTime.Now)
                    'CR.codigocobroimpreso = row.Cells(0).Value
                    'CR.Registrar_impresiones()
                    'CR.CodigoContrato = 0
                End If


            End If
        Next
        If (seleccionar = False) Then
            MsgBox("No hay Cobros seleccionados")
        Else

            Dim frm As New Frm_recibos1()
            frm.Detail = detalles
            frm.ShowDialog()
        End If
    End Sub

    Public Sub generarrecibo()
        Dim detalles As New List(Of ERecibos)()

        For Each row As DataGridViewRow In dgv_agregar_cobro.Rows

            Dim article As New ERecibos()
            'Vamos tomando los valores de las celdas del row que estamos 
            'recorriendo actualmente y asignamos su valor a la propiedad de la clase intanciada

            article.Contrato = CStr(txt_numero_C.Text)
            article.Nombre = CStr(txt_Cliente.Text)
            article.Periodo = CDate(DateTime.Now).ToString("MMMM yyyy")
            article.Direcion = txt_direccion.Text
            article.Contratado = txt_monto_contrato.Text
            CR.CodigoContrato = row.Cells(14).Value
            article.Ahorrado = CDec(txt_monto_contrato.Text) - CDec(CR.Devolver_monto_credito())
            article.CTASAhorradas = txt_cuotas_ahorradas.Text
            article.FechaImpresion = Date.Now.ToString("dd-MM-yyyy")
            article.NRecibo = txt_recibo.Text
            article.MtoCtas = tb_monto_abono.Text
            article.SaldoCtas = txt_saldo_cuotas.Text
            'article.Telefono = row.Cells(16).Value
            'article.Zona = row.Cells(17).Value.ToString.Substring(0, 2)
            'Vamos agregando el Item a la lista del detalle
            detalles.Add(article)

        Next


        Dim frm As New Frm_recibos1()

        frm.Detail = detalles
        frm.ShowDialog()
        CR.CodigoContrato = 0
    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles txt_cobros_busqueda.TextChanged
        If (txt_cobros_busqueda.Text.Trim() <> "") Then
            Try
                C.dato = CStr(txt_cobros_busqueda.Text)
                Llenar_Grilla_cobros(C.Buscar_Contratos_Cobros())
            Catch ex As Exception
                clsMensaje.mostrar_mensaje(ex.Message, "error")
            End Try
        Else

            Listar_contratos_Cobros()
        End If
    End Sub

    Private Sub dgv_creditos_cliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_creditos_cliente.CellContentClick

        If (Me.dgv_creditos_cliente.Columns(e.ColumnIndex).Name.Equals("opciones")) Then
            Dim detalles As New List(Of ERecibos)()



            Dim article As New ERecibos()
            'Vamos tomando los valores de las celdas del row que estamos 
            'recorriendo actualmente y asignamos su valor a la propiedad de la clase intanciada

            article.Contrato = dgv_creditos_cliente.CurrentRow.Cells(1).Value.ToString()
            article.Nombre = dgv_creditos_cliente.CurrentRow.Cells(2).Value.ToString()

            article.Direcion = dgv_creditos_cliente.CurrentRow.Cells(3).Value.ToString()
            article.Periodo = dgv_creditos_cliente.CurrentRow.Cells(4).Value.ToString()
            article.Contratado = dgv_creditos_cliente.CurrentRow.Cells(5).Value.ToString()


            article.CTASAhorradas = dgv_creditos_cliente.CurrentRow.Cells(6).Value.ToString()
            article.FechaImpresion = dgv_creditos_cliente.CurrentRow.Cells(7).Value.ToString()
            article.NRecibo = dgv_creditos_cliente.CurrentRow.Cells(8).Value.ToString()
            article.MtoCtas = dgv_creditos_cliente.CurrentRow.Cells(9).Value.ToString()
            article.SaldoCtas = dgv_creditos_cliente.CurrentRow.Cells(11).Value.ToString()


            article.Ahorrado = CDec(dgv_creditos_cliente.CurrentRow.Cells(5).Value.ToString()) - CDec(dgv_creditos_cliente.CurrentRow.Cells(10).Value.ToString())
            article.Telefono = dgv_creditos_cliente.CurrentRow.Cells(12).Value.ToString()
            article.Zona = dgv_creditos_cliente.CurrentRow.Cells(13).Value.ToString().Substring(0, 2)
            article.Logo = GetBytes(generarcodigo(article.NRecibo))
            'Vamos agregando el Item a la lista del detalle
            detalles.Add(article)



            Dim frm As New Frm_recibos1()

            frm.Detail = detalles
            frm.ShowDialog()


        End If

    End Sub

    Private Sub cb_zona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_zona.SelectedIndexChanged
        If rb_university.Checked Or rb_alfa.Checked Then
            Try
                C.dato = CStr(cb_zona.SelectedItem)
                Llenar_Grilla_cobros(C.Buscar_Zona())
            Catch ex As Exception
                clsMensaje.mostrar_mensaje(ex.Message, "error")
            End Try
        End If


    End Sub



    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New Frm013_AceptarCobros()
        frm.ShowDialog()
    End Sub
    Function generarcodigo(codigo As String) As Image
        Dim bcode As New Barcode128
        bcode.BarHeight = 50
        bcode.Code = codigo
        bcode.GenerateChecksum = True
        bcode.CodeType = Barcode.CODE128
        Try
            Dim bm As New Bitmap(bcode.CreateDrawingImage(Color.Black, Color.White))
            Dim img As Image
            img = New Bitmap(bm.Width, bm.Height)
            Dim g As Graphics = Graphics.FromImage(img)
            g.FillRectangle(New SolidBrush(Color.White), 0, 0, bm.Width, bm.Height)
            g.DrawImage(bm, 0, 0)
            Return img
        Catch ex As Exception
            MsgBox("no se pudo generar")
        End Try
    End Function
    Private Function GetBytes(ByVal imageIn As Image) As Byte()
        Dim ms As MemoryStream = New MemoryStream()
        imageIn.Save(ms, ImageFormat.Png)
        Return ms.ToArray()
    End Function

    Private Sub lkbCerrar_Click(sender As Object, e As EventArgs) Handles lkbCerrar.Click
        frm_inicio.mincreditos = False
        frm_inicio.pn_principal.Controls.Clear()
        frm_inicio.pn_principal.Hide()
        frm_inicio.min_pn_creditos.BackColor = Color.SteelBlue
        Me.Close()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txt_busqueda.TextChanged
        If (txt_busqueda.Text.Trim() <> "") Then
            Try
                C.dato = CStr(txt_busqueda.Text)
                Llenar_Grilla(C.Buscar_contrato_credito(), dgv_lista_creditos)
            Catch ex As Exception
                clsMensaje.mostrar_mensaje(ex.Message, "error")
            End Try
        Else
            Listar_Contratos()
        End If
    End Sub

    Private Sub TextBox1_TextChanged_2(sender As Object, e As EventArgs) Handles txt_datos_cobros.TextChanged
        If (txt_datos_cobros.Text.Trim() <> "") Then
            Try
                C.dato = CStr(txt_datos_cobros.Text)
                Llenar_Grilla_cobros_asignados(C.Buscar_Carga())
            Catch ex As Exception
                clsMensaje.mostrar_mensaje(ex.Message, "error")
            End Try
        Else

            Listar_Cobros()
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    'Private Sub txtDatos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDatos.KeyPress
    '    If (rb_identificacion.Checked) Then
    '        Validar.Numeros(e)
    '    Else
    '        Validar.Letras(e)
    '    End If
    'End Sub

    'Private Sub rb_identificacion_CheckedChanged(sender As Object, e As EventArgs) Handles rb_identificacion.CheckedChanged
    '    txtDatos.MaxLength = 11
    '    txtDatos.Clear()

    'End Sub

    'Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    '    txtDatos.MaxLength = 256
    '    txtDatos.Clear()

    'End Sub

    'Private Sub txt_busqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_busqueda.KeyPress
    '    If (rb_identificacionlistarcreditos.Checked) Then
    '        Validar.Numeros(e)
    '    Else
    '        Validar.Letras(e)
    '    End If
    'End Sub

    'Private Sub txt_cobros_busqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cobros_busqueda.KeyPress
    '    If (rb_identificarcobros.Checked) Then
    '        Validar.Numeros(e)
    '    Else
    '        Validar.Letras(e)
    '    End If
    'End Sub

    'Private Sub txt_datos_cobros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_datos_cobros.KeyPress
    '    If (rb_button_identificacion.Checked) Then
    '        Validar.Numeros(e)
    '    Else
    '        Validar.Letras(e)
    '    End If
    'End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New Frm013i_ActualizarContratos
        frm.ShowDialog()
    End Sub
    Function MonthDifference(FechaInicio As DateTime, FechaFin As DateTime) As Decimal
        'Console.WriteLine(FechaInicio.ToString() + ":" + FechaFin + ";" + DateDiff("m", FechaInicio, FechaFin).ToString())
        Return DateDiff("m", FechaInicio, FechaFin)

    End Function

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Limpiar_controles()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rb_university.CheckedChanged
        If rb_university.Checked = False Then
            Listar_contratos_Cobros()
        End If
        If rb_university.Checked = True Then
            Try
                C.dato = CStr(cb_zona.SelectedItem)
                C.tipo_contrato = rb_university.Text
                Llenar_Grilla_cobros(C.Buscar_Zona())
            Catch ex As Exception
                clsMensaje.mostrar_mensaje(ex.Message, "error")
            End Try
        End If
    End Sub

    Private Sub rb_alfa_CheckedChanged(sender As Object, e As EventArgs) Handles rb_alfa.CheckedChanged
        If rb_alfa.Checked = False Then
            Listar_contratos_Cobros()
        End If
        If rb_alfa.Checked = True Then
            Try
                C.dato = CStr(cb_zona.SelectedItem)
                C.tipo_contrato = rb_alfa.Text
                Llenar_Grilla_cobros(C.Buscar_Zona())
            Catch ex As Exception
                clsMensaje.mostrar_mensaje(ex.Message, "error")
            End Try
        End If
    End Sub

    Private Sub tb_monto_abono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_monto_abono.KeyPress
        Validar.keypres(e, tb_monto_abono)
    End Sub

    Private Sub tb_monto_abono_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_monto_abono.KeyDown
        Validar.keydowns(e)
    End Sub

    Private Sub tb_monto_abono_MouseLeave(sender As Object, e As EventArgs) Handles tb_monto_abono.MouseLeave
        Validar.strCurrency = ""
        Validar.acceptableKey = False
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles rb_university_cargados.CheckedChanged
        If rb_university_cargados.Checked = False Then
            Listar_Cobros()
        End If
        If rb_university_cargados.Checked = True Then
            Try
                C.dato = CStr(cb_zona_cargados.SelectedItem)
                C.tipo_contrato = rb_university_cargados.Text
                Llenar_Grilla_cobros_asignados(C.Buscar_Zona_Carga())
            Catch ex As Exception
                clsMensaje.mostrar_mensaje(ex.Message, "error")
            End Try
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_zona_cargados.SelectedIndexChanged
        If rb_university_cargados.Checked Then
            Try
                C.dato = CStr(cb_zona_cargados.SelectedItem)
                C.tipo_contrato = rb_university_cargados.Text
                Llenar_Grilla_cobros_asignados(C.Buscar_Zona_Carga())
            Catch ex As Exception
                clsMensaje.mostrar_mensaje(ex.Message, "error")
            End Try

        ElseIf rb_alfa_cargados.Checked Then
            Try
                C.dato = CStr(cb_zona_cargados.SelectedItem)
                C.tipo_contrato = rb_alfa_cargados.Text
                Llenar_Grilla_cobros_asignados(C.Buscar_Zona_Carga())
            Catch ex As Exception
                clsMensaje.mostrar_mensaje(ex.Message, "error")
            End Try
        End If

    End Sub

    Private Sub rb_alfa_cargados_CheckedChanged(sender As Object, e As EventArgs) Handles rb_alfa_cargados.CheckedChanged
        If rb_alfa_cargados.Checked = False Then
            Listar_Cobros()
        End If
        If rb_alfa_cargados.Checked = True Then
            Try
                C.dato = CStr(cb_zona_cargados.SelectedItem)
                C.tipo_contrato = rb_alfa_cargados.Text
                Llenar_Grilla_cobros_asignados(C.Buscar_Zona_Carga())
            Catch ex As Exception
                clsMensaje.mostrar_mensaje(ex.Message, "error")
            End Try
        End If
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub RadioButton3_CheckedChanged_1(sender As Object, e As EventArgs) Handles rb_cargados.CheckedChanged
        If rb_university_cargados.Checked = False Then
            Listar_Cobros()
        End If
        If rb_university_cargados.Checked = True Then
            Try

                Llenar_Grilla_cobros_asignados(C.Devolver_recibos_carga())
            Catch ex As Exception
                clsMensaje.mostrar_mensaje(ex.Message, "error")
            End Try
        End If
    End Sub

    Private Sub TextBox1_TextChanged_3(sender As Object, e As EventArgs) Handles txt_busqueda_I.TextChanged
        If (txt_busqueda_I.Text.Trim() <> "") Then
            Try
                C.Busqueda = CStr(txt_busqueda_I.Text)
                Llenar_Grilla_cobros_impresos(C.Buscar_recibos_impresos())
            Catch ex As Exception
                clsMensaje.mostrar_mensaje(ex.Message, "error")
            End Try
        Else

            Listar_Cobros()
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
    Private Sub txt_dato_recibo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_dato_recibo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If (txt_dato_recibo.Text.Trim() <> "") Then
                Try
                    C.datorecibo = CStr(txt_dato_recibo.Text)
                    Llenar_Grilla_Recibos(C.Buscar_recibos_Creditos())
                Catch ex As Exception
                    clsMensaje.mostrar_mensaje(ex.Message, "error")
                End Try

            End If
        End If
    End Sub

    Private Sub tb_monto_abono_TextChanged(sender As Object, e As EventArgs) Handles tb_monto_abono.TextChanged

    End Sub

    Private Sub Rb_provicionales_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_provicionales.CheckedChanged
        If rb_university_cargados.Checked = False Then
            Listar_Cobros()
        End If
        If rb_university_cargados.Checked = True Then
            Try

                Llenar_Grilla_cobros_asignados(C.Devolver_recibos_provicionales())
            Catch ex As Exception
                clsMensaje.mostrar_mensaje(ex.Message, "error")
            End Try
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim frm As New Frm013i_actualizarfecha_recibos()
        frm.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If rb_university_reporte.Checked = True Then
            Dim reporte As New Reporte_de_recibos_Recaudados_University

            reporte.contrato = 0
            reporte.fecha1 = CDate(dtpFechaInicial.Value.Date)
            reporte.fecha2 = CDate(dtpFechaInicial.Value.Date)

            reporte.ShowDialog()

        ElseIf rb_alfa_reporte.Checked = True Then
            Dim reporte As New Reporte_de_recibos_Recaudados_Alfa

            reporte.contrato = 0
            reporte.fecha1 = CDate(dtpFechaInicial.Value.Date)
            reporte.fecha2 = CDate(dtpFechaInicial.Value.Date)

            reporte.ShowDialog()
        End If
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        frm_inicio.mincreditos = True
        frm_inicio.Frm_creditos = Me

        frm_inicio.pn_principal.Controls.Clear()
        frm_inicio.pn_principal.Hide()
        frm_inicio.min_pn_creditos.BackColor = Color.LightSkyBlue
        Me.Hide()
    End Sub

    Private Sub btnMontoAhorrado_Click(sender As Object, e As EventArgs) Handles btnMontoAhorrado.Click
        If (txt_numero_C.Text.Length() > 0) Then
            Dim frm As New Frm_0014_actualizarcontrato()
            frm.txtCodigoContrado.Text = Codigo_contrato
            frm.txt_Contrato.Text = txt_numero_C.Text
            frm.txt_Cliente.Text = txt_Cliente.Text
            frm.txt_direccion.Text = txt_direccion.Text
            frm.txt_periodo.Text = txt_periodo.Text
            frm.txt_monto_contrato.Text = txt_monto_contrato.Text
            frm.txt_cuotas_ahorradas.Text = txt_cuotas_ahorradas.Text
            frm.txt_cuotas_ahorradas.Text = txt_cuotas_ahorradas.Text
            frm.txt_ahorrado.Text = txt_ahorrado.Text
            frm.txt_saldo_cuotas.Text = txt_saldo_cuotas.Text
            frm.txt_monto_abono.Text = tb_monto_abono.Text
            frm.TipoAjuste = "Monto"
            frm.ShowDialog()
        Else
            clsMensaje.mostrar_mensaje("Selecione un contrato", "Error")
        End If
    End Sub

    Private Sub btnCamPeriodo_Click(sender As Object, e As EventArgs) Handles btnCamPeriodo.Click
        If (txt_numero_C.Text.Length() > 0) Then
            Dim frm As New Frm_0014_actualizarcontrato()
            frm.txtCodigoContrado.Text = Codigo_contrato
            frm.txt_Contrato.Text = txt_numero_C.Text
            frm.txt_Cliente.Text = txt_Cliente.Text
            frm.txt_direccion.Text = txt_direccion.Text
            frm.txt_periodo.Text = txt_periodo.Text
            frm.txt_monto_contrato.Text = txt_monto_contrato.Text
            frm.txt_cuotas_ahorradas.Text = txt_cuotas_ahorradas.Text
            frm.txt_cuotas_ahorradas.Text = txt_cuotas_ahorradas.Text
            frm.txt_ahorrado.Text = txt_ahorrado.Text
            frm.txt_saldo_cuotas.Text = txt_saldo_cuotas.Text
            frm.txt_monto_abono.Text = tb_monto_abono.Text
            frm.TipoAjuste = "Periodo"
            frm.ShowDialog()
        Else
            clsMensaje.mostrar_mensaje("Selecione un contrato", "Error")
        End If
    End Sub

    Private Sub btnCorregir_Click(sender As Object, e As EventArgs) Handles btnCorregir.Click
        Dim frm As New Frm_0015_actualizar_Recibo()
        frm.ShowDialog()
    End Sub

    Private Sub txt_dato_recibo_TextChanged(sender As Object, e As EventArgs) Handles txt_dato_recibo.TextChanged

    End Sub

    Private Sub cb_zonas_orden_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_zonas_orden.SelectedIndexChanged

        Try
            C.datoorden = CStr(cb_zonas_orden.SelectedItem)
            Llenar_Grilla_orden(C.Buscar_Zona_orden(), dgv_orden)
            Catch ex As Exception
            clsMensaje.mostrar_mensaje(ex.Message, "error")
        End Try



    End Sub

    Private Sub txt_busqueda_orden_TextChanged(sender As Object, e As EventArgs) Handles txt_busqueda_orden.TextChanged
        If (txt_busqueda_orden.Text.Trim() <> "") Then
            Try
                C.datoorden = CStr(txt_busqueda_orden.Text)
                Llenar_Grilla_orden(C.Buscar_Contratos_orden(), dgv_orden)
            Catch ex As Exception
                clsMensaje.mostrar_mensaje(ex.Message, "error")
            End Try
        Else

            Listar_orden()
        End If
    End Sub

    Private Sub dgv_orden_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_orden.CellContentClick
        C.CodigoContrato = dgv_orden.CurrentRow.Cells(0).Value.ToString()
        txt_contrato_orden.Text = dgv_orden.CurrentRow.Cells(3).Value.ToString()
        txt_nombre_zona.Text = dgv_orden.CurrentRow.Cells(1).Value.ToString()
        txt_zona_orden.Text = dgv_orden.CurrentRow.Cells(4).Value.ToString()
        txt_direccion_orden.Text = dgv_orden.CurrentRow.Cells(2).Value.ToString()
    End Sub

    Private Sub btn_asignar_numero_Click(sender As Object, e As EventArgs) Handles btn_asignar_numero.Click
        Try
            If (txt_numero.Text.Trim() = "") Then
                C.Numeroorden = txt_numero.Text
                C.Registrar_orden()
            End If
        Catch ex As Exception
            clsMensaje.mostrar_mensaje(ex.Message, "error")
        End Try
        C.CodigoContrato = 0
        txt_contrato_orden.Text = ""
        txt_nombre_zona.Text = ""
        txt_zona_orden.Text = ""
        txt_direccion_orden.Text = ""
    End Sub

    Private Sub txt_numero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_numero.KeyPress
        Validar.Numeros(e)
    End Sub
End Class

