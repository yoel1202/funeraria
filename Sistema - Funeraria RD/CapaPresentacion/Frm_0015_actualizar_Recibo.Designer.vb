<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_0015_actualizar_Recibo
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
        Me.bordeIzquierda = New System.Windows.Forms.Panel()
        Me.bordeInferior = New System.Windows.Forms.Panel()
        Me.Panel_cabecera = New System.Windows.Forms.Panel()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.lkb_cerrar = New System.Windows.Forms.LinkLabel()
        Me.lkb_min = New System.Windows.Forms.LinkLabel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lb_monto_actual = New System.Windows.Forms.Label()
        Me.txt_periodo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Cliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_monto_contrato = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_cuotas_ahorradas = New System.Windows.Forms.TextBox()
        Me.btn_abonar = New System.Windows.Forms.Button()
        Me.lb_monto_abono = New System.Windows.Forms.Label()
        Me.txt_monto_abono = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Contrato = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_ahorrado = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_saldo_cuotas = New System.Windows.Forms.TextBox()
        Me.lb_mensaje = New System.Windows.Forms.Label()
        Me.txt_saldo_contrato = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblcodigoSerie = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCodigoRecibo = New System.Windows.Forms.TextBox()
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel_cabecera.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'bordeIzquierda
        '
        Me.bordeIzquierda.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bordeIzquierda.Dock = System.Windows.Forms.DockStyle.Left
        Me.bordeIzquierda.Location = New System.Drawing.Point(0, 0)
        Me.bordeIzquierda.Name = "bordeIzquierda"
        Me.bordeIzquierda.Size = New System.Drawing.Size(2, 491)
        Me.bordeIzquierda.TabIndex = 269
        '
        'bordeInferior
        '
        Me.bordeInferior.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bordeInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bordeInferior.Location = New System.Drawing.Point(0, 491)
        Me.bordeInferior.Name = "bordeInferior"
        Me.bordeInferior.Size = New System.Drawing.Size(603, 2)
        Me.bordeInferior.TabIndex = 270
        '
        'Panel_cabecera
        '
        Me.Panel_cabecera.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Panel_cabecera.Controls.Add(Me.panel1)
        Me.Panel_cabecera.Controls.Add(Me.lblTitulo)
        Me.Panel_cabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_cabecera.Location = New System.Drawing.Point(2, 0)
        Me.Panel_cabecera.Name = "Panel_cabecera"
        Me.Panel_cabecera.Size = New System.Drawing.Size(601, 31)
        Me.Panel_cabecera.TabIndex = 272
        '
        'panel1
        '
        Me.panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel1.BackColor = System.Drawing.Color.Transparent
        Me.panel1.Controls.Add(Me.lkb_cerrar)
        Me.panel1.Controls.Add(Me.lkb_min)
        Me.panel1.Location = New System.Drawing.Point(534, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(68, 30)
        Me.panel1.TabIndex = 206
        '
        'lkb_cerrar
        '
        Me.lkb_cerrar.ActiveLinkColor = System.Drawing.Color.DarkRed
        Me.lkb_cerrar.AutoSize = True
        Me.lkb_cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkb_cerrar.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lkb_cerrar.LinkColor = System.Drawing.Color.White
        Me.lkb_cerrar.Location = New System.Drawing.Point(39, 5)
        Me.lkb_cerrar.Name = "lkb_cerrar"
        Me.lkb_cerrar.Size = New System.Drawing.Size(15, 18)
        Me.lkb_cerrar.TabIndex = 1
        Me.lkb_cerrar.TabStop = True
        Me.lkb_cerrar.Text = "x"
        '
        'lkb_min
        '
        Me.lkb_min.ActiveLinkColor = System.Drawing.Color.Gainsboro
        Me.lkb_min.AutoSize = True
        Me.lkb_min.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkb_min.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lkb_min.LinkColor = System.Drawing.Color.White
        Me.lkb_min.Location = New System.Drawing.Point(13, 7)
        Me.lkb_min.Name = "lkb_min"
        Me.lkb_min.Size = New System.Drawing.Size(17, 18)
        Me.lkb_min.TabIndex = 0
        Me.lkb_min.TabStop = True
        Me.lkb_min.Text = "+"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Window
        Me.lblTitulo.Location = New System.Drawing.Point(13, 9)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(105, 15)
        Me.lblTitulo.TabIndex = 205
        Me.lblTitulo.Text = "Ajuste de contrato"
        '
        'lb_monto_actual
        '
        Me.lb_monto_actual.AutoSize = True
        Me.lb_monto_actual.Location = New System.Drawing.Point(87, 253)
        Me.lb_monto_actual.Name = "lb_monto_actual"
        Me.lb_monto_actual.Size = New System.Drawing.Size(60, 19)
        Me.lb_monto_actual.TabIndex = 64
        Me.lb_monto_actual.Text = "Periodo:"
        '
        'txt_periodo
        '
        Me.txt_periodo.Location = New System.Drawing.Point(168, 250)
        Me.txt_periodo.Name = "txt_periodo"
        Me.txt_periodo.ReadOnly = True
        Me.txt_periodo.Size = New System.Drawing.Size(174, 26)
        Me.txt_periodo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 19)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Nombre:"
        '
        'txt_Cliente
        '
        Me.txt_Cliente.Location = New System.Drawing.Point(168, 93)
        Me.txt_Cliente.Name = "txt_Cliente"
        Me.txt_Cliente.ReadOnly = True
        Me.txt_Cliente.Size = New System.Drawing.Size(363, 26)
        Me.txt_Cliente.TabIndex = 74
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 285)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 19)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Contratado:"
        '
        'txt_monto_contrato
        '
        Me.txt_monto_contrato.Location = New System.Drawing.Point(168, 282)
        Me.txt_monto_contrato.Name = "txt_monto_contrato"
        Me.txt_monto_contrato.ReadOnly = True
        Me.txt_monto_contrato.Size = New System.Drawing.Size(363, 26)
        Me.txt_monto_contrato.TabIndex = 76
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(77, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 19)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "Direccion:"
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(168, 122)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.ReadOnly = True
        Me.txt_direccion.Size = New System.Drawing.Size(363, 26)
        Me.txt_direccion.TabIndex = 78
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 19)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "Ctas. Ahorradas:"
        '
        'txt_cuotas_ahorradas
        '
        Me.txt_cuotas_ahorradas.Location = New System.Drawing.Point(168, 154)
        Me.txt_cuotas_ahorradas.Name = "txt_cuotas_ahorradas"
        Me.txt_cuotas_ahorradas.Size = New System.Drawing.Size(363, 26)
        Me.txt_cuotas_ahorradas.TabIndex = 80
        '
        'btn_abonar
        '
        Me.btn_abonar.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_abonar.FlatAppearance.BorderSize = 0
        Me.btn_abonar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_abonar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_abonar.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_abonar.Location = New System.Drawing.Point(97, 403)
        Me.btn_abonar.Name = "btn_abonar"
        Me.btn_abonar.Size = New System.Drawing.Size(150, 35)
        Me.btn_abonar.TabIndex = 87
        Me.btn_abonar.Text = "Guardar"
        Me.btn_abonar.UseVisualStyleBackColor = False
        '
        'lb_monto_abono
        '
        Me.lb_monto_abono.AutoSize = True
        Me.lb_monto_abono.Location = New System.Drawing.Point(64, 189)
        Me.lb_monto_abono.Name = "lb_monto_abono"
        Me.lb_monto_abono.Size = New System.Drawing.Size(83, 19)
        Me.lb_monto_abono.TabIndex = 88
        Me.lb_monto_abono.Text = "Mto. Cuota:"
        '
        'txt_monto_abono
        '
        Me.txt_monto_abono.Location = New System.Drawing.Point(168, 186)
        Me.txt_monto_abono.Name = "txt_monto_abono"
        Me.txt_monto_abono.Size = New System.Drawing.Size(363, 26)
        Me.txt_monto_abono.TabIndex = 89
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(81, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 19)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Contrato:"
        '
        'txt_Contrato
        '
        Me.txt_Contrato.Location = New System.Drawing.Point(168, 58)
        Me.txt_Contrato.Name = "txt_Contrato"
        Me.txt_Contrato.ReadOnly = True
        Me.txt_Contrato.Size = New System.Drawing.Size(363, 26)
        Me.txt_Contrato.TabIndex = 93
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(76, 317)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 19)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = "Ahorrado:"
        '
        'txt_ahorrado
        '
        Me.txt_ahorrado.Location = New System.Drawing.Point(168, 314)
        Me.txt_ahorrado.Name = "txt_ahorrado"
        Me.txt_ahorrado.Size = New System.Drawing.Size(363, 26)
        Me.txt_ahorrado.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(68, 221)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 19)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "Saldo Ctas:"
        '
        'txt_saldo_cuotas
        '
        Me.txt_saldo_cuotas.Location = New System.Drawing.Point(168, 218)
        Me.txt_saldo_cuotas.Name = "txt_saldo_cuotas"
        Me.txt_saldo_cuotas.Size = New System.Drawing.Size(363, 26)
        Me.txt_saldo_cuotas.TabIndex = 97
        '
        'lb_mensaje
        '
        Me.lb_mensaje.AutoSize = True
        Me.lb_mensaje.Location = New System.Drawing.Point(168, 375)
        Me.lb_mensaje.Name = "lb_mensaje"
        Me.lb_mensaje.Size = New System.Drawing.Size(0, 19)
        Me.lb_mensaje.TabIndex = 98
        '
        'txt_saldo_contrato
        '
        Me.txt_saldo_contrato.Location = New System.Drawing.Point(168, 346)
        Me.txt_saldo_contrato.Name = "txt_saldo_contrato"
        Me.txt_saldo_contrato.ReadOnly = True
        Me.txt_saldo_contrato.Size = New System.Drawing.Size(363, 26)
        Me.txt_saldo_contrato.TabIndex = 99
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 349)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 19)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Saldo contrato:"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.btnBuscar)
        Me.GroupBox8.Controls.Add(Me.lblcodigoSerie)
        Me.GroupBox8.Controls.Add(Me.Label9)
        Me.GroupBox8.Controls.Add(Me.txtCodigoRecibo)
        Me.GroupBox8.Controls.Add(Me.dtpFechaInicial)
        Me.GroupBox8.Controls.Add(Me.Button1)
        Me.GroupBox8.Controls.Add(Me.Label1)
        Me.GroupBox8.Controls.Add(Me.txt_saldo_contrato)
        Me.GroupBox8.Controls.Add(Me.lb_mensaje)
        Me.GroupBox8.Controls.Add(Me.txt_saldo_cuotas)
        Me.GroupBox8.Controls.Add(Me.Label8)
        Me.GroupBox8.Controls.Add(Me.txt_ahorrado)
        Me.GroupBox8.Controls.Add(Me.Label7)
        Me.GroupBox8.Controls.Add(Me.txt_Contrato)
        Me.GroupBox8.Controls.Add(Me.Label6)
        Me.GroupBox8.Controls.Add(Me.txt_monto_abono)
        Me.GroupBox8.Controls.Add(Me.lb_monto_abono)
        Me.GroupBox8.Controls.Add(Me.btn_abonar)
        Me.GroupBox8.Controls.Add(Me.txt_cuotas_ahorradas)
        Me.GroupBox8.Controls.Add(Me.Label5)
        Me.GroupBox8.Controls.Add(Me.txt_direccion)
        Me.GroupBox8.Controls.Add(Me.Label4)
        Me.GroupBox8.Controls.Add(Me.txt_monto_contrato)
        Me.GroupBox8.Controls.Add(Me.Label3)
        Me.GroupBox8.Controls.Add(Me.txt_Cliente)
        Me.GroupBox8.Controls.Add(Me.Label2)
        Me.GroupBox8.Controls.Add(Me.txt_periodo)
        Me.GroupBox8.Controls.Add(Me.lb_monto_actual)
        Me.GroupBox8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(16, 37)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(566, 444)
        Me.GroupBox8.TabIndex = 271
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Cambiar"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(429, 25)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(102, 27)
        Me.btnBuscar.TabIndex = 106
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lblcodigoSerie
        '
        Me.lblcodigoSerie.AutoSize = True
        Me.lblcodigoSerie.Location = New System.Drawing.Point(17, 375)
        Me.lblcodigoSerie.Name = "lblcodigoSerie"
        Me.lblcodigoSerie.Size = New System.Drawing.Size(0, 19)
        Me.lblcodigoSerie.TabIndex = 105
        Me.lblcodigoSerie.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(38, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 19)
        Me.Label9.TabIndex = 104
        Me.Label9.Text = "Número Recibo:"
        '
        'txtCodigoRecibo
        '
        Me.txtCodigoRecibo.Location = New System.Drawing.Point(168, 25)
        Me.txtCodigoRecibo.Name = "txtCodigoRecibo"
        Me.txtCodigoRecibo.Size = New System.Drawing.Size(251, 26)
        Me.txtCodigoRecibo.TabIndex = 103
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicial.Location = New System.Drawing.Point(348, 250)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(183, 26)
        Me.dtpFechaInicial.TabIndex = 102
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SeaGreen
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Window
        Me.Button1.Location = New System.Drawing.Point(348, 403)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 35)
        Me.Button1.TabIndex = 101
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Frm_0015_actualizar_Recibo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 493)
        Me.Controls.Add(Me.Panel_cabecera)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.bordeIzquierda)
        Me.Controls.Add(Me.bordeInferior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_0015_actualizar_Recibo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_0013_actualizarfecha_recibos"
        Me.Panel_cabecera.ResumeLayout(False)
        Me.Panel_cabecera.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents bordeIzquierda As Panel
    Private WithEvents bordeInferior As Panel
    Private WithEvents Panel_cabecera As Panel
    Private WithEvents panel1 As Panel
    Private WithEvents lkb_cerrar As LinkLabel
    Private WithEvents lkb_min As LinkLabel
    Private WithEvents lblTitulo As Label
    Friend WithEvents lb_monto_actual As Label
    Friend WithEvents txt_periodo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Cliente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_monto_contrato As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_direccion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_cuotas_ahorradas As TextBox
    Friend WithEvents btn_abonar As Button
    Friend WithEvents lb_monto_abono As Label
    Friend WithEvents txt_monto_abono As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_Contrato As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_ahorrado As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_saldo_cuotas As TextBox
    Friend WithEvents lb_mensaje As Label
    Friend WithEvents txt_saldo_contrato As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents dtpFechaInicial As DateTimePicker
    Friend WithEvents txtCodigoRecibo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lblcodigoSerie As Label
    Friend WithEvents btnBuscar As Button
End Class
