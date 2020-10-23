Public Class Vuelos_Internacionales

    Private Sub Vuelos_Internacionales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        banner.Stop()
        banner.Movie = "F:\VIAJESEGURO\Banner 018.swf"
        banner.Play()
        Dim cconcexion As New Conexion
        Dim tabla As New DataTable
        If cconcexion.consultar_todoss Then
            tabla = cconcexion._tabla
            DataGridView1.DataSource = tabla
        Else
            MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        Try

            TextBox.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
            TextBox2.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value
            TextBox1.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value
            TextBox3.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(3).Value
            TextBox4.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(4).Value
            TextBox5.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(5).Value
            TextBox6.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(6).Value
            TextBox7.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(7).Value
            TextBox8.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(8).Value
            TextBox9.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(9).Value

        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtregresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregresar.Click
        Me.Close()
        Servicios.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Registrar_Vuelos.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        TextBox1.ReadOnly = False
        TextBox2.ReadOnly = False
        TextBox3.ReadOnly = False
        TextBox4.ReadOnly = False
        TextBox5.ReadOnly = False
        TextBox6.ReadOnly = False
        TextBox7.ReadOnly = False
        TextBox8.ReadOnly = False

        Button2.Visible = True
        Button3.Visible = False
        Button1.Visible = False
        Button4.Visible = False
        btnregresar.Enabled = False


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim conexion As New Conexion
        Dim datos As New Datos

        datos.NombreDePasajero = TextBox1.Text
        datos.NombreEmpresaDeVuelo = TextBox2.Text
        datos.NombreDeAeropuerto = TextBox3.Text
        datos.Pais1 = TextBox4.Text
        datos.Ciudadess = TextBox5.Text
        datos.HoraDeSalidass = TextBox6.Text
        datos.Fechas = TextBox7.Text
        datos.TiempoDeDespegue = TextBox8.Text
        datos.TiempoAporoximado = TextBox9.Text


        If conexion.Actualizar_Datoss(datos) Then
            If conexion.consultar_todoss() Then
                DataGridView1.DataSource = conexion._tabla
            End If
            MessageBox.Show("Se Actualizo Correctamente", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Se Actualizo Incorrectamente", "Actulizar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        btnregresar.Enabled = True
        Button1.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        Button2.Visible = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim conexion As New Conexion
        Dim datos As New Datos

        datos.CODROLes = TextBox.Text
        If conexion.eliminar_Datoss(datos) Then
            If conexion.consultar_todoss() Then
                DataGridView1.DataSource = conexion._tabla
            End If
            MessageBox.Show("Se Ha Borrado El Registro", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox.Text = ""
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""

        Else
            MessageBox.Show("No Se Pudo Borrar El Registro", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class