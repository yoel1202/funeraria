﻿Imports CapaLogicaNegocio 'Importamos la capa lógica de negocio

Public Class Frm007_Proveedor
    Public frm_inicio As Frm_menu = New Frm_menu
    Dim P As New clsProveedor 'Instanciamos la clase clsProveedor de la Capa Logica de Negocio para usar sus funciones
    'Dim frm As New FrmProveedor
    Public CodigoPr As Integer = 0 'Variable para almacenar el código del Proveedor
    Public Valor As Integer = 0 'Variable para verificar si se va a registrar o actualizar la información
    Dim valida As Integer = 0
    Dim U As New clsUsuario 'Instanciamos la clase clsUsuario de la Capa Logica de Negocio para usar sus funciones
    Private Sub FrmProveedorPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Listar_Proveedores()
        Me.SetBounds(58, 0, Screen.PrimaryScreen.Bounds.Width - 60, Screen.PrimaryScreen.Bounds.Height - 100)
    End Sub

    Private Sub Listar_Proveedores()
        Try 'Manejamos una excepción de errores
            Llenar_Grilla(P.Listar_Proveedores())
        Catch ex As Exception
            clsMensaje.mostrar_mensaje(ex.Message, "error")
        End Try
    End Sub

    Private Sub Llenar_Grilla(ByVal dt As DataTable)
        dgvprovedores.Rows.Clear() 'Limpiamos el control DataGridView1

        'Llenamos el DataGridView1 con todos los elementos que contiene el DataTable
        For i = 0 To dt.Rows.Count - 1 'Recorremos el DataTable
            dgvprovedores.Rows.Add(dt.Rows(i)(0)) 'Agregamos una nueva fila en blanco
            dgvprovedores.Rows(i).Cells(0).Value = dt.Rows(i)(0).ToString()
            dgvprovedores.Rows(i).Cells(1).Value = dt.Rows(i)(1).ToString()
            dgvprovedores.Rows(i).Cells(2).Value = dt.Rows(i)(2).ToString()
            dgvprovedores.Rows(i).Cells(3).Value = dt.Rows(i)(3).ToString()
            dgvprovedores.Rows(i).Cells(4).Value = dt.Rows(i)(4).ToString()
            dgvprovedores.Rows(i).Cells(5).Value = dt.Rows(i)(5).ToString()
            dgvprovedores.Rows(i).Cells(6).Value = dt.Rows(i)(6).ToString()
            dgvprovedores.Rows(i).Cells(7).Value = dt.Rows(i)(7).ToString()
            dgvprovedores.Rows(i).Cells(8).Value = "Editar"
        Next
        dgvprovedores.ClearSelection() 'Limpiamos la selección del DataGridView1
        For Each row As DataGridViewRow In dgvprovedores.Rows
            Dim button As DataGridViewButtonCell = CType(row.Cells(8), DataGridViewButtonCell)
            button.Style.BackColor = Color.FromArgb(92, 184, 92)
            button.Style.ForeColor = Color.White
            button.Style.Font = New Font("Arial", 9, FontStyle.Bold)
        Next
    End Sub

    'Private Sub rbnNDoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnNDoc.CheckedChanged
    '    txtDatos.MaxLength = 11
    '    txtDatos.Clear()
    '    valida = 0
    '    txtDatos.Focus()
    'End Sub

    'Private Sub rbnNombre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnNombre.CheckedChanged
    '    txtDatos.MaxLength = 256
    '    txtDatos.Clear()
    '    valida = 1
    '    Listar_Proveedores()
    '    txtDatos.Focus()
    'End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Valor = 0
        TabControl1.SelectTab(TabPage2)
        txtRuc.Focus()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvprovedores.CellContentClick
        If (Me.dgvprovedores.Columns(e.ColumnIndex).Name.Equals("Button")) Then
            Me.dgvprovedores.ClearSelection()
            CodigoPr = Me.dgvprovedores.CurrentRow.Cells(0).Value.ToString()
            txtRuc.Text = Me.dgvprovedores.CurrentRow.Cells(1).Value.ToString()
            txtRazonSocial.Text = Me.dgvprovedores.CurrentRow.Cells(2).Value.ToString()
            txtRepresentante.Text = Me.dgvprovedores.CurrentRow.Cells(3).Value.ToString()
            txtCelular.Text = Me.dgvprovedores.CurrentRow.Cells(4).Value.ToString()
            txtTelefono.Text = Me.dgvprovedores.CurrentRow.Cells(5).Value.ToString()
            txtDireccion.Text = Me.dgvprovedores.CurrentRow.Cells(6).Value.ToString()
            txtEmail.Text = Me.dgvprovedores.CurrentRow.Cells(7).Value.ToString()
            Valor = 1
            TabControl1.SelectTab(TabPage2)
        End If
    End Sub

    Private Sub txtDatos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDatos.TextChanged
        If (txtDatos.Text.Trim() <> "") Then
            Try
                P.Datos = CStr(txtDatos.Text)
                Llenar_Grilla(P.Buscar_Proveedor())
            Catch ex As Exception
                clsMensaje.mostrar_mensaje(ex.Message, "error")
            End Try
        Else
            Listar_Proveedores()
        End If
    End Sub

    'Private Sub txtDatos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDatos.KeyPress
    '    If (valida = 0) Then
    '        Validar.Numeros(e)
    '    Else
    '        Validar.LetrasconPunto(e)
    '    End If
    'End Sub

    Private Sub lkbCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkbCerrar.Click
        frm_inicio.minprovedores = False
        frm_inicio.pn_principal.Controls.Clear()
        frm_inicio.pn_principal.Hide()
        frm_inicio.min_pn_provedores.BackColor = Color.SteelBlue
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        U.CodigoPersona = CStr(Codigo_Personal_Online)
        U.tipo = "personal"
        Dim permiso As String = U.Devolver_permisos()

        If (permiso = "Todos") Then
            'Evento para guardar cambios, para registrar y/o actualizar información
            ErrorProvider1.Clear()
            If (txtRuc.Text.Trim = "") Then
                ErrorProvider1.SetError(txtRuc, "Ingrese Número de RUC")
            ElseIf (txtRazonSocial.Text.Trim = "") Then
                ErrorProvider1.SetError(txtRazonSocial, "Ingrese Razón Social del Proveedor")
            ElseIf (txtRepresentante.Text.Trim = "") Then
                ErrorProvider1.SetError(txtRepresentante, "Ingrese el Representante del Proveedor")
            ElseIf (txtCelular.Text.Trim = "") Then
                ErrorProvider1.SetError(txtCelular, "Ingrese número de Celular del Representante")
            ElseIf (txtTelefono.Text.Trim = "") Then
                ErrorProvider1.SetError(txtTelefono, "Ingrese número de Telefono del Proveedor")
            ElseIf (txtDireccion.Text.Trim = "") Then
                ErrorProvider1.SetError(txtTelefono, "Ingrese Dirección")
            Else
                Dim Mensaje As String = "" 'Variable para recuperar el mensaje del procedimiento almacenado de la BD
                Try
                    If (Valor = 0) Then
                        P.Ruc = CStr(txtRuc.Text)
                        P.RazinSocial = CStr(txtRazonSocial.Text)
                        P.Representante = CStr(txtRepresentante.Text)
                        P.Celular = CStr(txtCelular.Text)
                        P.Telefono = CStr(txtTelefono.Text)
                        P.Direccion = CStr(txtDireccion.Text)
                        P.Email = CStr(txtEmail.Text)
                        Mensaje = P.Registrar_Proveedores()
                        If (Mensaje = "Registrado correctamente") Then
                            clsMensaje.mostrar_mensaje(Mensaje, "ok")
                            TabControl1.SelectTab(TabPage1)
                            Valor = 0
                        Else
                            clsMensaje.mostrar_mensaje(Mensaje, "error")
                        End If
                        U.CodigoPersona = CStr(Codigo_Personal_Online)
                        U.Accion = "Registrado un proveedor : " + P.RazinSocial + " " + P.Ruc
                        U.fechas = DateTime.Now
                        U.Registra_Acciones()
                    Else
                        P.CodigoProveedor = CInt(CodigoPr)
                        P.Ruc = CStr(txtRuc.Text)
                        P.RazinSocial = CStr(txtRazonSocial.Text)
                        P.Representante = CStr(txtRepresentante.Text)
                        P.Celular = CStr(txtCelular.Text)
                        P.Telefono = CStr(txtTelefono.Text)
                        P.Direccion = CStr(txtDireccion.Text)
                        P.Email = CStr(txtEmail.Text)
                        Mensaje = P.Actualizar_Proveedores()
                        If (Mensaje = "Actualizado correctamente") Then
                            clsMensaje.mostrar_mensaje(Mensaje, "ok")
                            TabControl1.SelectTab(TabPage1)
                            Valor = 0
                        Else
                            clsMensaje.mostrar_mensaje(Mensaje, "error")
                        End If
                        U.CodigoPersona = CStr(Codigo_Personal_Online)
                        U.Accion = "Actualizado un proveedor : " + P.RazinSocial + " " + P.Ruc
                        U.fechas = DateTime.Now
                        U.Registra_Acciones()
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
        txtRuc.Clear()
        txtRazonSocial.Clear()
        'rbnNDoc.Checked = True
        txtDatos.Clear()
        txtRepresentante.Clear()
        txtCelular.Clear()
        txtTelefono.Clear()
        txtDireccion.Clear()
        txtEmail.Clear()
        txtRuc.Focus()
        Valor = 0
        dgvprovedores.ClearSelection()
        ErrorProvider1.Clear()
    End Sub

    Private Sub TabControl1_Selecting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlCancelEventArgs) Handles TabControl1.Selecting
        Listar_Proveedores()
        If (Valor = 0) Then
            Limpiar_Controles()
        End If
    End Sub

    Private Sub Frm006_Proveedor_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Frm00_Login.FormActive = 1
    End Sub

    Private Sub Frm006_Proveedor_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Frm00_Login.FormActive = 0
        Validar.Cerrar_form = 0
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        Limpiar_Controles()
        txtRuc.Focus()
    End Sub

    Private Sub txtRuc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRuc.KeyPress
        Validar.Numeros(e)
    End Sub

    Private Sub txtRazonSocial_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRazonSocial.KeyPress
        Validar.LetrasconPunto(e)
    End Sub

    Private Sub txtRepresentante_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRepresentante.KeyPress
        Validar.Letras(e)
    End Sub

    Private Sub txtCelular_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCelular.KeyPress
        Validar.Numeros_con_Numeral(e)
    End Sub

    Private Sub txtTelefono_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        Validar.Numeros_con_Numeral(e)
    End Sub

    Private Sub txtEmail_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmail.KeyPress
        Validar.Espacio(e)
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If (keyData = Keys.Escape) Then
            Cerrar_Form()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub Cerrar_Form()
        If (txtDatos.Text.Trim = "" And txtRuc.Text.Trim = "" And txtRazonSocial.Text.Trim = "" And txtRepresentante.Text.Trim = "" And txtCelular.Text.Trim = "" And txtTelefono.Text.Trim = "" And txtDireccion.Text.Trim = "" And txtEmail.Text.Trim = "") Then
            Close()
        Else
            Dim fr As New Frm011_MensajedeConfirmación2
            fr.ShowDialog()
            If (Validar.Cerrar_form = 1) Then
                Close()
            End If
        End If
    End Sub

    Private Sub lb_min_Click(sender As Object, e As EventArgs) Handles lb_min.Click
        frm_inicio.minprovedores = True
        frm_inicio.Frm_provedores = Me

        frm_inicio.pn_principal.Controls.Clear()
        frm_inicio.pn_principal.Hide()
        frm_inicio.min_pn_provedores.BackColor = Color.LightSkyBlue
        Me.Hide()
    End Sub
End Class