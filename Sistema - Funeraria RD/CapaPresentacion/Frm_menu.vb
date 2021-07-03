Imports System.IO
Imports CapaLogicaNegocio

Public Class Frm_menu
    Public paso As Boolean = True
    Public pasar As Boolean = True
    Public ID As Integer = 100
    Public pnpersonal As New Panel
    Public frm_personal As Frm002_PersonalPrincipal
    Public Frm_productos As Frm003_ProductosyServicios
    Public Frm_cotizaciones As Frm004_PlanesFunerarios
    Public Frm_clientes As Frm005_Cliente
    Public Frm_difuntos As Frm006_Difunto
    Public Frm_provedores As Frm007_Proveedor
    Public Frm_compras As Frm008_Compras
    Public Frm_ventas As Frm009_Ventas
    Public Frm_creditos As Frm013_CreditoCobros
    Public Frm_contratos As Frm012_Contratos
    Public minpersonal As Boolean
    Public minproductos As Boolean
    Public mincotizaciones As Boolean
    Public minclientes As Boolean
    Public mindifuntos As Boolean
    Public minprovedores As Boolean
    Public mincompras As Boolean
    Public minventas As Boolean
    Public mincreditos As Boolean
    Public mincontratos As Boolean
    Dim U As New clsUsuario 'Instanciamos la clase clsUsuario de la Capa Logica de Negocio para usar sus funciones
    'Private Sub comprobar_focus(ByVal valor As Integer)
    '    Select Case (valor)
    '        Case 1
    '            pintar_buttons()
    '            pn_personal.BackColor = Color.FromArgb(0, 122, 204)
    '        Case 2
    '            pintar_buttons()
    '            btn2.BackColor = Color.FromArgb(0, 122, 204)
    '        Case 3
    '            pintar_buttons()
    '            btn3.BackColor = Color.FromArgb(0, 122, 204)
    '        Case 4
    '            pintar_buttons()
    '            btn4.BackColor = Color.FromArgb(0, 122, 204)
    '        Case 5
    '            pintar_buttons()
    '            btn5.BackColor = Color.FromArgb(0, 122, 204)
    '        Case 6
    '            pintar_buttons()
    '            btn6.BackColor = Color.FromArgb(0, 122, 204)
    '        Case 7
    '            pintar_buttons()
    '            btn7.BackColor = Color.FromArgb(0, 122, 204)
    '        Case 8
    '            pintar_buttons()
    '            btn8.BackColor = Color.FromArgb(0, 122, 204)

    '    End Select

    'End Sub
    'Private Sub pintar_buttons()
    '    btn1.BackColor = Color.FromArgb(103, 103, 103)
    '    btn2.BackColor = Color.FromArgb(103, 103, 103)
    '    btn3.BackColor = Color.FromArgb(103, 103, 103)
    '    btn4.BackColor = Color.FromArgb(103, 103, 103)
    '    btn5.BackColor = Color.FromArgb(103, 103, 103)
    '    btn6.BackColor = Color.FromArgb(103, 103, 103)
    '    btn7.BackColor = Color.FromArgb(103, 103, 103)
    '    btn8.BackColor = Color.FromArgb(103, 103, 103)
    'End Sub
    Private Sub Panel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pn_personal(sender As Object, e As EventArgs) Handles pn_personales.Click
        If (pasar) Then
            U.CodigoPersona = CStr(Codigo_Personal_Online)
            U.tipo = "personal"
            Dim permiso As String = U.Devolver_permisos()

            If (permiso = "Todos" Or permiso = "Visualizar") Then
                If (Frm00_Login.FormActive = 0) Then
                    'comprobar_focus(1)
                    Dim myForm As Frm002_PersonalPrincipal = New Frm002_PersonalPrincipal()

                    myForm.TopLevel = False
                    myForm.AutoScroll = True
                    pn_principal.Controls.Add(myForm)
                    myForm.frm_inicio = Me
                    myForm.Show()

                    pn_principal.Show()

                End If
            Else
                clsMensaje.mostrar_mensaje("Solo el administrador tiene acceso a esta Opción", "error")
            End If
        Else
            U.CodigoPersona = CStr(Codigo_Personal_Online)
            U.tipo = "credito"
            Dim permiso As String = U.Devolver_permisos()

            If (permiso = "Todos" Or permiso = "Visualizar") Then
                If (Frm00_Login.FormActive = 0) Then


                    Dim myForm As Frm013_CreditoCobros = New Frm013_CreditoCobros()
                    myForm.Size = New Point(Screen.PrimaryScreen.Bounds.Width - 45, Screen.PrimaryScreen.Bounds.Height - 150)
                    myForm.TopLevel = False
                    myForm.AutoScroll = True
                    pn_principal.Controls.Add(myForm)
                    myForm.frm_inicio = Me
                    myForm.Show()
                    pn_principal.Show()
                End If
            End If
        End If

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim cerrar = New Frm011_MensajedeConfirmación()
        cerrar.Show()


    End Sub

    Private Sub Frm_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lb_nombre.Text = usuario_online

        Timer2.Start()
        PictureBox1.SetBounds(Screen.PrimaryScreen.Bounds.Width - 150, 15, PictureBox1.Width, PictureBox1.Height)
        pb_boton_inicio.SetBounds(0, Screen.PrimaryScreen.Bounds.Height - 70, pb_boton_inicio.Width, pb_boton_inicio.Height)
        PictureBox3.SetBounds(Screen.PrimaryScreen.Bounds.Width - 60, 15, PictureBox3.Width, PictureBox3.Height)
        PictureBox4.SetBounds(10, 30, PictureBox4.Width, PictureBox4.Height)
        pb_siguiente.SetBounds(Screen.PrimaryScreen.Bounds.Width - 100, Me.Height - 170, pb_siguiente.Width + 20, pb_siguiente.Height + 20)
        Label1.SetBounds(100, 30, Label1.Width, Label1.Height)
        lb_nombre.SetBounds(Screen.PrimaryScreen.Bounds.Width - 310, PictureBox1.Height - 20, lb_nombre.Width, lb_nombre.Height)

        lb_fecha.SetBounds(Screen.PrimaryScreen.Bounds.Width - 145, Me.Height - 70, lb_fecha.Width, lb_fecha.Height)
        Label12.SetBounds(Screen.PrimaryScreen.Bounds.Width - 60, PictureBox3.Height + 15, Label12.Width, Label12.Height)
        lb_cedula.SetBounds(Screen.PrimaryScreen.Bounds.Width - 245, PictureBox1.Height, lb_cedula.Width, lb_cedula.Height)


        pn_principal.SetBounds(0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
        pn_personales.SetBounds(PictureBox4.Width + 50, PictureBox4.Height + 40, pn_personales.Width, pn_personales.Height)

        pn_productos.SetBounds(pn_personales.Width + 200, PictureBox4.Height + 40, pn_productos.Width, pn_productos.Height)
        Pn_planes.SetBounds(pn_productos.Width + 500, PictureBox4.Height + 40, Pn_planes.Width, Pn_planes.Height)
        pn_clientes.SetBounds(pn_productos.Width + 800, PictureBox4.Height + 40, Pn_planes.Width, Pn_planes.Height)
        pn_difuntos.SetBounds(PictureBox4.Width + 50, pn_personales.Height + 200, pn_difuntos.Width, pn_difuntos.Height)
        pn_provedor.SetBounds(pn_difuntos.Width + 200, pn_personales.Height + 200, pn_provedor.Width, pn_provedor.Height)
        pn_compras.SetBounds(pn_provedor.Width + 500, pn_personales.Height + 200, pn_provedor.Width, pn_provedor.Height)
        pn_ventas.SetBounds(pn_provedor.Width + 800, pn_personales.Height + 200, pn_provedor.Width, pn_provedor.Height)
        pn_principal.Hide()


        Timer1.Start()
        'Dim ds As DataSet = conexion.sqlconsulta("Select id_empleado,nombre,apellido,cedula,telefono,foto from tbl_empleados INNER JOIN tbl_usuarios on id_empleado=fk_empleado where id_usuario='" + ID.ToString() + "'")
        'Label2.Text = ds.Tables(0).Rows(0).Item(1).ToString()
        'Label3.Text = ds.Tables(0).Rows(0).Item(2).ToString()

        'Try
        '    PictureBox1.BackgroundImage = Image.FromFile(ds.Tables(0).Rows(0).Item(5).ToString())
        '    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        'Catch ex As Exception
        '    PictureBox1.BackgroundImage = Image.FromFile("perfiles\profile.png")
        '    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        'End Try
        If File.Exists("configuracion.cfg") Then

            Dim busqueda = New StreamReader("configuracion.cfg")

            Dim cadena
            cadena = busqueda.ReadLine
            Do While (Not cadena Is Nothing)
                Dim campos As String() = cadena.Split(":")
                If campos(0).Equals("Fondo") Then
                    Me.BackgroundImage = Image.FromFile("fondo/" + campos(1))
                    Me.BackgroundImageLayout = ImageLayout.Stretch
                End If
                cadena = busqueda.ReadLine
            Loop


            busqueda.Close()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles pb_boton_inicio.Click
        If pn_principal.Visible = True Then
            pn_principal.Controls.Clear()

            pn_principal.Hide()
            If pasar = True Then
                pn_personales.Show()
                pn_productos.Show()
                Pn_planes.Show()
                pn_difuntos.Show()
                pn_provedor.Show()
                pn_compras.Show()
                pn_clientes.Show()
                pn_ventas.Show()
            Else
                pn_personales.Show()
                pn_difuntos.Show()
                pn_provedor.Show()
                pn_productos.Show()
            End If
            paso = False

        End If

        If paso = True Then

            If pasar = True Then
                pn_personales.Hide()
                pn_productos.Hide()
                Pn_planes.Hide()
                pn_difuntos.Hide()
                pn_provedor.Hide()
                pn_compras.Hide()
                pn_clientes.Hide()
                pn_ventas.Hide()

            Else
                pn_personales.Hide()
                pn_difuntos.Hide()
                pn_provedor.Hide()
                pn_productos.Hide()
            End If
            paso = False
        Else
            If pasar = True Then
                pn_personales.Show()
                pn_productos.Show()
                Pn_planes.Show()
                pn_difuntos.Show()
                pn_provedor.Show()
                pn_compras.Show()
                pn_clientes.Show()
                pn_ventas.Show()
            Else
                pn_personales.Show()
                pn_difuntos.Show()
                pn_provedor.Show()
                pn_productos.Show()
            End If

            paso = True


        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lb_fecha.Text = DateTime.Now.ToLongDateString()
        Label12.Text = DateTime.Now.ToLongTimeString()
    End Sub

    Private Sub pn_empleados_Click(sender As Object, e As EventArgs) Handles pn_productos.Click
        If (pasar) Then
            U.CodigoPersona = CStr(Codigo_Personal_Online)
            U.tipo = "producto"
            Dim permiso As String = U.Devolver_permisos()

            If (permiso = "Todos" Or permiso = "Visualizar") Then
                If (Frm00_Login.FormActive = 0) Then


                    Dim myForm As Frm003_ProductosyServicios = New Frm003_ProductosyServicios()
                    myForm.Size = New Point(Screen.PrimaryScreen.Bounds.Width - 45, Screen.PrimaryScreen.Bounds.Height - 150)
                    myForm.TopLevel = False
                    myForm.AutoScroll = True
                    pn_principal.Controls.Add(myForm)
                    myForm.frm_inicio = Me
                    myForm.Show()
                    myForm.frm_inicio = Me
                    pn_principal.Show()
                End If
            Else
                clsMensaje.mostrar_mensaje("no cuenta con permisos tiene acceso a esta Opción", "error")
            End If
        Else
            If (Frm00_Login.FormActive = 0) Then


                Dim myForm As Frm014_Reportes = New Frm014_Reportes()
                myForm.Size = New Point(Screen.PrimaryScreen.Bounds.Width - 45, Screen.PrimaryScreen.Bounds.Height - 150)
                myForm.TopLevel = False
                myForm.AutoScroll = True
                pn_principal.Controls.Add(myForm)
                myForm.frm_inicio = Me
                myForm.Show()
                pn_principal.Show()
            End If
        End If
    End Sub

    Private Sub Pn_pagos_Click(sender As Object, e As EventArgs) Handles Pn_planes.Click

        U.CodigoPersona = CStr(Codigo_Personal_Online)
        U.tipo = "plan"
        Dim permiso As String = U.Devolver_permisos()

        If (permiso = "Todos" Or permiso = "Visualizar") Then

            If (Frm00_Login.FormActive = 0) Then


                Dim myForm As Frm004_PlanesFunerarios = New Frm004_PlanesFunerarios()
                myForm.Size = New Point(Screen.PrimaryScreen.Bounds.Width - 45, Screen.PrimaryScreen.Bounds.Height - 150)
                myForm.TopLevel = False
                myForm.AutoScroll = True
                pn_principal.Controls.Add(myForm)
                myForm.frm_inicio = Me
                myForm.Show()
                pn_principal.Show()
            End If
        Else
            clsMensaje.mostrar_mensaje("no cuenta con permisos tiene acceso a esta Opción", "error")
        End If
    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles pn_clientes.Click
        U.CodigoPersona = CStr(Codigo_Personal_Online)
        U.tipo = "producto"
        Dim permiso As String = U.Devolver_permisos()

        If (permiso = "Todos" Or permiso = "cliente") Then
            If (Frm00_Login.FormActive = 0) Then


                Dim myForm As Frm005_Cliente = New Frm005_Cliente()
                myForm.Size = New Point(Screen.PrimaryScreen.Bounds.Width - 45, Screen.PrimaryScreen.Bounds.Height - 150)
                myForm.TopLevel = False
                myForm.AutoScroll = True
                pn_principal.Controls.Add(myForm)
                myForm.frm_inicio = Me
                myForm.Show()
                pn_principal.Show()
            End If
        Else
            clsMensaje.mostrar_mensaje("no cuenta con permisos tiene acceso a esta Opción", "error")
        End If
    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles pn_difuntos.Click
        If (pasar) Then

            U.CodigoPersona = CStr(Codigo_Personal_Online)
            U.tipo = "difunto"
            Dim permiso As String = U.Devolver_permisos()

            If (permiso = "Todos" Or permiso = "Visualizar") Then
                If (Frm00_Login.FormActive = 0) Then


                    Dim myForm As Frm006_Difunto = New Frm006_Difunto()
                    myForm.Size = New Point(Screen.PrimaryScreen.Bounds.Width - 45, Screen.PrimaryScreen.Bounds.Height - 150)
                    myForm.TopLevel = False
                    myForm.AutoScroll = True
                    pn_principal.Controls.Add(myForm)
                    myForm.frm_inicio = Me
                    myForm.Show()
                    pn_principal.Show()
                End If
            Else
                clsMensaje.mostrar_mensaje("no cuenta con permisos tiene acceso a esta Opción", "error")
            End If




        Else
            U.CodigoPersona = CStr(Codigo_Personal_Online)
            U.tipo = "contrato"
            Dim permiso As String = U.Devolver_permisos()

            If (permiso = "Todos" Or permiso = "Visualizar") Then

                If (Frm00_Login.FormActive = 0) Then


                    Dim myForm As Frm012_Contratos = New Frm012_Contratos()
                    myForm.Plan.Clear()
                    myForm.Size = New Point(Screen.PrimaryScreen.Bounds.Width - 45, Screen.PrimaryScreen.Bounds.Height - 150)
                    myForm.TopLevel = False
                    myForm.AutoScroll = True
                    pn_principal.Controls.Add(myForm)
                    myForm.frm_inicio = Me
                    myForm.Show()
                    pn_principal.Show()
                End If
            End If
        End If
    End Sub

    Private Sub Panel5_Click(sender As Object, e As EventArgs) Handles pn_provedor.Click
        If (pasar) Then

            U.CodigoPersona = CStr(Codigo_Personal_Online)
            U.tipo = "producto"
            Dim permiso As String = U.Devolver_permisos()

            If (permiso = "Todos" Or permiso = "provedor") Then
                If (Frm00_Login.FormActive = 0) Then


                    Dim myForm As Frm007_Proveedor = New Frm007_Proveedor()
                    myForm.Size = New Point(Screen.PrimaryScreen.Bounds.Width - 45, Screen.PrimaryScreen.Bounds.Height - 150)
                    myForm.TopLevel = False
                    myForm.AutoScroll = True
                    pn_principal.Controls.Add(myForm)
                    myForm.frm_inicio = Me
                    myForm.Show()
                    pn_principal.Show()
                End If
            Else
                clsMensaje.mostrar_mensaje("no cuenta con permisos tiene acceso a esta Opción", "error")
            End If
        Else

            If (Frm00_Login.FormActive = 0) Then


                Dim myForm As Frm015_Configuraciones = New Frm015_Configuraciones()
                myForm.Size = New Point(Screen.PrimaryScreen.Bounds.Width - 45, Screen.PrimaryScreen.Bounds.Height - 150)
                myForm.Seguridad1.ID = ID
                myForm.TopLevel = False
                myForm.AutoScroll = True
                pn_principal.Controls.Add(myForm)
                myForm.frm_inicio = Me
                myForm.Show()
                pn_principal.Show()
            End If
        End If

    End Sub

    Private Sub pn_configuracion_Click(sender As Object, e As EventArgs) Handles pn_compras.Click
        U.CodigoPersona = CStr(Codigo_Personal_Online)
        U.tipo = "compra"
        Dim permiso As String = U.Devolver_permisos()

        If (permiso = "Todos" Or permiso = "Visualizar") Then
            If (Frm00_Login.FormActive = 0) Then

                Dim myForm As Frm008_Compras = New Frm008_Compras()
                myForm.Size = New Point(Screen.PrimaryScreen.Bounds.Width - 45, Screen.PrimaryScreen.Bounds.Height - 150)
                myForm.TopLevel = False
                myForm.AutoScroll = True
                pn_principal.Controls.Add(myForm)
                myForm.frm_inicio = Me
                myForm.Show()
                pn_principal.Show()
            End If
        Else
            clsMensaje.mostrar_mensaje("no cuenta con permisos tiene acceso a esta Opción", "error")
        End If
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles pn_ventas.Click
        U.CodigoPersona = CStr(Codigo_Personal_Online)
        U.tipo = "venta"
        Dim permiso As String = U.Devolver_permisos()

        If (permiso = "Todos" Or permiso = "Visualizar") Then
            If (Frm00_Login.FormActive = 0) Then


                Dim myForm As Frm009_Ventas = New Frm009_Ventas()
                myForm.Size = New Point(Screen.PrimaryScreen.Bounds.Width - 45, Screen.PrimaryScreen.Bounds.Height - 150)
                myForm.Plan.Clear()
                myForm.TopLevel = False
                myForm.AutoScroll = True
                pn_principal.Controls.Add(myForm)
                myForm.frm_inicio = Me
                myForm.Show()
                pn_principal.Show()
            End If
        Else
            clsMensaje.mostrar_mensaje("no cuenta con permisos tiene acceso a esta Opción", "error")
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles pb_siguiente.Click
        If pasar Then

            Pn_planes.Hide()
            pn_compras.Hide()
            pn_clientes.Hide()
            pn_ventas.Hide()
            pasar = False
            pb_siguiente.BackgroundImage = Image.FromFile("C:\Funeraria/Menu/left.png")
            pn_personales.BackgroundImage = Image.FromFile("C:\Funeraria/Menu/pagos 1.png")
            lb_personal.Text = "Credito y Cobro"
            pn_difuntos.BackgroundImage = Image.FromFile("C:\Funeraria/Menu/contrato 1.png")
            lb_difuntos.Text = "Contratos"

            pn_productos.BackgroundImage = Image.FromFile("C:\Funeraria/Menu/report1.png")
            lb_productos.Text = "Reportes"
            pn_provedor.BackgroundImage = Image.FromFile("C:\Funeraria/Menu/configuracion (1).png")
            lb_provedores.Text = "Configuracion"
        Else

            Pn_planes.Show()
            pn_compras.Show()
            pn_clientes.Show()
            pn_ventas.Show()
            pasar = True
            pb_siguiente.BackgroundImage = Image.FromFile("C:\Funeraria/Menu/right.png")
            pn_personales.BackgroundImage = Image.FromFile("C:\Funeraria/Menu/clientes 1.png")
            lb_personal.Text = "Personal"
            pn_difuntos.BackgroundImage = Image.FromFile("C:\Funeraria/Menu/difuntos.png")
            lb_difuntos.Text = "Difuntos"

            pn_productos.BackgroundImage = Image.FromFile("C:\Funeraria/Menu/productos 1.png")
            lb_productos.Text = "Productos y Servicios"
            pn_provedor.BackgroundImage = Image.FromFile("C:\Funeraria/Menu/provedor 1.png")
            lb_provedores.Text = "Provedores"
        End If
    End Sub

    Private Sub pn_personales_MouseMove(sender As Object, e As MouseEventArgs) Handles pn_personales.MouseMove
        If pasar Then
            pn_personales.BackgroundImage = Image.FromFile("C:\Funeraria/Menu/clientes 2.png")
        Else
            pn_personales.BackgroundImage = Image.FromFile("C:\Funeraria/Menu/pagos 2.png")
        End If
    End Sub

    Private Sub pn_personales_MouseLeave(sender As Object, e As EventArgs) Handles pn_personales.MouseLeave
        If pasar Then
            pn_personales.BackgroundImage = Image.FromFile("C:\Funeraria/Menu/clientes 1.png")
        Else
            pn_personales.BackgroundImage = Image.FromFile("C:\Funeraria/Menu/pagos 1.png")
        End If
    End Sub

    Private Sub pn_difuntos_MouseMove(sender As Object, e As MouseEventArgs) Handles pn_difuntos.MouseMove
        If pasar Then
            pn_difuntos.BackgroundImage = Image.FromFile("C:\Funeraria/Menu/difunto 2.png")
        Else
            pn_difuntos.BackgroundImage = Image.FromFile("C:\Funeraria/Menu/contrato 2.png")
        End If
    End Sub

    Private Sub pn_difuntos_MouseLeave(sender As Object, e As EventArgs) Handles pn_difuntos.MouseLeave
        If pasar Then
            pn_difuntos.BackgroundImage = Image.FromFile("C:\Funeraria/Menu/difuntos.png")
        Else
            pn_difuntos.BackgroundImage = Image.FromFile("C:\Funeraria/Menu/contrato 1.png")
        End If
    End Sub

    Private Sub pn_productos_MouseMove(sender As Object, e As MouseEventArgs) Handles pn_productos.MouseMove
        If pasar Then
            pn_productos.BackgroundImage = Image.FromFile("C:\Funeraria/Menu/productos 2.png")
        Else
            pn_productos.BackgroundImage = Image.FromFile("C:\Funeraria/Menu/report2.png")
        End If
    End Sub

    Private Sub pn_productos_MouseLeave(sender As Object, e As EventArgs) Handles pn_productos.MouseLeave
        If pasar Then
            pn_productos.BackgroundImage = Image.FromFile("C:\Funeraria/Menu/productos 1.png")
        Else
            pn_productos.BackgroundImage = Image.FromFile("C:\Funeraria/Menu/report1.png")
        End If
    End Sub

    Private Sub pn_provedor_MouseMove(sender As Object, e As MouseEventArgs) Handles pn_provedor.MouseMove
        If pasar Then
            pn_provedor.BackgroundImage = Image.FromFile("C:\Funeraria/Menu/provedor 2.png")
        Else
            pn_provedor.BackgroundImage = Image.FromFile("C:\Funeraria/Menu/configuracion (2).png")
        End If
    End Sub

    Private Sub pn_provedor_MouseLeave(sender As Object, e As EventArgs) Handles pn_provedor.MouseLeave
        If pasar Then
            pn_provedor.BackgroundImage = Image.FromFile("C:\Funeraria/Menu/provedor 1.png")
        Else
            pn_provedor.BackgroundImage = Image.FromFile("C:\Funeraria/Menu/configuracion (1).png")
        End If
    End Sub

    Private Sub Pn_planes_MouseMove(sender As Object, e As MouseEventArgs) Handles Pn_planes.MouseMove
        Pn_planes.BackgroundImage = Image.FromFile("C:\Funeraria/Menu/cotizaciones 2.png")
    End Sub

    Private Sub Pn_planes_MouseLeave(sender As Object, e As EventArgs) Handles Pn_planes.MouseLeave
        Pn_planes.BackgroundImage = Image.FromFile("C:\Funeraria/Menu/cotizaciones 1.png")
    End Sub

    Private Sub pn_compras_MouseMove(sender As Object, e As MouseEventArgs) Handles pn_compras.MouseMove
        pn_compras.BackgroundImage = Image.FromFile("C:\Funeraria/Menu/compras 2.png")
    End Sub

    Private Sub pn_compras_MouseLeave(sender As Object, e As EventArgs) Handles pn_compras.MouseLeave
        pn_compras.BackgroundImage = Image.FromFile("C:\Funeraria/Menu/compras 1.png")
    End Sub

    Private Sub pn_clientes_MouseMove(sender As Object, e As MouseEventArgs) Handles pn_clientes.MouseMove
        pn_clientes.BackgroundImage = Image.FromFile("C:\Funeraria/Menu/cliente 2.png")
    End Sub

    Private Sub pn_clientes_MouseLeave(sender As Object, e As EventArgs) Handles pn_clientes.MouseLeave
        pn_clientes.BackgroundImage = Image.FromFile("C:\Funeraria/Menu/cliente 1.png")
    End Sub

    Private Sub pn_ventas_MouseMove(sender As Object, e As MouseEventArgs) Handles pn_ventas.MouseMove
        pn_ventas.BackgroundImage = Image.FromFile("C:\Funeraria/Menu/ventas 2.png")
    End Sub

    Private Sub pn_ventas_MouseLeave(sender As Object, e As EventArgs) Handles pn_ventas.MouseLeave
        pn_ventas.BackgroundImage = Image.FromFile("C:\Funeraria/Menu/ventas 1.png")
    End Sub

    Private Sub min_pn_personal_Click(sender As Object, e As EventArgs) Handles min_pn_personal.Click

        If minpersonal = True Then
            pn_principal.Controls.Clear()
            frm_personal.TopLevel = False
            frm_personal.AutoScroll = True
            pn_principal.Controls.Add(frm_personal)
            frm_personal.frm_inicio = Me
            frm_personal.Show()

            pn_principal.Show()
        End If
    End Sub

    Private Sub min_pn_productos_Click(sender As Object, e As EventArgs) Handles min_pn_productos.Click
        If minproductos = True Then
            pn_principal.Controls.Clear()
            Frm_productos.TopLevel = False
            Frm_productos.AutoScroll = True
            pn_principal.Controls.Add(Frm_productos)
            Frm_productos.frm_inicio = Me
            Frm_productos.Show()

            pn_principal.Show()
        End If
    End Sub

    Private Sub min_pn_cotizaciones_Click(sender As Object, e As EventArgs) Handles min_pn_cotizaciones.Click
        If mincotizaciones = True Then
            pn_principal.Controls.Clear()
            Frm_cotizaciones.TopLevel = False
            Frm_cotizaciones.AutoScroll = True
            pn_principal.Controls.Add(Frm_cotizaciones)
            Frm_cotizaciones.frm_inicio = Me
            Frm_cotizaciones.Show()

            pn_principal.Show()
        End If
    End Sub

    Private Sub min_pn_clientes_Click(sender As Object, e As EventArgs) Handles min_pn_clientes.Click
        If minclientes = True Then
            pn_principal.Controls.Clear()
            Frm_clientes.TopLevel = False
            Frm_clientes.AutoScroll = True
            pn_principal.Controls.Add(Frm_clientes)
            Frm_clientes.frm_inicio = Me
            Frm_clientes.Show()

            pn_principal.Show()
        End If
    End Sub

    Private Sub min_pn_difuntos_Click(sender As Object, e As EventArgs) Handles min_pn_difuntos.Click
        If mindifuntos = True Then
            pn_principal.Controls.Clear()
            Frm_difuntos.TopLevel = False
            Frm_difuntos.AutoScroll = True
            pn_principal.Controls.Add(Frm_difuntos)
            Frm_difuntos.frm_inicio = Me
            Frm_difuntos.Show()

            pn_principal.Show()
        End If
    End Sub

    Private Sub min_pn_provedores_Click(sender As Object, e As EventArgs) Handles min_pn_provedores.Click
        If minprovedores = True Then
            pn_principal.Controls.Clear()
            Frm_provedores.TopLevel = False
            Frm_provedores.AutoScroll = True
            pn_principal.Controls.Add(Frm_provedores)
            Frm_provedores.frm_inicio = Me
            Frm_provedores.Show()

            pn_principal.Show()
        End If
    End Sub

    Private Sub min_pn_compras_Click(sender As Object, e As EventArgs) Handles min_pn_compras.Click
        If mincompras = True Then
            pn_principal.Controls.Clear()
            Frm_compras.TopLevel = False
            Frm_compras.AutoScroll = True
            pn_principal.Controls.Add(Frm_compras)
            Frm_compras.frm_inicio = Me
            Frm_compras.Show()

            pn_principal.Show()
        End If
    End Sub

    Private Sub min_pn_ventas_Click(sender As Object, e As EventArgs) Handles min_pn_ventas.Click
        If minventas = True Then
            pn_principal.Controls.Clear()
            Frm_ventas.TopLevel = False
            Frm_ventas.AutoScroll = True
            pn_principal.Controls.Add(Frm_ventas)
            Frm_ventas.frm_inicio = Me
            Frm_ventas.Show()

            pn_principal.Show()
        End If
    End Sub

    Private Sub min_pn_creditos_Click(sender As Object, e As EventArgs) Handles min_pn_creditos.Click
        If mincreditos = True Then
            pn_principal.Controls.Clear()
            Frm_creditos.TopLevel = False
            Frm_creditos.AutoScroll = True
            pn_principal.Controls.Add(Frm_creditos)
            Frm_creditos.frm_inicio = Me
            Frm_creditos.Show()

            pn_principal.Show()
        End If
    End Sub

    Private Sub min_pn_contratos_Click(sender As Object, e As EventArgs) Handles min_pn_contratos.Click
        If mincontratos = True Then
            pn_principal.Controls.Clear()
            Frm_contratos.TopLevel = False
            Frm_contratos.AutoScroll = True
            pn_principal.Controls.Add(Frm_contratos)
            Frm_contratos.frm_inicio = Me
            Frm_contratos.Show()

            pn_principal.Show()
        End If
    End Sub

    Private Sub Frm_menu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim cerrar = New Frm011_MensajedeConfirmación()
        cerrar.Show()
    End Sub
End Class