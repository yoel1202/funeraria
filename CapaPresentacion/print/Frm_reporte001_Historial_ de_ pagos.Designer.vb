<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_reporte001_Historial__de__pagos
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.lkbCerrar = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1000, 600)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'lkbCerrar
        '
        Me.lkbCerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lkbCerrar.BackColor = System.Drawing.Color.Transparent
        Me.lkbCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lkbCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkbCerrar.ForeColor = System.Drawing.SystemColors.MenuText
        Me.lkbCerrar.Location = New System.Drawing.Point(961, 0)
        Me.lkbCerrar.Name = "lkbCerrar"
        Me.lkbCerrar.Size = New System.Drawing.Size(39, 40)
        Me.lkbCerrar.TabIndex = 207
        Me.lkbCerrar.Text = "X"
        Me.lkbCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frm_reporte001_Historial__de__pagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.lkbCerrar)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_reporte001_Historial__de__pagos"
        Me.Text = "Frm_reporte001_Historial__de__pagos"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Private WithEvents lkbCerrar As Label
End Class
