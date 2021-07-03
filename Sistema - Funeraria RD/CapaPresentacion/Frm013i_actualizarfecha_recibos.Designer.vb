<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm013i_actualizarfecha_recibos
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
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.lb_mensaje = New System.Windows.Forms.Label()
        Me.txt_saldo_cuotas = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_ahorrado = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_recibo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_monto_abono = New System.Windows.Forms.TextBox()
        Me.lb_monto_abono = New System.Windows.Forms.Label()
        Me.btn_abonar = New System.Windows.Forms.Button()
        Me.txt_cuotas_ahorradas = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_monto_contrato = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Cliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_numero_C = New System.Windows.Forms.TextBox()
        Me.lb_fecha = New System.Windows.Forms.Label()
        Me.txt_periodo = New System.Windows.Forms.TextBox()
        Me.lb_monto_actual = New System.Windows.Forms.Label()
        Me.bordeIzquierda = New System.Windows.Forms.Panel()
        Me.bordeInferior = New System.Windows.Forms.Panel()
        Me.Panel_cabecera = New System.Windows.Forms.Panel()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.lkb_cerrar = New System.Windows.Forms.LinkLabel()
        Me.lkb_min = New System.Windows.Forms.LinkLabel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.GroupBox8.SuspendLayout()
        Me.Panel_cabecera.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.dtpFechaInicial)
        Me.GroupBox8.Controls.Add(Me.lb_mensaje)
        Me.GroupBox8.Controls.Add(Me.txt_saldo_cuotas)
        Me.GroupBox8.Controls.Add(Me.Label8)
        Me.GroupBox8.Controls.Add(Me.txt_ahorrado)
        Me.GroupBox8.Controls.Add(Me.Label7)
        Me.GroupBox8.Controls.Add(Me.txt_recibo)
        Me.GroupBox8.Controls.Add(Me.Label6)
        Me.GroupBox8.Controls.Add(Me.Label1)
        Me.GroupBox8.Controls.Add(Me.tb_monto_abono)
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
        Me.GroupBox8.Controls.Add(Me.txt_numero_C)
        Me.GroupBox8.Controls.Add(Me.lb_fecha)
        Me.GroupBox8.Controls.Add(Me.txt_periodo)
        Me.GroupBox8.Controls.Add(Me.lb_monto_actual)
        Me.GroupBox8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(16, 37)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(544, 400)
        Me.GroupBox8.TabIndex = 271
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Abonos"
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicial.Location = New System.Drawing.Point(168, 250)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(198, 26)
        Me.dtpFechaInicial.TabIndex = 99
        '
        'lb_mensaje
        '
        Me.lb_mensaje.AutoSize = True
        Me.lb_mensaje.Location = New System.Drawing.Point(168, 375)
        Me.lb_mensaje.Name = "lb_mensaje"
        Me.lb_mensaje.Size = New System.Drawing.Size(0, 19)
        Me.lb_mensaje.TabIndex = 98
        '
        'txt_saldo_cuotas
        '
        Me.txt_saldo_cuotas.Location = New System.Drawing.Point(168, 342)
        Me.txt_saldo_cuotas.Name = "txt_saldo_cuotas"
        Me.txt_saldo_cuotas.ReadOnly = True
        Me.txt_saldo_cuotas.Size = New System.Drawing.Size(198, 26)
        Me.txt_saldo_cuotas.TabIndex = 97
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(50, 346)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 19)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "Saldo Ctas:"
        '
        'txt_ahorrado
        '
        Me.txt_ahorrado.Location = New System.Drawing.Point(168, 312)
        Me.txt_ahorrado.Name = "txt_ahorrado"
        Me.txt_ahorrado.ReadOnly = True
        Me.txt_ahorrado.Size = New System.Drawing.Size(198, 26)
        Me.txt_ahorrado.TabIndex = 95
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(58, 316)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 19)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = "Ahorrado:"
        '
        'txt_recibo
        '
        Me.txt_recibo.Location = New System.Drawing.Point(168, 34)
        Me.txt_recibo.Name = "txt_recibo"
        Me.txt_recibo.Size = New System.Drawing.Size(198, 26)
        Me.txt_recibo.TabIndex = 93
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(74, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 19)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Recibo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 253)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 19)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Fecha:"
        '
        'tb_monto_abono
        '
        Me.tb_monto_abono.Location = New System.Drawing.Point(168, 281)
        Me.tb_monto_abono.Name = "tb_monto_abono"
        Me.tb_monto_abono.Size = New System.Drawing.Size(198, 26)
        Me.tb_monto_abono.TabIndex = 89
        '
        'lb_monto_abono
        '
        Me.lb_monto_abono.AutoSize = True
        Me.lb_monto_abono.Location = New System.Drawing.Point(46, 285)
        Me.lb_monto_abono.Name = "lb_monto_abono"
        Me.lb_monto_abono.Size = New System.Drawing.Size(83, 19)
        Me.lb_monto_abono.TabIndex = 88
        Me.lb_monto_abono.Text = "Mto. Cuota:"
        '
        'btn_abonar
        '
        Me.btn_abonar.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_abonar.FlatAppearance.BorderSize = 0
        Me.btn_abonar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_abonar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_abonar.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_abonar.Location = New System.Drawing.Point(382, 144)
        Me.btn_abonar.Name = "btn_abonar"
        Me.btn_abonar.Size = New System.Drawing.Size(150, 35)
        Me.btn_abonar.TabIndex = 87
        Me.btn_abonar.Text = "Actualizar Fecha"
        Me.btn_abonar.UseVisualStyleBackColor = False
        '
        'txt_cuotas_ahorradas
        '
        Me.txt_cuotas_ahorradas.Location = New System.Drawing.Point(168, 185)
        Me.txt_cuotas_ahorradas.Name = "txt_cuotas_ahorradas"
        Me.txt_cuotas_ahorradas.ReadOnly = True
        Me.txt_cuotas_ahorradas.Size = New System.Drawing.Size(198, 26)
        Me.txt_cuotas_ahorradas.TabIndex = 80
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 19)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "Ctas. Ahorradas:"
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(168, 95)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.ReadOnly = True
        Me.txt_direccion.Size = New System.Drawing.Size(198, 26)
        Me.txt_direccion.TabIndex = 78
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 19)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "Direccion:"
        '
        'txt_monto_contrato
        '
        Me.txt_monto_contrato.Location = New System.Drawing.Point(168, 154)
        Me.txt_monto_contrato.Name = "txt_monto_contrato"
        Me.txt_monto_contrato.ReadOnly = True
        Me.txt_monto_contrato.Size = New System.Drawing.Size(198, 26)
        Me.txt_monto_contrato.TabIndex = 76
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 19)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Contratado:"
        '
        'txt_Cliente
        '
        Me.txt_Cliente.Location = New System.Drawing.Point(168, 66)
        Me.txt_Cliente.Name = "txt_Cliente"
        Me.txt_Cliente.ReadOnly = True
        Me.txt_Cliente.Size = New System.Drawing.Size(198, 26)
        Me.txt_Cliente.TabIndex = 74
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 19)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Nombre:"
        '
        'txt_numero_C
        '
        Me.txt_numero_C.Location = New System.Drawing.Point(168, 218)
        Me.txt_numero_C.Name = "txt_numero_C"
        Me.txt_numero_C.ReadOnly = True
        Me.txt_numero_C.Size = New System.Drawing.Size(198, 26)
        Me.txt_numero_C.TabIndex = 72
        '
        'lb_fecha
        '
        Me.lb_fecha.AutoSize = True
        Me.lb_fecha.Location = New System.Drawing.Point(59, 221)
        Me.lb_fecha.Name = "lb_fecha"
        Me.lb_fecha.Size = New System.Drawing.Size(70, 19)
        Me.lb_fecha.TabIndex = 70
        Me.lb_fecha.Text = " Contrato:"
        '
        'txt_periodo
        '
        Me.txt_periodo.Location = New System.Drawing.Point(168, 125)
        Me.txt_periodo.Name = "txt_periodo"
        Me.txt_periodo.ReadOnly = True
        Me.txt_periodo.Size = New System.Drawing.Size(198, 26)
        Me.txt_periodo.TabIndex = 65
        '
        'lb_monto_actual
        '
        Me.lb_monto_actual.AutoSize = True
        Me.lb_monto_actual.Location = New System.Drawing.Point(69, 128)
        Me.lb_monto_actual.Name = "lb_monto_actual"
        Me.lb_monto_actual.Size = New System.Drawing.Size(60, 19)
        Me.lb_monto_actual.TabIndex = 64
        Me.lb_monto_actual.Text = "Periodo:"
        '
        'bordeIzquierda
        '
        Me.bordeIzquierda.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bordeIzquierda.Dock = System.Windows.Forms.DockStyle.Left
        Me.bordeIzquierda.Location = New System.Drawing.Point(0, 0)
        Me.bordeIzquierda.Name = "bordeIzquierda"
        Me.bordeIzquierda.Size = New System.Drawing.Size(2, 448)
        Me.bordeIzquierda.TabIndex = 269
        '
        'bordeInferior
        '
        Me.bordeInferior.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bordeInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bordeInferior.Location = New System.Drawing.Point(0, 448)
        Me.bordeInferior.Name = "bordeInferior"
        Me.bordeInferior.Size = New System.Drawing.Size(561, 2)
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
        Me.Panel_cabecera.Size = New System.Drawing.Size(559, 31)
        Me.Panel_cabecera.TabIndex = 272
        '
        'panel1
        '
        Me.panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel1.BackColor = System.Drawing.Color.Transparent
        Me.panel1.Controls.Add(Me.lkb_cerrar)
        Me.panel1.Controls.Add(Me.lkb_min)
        Me.panel1.Location = New System.Drawing.Point(492, 0)
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
        Me.lblTitulo.Size = New System.Drawing.Size(124, 15)
        Me.lblTitulo.TabIndex = 205
        Me.lblTitulo.Text = "Listado de Productos"
        '
        'Frm013i_actualizarfecha_recibos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 450)
        Me.Controls.Add(Me.Panel_cabecera)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.bordeIzquierda)
        Me.Controls.Add(Me.bordeInferior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm013i_actualizarfecha_recibos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_0013_actualizarfecha_recibos"
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.Panel_cabecera.ResumeLayout(False)
        Me.Panel_cabecera.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents dtpFechaInicial As DateTimePicker
    Friend WithEvents lb_mensaje As Label
    Friend WithEvents txt_saldo_cuotas As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_ahorrado As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_recibo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_monto_abono As TextBox
    Friend WithEvents lb_monto_abono As Label
    Friend WithEvents btn_abonar As Button
    Friend WithEvents txt_cuotas_ahorradas As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_direccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_monto_contrato As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Cliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_numero_C As TextBox
    Friend WithEvents lb_fecha As Label
    Friend WithEvents txt_periodo As TextBox
    Friend WithEvents lb_monto_actual As Label
    Private WithEvents bordeIzquierda As Panel
    Private WithEvents bordeInferior As Panel
    Private WithEvents Panel_cabecera As Panel
    Private WithEvents panel1 As Panel
    Private WithEvents lkb_cerrar As LinkLabel
    Private WithEvents lkb_min As LinkLabel
    Private WithEvents lblTitulo As Label
End Class
