<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm012_liquidaciones
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
        Me.dgv_liquidaciones = New System.Windows.Forms.DataGridView()
        Me.Panel_cabecera = New System.Windows.Forms.Panel()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.lkb_cerrar = New System.Windows.Forms.LinkLabel()
        Me.lkb_min = New System.Windows.Forms.LinkLabel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.bordeDerecha = New System.Windows.Forms.Panel()
        Me.bordeIzquierda = New System.Windows.Forms.Panel()
        Me.bordeInferior = New System.Windows.Forms.Panel()
        Me.dgv_detalles_liquidaciones = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUBTOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblIgv = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_liquidaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_cabecera.SuspendLayout()
        Me.panel1.SuspendLayout()
        CType(Me.dgv_detalles_liquidaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_liquidaciones
        '
        Me.dgv_liquidaciones.AllowUserToAddRows = False
        Me.dgv_liquidaciones.AllowUserToDeleteRows = False
        Me.dgv_liquidaciones.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgv_liquidaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_liquidaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Descripcion, Me.Precio, Me.Comprobante, Me.Fecha})
        Me.dgv_liquidaciones.Location = New System.Drawing.Point(14, 60)
        Me.dgv_liquidaciones.Name = "dgv_liquidaciones"
        Me.dgv_liquidaciones.ReadOnly = True
        Me.dgv_liquidaciones.Size = New System.Drawing.Size(611, 96)
        Me.dgv_liquidaciones.TabIndex = 276
        '
        'Panel_cabecera
        '
        Me.Panel_cabecera.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Panel_cabecera.Controls.Add(Me.panel1)
        Me.Panel_cabecera.Controls.Add(Me.lblTitulo)
        Me.Panel_cabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_cabecera.Location = New System.Drawing.Point(2, 0)
        Me.Panel_cabecera.Name = "Panel_cabecera"
        Me.Panel_cabecera.Size = New System.Drawing.Size(652, 31)
        Me.Panel_cabecera.TabIndex = 277
        '
        'panel1
        '
        Me.panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel1.BackColor = System.Drawing.Color.Transparent
        Me.panel1.Controls.Add(Me.lkb_cerrar)
        Me.panel1.Controls.Add(Me.lkb_min)
        Me.panel1.Location = New System.Drawing.Point(585, 0)
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
        Me.lblTitulo.Size = New System.Drawing.Size(146, 15)
        Me.lblTitulo.TabIndex = 205
        Me.lblTitulo.Text = "Listado de Liquidaciones"
        '
        'bordeDerecha
        '
        Me.bordeDerecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bordeDerecha.Dock = System.Windows.Forms.DockStyle.Right
        Me.bordeDerecha.Location = New System.Drawing.Point(654, 0)
        Me.bordeDerecha.Name = "bordeDerecha"
        Me.bordeDerecha.Size = New System.Drawing.Size(2, 369)
        Me.bordeDerecha.TabIndex = 280
        '
        'bordeIzquierda
        '
        Me.bordeIzquierda.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bordeIzquierda.Dock = System.Windows.Forms.DockStyle.Left
        Me.bordeIzquierda.Location = New System.Drawing.Point(0, 0)
        Me.bordeIzquierda.Name = "bordeIzquierda"
        Me.bordeIzquierda.Size = New System.Drawing.Size(2, 369)
        Me.bordeIzquierda.TabIndex = 279
        '
        'bordeInferior
        '
        Me.bordeInferior.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bordeInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bordeInferior.Location = New System.Drawing.Point(0, 369)
        Me.bordeInferior.Name = "bordeInferior"
        Me.bordeInferior.Size = New System.Drawing.Size(656, 2)
        Me.bordeInferior.TabIndex = 278
        '
        'dgv_detalles_liquidaciones
        '
        Me.dgv_detalles_liquidaciones.AllowUserToAddRows = False
        Me.dgv_detalles_liquidaciones.AllowUserToDeleteRows = False
        Me.dgv_detalles_liquidaciones.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgv_detalles_liquidaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalles_liquidaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.SUBTOTAL})
        Me.dgv_detalles_liquidaciones.Location = New System.Drawing.Point(6, 22)
        Me.dgv_detalles_liquidaciones.Name = "dgv_detalles_liquidaciones"
        Me.dgv_detalles_liquidaciones.ReadOnly = True
        Me.dgv_detalles_liquidaciones.Size = New System.Drawing.Size(611, 118)
        Me.dgv_detalles_liquidaciones.TabIndex = 281
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre Producto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Precio Venta"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 120
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "IVA"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'SUBTOTAL
        '
        Me.SUBTOTAL.HeaderText = "Subtotal"
        Me.SUBTOTAL.Name = "SUBTOTAL"
        Me.SUBTOTAL.ReadOnly = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.dgv_detalles_liquidaciones)
        Me.GroupBox8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(8, 171)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(625, 146)
        Me.GroupBox8.TabIndex = 282
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Productos Aplicados"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(479, 324)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 13)
        Me.Label13.TabIndex = 283
        Me.Label13.Text = "TOTAL:"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(535, 319)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(87, 23)
        Me.lblTotal.TabIndex = 286
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(129, 325)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 13)
        Me.Label12.TabIndex = 288
        Me.Label12.Text = "SUB TOTAL:"
        '
        'lblIgv
        '
        Me.lblIgv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIgv.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIgv.Location = New System.Drawing.Point(372, 319)
        Me.lblIgv.Name = "lblIgv"
        Me.lblIgv.Size = New System.Drawing.Size(87, 23)
        Me.lblIgv.TabIndex = 285
        Me.lblIgv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(326, 325)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 287
        Me.Label7.Text = "I..V.A"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubTotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.Location = New System.Drawing.Point(215, 320)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(87, 23)
        Me.lblSubTotal.TabIndex = 284
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Visible = False
        '
        'Descripcion
        '
        Me.Descripcion.FillWeight = 40.0!
        Me.Descripcion.HeaderText = "Total  Liquidado"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 150
        '
        'Precio
        '
        Me.Precio.HeaderText = "Fecha del Servicio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 150
        '
        'Comprobante
        '
        Me.Comprobante.HeaderText = "Retirado Por"
        Me.Comprobante.Name = "Comprobante"
        Me.Comprobante.ReadOnly = True
        Me.Comprobante.Width = 120
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Difunto"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 150
        '
        'Frm012_liquidaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 371)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblIgv)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.dgv_liquidaciones)
        Me.Controls.Add(Me.Panel_cabecera)
        Me.Controls.Add(Me.bordeDerecha)
        Me.Controls.Add(Me.bordeIzquierda)
        Me.Controls.Add(Me.bordeInferior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm012_liquidaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm012_liquidaciones"
        CType(Me.dgv_liquidaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_cabecera.ResumeLayout(False)
        Me.Panel_cabecera.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.dgv_detalles_liquidaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_liquidaciones As DataGridView
    Private WithEvents Panel_cabecera As Panel
    Private WithEvents panel1 As Panel
    Private WithEvents lkb_cerrar As LinkLabel
    Private WithEvents lkb_min As LinkLabel
    Private WithEvents lblTitulo As Label
    Private WithEvents bordeDerecha As Panel
    Private WithEvents bordeIzquierda As Panel
    Private WithEvents bordeInferior As Panel
    Friend WithEvents dgv_detalles_liquidaciones As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents SUBTOTAL As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblIgv As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Comprobante As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
End Class
