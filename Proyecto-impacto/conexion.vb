Imports System.Data.Sql
Imports System.Data.SqlClient
Imports WL



Module conexion
    Public conexion As SqlConnection
    Public consulta As SqlCommand
    Public respuesta As SqlDataReader
    Public iduser As Integer

    Sub conectar()
        Try
            conexion = New SqlConnection("Data Source=DESKTOP-1KFTLIO;Initial Catalog=impactoDB;Integrated Security=True")
            conexion.Open()

        Catch ex As Exception
            MsgBox("No se pudo conectar " + ex.ToString)

        End Try
    End Sub
    Function verificarusuario(ByVal nombreUsuario As String)
        Dim valido As Boolean = False
        Dim usuario As SqlParameter
        Try
            usuario = New SqlParameter("@usuario", SqlDbType.VarChar)
            usuario.Size = 45
            usuario.Value = nombreUsuario
            consulta = New SqlCommand("verificarusuario", conexion)
            consulta.CommandType = CommandType.StoredProcedure
            consulta.Parameters.Add(usuario)
            respuesta = consulta.ExecuteReader

            If respuesta.Read Then
                valido = True

            End If
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
        Return valido
    End Function
    Function verificarcontrasena(ByVal nombreUsuario As String)
        Dim usuario As SqlParameter
        Dim clave As String = ""
        Dim id As Integer
        Dim nombre As String = ""
        Dim apellidopat As String = ""
        Dim apellidomat As String = ""


        Try
            usuario = New SqlParameter("@usuario", SqlDbType.VarChar)
            usuario.Size = 45
            usuario.Value = nombreUsuario
            consulta = New SqlCommand("verificarcontrasena", conexion)
            consulta.CommandType = CommandType.StoredProcedure
            consulta.Parameters.Add(usuario)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                clave = respuesta.Item("password")
            End If
            id = respuesta.Item("idempleado")
            nombre = respuesta.Item("nombreempleado")
            apellidopat = respuesta.Item("apellidopatempleado")
            apellidomat = respuesta.Item("apellidomatempleado")
            respuesta.Close()



        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Dim arreglo = {clave, nombre, apellidopat, apellidomat, id}
        Return arreglo

    End Function
    Function mostrarbienvenida(ByVal iduser As Integer)

        Dim id As SqlParameter
        Dim nombreempleado As String = ""
        Dim apellidopempleado As String = ""
        Dim apellidomempleado As String = ""

        Try
            id = New SqlParameter("@iduser", SqlDbType.Int)
            id.Value = iduser
            consulta = New SqlCommand("mostrarbienvenida", conexion)
            consulta.CommandType = CommandType.StoredProcedure
            consulta.Parameters.Add(id)
            respuesta = consulta.ExecuteReader
            While respuesta.Read
                nombreempleado = respuesta.Item("nombreempleado")
                apellidopempleado = respuesta.Item("apellidopatempleado")
                apellidomempleado = respuesta.Item("apellidomatempleado")

            End While
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Dim arreglo = {nombreempleado, apellidopempleado, apellidomempleado}
        Return arreglo
    End Function
    Sub actualizarinfoempleado(ByVal nombre As String, ByVal apellidop As String, ByVal apellidom As String)
        Dim nombreparameter As SqlParameter
        Dim apellidopparameter As SqlParameter
        Dim apellidomparameter As SqlParameter
        Dim idp As SqlParameter
        Try
            nombreparameter = New SqlParameter("@nombre", SqlDbType.VarChar)
            nombreparameter.Size = 45
            nombreparameter.Value = nombre
            apellidopparameter = New SqlParameter("@apellidop", SqlDbType.VarChar)
            apellidopparameter.Size = 45
            apellidopparameter.Value = apellidop
            apellidomparameter = New SqlParameter("@apellidom", SqlDbType.VarChar)
            apellidomparameter.Size = 45
            apellidomparameter.Value = apellidom
            idp = New SqlParameter("@iduser", SqlDbType.Int)
            idp.Value = iduser

            consulta = New SqlCommand("actualizarinfoempleado", conexion)
            consulta.CommandType = CommandType.StoredProcedure
            consulta.Parameters.Add(nombreparameter)
            consulta.Parameters.Add(apellidopparameter)
            consulta.Parameters.Add(apellidomparameter)
            consulta.Parameters.Add(idp)
            consulta.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Function extraerdatosempleado()
        Dim idp As SqlParameter
        Dim nombretextbox As String = ""
        Dim apellidoptextbox As String = ""
        Dim apellidomtextbox As String = ""
        Try

            idp = New SqlParameter("@iduser", SqlDbType.Int)
            idp.Value = iduser
            consulta = New SqlCommand("extraerdatosempleado", conexion)
            consulta.CommandType = CommandType.StoredProcedure
            consulta.Parameters.Add(idp)
            consulta.ExecuteNonQuery()
            respuesta = consulta.ExecuteReader
            While respuesta.Read

                nombretextbox = respuesta.Item("nombreempleado")
                apellidoptextbox = respuesta.Item("apellidopatempleado")
                apellidomtextbox = respuesta.Item("apellidomatempleado")

            End While
            respuesta.Close()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Dim arreglo = {nombretextbox, apellidoptextbox, apellidomtextbox}
        Return arreglo

    End Function

    Sub mostrartablapedido(ByVal tabla1 As DataGridView)
        Dim da As New SqlDataAdapter("select idpedido, idcliente,nombrecliente+' '+apellidopaternocliente+' '+apellidomaternocliente as 'Nombre Cliente',montotot, cantprod, fecha, descripcion,  telefonocliente,correocliente, nombreempleado+' '+apellidopatempleado+' '+apellidomatempleado as 'Nombre empleado'  from Pedido2 join Cliente on cliente_idcliente=idcliente join Empleado on empleados_idempleados=idempleado join Forma_de_pago on formadepago_idformadepago=idformadepago", conexion)
        Dim ds As New DataSet
        da.Fill(ds)
        tabla1.DataSource = ds.Tables(0)


    End Sub
    Sub mostrartablaproducto(ByVal tabla1 As DataGridView)
        Dim da As New SqlDataAdapter("select idproducto, nombreproducto, desproducto, precio, stock from producto", conexion)
        Dim ds As New DataSet
        da.Fill(ds)
        tabla1.DataSource = ds.Tables(0)
    End Sub
    Sub mostrartablacliente(ByVal tabla1 As DataGridView)
        Dim da As New SqlDataAdapter("select idcliente, nombrecliente, apellidopaternocliente, apellidomaternocliente, telefonocliente, correocliente from cliente", conexion)
        Dim ds As New DataSet
        da.Fill(ds)
        tabla1.DataSource = ds.Tables(0)
    End Sub
    Sub llenarcategoria(ByVal combo As ComboBox)
        Try

            consulta = New SqlCommand("select nombrecategoria from Categoria", conexion)
            respuesta = consulta.ExecuteReader
            While respuesta.Read
                combo.Items.Add(respuesta(0))

            End While
            respuesta.Close()
        Catch ex As Exception
            MsgBox("No se ha podido recolectar la informacion de la base de datos" & ex.ToString)
        End Try


    End Sub
    Function llenarproducto(ByVal combo As ComboBox, ByVal ncategoria As String)
        Dim nombrecategoria As SqlParameter

        Try
            nombrecategoria = New SqlParameter("@nombrecategoria", SqlDbType.VarChar)
            nombrecategoria.Size = 45
            nombrecategoria.Value = ncategoria
            consulta = New SqlCommand("llenarproducto", conexion)
            consulta.CommandType = CommandType.StoredProcedure
            consulta.Parameters.Add(nombrecategoria)
            consulta.ExecuteNonQuery()
            respuesta = consulta.ExecuteReader
            While respuesta.Read
                combo.Items.Add(respuesta(0))

            End While
            respuesta.Close()
        Catch ex As Exception
            MsgBox("No se ha podido recolectar la informacion de la base de datos" & ex.ToString)
        End Try

    End Function
    Function obtenerprecioproducto(ByVal nombreproducto As String)
        Dim precio As Decimal
        Try
            consulta = New SqlCommand("select precio from producto where nombreproducto='" & nombreproducto & "'", conexion)
            respuesta = consulta.ExecuteReader
            While respuesta.Read
                precio = respuesta.Item("precio")
            End While
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return precio

    End Function
    Sub llenarformadepago(ByVal combo As ComboBox)
        Try

            consulta = New SqlCommand("select descripcion from Forma_de_pago", conexion)
            respuesta = consulta.ExecuteReader
            While respuesta.Read
                combo.Items.Add(respuesta(0))

            End While
            respuesta.Close()
        Catch ex As Exception
            MsgBox("No se ha podido recolectar la informacion de la base de datos" & ex.ToString)
        End Try


    End Sub
    Sub agregarcliente(ByVal nombrecliente As String, ByVal apellidopatcliente As String, ByVal apellidomatcliente As String, ByVal telefonocliente As String, ByVal correocliente As String)
        Dim nombre As SqlParameter
        Dim apellidop As SqlParameter
        Dim apellidom As SqlParameter
        Dim telefono As SqlParameter
        Dim correo As SqlParameter

        Try
            nombre = New SqlParameter("@nombrecliente", SqlDbType.VarChar)
            nombre.Size = 45
            nombre.Value = nombrecliente
            apellidop = New SqlParameter("@paternocliente", SqlDbType.VarChar)
            apellidop.Size = 45
            apellidop.Value = apellidopatcliente
            apellidom = New SqlParameter("@maternocliente", SqlDbType.VarChar)
            apellidom.Size = 45
            apellidom.Value = apellidomatcliente
            telefono = New SqlParameter("@telefonocliente", SqlDbType.Char)
            telefono.Size = 9
            telefono.Value = telefonocliente
            correo = New SqlParameter("@correocliente", SqlDbType.Char)
            correo.Size = 45
            correo.Value = correocliente
            consulta = New SqlCommand("registrarcliente", conexion)
            consulta.CommandType = CommandType.StoredProcedure
            consulta.Parameters.Add(nombre)
            consulta.Parameters.Add(apellidop)
            consulta.Parameters.Add(apellidom)
            consulta.Parameters.Add(telefono)
            consulta.Parameters.Add(correo)
            consulta.ExecuteNonQuery()
            MsgBox("Cliente agregado")

        Catch ex As Exception
            MsgBox("Error al agregar cliente" + ex.ToString)
        End Try

    End Sub
    Sub agregarpedido(ByVal idcliente As Integer, ByVal montotot As Double, ByVal cantidadprod As Integer, ByVal fecha As String, ByVal idformadepago As String, ByVal idempleado As Integer)
        Dim idclientep As SqlParameter
        Dim montototp As SqlParameter
        Dim cantidadprodp As SqlParameter
        Dim fechap As SqlParameter
        Dim idformadepagop As SqlParameter
        Dim idempleadop As SqlParameter
        Try
            idclientep = New SqlParameter("@idcliente", SqlDbType.Int)
            idclientep.Value = idcliente
            montototp = New SqlParameter("@montotot", SqlDbType.Float)
            montototp.Value = montotot
            cantidadprodp = New SqlParameter("@cantidad", SqlDbType.Int)
            cantidadprodp.Value = cantidadprod
            fechap = New SqlParameter("@fecha", SqlDbType.VarChar)
            fechap.Size = 45
            fechap.Value = fecha
            idformadepagop = New SqlParameter("@idformadepago", SqlDbType.Int)
            idformadepagop.Value = idformadepago
            idempleadop = New SqlParameter("@idempleado", SqlDbType.Int)
            idempleadop.Value = idempleado
            consulta = New SqlCommand("registrarpedido", conexion)
            consulta.CommandType = CommandType.StoredProcedure
            consulta.Parameters.Add(idclientep)
            consulta.Parameters.Add(montototp)
            consulta.Parameters.Add(cantidadprodp)
            consulta.Parameters.Add(fechap)
            consulta.Parameters.Add(idformadepagop)
            consulta.Parameters.Add(idempleadop)
            consulta.ExecuteNonQuery()
            MsgBox("Pedido registrado")

        Catch ex As Exception
            MsgBox("Error al agregar pedido" + ex.ToString)
        End Try
    End Sub
    Function obteneridproducto(ByVal nomproducto As String)
        Dim idproducto As Integer
        Try

            consulta = New SqlCommand("select idproducto from producto where nombreproducto='" & nomproducto & "'", conexion)
            respuesta = consulta.ExecuteReader
            While respuesta.Read
                idproducto = respuesta(0)
            End While
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return idproducto
    End Function
    Sub agregardetallepedido(ByVal idpedido As Integer, ByVal idproducto As Integer, ByVal cantidadprod As Integer)
        Dim idpedidop As SqlParameter
        Dim idproductop As SqlParameter
        Dim cantidadprodp As SqlParameter


        Try
            idpedidop = New SqlParameter("@idpedido", SqlDbType.Int)
            idpedidop.Value = idpedido
            idproductop = New SqlParameter("@idproducto", SqlDbType.Int)
            idproductop.Value = idproducto
            cantidadprodp = New SqlParameter("@cantidad", SqlDbType.Int)
            cantidadprodp.Value = cantidadprod
            consulta = New SqlCommand("registrarpedidodetalle", conexion)
            consulta.CommandType = CommandType.StoredProcedure
            consulta.Parameters.Add(idpedidop)
            consulta.Parameters.Add(idproductop)
            consulta.Parameters.Add(cantidadprodp)
            consulta.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub tablafiltropedido(ByVal nombregrid As DataGridView, ByVal nombrecliente As String)
        Dim da As New SqlDataAdapter("select idpedido, idcliente,nombrecliente+' '+apellidopaternocliente+' '+apellidomaternocliente as 'Nombre Cliente',montotot, cantprod, fecha, descripcion,  telefonocliente,correocliente, nombreempleado+' '+apellidopatempleado+' '+apellidomatempleado as 'Nombre empleado'  from Pedido2 join Cliente on cliente_idcliente=idcliente join Empleado on empleados_idempleados=idempleado join Forma_de_pago on formadepago_idformadepago=idformadepago where NombreCliente like '" & nombrecliente & "%'", conexion)
        Dim ds As New DataSet
        da.Fill(ds)
        nombregrid.DataSource = ds.Tables(0)

    End Sub
    Sub tablafiltroproducto(ByVal nombregrid As DataGridView, ByVal nombreproducto As String)
        Dim da As New SqlDataAdapter("select idproducto, nombreproducto, desproducto, precio, stock from producto where nombreproducto like '" & nombreproducto & "%'", conexion)
        Dim ds As New DataSet
        da.Fill(ds)
        nombregrid.DataSource = ds.Tables(0)
    End Sub
    Sub tablafiltrocliente(ByVal tabla1 As DataGridView, ByVal nombrecliente As String)
        Dim da As New SqlDataAdapter("select idcliente, nombrecliente, apellidopaternocliente, apellidomaternocliente, telefonocliente, correocliente from cliente where nombrecliente like'" & nombrecliente & "%'", conexion)
        Dim ds As New DataSet
        da.Fill(ds)
        tabla1.DataSource = ds.Tables(0)
    End Sub
    Function extraerultimoidpedido()
        Dim id As Integer
        Try
            consulta = New SqlCommand("extraerultimoidpedido", conexion)
            respuesta = consulta.ExecuteReader
            While respuesta.Read
                id = respuesta(0)
            End While
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return id
    End Function
    Sub modificarproducto(ByVal nombregrid As DataGridView, ByVal nombreproducto As String, ByVal desproducto As String, ByVal precio As Decimal, ByVal stock As Integer)
        Try
            Dim introw As Integer = nombregrid.CurrentCell.RowIndex
            If introw >= 0 And introw < nombregrid.Rows.Count Then

                Dim idproducto As Integer = nombregrid.SelectedRows(0).Cells("idproducto").Value
                Dim idproductop As SqlParameter
                Dim nombreproductop As SqlParameter
                Dim desproductop As SqlParameter
                Dim preciop As SqlParameter
                Dim stockp As SqlParameter
                idproductop = New SqlParameter("@idproducto", SqlDbType.Int)
                idproductop.Value = idproducto
                nombreproductop = New SqlParameter("@nombreproducto", SqlDbType.VarChar)
                nombreproductop.Size = 45
                nombreproductop.Value = nombreproducto
                desproductop = New SqlParameter("@desproducto", SqlDbType.VarChar)
                desproductop.Size = 90
                desproductop.Value = desproducto
                preciop = New SqlParameter("@precio", SqlDbType.Float)
                preciop.Value = precio
                stockp = New SqlParameter("@stock", SqlDbType.Int)
                stockp.Value = stock



                consulta = New SqlCommand("modificarproducto", conexion)
                consulta.CommandType = CommandType.StoredProcedure
                consulta.Parameters.Add(idproductop)
                consulta.Parameters.Add(nombreproductop)
                consulta.Parameters.Add(desproductop)
                consulta.Parameters.Add(preciop)
                consulta.Parameters.Add(stockp)
                consulta.ExecuteNonQuery()
                MsgBox("Fila modificada")

            Else

                MessageBox.Show("Error al seleccionar filas, no hay un valor valido de filas")

            End If
        Catch ex As Exception
            MsgBox("No se pudo modificar la fila" & ex.ToString)
        End Try
    End Sub
    Sub actualizarstock(ByVal nombreproducto As String, ByVal cantidad As Integer)
        Try
            Dim nombreproductop As SqlParameter
            Dim cantidadp As SqlParameter
            nombreproductop = New SqlParameter("@nombreproducto", SqlDbType.VarChar)
            nombreproductop.Size = 45
            nombreproductop.Value = nombreproducto
            cantidadp = New SqlParameter("@cantidad", SqlDbType.Int)
            cantidadp.Value = cantidad

            consulta = New SqlCommand("actualizarstock", conexion)
            consulta.CommandType = CommandType.StoredProcedure
            consulta.Parameters.Add(nombreproductop)
            consulta.Parameters.Add(cantidadp)
            consulta.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Function obteneridformadepago(ByVal formadepago As String)
        Dim idformadepago As Integer

        Try
            consulta = New SqlCommand("select idformadepago from Forma_de_pago where descripcion='" & formadepago & "'", conexion)
            respuesta = consulta.ExecuteReader
            While respuesta.Read()
                idformadepago = respuesta(0)
            End While

            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return idformadepago
    End Function




End Module
