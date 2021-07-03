Imports CapaLogicaNegocio
Imports Microsoft.Reporting.WinForms

Public Class Frm_recibos1
    Public Detail As New List(Of ERecibos)()


    Dim U As New clsUsuario 'Instanciamos la clase clsUsuario de la Capa Logica de Negocio para usar sus funciones
    Dim C As New clsContratos 'Instanciamos la clase clsUsuario de la Capa Logica de Negocio para usar sus funciones
    Dim CR As New ClsCredito 'Instanciamos la clase clsUsuario de la Capa Logica de Negocio para usar sus funciones
    Private Sub Frm_recibos1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Validar.Centrar_Form(Me)
        'Limpiemos el DataSource del informe
        ReportViewer1.LocalReport.DataSources.Clear()

        'Establezcamos los parametros que enviaremos al reporte
        'recuerde que son dos para el titulo del reporte y para el nombre de la empresa


        'Establezcamos la lista como Datasource del informe
        ReportViewer1.LocalReport.EnableExternalImages = True
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", Detail))



        'Hagamos un refresh al reportViewer
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Print(sender As Object, e As ReportPrintEventArgs) Handles ReportViewer1.Print

    End Sub

    Private Sub ReportViewer1_PrintingBegin(sender As Object, e As ReportPrintEventArgs) Handles ReportViewer1.PrintingBegin
        For Each row As ERecibos In Detail
            U.CodigoPersona = CStr(Codigo_Personal_Online)
            U.Accion = "Se imprimio el : " + row.NRecibo + " con contrato: " + row.Contrato
            U.fechas = DateTime.Now
            U.Registra_Acciones()
            CR.Fecha = row.FechaImpresion
            CR.Serie = row.NRecibo
            CR.CodigoContrato = row.codigocontrato
            CR.Ahorrado = row.Ahorrado
            CR.SaldoCuotas = row.SaldoCtas
            CR.CuotasAhorradas = row.CTASAhorradas
            CR.Registrar_impresiones()

        Next
        'U.CodigoPersona = CStr(Codigo_Personal_Online)
        'U.Accion = "Se imprimio el : " + article.NRecibo + " con contrato: " + article.Contrato
        'U.fechas = DateTime.Now
        'U.Registra_Acciones()
        'CR.fechaimpreso = CDate(DateTime.Now)
        'CR.codigocobroimpreso = row.Cells(0).Value
        'CR.Registrar_impresiones()
        'CR.CodigoContrato = 0
    End Sub
End Class