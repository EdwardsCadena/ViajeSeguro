Public Class RegistrarEntrada

    Private Sub RegistrarEntrada_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        nombre.ReadOnly = False
        apellido.ReadOnly = False
        direccion.ReadOnly = False
        usuario.ReadOnly = False
        contraseña.ReadOnly = False
        rol.ReadOnly = False


        Me.nombre.Text = ""
        Me.apellido.Text = ""
        Me.direccion.Text = ""
        Me.usuario.Text = ""
        Me.contraseña.Text = ""
        Me.rol.Text = ""
        Button1.Visible = False
        Button2.Visible = True
        Button3.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim conexion As New Conexion
        Dim datos As New Datos
        Dim z As Integer

        z = rol.Text
        If (z = 1) Then
            Clave_Del_Administrador.Show()
        Else
            datos.nombres = nombre.Text
            datos.apellidos = apellido.Text
            datos.direcionn = direccion.Text
            datos.nomusuario = usuario.Text
            datos.pass = contraseña.Text
            datos.rolusuario = rol.Text
            If conexion.insertar_Datos(datos) Then
                MessageBox.Show("Se Inserto Correctamente El Usuario", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error Al  Insertar El Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        Button1.Visible = True
        Button2.Visible = True





    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Entrada.Show()
    End Sub
End Class