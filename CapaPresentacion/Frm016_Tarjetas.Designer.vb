<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm016_Tarjetas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm016_Tarjetas))
        Me.Panel_cabecera = New System.Windows.Forms.Panel()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.lkbCerrar = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.ptbIcon = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Dgv_textos = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Religion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Texto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.opcion = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.tb_nombre_texto = New System.Windows.Forms.TextBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cb_tipo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rtxt_texto = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnmenos = New System.Windows.Forms.Button()
        Me.btn_mas = New System.Windows.Forms.Button()
        Me.btn_exportar = New System.Windows.Forms.Button()
        Me.tb_nombre = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.pn_imagen = New System.Windows.Forms.Panel()
        Me.pb_difunto = New System.Windows.Forms.PictureBox()
        Me.lb_texto = New System.Windows.Forms.Label()
        Me.lb_fecha_fallecimiento = New System.Windows.Forms.Label()
        Me.lb_fecha_nacimiento = New System.Windows.Forms.Label()
        Me.lb_nombre = New System.Windows.Forms.Label()
        Me.lb_apellidos = New System.Windows.Forms.Label()
        Me.dtpFechaFallec = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tb_apellidos = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cb_nombre_textos = New System.Windows.Forms.ComboBox()
        Me.cb_diseño = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_religion = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rb_texto = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.Panel_cabecera.SuspendLayout()
        CType(Me.ptbIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.Dgv_textos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pn_imagen.SuspendLayout()
        CType(Me.pb_difunto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_cabecera
        '
        Me.Panel_cabecera.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Panel_cabecera.Controls.Add(Me.Label34)
        Me.Panel_cabecera.Controls.Add(Me.lkbCerrar)
        Me.Panel_cabecera.Controls.Add(Me.lblTitulo)
        Me.Panel_cabecera.Controls.Add(Me.ptbIcon)
        Me.Panel_cabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_cabecera.Location = New System.Drawing.Point(0, 0)
        Me.Panel_cabecera.Name = "Panel_cabecera"
        Me.Panel_cabecera.Size = New System.Drawing.Size(1022, 40)
        Me.Panel_cabecera.TabIndex = 258
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label34.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.SystemColors.Window
        Me.Label34.Location = New System.Drawing.Point(960, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(31, 40)
        Me.Label34.TabIndex = 208
        Me.Label34.Text = "-"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lkbCerrar
        '
        Me.lkbCerrar.BackColor = System.Drawing.Color.Transparent
        Me.lkbCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lkbCerrar.Dock = System.Windows.Forms.DockStyle.Right
        Me.lkbCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkbCerrar.ForeColor = System.Drawing.SystemColors.Window
        Me.lkbCerrar.Location = New System.Drawing.Point(991, 0)
        Me.lkbCerrar.Name = "lkbCerrar"
        Me.lkbCerrar.Size = New System.Drawing.Size(31, 40)
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
        Me.lblTitulo.Size = New System.Drawing.Size(59, 17)
        Me.lblTitulo.TabIndex = 205
        Me.lblTitulo.Text = "Tarjetas"
        '
        'ptbIcon
        '
        Me.ptbIcon.Image = CType(resources.GetObject("ptbIcon.Image"), System.Drawing.Image)
        Me.ptbIcon.Location = New System.Drawing.Point(11, 4)
        Me.ptbIcon.Name = "ptbIcon"
        Me.ptbIcon.Size = New System.Drawing.Size(25, 26)
        Me.ptbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbIcon.TabIndex = 162
        Me.ptbIcon.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 40)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1022, 748)
        Me.TabControl1.TabIndex = 259
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.AliceBlue
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1014, 722)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registrar Textos"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Dgv_textos)
        Me.GroupBox5.Controls.Add(Me.tb_nombre_texto)
        Me.GroupBox5.Controls.Add(Me.btnRegistrar)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.cb_tipo)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.rtxt_texto)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(40, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1022, 404)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Información de Contratos"
        '
        'Dgv_textos
        '
        Me.Dgv_textos.AllowUserToAddRows = False
        Me.Dgv_textos.BackgroundColor = System.Drawing.SystemColors.Window
        Me.Dgv_textos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_textos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Religion, Me.Nombre, Me.Texto, Me.opcion})
        Me.Dgv_textos.Location = New System.Drawing.Point(430, 25)
        Me.Dgv_textos.Name = "Dgv_textos"
        Me.Dgv_textos.RowHeadersWidth = 51
        Me.Dgv_textos.Size = New System.Drawing.Size(534, 199)
        Me.Dgv_textos.TabIndex = 300
        '
        'Column1
        '
        Me.Column1.HeaderText = "CodigoContrato"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        Me.Column1.Width = 125
        '
        'Religion
        '
        Me.Religion.HeaderText = "Religion"
        Me.Religion.Name = "Religion"
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre del texto"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 150
        '
        'Texto
        '
        Me.Texto.HeaderText = "Texto"
        Me.Texto.Name = "Texto"
        Me.Texto.Width = 200
        '
        'opcion
        '
        Me.opcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.opcion.HeaderText = "Editar"
        Me.opcion.Name = "opcion"
        '
        'tb_nombre_texto
        '
        Me.tb_nombre_texto.Location = New System.Drawing.Point(128, 76)
        Me.tb_nombre_texto.MaxLength = 50
        Me.tb_nombre_texto.Name = "tb_nombre_texto"
        Me.tb_nombre_texto.Size = New System.Drawing.Size(297, 26)
        Me.tb_nombre_texto.TabIndex = 299
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.ForeColor = System.Drawing.SystemColors.Window
        Me.btnRegistrar.Location = New System.Drawing.Point(128, 227)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(146, 45)
        Me.btnRegistrar.TabIndex = 0
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 19)
        Me.Label10.TabIndex = 298
        Me.Label10.Text = "Nombre Texto:"
        '
        'cb_tipo
        '
        Me.cb_tipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cb_tipo.FormattingEnabled = True
        Me.cb_tipo.Items.AddRange(New Object() {"Evangélico", "Católico"})
        Me.cb_tipo.Location = New System.Drawing.Point(128, 29)
        Me.cb_tipo.Name = "cb_tipo"
        Me.cb_tipo.Size = New System.Drawing.Size(297, 27)
        Me.cb_tipo.TabIndex = 296
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 19)
        Me.Label8.TabIndex = 288
        Me.Label8.Text = "Texto:"
        '
        'rtxt_texto
        '
        Me.rtxt_texto.Location = New System.Drawing.Point(128, 117)
        Me.rtxt_texto.Margin = New System.Windows.Forms.Padding(2)
        Me.rtxt_texto.MaxLength = 200
        Me.rtxt_texto.Name = "rtxt_texto"
        Me.rtxt_texto.Size = New System.Drawing.Size(297, 96)
        Me.rtxt_texto.TabIndex = 284
        Me.rtxt_texto.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 19)
        Me.Label4.TabIndex = 282
        Me.Label4.Text = "Religion:"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.AliceBlue
        Me.TabPage2.Controls.Add(Me.PictureBox2)
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.btnmenos)
        Me.TabPage2.Controls.Add(Me.btn_mas)
        Me.TabPage2.Controls.Add(Me.btn_exportar)
        Me.TabPage2.Controls.Add(Me.tb_nombre)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.pn_imagen)
        Me.TabPage2.Controls.Add(Me.dtpFechaFallec)
        Me.TabPage2.Controls.Add(Me.dtpFechaNac)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.tb_apellidos)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.cb_nombre_textos)
        Me.TabPage2.Controls.Add(Me.cb_diseño)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.cb_religion)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.rb_texto)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1014, 722)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Generar Tarjetas"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(452, 124)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(45, 33)
        Me.PictureBox2.TabIndex = 327
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(452, 162)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 37)
        Me.PictureBox1.TabIndex = 326
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(437, 88)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(27, 21)
        Me.Button3.TabIndex = 325
        Me.Button3.Text = "-"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(405, 87)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(27, 21)
        Me.Button2.TabIndex = 324
        Me.Button2.Text = "+"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnmenos
        '
        Me.btnmenos.Location = New System.Drawing.Point(437, 61)
        Me.btnmenos.Name = "btnmenos"
        Me.btnmenos.Size = New System.Drawing.Size(27, 21)
        Me.btnmenos.TabIndex = 323
        Me.btnmenos.Text = "-"
        Me.btnmenos.UseVisualStyleBackColor = True
        '
        'btn_mas
        '
        Me.btn_mas.Location = New System.Drawing.Point(407, 61)
        Me.btn_mas.Name = "btn_mas"
        Me.btn_mas.Size = New System.Drawing.Size(27, 21)
        Me.btn_mas.TabIndex = 322
        Me.btn_mas.Text = "+"
        Me.btn_mas.UseVisualStyleBackColor = True
        '
        'btn_exportar
        '
        Me.btn_exportar.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exportar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exportar.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_exportar.Location = New System.Drawing.Point(256, 344)
        Me.btn_exportar.Name = "btn_exportar"
        Me.btn_exportar.Size = New System.Drawing.Size(146, 45)
        Me.btn_exportar.TabIndex = 321
        Me.btn_exportar.Text = "Exportar"
        Me.btn_exportar.UseVisualStyleBackColor = False
        '
        'tb_nombre
        '
        Me.tb_nombre.Location = New System.Drawing.Point(102, 87)
        Me.tb_nombre.Name = "tb_nombre"
        Me.tb_nombre.Size = New System.Drawing.Size(297, 20)
        Me.tb_nombre.TabIndex = 320
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 90)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 13)
        Me.Label11.TabIndex = 319
        Me.Label11.Text = "Nombre Difunto:"
        '
        'pn_imagen
        '
        Me.pn_imagen.Controls.Add(Me.pb_difunto)
        Me.pn_imagen.Controls.Add(Me.lb_texto)
        Me.pn_imagen.Controls.Add(Me.lb_fecha_fallecimiento)
        Me.pn_imagen.Controls.Add(Me.lb_fecha_nacimiento)
        Me.pn_imagen.Controls.Add(Me.lb_nombre)
        Me.pn_imagen.Controls.Add(Me.lb_apellidos)
        Me.pn_imagen.Location = New System.Drawing.Point(522, 31)
        Me.pn_imagen.Name = "pn_imagen"
        Me.pn_imagen.Size = New System.Drawing.Size(238, 524)
        Me.pn_imagen.TabIndex = 318
        '
        'pb_difunto
        '
        Me.pb_difunto.BackColor = System.Drawing.Color.Transparent
        Me.pb_difunto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_difunto.Location = New System.Drawing.Point(20, 12)
        Me.pb_difunto.Name = "pb_difunto"
        Me.pb_difunto.Size = New System.Drawing.Size(104, 93)
        Me.pb_difunto.TabIndex = 327
        Me.pb_difunto.TabStop = False
        '
        'lb_texto
        '
        Me.lb_texto.BackColor = System.Drawing.Color.Transparent
        Me.lb_texto.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_texto.Location = New System.Drawing.Point(20, 333)
        Me.lb_texto.Name = "lb_texto"
        Me.lb_texto.Size = New System.Drawing.Size(204, 179)
        Me.lb_texto.TabIndex = 314
        Me.lb_texto.Text = "Label12"
        Me.lb_texto.UseCompatibleTextRendering = True
        '
        'lb_fecha_fallecimiento
        '
        Me.lb_fecha_fallecimiento.AutoSize = True
        Me.lb_fecha_fallecimiento.BackColor = System.Drawing.Color.Transparent
        Me.lb_fecha_fallecimiento.Font = New System.Drawing.Font("Ink Free", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_fecha_fallecimiento.Location = New System.Drawing.Point(93, 240)
        Me.lb_fecha_fallecimiento.Name = "lb_fecha_fallecimiento"
        Me.lb_fecha_fallecimiento.Size = New System.Drawing.Size(53, 16)
        Me.lb_fecha_fallecimiento.TabIndex = 313
        Me.lb_fecha_fallecimiento.Text = "Label12"
        '
        'lb_fecha_nacimiento
        '
        Me.lb_fecha_nacimiento.AutoSize = True
        Me.lb_fecha_nacimiento.BackColor = System.Drawing.Color.Transparent
        Me.lb_fecha_nacimiento.Font = New System.Drawing.Font("Ink Free", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_fecha_nacimiento.Location = New System.Drawing.Point(93, 218)
        Me.lb_fecha_nacimiento.Name = "lb_fecha_nacimiento"
        Me.lb_fecha_nacimiento.Size = New System.Drawing.Size(53, 16)
        Me.lb_fecha_nacimiento.TabIndex = 312
        Me.lb_fecha_nacimiento.Text = "Label12"
        '
        'lb_nombre
        '
        Me.lb_nombre.AutoSize = True
        Me.lb_nombre.BackColor = System.Drawing.Color.Transparent
        Me.lb_nombre.Font = New System.Drawing.Font("Constantia", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_nombre.Location = New System.Drawing.Point(87, 166)
        Me.lb_nombre.Name = "lb_nombre"
        Me.lb_nombre.Size = New System.Drawing.Size(100, 36)
        Me.lb_nombre.TabIndex = 311
        Me.lb_nombre.Text = "Label6"
        '
        'lb_apellidos
        '
        Me.lb_apellidos.AutoSize = True
        Me.lb_apellidos.BackColor = System.Drawing.Color.Transparent
        Me.lb_apellidos.Font = New System.Drawing.Font("Constantia", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_apellidos.Location = New System.Drawing.Point(25, 131)
        Me.lb_apellidos.Name = "lb_apellidos"
        Me.lb_apellidos.Size = New System.Drawing.Size(100, 36)
        Me.lb_apellidos.TabIndex = 310
        Me.lb_apellidos.Text = "Label6"
        '
        'dtpFechaFallec
        '
        Me.dtpFechaFallec.Location = New System.Drawing.Point(124, 149)
        Me.dtpFechaFallec.Name = "dtpFechaFallec"
        Me.dtpFechaFallec.Size = New System.Drawing.Size(299, 20)
        Me.dtpFechaFallec.TabIndex = 317
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.Location = New System.Drawing.Point(126, 123)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.Size = New System.Drawing.Size(297, 20)
        Me.dtpFechaNac.TabIndex = 315
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 316
        Me.Label6.Text = "Fecha Fallecimiento:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 123)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 13)
        Me.Label9.TabIndex = 314
        Me.Label9.Text = "Fecha Nacimiento:"
        '
        'tb_apellidos
        '
        Me.tb_apellidos.Location = New System.Drawing.Point(104, 61)
        Me.tb_apellidos.Name = "tb_apellidos"
        Me.tb_apellidos.Size = New System.Drawing.Size(297, 20)
        Me.tb_apellidos.TabIndex = 313
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 312
        Me.Label7.Text = "Apellidos Difunto:"
        '
        'cb_nombre_textos
        '
        Me.cb_nombre_textos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cb_nombre_textos.FormattingEnabled = True
        Me.cb_nombre_textos.Items.AddRange(New Object() {"Seleccionar opción"})
        Me.cb_nombre_textos.Location = New System.Drawing.Point(126, 203)
        Me.cb_nombre_textos.Name = "cb_nombre_textos"
        Me.cb_nombre_textos.Size = New System.Drawing.Size(297, 21)
        Me.cb_nombre_textos.TabIndex = 311
        '
        'cb_diseño
        '
        Me.cb_diseño.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cb_diseño.FormattingEnabled = True
        Me.cb_diseño.Items.AddRange(New Object() {"Diseño 1", "Diseño 2", "Diseño 3", "Diseño 4"})
        Me.cb_diseño.Location = New System.Drawing.Point(104, 31)
        Me.cb_diseño.Name = "cb_diseño"
        Me.cb_diseño.Size = New System.Drawing.Size(297, 21)
        Me.cb_diseño.TabIndex = 308
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 307
        Me.Label5.Text = "Tipo de tarjeta:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SeaGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Window
        Me.Button1.Location = New System.Drawing.Point(35, 344)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 45)
        Me.Button1.TabIndex = 300
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 206)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 305
        Me.Label1.Text = "Nombre Texto:"
        '
        'cb_religion
        '
        Me.cb_religion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cb_religion.FormattingEnabled = True
        Me.cb_religion.Items.AddRange(New Object() {"Seleccionar opcion", "Evangelico", "Catolico"})
        Me.cb_religion.Location = New System.Drawing.Point(126, 176)
        Me.cb_religion.Name = "cb_religion"
        Me.cb_religion.Size = New System.Drawing.Size(297, 21)
        Me.cb_religion.TabIndex = 304
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 303
        Me.Label2.Text = "Texto:"
        '
        'rb_texto
        '
        Me.rb_texto.Location = New System.Drawing.Point(124, 229)
        Me.rb_texto.Margin = New System.Windows.Forms.Padding(2)
        Me.rb_texto.MaxLength = 500
        Me.rb_texto.Name = "rb_texto"
        Me.rb_texto.Size = New System.Drawing.Size(316, 96)
        Me.rb_texto.TabIndex = 302
        Me.rb_texto.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 301
        Me.Label3.Text = "Religion:"
        '
        'Frm016_Tarjetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 788)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel_cabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm016_Tarjetas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_016_Tarjetas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel_cabecera.ResumeLayout(False)
        Me.Panel_cabecera.PerformLayout()
        CType(Me.ptbIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.Dgv_textos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pn_imagen.ResumeLayout(False)
        Me.pn_imagen.PerformLayout()
        CType(Me.pb_difunto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents Panel_cabecera As Panel
    Private WithEvents Label34 As Label
    Private WithEvents lkbCerrar As Label
    Private WithEvents lblTitulo As Label
    Private WithEvents ptbIcon As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cb_tipo As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents rtxt_texto As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Dgv_textos As DataGridView
    Friend WithEvents tb_nombre_texto As TextBox
    Friend WithEvents cb_diseño As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cb_religion As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents rb_texto As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_apellidos As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cb_nombre_textos As ComboBox
    Friend WithEvents lb_apellidos As Label
    Friend WithEvents dtpFechaFallec As DateTimePicker
    Friend WithEvents dtpFechaNac As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents pn_imagen As Panel
    Friend WithEvents tb_nombre As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lb_nombre As Label
    Friend WithEvents lb_fecha_nacimiento As Label
    Friend WithEvents lb_fecha_fallecimiento As Label
    Friend WithEvents lb_texto As Label
    Friend WithEvents btn_exportar As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Religion As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Texto As DataGridViewTextBoxColumn
    Friend WithEvents opcion As DataGridViewButtonColumn
    Friend WithEvents btnmenos As Button
    Friend WithEvents btn_mas As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents pb_difunto As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents FontDialog1 As FontDialog
End Class
