Public Class inicio
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            TextBox1.Text = extraerdatosempleado()(0)
            TextBox2.Text = extraerdatosempleado()(1)
            TextBox3.Text = extraerdatosempleado()(2)

            If iduser = 1 Then
                PictureBoxLuis.Show()
                PictureBoxPercy.Hide()
                PictureBoxPipo.Hide()
            Else
                If iduser = 2 Then
                    PictureBoxLuis.Hide()
                    PictureBoxPercy.Show()
                    PictureBoxPipo.Hide()
                Else
                    If iduser = 3 Then
                        PictureBoxPipo.Show()
                        PictureBoxPercy.Hide()
                        PictureBoxLuis.Hide()
                    End If
                End If
            End If

            Label1.Text = "Hola denuevo " + mostrarbienvenida(iduser)(0) + " " + mostrarbienvenida(iduser)(1) + " " + mostrarbienvenida(iduser)(2) + "!"
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BotonEditar_Click(sender As Object, e As EventArgs) Handles BotonEditar.Click
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        BunifuFlatButtonGuardar.Visible = True
        BunifuFlatButtonCancelar.Visible = True
        BotonEditar.Enabled = False






    End Sub

    Private Sub BunifuFlatButtonCancelar_Click(sender As Object, e As EventArgs) Handles BunifuFlatButtonCancelar.Click
        BunifuFlatButtonCancelar.Visible = False
        BunifuFlatButtonGuardar.Visible = False
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        BotonEditar.Enabled = True

    End Sub

    Private Sub BunifuFlatButtonGuardar_Click(sender As Object, e As EventArgs) Handles BunifuFlatButtonGuardar.Click
        actualizarinfoempleado(TextBox1.Text, TextBox2.Text, TextBox3.Text)
        BunifuFlatButtonCancelar.Visible = False
        BunifuFlatButtonGuardar.Visible = False
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        BotonEditar.Enabled = True
        Label1.Text = "Hola denuevo " + mostrarbienvenida(iduser)(0) + " " + mostrarbienvenida(iduser)(1) + " " + mostrarbienvenida(iduser)(2) + "!"
    End Sub
End Class