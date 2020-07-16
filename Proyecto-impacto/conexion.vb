Module conexion
    Function verificarLogin(ByVal nombreUsuario As String, ByVal clave As String)
        Dim valido As Boolean = False
        Dim username As String = "Shakur23"
        Dim password As String = "Shakur2311"
        Try
            If username.Equals(nombreUsuario) And password.Equals(clave) Then
                valido = True

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
        Return valido
    End Function
End Module
