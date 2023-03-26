
Public Class Form2
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel3_Paint_1(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BotonLista_Click(sender As Object, e As EventArgs) Handles BotonSalirApp.Click
        Application.Exit()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrirFormulario(inicio)
    End Sub

    Private Sub BotonMinimizar_Click(sender As Object, e As EventArgs) Handles BotonMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BotonMaximizar_Click(sender As Object, e As EventArgs) Handles BotonMaximizar.Click

        If WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal

        Else
            If WindowState = FormWindowState.Normal Then
                WindowState = FormWindowState.Maximized
            End If


        End If

    End Sub

    Private Sub BunifuCustomLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles BotonInicio.Click
        abrirFormulario(inicio)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If Panel2.Width = 183 Then
            Panel2.Visible = False
            Panel2.Width = 50
            MenuCerrar.Show(Panel2)
        Else
            Panel2.Visible = False
            Panel2.Width = 183
            MenuAbrir.Show(Panel2)

        End If

    End Sub
    Private actualFormulario As Form = Nothing
    Private anteriorFormulario As Form = Nothing
    Private Sub abrirFormulario(hijoForm As Form)
        If actualFormulario IsNot Nothing Then
            anteriorFormulario = actualFormulario
            If anteriorFormulario IsNot actualFormulario Then
                anteriorFormulario = actualFormulario
                actualFormulario.Close()


            End If


        End If
        actualFormulario = hijoForm
        hijoForm.TopLevel = False
        hijoForm.FormBorderStyle = FormBorderStyle.None
        hijoForm.Dock = DockStyle.Fill
        Panel3.Controls.Add(hijoForm)
        Panel3.Tag = hijoForm
        hijoForm.BringToFront()
        hijoForm.Show()

    End Sub

    Private Sub BotonBuscar_Click(sender As Object, e As EventArgs) Handles BotonBuscar.Click
        abrirFormulario(inventario)
    End Sub

    Private Sub BotonRegistrar_Click(sender As Object, e As EventArgs) Handles BotonRegistrar.Click
        abrirFormulario(registrar)
    End Sub

    Private Sub Panel3_Paint_2(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class