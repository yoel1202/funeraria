﻿Imports System.IO
Imports System.Xml
Imports CapaLogicaNegocio 'Importamos la capa lógica de negocio

Public Class Frm008_Compras

    Implements IProveedor

    Dim C As New clsCompras
    Public frm_inicio As Frm_menu = New Frm_menu
    Private Shared ReadOnly Proveedor As New List(Of EProveedor)()
    Private Shared ReadOnly Producto As New List(Of EProducto)()
    Public Property Caller() As IProveedor
    Dim CodigoProveedor As Integer = 0
    Dim CodigoProducto As Integer = 0
    Dim CodigoCompra As Integer = 0
    Dim selecionar_credito = False
    Dim Tipo_Dato As Integer = 0 'Variable para verificar si el texto Ingresado es Letra o Número (0=Letras | 1=Números)
    Dim U As New clsUsuario 'Instanciamos la clase clsUsuario de la Capa Logica de Negocio para usar sus funciones

    Private Sub lkbBuscar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lkbBuscar.LinkClicked
        'Instanciamos el FrmPersonalPrincipal
        Dim frm As New ListadoProveedor()
        'Le indicamos quien lo mando a llamar usando la Propiedad Caller
        frm.Caller = Me
        'Mostramos el FrmPersonalPrincipal
        frm.ShowDialog()
    End Sub

    Private Sub Frm008Compras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblTotal.Text = "0.0"
        lblSubTotal.Text = "0.0"
        lblIgv.Text = "0.0"
        Listar_Compras()
        Listar_Creditos()
        tb_fecha.Text = DateTime.Now
        Me.SetBounds(58, 0, Screen.PrimaryScreen.Bounds.Width - 60, Screen.PrimaryScreen.Bounds.Height - 100)
    End Sub

    Public Function LoadDataRow(ByVal Proveed As EProveedor) As Boolean Implements IProveedor.LoadDataRow
        'Busca si el Cliente ya se encuentra en la lista
        Dim exists As Boolean = Proveedor.Any(Function(x) x.CodigoProveedor.Equals(Proveed.CodigoProveedor))
        'Preguntamos por el resultado de la busqueda del Cliente dentro de la lista
        If Not exists Then
            CodigoProveedor = Proveed.CodigoProveedor
            txtProveedor.Text = Proveed.Datos
            'Retornamos True
            Return True
        End If
        'Si la condicion exists es igual a False, es decir, que el Cliente SI existe en la lista
        'retornamos FALSE para mostrar un mensajde informacion
        Return False
    End Function

    Public Function LoadDataRow1(ByVal Product As EProducto) As Boolean Implements IProveedor.LoadDataRow1
        'Busca si el Cliente ya se encuentra en la lista
        Dim exists As Boolean = Producto.Any(Function(x) x.CodigoProducto.Equals(Product.CodigoProducto))
        'Preguntamos por el resultado de la busqueda del Producto dentro de la lista
        If Not exists Then
            CodigoProducto = Convert.ToInt32(Product.CodigoProducto)
            txtProducto.Text = Convert.ToString(Product.NombreProducto)

            'Retornamos True
            Return True
        End If
        'Si la condicion exists es igual a False, es decir, que el Cliente SI existe en la lista
        'retornamos FALSE para mostrar un mensajde informacion
        Return False
    End Function

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        'Instanciamos el FrmPersonalPrincipal
        Dim frm As New Frm008ii_ListadoProductos()
        'Le indicamos quien lo mando a llamar usando la Propiedad Caller
        frm.Caller = Me
        'Mostramos el FrmPersonalPrincipal
        frm.ShowDialog()
    End Sub

    Private Sub lkbAgregar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lkbAgregar.LinkClicked
        ErrorProvider1.Clear()
        If (txtProducto.Text.Trim = "") Then
            ErrorProvider1.SetError(txtProducto, "Debe Seleccionar un Producto")
        ElseIf (txtPrecioCompra.Text.Trim = "" Or txtPrecioCompra.Text = "0") Then
            ErrorProvider1.SetError(txtPrecioCompra, "Ingrese Correctamente el Precio de Compra del Producto")
        ElseIf (tb_precio_venta.Text.Trim = "" Or txtPrecioCompra.Text = "0") Then
            ErrorProvider1.SetError(tb_precio_venta, "Ingrese Correctamente el Precio de venta del Producto")
        ElseIf (tb_utilidad.Text.Trim = "" Or txtPrecioCompra.Text = "0") Then
            ErrorProvider1.SetError(tb_utilidad, "Ingrese Correctamente el utilidad de Compra del Producto")
        Else
            Dim i As Integer = dgv_compras.Rows.Count
            Dim SubTotal As Decimal = 0
            Dim Igv As Decimal = 0

            Try
                If (verificar(CodigoProducto) = False) Then
                    dgv_compras.Rows.Add()
                    Me.dgv_compras.Rows(i).Cells(0).Value = CodigoProducto
                    Me.dgv_compras.Rows(i).Cells(1).Value = CStr(txtProducto.Text)
                    Me.dgv_compras.Rows(i).Cells(2).Value = CDec(txtPrecioCompra.Text)
                    Me.dgv_compras.Rows(i).Cells(3).Value = CDec(tb_utilidad.Text)
                    Me.dgv_compras.Rows(i).Cells(4).Value = CDec(tb_precio_venta.Text)
                    Me.dgv_compras.Rows(i).Cells(5).Value = CInt(txtCantidad.Value)
                    SubTotal = CDec(tb_precio_venta.Text) * CDec(txtCantidad.Value)
                    Igv = SubTotal * 0.13
                    Me.dgv_compras.Rows(i).Cells(6).Value = Math.Round(Igv, 2)
                    Me.dgv_compras.Rows(i).Cells(7).Value = Math.Round(SubTotal, 2)
                    Me.dgv_compras.Rows(i).Cells(8).Value = Math.Round(CDec(SubTotal + Igv), 2)
                    Me.dgv_compras.Rows(i).Cells(9).Value = "Eliminar"

                    Me.dgv_compras.ClearSelection()
                    Call asignar_color_boton()
                    lblTotal.Text = CalcularTotal()
                    lblIgv.Text = CalcularIgv()
                    lblSubTotal.Text = CalcularSubTotal()
                    Limpiar_controles_agregar()
                Else
                    clsMensaje.mostrar_mensaje("El producto ya existe en la lista", "error")
                End If
            Catch ex As Exception
                clsMensaje.mostrar_mensaje(ex.Message, "error")
            End Try
        End If
    End Sub

    Private Sub asignar_color_boton()
        For Each row As DataGridViewRow In dgv_compras.Rows
            Dim button1 As DataGridViewButtonCell = CType(row.Cells(9), DataGridViewButtonCell)
            button1.Style.BackColor = Color.FromArgb(217, 83, 79)
            button1.Style.ForeColor = Color.White
            button1.Style.Font = New Font("Arial", 9, FontStyle.Bold)
        Next
    End Sub
    Private Sub asignar_color_botoncredito()
        For Each row As DataGridViewRow In dgv_creditos.Rows
            Dim button1 As DataGridViewButtonCell = CType(row.Cells(8), DataGridViewButtonCell)
            button1.Style.BackColor = Color.FromArgb(92, 184, 92)
            button1.Style.ForeColor = Color.White
            button1.Style.Font = New Font("Arial", 9, FontStyle.Bold)
        Next
    End Sub

    Private Function verificar(ByVal CodigoProducto As Integer) As Boolean
        For i = 0 To dgv_compras.RowCount - 1
            If (dgv_compras.Rows(i).Cells(0).Value = CodigoProducto) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Function CalcularTotal() As Decimal
        Dim Total As Decimal = 0
        For i = 0 To dgv_compras.RowCount - 1
            Total += CDec(dgv_compras.Rows(i).Cells(8).Value)
        Next
        Return Total
    End Function

    Private Function CalcularIgv() As Decimal
        Dim igv As Decimal = 0
        For i = 0 To dgv_compras.RowCount - 1
            igv += ((CDec(dgv_compras.Rows(i).Cells(4).Value) * CInt(dgv_compras.Rows(i).Cells(5).Value)) * 0.13)
        Next
        Return Math.Round(igv, 2)
    End Function

    Private Function CalcularSubTotal() As Decimal
        Dim SubTotal As Decimal = 0
        For i = 0 To dgv_compras.RowCount - 1
            SubTotal += (CDec(dgv_compras.Rows(i).Cells(4).Value) * CInt(dgv_compras.Rows(i).Cells(5).Value))
        Next
        Return Math.Round(SubTotal, 2)
    End Function

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_compras.CellContentClick
        Try
            If (Me.dgv_compras.Columns(e.ColumnIndex).Name.Equals("Eliminar")) Then
                Dim Total As Double = 0
                Dim i As Integer = dgv_compras.CurrentRow.Index
                dgv_compras.Rows.RemoveAt(i)
                lblTotal.Text = CalcularTotal()
                lblIgv.Text = CalcularIgv()
                lblSubTotal.Text = CalcularSubTotal()
            End If
        Catch ex As Exception
            clsMensaje.mostrar_mensaje(ex.Message, "error")
        End Try
    End Sub

    Private Sub Limpiar_controles_agregar()
        txtProducto.Clear()
        txtCantidad.Value = 1
        txtPrecioCompra.Clear()
        tb_utilidad.Clear()
        tb_precio_venta.Clear()
        txtProducto.Focus()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        U.CodigoPersona = CStr(Codigo_Personal_Online)
        U.tipo = "personal"
        Dim permiso As String = U.Devolver_permisos()

        If (permiso = "Todos") Then
            ErrorProvider1.Clear()

            If (txtProveedor.Text.Trim() = "") Then
                ErrorProvider1.SetError(txtProveedor, "Debe Seleccionar un Proveedor")
            ElseIf (txtSerie.Text.Trim() = "") Then
                ErrorProvider1.SetError(txtSerie, "Debe Ingresar Número de Serie del Comprobante")
            ElseIf (txtNroDocumento.Text.Trim() = "") Then
                ErrorProvider1.SetError(txtNroDocumento, "Debe Ingresar Número de Comprobante")
                'ElseIf (ckb_gasto.Checked Or ckb_reventa.Checked) Then
                '    ErrorProvider1.SetError(ckb_gasto, "Debe Ingresar Número de Comprobante")
                'ElseIf (rbnFactura.Checked Or rbnBoleta.Checked) Then
                '    ErrorProvider1.SetError(rbnFactura, "Debe Ingresar Número de Comprobante")
            ElseIf (dgv_compras.Rows.Count < 1) Then
                clsMensaje.mostrar_mensaje("No hay ningún Ítem agregado al carrito de Compra", "error")
            Else
                Dim Mensaje As String = ""
                Try
                    C.CodigoProveedor = CInt(CodigoProveedor)
                    C.FechaCompra = CDate(dtpFecha.Value)
                    C.TipoDocumento = If(rbnBoleta.Checked = True, "Boleta", "Factura")
                    C.Tipocompra = If(ckb_gasto.Checked = True, "Gasto", "Reventa")
                    C.TipoPago = If(chk_Credito.Checked = True, "Credito", "Contado")
                    C.Serie = CStr(txtSerie.Text)
                    C.NroDocumento = CStr(txtNroDocumento.Text)
                    C.Total = CDec(lblTotal.Text)
                    C.plazo = tb_plazo.Text
                    C.cuota = tb_cuota.Text
                    Mensaje = C.Registrar_Compras()

                    If (Mensaje = "Compra Registrada correctamente") Then

                        For i = 0 To dgv_compras.RowCount - 1
                            C.CodigoCompras = CInt(C.Devolver_Codigo_Compras())
                            C.CodigoItem = CInt(dgv_compras.Rows(i).Cells(0).Value)
                            C.PrecioCompra = CDec(dgv_compras.Rows(i).Cells(2).Value)
                            C.utilidad = CDec(dgv_compras.Rows(i).Cells(3).Value)
                            C.Precioventa = CDec(dgv_compras.Rows(i).Cells(4).Value)

                            C.Cantidad = CInt(dgv_compras.Rows(i).Cells(5).Value)
                            C.Igv = CDec(dgv_compras.Rows(i).Cells(6).Value)
                            C.SubTotal = CDec(dgv_compras.Rows(i).Cells(7).Value)
                            C.Registrar_Detalle_Compras()
                        Next
                        U.CodigoPersona = CStr(Codigo_Personal_Online)
                        U.Accion = "Registrado una compra  : " + C.TipoDocumento.ToString() + " serie: " + C.Serie.ToString() + " precio venta: " + C.Precioventa.ToString()
                        U.fechas = DateTime.Now
                        U.Registra_Acciones()
                        clsMensaje.mostrar_mensaje(Mensaje, "ok")
                        Limpiar_Controles()
                    Else
                        clsMensaje.mostrar_mensaje(Mensaje, "error")
                    End If
                Catch ex As Exception
                    clsMensaje.mostrar_mensaje(ex.Message, "error")
                End Try
            End If
        Else
            clsMensaje.mostrar_mensaje("no  tiene permisos para esta Opción", "error")
        End If
    End Sub

    Private Sub Limpiar_Controles()
        CodigoProveedor = 0
        CodigoProducto = 0
        txtProveedor.Clear()
        dtpFecha.Value = Now
        rbnBoleta.Checked = True
        txtProducto.Clear()
        txtCantidad.Value = 1
        txtPrecioCompra.Clear()
        txtSerie.Clear()
        txtNroDocumento.Clear()
        dgv_compras.Rows.Clear()
        lblIgv.Text = "0.0"
        lblSubTotal.Text = "0.0"
        lblTotal.Text = "0.0"
    End Sub

    Private Sub Listar_Compras()
        Llenar_Grilla(C.Listar_Compras())
    End Sub
    Private Sub Listar_Creditos()
        Llenar_Grilla_credito(C.Listar_creditos())
    End Sub
    Private Sub Llenar_Grilla(ByVal dt As DataTable)
        Try
            dtgvListadoCompras.Rows.Clear()

            For i = 0 To dt.Rows.Count - 1
                dtgvListadoCompras.Rows.Add(dt.Rows(i)(0))
                dtgvListadoCompras.Rows(i).Cells(0).Value = dt.Rows(i)(0).ToString()
                dtgvListadoCompras.Rows(i).Cells(1).Value = dt.Rows(i)(1).ToString()
                dtgvListadoCompras.Rows(i).Cells(2).Value = dt.Rows(i)(2).ToString()
                dtgvListadoCompras.Rows(i).Cells(3).Value = dt.Rows(i)(3).ToString()
                dtgvListadoCompras.Rows(i).Cells(4).Value = Format(dt.Rows(i)(4), "dd/MM/yyyy")
                dtgvListadoCompras.Rows(i).Cells(5).Value = Math.Round(dt.Rows(i)(5), 2)


                Me.dgv_compras.ClearSelection()
            Next
            Me.dgv_compras.ClearSelection()
        Catch ex As Exception
            clsMensaje.mostrar_mensaje(ex.Message, "error")
        End Try
    End Sub
    Private Sub Llenar_Grilla_credito(ByVal dt As DataTable)
        Try
            dgv_creditos.Rows.Clear()

            For i = 0 To dt.Rows.Count - 1
                dgv_creditos.Rows.Add(dt.Rows(i)(0))
                dgv_creditos.Rows(i).Cells(0).Value = dt.Rows(i)(0).ToString()
                dgv_creditos.Rows(i).Cells(1).Value = dt.Rows(i)(1).ToString()
                dgv_creditos.Rows(i).Cells(2).Value = dt.Rows(i)(2).ToString()
                dgv_creditos.Rows(i).Cells(3).Value = dt.Rows(i)(3).ToString()
                dgv_creditos.Rows(i).Cells(4).Value = Format(dt.Rows(i)(4), "dd/MM/yyyy")
                dgv_creditos.Rows(i).Cells(5).Value = Math.Round(dt.Rows(i)(5), 2)
                dgv_creditos.Rows(i).Cells(6).Value = dt.Rows(i)(6).ToString()
                dgv_creditos.Rows(i).Cells(7).Value = dt.Rows(i)(7).ToString()
                dgv_creditos.Rows(i).Cells(8).Value = "Ver Abonos"

            Next
            Me.dgv_compras.ClearSelection()
            Call asignar_color_botoncredito()
        Catch ex As Exception
            clsMensaje.mostrar_mensaje(ex.Message, "error")
        End Try
    End Sub
    Private Sub dtgvListadoCompras_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgvListadoCompras.CellClick
        If (dtgvListadoCompras.Rows.Count > 0) Then
            dtgvListadoCompras.Rows(dtgvListadoCompras.CurrentRow.Index).Selected = True
            Listar_Detalle_Compras()
        End If
    End Sub
    Private Sub Listar_Detalle_Compras()
        C.CodigoCompras = CInt(Me.dtgvListadoCompras.CurrentRow.Cells(0).Value)
        Llenar_Grilla_Detalle(C.Listar_Detalle_Compras())
    End Sub

    Private Sub Llenar_Grilla_Detalle(ByVal dt As DataTable)
        Dim Total As Decimal = 0
        Dim SubTotal As Decimal = 0
        Dim Igv As Decimal = 0

        Try
            Me.dtgvListadoDetalle.Rows.Clear()
            For i = 0 To dt.Rows.Count - 1
                dtgvListadoDetalle.Rows.Add(dt.Rows(i)(0))
                dtgvListadoDetalle.Rows(i).Cells(0).Value = dt.Rows(i)(0).ToString()
                dtgvListadoDetalle.Rows(i).Cells(1).Value = dt.Rows(i)(1).ToString()
                dtgvListadoDetalle.Rows(i).Cells(2).Value = dt.Rows(i)(2).ToString()
                dtgvListadoDetalle.Rows(i).Cells(3).Value = Math.Round(dt.Rows(i)(3), 2)
                dtgvListadoDetalle.Rows(i).Cells(4).Value = dt.Rows(i)(4).ToString()
                dtgvListadoDetalle.Rows(i).Cells(5).Value = Math.Round(dt.Rows(i)(5), 2)
                dtgvListadoDetalle.Rows(i).Cells(6).Value = Math.Round(dt.Rows(i)(6), 2)
                dtgvListadoDetalle.Rows(i).Cells(7).Value = Math.Round(dt.Rows(i)(7), 2)
                Total += dt.Rows(i)(7)
            Next
            Me.dtgvListadoDetalle.ClearSelection()
            lblTotal2.Text = Math.Round(Total, 2)
            SubTotal = Total / 1.18
            lblSubTotal2.Text = Math.Round(SubTotal, 2)
            Igv = SubTotal * 0.18
            lblIgv2.Text = Math.Round(Igv, 2)
        Catch ex As Exception
            clsMensaje.mostrar_mensaje(ex.Message, "error")
        End Try
    End Sub

    Private Sub Frm008_Compras_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Frm00_Login.FormActive = 1
    End Sub

    Private Sub Frm008_Compras_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Frm00_Login.FormActive = 0
        Validar.Cerrar_form = 0
    End Sub

    Private Sub lkbCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkbCerrar.Click
        frm_inicio.mincompras = False
        frm_inicio.pn_principal.Controls.Clear()
        frm_inicio.pn_principal.Hide()
        frm_inicio.min_pn_compras.BackColor = Color.SteelBlue
        Me.Close()
    End Sub

    Private Sub ckbConsultar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbConsultar.CheckedChanged
        If (ckbConsultar.Checked = True) Then
            dtpFechaInicial.Enabled = True
            dtpFechaFinal.Enabled = True
            btnConsultar.Enabled = True
            dtgvListadoCompras.Rows.Clear()
            Me.dtgvListadoDetalle.Rows.Clear()
            lblIgv2.Text = ""
            lblSubTotal2.Text = ""
            lblTotal2.Text = ""
        Else
            dtpFechaInicial.Enabled = False
            dtpFechaFinal.Enabled = False
            btnConsultar.Enabled = False
            Call Listar_Compras()
        End If
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Try
            C.Fecha1 = CDate(dtpFechaInicial.Value)
            C.Fecha2 = CDate(dtpFechaFinal.Value)
            Llenar_Grilla(C.Listar_Compras_porFecha())
        Catch ex As Exception
            clsMensaje.mostrar_mensaje(ex.Message, "error")
        End Try
    End Sub

    Private Sub txtPrecioCompra_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecioCompra.KeyPress
        Validar.Numeros_con_Decimales(e)
    End Sub

    Private Sub txtSerie_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerie.KeyPress
        Validar.Numeros(e)
    End Sub

    Private Sub txtNroDocumento_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroDocumento.KeyPress
        Validar.Numeros(e)
    End Sub

    Private Sub TabControl1_Selected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabControl1.Selected
        If (TabControl1.SelectedTab Is TabPage2) Then
            Call Listar_Compras()
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If (keyData = Keys.Escape) Then
            Cerrar_Form()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub Cerrar_Form()
        If (txtProveedor.Text.Trim = "" And txtProducto.Text.Trim = "" And txtPrecioCompra.Text.Trim = "" And txtSerie.Text.Trim = "" And txtNroDocumento.Text.Trim = "") Then
            Close()
        Else
            Dim fr As New Frm011_MensajedeConfirmación2
            fr.ShowDialog()
            If (Validar.Cerrar_form = 1) Then
                Close()
            End If
        End If
    End Sub

    Private Sub txtPrecioCompra_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioCompra.TextChanged
        If (tb_utilidad.Text <> "" And txtPrecioCompra.Text <> "") Then
            Dim resultado = 0
            resultado = (CDec(txtPrecioCompra.Text) / 100 * CDec(tb_utilidad.Text)) + CDec(txtPrecioCompra.Text)
            tb_precio_venta.Text = resultado.ToString()
        End If
    End Sub

    Private Sub Panel_cabecera_Paint(sender As Object, e As PaintEventArgs) Handles Panel_cabecera.Paint

    End Sub

    Private Sub tb_utilidad_TextChanged(sender As Object, e As EventArgs) Handles tb_utilidad.TextChanged
        If (tb_utilidad.Text <> "" And txtPrecioCompra.Text <> "") Then
            Dim resultado = 0
            resultado = (CDec(txtPrecioCompra.Text) / 100 * CDec(tb_utilidad.Text)) + CDec(txtPrecioCompra.Text)
            tb_precio_venta.Text = resultado.ToString()
        End If
    End Sub

    Private Sub tb_utilidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_utilidad.KeyPress
        Validar.Numeros(e)
    End Sub

    Private Sub tb_precio_venta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_precio_venta.KeyPress
        Validar.Numeros(e)
    End Sub

    Private Sub rb_gasto_CheckedChanged(sender As Object, e As EventArgs)
        tb_utilidad.Text = 0
        tb_utilidad.Enabled = False
        tb_precio_venta.Text = 0
        tb_precio_venta.Enabled = False
    End Sub

    Private Sub rb_reventa_CheckedChanged(sender As Object, e As EventArgs)
        tb_utilidad.Text = ""
        tb_utilidad.Enabled = True
        tb_precio_venta.Text = ""
        tb_precio_venta.Enabled = True
    End Sub

    Private Sub ckb_gasto_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_gasto.CheckedChanged
        ckb_reventa.Checked = False
    End Sub

    Private Sub ckb_reventa_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_reventa.CheckedChanged
        ckb_gasto.Checked = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ofd As OpenFileDialog = New OpenFileDialog()
        ofd.Filter = "XML Files (*.xml)|*.xml"
        ofd.FilterIndex = 0
        ofd.DefaultExt = "xml"

        If ofd.ShowDialog() = DialogResult.OK Then

            If Not String.Equals(Path.GetExtension(ofd.FileName), ".xml", StringComparison.OrdinalIgnoreCase) Then
                MessageBox.Show("The type of the selected file is not supported by this application. You must select an XML file.", "Invalid File Type", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Else
                Dim xmldoc As New XmlDataDocument()
                Dim xmlnode As XmlNodeList
                Dim i As Integer
                Dim str As String
                Dim fs As New FileStream(ofd.FileName, FileMode.Open, FileAccess.Read)
                xmldoc.Load(fs)
                xmlnode = xmldoc.GetElementsByTagName("NumeroConsecutivo")
                For i = 0 To xmlnode.Count - 1
                    xmlnode(i).ChildNodes.Item(0).InnerText.Trim()
                    str = xmlnode(i).ChildNodes.Item(0).InnerText.Trim()
                    MsgBox(str)
                Next
            End If
        End If
    End Sub

    Private Sub chk_contado_CheckedChanged(sender As Object, e As EventArgs) Handles chk_contado.CheckedChanged
        lb_plazo.Hide()
        tb_plazo.Hide()
        lb_cuota.Hide()
        tb_cuota.Hide()
        chk_Credito.Checked = False
        tb_plazo.Text = 0
        tb_cuota.Text = 0
    End Sub

    Private Sub chk_Credito_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Credito.CheckedChanged
        lb_plazo.Show()
        tb_plazo.Show()
        lb_cuota.Show()
        tb_cuota.Show()
        tb_cuota.Clear()
        tb_plazo.Clear()
        chk_contado.Checked = False

    End Sub

    Private Sub tb_plazo_TextChanged(sender As Object, e As EventArgs) Handles tb_plazo.TextChanged

        If (lblTotal.Text.Length > 3 And tb_plazo.Text <> "" And tb_plazo.Text <> "0") Then
            tb_cuota.Text = CDec(lblTotal.Text.Trim()) / CDec(tb_plazo.Text)
        End If

    End Sub

    Private Sub tb_plazo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_plazo.KeyPress
        Validar.Numeros(e)
    End Sub

    Private Sub tb_cuota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_cuota.KeyPress
        Validar.Numeros(e)
    End Sub


    Private Sub tb_Datos_TextChanged(sender As Object, e As EventArgs) Handles txtDatos.TextChanged


        If (txtDatos.Text.Trim() <> "") Then
            Try
                C.datos = txtDatos.Text
                Listar_Creditos()
            Catch ex As Exception
                clsMensaje.mostrar_mensaje(ex.Message, "error")
            End Try
        Else

        End If
    End Sub

    Private Sub lblTotal_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblTotal_TextChanged(sender As Object, e As EventArgs) Handles lblTotal.TextChanged
        If (lblTotal.Text.Length > 3 And tb_plazo.Text <> "" And tb_plazo.Text <> "0") Then
            tb_cuota.Text = CDec(lblTotal.Text) / CDec(tb_plazo.Text)
        End If
    End Sub

    Private Sub dgv_creditos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_creditos.CellContentClick
        Try

            If (Me.dgv_creditos.Columns(e.ColumnIndex).Name.Equals("Opción")) Then
                Dim frm As Frm008iiii_Listado_Abonos_Compras = New Frm008iiii_Listado_Abonos_Compras
                frm.C.CodigoCompras = dgv_creditos.CurrentRow.Cells(0).Value.ToString()
                frm.Show()
            Else

            End If
        Catch ex As Exception
            clsMensaje.mostrar_mensaje(ex.Message, "error")
        End Try


    End Sub

    Private Sub btn_abonar_Click(sender As Object, e As EventArgs) Handles btn_abonar.Click
        U.CodigoPersona = CStr(Codigo_Personal_Online)
        U.tipo = "personal"
        Dim permiso As String = U.Devolver_permisos()

        If (permiso = "Todos") Then
            ErrorProvider1.Clear()

            If (tb_monto_abono.Text.Trim() = "") Then
                ErrorProvider1.SetError(tb_monto_abono, "Debe Ingresar el Monto del Abono")
            ElseIf (tb_monto_actual.Text.Trim() = "") Then
                ErrorProvider1.SetError(tb_monto_actual, "Debe Ingresar monto actual")
            ElseIf (tb_comprobante.Text.Trim() = "") Then
                ErrorProvider1.SetError(tb_comprobante, "Debe Ingresar Número de Comprobante")

            ElseIf (dgv_creditos.Rows.Count < 1) Then
                clsMensaje.mostrar_mensaje("No hay ningún Ítem agregado al carrito de Compra", "error")
            Else
                If (selecionar_credito) Then
                    Dim Mensaje As String = ""
                    Try
                        Dim resultado = 0
                        resultado = CDec(tb_monto_actual.Text) - CDec(tb_monto_abono.Text)
                        If (resultado >= 0) Then
                            C.MontoAbono = tb_monto_abono.Text
                            C.MontoActual = resultado
                            C.FechaAbono = CDate(tb_fecha.Text)
                            C.NComprobante = tb_comprobante.Text
                            Mensaje = C.Registrar_Abono()
                            clsMensaje.mostrar_mensaje(Mensaje, "ok")
                            tb_monto_actual.Text = C.Devolver_monto_credito()
                        Else
                            clsMensaje.mostrar_mensaje("el monto del abono supera el monto actual", "error")
                        End If
                        U.Accion = "Abonado una compra  : " + C.MontoAbono.ToString() + " Monto Actual: " + C.MontoActual.ToString() + " NComprobante: " + C.NComprobante.ToString()
                    Catch ex As Exception
                        clsMensaje.mostrar_mensaje(ex.Message, "error")
                    End Try
                End If

            End If

        End If
    End Sub

    'Private Sub rbnNombre_CheckedChanged(sender As Object, e As EventArgs) Handles rbnNombre.CheckedChanged
    '    Listar_Creditos()
    '    txtDatos.MaxLength = 256
    '    txtDatos.Clear()
    '    Tipo_Dato = 1
    '    txtDatos.Focus()
    'End Sub

    'Private Sub rbnNDoc_CheckedChanged(sender As Object, e As EventArgs)
    '    Listar_Creditos()
    '    txtDatos.MaxLength = 8
    '    txtDatos.Clear()
    '    Tipo_Dato = 0
    '    txtDatos.Focus()
    'End Sub

    'Private Sub txtDatos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDatos.KeyPress
    '    If (Tipo_Dato = 0) Then
    '        Validar.Numeros(e)
    '    Else
    '        Validar.Letras(e)
    '    End If
    'End Sub


    Private Sub dgv_creditos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_creditos.CellClick
        Try
            CodigoCompra = dgv_creditos.CurrentRow.Cells(0).Value.ToString()
            tb_monto_abono.Text = CDec(dgv_creditos.CurrentRow.Cells(5).Value.ToString()) / CDec(dgv_creditos.CurrentRow.Cells(6).Value.ToString())
            lb_total.Text = dgv_creditos.CurrentRow.Cells(5).Value.ToString()
            lb_subtotal.Text = CDec(dgv_creditos.CurrentRow.Cells(5).Value.ToString()) / 1.13
            lb_iva.Text = (CDec(dgv_creditos.CurrentRow.Cells(5).Value.ToString()) / 1.13) * 0.13
            C.CodigoComprass = dgv_creditos.CurrentRow.Cells(0).Value.ToString()
            tb_monto_actual.Text = C.Devolver_monto_credito()
            selecionar_credito = True
        Catch ex As Exception
            clsMensaje.mostrar_mensaje(ex.Message, "error")
        End Try
    End Sub

    Private Sub lb_min_Click(sender As Object, e As EventArgs) Handles lb_min.Click
        frm_inicio.mincompras = True
        frm_inicio.Frm_compras = Me

        frm_inicio.pn_principal.Controls.Clear()
        frm_inicio.pn_principal.Hide()
        frm_inicio.min_pn_compras.BackColor = Color.LightSkyBlue
        Me.Hide()
    End Sub
End Class