﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm010_Mensaje
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
        Me.bordeInferior = New System.Windows.Forms.Panel()
        Me.bordeDerecha = New System.Windows.Forms.Panel()
        Me.bordeIzquierda = New System.Windows.Forms.Panel()
        Me.Panel_cabecera = New System.Windows.Forms.Panel()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.lkb_cerrar = New System.Windows.Forms.LinkLabel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblmsj = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Panel_msj = New System.Windows.Forms.Panel()
        Me.ptbIcono = New System.Windows.Forms.PictureBox()
        Me.Panel_cabecera.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.Panel_msj.SuspendLayout()
        CType(Me.ptbIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bordeInferior
        '
        Me.bordeInferior.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bordeInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bordeInferior.Location = New System.Drawing.Point(0, 158)
        Me.bordeInferior.Name = "bordeInferior"
        Me.bordeInferior.Size = New System.Drawing.Size(271, 2)
        Me.bordeInferior.TabIndex = 263
        '
        'bordeDerecha
        '
        Me.bordeDerecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bordeDerecha.Dock = System.Windows.Forms.DockStyle.Right
        Me.bordeDerecha.Location = New System.Drawing.Point(271, 0)
        Me.bordeDerecha.Name = "bordeDerecha"
        Me.bordeDerecha.Size = New System.Drawing.Size(2, 160)
        Me.bordeDerecha.TabIndex = 262
        '
        'bordeIzquierda
        '
        Me.bordeIzquierda.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bordeIzquierda.Dock = System.Windows.Forms.DockStyle.Left
        Me.bordeIzquierda.Location = New System.Drawing.Point(0, 0)
        Me.bordeIzquierda.Name = "bordeIzquierda"
        Me.bordeIzquierda.Size = New System.Drawing.Size(2, 158)
        Me.bordeIzquierda.TabIndex = 264
        '
        'Panel_cabecera
        '
        Me.Panel_cabecera.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Panel_cabecera.Controls.Add(Me.panel1)
        Me.Panel_cabecera.Controls.Add(Me.lblTitulo)
        Me.Panel_cabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_cabecera.Location = New System.Drawing.Point(2, 0)
        Me.Panel_cabecera.Name = "Panel_cabecera"
        Me.Panel_cabecera.Size = New System.Drawing.Size(269, 31)
        Me.Panel_cabecera.TabIndex = 265
        '
        'panel1
        '
        Me.panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel1.BackColor = System.Drawing.Color.Transparent
        Me.panel1.Controls.Add(Me.lkb_cerrar)
        Me.panel1.Location = New System.Drawing.Point(246, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(24, 30)
        Me.panel1.TabIndex = 206
        '
        'lkb_cerrar
        '
        Me.lkb_cerrar.ActiveLinkColor = System.Drawing.Color.DarkRed
        Me.lkb_cerrar.AutoSize = True
        Me.lkb_cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkb_cerrar.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lkb_cerrar.LinkColor = System.Drawing.Color.White
        Me.lkb_cerrar.Location = New System.Drawing.Point(6, 6)
        Me.lkb_cerrar.Name = "lkb_cerrar"
        Me.lkb_cerrar.Size = New System.Drawing.Size(15, 18)
        Me.lkb_cerrar.TabIndex = 1
        Me.lkb_cerrar.TabStop = True
        Me.lkb_cerrar.Text = "x"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Window
        Me.lblTitulo.Location = New System.Drawing.Point(10, 9)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(101, 15)
        Me.lblTitulo.TabIndex = 205
        Me.lblTitulo.Text = "Mensaje de Error"
        '
        'lblmsj
        '
        Me.lblmsj.AutoSize = True
        Me.lblmsj.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmsj.Location = New System.Drawing.Point(46, 13)
        Me.lblmsj.Name = "lblmsj"
        Me.lblmsj.Size = New System.Drawing.Size(118, 15)
        Me.lblmsj.TabIndex = 266
        Me.lblmsj.Text = "No se pudo registrar"
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.SystemColors.Window
        Me.btnAceptar.Location = New System.Drawing.Point(48, 106)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(160, 40)
        Me.btnAceptar.TabIndex = 268
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'Panel_msj
        '
        Me.Panel_msj.AutoSize = True
        Me.Panel_msj.Controls.Add(Me.ptbIcono)
        Me.Panel_msj.Controls.Add(Me.lblmsj)
        Me.Panel_msj.Location = New System.Drawing.Point(43, 51)
        Me.Panel_msj.Name = "Panel_msj"
        Me.Panel_msj.Size = New System.Drawing.Size(173, 41)
        Me.Panel_msj.TabIndex = 269
        '
        'ptbIcono
        '
        Me.ptbIcono.Image = Global.CapaPresentacion.My.Resources.Resources.ic_cancel
        Me.ptbIcono.Location = New System.Drawing.Point(4, 3)
        Me.ptbIcono.Name = "ptbIcono"
        Me.ptbIcono.Size = New System.Drawing.Size(35, 35)
        Me.ptbIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbIcono.TabIndex = 267
        Me.ptbIcono.TabStop = False
        '
        'Frm010_Mensaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(273, 160)
        Me.Controls.Add(Me.Panel_msj)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Panel_cabecera)
        Me.Controls.Add(Me.bordeIzquierda)
        Me.Controls.Add(Me.bordeInferior)
        Me.Controls.Add(Me.bordeDerecha)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm010_Mensaje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMensajeOk"
        Me.Panel_cabecera.ResumeLayout(False)
        Me.Panel_cabecera.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.Panel_msj.ResumeLayout(False)
        Me.Panel_msj.PerformLayout()
        CType(Me.ptbIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents bordeInferior As System.Windows.Forms.Panel
    Private WithEvents bordeDerecha As System.Windows.Forms.Panel
    Private WithEvents bordeIzquierda As System.Windows.Forms.Panel
    Private WithEvents Panel_cabecera As System.Windows.Forms.Panel
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents lkb_cerrar As System.Windows.Forms.LinkLabel
    Friend WithEvents lblmsj As System.Windows.Forms.Label
    Friend WithEvents ptbIcono As System.Windows.Forms.PictureBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Panel_msj As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
End Class