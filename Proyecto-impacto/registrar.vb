Imports WL


Public Class registrar
    Private suma As Double = 0

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub BunifuDropdown1_onItemSelected(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        If ((TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox3.Text = "") Or (TextBox4.Text = "") Or (TextBox5.Text = "")) Then
            MsgBox("Llenar todos los datos")
        Else
            agregarcliente(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)


        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""

    End Sub

    Private Sub Registrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
        llenarcategoria(ComboBox1)
        llenarformadepago(ComboBox3)
        TextBox6.Visible = False
        BunifuSeparator7.Visible = False







    End Sub

    Private Sub BunifuSeparator2_Load(sender As Object, e As EventArgs) Handles BunifuSeparator2.Load

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label10.Visible = False
            Label11.Visible = False
            TextBox1.Visible = False
            TextBox2.Visible = False
            TextBox3.Visible = False
            TextBox4.Visible = False
            TextBox5.Visible = False
            BunifuSeparator2.Visible = False
            BunifuSeparator3.Visible = False
            BunifuSeparator4.Visible = False
            BunifuSeparator5.Visible = False
            BunifuSeparator6.Visible = False
            Label12.Visible = True
            TextBox6.Visible = True
            BunifuSeparator7.Visible = True


        Else

            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            Label10.Visible = True
            Label11.Visible = True
            TextBox1.Visible = True
            TextBox2.Visible = True
            TextBox3.Visible = True
            TextBox4.Visible = True
            TextBox5.Visible = True
            BunifuSeparator2.Visible = True
            BunifuSeparator3.Visible = True
            BunifuSeparator4.Visible = True
            BunifuSeparator5.Visible = True
            BunifuSeparator6.Visible = True
            Label12.Visible = False
            TextBox6.Visible = False
            BunifuSeparator7.Visible = False


        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.Items.Clear()
        llenarproducto(ComboBox2, ComboBox1.SelectedItem)

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click




        suma += Convert.ToDouble(Label18.Text)
        Label17.Text = suma.ToString()




        DataGridView1.Rows.Add(ComboBox1.SelectedItem, ComboBox2.SelectedItem, TextBox7.Text, TextBox8.Text, Label18.Text)
        ComboBox2.Items.Clear()
        TextBox7.Text = ""
        Label18.Text = ""

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        TextBox8.Text = obtenerprecioproducto(ComboBox2.SelectedItem)
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Dim montotot As Double = 0
        Dim cantidadtotprod As Integer = 0
        Dim fecha As String = String.Format("{0:G}", DateTime.Now)
        Dim producto As String
        Dim cantidad As Integer



        Dim formapago As String
        formapago = ComboBox3.SelectedItem

        Dim ticket1 = New Tickets






        For Each fila As DataGridViewRow In DataGridView1.Rows
            montotot += Convert.ToDouble(fila.Cells("PrecioTotal").Value)
            cantidadtotprod += Convert.ToInt16(fila.Cells("Cantidad").Value)

        Next

        agregarpedido(Convert.ToInt32(TextBox6.Text), montotot, cantidadtotprod, fecha, obteneridformadepago(formapago), iduser)

        If DataGridView1.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In DataGridView1.Rows
                If Fila.Cells("Categoria").Value IsNot Nothing Then
                    agregardetallepedido(extraerultimoidpedido(), obteneridproducto(Fila.Cells("Producto").Value), Fila.Cells("Cantidad").Value)
                    producto = Fila.Cells("Producto").Value
                    cantidad = Convert.ToInt32(Fila.Cells("Cantidad").Value)
                    actualizarstock(producto, cantidad)




                End If
            Next
        End If
        Dim canceladocon As Decimal = TextBox9.Text
        Dim vuelto As Decimal = canceladocon - montotot
        Dim preciounidad As Decimal
        Dim preciototal As Decimal

        ''IMPRIMIMOS EL TICKET
        ticket1.Limpiar()
        ticket1.Logo("buy.png")
        ticket1.Titulo("IMPORTACIONES IMPACTO S.A.C")
        ticket1.Encabezado("AV WILSON 232 CENTRO DE LIMA")
        ticket1.Encabezado("CIUDAD CODIGO POSTAL")
        ticket1.Encabezado("RFC: ABC12345678")
        ticket1.Encabezado("FECHA: " + DateTime.Now.ToShortDateString())
        If DataGridView1.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In DataGridView1.Rows
                If Fila.Cells("Categoria").Value IsNot Nothing Then
                    cantidad = Fila.Cells("Cantidad").Value
                    producto = Fila.Cells("Producto").Value
                    preciounidad = Fila.Cells("PrecioUnidad").Value
                    preciototal = Fila.Cells("PrecioTotal").Value
                    ticket1.Articulo("123456789", cantidad, producto, preciounidad, preciototal)

                End If
            Next
        End If
        ticket1.NumArticulos(cantidadtotprod)
        ticket1.Total(montotot)
        ticket1.Pago("CANCELADO CON:", TextBox9.Text)
        ticket1.Pago("TARJETA:", "")
        ticket1.Pago("VUELTO:", vuelto)
        ticket1.Pie("=================================================")
        ticket1.Pie("GRACIAS POR SU PREFERENCIA!!")
        ticket1.VistaPrevia()


        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        DataGridView1.Rows.Clear()
        Label17.Text = ""
        suma = 0





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        Label18.Text = Val(TextBox7.Text) * Val(TextBox8.Text)

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        DataGridView1.Rows.Clear()
        Label17.Text = ""
        suma = 0
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub
End Class