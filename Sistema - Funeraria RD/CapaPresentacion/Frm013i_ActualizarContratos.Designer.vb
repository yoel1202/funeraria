<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm013i_ActualizarContratos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel_cabecera = New System.Windows.Forms.Panel()
        Me.lkbCerrar = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.ptbIcon = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Panel_cabecera.SuspendLayout()
        CType(Me.ptbIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_cabecera
        '
        Me.Panel_cabecera.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Panel_cabecera.Controls.Add(Me.lkbCerrar)
        Me.Panel_cabecera.Controls.Add(Me.lblTitulo)
        Me.Panel_cabecera.Controls.Add(Me.ptbIcon)
        Me.Panel_cabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_cabecera.Location = New System.Drawing.Point(0, 0)
        Me.Panel_cabecera.Name = "Panel_cabecera"
        Me.Panel_cabecera.Size = New System.Drawing.Size(275, 27)
        Me.Panel_cabecera.TabIndex = 261
        '
        'lkbCerrar
        '
        Me.lkbCerrar.BackColor = System.Drawing.Color.Transparent
        Me.lkbCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lkbCerrar.Dock = System.Windows.Forms.DockStyle.Right
        Me.lkbCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkbCerrar.ForeColor = System.Drawing.SystemColors.Window
        Me.lkbCerrar.Location = New System.Drawing.Point(244, 0)
        Me.lkbCerrar.Name = "lkbCerrar"
        Me.lkbCerrar.Size = New System.Drawing.Size(31, 27)
        Me.lkbCerrar.TabIndex = 206
        Me.lkbCerrar.Text = "X"
        Me.lkbCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Window
        Me.lblTitulo.Location = New System.Drawing.Point(44, 10)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(140, 17)
        Me.lblTitulo.TabIndex = 205
        Me.lblTitulo.Text = "Actualizar Contratos"
        '
        'ptbIcon
        '
        Me.ptbIcon.Image = Global.CapaPresentacion.My.Resources.Resources.ic_Ventas
        Me.ptbIcon.Location = New System.Drawing.Point(11, 4)
        Me.ptbIcon.Name = "ptbIcon"
        Me.ptbIcon.Size = New System.Drawing.Size(25, 26)
        Me.ptbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbIcon.TabIndex = 162
        Me.ptbIcon.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SeaGreen
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Window
        Me.Button1.Location = New System.Drawing.Point(59, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 35)
        Me.Button1.TabIndex = 262
        Me.Button1.Text = "Actualizar contratos"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(59, 98)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(155, 23)
        Me.ProgressBar1.TabIndex = 263
        '
        'Frm016_ActualizarContratos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 252)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel_cabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm016_ActualizarContratos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm016_ActualizarContratos"
        Me.Panel_cabecera.ResumeLayout(False)
        Me.Panel_cabecera.PerformLayout()
        CType(Me.ptbIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents Panel_cabecera As Panel
    Private WithEvents lkbCerrar As Label
    Private WithEvents lblTitulo As Label
    Private WithEvents ptbIcon As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
