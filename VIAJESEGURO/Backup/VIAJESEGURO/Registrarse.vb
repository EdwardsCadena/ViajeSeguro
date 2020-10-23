Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Registrarse
    Dim DA As SqlDataAdapter
    Dim DS As DataSet
    Public cnn As New SqlCommand("Data Source=A411S003;Initial Catalog=volarseguro;Integrated Security=True")
    Private Sub cargar_Combo(ByVal ComboBox As ComboBox, ByVal sql As String)
        Dim strConexion As String = "Data Source=A411S003;Initial Catalog=volarseguro;Integrated Security=True"
        Dim conexion As New SqlConnection(strConexion)
        Try
            conexion.Open()
            Dim cdm As New SqlCommand(sql, conexion)
            Dim da As New SqlDataAdapter(cdm)
            Dim ds As New DataSet
            da.Fill(ds)
            ComboBox.DataSource = ds.Tables(0)
            ComboBox.DisplayMember = ds.Tables(0).Columns(1).Caption.ToString
            ComboBox.ValueMember = ds.Tables(0).Columns(0).Caption
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub




    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ae As Integer

        ae = rol.Text

        If (ae = 1) Then
            TextBox1.Visible = True
            Button4.Visible = True
            Label7.Visible = True
        End If
        Button2.Visible = False



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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Servicios.Show()
        Servicios.Button1.Visible = False
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Servicios.Show()

    End Sub

    Private Sub Registrarse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim conexion As New Conexion
        Dim datos As New Datos
        Dim ad As Integer
        datos.nombres = nombre.Text
        datos.apellidos = apellido.Text
        datos.direcionn = direccion.Text
        datos.nomusuario = usuario.Text
        datos.pass = contraseña.Text
        datos.rolusuario = rol.Text
        ad = TextBox1.Text

        If (ad = 1996) Then
            If conexion.insertar_Datos(datos) Then
                If conexion.consultar_todos() Then
                    Servicios.DGDatos.DataSource = conexion._tabla
                End If
                MessageBox.Show("Se Inserto Correctamente El Usuario", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error Al  Insertar El Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Error Al  Insertar La Contraseña Del Administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
        Button1.Visible = True
        Button2.Visible = False
        Me.Hide()
        Servicios.Show()
    End Sub
End Class