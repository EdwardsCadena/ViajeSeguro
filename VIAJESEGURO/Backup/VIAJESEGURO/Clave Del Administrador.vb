Public Class Clave_Del_Administrador
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim datos As New Datos
        Dim cconexion As New Conexion
        datos.nombres = RegistrarEntrada.nombre.Text
        datos.apellidos = RegistrarEntrada.apellido.Text
        datos.direcionn = RegistrarEntrada.direccion.Text
        datos.nomusuario = RegistrarEntrada.usuario.Text
        datos.pass = RegistrarEntrada.contraseña.Text
        datos.rolusuario = RegistrarEntrada.rol.Text
        Dim a As Integer
        a = TextBox1.Text
        If (a = 1996) Then
            If cconexion.insertar_Datos(datos) Then
                MessageBox.Show("Se Inserto Correctamente El Usuario", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error Al  Insertar El Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        Else
            MessageBox.Show("Error Al  Insertar La Contraseña Del Administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Me.Hide()
        Entrada.Show()
        RegistrarEntrada.Close()
        TextBox1.Text = ""

    End Sub
End Class