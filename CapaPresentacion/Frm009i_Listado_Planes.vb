﻿Imports CapaLogicaNegocio 'Importamos la capa lógica de negocio

Public Class Frm009i_Listado_Planes

    Public Property Caller() As IPlanServicio
    Public liquidacion As String = ""
    Dim PF As New clsProducto 'Instanciamos la clase clsPlanFunerario de la Capa Logica de Negocio para usar sus funciones
    Dim Stock_Plan = 0
    Private Sub FrmListado_Planes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Listar_Planes_Funerarios()

        Validar.Centrar_Form(Me)
    End Sub

    Private Sub Listar_Planes_Funerarios()
        Dim dt As New DataTable 'Instanciamos o asignamos memoria al DataTable
        Dim dt2, dt3 As New DataTable


        If (liquidacion = "liquidar") Then

            dt = PF.Listar_Productos_liquidaciones
            Try 'Manejamos una excepción de errores

                DataGridView1.Rows.Clear() 'Limpiamos el control DataGridView1

                'Llenamos el DataGridView1 con todos los elementos que contiene el DataTable
                For i = 0 To dt.Rows.Count - 1 'Recorremos el DataTable
                    DataGridView1.Rows.Add(dt.Rows(i)(0)) 'Agregamos una nueva fila en blanco
                    DataGridView1.Rows(i).Cells(0).Value = dt.Rows(i)(0).ToString()
                    DataGridView1.Rows(i).Cells(1).Value = dt.Rows(i)(1).ToString()
                    DataGridView1.Rows(i).Cells(2).Value = Math.Round(CDec(dt.Rows(i)(2)), 2)




                Next
            Catch ex As Exception
                clsMensaje.mostrar_mensaje(ex.Message, "error")
            End Try
        Else
            Try 'Manejamos una excepción de errores
                dt = PF.Listar_Productos_Ventas()
                DataGridView1.Rows.Clear() 'Limpiamos el control DataGridView1

                'Llenamos el DataGridView1 con todos los elementos que contiene el DataTable
                For i = 0 To dt.Rows.Count - 1 'Recorremos el DataTable
                    DataGridView1.Rows.Add(dt.Rows(i)(0)) 'Agregamos una nueva fila en blanco
                    DataGridView1.Rows(i).Cells(0).Value = dt.Rows(i)(0).ToString()
                    DataGridView1.Rows(i).Cells(1).Value = dt.Rows(i)(1).ToString()
                    DataGridView1.Rows(i).Cells(2).Value = Math.Round(CDec(dt.Rows(i)(2)), 2)

                    DataGridView1.Rows(i).Cells(3).Value = dt.Rows(i)(3).ToString()
                    DataGridView1.Rows(i).Cells(4).Value = "Ver Plan"
                    PF.CodigoItem = Convert.ToInt32(dt.Rows(i)(0)) 'Enviamos el código del Plan Funerario
                    dt3 = PF.Verificar_Stock_Productos() 'Consultamos si el plan tiene Stock Disponible
                    If (dt3.Rows(0)(0) <= 0) Then 'Si el Stock es menor a Cero
                        DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(255, 135, 135) 'Pintamos toda la fila de color rojo claro 
                        DataGridView1.Rows(i).DefaultCellStyle.ForeColor = Color.White 'Asiganmos color blanco al texto
                    Else
                        Stock_Plan = dt3.Rows(0)(0)
                    End If
                Next
                DataGridView1.ClearSelection() 'Limpiamos la selección del DataGridView1
                For Each row As DataGridViewRow In DataGridView1.Rows
                    Dim button1 As DataGridViewButtonCell = CType(row.Cells(4), DataGridViewButtonCell)
                    button1.Style.BackColor = Color.FromArgb(92, 184, 92)
                    button1.Style.ForeColor = Color.White
                    button1.Style.Font = New Font("Arial", 9, FontStyle.Bold)
                Next
            Catch ex As Exception
                clsMensaje.mostrar_mensaje(ex.Message, "error")
        End Try
        End If
            'Poblamos el DataTable


    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If (Me.DataGridView1.Columns(e.ColumnIndex).Name.Equals("VerPlan")) Then
            Me.DataGridView1.ClearSelection()
            Dim Frm As New Frm004ii_ModalPlanes()
            Frm.ptImagen.ImageLocation = Me.DataGridView1.CurrentRow.Cells(3).Value.ToString()
            Frm.ShowDialog()
        ElseIf (Me.DataGridView1.Columns(e.ColumnIndex).Name.Equals("Agregar")) Then
            MessageBox.Show("Agregado a la venta")
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If (Me.DataGridView1.Rows.Count > 0) Then
            Me.DataGridView1.Rows(Me.DataGridView1.CurrentRow.Index).Selected = True
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim dt As New DataTable
        Dim dt2 As New DataTable

        If (liquidacion = "liquidar") Then
            Try
                'Si el row en el que hicimos doble click es el encabezado del DataGridView, nos retornamos.
                If e.RowIndex = -1 Then
                    Return
                End If
                'Obtenemos el row en el cual se hizo doble Click
                Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

                Dim descripcion2 As String = String.Empty
                Dim titulo2 As String = String.Empty
                Dim RptaDefecto2 As String = String.Empty

                Dim Rpta2 As Object
                Dim descripcion As String = String.Empty
                Dim titulo As String = String.Empty
                Dim RptaDefecto As String = String.Empty
                Dim cantidades As Integer = 0
                Dim precios As Decimal = 0
                Dim Rpta As Object
                'Asignamos una breve descripción al InputBox
                descripcion = "Ingrese la Cantidad a Vender"
                'Título del InputBox
                titulo = "Cantidad"
                'Asignamos un valor por defecto
                RptaDefecto = 1
                'Mostramos la descripción, el título y el valor por defecto
                Rpta = InputBox(descripcion, titulo, RptaDefecto)
                cantidades = GetValue()
                descripcion2 = "Ingrese el precio a Vender"
                'Título del InputBox
                titulo2 = "Precio Venta"
                'Asignamos un valor por defecto
                RptaDefecto2 = 1
                'Mostramos la descripción, el título y el valor por defecto
                Rpta2 = InputBox(descripcion2, titulo2, RptaDefecto2)
                precios = GetValue()
                PF.CodigoItem = Convert.ToInt32(row.Cells("Codigo").Value) 'Enviamos el código del Plan Funerario

                If (Rpta.ToString.Trim <> "") Then
                    PF.CodigoItem = Convert.ToInt32(row.Cells("Codigo").Value)

                    dt = PF.Listar_Detalle_Producto()


                    lst.Add(New EDetalleItem With {.CodigoItem = CInt(dt.Rows(0)(0)),
                                                           .CodigoPlan = CInt(dt.Rows(0)(1)),
                                                           .Nombre = CStr(dt.Rows(0)(2)),
                                                           .Precio = CDec(precios),
                                                           .Cantidad = CInt(cantidades),
                                                           .SubTotal = (.Precio * .Cantidad) / 1.13,
                                                           .Igv = .SubTotal * 0.13})


                    'Instanciamos la clase EPlanServicio para cargar los datos tomandolos de las celdas del row
                    'Recuerde convertir al tipo de dato correcto
                    Dim item As New EPlanServicio()
                    item.Codigo = Convert.ToInt32(row.Cells("Codigo").Value)
                    item.Descripcion = Convert.ToString(row.Cells("Descripcion").Value)
                    item.Precio = Convert.ToDecimal(precios)
                    item.Cantidad = Convert.ToInt32(cantidades)

                    'Si no existe llamador para nuestro formulario nos retornamos sin hacer ninguna accion
                    If Caller Is Nothing Then
                        Return
                    End If

                    'Si el FrmCompras devolvio false por haber encontrado el Plan Funerario dentro de la lista
                    'Informamos de lo sucedido al usuario
                    If Not Caller.LoadDataRow1(item) Then
                        clsMensaje.mostrar_mensaje("El plan Funerario ya existe en la lista", "error")
                        'MessageBox.Show("El plan Funerario ya existe en la lista", "Atención", MessageBoxButtons.OK, MessageBoxIcon.[Stop])
                    End If
                    Close()
                Else
                    Return 'Si es vacío retornamos al mismo formulario
                End If
            Catch ex As Exception
                clsMensaje.mostrar_mensaje(String.Format("Error : {0}", ex.Message), "error")
            End Try
        Else
            Try
                'Si el row en el que hicimos doble click es el encabezado del DataGridView, nos retornamos.
                If e.RowIndex = -1 Then
                    Return
                End If
                'Obtenemos el row en el cual se hizo doble Click
                Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
                If (row.DefaultCellStyle.BackColor = Color.Red) Then
                    clsMensaje.mostrar_mensaje("El " & row.Cells("Descripcion").Value & " no tiene ningún Item", "error")
                ElseIf (row.DefaultCellStyle.BackColor = Color.FromArgb(255, 135, 135)) Then
                    clsMensaje.mostrar_mensaje("El " & row.Cells("Descripcion").Value & " no tiene Stock disponible", "error")
                    Return
                End If

                Dim descripcion As String = String.Empty
                Dim titulo As String = String.Empty
                Dim RptaDefecto As String = String.Empty

                Dim Rpta As Object
                'Asignamos una breve descripción al InputBox
                descripcion = "Ingrese la Cantidad a Vender"
                'Título del InputBox
                titulo = "Sistema para Funeraria"
                'Asignamos un valor por defecto
                RptaDefecto = 1
                'Mostramos la descripción, el título y el valor por defecto
                Rpta = InputBox(descripcion, titulo, RptaDefecto)

                PF.CodigoItem = Convert.ToInt32(row.Cells("Codigo").Value) 'Enviamos el código del Plan Funerario
                dt2 = PF.Verificar_Stock_Productos()
                Stock_Plan = dt2.Rows(0)(0)
                If (Rpta > Stock_Plan) Then
                    clsMensaje.mostrar_mensaje("El Stock del producto Seleccionado es Insuficiente", "error")
                ElseIf (Rpta.ToString.Trim <> "") Then
                    PF.CodigoItem = Convert.ToInt32(row.Cells("Codigo").Value)

                    dt = PF.Listar_Detalle_Producto()


                    lst.Add(New EDetalleItem With {.CodigoItem = CInt(dt.Rows(0)(0)),
                                                           .CodigoPlan = CInt(dt.Rows(0)(1)),
                                                           .Nombre = CStr(dt.Rows(0)(2)),
                                                           .Precio = CDec(dt.Rows(0)(3)),
                                                           .Cantidad = CInt(Rpta),
                                                           .SubTotal = (.Precio * .Cantidad) / 1.13,
                                                           .Igv = .SubTotal * 0.13})


                    'Instanciamos la clase EPlanServicio para cargar los datos tomandolos de las celdas del row
                    'Recuerde convertir al tipo de dato correcto
                    Dim item As New EPlanServicio()
                    item.Codigo = Convert.ToInt32(row.Cells("Codigo").Value)
                    item.Descripcion = Convert.ToString(row.Cells("Descripcion").Value)
                    item.Precio = Convert.ToDecimal(row.Cells("Precio").Value)
                    item.Cantidad = Convert.ToInt32(Rpta)

                    'Si no existe llamador para nuestro formulario nos retornamos sin hacer ninguna accion
                    If Caller Is Nothing Then
                        Return
                    End If

                    'Si el FrmCompras devolvio false por haber encontrado el Plan Funerario dentro de la lista
                    'Informamos de lo sucedido al usuario
                    If Not Caller.LoadDataRow1(item) Then
                        clsMensaje.mostrar_mensaje("El plan Funerario ya existe en la lista", "error")
                        'MessageBox.Show("El plan Funerario ya existe en la lista", "Atención", MessageBoxButtons.OK, MessageBoxIcon.[Stop])
                    End If
                    Close()
                Else
                    Return 'Si es vacío retornamos al mismo formulario
                End If
            Catch ex As Exception
                clsMensaje.mostrar_mensaje(String.Format("Error : {0}", ex.Message), "error")
            End Try
        End If


    End Sub

    Private Function verificarPlan(ByVal CodigoPlan As Integer) As Boolean
        For i = 0 To lst.Count - 1
            If (lst(i).CodigoPlan = CodigoPlan) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub lkb_cerrar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lkb_cerrar.LinkClicked
        Close()
    End Sub
End Class