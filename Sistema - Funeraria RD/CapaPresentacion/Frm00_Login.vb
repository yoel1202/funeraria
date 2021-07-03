Imports System.IO
Imports CapaLogicaNegocio 'Importamos la capa lógica de negocio
Public Class Frm00_Login
    Public frm_inicio As Frm_menu = New Frm_menu

    Public FormActive As Integer = 0 'Creamos la variable pública FormActive para validar que no se abran varios forms a la vez
    Dim U As New clsUsuario 'Instanciamos la clase clsUsuario de la Capa Logica de Negocio para usar sus funciones
    Dim ruta As New CopiarImagen

    Private Sub Frm00_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label3.Text = "© " + Date.Today.Year.ToString() + " - Todos los derechos reservados"
        Dim busqueda = New StreamReader("configuracion.cfg")

        Dim cadena
        cadena = busqueda.ReadLine
        Do While (Not cadena Is Nothing)
            Dim campos As String() = cadena.Split(":")
            If campos(0).Equals("guardarusuario") And campos.Length > 2 Then

                txtusuario.Text = campos(2)

            ElseIf campos(0).Equals("guardarpass") And campos.Length > 2 Then

                txtClave.Text = campos(2)


            End If
            cadena = busqueda.ReadLine

        Loop


        busqueda.Close()
    End Sub

    Private Sub lkb_cerrar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lkb_cerrar.LinkClicked
        Application.Exit()
    End Sub

    Private Sub lkb_min_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lkb_min.LinkClicked
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        ErrorProvider1.Clear()
        If (txtusuario.Text = "") Then
            ErrorProvider1.SetError(txtusuario, "Ingrese Usuario")
        ElseIf (txtClave.Text = "") Then
            ErrorProvider1.SetError(txtClave, "Ingrese Clave")
        Else
            lblmsj.Visible = True
            'Evento para loguear
            Dim Mensaje As String = "" 'Variable para recuperar el mensaje del procedimiento almacenado de la BD

            Try
                U.Usuario = CStr(txtusuario.Text)
                U.Clave = CStr(txtClave.Text)
                Mensaje = U.Loguear()


                If (Mensaje = "Logueado Correctamente") Then
                    U.Usuario = txtusuario.Text
                    Validar.Codigo_Personal_Online = U.Devolver_Codigo_Personal()
                    Validar.usuario_online = txtusuario.Text
                    Validar.password = txtClave.Text
                    Timer1.Start()
                    lblmsj.Text = "Bienvenido Sr(a): " & txtusuario.Text
                    centrar_msj()
                    Dim rutaDestino As String = "C:\Funeraria"
                    Call ruta.crearDirectoriosBlanco(rutaDestino)
                Else


                    lblmsj.Text = Mensaje
                    centrar_msj()
                End If
            Catch ex As Exception
                clsMensaje.mostrar_mensaje(ex.Message, "error")
            End Try

        End If
    End Sub

    Dim contador = 0
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        contador += 1
        If (contador = 2) Then
            lblmsj.Text = "Iniciando el Sistema..."
            centrar_msj()
        ElseIf (contador = 3) Then
            Timer1.Stop()

            frm_inicio.Show()
            frm_inicio.ID = Validar.Codigo_Personal_Online
            Me.Close()
        End If

    End Sub

    Private Sub centrar_msj()
        lblmsj.Location = New Point((Me.Width - lblmsj.Width) / 2, (lblmsj.Location.Y))
    End Sub

    Private Sub txtClave_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Validar.Espacio(e)
    End Sub

    Private Sub txtusuario_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Validar.Espacio(e)
    End Sub

    Private Sub txtClave_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel_cabecera_Paint(sender As Object, e As PaintEventArgs) Handles Panel_cabecera.Paint

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        System.Diagnostics.Process.Start("D:\actualizacion\actualizacion.exe")
        Application.Exit()
    End Sub

    Private Sub txtClave_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClave.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btnIngresar_Click(sender, e)
        End If
    End Sub

    Private Sub txtusuario_TextChanged(sender As Object, e As EventArgs) Handles txtusuario.TextChanged

    End Sub

    Private Sub txtusuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtusuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btnIngresar_Click(sender, e)
        End If
    End Sub
End Class