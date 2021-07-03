Imports CapaLogicaNegocio

Public Class Frm_0014_actualizarcontrato
    Dim CR As New ClsCredito
    Dim U As New clsUsuario
    Dim montoInicialAhorrado As String
    Public TipoAjuste As String

    Private Sub btn_abonar_Click(sender As Object, e As EventArgs) Handles btn_abonar.Click

        If TipoAjuste = "Periodo" Then
            Dim messaje As String = ""
            CR.Periodo = txt_periodo.Text
            CR.Numero_Contrato = txtCodigoContrado.Text
            messaje = CR.Actualizar_Periodo_Credito()
            clsMensaje.mostrar_mensaje("Actualizado ", "ok")
            U.CodigoPersona = CStr(Codigo_Personal_Online)
            U.Accion = "Se edito el periodo del contrato #: " + txt_Contrato.Text + " al periodo " + txt_periodo.Text
            U.fechas = DateTime.Now
            U.Registra_Acciones()
        Else
            Dim messaje As String = ""
            CR.ahorradorecibo = txt_saldo_contrato.Text
            CR.Numero_Contrato = txtCodigoContrado.Text
            messaje = CR.Actualizar_Monto_Contrato()
            clsMensaje.mostrar_mensaje("Actualizado correctamente", "ok")
            U.CodigoPersona = CStr(Codigo_Personal_Online)
            U.Accion = "Se edito el monto ahorrado del contrato #: " + txt_Contrato.Text + " Anterior monto ahorrado " + montoInicialAhorrado + " - Nuevo monto ahorrado: " + txt_ahorrado.Text
            U.fechas = DateTime.Now
            U.Registra_Acciones()
        End If
    End Sub

    Private Sub lkb_cerrar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lkb_cerrar.LinkClicked
        Me.Close()
    End Sub

    Private Sub txt_ahorrado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ahorrado.KeyPress
        Validar.Numeros(e)
    End Sub

    Private Sub txt_ahorrado_TextChanged(sender As Object, e As EventArgs) Handles txt_ahorrado.TextChanged
        If (txt_monto_contrato.Text.Length() > 0 And txt_ahorrado.Text.Length() > 0) Then
            txt_saldo_contrato.Text = Convert.ToString(Convert.ToDouble(txt_monto_contrato.Text) - Convert.ToDouble(txt_ahorrado.Text))
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Frm_0014_actualizarcontrato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        montoInicialAhorrado = txt_ahorrado.Text
        If (txt_monto_contrato.Text.Length() > 0 And txt_ahorrado.Text.Length() > 0) Then
            txt_saldo_contrato.Text = Convert.ToString(Convert.ToDouble(txt_monto_contrato.Text) - Convert.ToDouble(txt_ahorrado.Text))
        End If

        If TipoAjuste = "Periodo" Then
            txt_periodo.Enabled = True
            txt_ahorrado.Enabled = False
        Else
            txt_ahorrado.Enabled = True
            dtpFechaInicial.Enabled = False
        End If
    End Sub

    Private Sub dtpFechaInicial_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaInicial.ValueChanged
        txt_periodo.Text = TomarPeriodo(dtpFechaInicial.Value.ToShortDateString.ToString())
    End Sub

    Function TomarPeriodo(periodo As String) As String
        Dim periodos = ""
        Dim isValidDate = CDate(periodo).ToString("MMMM yyyy")
        If (periodo <> "") Then
            Dim cadena As Integer = CInt(CDate(isValidDate).ToString("yyyy"))
            Dim suma = cadena + 1
            Select Case LCase(isValidDate)
                Case "enero " + cadena.ToString()
                    periodos = "Enero " + cadena.ToString()
                Case "febrero " + cadena.ToString()
                    periodos = "Febrero " + cadena.ToString()
                Case "marzo " + cadena.ToString()
                    periodos = "Marzo " + cadena.ToString()
                Case "abril " + cadena.ToString()
                    periodos = "Abril " + cadena.ToString()
                Case "mayo " + cadena.ToString()
                    periodos = "Mayo " + cadena.ToString()
                Case "junio " + cadena.ToString()
                    periodos = "Junio " + cadena.ToString()
                Case "julio " + cadena.ToString()
                    periodos = "Julio " + cadena.ToString()
                Case "agosto " + cadena.ToString()
                    periodos = "Agosto " + cadena.ToString()
                Case "septiembre " + cadena.ToString()
                    periodos = "Septiembre " + cadena.ToString()
                Case "octubre " + cadena.ToString()
                    periodos = "Octubre " + cadena.ToString()
                Case "noviembre " + cadena.ToString()
                    periodos = "Noviembre " + cadena.ToString()
                Case "diciembre " + cadena.ToString()
                    periodos = "Diciembre " + suma.ToString()
            End Select
        End If
        Return periodos
    End Function

End Class