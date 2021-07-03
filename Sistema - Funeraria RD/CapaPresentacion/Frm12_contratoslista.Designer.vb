<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm12_contratoslista
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel_cabecera = New System.Windows.Forms.Panel()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.lkb_cerrar = New System.Windows.Forms.LinkLabel()
        Me.lkb_min = New System.Windows.Forms.LinkLabel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Dgv_contratos = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vendedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.condicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Consecutivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ahorrado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Plazo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Zona = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lugar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fechac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Forma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Imagen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Editar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.CodigoClient = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoPer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDatos = New System.Windows.Forms.TextBox()
        Me.Panel_cabecera.SuspendLayout()
        Me.panel1.SuspendLayout()
        CType(Me.Dgv_contratos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_cabecera
        '
        Me.Panel_cabecera.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Panel_cabecera.Controls.Add(Me.panel1)
        Me.Panel_cabecera.Controls.Add(Me.lblTitulo)
        Me.Panel_cabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_cabecera.Location = New System.Drawing.Point(0, 0)
        Me.Panel_cabecera.Name = "Panel_cabecera"
        Me.Panel_cabecera.Size = New System.Drawing.Size(994, 31)
        Me.Panel_cabecera.TabIndex = 274
        '
        'panel1
        '
        Me.panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel1.BackColor = System.Drawing.Color.Transparent
        Me.panel1.Controls.Add(Me.lkb_cerrar)
        Me.panel1.Controls.Add(Me.lkb_min)
        Me.panel1.Location = New System.Drawing.Point(927, 0)
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
        Me.lblTitulo.Size = New System.Drawing.Size(122, 15)
        Me.lblTitulo.TabIndex = 205
        Me.lblTitulo.Text = "Listado de Contratos"
        '
        'Dgv_contratos
        '
        Me.Dgv_contratos.AllowUserToAddRows = False
        Me.Dgv_contratos.BackgroundColor = System.Drawing.SystemColors.Window
        Me.Dgv_contratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_contratos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.cliente, Me.Vendedor, Me.Numero, Me.condicion, Me.Consecutivo, Me.Ahorrado, Me.Monto, Me.Plazo, Me.cuota, Me.Zona, Me.lugar, Me.Fechac, Me.Forma, Me.Observacion, Me.fecha, Me.Imagen, Me.Estado, Me.Eliminar, Me.Editar, Me.CodigoClient, Me.CodigoPer})
        Me.Dgv_contratos.Location = New System.Drawing.Point(16, 100)
        Me.Dgv_contratos.Name = "Dgv_contratos"
        Me.Dgv_contratos.RowHeadersWidth = 51
        Me.Dgv_contratos.Size = New System.Drawing.Size(966, 195)
        Me.Dgv_contratos.TabIndex = 275
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "CodigoContrato"
        Me.Codigo.MinimumWidth = 6
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Visible = False
        Me.Codigo.Width = 125
        '
        'cliente
        '
        Me.cliente.HeaderText = "Cliente"
        Me.cliente.Name = "cliente"
        '
        'Vendedor
        '
        Me.Vendedor.HeaderText = "Vendedor"
        Me.Vendedor.Name = "Vendedor"
        '
        'Numero
        '
        Me.Numero.HeaderText = "Numero de Contrato"
        Me.Numero.MinimumWidth = 6
        Me.Numero.Name = "Numero"
        Me.Numero.Width = 125
        '
        'condicion
        '
        Me.condicion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.condicion.HeaderText = "Tipo Contrato"
        Me.condicion.MinimumWidth = 6
        Me.condicion.Name = "condicion"
        Me.condicion.ReadOnly = True
        Me.condicion.Width = 88
        '
        'Consecutivo
        '
        Me.Consecutivo.HeaderText = "Consecutivo"
        Me.Consecutivo.Name = "Consecutivo"
        '
        'Ahorrado
        '
        Me.Ahorrado.HeaderText = "Ahorrado"
        Me.Ahorrado.Name = "Ahorrado"
        '
        'Monto
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Monto.DefaultCellStyle = DataGridViewCellStyle1
        Me.Monto.HeaderText = "Monto"
        Me.Monto.MinimumWidth = 6
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        Me.Monto.Width = 70
        '
        'Plazo
        '
        Me.Plazo.HeaderText = "Plazo"
        Me.Plazo.Name = "Plazo"
        '
        'cuota
        '
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.cuota.DefaultCellStyle = DataGridViewCellStyle2
        Me.cuota.HeaderText = "Cuota"
        Me.cuota.MinimumWidth = 6
        Me.cuota.Name = "cuota"
        Me.cuota.ReadOnly = True
        Me.cuota.Width = 125
        '
        'Zona
        '
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Zona.DefaultCellStyle = DataGridViewCellStyle3
        Me.Zona.HeaderText = "Zona"
        Me.Zona.MinimumWidth = 6
        Me.Zona.Name = "Zona"
        Me.Zona.ReadOnly = True
        Me.Zona.Width = 125
        '
        'lugar
        '
        Me.lugar.HeaderText = "Lugar de cobro"
        Me.lugar.MinimumWidth = 6
        Me.lugar.Name = "lugar"
        Me.lugar.Width = 125
        '
        'Fechac
        '
        Me.Fechac.HeaderText = "Fecha de cobro"
        Me.Fechac.MinimumWidth = 6
        Me.Fechac.Name = "Fechac"
        Me.Fechac.Width = 125
        '
        'Forma
        '
        Me.Forma.HeaderText = "Forma Pago"
        Me.Forma.Name = "Forma"
        '
        'Observacion
        '
        Me.Observacion.HeaderText = "Observacion"
        Me.Observacion.MinimumWidth = 6
        Me.Observacion.Name = "Observacion"
        Me.Observacion.Width = 125
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.MinimumWidth = 6
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Width = 125
        '
        'Imagen
        '
        Me.Imagen.HeaderText = "Imagen"
        Me.Imagen.MinimumWidth = 6
        Me.Imagen.Name = "Imagen"
        Me.Imagen.Width = 125
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        '
        'Eliminar
        '
        Me.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Eliminar.HeaderText = "Opción"
        Me.Eliminar.MinimumWidth = 6
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Eliminar.Width = 90
        '
        'Editar
        '
        Me.Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Editar.HeaderText = "Editar"
        Me.Editar.Name = "Editar"
        '
        'CodigoClient
        '
        Me.CodigoClient.HeaderText = "CodigoCliente"
        Me.CodigoClient.Name = "CodigoClient"
        Me.CodigoClient.Visible = False
        '
        'CodigoPer
        '
        Me.CodigoPer.HeaderText = "CodigoPersonal"
        Me.CodigoPer.Name = "CodigoPer"
        Me.CodigoPer.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDatos)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(966, 57)
        Me.GroupBox1.TabIndex = 276
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consultar"
        '
        'txtDatos
        '
        Me.txtDatos.Location = New System.Drawing.Point(19, 19)
        Me.txtDatos.Name = "txtDatos"
        Me.txtDatos.Size = New System.Drawing.Size(610, 20)
        Me.txtDatos.TabIndex = 3
        '
        'Frm12_contratoslista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 317)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Dgv_contratos)
        Me.Controls.Add(Me.Panel_cabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm12_contratoslista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm12_contratoslista"
        Me.Panel_cabecera.ResumeLayout(False)
        Me.Panel_cabecera.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.Dgv_contratos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents Panel_cabecera As Panel
    Private WithEvents panel1 As Panel
    Private WithEvents lkb_cerrar As LinkLabel
    Private WithEvents lkb_min As LinkLabel
    Private WithEvents lblTitulo As Label
    Friend WithEvents Dgv_contratos As DataGridView
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents cliente As DataGridViewTextBoxColumn
    Friend WithEvents Vendedor As DataGridViewTextBoxColumn
    Friend WithEvents Numero As DataGridViewTextBoxColumn
    Friend WithEvents condicion As DataGridViewTextBoxColumn
    Friend WithEvents Consecutivo As DataGridViewTextBoxColumn
    Friend WithEvents Ahorrado As DataGridViewTextBoxColumn
    Friend WithEvents Monto As DataGridViewTextBoxColumn
    Friend WithEvents Plazo As DataGridViewTextBoxColumn
    Friend WithEvents cuota As DataGridViewTextBoxColumn
    Friend WithEvents Zona As DataGridViewTextBoxColumn
    Friend WithEvents lugar As DataGridViewTextBoxColumn
    Friend WithEvents Fechac As DataGridViewTextBoxColumn
    Friend WithEvents Forma As DataGridViewTextBoxColumn
    Friend WithEvents Observacion As DataGridViewTextBoxColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents Imagen As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As DataGridViewButtonColumn
    Friend WithEvents Editar As DataGridViewButtonColumn
    Friend WithEvents CodigoClient As DataGridViewTextBoxColumn
    Friend WithEvents CodigoPer As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDatos As TextBox
End Class
