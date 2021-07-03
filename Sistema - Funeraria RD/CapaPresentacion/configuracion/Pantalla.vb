Imports System.IO

Public Class Pantalla
    Dim caso = 6
    Public frm_inicio As Frm_menu = New Frm_menu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_inicio.BackgroundImage = PictureBox6.BackgroundImage
        frm_inicio.BackgroundImageLayout = ImageLayout.Stretch

        Select Case caso
            Case 1
                cambiarfondo("fondo 1.jpg")
            Case 2
                cambiarfondo("fondo 2.jpg")
            Case 3
                cambiarfondo("fondo 3.jpg")
            Case 4
                cambiarfondo("fondo 4.jpg")
            Case 5
                cambiarfondo("fondo 5.jpg")
        End Select
    End Sub
    Sub cambiarfondo(ByRef pic As String)
        If File.Exists("configuracion.cfg") Then
            Dim busqueda = New StreamReader("configuracion.cfg")
            Dim temporal = New StreamWriter("temporal.cfg", True)

            Dim cadena
            cadena = busqueda.ReadLine
            Do While (Not cadena Is Nothing)
                Dim campos As String() = cadena.Split(":")
                If campos(0).Equals("Fondo") Then
                    temporal.WriteLine("Fondo:" + pic)
                ElseIf campos(0).Equals("guardarusuario") And campos.Length > 2 Then

                    temporal.WriteLine(campos(0) + ":" + campos(1) + ":" + campos(2))
                ElseIf campos(0).Equals("guardarpass") And campos.Length > 2 Then

                    temporal.WriteLine(campos(0) + ":" + campos(1) + ":" + campos(2))
                Else

                    temporal.WriteLine(campos(0) + ":" + campos(1))
                End If
                cadena = busqueda.ReadLine
            Loop

            temporal.Close()
            busqueda.Close()
            File.Delete("configuracion.cfg")
            File.Move("temporal.cfg", "configuracion.cfg")
        End If
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.jpg;*.png)|*.jpg;*.png"
        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then

            PictureBox6.BackgroundImage = Image.FromFile(opf.FileName)
            PictureBox6.BackgroundImageLayout = ImageLayout.Stretch
            FileCopy(opf.FileName, "fondo\fondo 5.jpg")
            caso = 5
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        PictureBox6.BackgroundImage = PictureBox7.BackgroundImage
        caso = 1
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        PictureBox6.BackgroundImage = PictureBox8.BackgroundImage
        caso = 2
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        PictureBox6.BackgroundImage = PictureBox9.BackgroundImage
        caso = 3
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        PictureBox6.BackgroundImage = PictureBox10.BackgroundImage
        caso = 4
    End Sub
End Class
