Public Class Frm015_Configuraciones
    Dim ID
    Public frm_inicio As Frm_menu = New Frm_menu
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Pantalla1.BringToFront()
        Pantalla1.frm_inicio = frm_inicio
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Apagado1.BringToFront()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Seguridad1.BringToFront()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Caracteristica1.BringToFront()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Actualizacion1.BringToFront()
    End Sub

    Private Sub Frm015_Configuraciones_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave

    End Sub

    Private Sub Frm015_Configuraciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pantalla1.BringToFront()
        Pantalla1.frm_inicio = frm_inicio
        Me.SetBounds(58, 0, Screen.PrimaryScreen.Bounds.Width - 60, Screen.PrimaryScreen.Bounds.Height - 100)
    End Sub

    Private Sub lkbCerrar_Click(sender As Object, e As EventArgs) Handles lkbCerrar.Click
        frm_inicio.pn_principal.Controls.Clear()
        frm_inicio.pn_principal.Hide()

        Me.Close()
    End Sub
End Class