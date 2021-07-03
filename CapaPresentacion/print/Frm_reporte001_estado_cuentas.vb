Imports CapaLogicaNegocio

Public Class Frm_reporte001_estado_cuentas
    Public contrato As String
    Dim C As New clsContratos 'Instanciamos la clase clsUsuario de la Capa Logica de Negocio para usar sus funciones
    Dim CR As New ClsCredito 'Instanciamos la clase clsUsuario de la Capa Logica de Negocio para usar sus funciones

    Private Sub Frm_reporte001_estado_cuentas_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Frm_reporte001_estado_cuentas_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        C.RPTcontratos = contrato

        Dim dt As DataTable = C.RPT_ESTADO_CUENTA
        If dt.Rows.Count > 0 Then

            Dim ahorrado As Decimal = 0
            Dim reporte As New Frm_reporte001_estado_cuenta
            CR.CodigoContrato = CInt(dt.Rows(0)(0).ToString())
            ahorrado = CDec(CR.Devolver_monto_credito())
            reporte.SetParameterValue("prm_contrato", dt.Rows(0)(2).ToString())
            reporte.SetParameterValue("prm_telefono", dt.Rows(0)(9).ToString())
            reporte.SetParameterValue("prm_direccion", dt.Rows(0)(8).ToString())
            reporte.SetParameterValue("prm_cliente", dt.Rows(0)(1).ToString())
            reporte.SetParameterValue("prm_estado", dt.Rows(0)(7).ToString())
            reporte.SetParameterValue("prm_periodo", CR.Periodos_Recibos())
            reporte.SetParameterValue("prm_ahorrado", ahorrado)
            reporte.SetParameterValue("prm_C_canceladas", Math.Floor((CDec(ahorrado) / CDec(dt.Rows(0)(6).ToString()))))
            reporte.SetParameterValue("prm_cuotas_pendientes", Math.Floor(CDec(dt.Rows(0)(5).ToString()) - (CDec(ahorrado) / CDec(dt.Rows(0)(6).ToString()))))
            reporte.SetParameterValue("prm_total_cuotas", dt.Rows(0)(5).ToString())
            reporte.SetParameterValue("prm_cuota", dt.Rows(0)(6).ToString())
            reporte.SetParameterValue("prm_monto", dt.Rows(0)(4).ToString())
            Dim pendiente As Decimal = CDec(dt.Rows(0)(4).ToString()) - CDec(ahorrado)
            reporte.SetParameterValue("prm_pendiente", pendiente)
            reporte.SetParameterValue("CodigoContratos", CInt(dt.Rows(0)(0).ToString()))
            'reporte.SetParameterValue("fecha1", CDate("1964-03-05 00:00:00"))
            'reporte.SetParameterValue("fecha2", DateTime.Now)
            Me.CrystalReportViewer1.ReportSource = reporte
        End If
        'Dim RptDocument As New ReportDocument

    End Sub
End Class