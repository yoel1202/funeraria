<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm012_VentasLiquidacion
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lkbCerrar = New System.Windows.Forms.Label()
        Me.ptbIcon = New System.Windows.Forms.PictureBox()
        Me.bordeIzquierda = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblIgv = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.dgvmantenimientos = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnIgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnSubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminars = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtmontoactual = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chk_contado = New System.Windows.Forms.CheckBox()
        Me.chk_credito = New System.Windows.Forms.CheckBox()
        Me.txtNroDocumento = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lkbBuscar = New System.Windows.Forms.LinkLabel()
        Me.lb_plazo = New System.Windows.Forms.Label()
        Me.rbnFactura = New System.Windows.Forms.RadioButton()
        Me.rbnBoleta = New System.Windows.Forms.RadioButton()
        Me.txt_plazo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_cuota = New System.Windows.Forms.TextBox()
        Me.lb_cuota = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.bordeInferior = New System.Windows.Forms.Panel()
        Me.Panel_cabecera = New System.Windows.Forms.Panel()
        Me.bordeDerecha = New System.Windows.Forms.Panel()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvmantenimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel_cabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Window
        Me.lblTitulo.Location = New System.Drawing.Point(44, 10)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(52, 17)
        Me.lblTitulo.TabIndex = 205
        Me.lblTitulo.Text = "Ventas"
        '
        'lkbCerrar
        '
        Me.lkbCerrar.BackColor = System.Drawing.Color.Transparent
        Me.lkbCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lkbCerrar.Dock = System.Windows.Forms.DockStyle.Right
        Me.lkbCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkbCerrar.ForeColor = System.Drawing.SystemColors.Window
        Me.lkbCerrar.Location = New System.Drawing.Point(988, 0)
        Me.lkbCerrar.Name = "lkbCerrar"
        Me.lkbCerrar.Size = New System.Drawing.Size(31, 27)
        Me.lkbCerrar.TabIndex = 206
        Me.lkbCerrar.Text = "X"
        Me.lkbCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'bordeIzquierda
        '
        Me.bordeIzquierda.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bordeIzquierda.Dock = System.Windows.Forms.DockStyle.Left
        Me.bordeIzquierda.Location = New System.Drawing.Point(0, 27)
        Me.bordeIzquierda.Name = "bordeIzquierda"
        Me.bordeIzquierda.Size = New System.Drawing.Size(1, 465)
        Me.bordeIzquierda.TabIndex = 269
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1019, 465)
        Me.TabControl1.TabIndex = 265
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.lblTotal)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.lblIgv)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.lblSubTotal)
        Me.TabPage1.Controls.Add(Me.dgvmantenimientos)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1011, 439)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Realizar Ventas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(857, 387)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(51, 13)
        Me.Label22.TabIndex = 274
        Me.Label22.Text = "TOTAL:"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(913, 382)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(87, 23)
        Me.lblTotal.TabIndex = 277
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(507, 388)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(80, 13)
        Me.Label23.TabIndex = 279
        Me.Label23.Text = "SUB TOTAL:"
        '
        'lblIgv
        '
        Me.lblIgv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIgv.Location = New System.Drawing.Point(750, 382)
        Me.lblIgv.Name = "lblIgv"
        Me.lblIgv.Size = New System.Drawing.Size(87, 23)
        Me.lblIgv.TabIndex = 276
        Me.lblIgv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(704, 388)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(39, 13)
        Me.Label24.TabIndex = 278
        Me.Label24.Text = "I..V.A"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubTotal.Location = New System.Drawing.Point(593, 383)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(87, 23)
        Me.lblSubTotal.TabIndex = 275
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvmantenimientos
        '
        Me.dgvmantenimientos.AllowUserToAddRows = False
        Me.dgvmantenimientos.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvmantenimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmantenimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Descripcion, Me.Precio, Me.Cantidad, Me.ColumnIgv, Me.ColumnSubTotal, Me.Importe, Me.Eliminars})
        Me.dgvmantenimientos.Location = New System.Drawing.Point(6, 264)
        Me.dgvmantenimientos.Name = "dgvmantenimientos"
        Me.dgvmantenimientos.RowHeadersWidth = 51
        Me.dgvmantenimientos.Size = New System.Drawing.Size(994, 115)
        Me.dgvmantenimientos.TabIndex = 24
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "CodigoProducto"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.MinimumWidth = 6
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 280
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.MinimumWidth = 6
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 125
        '
        'Cantidad
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle1
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 6
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 70
        '
        'ColumnIgv
        '
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.ColumnIgv.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColumnIgv.HeaderText = "IVA"
        Me.ColumnIgv.MinimumWidth = 6
        Me.ColumnIgv.Name = "ColumnIgv"
        Me.ColumnIgv.ReadOnly = True
        Me.ColumnIgv.Width = 125
        '
        'ColumnSubTotal
        '
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ColumnSubTotal.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColumnSubTotal.HeaderText = "SubTotal"
        Me.ColumnSubTotal.MinimumWidth = 6
        Me.ColumnSubTotal.Name = "ColumnSubTotal"
        Me.ColumnSubTotal.ReadOnly = True
        Me.ColumnSubTotal.Width = 125
        '
        'Importe
        '
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Importe.DefaultCellStyle = DataGridViewCellStyle4
        Me.Importe.HeaderText = "Importe"
        Me.Importe.MinimumWidth = 6
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        Me.Importe.Width = 125
        '
        'Eliminars
        '
        Me.Eliminars.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Eliminars.HeaderText = "Opción"
        Me.Eliminars.MinimumWidth = 6
        Me.Eliminars.Name = "Eliminars"
        Me.Eliminars.ReadOnly = True
        Me.Eliminars.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Eliminars.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Eliminars.Width = 90
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtmontoactual)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.chk_contado)
        Me.GroupBox5.Controls.Add(Me.chk_credito)
        Me.GroupBox5.Controls.Add(Me.txtNroDocumento)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.txtCliente)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.lkbBuscar)
        Me.GroupBox5.Controls.Add(Me.lb_plazo)
        Me.GroupBox5.Controls.Add(Me.rbnFactura)
        Me.GroupBox5.Controls.Add(Me.rbnBoleta)
        Me.GroupBox5.Controls.Add(Me.txt_plazo)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.txt_cuota)
        Me.GroupBox5.Controls.Add(Me.lb_cuota)
        Me.GroupBox5.Controls.Add(Me.dtpFecha)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(40, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(887, 159)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Información de la Venta"
        '
        'txtmontoactual
        '
        Me.txtmontoactual.Location = New System.Drawing.Point(148, 124)
        Me.txtmontoactual.Name = "txtmontoactual"
        Me.txtmontoactual.ReadOnly = True
        Me.txtmontoactual.Size = New System.Drawing.Size(112, 26)
        Me.txtmontoactual.TabIndex = 281
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 19)
        Me.Label4.TabIndex = 282
        Me.Label4.Text = "Monto:"
        '
        'chk_contado
        '
        Me.chk_contado.AutoSize = True
        Me.chk_contado.Location = New System.Drawing.Point(318, 28)
        Me.chk_contado.Margin = New System.Windows.Forms.Padding(2)
        Me.chk_contado.Name = "chk_contado"
        Me.chk_contado.Size = New System.Drawing.Size(81, 23)
        Me.chk_contado.TabIndex = 280
        Me.chk_contado.Text = "Contado"
        Me.chk_contado.UseVisualStyleBackColor = True
        '
        'chk_credito
        '
        Me.chk_credito.AutoSize = True
        Me.chk_credito.Checked = True
        Me.chk_credito.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_credito.Location = New System.Drawing.Point(155, 28)
        Me.chk_credito.Margin = New System.Windows.Forms.Padding(2)
        Me.chk_credito.Name = "chk_credito"
        Me.chk_credito.Size = New System.Drawing.Size(74, 23)
        Me.chk_credito.TabIndex = 279
        Me.chk_credito.Text = "Credito"
        Me.chk_credito.UseVisualStyleBackColor = True
        '
        'txtNroDocumento
        '
        Me.txtNroDocumento.Location = New System.Drawing.Point(558, 58)
        Me.txtNroDocumento.MaxLength = 7
        Me.txtNroDocumento.Name = "txtNroDocumento"
        Me.txtNroDocumento.Size = New System.Drawing.Size(250, 26)
        Me.txtNroDocumento.TabIndex = 278
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(487, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 19)
        Me.Label2.TabIndex = 277
        Me.Label2.Text = "N° Doc:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(487, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente:"
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.SystemColors.Window
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(556, 30)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(252, 26)
        Me.txtCliente.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(21, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 19)
        Me.Label14.TabIndex = 267
        Me.Label14.Text = "Condición Venta:"
        '
        'lkbBuscar
        '
        Me.lkbBuscar.AutoSize = True
        Me.lkbBuscar.Location = New System.Drawing.Point(827, 33)
        Me.lkbBuscar.Name = "lkbBuscar"
        Me.lkbBuscar.Size = New System.Drawing.Size(51, 19)
        Me.lkbBuscar.TabIndex = 7
        Me.lkbBuscar.TabStop = True
        Me.lkbBuscar.Text = "Buscar"
        '
        'lb_plazo
        '
        Me.lb_plazo.AutoSize = True
        Me.lb_plazo.Location = New System.Drawing.Point(32, 94)
        Me.lb_plazo.Name = "lb_plazo"
        Me.lb_plazo.Size = New System.Drawing.Size(45, 19)
        Me.lb_plazo.TabIndex = 268
        Me.lb_plazo.Text = "Plazo:"
        '
        'rbnFactura
        '
        Me.rbnFactura.AutoSize = True
        Me.rbnFactura.Location = New System.Drawing.Point(691, 91)
        Me.rbnFactura.Name = "rbnFactura"
        Me.rbnFactura.Size = New System.Drawing.Size(73, 23)
        Me.rbnFactura.TabIndex = 8
        Me.rbnFactura.Text = "Factura"
        Me.rbnFactura.UseVisualStyleBackColor = True
        '
        'rbnBoleta
        '
        Me.rbnBoleta.AutoSize = True
        Me.rbnBoleta.Location = New System.Drawing.Point(558, 90)
        Me.rbnBoleta.Name = "rbnBoleta"
        Me.rbnBoleta.Size = New System.Drawing.Size(66, 23)
        Me.rbnBoleta.TabIndex = 7
        Me.rbnBoleta.Text = "Boleta"
        Me.rbnBoleta.UseVisualStyleBackColor = True
        '
        'txt_plazo
        '
        Me.txt_plazo.Location = New System.Drawing.Point(148, 92)
        Me.txt_plazo.Name = "txt_plazo"
        Me.txt_plazo.Size = New System.Drawing.Size(115, 26)
        Me.txt_plazo.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(472, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = " Tipo Doc.:"
        '
        'txt_cuota
        '
        Me.txt_cuota.Location = New System.Drawing.Point(330, 91)
        Me.txt_cuota.Name = "txt_cuota"
        Me.txt_cuota.Size = New System.Drawing.Size(112, 26)
        Me.txt_cuota.TabIndex = 2
        '
        'lb_cuota
        '
        Me.lb_cuota.AutoSize = True
        Me.lb_cuota.Location = New System.Drawing.Point(269, 95)
        Me.lb_cuota.Name = "lb_cuota"
        Me.lb_cuota.Size = New System.Drawing.Size(49, 19)
        Me.lb_cuota.TabIndex = 270
        Me.lb_cuota.Text = "Cuota:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(148, 58)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(294, 26)
        Me.dtpFecha.TabIndex = 3
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(27, 63)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 19)
        Me.Label17.TabIndex = 271
        Me.Label17.Text = "Fecha :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnRegistrar)
        Me.GroupBox4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(662, 180)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(265, 78)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Opciones"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.ForeColor = System.Drawing.SystemColors.Window
        Me.btnRegistrar.Location = New System.Drawing.Point(44, 20)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(180, 45)
        Me.btnRegistrar.TabIndex = 0
        Me.btnRegistrar.Text = "Liquidar contrato"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'bordeInferior
        '
        Me.bordeInferior.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bordeInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bordeInferior.Location = New System.Drawing.Point(0, 492)
        Me.bordeInferior.Name = "bordeInferior"
        Me.bordeInferior.Size = New System.Drawing.Size(1019, 1)
        Me.bordeInferior.TabIndex = 268
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
        Me.Panel_cabecera.Size = New System.Drawing.Size(1019, 27)
        Me.Panel_cabecera.TabIndex = 266
        '
        'bordeDerecha
        '
        Me.bordeDerecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bordeDerecha.Dock = System.Windows.Forms.DockStyle.Right
        Me.bordeDerecha.Location = New System.Drawing.Point(1019, 0)
        Me.bordeDerecha.Name = "bordeDerecha"
        Me.bordeDerecha.Size = New System.Drawing.Size(10, 493)
        Me.bordeDerecha.TabIndex = 267
        '
        'Frm012_VentasLiquidacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 493)
        Me.Controls.Add(Me.bordeIzquierda)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.bordeInferior)
        Me.Controls.Add(Me.Panel_cabecera)
        Me.Controls.Add(Me.bordeDerecha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm012_VentasLiquidacion"
        Me.Text = "Frm012_VentasLiquidacion"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvmantenimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.Panel_cabecera.ResumeLayout(False)
        Me.Panel_cabecera.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ErrorProvider1 As ErrorProvider
    Private WithEvents bordeIzquierda As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtmontoactual As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents chk_contado As CheckBox
    Friend WithEvents chk_credito As CheckBox
    Friend WithEvents txtNroDocumento As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents lkbBuscar As LinkLabel
    Friend WithEvents lb_plazo As Label
    Friend WithEvents rbnFactura As RadioButton
    Friend WithEvents rbnBoleta As RadioButton
    Friend WithEvents txt_plazo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_cuota As TextBox
    Friend WithEvents lb_cuota As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnRegistrar As Button
    Private WithEvents bordeInferior As Panel
    Private WithEvents Panel_cabecera As Panel
    Private WithEvents lkbCerrar As Label
    Private WithEvents lblTitulo As Label
    Private WithEvents ptbIcon As PictureBox
    Private WithEvents bordeDerecha As Panel
    Friend WithEvents dgvmantenimientos As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents ColumnIgv As DataGridViewTextBoxColumn
    Friend WithEvents ColumnSubTotal As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
    Friend WithEvents Eliminars As DataGridViewButtonColumn
    Friend WithEvents Label22 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents lblIgv As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents lblSubTotal As Label
End Class
