Public Class Reporte_de_recibos_agregados_a_cobro_Alfa
    Public contrato As String
    Public fecha1 As Date
    Public fecha2 As Date
    Private Sub Reporte_de_recibos_agregados_a_cobro_Alfa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim reporte As New Reporte_de_recibos_agregados_a_cobro_Alfa_RPT
        If (contrato = 0) Then
            reporte.SetParameterValue("numerocontratos", contrato)
            reporte.SetParameterValue("fecha1", fecha1)
            reporte.SetParameterValue("fecha2", fecha2)
        Else
            reporte.SetParameterValue("numerocontratos", contrato)
            reporte.SetParameterValue("fecha1", fecha1)
            reporte.SetParameterValue("fecha2", fecha2)
        End If

        Me.CrystalReportViewer1.ReportSource = reporte
    End Sub
End Class