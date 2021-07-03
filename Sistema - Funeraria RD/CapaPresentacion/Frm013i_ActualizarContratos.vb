Imports CapaLogicaNegocio

Public Class Frm013i_ActualizarContratos
    Dim C As New clsContratos 'Instanciamos la clase clsUsuario de la Capa Logica de Negocio para usar sus funciones
    Dim CR As New ClsCredito 'Instanciamos la clase clsUsuario de la Capa Logica de Negocio para usar sus funciones
    Private Sub Frm016_ActualizarContratos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MsgBox(CR.Devolver_periodo())
        Dim Cuenta As Integer = 1
        Button1.Enabled = False

        Dim dt As DataTable = C.Listar_Todos_Contratos
        ProgressBar1.Maximum = dt.Rows.Count()
        For i = 0 To dt.Rows.Count - 1
            Try
                CR.CodigoContrato = dt.Rows(i)(0).ToString()
                Dim mes As Integer = MonthDifference(CDate(CR.Periodos_Recibos()).ToString("dd/MM/yyyy"), DateTime.Now)
                If (mes <= 1) Then
                    Console.WriteLine(mes)
                    C.CodigoContrato = CR.CodigoContrato
                    C.Estado = "ACTIVO PENDIENTE"
                    C.Actualizar_Estados()
                ElseIf (mes = 2) Then
                    Console.WriteLine(mes)
                    C.CodigoContrato = CR.CodigoContrato
                    C.Estado = "MOROSO PENDIENTE"
                    C.Actualizar_Estados()
                ElseIf (mes > 2) Then
                    Console.WriteLine(mes)
                    C.CodigoContrato = CR.CodigoContrato
                    C.Estado = "ANULADO"
                    C.Actualizar_Estados()
                End If
            Catch ex As Exception
                MsgBox("no se pudo actualizar" + ex.Message)

            End Try
            ProgressBar1.Value = Cuenta
            Cuenta = Cuenta + 1
        Next
        C.Actualizar_Estados_recibos()
        mostrar_mensaje("Se actualizaron los contratos correctamente", "ok")
        CR.CodigoContrato = 0
        Button1.Enabled = True
    End Sub
    Function MonthDifference(FechaInicio As DateTime, FechaFin As DateTime) As Decimal
        'Console.WriteLine(FechaInicio.ToString() + ":" + FechaFin + ";" + DateDiff("m", FechaInicio, FechaFin).ToString())
        Return DateDiff("m", FechaInicio, FechaFin)

    End Function

    Private Sub lkbCerrar_Click(sender As Object, e As EventArgs) Handles lkbCerrar.Click
        Close()
    End Sub
End Class