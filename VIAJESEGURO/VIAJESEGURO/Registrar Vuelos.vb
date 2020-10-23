Public Class Registrar_Vuelos


    Private Sub Registrar_Vuelos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click



        txtnomempresa.ReadOnly = False
        txtnompasa.ReadOnly = False



        Me.pdd.Text = ""

        Me.nda.Text = ""
        Me.txtnomempresa.Text = ""
        Me.txtnompasa.Text = ""
        Me.ciudad.Text = ""

        btnnuevo.Visible = False
        btngrabar.Visible = True

    End Sub

    Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        Dim conexion As New Conexion
        Dim datos As New Datos

        datos.Ciudadess = ciudad.Text
        datos.Pais1 = pdd.Text
        datos.NombreDeAeropuerto = nda.Text
        datos.NombreEmpresaDeVuelo = txtnomempresa.Text
        datos.NombreDePasajero = txtnompasa.Text
        datos.Fechas = DateTimePicker1.Text
        If conexion.insertar_Datoss(datos) Then
            If conexion.consultar_todoss() Then
                Vuelos_Internacionales.DataGridView1.DataSource = conexion._tabla
            End If
            MessageBox.Show("Se Registro Correctamente", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error Al  Registrarse", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Me.Hide()
        Vuelos_Internacionales.Show()

    End Sub

    Private Sub btnregresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregresar.Click
        Me.Hide()
        Vuelos_Internacionales.Show()

    End Sub
End Class