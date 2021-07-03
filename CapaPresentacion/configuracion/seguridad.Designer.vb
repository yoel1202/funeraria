<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class seguridad
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ch_passwordsi = New System.Windows.Forms.CheckBox()
        Me.ch_usuariosi = New System.Windows.Forms.CheckBox()
        Me.ch_passwordno = New System.Windows.Forms.CheckBox()
        Me.ch_usuariono = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(154, 179)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Guardar usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(154, 134)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Guardar contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(256, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(382, 27)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Cambiar la configuracion de seguridad"
        '
        'ch_passwordsi
        '
        Me.ch_passwordsi.AutoSize = True
        Me.ch_passwordsi.Location = New System.Drawing.Point(288, 135)
        Me.ch_passwordsi.Name = "ch_passwordsi"
        Me.ch_passwordsi.Size = New System.Drawing.Size(35, 17)
        Me.ch_passwordsi.TabIndex = 26
        Me.ch_passwordsi.Text = "Si"
        Me.ch_passwordsi.UseVisualStyleBackColor = True
        '
        'ch_usuariosi
        '
        Me.ch_usuariosi.AutoSize = True
        Me.ch_usuariosi.Location = New System.Drawing.Point(288, 178)
        Me.ch_usuariosi.Name = "ch_usuariosi"
        Me.ch_usuariosi.Size = New System.Drawing.Size(35, 17)
        Me.ch_usuariosi.TabIndex = 27
        Me.ch_usuariosi.Text = "Si"
        Me.ch_usuariosi.UseVisualStyleBackColor = True
        '
        'ch_passwordno
        '
        Me.ch_passwordno.AutoSize = True
        Me.ch_passwordno.Location = New System.Drawing.Point(374, 135)
        Me.ch_passwordno.Name = "ch_passwordno"
        Me.ch_passwordno.Size = New System.Drawing.Size(40, 17)
        Me.ch_passwordno.TabIndex = 28
        Me.ch_passwordno.Text = "No"
        Me.ch_passwordno.UseVisualStyleBackColor = True
        '
        'ch_usuariono
        '
        Me.ch_usuariono.AutoSize = True
        Me.ch_usuariono.Location = New System.Drawing.Point(374, 178)
        Me.ch_usuariono.Name = "ch_usuariono"
        Me.ch_usuariono.Size = New System.Drawing.Size(40, 17)
        Me.ch_usuariono.TabIndex = 29
        Me.ch_usuariono.Text = "No"
        Me.ch_usuariono.UseVisualStyleBackColor = True
        '
        'seguridad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.Controls.Add(Me.ch_usuariono)
        Me.Controls.Add(Me.ch_passwordno)
        Me.Controls.Add(Me.ch_usuariosi)
        Me.Controls.Add(Me.ch_passwordsi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "seguridad"
        Me.Size = New System.Drawing.Size(915, 514)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ch_passwordsi As CheckBox
    Friend WithEvents ch_usuariosi As CheckBox
    Friend WithEvents ch_passwordno As CheckBox
    Friend WithEvents ch_usuariono As CheckBox
End Class
