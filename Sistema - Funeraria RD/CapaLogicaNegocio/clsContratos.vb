Imports CapaAccesoDatos
Imports MySql.Data.MySqlClient

Public Class clsContratos

    Dim M As New clsManejador 'Instanciamos la clase clsManejador
    'Declaramos nuestras propiedades
    Public Property CodigoContrato() As Integer
    Public Property Numeroorden() As Integer
    Public Property CodigoCliente() As Integer
    Public Property CodigoClientes() As Integer
    Public Property CodigoPersonal() As Integer
    Public Property TipoContrato() As String
    Public Property Monto() As Decimal
    Public Property Plazo() As Integer
    Public Property Cuota() As Decimal
    Public Property Zona() As String
    Public Property LugarCobro() As String
    Public Property FechaCobro() As String
    Public Property Observacion() As String
    Public Property NumeroContrato() As String
    Public Property Contrato() As String
    Public Property FechaContrato() As Date
    Public Property dato() As String
    Public Property datoorden() As String
    Public Property datorecibo() As String
    Public Property datos() As String
    Public Property datosautocompletar() As String
    Public Property Consecutivo As Integer
    Public Property FormaPago() As String
    Public Property monto_actual() As Decimal
    Public Property RPTcontratos() As String

    Public Property Total() As Decimal
    Public Property Fecha() As Date
    Public Property CodigoTraslado() As Integer
    Public Property CodigoLiquidacion() As Integer
    Public Property CodigoItem() As Integer
    Public Property Cantidad() As Integer
    Public Property PrecioVenta As Decimal
    Public Property IGV() As Decimal
    Public Property Descuento() As Decimal
    Public Property SubTotal() As Decimal

    Public Property CodigoContrato2() As Integer

    Public Property nsolicitud As Integer
    Public Property observacionesliquidar As String
    Public Property Estado() As String

    Public Property Retirado() As String
    Public Property codigocontratoliquidaciones() As Integer
    Public Property CodigoLiquidaciones As Integer
    Public Property tipo_contrato() As String
    Public Property Busqueda() As String

    Public Property prima() As Decimal
    Public Property fechas() As Date
    Public Property Periodos() As String
    Public Property CuotasAhorradass() As Integer
    Public Property Ahorrados() As Decimal
    Public Property SaldoCuotass() As Integer
    Public Property reconocimientos() As String
    Public Property observaciones() As String
    Public Property Difunto() As String
    Public Property TipoReligion() As String
    Public Property TipoTexto() As String
    Public Property NombreTexto() As String
    Public Property Texto() As String
    Public Property CodigoTexto() As Integer
    Public Property CodigoContratorecibos() As Integer
    Public Property ahorradorecibo() As Decimal
    Public Property Scuotas() As Integer
    Public Property CodigoCarga() As Integer
    Public Property Acuotas() As Integer


    Public Function Registrar_texto() As String
        Dim Mensaje As String = "" 'Declaramos la variable para recuperar el Mensaje

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro

        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros
            lst.Add(New clsParametro("@TipoTexto", TipoTexto))
            lst.Add(New clsParametro("@NombreTexto", NombreTexto))
            lst.Add(New clsParametro("@Texto", Texto))
            lst.Add(New clsParametro("@Mensaje", "", MySqlDbType.VarChar, ParameterDirection.Output, 100)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Registrar_texto", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Mensaje = lst(3).Valor.ToString() 'Recuperamos el mensaje de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al registrar el contrato, verifique clase clsContratos") 'Creamos una nueva excepción de errores
        End Try

        Return Mensaje 'Retornamos el mensaje recuperado
    End Function
    Public Function Registrar_Contrato() As String
        Dim Mensaje As String = "" 'Declaramos la variable para recuperar el Mensaje

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro

        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros
            lst.Add(New clsParametro("@CodigoClientes", CodigoCliente))
            lst.Add(New clsParametro("@CodigoPersonals", CodigoPersonal))
            lst.Add(New clsParametro("@TipoContratos", TipoContrato))
            lst.Add(New clsParametro("@Montos", Monto))
            lst.Add(New clsParametro("@Plazos", Plazo))
            lst.Add(New clsParametro("@Cuotas", Cuota))
            lst.Add(New clsParametro("@Zonas", Zona))
            lst.Add(New clsParametro("@LugarCobros", LugarCobro))
            lst.Add(New clsParametro("@FechaCobros", FechaCobro))
            lst.Add(New clsParametro("@Observacions", Observacion))
            lst.Add(New clsParametro("@NumeroContratos", NumeroContrato))
            lst.Add(New clsParametro("@FechaContratos", FechaContrato))
            lst.Add(New clsParametro("@Contratos", Contrato))
            lst.Add(New clsParametro("@Consecutivos", Consecutivo))
            lst.Add(New clsParametro("@formapagos", FormaPago))
            lst.Add(New clsParametro("@montoactuales", monto_actual))
            lst.Add(New clsParametro("@Mensaje", "", MySqlDbType.VarChar, ParameterDirection.Output, 100)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Registrar_Contratos", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Mensaje = lst(16).Valor.ToString() 'Recuperamos el mensaje de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al registrar el contrato, verifique clase clsContratos") 'Creamos una nueva excepción de errores
        End Try

        Return Mensaje 'Retornamos el mensaje recuperado
    End Function
    Public Function Actualizar_Contrato() As String
        Dim Mensaje As String = "" 'Declaramos la variable para recuperar el Mensaje

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro

        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros
            lst.Add(New clsParametro("@CodigoContratos", CodigoContrato))
            lst.Add(New clsParametro("@CodigoClientes", CodigoCliente))
            lst.Add(New clsParametro("@CodigoPersonals", CodigoPersonal))
            lst.Add(New clsParametro("@TipoContratos", TipoContrato))
            lst.Add(New clsParametro("@Montos", Monto))
            lst.Add(New clsParametro("@Plazos", Plazo))
            lst.Add(New clsParametro("@Cuotas", Cuota))
            lst.Add(New clsParametro("@Zonas", Zona))
            lst.Add(New clsParametro("@LugarCobros", LugarCobro))
            lst.Add(New clsParametro("@FechaCobros", FechaCobro))
            lst.Add(New clsParametro("@Observacions", Observacion))
            lst.Add(New clsParametro("@NumeroContratos", NumeroContrato))
            lst.Add(New clsParametro("@FechaContratos", FechaContrato))
            lst.Add(New clsParametro("@Contratos", Contrato))
            lst.Add(New clsParametro("@Consecutivos", Consecutivo))
            lst.Add(New clsParametro("@formapagos", FormaPago))
            lst.Add(New clsParametro("@montoactuales", monto_actual))
            lst.Add(New clsParametro("@Mensaje", "", MySqlDbType.VarChar, ParameterDirection.Output, 100)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Actualizar_Contratos", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Mensaje = lst(17).Valor.ToString() 'Recuperamos el mensaje de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al registrar el contrato, verifique clase clsContratos") 'Creamos una nueva excepción de errores
        End Try

        Return Mensaje 'Retornamos el mensaje recuperado
    End Function
    Public Function Actualizar_Estados() As String
        Dim Mensaje As String = "" 'Declaramos la variable para recuperar el Mensaje

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro

        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros
            lst.Add(New clsParametro("@CodigoContratos", CodigoContrato))
            lst.Add(New clsParametro("@Estados", Estado))
            lst.Add(New clsParametro("@Mensaje", "", MySqlDbType.VarChar, ParameterDirection.Output, 100)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Actualizar_Estados", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Mensaje = lst(2).Valor.ToString() 'Recuperamos el mensaje de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al registrar el contrato, verifique clase clsContratos") 'Creamos una nueva excepción de errores
        End Try

        Return Mensaje 'Retornamos el mensaje recuperado
    End Function
    Public Function Actualizar_Estados_recibos() As String
        Dim Mensaje As String = "" 'Declaramos la variable para recuperar el Mensaje

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro

        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros

            lst.Add(New clsParametro("@Mensaje", "", MySqlDbType.VarChar, ParameterDirection.Output, 100)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Actualizar_Estados_recibos", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Mensaje = lst(0).Valor.ToString() 'Recuperamos el mensaje de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al registrar el contrato, verifique clase clsContratos") 'Creamos una nueva excepción de errores
        End Try

        Return Mensaje 'Retornamos el mensaje recuperado
    End Function
    Public Function Actualizar_recibos() As String
        Dim Mensaje As String = "" 'Declaramos la variable para recuperar el Mensaje

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro

        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros
            lst.Add(New clsParametro("@CodigoCargas", CodigoCarga))
            lst.Add(New clsParametro("@ahorradorecibo", ahorradorecibo))
            lst.Add(New clsParametro("@Scuotas", Scuotas))
            lst.Add(New clsParametro("@Acuotas", Acuotas))
            lst.Add(New clsParametro("@Mensaje", "", MySqlDbType.VarChar, ParameterDirection.Output, 100)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Actualizar_recibos", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Mensaje = lst(4).Valor.ToString() 'Recuperamos el mensaje de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al registrar el contrato, verifique clase clsContratos") 'Creamos una nueva excepción de errores
        End Try

        Return Mensaje 'Retornamos el mensaje recuperado
    End Function
    Public Function Devolver_Codigo_cliente() As Integer
        Dim Codigo As Integer = 0

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro
        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros
            lst.Add(New clsParametro("@Codigoclientes", CodigoCliente))
            lst.Add(New clsParametro("@Codigo", "", MySqlDbType.Int32, ParameterDirection.Output, 20)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Devolver_Codigo_cliente", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Codigo = lst(0).Valor.ToString() 'Recuperamos el código de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al devolver el código del Item, verifique clase clsItem") 'Creamos una nueva excepción de errores
        End Try
        Return Codigo 'Retornamos el código recuperado
    End Function
    Public Function Devolver_Codigo_difunto() As Integer
        Dim Codigo As Integer = 0

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro
        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros
            lst.Add(New clsParametro("@Difuntos", Difunto))
            lst.Add(New clsParametro("@codigo_difuntos", "", MySqlDbType.Int32, ParameterDirection.Output, 100)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Devolver_Codigo_difunto", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Codigo = lst(1).Valor.ToString() 'Recuperamos el código de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al devolver el código del Item, verifique clase clsItem") 'Creamos una nueva excepción de errores
        End Try
        Return Codigo 'Retornamos el código recuperado
    End Function
    Public Function Devolver_monto() As Decimal
        Dim monto As Decimal = 0

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro
        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros
            lst.Add(New clsParametro("@Codigocontratos", CodigoContrato))
            lst.Add(New clsParametro("@montos", "", MySqlDbType.Decimal, ParameterDirection.Output, 20)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Devolver_monto_contrato", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            monto = lst(1).Valor.ToString() 'Recuperamos el código de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al devolver el código del Item, verifique clase clsItem") 'Creamos una nueva excepción de errores
        End Try
        Return monto 'Retornamos el código recuperado
    End Function
    Public Function Devolver_n_contratos() As String
        Dim Codigo As String = 0

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro
        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros
            lst.Add(New clsParametro("@codigo_clientes", CodigoClientes))
            lst.Add(New clsParametro("@n_contratos", "", MySqlDbType.VarChar, ParameterDirection.Output, 30)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Devolver_n_contratos", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Codigo = lst(1).Valor.ToString() 'Recuperamos el código de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al devolver el código del Item, verifique clase clsItem") 'Creamos una nueva excepción de errores
        End Try
        Return Codigo 'Retornamos el código recuperado
    End Function
    Public Function Devolver_n_contrato() As Integer
        Dim Codigo As Integer = 0

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro
        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros
            lst.Add(New clsParametro("@Codigoclientes", CodigoCliente))
            lst.Add(New clsParametro("@Codigo", "", MySqlDbType.Int32, ParameterDirection.Output, 20)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Devolver_Codigo_cliente", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Codigo = lst(0).Valor.ToString() 'Recuperamos el código de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al devolver el código del Item, verifique clase clsItem") 'Creamos una nueva excepción de errores
        End Try
        Return Codigo 'Retornamos el código recuperado
    End Function
    Public Function Devolver_codigo_cliente_contratos() As Integer
        Dim Codigo As Integer = 0

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro
        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros
            lst.Add(New clsParametro("@codigocontratos", CodigoContrato))
            lst.Add(New clsParametro("@Codigo", "", MySqlDbType.Int32, ParameterDirection.Output, 5)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Devolver_codigo_cliente_contratos", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Codigo = lst(0).Valor.ToString() 'Recuperamos el código de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al devolver el código del Item, verifique clase clsItem") 'Creamos una nueva excepción de errores
        End Try
        Return Codigo 'Retornamos el código recuperado
    End Function
    Public Function Listar_tralados_por_cliente() As DataTable 'Función para listar Ventas
        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@CodigoContratos", CodigoContrato))
            Return M.Listado("Listar_tralados_por_cliente", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al listar Contratos, verifique clase clsContrato") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function Listar_Contratos() As DataTable 'Función para listar Ventas
        Try 'Manejamos una excepción de errores
            Return M.Listado("Listar_Contratos", Nothing) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al listar Contratos, verifique clase clsContrato") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function listar_liquidados() As DataTable 'Función para listar Ventas
        Try 'Manejamos una excepción de errores
            Return M.Listado("listar_liquidados", Nothing) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al listar Contratos, verifique clase clsContrato") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function listar_trasladados() As DataTable 'Función para listar Ventas
        Try 'Manejamos una excepción de errores
            Return M.Listado("listar_trasladados", Nothing) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al listar Contratos, verifique clase clsContrato") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function Listar_Contratos_creditos() As DataTable 'Función para listar Ventas
        Try 'Manejamos una excepción de errores
            Return M.Listado("Listar_Contratos_creditos", Nothing) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al listar Contratos, verifique clase clsContrato") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function Listar_Contratos_orden() As DataTable 'Función para listar Ventas
        Try 'Manejamos una excepción de errores
            Return M.Listado("Listar_Contratos_orden", Nothing) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al listar Contratos, verifique clase clsContrato") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function Listar_textos() As DataTable 'Función para listar Ventas
        Try 'Manejamos una excepción de errores
            Return M.Listado("Listar_textos", Nothing) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al listar Contratos, verifique clase clsContrato") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function Listar_religion() As DataTable 'Función para listar Colores
        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la 
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@tiporeligion", TipoReligion))
            Return M.Listado("Listar_religion", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al listar Material, verifique clase clsMaterial") 'Creamos una nueva excepción de errores
        End Try
    End Function

    Public Function devolver_recibos_contratos() As DataTable 'Función para listar Ventas
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@CodigoContratos", CodigoContrato))
            Return M.Listado("devolver_recibos_contratos", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al buscar difunto, verifique clase clsDifunto") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function devover_vendedor_contratos() As DataTable 'Función para listar Ventas
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@datos", datos))
            Return M.Listado("devover_vendedor_contratos", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al buscar difunto, verifique clase clsDifunto") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function devover_vendedor_contratos_autocompletar() As DataTable 'Función para listar Ventas
        Try 'Manejamos una excepción de errores
            Return M.Listado("devover_vendedor_contratos_autocompletar", Nothing) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al listar Contratos, verifique clase clsContrato") 'Creamos una nueva excepción de errores
        End Try
    End Function


    Public Function Filtrar_Clientes() As DataTable 'Función para filtrar Clientes por Nro Documento o Nombres
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@Datos", datosautocompletar))
            Return M.Listado("devover_cliente_contratos_autocompletar", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al filtrar Clientes, verifique clase clsCliente") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function devover_Cliente_contratos() As DataTable 'Función para listar Ventas
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@datos", datos))
            Return M.Listado("devover_Cliente_contratos", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al buscar difunto, verifique clase clsDifunto") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function devolver_productos_liquidados() As DataTable 'Función para listar Ventas
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@CodigoLiquidaciones", CodigoLiquidacion))
            Return M.Listado("devolver_productos_liquidados", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al buscar difunto, verifique clase clsDifunto") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function devolver_liquidados() As DataTable 'Función para listar Ventas
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@codigocontrato", CodigoContrato))
            Return M.Listado("devolver_liquidados", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al buscar difunto, verifique clase clsDifunto") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function Listar_Todos_Contratos() As DataTable 'Función para listar Ventas
        Try 'Manejamos una excepción de errores
            Return M.Listado("Listar_Todos_Contratos", Nothing) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al listar Contratos, verifique clase clsContrato") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function Devolver_texto() As String
        Dim tipo As String = ""

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro
        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros

            lst.Add(New clsParametro("@CodigoTexto", CodigoTexto))
            lst.Add(New clsParametro("@texto", "", MySqlDbType.VarChar, ParameterDirection.Output, 200)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Devolver_Texto", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            tipo = lst(1).Valor.ToString() 'Recuperamos el monto de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al devolver el código de la compra, verifique clase clsCredito") 'Creamos una nueva excepción de errores
        End Try
        Return tipo 'Retornamos el monto recuperado
    End Function
    Public Function Devolver_recibos_cargados() As DataTable 'Función para listar Ventas
        Try 'Manejamos una excepción de errores
            Return M.Listado("Devolver_recibos_cargados", Nothing) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al listar Contratos, verifique clase clsContrato") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function Devolver_recibos_carga() As DataTable 'Función para listar Ventas
        Try 'Manejamos una excepción de errores
            Return M.Listado("Devolver_recibos_carga", Nothing) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al listar Contratos, verifique clase clsContrato") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function Devolver_recibos_provicionales() As DataTable 'Función para listar Ventas
        Try 'Manejamos una excepción de errores
            Return M.Listado("Devolver_recibos_provicionales", Nothing) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al listar Contratos, verifique clase clsContrato") 'Creamos una nueva excepción de errores
        End Try
    End Function

    Public Function Devolver_solicitud() As Integer
        Dim solicitud As Integer = 0

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro
        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros


            lst.Add(New clsParametro("@nsolicitud", "", MySqlDbType.Int32, ParameterDirection.Output, 50)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Devolver_solicitud", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            solicitud = lst(0).Valor.ToString() 'Recuperamos el monto de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al devolver el código de la compra, verifique clase clsCredito") 'Creamos una nueva excepción de errores
        End Try
        Return solicitud 'Retornamos el monto recuperado
    End Function
    Public Function Listar_Contratos_Cobros() As DataTable 'Función para listar Ventas
        Try 'Manejamos una excepción de errores
            Return M.Listado("Listar_Contratos_Cobros", Nothing) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al listar Contratos, verifique clase clsContrato") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function Buscar_Contratos() As DataTable 'Función para filtrar Difuntos
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@datos", dato))
            Return M.Listado("Buscar_contrato", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al buscar contrato, verifique clase clsDifunto") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function Buscar_contrato_liquidacion() As DataTable 'Función para filtrar Difuntos
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@datos", dato))
            Return M.Listado("Buscar_contrato_liquidacion", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al buscar contrato, verifique clase clsDifunto") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function Buscar_contrato_liquidacion_trasladado() As DataTable 'Función para filtrar Difuntos
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@datos", dato))
            Return M.Listado("Buscar_contrato_liquidacion_trasladado", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al buscar contrato, verifique clase clsDifunto") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function Buscar_contrato_credito() As DataTable 'Función para filtrar Difuntos
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@datos", dato))
            Return M.Listado("Buscar_contrato_credito", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al buscar contrato, verifique clase clsDifunto") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function Buscar_Contratos_Cobros() As DataTable 'Función para filtrar Difuntos
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@datos", dato))
            Return M.Listado("Buscar_Contratos_Cobros", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al buscar contrato cobros, verifique clase clsDifunto") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function Buscar_Contratos_orden() As DataTable 'Función para filtrar Difuntos
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@datos", datoorden))
            Return M.Listado("Buscar_Contratos_orden", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al buscar contrato cobros, verifique clase clsDifunto") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function Buscar_recibos_Creditos() As DataTable 'Función para filtrar Difuntos
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@datos", datorecibo))
            Return M.Listado("Buscar_recibos_Creditos", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al buscar recibos, verifique clase clsDifunto") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function Buscar_recibos_Creditos_contratos() As DataTable 'Función para filtrar Difuntos
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@codigo", CodigoContratorecibos))
            Return M.Listado("Buscar_recibos_Creditos_contratos", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al buscar recibos, verifique clase clsDifunto") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function Buscar_Cobros() As DataTable 'Función para filtrar Difuntos
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@datos", dato))
            Return M.Listado("Buscar_Cobros", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al buscar cobros, verifique clase clsDifunto") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function Buscar_Carga() As DataTable 'Función para filtrar Difuntos
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@datos", dato))
            Return M.Listado("Buscar_Carga", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al buscar difunto, verifique clase clsDifunto") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function Buscar_recibos_impresos() As DataTable 'Función para filtrar Difuntos
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@datos", Busqueda))
            Return M.Listado("Buscar_recibos_impresos", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al buscar difunto, verifique clase clsDifunto") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function Buscar_Zona() As DataTable 'Función para filtrar Difuntos
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@datos", dato))
            lst.Add(New clsParametro("@tipo", tipo_contrato))
            Return M.Listado("Buscar_Zona", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al buscar difunto, verifique clase clsDifunto") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function Buscar_Zona_Cargados() As DataTable 'Función para filtrar Difuntos
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@datos", dato))
            lst.Add(New clsParametro("@tipo", tipo_contrato))
            Return M.Listado("Buscar_Zona_Cargados", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al buscar difunto, verifique clase clsDifunto") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function Buscar_Zona_Carga() As DataTable 'Función para filtrar Difuntos
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@datos", dato))
            lst.Add(New clsParametro("@tipo", tipo_contrato))
            Return M.Listado("Buscar_Zona_Carga", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al buscar difunto, verifique clase clsDifunto") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function Buscar_Zona_orden() As DataTable 'Función para filtrar Difuntos
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@datos", datoorden))
            Return M.Listado("Buscar_Zona_orden", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al buscar difunto, verifique clase clsDifunto") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function Registrar_Liquidacion() As String 'Función para registrar Ventas
        Dim Mensaje As String = "" 'Declaramos la variable para recuperar el Mensaje

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro

        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros

            lst.Add(New clsParametro("@codigocontratos", CodigoContrato))
            lst.Add(New clsParametro("@Difuntos", Difunto))
            lst.Add(New clsParametro("@totals", Total))
            lst.Add(New clsParametro("@fechas", Fecha))
            lst.Add(New clsParametro("@Retirados", Retirado))
            lst.Add(New clsParametro("@nsolicitud", nsolicitud))
            lst.Add(New clsParametro("@observacionesliquidar", observacionesliquidar))
            lst.Add(New clsParametro("@Mensaje", "", MySqlDbType.VarChar, ParameterDirection.Output, 100)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Registrar_Liquidacion", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Mensaje = lst(7).Valor.ToString() 'Recuperamos el mensaje de la Base de Datos

        Catch ex As Exception
            Throw New Exception("Error al registrar ventas, verifique clase clsVentas" + ex.Message) 'Creamos una nueva excepción de errores
        End Try

        Return Mensaje 'Retornamos el mensaje recuperado
    End Function
    Public Function Actualizar_Liquidacion() As String 'Función para registrar Ventas
        Dim Mensaje As String = "" 'Declaramos la variable para recuperar el Mensaje

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro

        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros

            lst.Add(New clsParametro("@codigoliquidaciones", CodigoLiquidacion))
            lst.Add(New clsParametro("@totals", Total))
            lst.Add(New clsParametro("@observacionesliquidar", observacionesliquidar))
            lst.Add(New clsParametro("@Mensaje", "", MySqlDbType.VarChar, ParameterDirection.Output, 100)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Actualizar_Liquidacion", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Mensaje = lst(3).Valor.ToString() 'Recuperamos el mensaje de la Base de Datos

        Catch ex As Exception
            Throw New Exception("Error al registrar ventas, verifique clase clsVentas" + ex.Message) 'Creamos una nueva excepción de errores
        End Try

        Return Mensaje 'Retornamos el mensaje recuperado
    End Function
    Public Function Devolver_Codigo_Liquidacion() As Integer
        Dim Codigo As Integer = 0

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro
        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros
            lst.Add(New clsParametro("@CodigoLiquidaciones", "", MySqlDbType.Int32, ParameterDirection.Output, 5)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Devolver_Codigo_Liquidacion", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Codigo = lst(0).Valor.ToString() 'Recuperamos el código de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al devolver el código de la Venta, verifique clase clsVentas") 'Creamos una nueva excepción de errores
        End Try
        Return Codigo 'Retornamos el código recuperado
    End Function
    Public Function Registrar_Detalle_Liquidacion() As String 'Función para registrar Detalle de  Ventas
        Dim Mensaje As String = "" 'Declaramos la variable para recuperar el Mensaje

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro

        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros
            lst.Add(New clsParametro("@CodigoLiquidaciones", CodigoLiquidacion))
            lst.Add(New clsParametro("@Codigo_Items", CodigoItem))
            lst.Add(New clsParametro("@Cantidads", Cantidad))
            lst.Add(New clsParametro("@Precio_Ventas", PrecioVenta))
            lst.Add(New clsParametro("@Igvs", IGV))
            lst.Add(New clsParametro("@Dsctos", Descuento))
            lst.Add(New clsParametro("@Sub_Totals", SubTotal))
            lst.Add(New clsParametro("@Mensaje", "", MySqlDbType.VarChar, ParameterDirection.Output, 100)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Registrar_Detalle_Liquidacion", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Mensaje = lst(7).Valor.ToString() 'Recuperamos el mensaje de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al registrar detalle de Liquidacion, verifique clase clsContratos") 'Creamos una nueva excepción de errores
        End Try

        Return Mensaje 'Retornamos el mensaje recuperado
    End Function
    Public Function Actualizar_Detalle_Liquidacion() As String 'Función para registrar Detalle de  Ventas
        Dim Mensaje As String = "" 'Declaramos la variable para recuperar el Mensaje

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro


        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros
            lst.Add(New clsParametro("@CodigoLiquidaciones", CodigoLiquidacion))
            lst.Add(New clsParametro("@Codigo_Items", CodigoItem))
            lst.Add(New clsParametro("@Cantidads", Cantidad))
            lst.Add(New clsParametro("@Precio_Ventas", PrecioVenta))
            lst.Add(New clsParametro("@Igvs", IGV))
            lst.Add(New clsParametro("@Dsctos", Descuento))
            lst.Add(New clsParametro("@Sub_Totals", SubTotal))
            lst.Add(New clsParametro("@Mensaje", "", MySqlDbType.VarChar, ParameterDirection.Output, 100)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Actualizar_Detalle_Liquidacion", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Mensaje = lst(7).Valor.ToString() 'Recuperamos el mensaje de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al registrar detalle de Liquidacion, verifique clase clsContratos") 'Creamos una nueva excepción de errores
        End Try

        Return Mensaje 'Retornamos el mensaje recuperado
    End Function
    Public Function Registrar_Traslado() As String 'Función para registrar Detalle de  Ventas
        Dim Mensaje As String = "" 'Declaramos la variable para recuperar el Mensaje

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro

        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros
            lst.Add(New clsParametro("@codigocontratos", CodigoContrato))
            lst.Add(New clsParametro("@codigocontratos2", CodigoContrato2))
            lst.Add(New clsParametro("@montos", Monto))
            lst.Add(New clsParametro("@fechas", Fecha))
            lst.Add(New clsParametro("@Mensaje", "", MySqlDbType.VarChar, ParameterDirection.Output, 100)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Registrar_Traslado", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Mensaje = lst(4).Valor.ToString() 'Recuperamos el mensaje de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al registrar traslado, verifique clase clsContratos") 'Creamos una nueva excepción de errores
        End Try

        Return Mensaje 'Retornamos el mensaje recuperado
    End Function
    Public Function Actualizar_Traslado() As String 'Función para registrar Detalle de  Ventas
        Dim Mensaje As String = "" 'Declaramos la variable para recuperar el Mensaje

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro

        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros
            lst.Add(New clsParametro("@CodigoTraslados", CodigoTraslado))
            lst.Add(New clsParametro("@montos", Monto))
            lst.Add(New clsParametro("@Mensaje", "", MySqlDbType.VarChar, ParameterDirection.Output, 100)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Actualizar_Traslado", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Mensaje = lst(2).Valor.ToString() 'Recuperamos el mensaje de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al registrar traslado, verifique clase clsContratos") 'Creamos una nueva excepción de errores
        End Try

        Return Mensaje 'Retornamos el mensaje recuperado
    End Function
    Public Function Eliminar_detalle_liquidacion() As String 'Función para registrar Detalle de  Ventas
        Dim Mensaje As String = "" 'Declaramos la variable para recuperar el Mensaje

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro


        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros
            lst.Add(New clsParametro("@CodigoLiquidaciones", CodigoLiquidacion))
            lst.Add(New clsParametro("@Mensaje", "", MySqlDbType.VarChar, ParameterDirection.Output, 100)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Eliminar_detalle_liquidacion", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Mensaje = lst(1).Valor.ToString() 'Recuperamos el mensaje de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al registrar traslado, verifique clase clsContratos") 'Creamos una nueva excepción de errores
        End Try

        Return Mensaje 'Retornamos el mensaje recuperado
    End Function

    Public Function Registrar_Prima() As String
        Dim Mensaje As String = "" 'Declaramos la variable para recuperar el Mensaje

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro

        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros

            lst.Add(New clsParametro("@MontoAbono", prima))
            lst.Add(New clsParametro("@MontoActual", monto_actual))
            lst.Add(New clsParametro("@fechas", fechas))
            lst.Add(New clsParametro("@Periodos", Periodos))
            lst.Add(New clsParametro("@CuotasAhorradass", CuotasAhorradass))
            lst.Add(New clsParametro("@Ahorrados", Ahorrados))
            lst.Add(New clsParametro("@SaldoCuotass", SaldoCuotass))
            lst.Add(New clsParametro("@reconocimientos", reconocimientos))
            lst.Add(New clsParametro("@observaciones", observaciones))
            lst.Add(New clsParametro("@Mensaje", "", MySqlDbType.VarChar, ParameterDirection.Output, 100)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Registrar_Prima", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Mensaje = lst(9).Valor.ToString() 'Recuperamos el mensaje de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al registrar el contrato, verifique clase clsCreditos") 'Creamos una nueva excepción de errores
        End Try

        Return Mensaje 'Retornamos el mensaje recuperado
    End Function
    Public Function Listar_liquidaciones_contratos() As DataTable 'Función para listar Compras
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@CodigoContratos", codigocontratoliquidaciones))
            Return M.Listado("Listar_liquidaciones_contratos", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al listar compras, verifique clase clsVentas") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function Listar_liquidaciones_Productos() As DataTable 'Función para listar Compras
        Dim lst As New List(Of clsParametro)
        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@CodigoLiquidaciones", CodigoLiquidaciones))
            Return M.Listado("Listar_liquidaciones_Productos", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al listar compras, verifique clase clsVentas") 'Creamos una nueva excepción de errores
        End Try
    End Function

    Public Function RPT_ESTADO_CUENTA() As DataTable 'Función para filtrar Difuntos
        Dim lst As New List(Of clsParametro)

        Try 'Manejamos una excepción de errores
            lst.Add(New clsParametro("@datos", RPTcontratos))
            Return M.Listado("RPT_ESTADO_CUENTA", lst) 'Pasamos el nombre de nuestro procedimiento almacenado sin ningún parámetro
        Catch ex As Exception
            Throw New Exception("Error al buscar difunto, verifique clase clsDifunto") 'Creamos una nueva excepción de errores
        End Try
    End Function
    Public Function Eliminar_Contrato() As String 'Función para registrar Compras
        Dim Mensaje As String = "" 'Declaramos la variable para recuperar el Mensaje

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro

        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros

            lst.Add(New clsParametro("@CodigoContratos", CodigoContrato))
            lst.Add(New clsParametro("@Mensaje", "", MySqlDbType.VarChar, ParameterDirection.Output, 100)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Eliminar_Contrato", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Mensaje = lst(1).Valor.ToString() 'Recuperamos el mensaje de la Base de Datos
        Catch ex As Exception
            Throw New Exception("Error al registrar compras, verifique clase clsCredito") 'Creamos una nueva excepción de errores
        End Try

        Return Mensaje 'Retornamos el mensaje recuperado
    End Function
    Public Function Registrar_orden() As String 'Función para registrar Ventas
        Dim Mensaje As String = "" 'Declaramos la variable para recuperar el Mensaje

        Dim lst As New List(Of clsParametro) 'Instanciamos nuestra lista genérica con la clase clsParametro

        Try 'Manejamos una excepción de errores
            'Agregamos a la lista genérica el nombre y valor de los parámetros

            lst.Add(New clsParametro("@codigocontratos", CodigoContrato))
            lst.Add(New clsParametro("@Numeroordenes", Numeroorden))
            lst.Add(New clsParametro("@Mensaje", "", MySqlDbType.VarChar, ParameterDirection.Output, 100)) 'Especificamos que el parámetro @Mensaje es de tipo salida
            M.EjecutarSP("Registrar_orden", lst) 'Enviamos el nombre de nuestro Procedimiento almacenado con la lista de los parámetros para su ejecución
            Mensaje = lst(2).Valor.ToString() 'Recuperamos el mensaje de la Base de Datos

        Catch ex As Exception
            Throw New Exception("Error al registrar ventas, verifique clase clsVentas" + ex.Message) 'Creamos una nueva excepción de errores
        End Try

        Return Mensaje 'Retornamos el mensaje recuperado
    End Function
End Class

