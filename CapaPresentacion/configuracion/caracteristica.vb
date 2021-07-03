Public Class caracteristica
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        If ComboBox1.SelectedIndex > 0 And ComboBox2.SelectedIndex > 0 Then
            My.Forms.Frm00_Login.frm_inicio.Label1.Font = New Font(ComboBox2.SelectedItem.ToString(), My.Forms.Frm00_Login.frm_inicio.Label1.Font.Size + ComboBox1.SelectedItem, FontStyle.Regular)
            'My.Forms.Frm00_Login.frm_inicio.Label2.Font = New Font(ComboBox2.SelectedItem.ToString(), My.Forms.Frm00_Login.frm_inicio.Label2.Font.Size + ComboBox1.SelectedItem, FontStyle.Regular)
            'My.Forms.Frm00_Login.frm_inicio.Label3.Font = New Font(ComboBox2.SelectedItem.ToString(), My.Forms.Frm00_Login.frm_inicio.Label3.Font.Size + ComboBox1.SelectedItem, FontStyle.Regular)
            'My.Forms.Frm00_Login.frm_inicio.Label4.Font = New Font(ComboBox2.SelectedItem.ToString(), My.Forms.Frm00_Login.frm_inicio.Label4.Font.Size + ComboBox1.SelectedItem, FontStyle.Regular)
            'My.Forms.Frm00_Login.frm_inicio.Label11.Font = New Font(ComboBox2.SelectedItem.ToString(), My.Forms.Frm00_Login.frm_inicio.Label11.Font.Size + ComboBox1.SelectedItem, FontStyle.Regular)
            My.Forms.Frm00_Login.frm_inicio.Label12.Font = New Font(ComboBox2.SelectedItem.ToString(), My.Forms.Frm00_Login.frm_inicio.Label12.Font.Size + ComboBox1.SelectedItem, FontStyle.Regular)
        ElseIf ComboBox2.SelectedIndex = 0 And ComboBox1.SelectedIndex > 0 Then
            My.Forms.Frm00_Login.frm_inicio.Label1.Font = New Font(My.Forms.Frm00_Login.frm_inicio.Label1.Name, My.Forms.Frm00_Login.frm_inicio.Label1.Font.Size + ComboBox1.SelectedItem, FontStyle.Regular)
            'My.Forms.Frm00_Login.frm_inicio.Label2.Font = New Font(My.Forms.Frm00_Login.frm_inicio.Label2.Name, My.Forms.Frm00_Login.frm_inicio.Label2.Font.Size + ComboBox1.SelectedItem, FontStyle.Regular)
            'My.Forms.Frm00_Login.frm_inicio.Label3.Font = New Font(My.Forms.Frm00_Login.frm_inicio.Label3.Name, My.Forms.Frm00_Login.frm_inicio.Label3.Font.Size + ComboBox1.SelectedItem, FontStyle.Regular)
            'My.Forms.Frm00_Login.frm_inicio.Label4.Font = New Font(My.Forms.Frm00_Login.frm_inicio.Label4.Name, My.Forms.Frm00_Login.frm_inicio.Label4.Font.Size + ComboBox1.SelectedItem, FontStyle.Regular)
            'My.Forms.Frm00_Login.frm_inicio.Label11.Font = New Font(My.Forms.Frm00_Login.frm_inicio.Label11.Name, My.Forms.Frm00_Login.frm_inicio.Label11.Font.Size + ComboBox1.SelectedItem, FontStyle.Regular)
            My.Forms.Frm00_Login.frm_inicio.Label12.Font = New Font(My.Forms.Frm00_Login.frm_inicio.Label12.Name, My.Forms.Frm00_Login.frm_inicio.Label12.Font.Size + ComboBox1.SelectedItem, FontStyle.Regular)
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged

        Try
            If ComboBox3.SelectedIndex > 0 And ComboBox2.SelectedIndex > 0 Then
                My.Forms.Frm00_Login.frm_inicio.Label1.Font = New Font(ComboBox2.SelectedItem.ToString(), My.Forms.Frm00_Login.frm_inicio.Label1.Font.Size - ComboBox3.SelectedItem, FontStyle.Regular)
                'My.Forms.Frm00_Login.frm_inicio.Label2.Font = New Font(ComboBox2.SelectedItem.ToString(), My.Forms.Frm00_Login.frm_inicio.Label2.Font.Size - ComboBox3.SelectedItem, FontStyle.Regular)
                'My.Forms.Frm00_Login.frm_inicio.Label3.Font = New Font(ComboBox2.SelectedItem.ToString(), My.Forms.Frm00_Login.frm_inicio.Label3.Font.Size - ComboBox3.SelectedItem, FontStyle.Regular)
                'My.Forms.Frm00_Login.frm_inicio.Label4.Font = New Font(ComboBox2.SelectedItem.ToString(), My.Forms.Frm00_Login.frm_inicio.Label4.Font.Size - ComboBox3.SelectedItem, FontStyle.Regular)
                'My.Forms.Frm00_Login.frm_inicio.Label11.Font = New Font(ComboBox2.SelectedItem.ToString(), My.Forms.Frm00_Login.frm_inicio.Label11.Font.Size - ComboBox3.SelectedItem, FontStyle.Regular)
                'My.Forms.Frm00_Login.frm_inicio.Label12.Font = New Font(ComboBox2.SelectedItem.ToString(), My.Forms.Frm00_Login.frm_inicio.Label12.Font.Size - ComboBox3.SelectedItem, FontStyle.Regular)
            ElseIf ComboBox2.SelectedIndex = 0 And ComboBox3.SelectedIndex > 0 Then
                My.Forms.Frm00_Login.frm_inicio.Label1.Font = New Font(My.Forms.Frm00_Login.frm_inicio.Label1.Name, My.Forms.Frm00_Login.frm_inicio.Label1.Font.Size - ComboBox3.SelectedItem, FontStyle.Regular)
                'My.Forms.Frm00_Login.frm_inicio.Label2.Font = New Font(My.Forms.Frm00_Login.frm_inicio.Label2.Name, My.Forms.Frm00_Login.frm_inicio.Label2.Font.Size - ComboBox3.SelectedItem, FontStyle.Regular)
                'My.Forms.Frm00_Login.frm_inicio.Label3.Font = New Font(My.Forms.Frm00_Login.frm_inicio.Label3.Name, My.Forms.Frm00_Login.frm_inicio.Label3.Font.Size - ComboBox3.SelectedItem, FontStyle.Regular)
                'My.Forms.Frm00_Login.frm_inicio.Label4.Font = New Font(My.Forms.Frm00_Login.frm_inicio.Label4.Name, My.Forms.Frm00_Login.frm_inicio.Label4.Font.Size - ComboBox3.SelectedItem, FontStyle.Regular)
                'My.Forms.Frm00_Login.frm_inicio.Label11.Font = New Font(My.Forms.Frm00_Login.frm_inicio.Label11.Name, My.Forms.Frm00_Login.frm_inicio.Label11.Font.Size - ComboBox3.SelectedItem, FontStyle.Regular)
                'My.Forms.Frm00_Login.frm_inicio.Label12.Font = New Font(My.Forms.Frm00_Login.frm_inicio.Label11.Name, My.Forms.Frm00_Login.frm_inicio.Label12.Font.Size - ComboBox3.SelectedItem, FontStyle.Regular)


            End If
        Catch ex As Exception
            MsgBox("El tamaño es muy pequeño para disminuirse")
        End Try

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedIndex > 0 Then
            My.Forms.Frm00_Login.frm_inicio.Label1.Font = New Font(ComboBox2.SelectedItem.ToString(), My.Forms.Frm00_Login.frm_inicio.Label1.Font.Size, FontStyle.Regular)
            'My.Forms.Frm00_Login.frm_inicio.Label2.Font = New Font(ComboBox2.SelectedItem.ToString(), My.Forms.Frm00_Login.frm_inicio.Label2.Font.Size, FontStyle.Regular)
            'My.Forms.Frm00_Login.frm_inicio.Label3.Font = New Font(ComboBox2.SelectedItem.ToString(), My.Forms.Frm00_Login.frm_inicio.Label3.Font.Size, FontStyle.Regular)
            'My.Forms.Frm00_Login.frm_inicio.Label4.Font = New Font(ComboBox2.SelectedItem.ToString(), My.Forms.Frm00_Login.frm_inicio.Label4.Font.Size, FontStyle.Regular)
            'My.Forms.Frm00_Login.frm_inicio.Label11.Font = New Font(ComboBox2.SelectedItem.ToString(), My.Forms.Frm00_Login.frm_inicio.Label11.Font.Size, FontStyle.Regular)
            My.Forms.Frm00_Login.frm_inicio.Label12.Font = New Font(ComboBox2.SelectedItem.ToString(), My.Forms.Frm00_Login.frm_inicio.Label12.Font.Size, FontStyle.Regular)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            My.Forms.Frm00_Login.frm_inicio.Label1.ForeColor = ColorDialog1.Color
            'My.Forms.Frm00_Login.frm_inicio.Label2.ForeColor = ColorDialog1.Color
            'My.Forms.Frm00_Login.frm_inicio.Label3.ForeColor = ColorDialog1.Color
            'My.Forms.Frm00_Login.frm_inicio.Label4.ForeColor = ColorDialog1.Color
            'My.Forms.Frm00_Login.frm_inicio.Label11.ForeColor = ColorDialog1.Color
            My.Forms.Frm00_Login.frm_inicio.Label12.ForeColor = ColorDialog1.Color
            MessageBox.Show("Se ha cambiado correctamente")
        End If
    End Sub
End Class
