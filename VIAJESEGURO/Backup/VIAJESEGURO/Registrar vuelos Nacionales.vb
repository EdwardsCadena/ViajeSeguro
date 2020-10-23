Public Class Registrar_vuelos_Nacionales

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.ReadOnly = False
        TextBox2.ReadOnly = False
        TextBox3.ReadOnly = False
        TextBox4.ReadOnly = False
        TextBox5.ReadOnly = False
        TextBox6.ReadOnly = False
        TextBox7.ReadOnly = False
        Button2.Enabled = True
        Button1.Enabled = False

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Vuelos_Nacionales.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim conexion As New Conexion
        Dim datos As New Datos

        datos.CodRool = TextBox1.Text
        datos.NombreEmpresaDeVueloo = TextBox2.Text
        datos.Nombredelpasajero = TextBox3.Text
        datos.NombreDelAeropuertoo = TextBox4.Text
        datos.cciudad = TextBox5.Text
        datos.horadesalidas = TextBox6.Text
        datos.fechass = DateTimePicker1.Text
        datos.Hora_Del_Despegues = TextBox7.Text
        If conexion.insertar_vuelosnacionales(datos) Then
            If conexion.consultar_vuelosnacionales() Then
                Vuelos_Nacionales.DataGridView1.DataSource = conexion._tabla
            End If
            MessageBox.Show("Se Registro Correctamente El Vuelo", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error Al  Registrarse El Vuelo", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If


    End Sub
End Class