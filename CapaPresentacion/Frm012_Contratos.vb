Imports System.IO
Imports CapaLogicaNegocio

Public Class Frm012_Contratos

    Implements ICliente
    Implements IPersonal
    Implements IContratos
    'Implements IItem
    Implements IPlanServicio
    Implements IDifuntos
    Public Plan As New List(Of EPlanServicio)()
    Public frm_inicio As Frm_menu = New Frm_menu
    Dim CR As New ClsCredito

    Dim U As New clsUsuario 'Instanciamos la clase clsUsuario de la Capa Logica de Negocio para usar sus funciones
    Dim C As New clsContratos 'Instanciamos la clase clsUsuario de la Capa Logica de Negocio para usar sus funciones
    Private Shared ReadOnly Cliente As New List(Of ECliente)()
    Private Shared ReadOnly Personal As New List(Of EPersonal)()
    Private Shared ReadOnly Contrato As New List(Of EContratos)()
    Dim Imagenes As New CopiarImagen
    Dim Tipo_Dato As Integer = 0 'Variable para verificar si el texto Ingresado es Letra o Número (0=Letras | 1=Números)
    Dim CodigoCliente As Integer = 0
    Dim DireccionCliente As String = ""
    Dim TipoDocumento As String = ""
    Dim Documento As String = ""
    Dim Codigopersonal As Integer = 0
    Dim nombre As String = ""
    Dim cedula As String = ""
    Dim telefono As String = ""
    Dim CodigoContrato
    Dim valor As Integer = 0
    Dim SubTotal As Decimal = 0
    Dim Igv As Decimal = 0
    Dim paso As Boolean = True
    Dim CodigoContrato2 As Integer
    Dim cambio As Boolean = False
    Dim montoreal As Decimal = 0

    Private Sub lkbBuscar_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lkbBuscar.LinkClicked
        'Instanciamos el FrmPersonalPrincipal
        Dim frm As New Frm005_Cliente()
        frm.Cliente = 1
        'Le indicamos quien lo mando a llamar usando la Propiedad Caller
        frm.Caller1 = Me
        'Mostramos el FrmPersonalPrincipal
        Frm00_Login.FormActive = 2
        frm.ShowDialog()
    End Sub

    Public Function LoadDataRow(ByVal Client As ECliente) As Boolean Implements ICliente.LoadDataRow
        'Busca si el Cliente ya se encuentra en la lista
        Dim exists As Boolean = Cliente.Any(Function(x) x.CodigoCliente.Equals(Client.CodigoCliente))
        'Preguntamos por el resultado de la busqueda del Cliente dentro de la lista
        If Not exists Then
            CodigoCliente = Client.CodigoCliente
            txtCliente.Text = Client.Datos
            DireccionCliente = Client.Direccion
            TipoDocumento = Client.TipoDocumento
            C.CodigoClientes = Client.CodigoCliente
            txtNroDocumento.Text = C.Devolver_n_contratos
            Documento = Client.Documento
            'Retornamos True

            Return True
        End If
        'Si la condicion exists es igual a False, es decir, que el Cliente SI existe en la lista
        'retornamos FALSE para mostrar un mensajde informacion
        Return False
    End Function

    Private Sub txt_monto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_monto.KeyPress
        Validar.Numeros(e)
        Validar.keypres(e, txt_monto)

        If e.KeyChar = ChrW(Keys.Enter) Then
            txtplazo.Focus()


        End If

    End Sub

    Private Sub txtplazo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtplazo.KeyPress
        Validar.Numeros(e)
        If e.KeyChar = ChrW(Keys.Enter) Then
            txt_cuota.Focus()


        End If
    End Sub

    Private Sub txt_cuota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cuota.KeyPress
        Validar.Numeros(e)
        Validar.keypres(e, txt_cuota)
        If e.KeyChar = ChrW(Keys.Enter) Then
            txt_fecha_cobro.Focus()


        End If
    End Sub

    Public Function LoadDataRow(personales As EPersonal) As Boolean Implements IPersonal.LoadDataRow
        'Busca si el Cliente ya se encuentra en la lista
        Dim exists As Boolean = Personal.Any(Function(x) x.CodigoPersonal.Equals(personales.CodigoPersonal))

        'Preguntamos por el resultado de la busqueda del Cliente dentro de la lista
        If Not exists Then
            Codigopersonal = personales.CodigoPersonal
            txt_vendedor.Text = personales.Nombre
            cedula = personales.Cedula
            telefono = personales.Telefono

            'Retornamos True
            Return True
        End If
        'Si la condicion exists es igual a False, es decir, que el Cliente SI existe en la lista
        'retornamos FALSE para mostrar un mensajde informacion
        Return False
    End Function
    Public Function LoadDataRow(Difunto As EDifuntos) As Boolean Implements IDifuntos.LoadDataRow
        ''Busca si el Cliente ya se encuentra en la lista
        'Dim exists As Boolean = Personal.Any(Function(x) x.CodigoPersonal.Equals(Difunto.Codigo_Difunto))

        ''Preguntamos por el resultado de la busqueda del Cliente dentro de la lista
        'If Not exists Then
        '    CodigoDifunto = Difunto.Codigo_Difunto
        '    tb_difunto.Text = Difunto.Nombres + " " + Difunto.Apellidos



        '    'Retornamos True
        '    Return True
        'End If
        ''Si la condicion exists es igual a False, es decir, que el Cliente SI existe en la lista
        ''retornamos FALSE para mostrar un mensajde informacion
        'Return False
    End Function
    Private Sub lk_buscarpersonal_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lk_buscarpersonal.LinkClicked
        'Instanciamos el FrmPersonalPrincipal
        Dim frm As New Frm002_PersonalPrincipal()

        'Le indicamos quien lo mando a llamar usando la Propiedad Caller
        frm.Caller = Me
        'Mostramos el FrmPersonalPrincipal
        Frm00_Login.FormActive = 2
        frm.ShowDialog()
    End Sub

    Private Sub chk_university_CheckedChanged(sender As Object, e As EventArgs) Handles chk_university.CheckedChanged
        If chk_alfa.Checked Then
            chk_alfa.Checked = False
        End If
    End Sub

    Private Sub chk_alfa_CheckedChanged(sender As Object, e As EventArgs) Handles chk_alfa.CheckedChanged
        If chk_university.Checked Then
            chk_university.Checked = False
        End If
    End Sub

    Private Sub pb_contrato_Click(sender As Object, e As EventArgs) Handles pb_contrato.Click
        Dim OpenFile As New OpenFileDialog()
        Try
            If OpenFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
                pb_contrato.ImageLocation = OpenFile.FileName
            Else

            End If
        Catch ex As Exception
            clsMensaje.mostrar_mensaje("Debe elegir una imagen", "error")
        End Try

    End Sub

    Private Sub btnRegistrar_Click_1(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        btnRegistrar.Enabled = False
        U.CodigoPersona = CStr(Codigo_Personal_Online)
        U.tipo = "personal"
        Dim permiso As String = U.Devolver_permisos()

        If (permiso = "Todos") Then
            'Evento para guardar cambios, para registrar y/o actualizar información
            ErrorProvider1.Clear()
            If (txtplazo.Text.Trim = "") Then
                ErrorProvider1.SetError(txtplazo, "Ingrese Nombres")
            ElseIf (txt_cuota.Text.Trim = "") Then
                ErrorProvider1.SetError(txt_cuota, "Ingrese Descripción del Producto")
            ElseIf (txt_cuota.Text.Trim = "") Then
                ErrorProvider1.SetError(txt_cuota, "Debe Seleccionar un Material")
            ElseIf (txtplazo.Text.Trim = "") Then
                ErrorProvider1.SetError(txtplazo, "Debe Seleccionar un Color")

            Else
                Dim Mensaje As String = "" 'Variable para recuperar el mensaje del procedimiento almacenado de la BD
                Dim RutaImgen = ""
                Try 'Manejamos una excepción de errores

                    If valor = 0 Then
                        If cb_reconocimiento.SelectedItem = "No Aplica" Then

                            C.CodigoCliente = CInt(CodigoCliente)
                            Dim NombreFoto As String = "Contrato-" & C.Devolver_Codigo_cliente()

                            If (File.Exists(NombreFoto)) Then

                                File.Delete(NombreFoto)
                            End If
                            RutaImgen = Imagenes.copiarImagen(pb_contrato2.ImageLocation, NombreFoto + "-reverso", "", 1)
                            RutaImgen = Imagenes.copiarImagen(pb_contrato.ImageLocation, NombreFoto, "", 1)

                            C.CodigoCliente = CInt(CodigoCliente)
                            C.CodigoPersonal = CInt(Codigopersonal)
                            C.TipoContrato = If(chk_alfa.Checked = True, "Alfa", "University")
                            C.Monto = Decimal.Parse(txt_monto.Text.Substring(0, txt_monto.Text.Length - 3))
                            C.Plazo = CInt(txtplazo.Text)
                            C.Cuota = Decimal.Parse(txt_cuota.Text.Substring(0, txt_cuota.Text.Length - 3))
                            C.Zona = cb_zona.SelectedItem
                            C.LugarCobro = cb_lugarcobro.SelectedItem
                            C.FechaCobro = txt_fecha_cobro.Text
                            C.Observacion = rtxt_obserbaciones.Text
                            C.NumeroContrato = txtNroDocumento.Text
                            C.FechaContrato = CDate(dtpFechacontrato.Value)
                            C.Contrato = RutaImgen
                            C.Consecutivo = txt_consecutivo.Text
                            C.FormaPago = cb_forma_pago.SelectedItem
                            C.monto_actual = C.Monto
                            Mensaje = C.Registrar_Contrato()
                            Call Listar_Contratos() 'Llamamos al método listar contratos
                            clsMensaje.mostrar_mensaje(Mensaje, "ok")
                            Call Limpiar_controles() 'Llamamos el método limpiar controles
                        Else
                            C.CodigoCliente = CInt(CodigoCliente)
                            Dim NombreFoto As String = "Contrato-" & C.Devolver_Codigo_cliente()

                            If (File.Exists(NombreFoto)) Then

                                File.Delete(NombreFoto)
                            End If

                            If (CDec(txt_prima.Text) < Decimal.Parse(txt_monto.Text.Substring(0, txt_monto.Text.Length - 3))) Then
                                RutaImgen = Imagenes.copiarImagen(pb_contrato2.ImageLocation, NombreFoto + "-reverso", "", 1)
                                RutaImgen = Imagenes.copiarImagen(pb_contrato.ImageLocation, NombreFoto, "", 1)

                                C.CodigoCliente = CInt(CodigoCliente)
                                C.CodigoPersonal = CInt(Codigopersonal)
                                C.TipoContrato = If(chk_alfa.Checked = True, "Alfa", "University")
                                C.Monto = Decimal.Parse(txt_monto.Text.Substring(0, txt_monto.Text.Length - 3))

                                C.Plazo = CInt(txtplazo.Text)
                                C.Cuota = Decimal.Parse(txt_cuota.Text.Substring(0, txt_cuota.Text.Length - 3))
                                C.Zona = cb_zona.SelectedItem
                                C.LugarCobro = cb_lugarcobro.SelectedItem
                                C.FechaCobro = txt_fecha_cobro.Text
                                C.Observacion = rtxt_obserbaciones.Text
                                C.NumeroContrato = txtNroDocumento.Text
                                C.FechaContrato = CDate(dtpFechacontrato.Value)
                                C.Contrato = RutaImgen
                                C.Consecutivo = txt_consecutivo.Text
                                C.FormaPago = cb_forma_pago.SelectedItem
                                C.monto_actual = CDec(C.Monto) - CDec(txt_prima.Text)
                                Mensaje = C.Registrar_Contrato()
                                If Mensaje = "Contrato Se Registrado correctamente" Then
                                    C.prima = CDec(txt_prima.Text)
                                    C.fechas = CDate(dtpFechacontrato.Value)
                                    C.Periodos = CDate(dtpFechacontrato.Value).ToString("MMMM yyyy")
                                    C.Ahorrados = CDec(C.Monto) - C.monto_actual
                                    C.CuotasAhorradass = Math.Floor((CDec(C.Ahorrados) / CDec(C.Cuota)))
                                    C.SaldoCuotass = Math.Floor(CDec(C.Plazo) - (CDec(CR.ahorradorecibo) / CDec(C.Cuota)))
                                    C.reconocimientos = "Reconocimiento"
                                    C.observaciones = "No Aplica"
                                    C.Registrar_Prima()
                                End If
                            End If
                            Call Listar_Contratos() 'Llamamos al método listar contratos
                                clsMensaje.mostrar_mensaje(Mensaje, "ok")
                                Call Limpiar_controles() 'Llamamos el método limpiar controles
                            End If
                            Else
                            C.CodigoCliente = CInt(CodigoCliente)
                        Dim NombreFoto As String = "Contrato-" & C.Devolver_Codigo_cliente()

                        If (File.Exists(Application.StartupPath() + "\Funeraria\Producto\" + NombreFoto + ".jpg")) Then

                            File.Delete(Application.StartupPath() + "\Funeraria\Producto\" + NombreFoto + ".jpg")
                        End If
                        RutaImgen = Imagenes.copiarImagen(pb_contrato2.ImageLocation, NombreFoto + "-reverso", "", 1)
                        RutaImgen = Imagenes.copiarImagen(pb_contrato.ImageLocation, NombreFoto, "", 1)
                        C.CodigoContrato = CodigoContrato
                        CR.CodigoContrato = CodigoContrato
                        C.CodigoCliente = CInt(CodigoCliente)
                        C.CodigoPersonal = CInt(Codigopersonal)
                        C.TipoContrato = If(chk_alfa.Checked = True, "Alfa", "University")
                        Dim ahorrado As Decimal = CDec(CR.Devolver_monto_credito())
                        If (CDec(txt_monto.Text) = CDec(C.Devolver_monto)) Then
                            C.Monto = CDec(txt_monto.Text)
                            C.monto_actual = CDec(txt_monto.Text) - ahorrado
                        Else

                            Dim montoactual As Decimal = CDec(txt_monto.Text) - ahorrado
                            C.Monto = CDec(txt_monto.Text)
                            C.monto_actual = montoactual

                        End If
                        C.Plazo = CInt(txtplazo.Text)
                            C.Cuota = CDec(txt_cuota.Text)
                            C.Zona = cb_zona.SelectedItem
                            C.LugarCobro = txt_Notas.Text
                            C.FechaCobro = txt_fecha_cobro.Text
                            C.Observacion = rtxt_obserbaciones.Text
                            C.NumeroContrato = txtNroDocumento.Text
                            C.FechaContrato = CDate(dtpFechacontrato.Value)
                            C.Contrato = RutaImgen
                            C.Consecutivo = txt_consecutivo.Text
                        C.FormaPago = cb_forma_pago.SelectedItem
                        Mensaje = C.Actualizar_Contrato()
                        If Mensaje = "Contrato Actualizado correctamente" And cambio Then
                            Dim montocuota As Decimal = 0

                            Dim dt As DataTable = C.devolver_recibos_contratos
                            For i = 0 To dt.Rows.Count - 1


                                montocuota = CDec(C.Cuota) * CDec(i + 1)
                                C.ahorradorecibo = CDec(CR.Devolver_monto_credito()) + montocuota
                                C.CodigoCarga = CInt(dt.Rows(i)(0).ToString())
                                C.Scuotas = Math.Floor(CDec(C.Plazo) - Math.Floor((CDec(C.ahorradorecibo) / CDec(C.Cuota))))
                                C.Acuotas = Math.Floor((CDec(C.ahorradorecibo) / CDec(C.Cuota)))
                                C.Actualizar_recibos()
                            Next
                        End If
                        txt_cuota.ReadOnly = False
                            txtplazo.ReadOnly = False
                        txt_monto.ReadOnly = False
                        cb_reconocimiento.Enabled = True
                        clsMensaje.mostrar_mensaje(Mensaje, "ok")
                            Call Limpiar_controles() 'Llamamos el método limpiar controles
                            Call Listar_Contratos() 'Llamamos al método listar contratos
                        End If


                        Call Listar_Contratos()

                Catch ex As Exception
                    clsMensaje.mostrar_mensaje(ex.Message, "error")
                End Try
            End If
        Else
            clsMensaje.mostrar_mensaje("no  tiene permisos para esta Opción", "error")
        End If
        btnRegistrar.Enabled = True
    End Sub
    Private Sub Limpiar_controles_traslado()
        txt_monto_actual.Clear()
        CodigoContrato = 0
        CodigoContrato2 = 0
        txt_monto_actual.Clear()
        txt_contrato2.Clear()
        txt_cliente_tranferir.Clear()
        txt_monto2.Clear()
        txt_monto_transferido.Clear()
        txt_cliente.Clear()
        txt_contrato.Clear()
    End Sub
    Private Sub Limpiar_controles()

        chk_alfa.Checked = False
        chk_university.Checked = False
        txt_monto.Clear()
        txtplazo.Clear()
        txt_cuota.Clear()
        cb_zona.SelectedIndex = 0
        txt_Notas.Clear()
        txt_fecha_cobro.Clear()
        rtxt_obserbaciones.Clear()
        txtNroDocumento.Clear()
        Dgv_contratos.Rows.Clear()
        txtCliente.Clear()
        txt_vendedor.Clear()
        txt_prima.Clear()
        cb_reconocimiento.SelectedIndex = 0
        rtb_observacion.Clear()
        pb_contrato.Image = Image.FromFile("C:\Funeraria\Foto\sin foto.jpg")
        pb_contrato.ImageLocation = "C:\Funeraria\Foto\sin foto.jpg"
        CodigoCliente = 0
        Codigopersonal = 0
        'CodigoProducto = 0
        lst.Clear()
        pb_contrato2.Image = Image.FromFile("C:\Funeraria\Foto\sin foto.jpg")
        pb_contrato2.ImageLocation = "C:\Funeraria\Foto\sin foto.jpg"
    End Sub
    Private Sub Limpiar_controles_liquidacion()

        CodigoContrato = 0
        lblTotal.Text = ""
        dtpFecha.Value = DateTime.Now
        tb_difunto.Text = ""

        txt_retirado.Text = ""
        'CodigoProducto = 0
        lst.Clear()
        dgvmantenimientos.Rows.Clear()
    End Sub
    Private Sub Listar_Contratos()
        Llenar_Grilla(C.Listar_Contratos(), Dgv_contratos)
    End Sub

    Private Sub Llenar_Grilla(ByVal dt As DataTable, ByVal data As DataGridView)
        Try
            data.Rows.Clear()

            For i = 0 To dt.Rows.Count - 1
                data.Rows.Add(dt.Rows(i)(0))
                data.Rows(i).Cells(0).Value = CInt(dt.Rows(i)(0).ToString())
                data.Rows(i).Cells(1).Value = dt.Rows(i)(1).ToString()
                data.Rows(i).Cells(2).Value = dt.Rows(i)(2).ToString()
                data.Rows(i).Cells(3).Value = dt.Rows(i)(3).ToString()
                data.Rows(i).Cells(4).Value = dt.Rows(i)(4).ToString()
                data.Rows(i).Cells(5).Value = dt.Rows(i)(5).ToString()
                data.Rows(i).Cells(6).Value = CDec(dt.Rows(i)(6).ToString())
                data.Rows(i).Cells(7).Value = CInt(dt.Rows(i)(7).ToString())
                data.Rows(i).Cells(8).Value = CDec(dt.Rows(i)(8).ToString())
                data.Rows(i).Cells(9).Value = dt.Rows(i)(9).ToString()
                data.Rows(i).Cells(10).Value = dt.Rows(i)(10).ToString()
                data.Rows(i).Cells(11).Value = dt.Rows(i)(11).ToString()
                data.Rows(i).Cells(12).Value = dt.Rows(i)(12).ToString()
                data.Rows(i).Cells(13).Value = dt.Rows(i)(13).ToString()
                data.Rows(i).Cells(14).Value = Format(dt.Rows(i)(14), "dd/MM/yyyy")
                data.Rows(i).Cells(15).Value = dt.Rows(i)(15).ToString()
                data.Rows(i).Cells(16).Value = dt.Rows(i)(16).ToString()
                If (dt.Rows(i)(16).ToString() = "LIQUIDADO" Or dt.Rows(i)(16).ToString() = "ANULADO") Then 'Si el Stock es menor a Cero

                    data.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(255, 135, 135) 'Pintamos toda la fila de color rojo claro 
                    data.Rows(i).DefaultCellStyle.ForeColor = Color.White 'Asiganmos color blanco al texto
                ElseIf dt.Rows(i)(16).ToString() = "MOROSO PENDIENTE" Then
                    data.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(236, 175, 71) 'Pintamos toda la fila de color rojo claro 
                    data.Rows(i).DefaultCellStyle.ForeColor = Color.White 'Asiganmos color blanco al texto
                ElseIf dt.Rows(i)(16).ToString() = "CANCELADO PENDIENTE" Then
                    data.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(45, 202, 76) 'Pintamos toda la fila de color rojo claro 
                    data.Rows(i).DefaultCellStyle.ForeColor = Color.White 'Asiganmos color blanco al texto
                End If
                data.Rows(i).Cells(17).Value = "Ver Servicios Brindados"
                data.Rows(i).Cells(18).Value = "Editar"
                data.Rows(i).Cells(19).Value = dt.Rows(i)(17).ToString()
                data.Rows(i).Cells(20).Value = dt.Rows(i)(18).ToString()
                data.Rows(i).Cells(21).Value = "Ver Contrato"
                data.Rows(i).Cells(22).Value = "Eliminar"

            Next
            data.ClearSelection()
            For Each row As DataGridViewRow In data.Rows
                Dim button1 As DataGridViewButtonCell = CType(row.Cells(17), DataGridViewButtonCell)
                Dim button2 As DataGridViewButtonCell = CType(row.Cells(18), DataGridViewButtonCell)
                Dim button3 As DataGridViewButtonCell = CType(row.Cells(21), DataGridViewButtonCell)
                Dim button4 As DataGridViewButtonCell = CType(row.Cells(22), DataGridViewButtonCell)
                button1.Style.BackColor = Color.FromArgb(92, 184, 92)
                button1.Style.ForeColor = Color.White
                button1.Style.Font = New Font("Arial", 9, FontStyle.Bold)
                button2.Style.BackColor = Color.FromArgb(92, 184, 92)
                button2.Style.ForeColor = Color.White
                button2.Style.Font = New Font("Arial", 9, FontStyle.Bold)
                button3.Style.BackColor = Color.FromArgb(0, 191, 255)
                button3.Style.ForeColor = Color.White
                button3.Style.Font = New Font("Arial", 9, FontStyle.Bold)
                button4.Style.BackColor = Color.FromArgb(217, 83, 79)
                button4.Style.ForeColor = Color.White
                button4.Style.Font = New Font("Arial", 9, FontStyle.Bold)
            Next
        Catch ex As Exception
            clsMensaje.mostrar_mensaje(ex.Message, "error")
        End Try

    End Sub
    Dim DataCollection As New AutoCompleteStringCollection()
    Dim DataCollection2 As New AutoCompleteStringCollection()

    Private Sub Listar_detalle_traslado()
        Llenar_Grilla_detalle_traslado(C.Listar_tralados_por_cliente(), dgv_detalles_traslado)
    End Sub

    Private Sub Llenar_Grilla_detalle_traslado(ByVal dt As DataTable, ByVal data As DataGridView)
        Try
            data.Rows.Clear()

            For i = 0 To dt.Rows.Count - 1
                data.Rows.Add(dt.Rows(i)(0))
                data.Rows(i).Cells(0).Value = CInt(dt.Rows(i)(0).ToString())
                data.Rows(i).Cells(1).Value = dt.Rows(i)(2).ToString()
                data.Rows(i).Cells(2).Value = dt.Rows(i)(1).ToString()
                data.Rows(i).Cells(3).Value = dt.Rows(i)(3).ToString()
                data.Rows(i).Cells(4).Value = CDec(dt.Rows(i)(4).ToString())
                data.Rows(i).Cells(5).Value = Format(dt.Rows(i)(5), "dd/MM/yyyy")
                data.Rows(i).Cells(6).Value = dt.Rows(i)(6).ToString()
                data.Rows(i).Cells(7).Value = CInt(dt.Rows(i)(7).ToString())


            Next

        Catch ex As Exception
            clsMensaje.mostrar_mensaje(ex.Message, "error")
        End Try

    End Sub
    Private Sub Frm012_Contratos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pb_contrato.Image = Image.FromFile("C:\Funeraria\Foto\sin foto.jpg")
        pb_contrato.ImageLocation = "C:\Funeraria\Foto\sin foto.jpg"
        pb_contrato2.Image = Image.FromFile("C:\Funeraria\Foto\sin foto.jpg")
        pb_contrato2.ImageLocation = "C:\Funeraria\Foto\sin foto.jpg"
        Call Listar_Contratos()
        Llenar_Grilla(C.listar_trasladados(), dgv_trasladados)
        cb_zona.SelectedIndex = 0
        cb_lugarcobro.SelectedIndex = 0
        cb_forma_pago.SelectedIndex = 0
        cb_tipo_mantenimiento.SelectedIndex = 0
        txt_contrato2.Enabled = False
        lk_buscar2.Enabled = False
        btn_traslado.Enabled = False
        cb_reconocimiento.SelectedIndex = 0
        Me.SetBounds(58, 0, Screen.PrimaryScreen.Bounds.Width - 60, Screen.PrimaryScreen.Bounds.Height - 100)
        txt_vendedor.AutoCompleteMode = AutoCompleteMode.Suggest
        txt_vendedor.AutoCompleteSource = AutoCompleteSource.CustomSource
        txt_vendedor.AutoCompleteCustomSource = DataCollection
        getData(DataCollection, C.devover_vendedor_contratos_autocompletar)

        lst.Clear()
    End Sub
    Private Sub getData(ByVal dataCollection As AutoCompleteStringCollection, ByVal dt As DataTable)
        Try


            For i = 0 To dt.Rows.Count - 1


                dataCollection.Add(dt.Rows(i)(0))

            Next

            'Dim da As New OleDb.OleDbDataAdapter("select top 1000  nombre  from bebes order by id", Conexion)
            'dst = New DataSet
            'da.Fill(dst)
            'If dst.Tables(0).Rows.Count > 0 Then
            '    For Each row As DataRow In dst.Tables(0).Rows
            '        dataCollection.Add(row(0).ToString())
            '    Next
            'End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Dgv_contratos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_contratos.CellContentClick
        If (Me.Dgv_contratos.Columns(e.ColumnIndex).Name.Equals("Ver")) Then
            Dim frm As Frm012_liquidaciones = New Frm012_liquidaciones()
            frm.C.codigocontratoliquidaciones = Dgv_contratos.CurrentRow.Cells(0).Value.ToString()
            frm.Show()
        ElseIf (Me.Dgv_contratos.Columns(e.ColumnIndex).Name.Equals("Editar")) Then
            Me.Dgv_contratos.ClearSelection()
            CodigoContrato = Me.Dgv_contratos.CurrentRow.Cells(0).Value.ToString()
            txtCliente.Text = Me.Dgv_contratos.CurrentRow.Cells(1).Value.ToString()
            txt_vendedor.Text = Me.Dgv_contratos.CurrentRow.Cells(2).Value.ToString()
            txtNroDocumento.Text = Me.Dgv_contratos.CurrentRow.Cells(3).Value.ToString()
            cb_reconocimiento.Enabled = False
            If (Me.Dgv_contratos.CurrentRow.Cells(4).Value.ToString() = "Alfa") Then
                chk_alfa.Checked = True
            Else
                chk_university.Checked = True
            End If
            txt_consecutivo.Text = Me.Dgv_contratos.CurrentRow.Cells(5).Value.ToString()
            txt_monto.Text = Me.Dgv_contratos.CurrentRow.Cells(6).Value.ToString()
            txt_cuota.Text = Me.Dgv_contratos.CurrentRow.Cells(8).Value.ToString()
            txtplazo.Text = Me.Dgv_contratos.CurrentRow.Cells(7).Value.ToString()
            'txt_cuota.ReadOnly = True
            'txtplazo.ReadOnly = True
            'txt_monto.ReadOnly = True
            cb_zona.SelectedItem = Me.Dgv_contratos.CurrentRow.Cells(9).Value.ToString()
            cb_lugarcobro.SelectedItem = Me.Dgv_contratos.CurrentRow.Cells(10).Value.ToString()
            txt_fecha_cobro.Text = Me.Dgv_contratos.CurrentRow.Cells(11).Value.ToString()
            cb_forma_pago.SelectedItem = Me.Dgv_contratos.CurrentRow.Cells(12).Value.ToString()
            rtxt_obserbaciones.Text = Me.Dgv_contratos.CurrentRow.Cells(13).Value.ToString()
            dtpFechacontrato.Value = Me.Dgv_contratos.CurrentRow.Cells(14).Value.ToString()
            If File.Exists(Me.Dgv_contratos.CurrentRow.Cells(15).Value.ToString()) Then
                pb_contrato.ImageLocation = Me.Dgv_contratos.CurrentRow.Cells(15).Value.ToString()
                Dim cadena As String = Me.Dgv_contratos.CurrentRow.Cells(15).Value.ToString()
                If File.Exists(cadena.Substring(0, cadena.Length - 4) + "-reverso" + cadena.Substring(cadena.Length - 4, 4)) Then
                    pb_contrato2.ImageLocation = cadena.Substring(0, cadena.Length - 4) + "-reverso" + cadena.Substring(cadena.Length - 4, 4)
                Else
                    pb_contrato2.Image = Image.FromFile("C:\Funeraria\Foto\sin foto.jpg")
                    pb_contrato2.ImageLocation = "C:\Funeraria\Foto\sin foto.jpg"
                End If

            Else
                pb_contrato.Image = Image.FromFile("C:\Funeraria\Foto\sin foto.jpg")
                pb_contrato.ImageLocation = "C:\Funeraria\Foto\sin foto.jpg"

            End If




            CodigoCliente = CInt(Me.Dgv_contratos.CurrentRow.Cells(19).Value.ToString())
            Codigopersonal = CInt(Me.Dgv_contratos.CurrentRow.Cells(20).Value.ToString())
            valor = 1
            TabControl1.SelectTab(TabPage1)
        ElseIf (Me.Dgv_contratos.Columns(e.ColumnIndex).Name.Equals("vercontrato")) Then
            Me.Dgv_contratos.ClearSelection()
            Dim Frm As New Frm004ii_ModalPlanes()
            Frm.ptImagen.ImageLocation = Me.Dgv_contratos.CurrentRow.Cells(15).Value.ToString()
            Frm.ShowDialog()
        ElseIf (Me.Dgv_contratos.Columns(e.ColumnIndex).Name.Equals("Eliminar")) Then

            C.CodigoContrato = Dgv_contratos.CurrentRow.Cells(0).Value.ToString()
            Dim mensaje As String = C.Eliminar_Contrato()
            clsMensaje.mostrar_mensaje(mensaje, "ok")
            Listar_Contratos()
        End If
    End Sub

    'Private Sub rbnNombre_CheckedChanged(sender As Object, e As EventArgs) Handles rbnNombre.CheckedChanged
    '    Listar_Contratos()
    '    txtDatos.MaxLength = 256
    '    txtDatos.Clear()
    '    Tipo_Dato = 1
    '    txtDatos.Focus()
    'End Sub

    'Private Sub rbnNDoc_CheckedChanged(sender As Object, e As EventArgs) Handles rbnNDoc.CheckedChanged
    '    Listar_Contratos()
    '    txtDatos.MaxLength = 15
    '    txtDatos.Clear()
    '    Tipo_Dato = 0
    '    txtDatos.Focus()
    'End Sub

    Private Sub rbnNDoc_KeyPress(sender As Object, e As KeyPressEventArgs)
        Validar.Numeros(e)
    End Sub

    Private Sub rbnNombre_KeyPress(sender As Object, e As KeyPressEventArgs)
        Validar.Letras(e)
    End Sub

    Private Sub txtDatos_TextChanged(sender As Object, e As EventArgs) Handles txtDatos.TextChanged
        If (txtDatos.Text.Trim() <> "") Then
            Try
                C.dato = CStr(txtDatos.Text)
                Llenar_Grilla(C.Buscar_Contratos(), Dgv_contratos)
            Catch ex As Exception
                clsMensaje.mostrar_mensaje(ex.Message, "error")
            End Try
        Else
            Listar_Contratos()
        End If
    End Sub

    Private Sub txtplazo_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txt_monto_TextChanged(sender As Object, e As EventArgs) Handles txt_monto.TextChanged
        If (txt_monto.Text.Length > 3 And txtplazo.Text <> "" And txtplazo.Text <> "0") Then
            txt_cuota.Text = CDec(txt_monto.Text) / CDec(txtplazo.Text)
        End If
        cambio = True
    End Sub

    Private Sub txtplazo_TextChanged_1(sender As Object, e As EventArgs) Handles txtplazo.TextChanged
        If (txt_monto.Text.Length > 3 And txtplazo.Text <> "" And txtplazo.Text <> "0") Then
            txt_cuota.Text = CDec(txt_monto.Text) / CDec(txtplazo.Text)
        End If
        cambio = True
    End Sub

    Private Sub lkbBuscar1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lkbBuscar1.LinkClicked
        If (rbnPlanFunerario.Checked = True) Then
            Dim frm As New Frm009i_Listado_Planes()
            frm.liquidacion = "liquidar"
            frm.Caller = Me

            frm.ShowDialog()

        End If
    End Sub

    Public Function LoadDataRow1(ByVal planServico As EPlanServicio) As Boolean Implements IPlanServicio.LoadDataRow1
        'Busca si el Cliente ya se encuentra en la lista
        Dim exists As Boolean = Plan.Any(Function(x) x.Codigo.Equals(planServico.Codigo))
        'Preguntamos por el resultado de la busqueda del Cliente dentro de la lista
        If Not exists Then
            Plan.Add(planServico)

            Try
                Call Listar_Productos() 'Llamamos al método Listar_Productos

                lblTotal.Text = CalcularTotal()
                lblIgv.Text = CalcularIgv()
                lblSubTotal.Text = CalcularSubTotal()
            Catch ex As Exception
                clsMensaje.mostrar_mensaje(ex.Message, "error")
            End Try

            'Retornamos True
            Return True
        End If
        'Si la condicion exists es igual a False, es decir, que el Cliente SI existe en la lista
        'retornamos FALSE para mostrar un mensajde informacion
        Return False
    End Function


    Private Sub Listar_Productos()
        Try
            dgvmantenimientos.Rows.Clear()
            For i = 0 To Plan.Count - 1
                dgvmantenimientos.Rows.Add()
                Me.dgvmantenimientos.Rows(i).Cells(0).Value = CInt(Plan(i).Codigo)
                Me.dgvmantenimientos.Rows(i).Cells(1).Value = CStr(Plan(i).Descripcion)
                Me.dgvmantenimientos.Rows(i).Cells(2).Value = CDec(Plan(i).Precio)
                Me.dgvmantenimientos.Rows(i).Cells(3).Value = CInt(Plan(i).Cantidad)
                SubTotal = (CDec(Plan(i).Precio) * CInt(Plan(i).Cantidad)) / 1.13
                Igv = SubTotal * 0.13
                Me.dgvmantenimientos.Rows(i).Cells(4).Value = Math.Round(Igv, 2)
                Me.dgvmantenimientos.Rows(i).Cells(5).Value = Math.Round(SubTotal, 2)
                Me.dgvmantenimientos.Rows(i).Cells(6).Value = Math.Round(CDec(SubTotal + Igv), 2)
                Me.dgvmantenimientos.Rows(i).Cells(7).Value = "Eliminar"
            Next
            Me.dgvmantenimientos.ClearSelection()
            Call asignar_color_boton()
        Catch ex As Exception
            clsMensaje.mostrar_mensaje(ex.Message, "error")
        End Try
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
    Private Sub asignar_color_boton()
        For Each row As DataGridViewRow In dgvmantenimientos.Rows
            Dim button1 As DataGridViewButtonCell = CType(row.Cells(7), DataGridViewButtonCell)
            button1.Style.BackColor = Color.FromArgb(217, 83, 79)
            button1.Style.ForeColor = Color.White
            button1.Style.Font = New Font("Arial", 9, FontStyle.Bold)
        Next
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lk_buscar.LinkClicked
        Dim frm As Frm12_contratoslista
        paso = True
        'Instanciamos el FrmPersonalPrincipal
        If cb_tipo_mantenimiento.SelectedIndex = 2 Then
            frm = New Frm12_contratoslista()

            'Le indicamos quien lo mando a llamar usando la Propiedad Caller
            frm.Caller1 = Me
            frm.tipo = "LQ"

            'Mostramos el FrmPersonalPrincipal
            'Frm00_Login.FormActive = 2
            frm.ShowDialog()

        Else

            frm = New Frm12_contratoslista()

            'Le indicamos quien lo mando a llamar usando la Propiedad Caller
            frm.Caller1 = Me
            'Mostramos el FrmPersonalPrincipal
            'Frm00_Login.FormActive = 2
            frm.ShowDialog()
        End If


    End Sub

    Public Function LoadDataRow2(contratos As EContratos) As Boolean Implements IContratos.LoadDataRow2
        'Busca si el Cliente ya se encuentra en la lista
        Dim exists As Boolean = Contrato.Any(Function(x) x.CodigoContrato.Equals(contratos.CodigoContrato))
        'Preguntamos por el resultado de la busqueda del Cliente dentro de la lista
        If Not exists Then
            If paso Then
                If cb_tipo_mantenimiento.SelectedIndex = 2 Then
                    CodigoContrato = contratos.CodigoContrato
                    CR.CodigoContrato = CodigoContrato
                    txt_contrato.Text = contratos.Numero_contrato
                    txt_cliente.Text = contratos.Cliente
                    txt_monto_actual.Text = CStr(CDec(CR.Devolver_monto_credito()))
                    C.CodigoContrato = CodigoContrato
                    Dim datos As DataTable = C.devolver_liquidados()
                    tb_difunto.Text = datos.Rows(0).Item(6).ToString()
                    txt_retirado.Text = datos.Rows(0).Item(3).ToString()
                    txt_solicitud.Text = datos.Rows(0).Item(4).ToString()
                    rtb_observaciones.Text = datos.Rows(0).Item(5).ToString()
                    C.CodigoLiquidacion = datos.Rows(0).Item(0).ToString()
                    Dim dt As DataTable = C.devolver_productos_liquidados()
                    Plan.Clear()


                    For i = 0 To dt.Rows.Count - 1
                        Dim planServicios As EPlanServicio = New EPlanServicio
                        planServicios.Codigo = dt.Rows(i)(0).ToString()
                        planServicios.Descripcion = dt.Rows(i)(1).ToString()
                        planServicios.Cantidad = dt.Rows(i)(2).ToString()
                        planServicios.Precio = dt.Rows(i)(3).ToString()

                        Plan.Add(planServicios)
                    Next

                    Try
                        Call Listar_Productos() 'Llamamos al método Listar_Productos

                        lblTotal.Text = CalcularTotal()
                        lblIgv.Text = CalcularIgv()
                        lblSubTotal.Text = CalcularSubTotal()
                    Catch ex As Exception
                        clsMensaje.mostrar_mensaje(ex.Message, "error")
                    End Try

                    'ElseIf cb_tipo_mantenimiento.SelectedIndex = 3 Then
                    '    CodigoContrato = contratos.CodigoContrato
                    '    CR.CodigoContrato = CodigoContrato
                    '    txt_contrato.Text = contratos.Numero_contrato
                    '    txt_cliente.Text = contratos.Cliente
                    '    txt_monto_actual.Text = CStr(CDec(CR.Devolver_monto_credito()))
                    '    C.CodigoContrato = CodigoContrato
                    '    Dim dt As DataTable = C.devolver_productos_liquidados()
                Else

                    CodigoContrato = contratos.CodigoContrato
                    CR.CodigoContrato = CodigoContrato
                    txt_contrato.Text = contratos.Numero_contrato
                    txt_cliente.Text = contratos.Cliente
                    txt_monto_actual.Text = CStr(CDec(CR.Devolver_monto_credito()))

                End If


            Else
                CodigoContrato2 = contratos.CodigoContrato
                CR.CodigoContrato = CodigoContrato2
                txt_cliente_tranferir.Text = contratos.Cliente
                txt_contrato2.Text = contratos.Numero_contrato
                txt_monto2.Text = CStr(CDec(CR.Devolver_monto_credito()))
            End If
            'Retornamos True
            Return True
        End If
        'Si la condicion exists es igual a False, es decir, que el Cliente SI existe en la lista
        'retornamos FALSE para mostrar un mensajde informacion
        Return False
    End Function

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        rtxt_obserbaciones.Text = "Usuario: " + usuario_online + " Fecha: " + CStr(dtp_feccha_nota.Value.Date) + " " + txt_Notas.Text + vbCr + " " + rtxt_obserbaciones.Text
    End Sub

    Private Sub cb_tipo_mantenimiento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_tipo_mantenimiento.SelectedIndexChanged
        If cb_tipo_mantenimiento.SelectedIndex = 0 Or cb_tipo_mantenimiento.SelectedIndex = 2 Then
            txt_contrato2.Enabled = False
            lk_buscar2.Enabled = False
            lkbBuscar1.Enabled = True
            btnLiquidar.Enabled = True
            btn_traslado.Enabled = False
            txt_retirado.Enabled = True
            txt_solicitud.Text = C.Devolver_solicitud

        Else
            txt_contrato2.Enabled = True
            lk_buscar2.Enabled = True
            lkbBuscar1.Enabled = False
            btnLiquidar.Enabled = False
            btn_traslado.Enabled = True
            txt_retirado.Enabled = False

        End If

    End Sub

    Private Sub btnLiquidar_Click(sender As Object, e As EventArgs) Handles btnLiquidar.Click
        btnLiquidar.Enabled = False
        U.CodigoPersona = CStr(Codigo_Personal_Online)
        U.tipo = "personal"
        Dim permiso As String = U.Devolver_permisos()

        If (permiso = "Todos") Then
            ErrorProvider1.Clear()

            If (txt_contrato.Text.Trim = "") Then
                ErrorProvider1.SetError(txt_contrato, "Ingreso Dirección del Sepelio")
            ElseIf (txt_monto_actual.Text.Trim = "") Then
                ErrorProvider1.SetError(txt_monto_actual, "Seleccione Cliente")
            ElseIf (dgvmantenimientos.Rows.Count < 1) Then
                clsMensaje.mostrar_mensaje("No hay ningún Ítem en el Carrito de Ventas", "error")
            Else
                If cb_tipo_mantenimiento.SelectedIndex = 2 Then
                    Dim Mensaje As String = ""
                    Try


                        C.Total = lblTotal.Text
                            C.observacionesliquidar = rtb_observaciones.Text
                        Mensaje = C.Actualizar_Liquidacion()

                        If (Mensaje = "Liquidacion Actualizada correctamente") Then
                            C.Eliminar_detalle_liquidacion()
                            'Registramos el detalle de la Liquidacion            
                            For i = 0 To Plan.Count - 1


                                C.CodigoItem = CInt(Plan(i).Codigo)

                                C.Cantidad = CInt(Plan(i).Cantidad)
                                C.PrecioVenta = Math.Round(CDec(Plan(i).Precio), 2)
                                C.SubTotal = (CDec(Plan(i).Precio) * CInt(Plan(i).Cantidad)) / 1.13
                                C.IGV = SubTotal * 0.13
                                C.Descuento = CDec(0)

                                C.Actualizar_Detalle_Liquidacion()
                            Next
                            lst.Clear()

                            txt_solicitud.Text = C.Devolver_solicitud
                            clsMensaje.mostrar_mensaje(Mensaje, "ok")
                            'GenerarDocumento() 'Llamamos al método para generar el comprobante de pago (BOLETA Y/O FACTURA)
                            Limpiar_controles_liquidacion()

                        Else
                            clsMensaje.mostrar_mensaje(Mensaje, "error")

                            End If

                    Catch ex As Exception
                        clsMensaje.mostrar_mensaje(ex.Message, "error")
                    End Try
                Else
                    Dim Mensaje As String = ""
                    Try
                        If (CDec(lblTotal.Text) <= CDec(txt_monto_actual.Text)) Then
                            C.CodigoContrato = CodigoContrato
                            C.Total = lblTotal.Text
                            C.Fecha = DateTime.Now
                            C.Difunto = tb_difunto.Text
                            C.nsolicitud = txt_solicitud.Text
                            C.observacionesliquidar = rtb_observaciones.Text
                            C.Retirado = txt_retirado.Text
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

                                txt_solicitud.Text = C.Devolver_solicitud
                                clsMensaje.mostrar_mensaje(Mensaje, "ok")
                                'GenerarDocumento() 'Llamamos al método para generar el comprobante de pago (BOLETA Y/O FACTURA)
                                Limpiar_controles_liquidacion()

                            Else
                                clsMensaje.mostrar_mensaje(Mensaje, "error")

                            End If
                        Else
                            clsMensaje.mostrar_mensaje("el monto es mayor al contrato", "error")
                            'Dim answer As DialogResult
                            'answer = MessageBox.Show("El monto es menor al ahorrado debe generar un credito", "Yes/no sample", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            'If answer = vbYes Then

                            '    'Instanciamos el FrmPersonalPrincipal
                            '    Dim frm As New Frm012_VentasLiquidacion()
                            '    frm.C.CodigoContrato = CodigoContrato
                            '    frm.C.Total = txt_monto_actual.Text
                            '    frm.C.Fecha = DateTime.Now
                            '    frm.C.CodigoDifunto = CodigoDifunto
                            '    frm.C.Retirado = txt_retirado.Text
                            '    frm.C.CodigoLiquidacion = CInt(C.Devolver_Codigo_Liquidacion())
                            '    frm.monto = CDec(lblTotal.Text) - CDec(txt_monto_actual.Text)
                            '    frm.montototal = CDec(lblTotal.Text)
                            '    frm.list = lst
                            '    frm.Plan = Plan
                            '    frm.cliente = txt_cliente.Text
                            '    frm.ShowDialog()
                            'End If




                        End If
                    Catch ex As Exception
                        clsMensaje.mostrar_mensaje(ex.Message, "error")
                    End Try
                End If
            End If
        Else
            clsMensaje.mostrar_mensaje("no  tiene permisos para esta Opción", "error")
        End If
        btnLiquidar.Enabled = True

    End Sub

    Private Sub lk_buscar2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lk_buscar2.LinkClicked
        paso = False
        'Instanciamos el FrmPersonalPrincipal
        Dim frm As New Frm12_contratoslista()

        'Le indicamos quien lo mando a llamar usando la Propiedad Caller
        frm.Caller1 = Me
        'Mostramos el FrmPersonalPrincipal
        'Frm00_Login.FormActive = 2
        frm.ShowDialog()
    End Sub

    Private Sub btn_traslado_Click(sender As Object, e As EventArgs) Handles btn_traslado.Click
        btn_traslado.Enabled = False
        U.CodigoPersona = CStr(Codigo_Personal_Online)
        U.tipo = "personal"
        Dim permiso As String = U.Devolver_permisos()

        If (permiso = "Todos") Then
            'Evento para guardar cambios, para registrar y/o actualizar información
            ErrorProvider1.Clear()
            If (txt_contrato.Text.Trim = "") Then
                ErrorProvider1.SetError(txt_contrato, "Ingrese Nombres")
            ElseIf (txt_contrato2.Text.Trim = "") Then
                ErrorProvider1.SetError(txt_contrato2, "Ingrese Descripción del Producto")


            Else
                Dim Mensaje As String = "" 'Variable para recuperar el mensaje del procedimiento almacenado de la BD

                Try 'Manejamos una excepción de errores

                    If valor = 0 Then
                        Dim resultado As Decimal = CDec(txt_monto_actual.Text) - CDec(txt_monto_transferido.Text.Substring(0, txt_monto_transferido.Text.Length - 3))

                        If (resultado < 0) Then
                            clsMensaje.mostrar_mensaje("El monto excede lo transferido o es igual a 0", "error")
                        Else
                            C.CodigoContrato = CInt(CodigoContrato)
                            C.CodigoContrato2 = CInt(CodigoContrato2)
                            C.Monto = Decimal.Parse(txt_monto_transferido.Text.Substring(0, txt_monto_transferido.Text.Length - 3))
                            C.Fecha = CDate(dtpFecha.Value)
                            Mensaje = C.Registrar_Traslado()

                            clsMensaje.mostrar_mensaje(Mensaje, "ok")
                            Call Limpiar_controles_traslado() 'Llamamos el método limpiar controles
                        End If


                    End If


                    Call Listar_Contratos()

                Catch ex As Exception
                    clsMensaje.mostrar_mensaje(ex.Message, "error")
                End Try
            End If
        Else
            clsMensaje.mostrar_mensaje("no  tiene permisos para esta Opción", "error")
        End If
        btn_traslado.Enabled = True
    End Sub

    Private Sub txt_monto_transferido_TextChanged(sender As Object, e As EventArgs) Handles txt_monto_transferido.TextChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs)
        'Dim frm As New Frm006_Difunto()
        'frm.Difunto = 1
        ''Le indicamos quien lo mando a llamar usando la Propiedad Caller
        'frm.Caller1 = Me
        ''Mostramos el FrmPersonalPrincipal
        'Frm00_Login.FormActive = 2
        'frm.ShowDialog()
    End Sub

    Private Sub dgvmantenimientos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvmantenimientos.CellContentClick
        Try
            If (Me.dgvmantenimientos.Columns(e.ColumnIndex).Name.Equals("Eliminars")) Then
                Dim CodigoPlan As Integer = CInt(dgvmantenimientos.CurrentRow.Cells(0).Value)


                For j = 0 To lst.Count - 1
                    If CodigoPlan = lst(j).CodigoItem Then
                        lst.RemoveAt(j)
                    End If
                Next

                Dim i As Integer = dgvmantenimientos.CurrentRow.Index
                dgvmantenimientos.Rows.RemoveAt(i)
                Plan.RemoveAt(i)

                Dim Total As Double = 0
                lblTotal.Text = CalcularTotal()
                lblIgv.Text = CalcularIgv()
                lblSubTotal.Text = CalcularSubTotal()

            End If
        Catch ex As Exception
            clsMensaje.mostrar_mensaje(ex.Message, "error")
        End Try
    End Sub

    Private Sub lkbCerrar_Click(sender As Object, e As EventArgs) Handles lkbCerrar.Click
        frm_inicio.mincontratos = False
        frm_inicio.pn_principal.Controls.Clear()
        frm_inicio.pn_principal.Hide()
        frm_inicio.min_pn_contratos.BackColor = Color.SteelBlue
        Me.Close()
    End Sub



    Private Sub txt_monto_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_monto.KeyDown

        Validar.keydowns(e)
    End Sub

    Private Sub txt_monto_Leave(sender As Object, e As EventArgs) Handles txt_monto.Leave

        Validar.acceptableKey = False
        Validar.strCurrency = ""

    End Sub

    Private Sub txt_cuota_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cuota.KeyDown
        Validar.keydowns(e)
    End Sub

    Private Sub txt_cuota_Leave(sender As Object, e As EventArgs) Handles txt_cuota.Leave
        Validar.acceptableKey = False
        Validar.strCurrency = ""
    End Sub

    Private Sub txt_monto_transferido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_monto_transferido.KeyPress
        Validar.Numeros(e)
        Validar.keypres(e, txt_monto_transferido)
    End Sub

    Private Sub txt_monto_transferido_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_monto_transferido.KeyDown
        Validar.keydowns(e)
    End Sub

    Private Sub txt_monto_transferido_Leave(sender As Object, e As EventArgs) Handles txt_monto_transferido.Leave
        Validar.acceptableKey = False
        Validar.strCurrency = ""
    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub txt_vendedor_TextChanged(sender As Object, e As EventArgs) Handles txt_vendedor.TextChanged

    End Sub

    Private Sub txt_vendedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_vendedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            C.datos = txt_vendedor.Text
            Dim dt As DataTable = C.devover_vendedor_contratos()
            If dt.Rows.Count > 0 Then
                txt_vendedor.Text = dt.Rows(0)(0)
                Codigopersonal = dt.Rows(0)(1)


            Else
                clsMensaje.mostrar_mensaje("no se encontro ningun registro", "error")
            End If

        End If
    End Sub

    Private Sub txtCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            C.datos = txtCliente.Text
            Dim dt As DataTable = C.devover_Cliente_contratos()
            If dt.Rows.Count > 0 Then
                txtCliente.Text = dt.Rows(0)(0)

                CodigoCliente = dt.Rows(0)(1)
                C.CodigoClientes = dt.Rows(0)(1)
                txtNroDocumento.Text = C.Devolver_n_contratos
            Else
                clsMensaje.mostrar_mensaje("no se encontro ningun registro", "error")
            End If

        End If
    End Sub

    Private Sub txtCliente_TextChanged(sender As Object, e As EventArgs) Handles txtCliente.TextChanged
        'DataCollection2.Clear()
        'txtCliente.AutoCompleteMode = AutoCompleteMode.Suggest
        'txtCliente.AutoCompleteSource = AutoCompleteSource.CustomSource
        'txtCliente.AutoCompleteCustomSource = DataCollection2
        'C.datosautocompletar = txtCliente.Text
        'getData(DataCollection2, C.Filtrar_Clientes)
    End Sub

    Private Sub cb_reconocimiento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_reconocimiento.SelectedIndexChanged
        If cb_reconocimiento.SelectedItem = "Reconocimiento" Then
            txt_prima.Enabled = True
        Else
            txt_prima.Enabled = False

        End If
    End Sub

    Private Sub txtCliente_ImeModeChanged(sender As Object, e As EventArgs) Handles txtCliente.ImeModeChanged

    End Sub


    Private Sub Panel_cabecera_Paint(sender As Object, e As PaintEventArgs) Handles Panel_cabecera.Paint

    End Sub

    Private Sub Label34_Click(sender As Object, e As EventArgs) Handles Label34.Click
        frm_inicio.mincontratos = True
        frm_inicio.Frm_contratos = Me

        frm_inicio.pn_principal.Controls.Clear()
        frm_inicio.pn_principal.Hide()
        frm_inicio.min_pn_contratos.BackColor = Color.LightSkyBlue
        Me.Hide()
    End Sub

    Private Sub btn_tarjetas_Click(sender As Object, e As EventArgs) Handles btn_tarjetas.Click
        Dim frm As Frm016_Tarjetas = New Frm016_Tarjetas
        frm.ShowDialog()
    End Sub

    Private Sub txt_solicitud_TextChanged(sender As Object, e As EventArgs) Handles txt_solicitud.TextChanged

    End Sub

    Private Sub txt_cuota_TextChanged(sender As Object, e As EventArgs) Handles txt_cuota.TextChanged
        cambio = True
    End Sub

    Private Sub txt_fecha_cobro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_fecha_cobro.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cb_zona.Focus()


        End If
    End Sub

    Private Sub cb_zona_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cb_zona.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cb_lugarcobro.Focus()


        End If
    End Sub

    Private Sub txt_Notas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Notas.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cb_reconocimiento.Focus()


        End If
    End Sub

    Private Sub cb_reconocimiento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cb_reconocimiento.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txt_prima.Focus()


        End If
    End Sub

    Private Sub txt_prima_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_prima.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txt_cliente.Focus()


        End If
    End Sub

    Private Sub txtCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCliente.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txt_vendedor.Focus()


        End If
    End Sub

    Private Sub txt_vendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_vendedor.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txtNroDocumento.Focus()


        End If
    End Sub

    Private Sub txtNroDocumento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroDocumento.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txt_consecutivo.Focus()


        End If
    End Sub

    Private Sub txt_consecutivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_consecutivo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cb_forma_pago.Focus()


        End If
    End Sub

    Private Sub cb_forma_pago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cb_forma_pago.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            pb_contrato.Focus()


        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Try
            Dim proceso As New System.Diagnostics.Process
            With proceso

                .StartInfo.FileName = "wiaacmgr.exe" ' Abre el cuadro de dialogo del escaner

                .Start()
            End With
        Catch ex As Exception


        End Try
    End Sub

    Private Sub pb_contrato2_Click(sender As Object, e As EventArgs) Handles pb_contrato2.Click
        Dim OpenFile As New OpenFileDialog()
        Try
            If OpenFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
                pb_contrato2.ImageLocation = OpenFile.FileName
            Else

            End If
        Catch ex As Exception
            clsMensaje.mostrar_mensaje("Debe elegir una imagen", "error")
        End Try
    End Sub

    Private Sub txt_busquedatraslado_TextChanged(sender As Object, e As EventArgs) Handles txt_busquedatraslado.TextChanged
        If (txt_busquedatraslado.Text.Trim() <> "") Then
            Try
                C.dato = CStr(txt_busquedatraslado.Text)
                Llenar_Grilla(C.Buscar_contrato_liquidacion_trasladado(), dgv_trasladados)
            Catch ex As Exception
                clsMensaje.mostrar_mensaje(ex.Message, "error")
            End Try
        Else
            Llenar_Grilla(C.listar_trasladados(), dgv_trasladados)
        End If
    End Sub

    Private Sub dgv_trasladados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_trasladados.CellContentClick
        C.CodigoContrato = dgv_trasladados.CurrentRow.Cells(0).Value.ToString()
        'CodigoContrato = contratos.CodigoContrato
        CR.CodigoContrato = dgv_trasladados.CurrentRow.Cells(0).Value.ToString()
        txt_contrato_tr.Text = dgv_trasladados.CurrentRow.Cells(3).Value.ToString()
        txt_cliente_tr.Text = dgv_trasladados.CurrentRow.Cells(1).Value.ToString()
        txt_monto_tr.Text = CStr(CDec(CR.Devolver_monto_credito()))

        Listar_detalle_traslado()
    End Sub

    Private Sub dgv_detalles_traslado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_detalles_traslado.CellContentClick
        C.CodigoContrato2 = dgv_detalles_traslado.CurrentRow.Cells(0).Value.ToString()
        txt_contrato_tranferir_tr.Text = dgv_detalles_traslado.CurrentRow.Cells(2).Value.ToString()
        txt_cliente_tranferir_tr.Text = dgv_detalles_traslado.CurrentRow.Cells(1).Value.ToString()
        CR.CodigoContrato = dgv_detalles_traslado.CurrentRow.Cells(0).Value.ToString()
        txt_monto_tranferir_tr.Text = CStr(CDec(CR.Devolver_monto_credito()))
        montoreal = CDec(dgv_detalles_traslado.CurrentRow.Cells(4).Value.ToString())
        txt_tranferido_tr.Text = dgv_detalles_traslado.CurrentRow.Cells(4).Value.ToString()
        C.CodigoTraslado = dgv_detalles_traslado.CurrentRow.Cells(7).Value.ToString()
        btn_editar_traslado.Enabled = True
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btn_editar_traslado.Click
        Dim montocompleto As Decimal
        Dim Mensaje As String
        montocompleto = montoreal + CDec(txt_monto_tr.Text)

        If CDec(txt_tranferido_tr.Text) <= montocompleto And CDec(txt_tranferido_tr.Text) >= 0 Then
            C.Monto = txt_tranferido_tr.Text
            Mensaje = C.Actualizar_Traslado()
            limpiartraslado()
            clsMensaje.mostrar_mensaje(Mensaje, "ok")
        Else
            clsMensaje.mostrar_mensaje("El monto mayor a que se puede trasladar o es menor a cero por favor verificar", "error")
        End If
    End Sub
    Sub limpiartraslado()
        txt_contrato_tranferir_tr.Clear()
        txt_cliente_tranferir_tr.Clear()
        txt_monto_tranferir_tr.Clear()
        txt_tranferido_tr.Clear()
        txt_contrato_tr.Clear()
        txt_cliente_tr.Clear()
        txt_monto_tr.Clear()
        montoreal = 0
        CR.CodigoContrato = 0
        C.CodigoContrato = 0
        C.CodigoContrato2 = 0
        C.CodigoTraslado = 0
        btn_editar_traslado.Enabled = False
        dgv_detalles_traslado.Rows.Clear()
    End Sub


End Class