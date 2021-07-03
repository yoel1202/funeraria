Public Class Reporte_de_recibos_Recaudados_Alfa
    Public contrato As String
    Public fecha1 As Date
    Public fecha2 As Date
    Private Sub Reporte_de_recibos_Recaudados_Alfa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim RptDocument As New ReportDocument
        Dim reporte As New Reporte_de_recibos_Recaudados_Alfa_RPT
        If (contrato = 0) Then
            reporte.SetParameterValue("numerocontratos", contrato)
            reporte.SetParameterValue("fecha1", fecha1)
            reporte.SetParameterValue("fecha2", fecha2)
        Else
            reporte.SetParameterValue("numerocontratos", contrato)
            reporte.SetParameterValue("fecha1", fecha1)
            reporte.SetParameterValue("fecha2", fecha2)
        End If
        'RptDocument.Load(System.Web.HttpContext.Current.Server.MapPath(Application.StartupPath() + "print\Frm_reporte001_Historial_de_pago.rpt"))

        'RptDocument.SetParameterValue("numerocontratos ", contrato)

        Me.CrystalReportViewer1.ReportSource = reporte
    End Sub
End Class