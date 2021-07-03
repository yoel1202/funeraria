Public Class actualizacion
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        System.Diagnostics.Process.Start("D:\actualizacion\actualizacion.exe")
        Application.Exit()
    End Sub
End Class
