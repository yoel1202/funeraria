Imports CapaAccesoDatos
Imports MySql.Data.MySqlClient

Public Class ClsCredito
    Dim M As New clsManejador 'Instanciamos la clase clsManejador
    Public Property CodigoContrato As Integer

    Public Property segundadireccion() As String
    Public Property MontoAbono() As Decimal
    Public Property MontoActual() As Decimal
    Public Property Fecha() As Date
    Public Property Estado() As String
    Public Property Serie() As Integer
    Public Property Periodo() As String
    Public Property CuotasAhorradas() As Integer
    Public Property Ahorrado() As Decimal
    Public Property SaldoCuotas() As Integer
    Public Property NumeroContratos() As Integer
    Public Property CodigoCobros As Integer
    Public Property CodigoCliente() As Integer
    Public Property reconocimiento() As String
    Public Property observaciones() As String
    Public Property Monto() As Decimal
    Public Property Numero_Contrato() As String
    Public Property ncontrato() As String
    Public Property fecha1() As Date
    Public Property fecha2() As Date

    Public Property codigocobroimpreso() As String
    Public Property fechaimpreso() As Date
    Public Property codigocarga() As Integer
    Public Property codigoabono() As Integer
    Public Property ahorradorecibo() As Decimal
    Public Property Scuotas() As Decimal
    Public Property Acuotas() As Decimal
    Public Property periodosrecibo As String
    Public Property tiporecibo As String


    Public Function Devolver_monto_credito() As Integer
        Dim monto As Decimal = 0

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro
        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros

            lst.Add(New clsParametro("@Codigo_contratos", CodigoContrato))
            lst.Add(New clsParametro("@montos", "", MySqlDbType.Decimal, ParameterDirection.Output, 5)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Devolver_monto_credito_cobros", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            monto = lst(1).Valor.ToString() 'Recuperamos el monto de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al devolver el código de la compra, verifique clase clsCredito") 'Creamos una nueva excepción de errores
        End Try
        Return monto 'Retornamos el monto recuperado
    End Function
    Public Function Devolver_n_recibos() As Integer
        Dim Codigo As Integer = 0


        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro
        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros
            lst.Add(New clsParametro("@CodigoContratos", CodigoContrato))
            lst.Add(New clsParametro("@n_recibos", "", MySqlDbType.Int32, ParameterDirection.Output, 30)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Devolver_n_recibos", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Codigo = lst(1).Valor.ToString() 'Recuperamos el código de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al devolver el código del Item, verifique clase clsItem") 'Creamos una nueva excepción de errores
        End Try
        Return Codigo 'Retornamos el código recuperado
    End Function
    Public Function Devolver_tipo_contrato() As String
        Dim tipo As String = ""

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro
        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros

            lst.Add(New clsParametro("@Codigo_contratos", CodigoContrato))
            lst.Add(New clsParametro("@contratos", "", MySqlDbType.VarChar, ParameterDirection.Output, 30)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Devolver_tipo_contratos", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            tipo = lst(1).Valor.ToString() 'Recuperamos el monto de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al devolver el código de la compra, verifique clase clsCredito") 'Creamos una nueva excepción de errores
        End Try
        Return tipo 'Retornamos el monto recuperado
    End Function
    Public Function Devolver_periodo() As Date
        Dim fecha As Date = DateTime.Now

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro
        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros

            lst.Add(New clsParametro("@Codigo_contratos", CodigoContrato))
            lst.Add(New clsParametro("@periodos", "", MySqlDbType.Date, ParameterDirection.Output, 5)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Devolver_periodo", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            fecha = lst(1).Valor.ToString() 'Recuperamos el monto de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al devolver el periodo de contrato, verifique clase clsCredito") 'Creamos una nueva excepción de errores
        End Try
        Return fecha 'Retornamos el monto recuperado
    End Function
    Public Function Periodos_Recibos() As String
        Dim periodo As String = ""

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro
        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros

            lst.Add(New clsParametro("@Codigo_contratos", CodigoContrato))

            lst.Add(New clsParametro("@periodos", "", MySqlDbType.VarChar, ParameterDirection.Output, 50)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Periodos_Recibos", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            periodo = lst(1).Valor.ToString() 'Recuperamos el monto de la Base de Datos

        Catch ex As Exception
            Throw New Exception("Error al devolver el periodo de contrato, verifique clase clsCredito") 'Creamos una nueva excepción de errores
        End Try
        Return periodo 'Retornamos el monto recuperado
    End Function
    Public Function Devolver_ultimo_monto_credito() As Integer
        Dim monto As Decimal = 0

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro
        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros

            lst.Add(New clsParametro("@Codigo_contratos", CodigoContrato))
            lst.Add(New clsParametro("@montos", "", MySqlDbType.Decimal, ParameterDirection.Output, 30)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Devolver_ultimo_monto_credito", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            monto = lst(1).Valor.ToString() 'Recuperamos el monto de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al devolver el código de la compra, verifique clase clsCredito") 'Creamos una nueva excepción de errores
        End Try
        Return monto 'Retornamos el monto recuperado
    End Function
    Public Function Generar_Serie() As String
        Dim Serie As String = "" 'Declaramos la variable para recuperar la Serie de la BD
        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro

        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros
            lst.Add(New clsParametro("@Serie", "", MySqlDbType.Int64, ParameterDirection.Output, 50)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Serie_Documento", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Serie = lst(0).Valor.ToString() 'Recuperamos el código de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al devolver la Serie del documento, verifique clase clsCredito") 'Creamos una nueva excepción de errores
        End Try
        Return Serie
    End Function

    Public Function Obtener_Serie() As String
        Dim Serie As String = "" 'Declaramos la variable para recuperar la Serie de la BD
        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro

        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros
            lst.Add(New clsParametro("@CodigoCobros", CodigoCobros))
            lst.Add(New clsParametro("@Serie", "", MySqlDbType.Int32, ParameterDirection.Output, 30)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("ObtenerSerie", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Serie = lst(1).Valor.ToString() 'Recuperamos el código de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al devolver la Serie del documento, verifique clase clsCredito") 'Creamos una nueva excepción de errores
        End Try
        Return Serie
    End Function
    Public Function ObtenerCodigoSerie() As String
        Dim Serie As String = "" 'Declaramos la variable para recuperar la Serie de la BD
        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro

        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros
            lst.Add(New clsParametro("@CodigoCobros", CodigoCobros))
            lst.Add(New clsParametro("@CodigoSerie", "", MySqlDbType.Int32, ParameterDirection.Output, 30)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("ObtenerCodigoSerie", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Serie = lst(1).Valor.ToString() 'Recuperamos el código de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al devolver la Serie del documento, verifique clase clsCredito") 'Creamos una nueva excepción de errores
        End Try
        Return Serie
    End Function
    Public Function Registrar_Credito() As String
        Dim Mensaje As String = "" 'Declaramos la variable para recuperar el Mensaje

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro

        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros
            lst.Add(New clsParametro("@CodigoContratos", CodigoContrato))
            lst.Add(New clsParametro("@MontoAbono", MontoAbono))
            lst.Add(New clsParametro("@MontoActual", MontoActual))
            lst.Add(New clsParametro("@fechas", Fecha))
            lst.Add(New clsParametro("@Periodos", Periodo))
            lst.Add(New clsParametro("@CuotasAhorradass", CuotasAhorradas))
            lst.Add(New clsParametro("@Ahorrados", Ahorrado))
            lst.Add(New clsParametro("@SaldoCuotass", SaldoCuotas))
            lst.Add(New clsParametro("@reconocimientos", reconocimiento))
            lst.Add(New clsParametro("@observaciones", observaciones))
            lst.Add(New clsParametro("@Mensaje", "", MySqlDbType.VarChar, ParameterDirection.Output, 100)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Registrar_Creditos", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Mensaje = lst(10).Valor.ToString() 'Recuperamos el mensaje de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al registrar el contrato, verifique clase clsCreditos") 'Creamos una nueva excepción de errores
        End Try

        Return Mensaje 'Retornamos el mensaje recuperado
    End Function
    Public Function Registrar_Creditos_Cobros() As String
        Dim Mensaje As String = "" 'Declaramos la variable para recuperar el Mensaje

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro

        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros
            lst.Add(New clsParametro("@CodigoContratos", CodigoContrato))
            lst.Add(New clsParametro("@MontoAbono", MontoAbono))
            lst.Add(New clsParametro("@MontoActual", MontoActual))
            lst.Add(New clsParametro("@fechas", Fecha))
            lst.Add(New clsParametro("@Periodos", Periodo))
            lst.Add(New clsParametro("@CuotasAhorradass", CuotasAhorradas))
            lst.Add(New clsParametro("@Ahorrados", Ahorrado))
            lst.Add(New clsParametro("@SaldoCuotass", SaldoCuotas))
            lst.Add(New clsParametro("@serie", Serie))
            lst.Add(New clsParametro("@Mensaje", "", MySqlDbType.VarChar, ParameterDirection.Output, 100)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Registrar_Creditos_Cobros", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Mensaje = lst(9).Valor.ToString() 'Recuperamos el mensaje de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al registrar el contrato, verifique clase clsCreditos") 'Creamos una nueva excepción de errores
        End Try

        Return Mensaje 'Retornamos el mensaje recuperado
    End Function
    Public Function Registrar_Creditos_Carga() As String
        Dim Mensaje As String = "" 'Declaramos la variable para recuperar el Mensaje

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro

        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros
            lst.Add(New clsParametro("@CodigoContratos", CodigoContrato))
            lst.Add(New clsParametro("@CodigoCargas", codigocarga))
            lst.Add(New clsParametro("@MontoAbono", MontoAbono))
            lst.Add(New clsParametro("@MontoActual", MontoActual))

            lst.Add(New clsParametro("@fechas", Fecha))
            lst.Add(New clsParametro("@Periodos", Periodo))
            lst.Add(New clsParametro("@CuotasAhorradass", CuotasAhorradas))
            lst.Add(New clsParametro("@Ahorrados", Ahorrado))
            lst.Add(New clsParametro("@SaldoCuotass", SaldoCuotas))
            lst.Add(New clsParametro("@serie", Serie))
            lst.Add(New clsParametro("@Mensaje", "", MySqlDbType.VarChar, ParameterDirection.Output, 100)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Registrar_Creditos_Carga", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Mensaje = lst(10).Valor.ToString() 'Recuperamos el mensaje de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al registrar el contrato, verifique clase clsCreditos") 'Creamos una nueva excepción de errores
        End Try

        Return Mensaje 'Retornamos el mensaje recuperado
    End Function
    Public Function Actualizar_fecha_Creditos() As String

        Dim Mensaje As String = "" 'Declaramos la variable para recuperar el Mensaje

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro

        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros
            lst.Add(New clsParametro("@Codigoabonos", codigoabono))
            lst.Add(New clsParametro("@fechas", Fecha))
            lst.Add(New clsParametro("@MontoAbono", MontoAbono))
            lst.Add(New clsParametro("@Mensaje", "", MySqlDbType.VarChar, ParameterDirection.Output, 100)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Actualizar_fecha_Creditos", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Mensaje = lst(3).Valor.ToString() 'Recuperamos el mensaje de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al registrar el contrato, verifique clase clsCreditos") 'Creamos una nueva excepción de errores
        End Try

        Return Mensaje 'Retornamos el mensaje recuperado
    End Function


    Public Function Registrar_impresiones() As String
        Dim Mensaje As String = "" 'Declaramos la variable para recuperar el Mensaje

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro

        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros

            lst.Add(New clsParametro("@Fechas", Fecha))
            lst.Add(New clsParametro("@Serie", Serie))
            lst.Add(New clsParametro("@CodigoContratos", CodigoContrato))
            lst.Add(New clsParametro("@Ahorrados", Ahorrado))
            lst.Add(New clsParametro("@SaldoCuotas", SaldoCuotas))
            lst.Add(New clsParametro("@CuotasAhorradas", CuotasAhorradas))
            lst.Add(New clsParametro("@Mensaje", "", MySqlDbType.VarChar, ParameterDirection.Output, 100)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Registrar_impresiones", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Mensaje = lst(6).Valor.ToString() 'Recuperamos el mensaje de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al registrar el contrato, verifique clase clsCreditos") 'Creamos una nueva excepción de errores
        End Try

        Return Mensaje 'Retornamos el mensaje recuperado
    End Function
    Public Function Aceptar_Cobros() As String
        Dim Mensaje As String = "" 'Declaramos la variable para recuperar el Mensaje

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro

        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros


            lst.Add(New clsParametro("@CodigoContratos", CodigoContrato))
            lst.Add(New clsParametro("@CodigoCobross", CodigoCobros))
            lst.Add(New clsParametro("@MontoAbono", MontoAbono))
            lst.Add(New clsParametro("@MontoActual", MontoActual))
            lst.Add(New clsParametro("@fechas", Fecha))
            lst.Add(New clsParametro("@Periodos", Periodo))
            lst.Add(New clsParametro("@CuotasAhorradass", CuotasAhorradas))
            lst.Add(New clsParametro("@Ahorrados", Ahorrado))
            lst.Add(New clsParametro("@SaldoCuotass", SaldoCuotas))
            lst.Add(New clsParametro("@Mensaje", "", MySqlDbType.VarChar, ParameterDirection.Output, 100)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Aceptar_Cobros", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Mensaje = lst(9).Valor.ToString() 'Recuperamos el mensaje de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al Aceptar el recibo, verifique clase clsCredito") 'Creamos una nueva excepción de errores
        End Try

        Return Mensaje 'Retornamos el mensaje recuperado
    End Function
    Public Function Listar_Carga() As DataTable 'Función para listar Ventas
        Try 'Manejamos una excepción de errores
            Return M.Listado("Listar_Carga", Nothing) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al listar Ventas, verifique clase clsCredito") 'Creamos una nueva excepción de errores
        End Try
    End Function

    Public Function Listar_recibos_creditos() As DataTable 'Función para listar Ventas
        Try 'Manejamos una excepción de errores
            Return M.Listado("Listar_recibos_creditos", Nothing) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al listar Ventas, verifique clase clsCredito") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function Listar_recibos_impresos() As DataTable 'Función para listar Ventas
        Try 'Manejamos una excepción de errores
            Return M.Listado("Listar_recibos_impresos", Nothing) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al listar Ventas, verifique clase clsCredito") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function Registrar_Cobro() As String
        Dim Mensaje As String = "" 'Declaramos la variable para recuperar el Mensaje

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro

        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros
            lst.Add(New clsParametro("@CodigoContratos", CodigoContrato))
            lst.Add(New clsParametro("@Estados", Estado))
            lst.Add(New clsParametro("@Fechas", Fecha))
            lst.Add(New clsParametro("@Mensaje", "", MySqlDbType.VarChar, ParameterDirection.Output, 100)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Registrar_Cobro", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Mensaje = lst(3).Valor.ToString() 'Recuperamos el mensaje de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al registrar el contrato, verifique clase clsCreditos") 'Creamos una nueva excepción de errores
        End Try

        Return Mensaje 'Retornamos el mensaje recuperado
    End Function
    Public Function Registrar_Carga() As String
        Dim Mensajes As String = "" 'Declaramos la variable para recuperar el Mensaje

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro

        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros
            lst.Add(New clsParametro("@CodigoContratos", CodigoContrato))
            lst.Add(New clsParametro("@Estados", Estado))
            lst.Add(New clsParametro("@Fechas", Fecha))
            lst.Add(New clsParametro("@ahorradorecibo", ahorradorecibo))
            lst.Add(New clsParametro("@Scuotas", Scuotas))
            lst.Add(New clsParametro("@Acuotas", Acuotas))
            lst.Add(New clsParametro("@periodosrecibo", periodosrecibo))
            lst.Add(New clsParametro("@tiporecibo", tiporecibo))
            lst.Add(New clsParametro("@Mensaje", "", MySqlDbType.VarChar, ParameterDirection.Output, 100)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Registrar_Carga", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Mensajes = lst(8).Valor.ToString() 'Recuperamos el mensaje de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al registrar el contrato, verifique clase clsCreditos") 'Creamos una nueva excepción de errores
        End Try

        Return Mensajes 'Retornamos el mensaje recuperado
    End Function
    'Public Function Listar_Contratos_Cobros() As DataTable 'Función para listar Ventas
    '    Try 'Manejamos una excepción de errores
    '        Return M.Listado("Listar_Contratos_Cobros", Nothing) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
    '    Catch ex As Exception
    '        Throw New Exception("Error al listar Ventas, verifique clase clsCredito") 'Creamos una nueva excepción de errores
    '    End Try
    'End Function

    Public Function Eliminar_Cobro() As String 'Función para registrar Compras
        Dim Mensaje As String = "" 'Declaramos la variable para recuperar el Mensaje

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro

        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros

            lst.Add(New clsParametro("@CodigoCobros", CodigoCobros))
            lst.Add(New clsParametro("@Mensaje", "", MySqlDbType.VarChar, ParameterDirection.Output, 100)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Eliminar_Cobro", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Mensaje = lst(1).Valor.ToString() 'Recuperamos el mensaje de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al registrar compras, verifique clase clsCredito") 'Creamos una nueva excepción de errores
        End Try

        Return Mensaje 'Retornamos el mensaje recuperado
    End Function
    Public Function Listar_Cobros_por_cliente() As DataTable 'Función para listar Ventas
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@CodigoContratos", CodigoContrato))
            Return M.Listado("Listar_Cobros_por_cliente", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al buscar difunto, verifique clase clsCredito") 'Creamos una nueva excepción de errores
        End Try

    End Function
    Public Function Listar_Creditos_por_cliente() As DataTable 'Función para listar Ventas
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@CodigoContratos", CodigoContrato))
            Return M.Listado("Listar_Creditos_por_cliente", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al buscar difunto, verifique clase clsCredito") 'Creamos una nueva excepción de errores
        End Try

    End Function
    Public Function RPT_Listar_Creditos_por_cliente() As DataTable 'Función para listar Ventas
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@numerocontratos", ncontrato))
            lst.Add(New clsParametro("@fecha1", fecha1))
            lst.Add(New clsParametro("@fecha2", fecha2))
            Return M.Listado("RPT_Listar_Creditos_por_cliente", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al buscar difunto, verifique clase clsCredito") 'Creamos una nueva excepción de errores
        End Try

    End Function
    Public Function Listar_Creditos_por_contrato() As DataTable 'Función para listar Ventas
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@NumeroContratos", NumeroContratos))
            Return M.Listado("Listar_Creditos_por_contrato", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al buscar difunto, verifique clase clsCredito") 'Creamos una nueva excepción de errores
        End Try

    End Function
    Public Function Actualizar_Cobro() As String
        Dim Mensaje As String = "" 'Declaramos la variable para recuperar el Mensaje

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro

        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros
            lst.Add(New clsParametro("@codigocobros", CodigoCobros))
            lst.Add(New clsParametro("@Mensaje", "", MySqlDbType.VarChar, ParameterDirection.Output, 100)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Actualizar_Cobros", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Mensaje = lst(1).Valor.ToString() 'Recuperamos el mensaje de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al registrar el contrato, verifique clase clsCreditos") 'Creamos una nueva excepción de errores
        End Try

        Return Mensaje 'Retornamos el mensaje recuperado
    End Function
    Public Function Listar_Recibos() As DataTable 'Función para listar Ventas
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@datos", Serie))
            Return M.Listado("Listar_Recibos", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al buscar difunto, verifique clase clsCredito") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function Listar_Recibos_Carga() As DataTable 'Función para listar Ventas
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@datos", Serie))
            Return M.Listado("Listar_Recibos_Carga", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al buscar difunto, verifique clase clsCredito") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function listar_recibos_creditos_fecha() As DataTable 'Función para listar Ventas
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@datos", Serie))
            Return M.Listado("listar_recibos_creditos_fecha", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al buscar difunto, verifique clase clsCredito") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function listar_recibos_creditos_fecha_contrato() As DataTable 'Función para listar Ventas
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@codigocontrato", CodigoContrato))
            Return M.Listado("listar_recibos_creditos_fecha_contrato", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al buscar difunto, verifique clase clsCredito") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function RPT_Reporte_de_recibos_Recaudados_Alfa() As DataTable 'Función para listar Ventas
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@numerocontratos", ncontrato))
            lst.Add(New clsParametro("@fecha1", fecha1))
            lst.Add(New clsParametro("@fecha2", fecha2))
            Return M.Listado("RPT_Reporte_de_recibos_Recaudados_Alfa", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al buscar difunto, verifique clase clsCredito") 'Creamos una nueva excepción de errores
        End Try

    End Function
    Public Function RPT_Reporte_de_recibos_Recaudados_University() As DataTable 'Función para listar Ventas
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@numerocontratos", ncontrato))
            lst.Add(New clsParametro("@fecha1", fecha1))
            lst.Add(New clsParametro("@fecha2", fecha2))
            Return M.Listado("RPT_Reporte_de_recibos_Recaudados_University", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al buscar difunto, verifique clase clsCredito") 'Creamos una nueva excepción de errores
        End Try

    End Function
    Public Function RPT_Reporte_de_recibos_agregados_a_cobro_Alfa() As DataTable 'Función para listar Ventas
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@numerocontratos", ncontrato))
            lst.Add(New clsParametro("@fecha1", fecha1))
            lst.Add(New clsParametro("@fecha2", fecha2))
            Return M.Listado("RPT_Reporte_de_recibos_agregados_a_cobro_Alfa", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al buscar difunto, verifique clase clsCredito") 'Creamos una nueva excepción de errores
        End Try

    End Function
    Public Function RPT_Reporte_de_recibos_agregados_a_cobro_University() As DataTable 'Función para listar Ventas
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@numerocontratos", ncontrato))
            lst.Add(New clsParametro("@fecha1", fecha1))
            lst.Add(New clsParametro("@fecha2", fecha2))
            Return M.Listado("RPT_Reporte_de_recibos_agregados_a_cobro_University", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al buscar difunto, verifique clase clsCredito") 'Creamos una nueva excepción de errores
        End Try

    End Function
    Public Function RPT_SERVICIOS_BRINDADOS() As DataTable 'Función para listar Ventas
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@numerocontratos", ncontrato))
            Return M.Listado("RPT_SERVICIOS_BRINDADOS", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al buscar difunto, verifique clase clsCredito") 'Creamos una nueva excepción de errores
        End Try

    End Function
    Public Function RPT_ESTADO_CUENTA() As DataTable 'Función para listar Ventas
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@numerocontratos", ncontrato))
            Return M.Listado("RPT_ESTADO_CUENTA", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al buscar difunto, verifique clase clsCredito") 'Creamos una nueva excepción de errores
        End Try

    End Function

    Public Function Actualizar_Monto_Contrato() As String
        Dim Mensaje As String = "" 'Declaramos la variable para recuperar el Mensaje

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro

        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros
            lst.Add(New clsParametro("@Numero_Contrato", Numero_Contrato))
            lst.Add(New clsParametro("@Monto", ahorradorecibo))
            lst.Add(New clsParametro("@Mensaje", "", MySqlDbType.VarChar, ParameterDirection.Output, 100)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Actualizar_Monto_Contrato", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Mensaje = lst(2).Valor.ToString() 'Recuperamos el mensaje de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al registrar el contrato, verifique clase clsCreditos") 'Creamos una nueva excepción de errores
        End Try

        Return Mensaje 'Retornamos el mensaje recuperado
    End Function

    Public Function Actualizar_Periodo_Credito() As String
        Dim Mensaje As String = "" 'Declaramos la variable para recuperar el Mensaje

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro

        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros
            lst.Add(New clsParametro("@Numero_Contrato", Numero_Contrato))
            lst.Add(New clsParametro("@Periodo", Periodo))
            lst.Add(New clsParametro("@Mensaje", "", MySqlDbType.VarChar, ParameterDirection.Output, 100)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Actualizar_Periodo_Credito", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Mensaje = lst(2).Valor.ToString() 'Recuperamos el mensaje de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al Actualizar_Periodo_Credito, verifique clase clsCreditos") 'Creamos una nueva excepción de errores
        End Try

        Return Mensaje 'Retornamos el mensaje recuperado
    End Function

    Public Function Listar_actualizar_recibo() As DataTable 'Función para listar Ventas
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@datos", Serie))
            Return M.Listado("listar_recibo_editar", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al buscar difunto, verifique clase clsCredito") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function Actualizar_recibo() As String
        Dim Mensaje As String = "" 'Declaramos la variable para recuperar el Mensaje

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro

        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros
            lst.Add(New clsParametro("@P_CodigoSerie", Serie))
            lst.Add(New clsParametro("@P_ahorrado", Ahorrado))
            lst.Add(New clsParametro("@P_saldo_cuotas", SaldoCuotas))
            lst.Add(New clsParametro("@P_cuotas_ahorradas", CuotasAhorradas))
            lst.Add(New clsParametro("@P_periodo", Periodo))
            lst.Add(New clsParametro("@Mensaje", "", MySqlDbType.VarChar, ParameterDirection.Output, 100)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Actualizar_recibo", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Mensaje = lst(2).Valor.ToString() 'Recuperamos el mensaje de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al Actualizar_Periodo_Credito, verifique clase clsCreditos") 'Creamos una nueva excepción de errores
        End Try

        Return Mensaje 'Retornamos el mensaje recuperado
    End Function
End Class
