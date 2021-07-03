Imports CrystalDecisions.CrystalReports.Engine

Public Class Frm_reporte001_Historial__de__pagos
    Public contrato As String
    Public fecha1 As Date
    Public fecha2 As Date
    Private Sub Frm_reporte001_Historial__de__pagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim RptDocument As New ReportDocument
        Dim reporte As New Frm_reporte001_Historial_de_pago
        If (fecha1 = Nothing) Then
            reporte.SetParameterValue("numerocontratos", contrato)
            reporte.SetParameterValue("fecha1", CDate("1964-03-05 00:00:00"))
            reporte.SetParameterValue("fecha2", DateTime.Now)
        Else
            reporte.SetParameterValue("numerocontratos", contrato)
            reporte.SetParameterValue("fecha1", fecha1)
            reporte.SetParameterValue("fecha2", fecha2)
        End If
        'RptDocument.Load(System.Web.HttpContext.Current.Server.MapPath(Application.StartupPath() + "print\Frm_reporte001_Historial_de_pago.rpt"))

        'RptDocument.SetParameterValue("numerocontratos ", contrato)

        Me.CrystalReportViewer1.ReportSource = reporte
    End Sub

    Private Sub lkbCerrar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lkbCerrar_Click_1(sender As Object, e As EventArgs) Handles lkbCerrar.Click
        Close()
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class