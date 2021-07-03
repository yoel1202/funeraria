Imports Microsoft.Reporting.WinForms

Public Class frm_recibo
    'Cree las propiedades publicas Titulo y Empresa
    Public Property Titulo() As String
    Public Property Empresa() As String
    Public Property Direccion() As String
    Public Property Telefonos() As String
    Private Sub frm_recibo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Validar.Centrar_Form(Me)
        'Limpiemos el DataSource del informe
        ReportViewer2.LocalReport.DataSources.Clear()

        'Establezcamos los parametros que enviaremos al reporte
        'recuerde que son dos para el titulo del reporte y para el nombre de la empresa
        'Dim parameters As ReportParameter() = New ReportParameter(3) {}
        'parameters(0) = New ReportParameter("parameterTitulo", Titulo)
        'parameters(1) = New ReportParameter("parameterEmpresa", Empresa)
        'parameters(2) = New ReportParameter("parameterDireccion", Direccion)
        'parameters(3) = New ReportParameter("parameterTelefonos", Telefonos)

        ''Establezcamos la lista como Datasource del informe


        ''Enviemos la lista de parametros
        'ReportViewer2.LocalReport.SetParameters(parameters)

        'Hagamos un refresh al reportViewer
        Me.ReportViewer2.RefreshReport()

        Me.ReportViewer2.RefreshReport()
    End Sub

    Private Sub ReportViewer2_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReportViewer2_Load_1(sender As Object, e As EventArgs) Handles ReportViewer2.Load

    End Sub
End Class