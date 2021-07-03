

Imports System.Drawing.Drawing2D
Imports System.IO
Imports CapaLogicaNegocio
Imports Syncfusion.Pdf
Imports Syncfusion.Pdf.Graphics
Imports Syncfusion.Pdf.Grid

Public Class Frm016_Tarjetas
    Dim down As Boolean = False
    Dim inicial As Point
    Dim down2 As Boolean = False
    Dim inicial2 As Point
    Dim down3 As Boolean = False
    Dim inicial3 As Point
    Dim down4 As Boolean = False
    Dim inicial4 As Point
    Public frm_inicio As Frm_menu = New Frm_menu
    Dim C As New clsContratos 'Instanciamos la clase clsUsuario de la Capa Logica de Negocio para usar sus funciones
    Private Sub cb_diseño_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_diseño.SelectedIndexChanged
        If cb_diseño.SelectedIndex = 0 Then
            'pb_tarjeta.ImageLocation = "C:\Funeraria\Tarjetas\tarjeta-cielo.png"
            'pb_tarjeta.SizeMode = PictureBoxSizeMode.StretchImage
            pn_imagen.BackgroundImage = System.Drawing.Image.FromFile("C:\Funeraria\Tarjetas\tarjeta-cielo.png")
            pn_imagen.BackgroundImageLayout = ImageLayout.Stretch
        ElseIf cb_diseño.SelectedIndex = 1 Then
            pn_imagen.BackgroundImage = System.Drawing.Image.FromFile("C:\Funeraria\Tarjetas\tarjeta 2.jpg")
            pn_imagen.BackgroundImageLayout = ImageLayout.Stretch
        ElseIf cb_diseño.SelectedIndex = 2 Then
            pn_imagen.BackgroundImage = System.Drawing.Image.FromFile("C:\Funeraria\Tarjetas\tarjeta 3.jpg")
            pn_imagen.BackgroundImageLayout = ImageLayout.Stretch
        ElseIf cb_diseño.SelectedIndex = 3 Then
            pn_imagen.BackgroundImage = System.Drawing.Image.FromFile("C:\Funeraria\Tarjetas\tarjeta 4.jpg")
            pn_imagen.BackgroundImageLayout = ImageLayout.Stretch


        End If
    End Sub

    Private Sub lkbCerrar_Click(sender As Object, e As EventArgs) Handles lkbCerrar.Click
        Me.Close()
    End Sub

    Private Sub Frm016_Tarjetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_diseño.SelectedIndex = 0
        lb_apellidos.Text = ""
        lb_nombre.Text = ""
        lb_texto.Text = ""
        Listar_textos()
        cb_religion.SelectedIndex = 0
        cb_nombre_textos.SelectedIndex = 0
    End Sub

    Private Sub tb_difunto_TextChanged(sender As Object, e As EventArgs) Handles tb_apellidos.TextChanged
        lb_apellidos.Text = tb_apellidos.Text
    End Sub

    Private Sub tb_nombre_TextChanged(sender As Object, e As EventArgs) Handles tb_nombre.TextChanged
        lb_nombre.Text = tb_nombre.Text
    End Sub

    Private Sub lb_apellidos_MouseMove(sender As Object, e As MouseEventArgs) Handles lb_apellidos.MouseMove
        'Dim ctrl As Control = sender

        'Dim p1 As Point = ctrl.PointToScreen(e.Location)

        'Dim p2 As Point = ctrl.Parent.PointToClient(p1)

        'ctrl.Location = p2

        Dim ctrl As Control = sender
        If (down) Then
            ctrl.Left = e.X + ctrl.Left - inicial.X
            ctrl.Top = e.Y + ctrl.Top - inicial.Y
        End If


    End Sub

    Private Sub lb_apellidos_MouseUp(sender As Object, e As MouseEventArgs) Handles lb_apellidos.MouseUp
        down = False
    End Sub

    Private Sub lb_apellidos_MouseDown(sender As Object, e As MouseEventArgs) Handles lb_apellidos.MouseDown
        If e.Button = MouseButtons.Left Then
            down = True
            inicial = e.Location
        End If
    End Sub

    Private Sub lb_nombre_MouseMove(sender As Object, e As MouseEventArgs) Handles lb_nombre.MouseMove
        Dim ctrl As Control = sender
        If (down2) Then
            ctrl.Left = e.X + ctrl.Left - inicial2.X
            ctrl.Top = e.Y + ctrl.Top - inicial2.Y
        End If
    End Sub

    Private Sub lb_nombre_MouseDown(sender As Object, e As MouseEventArgs) Handles lb_nombre.MouseDown
        If e.Button = MouseButtons.Left Then
            down2 = True
            inicial2 = e.Location
        End If
    End Sub

    Private Sub lb_nombre_MouseUp(sender As Object, e As MouseEventArgs) Handles lb_nombre.MouseUp
        down2 = False
    End Sub

    Private Sub dtpFechaNac_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaNac.ValueChanged
        lb_fecha_nacimiento.Text = dtpFechaNac.Value.ToString("dd MMMM yyyy")
    End Sub

    Private Sub dtpFechaFallec_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaFallec.ValueChanged
        lb_fecha_fallecimiento.Text = dtpFechaFallec.Value.ToString("dd MMMM yyyy")
    End Sub

    Private Sub rb_texto_TextChanged(sender As Object, e As EventArgs) Handles rb_texto.TextChanged
        lb_texto.Text = rb_texto.Text
    End Sub

    Private Sub btn_exportar_Click(sender As Object, e As EventArgs) Handles btn_exportar.Click
        Dim document As New PdfDocument()
        'Adds page settings
        document.PageSettings.Orientation = PdfPageOrientation.Landscape
        document.PageSettings.Margins.All = 50
        'Adds a page to the document
        Dim page As PdfPage = document.Pages.Add()
        'Loads the image from disk 
        Dim bm As New Bitmap(pn_imagen.Size.Width, pn_imagen.Size.Height)
        pn_imagen.DrawToBitmap(bm, New System.Drawing.Rectangle(0, 0, bm.Width, bm.Height))
        'Dim MS As New MemoryStream
        'bm.Save(MS, Imaging.ImageFormat.Jpeg)

        '(MS.GetBuffer)
        Dim image As PdfImage = PdfImage.FromImage(bm)
        'Draws the image to the PDF page
        Dim g As PdfGraphics = page.Graphics
        page.Graphics.DrawImage(image, New RectangleF(0, 0, 180, 500))
        page.Graphics.DrawImage(image, New RectangleF(190, 0, 180, 500))
        page.Graphics.DrawImage(image, New RectangleF(380, 0, 180, 500))
        page.Graphics.DrawImage(image, New RectangleF(570, 0, 180, 500))
        Dim Font As PdfStandardFont = New PdfStandardFont(PdfFontFamily.TimesRoman, 14)

        'Creates the layout format for grid
        Dim layoutFormat As New PdfGridLayoutFormat()
        'Layout format settings to allow the table pagination
        layoutFormat.Layout = PdfLayoutType.Paginate
        'Draws the grid to the PDF page.


        document.Save("Tarjetas.pdf")
        document.Close(True)
        System.Diagnostics.Process.Start("Tarjetas.pdf")
        MessageBox.Show("Informacion se exporto correctamente !!!", "Info")
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim Mensaje As String = "" 'Variable para recuperar el mensaje del procedimiento almacenado de la BD
        C.TipoTexto = cb_tipo.SelectedItem
        C.NombreTexto = tb_nombre_texto.Text
        C.Texto = rtxt_texto.Text

        Mensaje = C.Registrar_texto()
        cb_tipo.SelectedIndex = 0
        tb_nombre_texto.Clear()
        rtxt_texto.Clear()
        Listar_textos()
        clsMensaje.mostrar_mensaje(Mensaje, "ok")
    End Sub
    Private Sub Listar_textos()
        Llenar_Grilla(C.Listar_textos())
    End Sub

    Private Sub Llenar_Grilla(ByVal dt As DataTable)
        Try
            Dgv_textos.Rows.Clear()

            For i = 0 To dt.Rows.Count - 1
                Dgv_textos.Rows.Add(dt.Rows(i)(0))
                Dgv_textos.Rows(i).Cells(0).Value = CInt(dt.Rows(i)(0).ToString())
                Dgv_textos.Rows(i).Cells(1).Value = dt.Rows(i)(1).ToString()
                Dgv_textos.Rows(i).Cells(2).Value = dt.Rows(i)(2).ToString()
                Dgv_textos.Rows(i).Cells(3).Value = dt.Rows(i)(3).ToString()
                Dgv_textos.Rows(i).Cells(4).Value = "Editar"


            Next
            Me.Dgv_textos.ClearSelection()
            For Each row As DataGridViewRow In Dgv_textos.Rows
                Dim button1 As DataGridViewButtonCell = CType(row.Cells(4), DataGridViewButtonCell)

                button1.Style.BackColor = Color.FromArgb(92, 184, 92)
                button1.Style.ForeColor = Color.White
                button1.Style.Font = New Font("Arial", 9, FontStyle.Bold)

            Next
        Catch ex As Exception
            clsMensaje.mostrar_mensaje(ex.Message, "error")
        End Try

    End Sub

    Private Sub cb_religion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_religion.SelectedIndexChanged
        If cb_religion.SelectedIndex = 1 Then
            C.TipoReligion = "Evangélico"
            Listar_religion()
        ElseIf cb_religion.SelectedIndex = 2 Then
            C.TipoReligion = "Católico"
            Listar_religion()
        End If
    End Sub
    Private Sub Listar_religion()
        Dim dt As New DataTable

        Try
            dt = C.Listar_religion()

            cb_nombre_textos.ValueMember = "id_tarjeta"
            cb_nombre_textos.DisplayMember = "nombre_texto"
            cb_nombre_textos.DataSource = dt

        Catch ex As Exception
            clsMensaje.mostrar_mensaje(ex.Message, "error")
        End Try
    End Sub

    Private Sub cb_nombre_textos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_nombre_textos.SelectedIndexChanged
        If (cb_nombre_textos.SelectedIndex > 0) Then
            C.CodigoTexto = cb_nombre_textos.SelectedValue
            rb_texto.Text = C.Devolver_texto()
        End If
    End Sub

    Private Sub btn_mas_Click(sender As Object, e As EventArgs) Handles btn_mas.Click
        lb_apellidos.Font = New Font(lb_apellidos.Name, lb_apellidos.Font.Size + 1, FontStyle.Regular)
    End Sub

    Private Sub btnmenos_Click(sender As Object, e As EventArgs) Handles btnmenos.Click
        lb_apellidos.Font = New Font(lb_apellidos.Name, lb_apellidos.Font.Size - 1, FontStyle.Regular)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lb_nombre.Font = New Font(lb_nombre.Name, lb_nombre.Font.Size + 1, FontStyle.Regular)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lb_nombre.Font = New Font(lb_nombre.Name, lb_nombre.Font.Size - 1, FontStyle.Regular)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then


            lb_nombre.ForeColor = ColorDialog1.Color
            lb_fecha_fallecimiento.ForeColor = ColorDialog1.Color
            lb_fecha_nacimiento.ForeColor = ColorDialog1.Color
            lb_apellidos.ForeColor = ColorDialog1.Color
            lb_texto.ForeColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub lb_texto_MouseDown(sender As Object, e As MouseEventArgs) Handles lb_texto.MouseDown
        If e.Button = MouseButtons.Left Then
            down3 = True
            inicial3 = e.Location
        End If
    End Sub

    Private Sub lb_texto_MouseLeave(sender As Object, e As EventArgs) Handles lb_texto.MouseLeave

    End Sub

    Private Sub lb_texto_MouseMove(sender As Object, e As MouseEventArgs) Handles lb_texto.MouseMove

        Dim ctrl As Control = sender
        If (down3) Then
            ctrl.Left = e.X + ctrl.Left - inicial3.X
            ctrl.Top = e.Y + ctrl.Top - inicial3.Y
        End If

    End Sub

    Private Sub lb_texto_MouseUp(sender As Object, e As MouseEventArgs) Handles lb_texto.MouseUp
        down3 = False
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles pb_difunto.Click





    End Sub

    Private Sub pb_difunto_MouseDown(sender As Object, e As MouseEventArgs) Handles pb_difunto.MouseDown
        If e.Button = MouseButtons.Left Then
            down4 = True
            inicial4 = e.Location
        End If
    End Sub

    Private Sub pb_difunto_MouseMove(sender As Object, e As MouseEventArgs) Handles pb_difunto.MouseMove
        Dim ctrl As Control = sender
        If (down4) Then
            ctrl.Left = e.X + ctrl.Left - inicial4.X
            ctrl.Top = e.Y + ctrl.Top - inicial4.Y
        End If
    End Sub

    Private Sub pb_difunto_MouseUp(sender As Object, e As MouseEventArgs) Handles pb_difunto.MouseUp
        down4 = False
    End Sub

    Private Sub pb_difunto_DoubleClick(sender As Object, e As EventArgs) Handles pb_difunto.DoubleClick
        Dim OpenFile As New OpenFileDialog()
        Try

            Using ofd As New OpenFileDialog
                    ofd.Filter = "Image Files|*.jpg;*.png;*.bmp"
                    ofd.Multiselect = False
                    If ofd.ShowDialog = DialogResult.OK Then
                        MakeRoundedImage(Image.FromFile(ofd.FileName), pb_difunto)
                        pb_difunto.SizeMode = PictureBoxSizeMode.StretchImage
                    End If
                End Using



        Catch ex As Exception
            clsMensaje.mostrar_mensaje("Debe elegir una imagen", "error")
        End Try


    End Sub
    Private Sub MakeRoundedImage(ByVal Img As Image, ByVal PicBox As PictureBox)
        Using bm As New Bitmap(Img.Width, Img.Height)
            Using grx2 As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(bm)
                grx2.SmoothingMode = SmoothingMode.AntiAlias
                Using tb As New TextureBrush(Img)
                    tb.TranslateTransform(0, 0)
                    Using gp As New GraphicsPath
                        gp.AddEllipse(0, 0, Img.Width, Img.Height)
                        grx2.FillPath(tb, gp)
                    End Using
                End Using
            End Using
            If PicBox.Image IsNot Nothing Then PicBox.Image.Dispose()
            PicBox.Image = New Bitmap(bm)
        End Using
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If FontDialog1.ShowDialog() = DialogResult.OK Then


            lb_nombre.Font = FontDialog1.Font
            lb_fecha_fallecimiento.Font = FontDialog1.Font
            lb_fecha_nacimiento.Font = FontDialog1.Font
            lb_apellidos.Font = FontDialog1.Font
            lb_texto.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub Label34_Click(sender As Object, e As EventArgs) Handles Label34.Click


        frm_inicio.pn_principal.Controls.Clear()
        frm_inicio.pn_principal.Hide()

        Me.Hide()
    End Sub
End Class