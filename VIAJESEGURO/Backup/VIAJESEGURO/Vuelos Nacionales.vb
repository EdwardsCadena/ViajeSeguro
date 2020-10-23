Public Class Vuelos_Nacionales

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        Try
            TextBox1.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
            TextBox2.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value
            TextBox3.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value
            TextBox4.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(3).Value
            TextBox5.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(4).Value
            TextBox6.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(5).Value
            TextBox7.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(6).Value
            TextBox8.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(7).Value
            TextBox9.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(8).Value
            TextBox10.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(9).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Vuelos_Nacionales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        banner.Stop()
        banner.Movie = "F:\VIAJESEGURO\Banner 012.swf"
        banner.Play()

        Dim de As New Conexion
        Dim ds As New DataTable
       
        If de.consultar_vuelosnacionales Then
            ds = de._tabla
            DataGridView1.DataSource = ds
        End If
    End Sub
    Private Sub Actualizarr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizarr.Click
        Actualizarr.Enabled = False
        Button2.Enabled = True
        Button3.Enabled = False
        Button4.Enabled = False


        TextBox2.ReadOnly = False
        TextBox3.ReadOnly = False
        TextBox4.ReadOnly = False
        TextBox5.ReadOnly = False
        TextBox6.ReadOnly = False
        TextBox7.ReadOnly = False
        TextBox8.ReadOnly = False
        TextBox9.ReadOnly = False
        TextBox10.ReadOnly = False


        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True
        TextBox7.Enabled = True
        TextBox8.Enabled = True
        TextBox9.Enabled = True
        TextBox10.Enabled = True

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ds As New Conexion
        Dim datos As New Datos

        datos.CodRool = TextBox2.Text
        datos.NombreEmpresaDeVueloo = TextBox3.Text
        datos.Nombredelpasajero = TextBox4.Text
        datos.NombreDelAeropuertoo = TextBox5.Text
        datos.cciudad = TextBox6.Text
        datos.horadesalidas = TextBox7.Text
        datos.fechass = TextBox8.Text
        datos.Hora_Del_Despegues = TextBox9.Text
        datos.TiempoAproximadaoDeVuelos = TextBox10.Text


        If ds.Actualizar_vuelosnacionales(datos) Then
            If ds.consultar_vuelosnacionales Then
                DataGridView1.DataSource = ds._tabla
            End If
            MessageBox.Show("Se Actualizo Correctamente Su Vuelo", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Se Actualizo Incorrectamente Su Vuelo", "Actulizar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Actualizarr.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Registrar_vuelos_Nacionales.Show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim conexion As New Conexion
        Dim datos As New Datos

        datos.CodRooll = TextBox1.Text
        If conexion.BORRAR_vuelosnacionales(datos) Then
            If conexion.consultar_vuelosnacionales Then
                DataGridView1.DataSource = conexion._tabla
            End If
            MessageBox.Show("Se Ha Borrado Correctamente El Vuelo", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""
            TextBox10.Text = ""
        Else
            MessageBox.Show("Nose Pudo Borrar El Vuelo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Servicios.Show()

    End Sub
End Class