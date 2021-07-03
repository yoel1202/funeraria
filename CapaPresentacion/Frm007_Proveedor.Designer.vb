<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm007_Proveedor
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDatos = New System.Windows.Forms.TextBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.dgvprovedores = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel_cabecera = New System.Windows.Forms.Panel()
        Me.lkbCerrar = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.ptbIcon = New System.Windows.Forms.PictureBox()
        Me.bordeIzquierda = New System.Windows.Forms.Panel()
        Me.bordeDerecha = New System.Windows.Forms.Panel()
        Me.bordeInferior = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.txtRepresentante = New System.Windows.Forms.TextBox()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.txtRuc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lb_min = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvprovedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_cabecera.SuspendLayout()
        CType(Me.ptbIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDatos)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(25, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(902, 82)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar por"
        '
        'txtDatos
        '
        Me.txtDatos.Location = New System.Drawing.Point(16, 38)
        Me.txtDatos.Name = "txtDatos"
        Me.txtDatos.Size = New System.Drawing.Size(867, 26)
        Me.txtDatos.TabIndex = 0
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.SeaGreen
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.ForeColor = System.Drawing.SystemColors.Window
        Me.btnNuevo.Location = New System.Drawing.Point(58, 24)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(150, 40)
        Me.btnNuevo.TabIndex = 5
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'dgvprovedores
        '
        Me.dgvprovedores.AllowUserToAddRows = False
        Me.dgvprovedores.AllowUserToDeleteRows = False
        Me.dgvprovedores.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvprovedores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvprovedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvprovedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column4, Me.Column5, Me.Column2, Me.Column3, Me.Column7, Me.Column6, Me.Column8, Me.Button})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvprovedores.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvprovedores.Location = New System.Drawing.Point(25, 123)
        Me.dgvprovedores.Name = "dgvprovedores"
        Me.dgvprovedores.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvprovedores.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvprovedores.Size = New System.Drawing.Size(1192, 279)
        Me.dgvprovedores.TabIndex = 7
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo Cliente"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column4
        '
        Me.Column4.HeaderText = "Cedula Juridica"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 80
        '
        'Column5
        '
        Me.Column5.HeaderText = "Razón Social"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 230
        '
        'Column2
        '
        Me.Column2.HeaderText = "Representante"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 190
        '
        'Column3
        '
        Me.Column3.HeaderText = "Celular"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 75
        '
        'Column7
        '
        Me.Column7.HeaderText = "Teléfono"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 75
        '
        'Column6
        '
        Me.Column6.HeaderText = "Dirección"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 240
        '
        'Column8
        '
        Me.Column8.HeaderText = "Email"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 170
        '
        'Button
        '
        Me.Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button.HeaderText = "Editar"
        Me.Button.Name = "Button"
        Me.Button.ReadOnly = True
        Me.Button.Width = 80
        '
        'Panel_cabecera
        '
        Me.Panel_cabecera.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Panel_cabecera.Controls.Add(Me.lb_min)
        Me.Panel_cabecera.Controls.Add(Me.lkbCerrar)
        Me.Panel_cabecera.Controls.Add(Me.lblTitulo)
        Me.Panel_cabecera.Controls.Add(Me.ptbIcon)
        Me.Panel_cabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_cabecera.Location = New System.Drawing.Point(0, 0)
        Me.Panel_cabecera.Name = "Panel_cabecera"
        Me.Panel_cabecera.Size = New System.Drawing.Size(1175, 40)
        Me.Panel_cabecera.TabIndex = 252
        '
        'lkbCerrar
        '
        Me.lkbCerrar.BackColor = System.Drawing.Color.Transparent
        Me.lkbCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lkbCerrar.Dock = System.Windows.Forms.DockStyle.Right
        Me.lkbCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkbCerrar.ForeColor = System.Drawing.SystemColors.Window
        Me.lkbCerrar.Location = New System.Drawing.Point(1144, 0)
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
        Me.lblTitulo.Size = New System.Drawing.Size(91, 17)
        Me.lblTitulo.TabIndex = 205
        Me.lblTitulo.Text = "Proveedores"
        '
        'ptbIcon
        '
        Me.ptbIcon.Image = Global.CapaPresentacion.My.Resources.Resources.ic_Proveedores
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
        Me.bordeIzquierda.Location = New System.Drawing.Point(0, 40)
        Me.bordeIzquierda.Name = "bordeIzquierda"
        Me.bordeIzquierda.Size = New System.Drawing.Size(2, 463)
        Me.bordeIzquierda.TabIndex = 253
        '
        'bordeDerecha
        '
        Me.bordeDerecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bordeDerecha.Dock = System.Windows.Forms.DockStyle.Right
        Me.bordeDerecha.Location = New System.Drawing.Point(1173, 40)
        Me.bordeDerecha.Name = "bordeDerecha"
        Me.bordeDerecha.Size = New System.Drawing.Size(2, 463)
        Me.bordeDerecha.TabIndex = 254
        '
        'bordeInferior
        '
        Me.bordeInferior.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bordeInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bordeInferior.Location = New System.Drawing.Point(2, 501)
        Me.bordeInferior.Name = "bordeInferior"
        Me.bordeInferior.Size = New System.Drawing.Size(1171, 2)
        Me.bordeInferior.TabIndex = 257
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(2, 40)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1171, 461)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.AliceBlue
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.dgvprovedores)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1163, 435)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado Proveedores"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnNuevo)
        Me.GroupBox6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(946, 20)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(271, 82)
        Me.GroupBox6.TabIndex = 10
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Opción"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.AliceBlue
        Me.TabPage2.Controls.Add(Me.btnLimpiar)
        Me.TabPage2.Controls.Add(Me.btnGuardar)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1163, 435)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Mantenimiento Proveedores"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnLimpiar.FlatAppearance.BorderSize = 0
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.SystemColors.Window
        Me.btnLimpiar.Location = New System.Drawing.Point(651, 325)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(150, 40)
        Me.btnLimpiar.TabIndex = 2
        Me.btnLimpiar.Text = "&Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.Window
        Me.btnGuardar.Location = New System.Drawing.Point(813, 325)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(150, 40)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtEmail)
        Me.GroupBox2.Controls.Add(Me.txtDireccion)
        Me.GroupBox2.Controls.Add(Me.txtTelefono)
        Me.GroupBox2.Controls.Add(Me.txtCelular)
        Me.GroupBox2.Controls.Add(Me.txtRepresentante)
        Me.GroupBox2.Controls.Add(Me.txtRazonSocial)
        Me.GroupBox2.Controls.Add(Me.txtRuc)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(283, 35)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(680, 281)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Proveedor"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(213, 234)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(396, 26)
        Me.txtEmail.TabIndex = 6
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(213, 200)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(396, 26)
        Me.txtDireccion.TabIndex = 5
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(213, 165)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(223, 26)
        Me.txtTelefono.TabIndex = 4
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(213, 131)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(223, 26)
        Me.txtCelular.TabIndex = 3
        '
        'txtRepresentante
        '
        Me.txtRepresentante.Location = New System.Drawing.Point(213, 98)
        Me.txtRepresentante.Name = "txtRepresentante"
        Me.txtRepresentante.Size = New System.Drawing.Size(396, 26)
        Me.txtRepresentante.TabIndex = 2
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Location = New System.Drawing.Point(213, 65)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(396, 26)
        Me.txtRazonSocial.TabIndex = 1
        '
        'txtRuc
        '
        Me.txtRuc.Location = New System.Drawing.Point(213, 33)
        Me.txtRuc.MaxLength = 11
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(223, 26)
        Me.txtRuc.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(105, 234)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "E-mail:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(88, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Dirección:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(63, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tel. Proveedor:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cel. Representante:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Representante:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Razón Social:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cedula Juridica"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'lb_min
        '
        Me.lb_min.BackColor = System.Drawing.Color.Transparent
        Me.lb_min.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lb_min.Dock = System.Windows.Forms.DockStyle.Right
        Me.lb_min.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_min.ForeColor = System.Drawing.SystemColors.Window
        Me.lb_min.Location = New System.Drawing.Point(1113, 0)
        Me.lb_min.Name = "lb_min"
        Me.lb_min.Size = New System.Drawing.Size(31, 40)
        Me.lb_min.TabIndex = 207
        Me.lb_min.Text = "-"
        Me.lb_min.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frm007_Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1175, 503)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.bordeInferior)
        Me.Controls.Add(Me.bordeDerecha)
        Me.Controls.Add(Me.bordeIzquierda)
        Me.Controls.Add(Me.Panel_cabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm007_Proveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmProveedorPrincipal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvprovedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_cabecera.ResumeLayout(False)
        Me.Panel_cabecera.PerformLayout()
        CType(Me.ptbIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents txtDatos As System.Windows.Forms.TextBox
    Friend WithEvents dgvprovedores As System.Windows.Forms.DataGridView
    Private WithEvents Panel_cabecera As System.Windows.Forms.Panel
    Private WithEvents lkbCerrar As System.Windows.Forms.Label
    Private WithEvents lblTitulo As System.Windows.Forms.Label
    Private WithEvents ptbIcon As System.Windows.Forms.PictureBox
    Private WithEvents bordeIzquierda As System.Windows.Forms.Panel
    Private WithEvents bordeDerecha As System.Windows.Forms.Panel
    Private WithEvents bordeInferior As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents txtRepresentante As System.Windows.Forms.TextBox
    Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents txtRuc As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Button As DataGridViewButtonColumn
    Private WithEvents lb_min As Label
End Class
