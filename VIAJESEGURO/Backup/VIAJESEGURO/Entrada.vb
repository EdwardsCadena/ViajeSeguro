Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Entrada
    Public Nombre, Apellido As String
    Private Sub cargar_Combo(ByVal ComboBox As ComboBox, ByVal sql As String)
        Dim strConexion As String = "Data Source=A411S003;Initial Catalog=volarseguro;Integrated Security=True"
        Dim conexion As New SqlConnection(strConexion)
        Try
            conexion.open()
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

    Private Sub Entrada_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        banner.Stop()
        banner.Movie = "F:\VIAJESEGURO\Banner 009.swf"
        banner.Play()
        cargar_Combo(roles, "select CodRol,TipoRol from rol")
    End Sub

    Private Sub acceso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acceso.Click
        Try
            Dim dts As New Datos
            Dim func As New Funciones

            dts.nomusuario = usuario.Text
            dts.pass = contraseña.Text
            dts.rolusuario = roles.SelectedValue
            TextBox1.Text = roles.SelectedValue

            If func.validar(dts) = True Then

                Servicios.Show()
                Me.Hide()


            Else
                MsgBox("Error en el Usuario, Contraseña o Rol", MsgBoxStyle.Information)
                usuario.Clear()
                contraseña.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Hide()
        RegistrarEntrada.Show()

    End Sub

    Private Sub banner_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub roles_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles roles.SelectedIndexChanged

    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxWindowsMediaPlayer1.Enter, AxWindowsMediaPlayer1.VisibleChanged

    End Sub
End Class