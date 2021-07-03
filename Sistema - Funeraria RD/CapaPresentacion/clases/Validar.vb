Public Module Validar
    Public usuario_online As String = ""
    Public Codigo_Personal_Online As Integer = 0
    Public password As String = ""
    Public Cerrar_form As Integer = 0
    Public strCurrency As String = ""
    Public acceptableKey As Boolean = False
    Public Sub Centrar_Form(ByVal frm As Form)
        frm.Location = New Point((Screen.PrimaryScreen.Bounds.Width + 105 - frm.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - frm.Height) / 2)
    End Sub
    
    Public Sub Numeros(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or (Char.IsControl(e.KeyChar)))
    End Sub

    Public Sub Numeros_con_Numeral(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or (Char.IsControl(e.KeyChar)) Or e.KeyChar = "#")
    End Sub

    Public Sub Numeros_con_Decimales(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or (Char.IsControl(e.KeyChar)) Or e.KeyChar = ".")
    End Sub

    Public Sub Letras(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = Not (Char.IsLetter(e.KeyChar) Or (Char.IsControl(e.KeyChar)) Or (Char.IsSeparator(e.KeyChar)))
    End Sub

    Public Sub LetrasconPunto(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = Not (Char.IsLetter(e.KeyChar) Or (Char.IsControl(e.KeyChar)) Or (Char.IsSeparator(e.KeyChar)) Or e.KeyChar = ".")
    End Sub

    Public Sub Espacio(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Char.IsSeparator(e.KeyChar)) Then
            e.Handled = True
        Else
            e.Handled = False
        End If

    End Sub

    Sub keydowns(e As KeyEventArgs)
        If (e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9) OrElse (e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9) OrElse e.KeyCode = Keys.Back Then
            acceptableKey = True
        Else
            acceptableKey = False
        End If
    End Sub
    Sub keypres(e As KeyPressEventArgs, text As TextBox)
        If acceptableKey = False Then
            ' Stop the character from being entered into the control since it is non-numerical.
            e.Handled = True
            Return
        Else
            If e.KeyChar = Convert.ToChar(Keys.Back) Then
                If strCurrency.Length > 0 Then
                    strCurrency = strCurrency.Substring(0, strCurrency.Length - 1)
                End If
            Else
                strCurrency = strCurrency & e.KeyChar
            End If

            If strCurrency.Length = 0 Then
                text.Text = ""
            ElseIf strCurrency.Length = 1 Then
                Dim amount As Double = strCurrency
                text.Text = amount.ToString("###,###,###.00")

            ElseIf strCurrency.Length = 2 Then
                Dim amount As Double = strCurrency
                text.Text = amount.ToString("###,###,###.00")
            ElseIf strCurrency.Length > 2 Then
                Dim amount As Double = strCurrency
                text.Text = amount.ToString("###,###,###.00")
                'txt_monto.Text = Decimal.Parse(txt_monto.Text.Substring(0, txt_monto.Text.Length - 3))
            End If
            text.Select(text.Text.Length, 0)

        End If
        e.Handled = True
    End Sub
End Module
