Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Servicios
    Dim accion As Boolean
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim registra As New Registrarse
        registra.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim conexion As New Conexion
        Dim datos As New Datos

        datos.coddroll = TextBox1.Text
        If conexion.eliminar_Datos(datos) Then
            If conexion.consultar_todos() Then
                DGDatos.DataSource = conexion._tabla
            End If
            MessageBox.Show("Se Ha Borrado El Registro", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""

        Else
            MessageBox.Show("Nose Pudo Borrado El Registro Correctamente", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub Servicios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cconcexion As New Conexion
        Dim tabla As New DataTable
       
        banner.Stop()
        banner.Movie = "F:\VIAJESEGURO\Banner 011.swf"
        banner.Play()

        Dim x As Integer
        x = Entrada.TextBox1.Text
        If (x = 1) Then
            MsgBox("Bienvenido Administrador")
            If cconcexion.consultar_todos Then
                tabla = cconcexion._tabla
                DGDatos.DataSource = tabla

            Else
                MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf (x = 2) Then
            MsgBox("Bienvenido Cliente")
            ActualizarToolStripMenuItem.Enabled = True
            BorrarToolStripMenuItem.Enabled = False
            RegistarToolStripMenuItem.Enabled = False
            If cconcexion.consultar_todosss() Then
                DGDatos.DataSource = cconcexion._tabla
                Label5.Visible = False
                Label6.Visible = False
                TextBox5.Visible = False
                TextBox6.Visible = False
            End If
        Else : x = 3
            MsgBox("Bienvenido Trabajador")
            BorrarToolStripMenuItem.Enabled = False
            If cconcexion.consultar_todosss() Then
                DGDatos.DataSource = cconcexion._tabla
                Label5.Visible = False
                Label6.Visible = False
                TextBox5.Visible = False
                TextBox6.Visible = False
            End If

        End If
    End Sub

    Private Sub DGDatos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGDatos.CellContentClick

    End Sub

    Private Sub DGDatos_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGDatos.SelectionChanged
        Try
            TextBox1.Text = DGDatos.Rows(DGDatos.CurrentRow.Index).Cells(0).Value
            TextBox2.Text = DGDatos.Rows(DGDatos.CurrentRow.Index).Cells(1).Value
            TextBox3.Text = DGDatos.Rows(DGDatos.CurrentRow.Index).Cells(2).Value
            TextBox4.Text = DGDatos.Rows(DGDatos.CurrentRow.Index).Cells(3).Value
            TextBox5.Text = DGDatos.Rows(DGDatos.CurrentRow.Index).Cells(4).Value
            TextBox6.Text = DGDatos.Rows(DGDatos.CurrentRow.Index).Cells(5).Value
            TextBox7.Text = DGDatos.Rows(DGDatos.CurrentRow.Index).Cells(6).Value

        Catch ex As Exception
        End Try
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Me.Close()
        Entrada.Show()
        Entrada.usuario.Text = ""
        Entrada.contraseña.Text = ""

    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub BorrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrarToolStripMenuItem.Click
        Button2.Visible = True
        Button1.Visible = False
        Button3.Visible = False
        Button4.Visible = False

    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click
        Button3.Visible = True
        Button1.Visible = False
        Button2.Visible = False
        Button4.Visible = False
    End Sub

    Private Sub RegistarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistarToolStripMenuItem.Click
        Button1.Visible = True
        Button3.Visible = False
        Button2.Visible = False
        Button4.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button3.Visible = False
        Button4.Visible = True

        TextBox2.ReadOnly = False
        TextBox3.ReadOnly = False
        TextBox4.ReadOnly = False
        TextBox5.ReadOnly = False
        TextBox6.ReadOnly = False
        TextBox7.ReadOnly = False





        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True
        TextBox7.Enabled = True



        accion = False

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim conexion As New Conexion
        Dim datos As New Datos

        datos.nombres = TextBox2.Text
        datos.apellidos = TextBox3.Text
        datos.direcionn = TextBox4.Text
        datos.nomusuario = TextBox5.Text
        datos.pass = TextBox6.Text
        datos.rolusuario = TextBox1.Text
        If conexion.Actualizar_Datos(datos) Then
            If conexion.consultar_todos() Then
                DGDatos.DataSource = conexion._tabla
            End If
            MessageBox.Show("Se Inserto Correctamente El Cambio", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error Al  Cambiar El Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub VuelosInternacionalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VuelosInternacionalesToolStripMenuItem.Click
        Me.Close()
        Vuelos_Internacionales.Show()
    End Sub

    Private Sub VuelosNacionalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VuelosNacionalesToolStripMenuItem.Click
        Me.Close()
        Vuelos_Nacionales.Show()

    End Sub

    Private Sub HotelesNacionalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HotelesNacionalesToolStripMenuItem.Click
        Me.Close()
        Hoteles_Nacionales.Show()

    End Sub

    Private Sub HotelesInternacionalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HotelesInternacionalesToolStripMenuItem.Click
        Me.Close()
        Hoteles_Internacionales.Show()
    End Sub
End Class

