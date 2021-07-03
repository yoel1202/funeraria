Public Module clsMensaje

    Public Sub mostrar_mensaje(ByVal mensaje As String, ByVal Tipo As String)
        Dim frm As New Frm010_Mensaje
        frm.lblmsj.Text = mensaje
        'Frm010_MensajeOk.Centrar_Controles()
        If (Tipo = "ok") Then
            frm.lblTitulo.Text = "Mensaje"
            frm.btnAceptar.BackColor = Color.FromArgb(0, 122, 204)
            frm.ptbIcono.Image = My.Resources.ic_ok
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
        Else
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Hand)
        End If
        frm.ShowDialog()

    End Sub
    Dim textBox As TextBox = New TextBox()
    Public Function InputBox(ByVal title As String, ByVal promptText As String, ByRef value As String) As DialogResult
        Dim form As Form = New Form()
        Dim label As Label = New Label()

        Dim buttonOk As Button = New Button()
        Dim buttonCancel As Button = New Button()
        Dim dialogResult As DialogResult
        form.Text = title
        label.Text = promptText
        textBox.Text = value
        buttonOk.Text = "OK"
        buttonCancel.Text = "Cancel"
        buttonOk.DialogResult = dialogResult.OK
        buttonCancel.DialogResult = dialogResult.Cancel
        label.SetBounds(9, 20, 372, 13)
        textBox.SetBounds(12, 36, 372, 20)
        buttonOk.SetBounds(228, 72, 75, 23)
        buttonCancel.SetBounds(309, 72, 75, 23)
        label.AutoSize = True
        textBox.Anchor = textBox.Anchor Or AnchorStyles.Right
        buttonOk.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        buttonCancel.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        form.ClientSize = New Size(396, 107)
        form.Controls.AddRange(New Control() {label, textBox, buttonOk, buttonCancel})
        form.ClientSize = New Size(Math.Max(300, label.Right + 10), form.ClientSize.Height)
        form.FormBorderStyle = FormBorderStyle.FixedDialog
        form.StartPosition = FormStartPosition.CenterScreen
        form.MinimizeBox = False
        form.MaximizeBox = False
        form.AcceptButton = buttonOk
        form.CancelButton = buttonCancel
        dialogResult = form.ShowDialog()
        value = textBox.Text
        Return dialogResult
    End Function


    Public Function GetValue() As String
        Return textBox.Text

    End Function
End Module
