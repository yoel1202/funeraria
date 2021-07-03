Imports CapaLogicaNegocio

Public Class Frm012_liquidaciones
    Public C As New clsContratos
    Private Sub Frm012_liquidaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar_abonos()
    End Sub

    Private Sub Listar_abonos()
        Try 'Manejamos una excepción de errores
            Llenar_Grilla(C.Listar_liquidaciones_contratos())
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Llenar_Grilla(ByVal dt As DataTable) 'Método para realizar el listado de todos los Productos
        dgv_liquidaciones.Rows.Clear() 'Limpiamos el control DataGridView1
        For i = 0 To dt.Rows.Count - 1 'Recorremos el DataTable
            dgv_liquidaciones.Rows.Add(dt.Rows(i)(0)) 'Agregamos una nueva fila en blanco
            dgv_liquidaciones.Rows(i).Cells(0).Value = dt.Rows(i)(0).ToString()
            dgv_liquidaciones.Rows(i).Cells(1).Value = dt.Rows(i)(1).ToString()
            dgv_liquidaciones.Rows(i).Cells(2).Value = dt.Rows(i)(2).ToString()
            dgv_liquidaciones.Rows(i).Cells(3).Value = dt.Rows(i)(3).ToString()
            dgv_liquidaciones.Rows(i).Cells(4).Value = dt.Rows(i)(4).ToString()


        Next
        dgv_liquidaciones.ClearSelection() 'Limpiamos la selección del DataGridView1
    End Sub
    Private Sub Listar_detalle()
        Try 'Manejamos una excepción de errores
            Llenar_Grilla_detalle(C.Listar_liquidaciones_Productos())
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Llenar_Grilla_detalle(ByVal dt As DataTable) 'Método para realizar el listado de todos los Productos
        dgv_detalles_liquidaciones.Rows.Clear() 'Limpiamos el control DataGridView1
        For i = 0 To dt.Rows.Count - 1 'Recorremos el DataTable
            dgv_detalles_liquidaciones.Rows.Add(dt.Rows(i)(0)) 'Agregamos una nueva fila en blanco
            dgv_detalles_liquidaciones.Rows(i).Cells(0).Value = dt.Rows(i)(0).ToString()
            dgv_detalles_liquidaciones.Rows(i).Cells(1).Value = dt.Rows(i)(1).ToString()
            dgv_detalles_liquidaciones.Rows(i).Cells(2).Value = dt.Rows(i)(2).ToString()
            dgv_detalles_liquidaciones.Rows(i).Cells(3).Value = dt.Rows(i)(3).ToString()
            dgv_detalles_liquidaciones.Rows(i).Cells(4).Value = dt.Rows(i)(4).ToString()
            dgv_detalles_liquidaciones.Rows(i).Cells(5).Value = dt.Rows(i)(5).ToString()

        Next
        dgv_detalles_liquidaciones.ClearSelection() 'Limpiamos la selección del DataGridView1
    End Sub

    Private Sub lkb_cerrar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lkb_cerrar.LinkClicked
        Me.Close()
    End Sub

    Private Sub dgv_liquidaciones_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_liquidaciones.CellClick
        C.CodigoLiquidaciones = dgv_liquidaciones.CurrentRow.Cells(0).Value.ToString()
        Listar_detalle()
        lblTotal.Text = CalcularTotal()
        lblIgv.Text = CalcularIgv()
        lblSubTotal.Text = CalcularSubTotal()
    End Sub

    Private Sub dgv_liquidaciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_liquidaciones.CellContentClick

    End Sub

    Private Function CalcularTotal() As String
        Dim Total As Decimal = 0
        For i = 0 To dgv_detalles_liquidaciones.RowCount - 1
            Total += CDec(dgv_detalles_liquidaciones.Rows(i).Cells(3).Value)
        Next
        Return Total
    End Function

    Private Function CalcularIgv() As String
        Dim igv As Decimal = 0
        For i = 0 To dgv_detalles_liquidaciones.RowCount - 1
            igv += ((CDec(dgv_detalles_liquidaciones.Rows(i).Cells(2).Value) * CInt(dgv_detalles_liquidaciones.Rows(i).Cells(3).Value)) / 1.13) * 0.13
        Next
        Return Math.Round(igv, 2)
    End Function

    Private Function CalcularSubTotal() As String
        Dim SubTotal As Decimal = 0
        For i = 0 To dgv_detalles_liquidaciones.RowCount - 1
            SubTotal += (CDec(dgv_detalles_liquidaciones.Rows(i).Cells(2).Value) * CInt(dgv_detalles_liquidaciones.Rows(i).Cells(3).Value)) / 1.13
        Next
        Return Math.Round(SubTotal, 2)
    End Function
End Class