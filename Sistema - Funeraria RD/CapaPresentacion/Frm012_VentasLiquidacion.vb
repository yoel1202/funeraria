Imports CapaLogicaNegocio

Public Class Frm012_VentasLiquidacion
    Public C As New clsContratos 'Instanciamos la clase clsUsuario de la Capa Logica de Negocio para usar sus funciones
    Public list As List(Of EDetalleItem)
    Dim V As New clsVentas
    Public monto As Decimal
    Public montototal As Decimal
    Dim SubTotal As Decimal = 0
    Dim Igv As Decimal = 0
    Public cliente As String
    Public Plan As New List(Of EPlanServicio)()
    Private Sub lkbCerrar_Click(sender As Object, e As EventArgs) Handles lkbCerrar.Click
        Close()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If chk_credito.Checked = True Then
            If (txt_plazo.Text.Trim = "") Then
                ErrorProvider1.SetError(txt_plazo, "Ingreso nombre del Cementerio")
            ElseIf (txt_cuota.Text.Trim = "") Then
                ErrorProvider1.SetError(txt_cuota, "Ingreso Dirección del Sepelio")
            End If
        End If
        If (txtCliente.Text.Trim = "") Then
            ErrorProvider1.SetError(txtCliente, "Seleccione Cliente")
        ElseIf (dgvmantenimientos.Rows.Count < 1) Then
            clsMensaje.mostrar_mensaje("No hay ningún Ítem en el Carrito de Ventas", "error")
        Else
            Dim Mensaje As String = ""
            Try
                V.CodigoCliente = CInt(C.Devolver_codigo_cliente_contratos)
                V.TipoDocumento = If(rbnBoleta.Checked = True, "Boleta", "Factura")
                V.Cuotas = CDec(txt_cuota.Text)
                V.Plazo = CDec(txt_plazo.Text)
                V.CondicionVenta = If(chk_contado.Checked = True, "Contado", "Credito")
                V.Total = (txtmontoactual.Text)
                V.FechaVenta = CDate(dtpFecha.Value)
                V.NumeroDocumento = txtNroDocumento.Text
                Mensaje = V.Registrar_Ventas()

                If (Mensaje = "Venta Registrada correctamente") Then
                    'Registramos el detalle de la venta            
                    For i = 0 To lst.Count - 1
                        V.CodigoVenta = CInt(V.Devolver_Codigo_Ventas())
                        V.CodigoItem = CInt(lst(i).CodigoItem)
                        V.Cantidad = CInt(lst(i).Cantidad)
                        V.PrecioVenta = Math.Round(CDec(lst(i).Precio), 2)
                        V.Igv = Math.Round(CDec(lst(i).Igv), 2)
                        V.Descuento = CDec(0)
                        V.SubTotal = Math.Round(CDec(lst(i).SubTotal), 2)
                        V.Registrar_Detalle_Ventas()
                    Next

                    Mensaje = C.Registrar_Liquidacion()
                    If (Mensaje = "Liquidacion Registrada correctamente") Then
                        'Registramos el detalle de la Liquidacion            
                        For i = 0 To lst.Count - 1
                            C.CodigoLiquidacion = CInt(C.Devolver_Codigo_Liquidacion())

                            C.CodigoItem = CInt(lst(i).CodigoItem)

                            C.Cantidad = CInt(lst(i).Cantidad)
                            C.PrecioVenta = Math.Round(CDec(lst(i).Precio), 2)
                            C.IGV = Math.Round(CDec(lst(i).Igv), 2)
                            C.Descuento = CDec(0)
                            C.SubTotal = Math.Round(CDec(lst(i).SubTotal), 2)
                            C.Registrar_Detalle_Liquidacion()
                        Next
                        lst.Clear()
                    End If
                    clsMensaje.mostrar_mensaje(Mensaje, "ok")

                Else
                    clsMensaje.mostrar_mensaje(Mensaje, "error")
                End If
            Catch ex As Exception
                clsMensaje.mostrar_mensaje(ex.Message, "error")
            End Try
        End If
    End Sub
    Private Sub Listar_Productos()
        Try
            dgvmantenimientos.Rows.Clear()
            For i = 0 To Plan.Count - 1
                dgvmantenimientos.Rows.Add()
                Me.dgvmantenimientos.Rows(i).Cells(0).Value = CInt(Plan(i).Codigo)
                Me.dgvmantenimientos.Rows(i).Cells(1).Value = CStr(Plan(i).Descripcion)
                Me.dgvmantenimientos.Rows(i).Cells(2).Value = CDec(Plan(i).Precio)
                Me.dgvmantenimientos.Rows(i).Cells(3).Value = CInt(Plan(i).Cantidad)
                SubTotal = (CDec(Plan(i).Precio) * CInt(Plan(i).Cantidad)) / 1.18
                Igv = SubTotal * 0.18
                Me.dgvmantenimientos.Rows(i).Cells(4).Value = Math.Round(Igv, 2)
                Me.dgvmantenimientos.Rows(i).Cells(5).Value = Math.Round(SubTotal, 2)
                Me.dgvmantenimientos.Rows(i).Cells(6).Value = Math.Round(CDec(SubTotal + Igv), 2)

            Next
            Me.dgvmantenimientos.ClearSelection()

        Catch ex As Exception
            clsMensaje.mostrar_mensaje(ex.Message, "error")
        End Try
    End Sub

    Private Sub Frm012_VentasLiquidacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar_Productos()
        txtmontoactual.Text = monto
        lblTotal.Text = CalcularTotal()
        lblIgv.Text = CalcularIgv()
        lblSubTotal.Text = CalcularSubTotal()
        txtCliente.Text = cliente
    End Sub
    Private Function CalcularTotal() As String
        Dim Total As Decimal = 0
        For i = 0 To dgvmantenimientos.RowCount - 1
            Total += CDec(dgvmantenimientos.Rows(i).Cells(6).Value)
        Next
        Return Total
    End Function

    Private Function CalcularIgv() As String
        Dim igv As Decimal = 0
        For i = 0 To dgvmantenimientos.RowCount - 1
            igv += ((CDec(dgvmantenimientos.Rows(i).Cells(2).Value) * CInt(dgvmantenimientos.Rows(i).Cells(3).Value)) / 1.18) * 0.18
        Next
        Return Math.Round(igv, 2)
    End Function

    Private Function CalcularSubTotal() As String
        Dim SubTotal As Decimal = 0
        For i = 0 To dgvmantenimientos.RowCount - 1
            SubTotal += (CDec(dgvmantenimientos.Rows(i).Cells(2).Value) * CInt(dgvmantenimientos.Rows(i).Cells(3).Value)) / 1.18
        Next
        Return Math.Round(SubTotal, 2)
    End Function

    Private Sub txt_plazo_TextChanged(sender As Object, e As EventArgs) Handles txt_plazo.TextChanged
        If (txtmontoactual.Text.Length > 3 And txt_plazo.Text <> "" And txt_plazo.Text <> "0") Then
            txt_cuota.Text = CDec(txtmontoactual.Text) / CDec(txt_plazo.Text)
        End If
    End Sub

    Private Sub chk_credito_CheckedChanged(sender As Object, e As EventArgs) Handles chk_credito.CheckedChanged
        If (chk_contado.Checked) Then
            chk_contado.Checked = False
        End If
        txt_cuota.Text = ""
        txt_plazo.Text = ""
        txt_cuota.Show()
        txt_plazo.Show()
        lb_plazo.Show()
        lb_cuota.Show()
    End Sub

    Private Sub chk_contado_CheckedChanged(sender As Object, e As EventArgs) Handles chk_contado.CheckedChanged
        If (chk_credito.Checked) Then
            chk_credito.Checked = False
        End If
        txt_cuota.Hide()
        txt_cuota.Text = 0
        txt_plazo.Text = 0
        txt_plazo.Hide()
        lb_plazo.Hide()
        lb_cuota.Hide()
    End Sub

    Private Sub txt_cuota_TextChanged(sender As Object, e As EventArgs) Handles txt_cuota.TextChanged

    End Sub

    Private Sub txtmontoactual_TextChanged(sender As Object, e As EventArgs) Handles txtmontoactual.TextChanged

    End Sub
End Class