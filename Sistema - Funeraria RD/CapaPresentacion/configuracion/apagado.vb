Public Class apagado
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        'If ComboBox1.SelectedIndex = 1 Then

        '    MessageBox.Show("se ha guardado correctamente")
        '    My.Forms.Frm00_Login.frm_inicio.minutos = TimeOfDay.AddMinutes(5).ToString("mm")
        'ElseIf ComboBox1.SelectedIndex = 2 Then

        '    MessageBox.Show("se ha guardado correctamente")

        '    MessageBox.Show("se ha guardado correctamente")
        '    My.Forms.Frm00_Login.frm_inicio.minutos = TimeOfDay.AddMinutes(10).ToString("mm")
        'ElseIf ComboBox1.SelectedIndex = 3 Then


        '    MessageBox.Show("se ha guardado correctamente")
        '    My.Forms.Frm00_Login.frm_inicio.minutos = TimeOfDay.AddMinutes(15).ToString("mm")
        'ElseIf ComboBox1.SelectedIndex = 4 Then

        '    MessageBox.Show("se ha guardado correctamente")

        '    MessageBox.Show("se ha guardado correctamente")
        '    My.Forms.Frm00_Login.frm_inicio.horas = TimeOfDay.AddHours(1).ToString("hh")
        'ElseIf ComboBox1.SelectedIndex = 5 Then

        '    MessageBox.Show("se ha guardado correctamente")

        '    MessageBox.Show("se ha guardado correctamente")
        '    My.Forms.Frm00_Login.frm_inicio.horas = TimeOfDay.AddHours(3).ToString("hh")
        'ElseIf ComboBox1.SelectedIndex = 6 Then

        '    MessageBox.Show("se ha guardado correctamente")

        '    MessageBox.Show("se ha guardado correctamente")
        '    My.Forms.Frm00_Login.frm_inicio.horas = TimeOfDay.AddHours(5).ToString("hh")
        'ElseIf ComboBox1.SelectedIndex = 0 Then
        '    My.Forms.Frm00_Login.frm_inicio.horas = -1
        '    My.Forms.Frm00_Login.frm_inicio.minutos = -1


        'End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        'If ComboBox2.SelectedIndex = 1 Then

        '    MessageBox.Show("se ha guardado correctamente")
        '    My.Forms.Frm00_Login.frm_inicio.minutosapagado = TimeOfDay.AddMinutes(5).ToString("mm")
        'ElseIf ComboBox2.SelectedIndex = 2 Then

        '    MessageBox.Show("se ha guardado correctamente")

        '    MessageBox.Show("se ha guardado correctamente")
        '    My.Forms.Frm00_Login.frm_inicio.minutosapagado = TimeOfDay.AddMinutes(10).ToString("mm")
        'ElseIf ComboBox2.SelectedIndex = 3 Then


        '    MessageBox.Show("se ha guardado correctamente")
        '    My.Forms.Frm00_Login.frm_inicio.minutosapagado = TimeOfDay.AddMinutes(15).ToString("mm")
        'ElseIf ComboBox2.SelectedIndex = 4 Then

        '    MessageBox.Show("se ha guardado correctamente")

        '    MessageBox.Show("se ha guardado correctamente")
        '    My.Forms.Frm00_Login.frm_inicio.horasapagado = TimeOfDay.AddHours(1).ToString("hh")
        'ElseIf ComboBox2.SelectedIndex = 5 Then

        '    MessageBox.Show("se ha guardado correctamente")

        '    MessageBox.Show("se ha guardado correctamente")
        '    My.Forms.Frm00_Login.frm_inicio.horasapagado = TimeOfDay.AddHours(3).ToString("hh")
        'ElseIf ComboBox2.SelectedIndex = 6 Then

        '    MessageBox.Show("se ha guardado correctamente")

        '    MessageBox.Show("se ha guardado correctamente")
        '    My.Forms.Frm00_Login.frm_inicio.horasapagado = TimeOfDay.AddHours(5).ToString("hh")
        'ElseIf ComboBox2.SelectedIndex = 0 Then
        '    My.Forms.Frm00_Login.frm_inicio.horasapagado = -1
        '    My.Forms.Frm00_Login.frm_inicio.minutosapagado = -1


        'End If
    End Sub

    Private Sub apagado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
    End Sub
End Class
