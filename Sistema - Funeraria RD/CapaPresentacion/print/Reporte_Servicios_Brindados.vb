Public Class Reporte_Servicios_Brindados
    Public contrato As String

    Private Sub Reporte_Servicios_Brindados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim reporte As New Reporte_Servicios_Brindados_RPT

        reporte.SetParameterValue("numerocontratos", contrato)



        Me.CrystalReportViewer1.ReportSource = reporte
    End Sub
End Class