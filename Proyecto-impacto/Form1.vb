
Public Class Form1
    Public id As Integer
    Public inic As New inicio

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        Me.Opacity = 0.9

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        Application.Exit()
    End Sub

    Private Sub BunifuSeparator1_Load(sender As Object, e As EventArgs) Handles BunifuSeparator1.Load

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Try
            If verificarusuario(TextBoxUser.Text) Then
                Dim contra As String = verificarcontrasena(TextBoxUser.Text)(0)

                If contra.Equals(TextBoxPass.Text) Then
                    Dim nombre As String = verificarcontrasena(TextBoxUser.Text)(1)
                    Dim apellidop As String = verificarcontrasena(TextBoxUser.Text)(2)
                    Dim apellidom As String = verificarcontrasena(TextBoxUser.Text)(3)
                    iduser = verificarcontrasena(TextBoxUser.Text)(4)
                    Form2.Show()


                    Me.Hide()

                Else
                    MsgBox("Contraseña incorrecta", MsgBoxStyle.Critical)

                End If

            Else
                MsgBox("Usuario incorrecto", MsgBoxStyle.Critical)

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
