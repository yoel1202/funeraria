Imports System.IO

Public Class seguridad
    Public ID

    Dim paso As Boolean
    Private Sub seguridad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If File.Exists("configuracion.cfg") Then


            Dim busqueda = New StreamReader("configuracion.cfg")

            Dim cadena
            cadena = busqueda.ReadLine
            Do While (Not cadena Is Nothing)
                Dim campos As String() = cadena.Split(":")
                If campos(0).Equals("guardarpass") Then
                    If campos(1).Equals("True") Then
                        ch_passwordsi.Checked = True
                        paso = False
                    Else
                        ch_passwordno.Checked = True
                        paso = False
                    End If
                ElseIf campos(0).Equals("guardarusuario") Then
                    If campos(1).Equals("True") Then
                        ch_usuariosi.Checked = True
                        paso = False
                    Else
                        ch_usuariono.Checked = True
                        paso = False
                    End If
                End If
                cadena = busqueda.ReadLine
            Loop

            busqueda.Close()


        End If
        paso = True
    End Sub













    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ch_passwordsi.CheckedChanged
        If File.Exists("configuracion.cfg") Then
            If paso Then

                ch_passwordno.Checked = False

                If ch_passwordsi.Checked Then

                    Dim busqueda = New StreamReader("configuracion.cfg")
                    Dim temporal = New StreamWriter("temporal.cfg", True)



                    Dim cadena
                    cadena = busqueda.ReadLine
                    Do While (Not cadena Is Nothing)
                        Dim campos As String() = cadena.Split(":")
                        If campos(0).Equals("guardarpass") Then
                            temporal.WriteLine("guardarpass:True" + ":" + password)
                        ElseIf campos(0).Equals("guardarusuario") And campos.Length > 2 Then

                            temporal.WriteLine(campos(0) + ":" + campos(1) + ":" + campos(2))
                        Else

                            temporal.WriteLine(campos(0) + ":" + campos(1))
                        End If
                        cadena = busqueda.ReadLine
                    Loop

                    temporal.Close()
                    busqueda.Close()
                    File.Delete("configuracion.cfg")
                    File.Move("temporal.cfg", "configuracion.cfg")
                End If
            End If
        End If
    End Sub

    Private Sub ch_usuariosi_CheckedChanged(sender As Object, e As EventArgs) Handles ch_usuariosi.CheckedChanged
        If File.Exists("configuracion.cfg") Then
            If paso Then

                ch_usuariono.Checked = False
                If ch_usuariosi.Checked Then

                    Dim busqueda = New StreamReader("configuracion.cfg")
                    Dim temporal = New StreamWriter("temporal.cfg", True)



                    Dim cadena
                    cadena = busqueda.ReadLine
                    Do While (Not cadena Is Nothing)
                        Dim campos As String() = cadena.Split(":")
                        If campos(0).Equals("guardarusuario") Then
                            temporal.WriteLine("guardarusuario:True" + ":" + usuario_online)

                        ElseIf campos(0).Equals("guardarpass") And campos.Length > 2 Then

                            temporal.WriteLine(campos(0) + ":" + campos(1) + ":" + campos(2))
                        Else

                            temporal.WriteLine(campos(0) + ":" + campos(1))
                        End If
                        cadena = busqueda.ReadLine
                    Loop

                    temporal.Close()
                    busqueda.Close()
                    File.Delete("configuracion.cfg")
                    File.Move("temporal.cfg", "configuracion.cfg")
                End If
            End If
        End If

    End Sub

    Private Sub ch_passwordno_CheckedChanged(sender As Object, e As EventArgs) Handles ch_passwordno.CheckedChanged
        If File.Exists("configuracion.cfg") Then
            If paso Then

                If ch_passwordno.Checked Then
                    ch_passwordsi.Checked = False
                    Dim busqueda = New StreamReader("configuracion.cfg")
                    Dim temporal = New StreamWriter("temporal.cfg", True)



                    Dim cadena
                    cadena = busqueda.ReadLine
                    Do While (Not cadena Is Nothing)
                        Dim campos As String() = cadena.Split(":")
                        If campos(0).Equals("guardarpass") Then
                            temporal.WriteLine("guardarpass:False")
                        ElseIf campos(0).Equals("guardarusuario") And campos.Length > 2 Then

                            temporal.WriteLine(campos(0) + ":" + campos(1) + ":" + campos(2))
                        Else

                            temporal.WriteLine(campos(0) + ":" + campos(1))
                        End If
                        cadena = busqueda.ReadLine
                    Loop

                    temporal.Close()
                    busqueda.Close()
                    File.Delete("configuracion.cfg")
                    File.Move("temporal.cfg", "configuracion.cfg")
                End If
            End If

        End If
    End Sub

    Private Sub ch_usuariono_CheckedChanged(sender As Object, e As EventArgs) Handles ch_usuariono.CheckedChanged
        If File.Exists("configuracion.cfg") Then
            If paso Then
                ch_usuariosi.Checked = False

                If ch_usuariono.Checked Then

                    Dim busqueda = New StreamReader("configuracion.cfg")
                    Dim temporal = New StreamWriter("temporal.cfg", True)



                    Dim cadena
                    cadena = busqueda.ReadLine
                    Do While (Not cadena Is Nothing)
                        Dim campos As String() = cadena.Split(":")
                        If campos(0).Equals("guardarusuario") Then
                            temporal.WriteLine("guardarusuario:False")
                        ElseIf campos(0).Equals("guardarpass") And campos.Length > 2 Then

                            temporal.WriteLine(campos(0) + ":" + campos(1) + ":" + campos(2))
                        Else

                            temporal.WriteLine(campos(0) + ":" + campos(1))
                        End If
                        cadena = busqueda.ReadLine
                    Loop

                    temporal.Close()
                    busqueda.Close()
                    File.Delete("configuracion.cfg")
                    File.Move("temporal.cfg", "configuracion.cfg")
                End If
            End If
        End If
    End Sub
End Class
