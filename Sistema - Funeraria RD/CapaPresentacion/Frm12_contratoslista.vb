Imports CapaLogicaNegocio

Public Class Frm12_contratoslista
    Dim C As New clsContratos 'Instanciamos la clase clsUsuario de la Capa Logica de Negocio para usar sus funciones
    Dim CR As New ClsCredito
    Public tipo As String
    Public Property Caller1() As IContratos
    Dim estados As String = ""
    Private Sub Frm12_contratoslista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Listar_Contratos()
    End Sub
    Private Sub Listar_Contratos()
        If tipo = "LQ" Then
            Try 'Manejamos una excepción de errores
                Llenar_Grilla(C.listar_liquidados())
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        Else

            Try 'Manejamos una excepción de errores
                Llenar_Grilla(C.Listar_Contratos())
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If



    End Sub
    Private Sub Llenar_Grilla(ByVal dt As DataTable) 'Método para realizar el listado de todos los Productos
        Try
            Dgv_contratos.Rows.Clear()

            For i = 0 To dt.Rows.Count - 1

                Dgv_contratos.Rows.Add(dt.Rows(i)(0))
                Dgv_contratos.Rows(i).Cells(0).Value = CInt(dt.Rows(i)(0).ToString())
                Dgv_contratos.Rows(i).Cells(1).Value = dt.Rows(i)(1).ToString()
                Dgv_contratos.Rows(i).Cells(2).Value = dt.Rows(i)(2).ToString()
                Dgv_contratos.Rows(i).Cells(3).Value = dt.Rows(i)(3).ToString()
                Dgv_contratos.Rows(i).Cells(4).Value = dt.Rows(i)(4).ToString()
                Dgv_contratos.Rows(i).Cells(5).Value = dt.Rows(i)(5).ToString()
                CR.CodigoContrato = CInt(dt.Rows(i)(0).ToString())
                Dgv_contratos.Rows(i).Cells(6).Value = CR.Devolver_monto_credito
                Dgv_contratos.Rows(i).Cells(7).Value = CDec(dt.Rows(i)(6).ToString())
                Dgv_contratos.Rows(i).Cells(8).Value = CInt(dt.Rows(i)(7).ToString())
                Dgv_contratos.Rows(i).Cells(9).Value = CDec(dt.Rows(i)(8).ToString())
                Dgv_contratos.Rows(i).Cells(10).Value = dt.Rows(i)(9).ToString()
                Dgv_contratos.Rows(i).Cells(11).Value = dt.Rows(i)(10).ToString()
                Dgv_contratos.Rows(i).Cells(12).Value = dt.Rows(i)(11).ToString()
                Dgv_contratos.Rows(i).Cells(13).Value = dt.Rows(i)(12).ToString()
                Dgv_contratos.Rows(i).Cells(14).Value = dt.Rows(i)(13).ToString()
                Dgv_contratos.Rows(i).Cells(15).Value = Format(dt.Rows(i)(14), "dd/MM/yyyy")
                Dgv_contratos.Rows(i).Cells(16).Value = dt.Rows(i)(15).ToString()

                If (dt.Rows(i)(16).ToString() = "LIQUIDADO" Or dt.Rows(i)(16).ToString() = "TRASLADO") Then 'Si el Stock es menor a Cero

                    Dgv_contratos.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(255, 135, 135) 'Pintamos toda la fila de color rojo claro 
                    Dgv_contratos.Rows(i).DefaultCellStyle.ForeColor = Color.White 'Asiganmos color blanco al texto


                End If
                Dgv_contratos.Rows(i).Cells(17).Value = dt.Rows(i)(16).ToString()
                Dgv_contratos.Rows(i).Cells(18).Value = "Ver Información"
                Dgv_contratos.Rows(i).Cells(19).Value = "Editar"
                Dgv_contratos.Rows(i).Cells(20).Value = dt.Rows(i)(17).ToString()
                Dgv_contratos.Rows(i).Cells(21).Value = dt.Rows(i)(18).ToString()

            Next
            Me.Dgv_contratos.ClearSelection()
            For Each row As DataGridViewRow In Dgv_contratos.Rows
                Dim button1 As DataGridViewButtonCell = CType(row.Cells(18), DataGridViewButtonCell)
                Dim button2 As DataGridViewButtonCell = CType(row.Cells(19), DataGridViewButtonCell)
                button1.Style.BackColor = Color.FromArgb(92, 184, 92)
                button1.Style.ForeColor = Color.White
                button1.Style.Font = New Font("Arial", 9, FontStyle.Bold)
                button2.Style.BackColor = Color.FromArgb(92, 184, 92)
                button2.Style.ForeColor = Color.White
                button2.Style.Font = New Font("Arial", 9, FontStyle.Bold)
            Next
        Catch ex As Exception
            clsMensaje.mostrar_mensaje(ex.Message, "error")
        End Try
    End Sub

    Private Sub lkb_cerrar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lkb_cerrar.LinkClicked
        Me.Close()
    End Sub

    Private Sub Dgv_contratos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_contratos.CellClick
        If (Me.Dgv_contratos.Rows.Count > 0) Then
            Me.Dgv_contratos.Rows(Me.Dgv_contratos.CurrentRow.Index).Selected = True
        End If
    End Sub

    Private Sub Dgv_contratos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_contratos.CellContentClick
        Try
            'Si el row en el que hicimos doble click es el encabezado del DataGridView, nos retornamos.
            If e.RowIndex = -1 Then
                Return
            End If


            'Obtenemos el row en el cual se hizo doble Click
            Dim row As DataGridViewRow = Dgv_contratos.Rows(e.RowIndex)
            CR.CodigoContrato = CInt(row.Cells(0).Value)

            Dim ahorrado As Decimal = CR.Devolver_monto_credito

            If (ahorrado <= 0) Then
                If (tipo = "LQ") Then
                    obtenerdatos(row)


                Else

                    clsMensaje.mostrar_mensaje("El contrato Seleccionado esta liquidado o trasladado a otro contrato", "error")
                End If
            Else
                'Instanciamos la clase EProveedor para cargar los datos tomandolos de las celdas del row
                'Recuerde convertir al tipo de dato correcto
                obtenerdatos(row)

            End If
        Catch ex As Exception
            MessageBox.Show(String.Format("Error : {0}", ex.Message), "Error Inesperado", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Sub obtenerdatos(row As DataGridViewRow)
        Dim item As New EContratos()
        item.CodigoContrato = Convert.ToInt32(row.Cells("Codigo").Value)
        item.Numero_contrato = Convert.ToString(row.Cells("Numero").Value)
        item.Cliente = Convert.ToString(row.Cells("cliente").Value)
        item.Monto = Convert.ToString(row.Cells("Monto").Value)

        'If (Producto = 0) Then
        'Si no existe llamador para nuestro formulario nos retornamos sin hacer ninguna accion
        If Caller1 Is Nothing Then
            Return
        End If

        'Si el FrmCompras devolvio false por haber encontrado el Proveedor dentro de la lista
        'Informamos de lo sucedido al usuario
        If Not Caller1.LoadDataRow2(item) Then
            MessageBox.Show("El Productos ya existe en la lista", "Atención", MessageBoxButtons.OK, MessageBoxIcon.[Stop])
        End If
        'Else
        ''Si no existe llamador para nuestro formulario nos retornamos sin hacer ninguna accion
        'If Caller1 Is Nothing Then
        '    Return
        'End If

        ''Si el FrmCompras devolvio false por haber encontrado el Proveedor dentro de la lista
        ''Informamos de lo sucedido al usuario
        'If Not Caller1.LoadDataRow(item) Then
        '    MessageBox.Show("El Productos ya existe en la lista", "Atención", MessageBoxButtons.OK, MessageBoxIcon.[Stop])
        'End If

        Close()

    End Sub
    Private Sub txtDatos_TextChanged(sender As Object, e As EventArgs) Handles txtDatos.TextChanged
        If (txtDatos.Text.Trim() <> "") Then
            Try
                If tipo = "LQ" Then
                    C.dato = CStr(txtDatos.Text)
                    Llenar_Grilla(C.Buscar_contrato_liquidacion())

                Else

                    C.dato = CStr(txtDatos.Text)
                    Llenar_Grilla(C.Buscar_Contratos())
                End If
            Catch ex As Exception
                clsMensaje.mostrar_mensaje(ex.Message, "error")
            End Try
        Else
            Listar_Contratos()
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class