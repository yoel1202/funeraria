<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_recibo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(396, 246)
        Me.ReportViewer1.TabIndex = 0
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "CapaPresentacion.reporte recibo.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.ServerReport.BearerToken = Nothing
        Me.ReportViewer2.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer2.TabIndex = 0
        '
        'frm_recibo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Name = "frm_recibo"
        Me.Text = "Form1"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
End Class
