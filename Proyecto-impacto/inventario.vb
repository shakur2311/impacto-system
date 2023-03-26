Public Class inventario
    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
        mostrartablapedido(DataGridView1)
        mostrartablaproducto(DataGridView2)
        mostrartablacliente(DataGridView3)

        DataGridView1.Visible = False
        DataGridView2.Visible = True
        DataGridView3.Visible = False
        BunifuFlatButton1.Visible = True
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        TextBoxProducto.Visible = True
        TextBoxDes.Visible = True
        TextBoxPrecio.Visible = True
        TextBoxStock.Visible = True
        BunifuSeparator2.Visible = True
        BunifuSeparator3.Visible = True
        BunifuSeparator4.Visible = True
        BunifuSeparator6.Visible = True

        DataGridView1.Columns(0).HeaderText = "id pedido"
        DataGridView1.Columns(1).HeaderText = "id cliente"
        DataGridView1.Columns(2).HeaderText = "Cliente"
        DataGridView1.Columns(3).HeaderText = "Monto total"
        DataGridView1.Columns(4).HeaderText = "Cantidad productos"
        DataGridView1.Columns(5).HeaderText = "Fecha pedido"
        DataGridView1.Columns(6).HeaderText = "ID Forma de pago"
        DataGridView1.Columns(7).HeaderText = "Telefono"
        DataGridView1.Columns(8).HeaderText = "Correo"
        DataGridView1.Columns(9).HeaderText = "Empleado"

    End Sub

    Private Sub BunifuCustomDataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        If RadioButtonPedido.Checked Then
            tablafiltropedido(DataGridView1, TextBoxSearch.Text)
        Else
            If RadioButtonProducto.Checked Then
                tablafiltroproducto(DataGridView2, TextBoxSearch.Text)
            Else
                If RadioButtonCliente.Checked Then
                    tablafiltrocliente(DataGridView3, TextBoxSearch.Text)
                End If
            End If
        End If


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        If RadioButtonPedido.Checked Then
            mostrartablapedido(DataGridView1)
        Else
            If RadioButtonProducto.Checked Then
                mostrartablaproducto(DataGridView2)
            Else
                If RadioButtonCliente.Checked Then
                    mostrartablacliente(DataGridView3)
                End If

            End If
        End If
    End Sub

    Private Sub RadioButtonPedido_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonPedido.CheckedChanged
        DataGridView1.Visible = True
        DataGridView2.Visible = False
        DataGridView3.Visible = False
        BunifuFlatButton1.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        TextBoxProducto.Visible = False
        TextBoxDes.Visible = False
        TextBoxPrecio.Visible = False
        TextBoxStock.Visible = False
        BunifuSeparator2.Visible = False
        BunifuSeparator3.Visible = False
        BunifuSeparator4.Visible = False
        BunifuSeparator6.Visible = False


    End Sub

    Private Sub RadioButtonProducto_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonProducto.CheckedChanged
        DataGridView1.Visible = False
        DataGridView2.Visible = True
        DataGridView3.Visible = False
        BunifuFlatButton1.Visible = True
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        TextBoxProducto.Visible = True
        TextBoxDes.Visible = True
        TextBoxPrecio.Visible = True
        TextBoxStock.Visible = True
        BunifuSeparator2.Visible = True
        BunifuSeparator3.Visible = True
        BunifuSeparator4.Visible = True
        BunifuSeparator6.Visible = True


    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        modificarproducto(DataGridView2, TextBoxProducto.Text, TextBoxDes.Text, Convert.ToDecimal(TextBoxPrecio.Text), Convert.ToInt32(TextBoxStock.Text))
        TextBoxProducto.Text = ""
        TextBoxDes.Text = ""
        TextBoxPrecio.Text = ""
        TextBoxStock.Text = ""

    End Sub

    Private Sub RadioButtonCliente_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonCliente.CheckedChanged
        DataGridView1.Visible = False
        DataGridView2.Visible = False
        DataGridView3.Visible = True
        BunifuFlatButton1.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        TextBoxProducto.Visible = False
        TextBoxDes.Visible = False
        TextBoxPrecio.Visible = False
        TextBoxStock.Visible = False
        BunifuSeparator2.Visible = False
        BunifuSeparator3.Visible = False
        BunifuSeparator4.Visible = False
        BunifuSeparator6.Visible = False
    End Sub
End Class