﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm004_PlanesFunerarios
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.dgv_planes = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VerPlan = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ptbImagen = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Panel_cabecera = New System.Windows.Forms.Panel()
        Me.lkbCerrar = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.ptbIcon = New System.Windows.Forms.PictureBox()
        Me.bordeInferior = New System.Windows.Forms.Panel()
        Me.bordeDerecha = New System.Windows.Forms.Panel()
        Me.bordeIzquierda = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lblTotal = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbxPlanesFunerarios = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lkbAgregarItem = New System.Windows.Forms.LinkLabel()
        Me.btnGuardarTabPage2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtgDetallesPlanes = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lb_min = New System.Windows.Forms.Label()
        CType(Me.dgv_planes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel_cabecera.SuspendLayout()
        CType(Me.ptbIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtgDetallesPlanes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Descripción:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(116, 28)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(391, 26)
        Me.txtDescripcion.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Precio:"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(116, 67)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(110, 26)
        Me.txtPrecio.TabIndex = 1
        Me.txtPrecio.Text = "0"
        '
        'dgv_planes
        '
        Me.dgv_planes.AllowUserToAddRows = False
        Me.dgv_planes.AllowUserToDeleteRows = False
        Me.dgv_planes.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgv_planes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_planes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.VerPlan})
        Me.dgv_planes.Location = New System.Drawing.Point(129, 243)
        Me.dgv_planes.Name = "dgv_planes"
        Me.dgv_planes.ReadOnly = True
        Me.dgv_planes.RowHeadersWidth = 51
        Me.dgv_planes.Size = New System.Drawing.Size(570, 176)
        Me.dgv_planes.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Descripción"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 300
        '
        'Column3
        '
        Me.Column3.HeaderText = "Precio"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "RutaImagen"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Visible = False
        Me.Column4.Width = 125
        '
        'VerPlan
        '
        Me.VerPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VerPlan.HeaderText = "Opción"
        Me.VerPlan.MinimumWidth = 6
        Me.VerPlan.Name = "VerPlan"
        Me.VerPlan.ReadOnly = True
        Me.VerPlan.Width = 90
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.Window
        Me.btnGuardar.Location = New System.Drawing.Point(358, 152)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(150, 40)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 19)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Imagen:"
        '
        'ptbImagen
        '
        Me.ptbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptbImagen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbImagen.Location = New System.Drawing.Point(116, 100)
        Me.ptbImagen.Name = "ptbImagen"
        Me.ptbImagen.Size = New System.Drawing.Size(216, 92)
        Me.ptbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbImagen.TabIndex = 9
        Me.ptbImagen.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ptbImagen)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.txtPrecio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(129, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(550, 213)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Plan Funerario"
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.SeaGreen
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.ForeColor = System.Drawing.SystemColors.Window
        Me.btnNuevo.Location = New System.Drawing.Point(357, 100)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(150, 40)
        Me.btnNuevo.TabIndex = 10
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
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
        Me.Panel_cabecera.TabIndex = 250
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
        Me.lblTitulo.Size = New System.Drawing.Size(127, 17)
        Me.lblTitulo.TabIndex = 205
        Me.lblTitulo.Text = "Planes Funerarios"
        '
        'ptbIcon
        '
        Me.ptbIcon.Image = Global.CapaPresentacion.My.Resources.Resources.ic_Planes
        Me.ptbIcon.Location = New System.Drawing.Point(11, 4)
        Me.ptbIcon.Name = "ptbIcon"
        Me.ptbIcon.Size = New System.Drawing.Size(25, 26)
        Me.ptbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbIcon.TabIndex = 162
        Me.ptbIcon.TabStop = False
        '
        'bordeInferior
        '
        Me.bordeInferior.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bordeInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bordeInferior.Location = New System.Drawing.Point(0, 501)
        Me.bordeInferior.Name = "bordeInferior"
        Me.bordeInferior.Size = New System.Drawing.Size(1175, 2)
        Me.bordeInferior.TabIndex = 251
        '
        'bordeDerecha
        '
        Me.bordeDerecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bordeDerecha.Dock = System.Windows.Forms.DockStyle.Right
        Me.bordeDerecha.Location = New System.Drawing.Point(1173, 40)
        Me.bordeDerecha.Name = "bordeDerecha"
        Me.bordeDerecha.Size = New System.Drawing.Size(2, 461)
        Me.bordeDerecha.TabIndex = 252
        '
        'bordeIzquierda
        '
        Me.bordeIzquierda.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bordeIzquierda.Dock = System.Windows.Forms.DockStyle.Left
        Me.bordeIzquierda.Location = New System.Drawing.Point(0, 40)
        Me.bordeIzquierda.Name = "bordeIzquierda"
        Me.bordeIzquierda.Size = New System.Drawing.Size(2, 461)
        Me.bordeIzquierda.TabIndex = 253
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TabControl1.Location = New System.Drawing.Point(2, 40)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1171, 461)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.AliceBlue
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.dgv_planes)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1163, 433)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Mantenimiento Planes"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.AliceBlue
        Me.TabPage2.Controls.Add(Me.lblTotal)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.btnGuardarTabPage2)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.dtgDetallesPlanes)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1163, 433)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Armar Planes"
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(655, 367)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(101, 21)
        Me.lblTotal.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SeaGreen
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.Window
        Me.Button1.Location = New System.Drawing.Point(362, 354)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 35)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Ploforma"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbxPlanesFunerarios)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lkbAgregarItem)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(70, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(767, 71)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seleccione Plan"
        '
        'cbxPlanesFunerarios
        '
        Me.cbxPlanesFunerarios.BackColor = System.Drawing.SystemColors.Menu
        Me.cbxPlanesFunerarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPlanesFunerarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxPlanesFunerarios.FormattingEnabled = True
        Me.cbxPlanesFunerarios.Location = New System.Drawing.Point(131, 25)
        Me.cbxPlanesFunerarios.Name = "cbxPlanesFunerarios"
        Me.cbxPlanesFunerarios.Size = New System.Drawing.Size(273, 27)
        Me.cbxPlanesFunerarios.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Plan Funerario:"
        '
        'lkbAgregarItem
        '
        Me.lkbAgregarItem.AutoSize = True
        Me.lkbAgregarItem.Location = New System.Drawing.Point(478, 30)
        Me.lkbAgregarItem.Name = "lkbAgregarItem"
        Me.lkbAgregarItem.Size = New System.Drawing.Size(89, 19)
        Me.lkbAgregarItem.TabIndex = 1
        Me.lkbAgregarItem.TabStop = True
        Me.lkbAgregarItem.Text = "Agregar Ítem"
        '
        'btnGuardarTabPage2
        '
        Me.btnGuardarTabPage2.BackColor = System.Drawing.Color.SeaGreen
        Me.btnGuardarTabPage2.FlatAppearance.BorderSize = 0
        Me.btnGuardarTabPage2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarTabPage2.ForeColor = System.Drawing.SystemColors.Window
        Me.btnGuardarTabPage2.Location = New System.Drawing.Point(70, 357)
        Me.btnGuardarTabPage2.Name = "btnGuardarTabPage2"
        Me.btnGuardarTabPage2.Size = New System.Drawing.Size(150, 35)
        Me.btnGuardarTabPage2.TabIndex = 13
        Me.btnGuardarTabPage2.Text = "&Guardar"
        Me.btnGuardarTabPage2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(574, 370)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Precio Total:"
        '
        'dtgDetallesPlanes
        '
        Me.dtgDetallesPlanes.AllowUserToAddRows = False
        Me.dtgDetallesPlanes.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dtgDetallesPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgDetallesPlanes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.CodigoDetalle, Me.DataGridViewTextBoxColumn2, Me.Precio, Me.Button})
        Me.dtgDetallesPlanes.Location = New System.Drawing.Point(70, 120)
        Me.dtgDetallesPlanes.Name = "dtgDetallesPlanes"
        Me.dtgDetallesPlanes.RowHeadersWidth = 51
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgDetallesPlanes.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgDetallesPlanes.Size = New System.Drawing.Size(767, 228)
        Me.dtgDetallesPlanes.TabIndex = 10
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'CodigoDetalle
        '
        Me.CodigoDetalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.CodigoDetalle.HeaderText = "CodigoDetalle"
        Me.CodigoDetalle.MinimumWidth = 6
        Me.CodigoDetalle.Name = "CodigoDetalle"
        Me.CodigoDetalle.ReadOnly = True
        Me.CodigoDetalle.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 430
        '
        'Precio
        '
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Precio.DefaultCellStyle = DataGridViewCellStyle1
        Me.Precio.HeaderText = "Precio"
        Me.Precio.MinimumWidth = 6
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 125
        '
        'Button
        '
        Me.Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button.HeaderText = "Eliminar"
        Me.Button.MinimumWidth = 6
        Me.Button.Name = "Button"
        Me.Button.ReadOnly = True
        Me.Button.Width = 125
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
        'Frm004_PlanesFunerarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1175, 503)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.bordeIzquierda)
        Me.Controls.Add(Me.bordeDerecha)
        Me.Controls.Add(Me.bordeInferior)
        Me.Controls.Add(Me.Panel_cabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm004_PlanesFunerarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PlanesFunerarios"
        CType(Me.dgv_planes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel_cabecera.ResumeLayout(False)
        Me.Panel_cabecera.PerformLayout()
        CType(Me.ptbIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dtgDetallesPlanes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents dgv_planes As System.Windows.Forms.DataGridView
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ptbImagen As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents Panel_cabecera As System.Windows.Forms.Panel
    Private WithEvents lkbCerrar As System.Windows.Forms.Label
    Private WithEvents lblTitulo As System.Windows.Forms.Label
    Private WithEvents ptbIcon As System.Windows.Forms.PictureBox
    Private WithEvents bordeInferior As System.Windows.Forms.Panel
    Private WithEvents bordeDerecha As System.Windows.Forms.Panel
    Private WithEvents bordeIzquierda As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbxPlanesFunerarios As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lkbAgregarItem As System.Windows.Forms.LinkLabel
    Friend WithEvents btnGuardarTabPage2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtgDetallesPlanes As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VerPlan As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents lblTotal As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CodigoDetalle As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Button As DataGridViewButtonColumn
    Private WithEvents lb_min As Label
End Class
