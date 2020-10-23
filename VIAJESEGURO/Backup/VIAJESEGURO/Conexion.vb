Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Conexion
    Private cadena As String
    Private conexion As SqlConnection
    Private tabla As DataTable = New DataTable
    Private adaptador As SqlDataAdapter = New SqlDataAdapter
    Public Shared cnn As New SqlConnection
    Private Sub Conexionn()
        cadena = "Data Source=A411S003;Initial Catalog=volarseguro;Integrated Security=True"
        conexion = New SqlConnection(cadena)
    End Sub
    Public ReadOnly Property _tabla() As DataTable
        Get
            Return tabla
        End Get
    End Property
    Public Function consultar_todos() As Boolean
        Dim estado As Boolean = True
        Try
            adaptador.SelectCommand = New SqlCommand("select Codusuario,CodRol,Nombres,Apellidos,Direccion,usuario,contraseña from usuario", cnn)
            adaptador.Fill(tabla)
        Catch ex As SqlException
            estado = False
        Finally
            Desconectado()
        End Try
        Return estado
    End Function
    'Tabla de Hoteles Internacionales'
    Public Function insertar_Hoteles_Internacionales(ByVal datos As Datos) As Boolean
        Dim estado As Boolean = True
        Try
            Conexionn()
            adaptador.InsertCommand = New SqlCommand("insert into Hoteles_Internacinales (COdRoll, Nombre_Del_Hotel, Nombre_Del_Cliente, Direccion_Del_Hotel, pais, Ciudad, Estrellas from Hoteles_Internacinales) values (@cod , @ndh , @ndc , @ddh , @pais , @ciudad, @estrellas)", conexion)

            adaptador.InsertCommand.Parameters.Add("@cod", SqlDbType.Int).Value = datos.Codigo
            adaptador.InsertCommand.Parameters.Add("@ndh", SqlDbType.VarChar, 80).Value = datos.NombreDelHotel
            adaptador.InsertCommand.Parameters.Add("@ndc", SqlDbType.VarChar, 80).Value = datos.NombreDelCliente
            adaptador.InsertCommand.Parameters.Add("@ddh", SqlDbType.VarChar, 80).Value = datos.DireccionDelHotel
            adaptador.InsertCommand.Parameters.Add("@pais", SqlDbType.VarChar, 50).Value = datos.Paiss
            adaptador.InsertCommand.Parameters.Add("@ciudad", SqlDbType.VarChar, 50).Value = datos.Ciudaddd
            adaptador.InsertCommand.Parameters.Add("@estrellas", SqlDbType.Int).Value = datos.Estrellass

            conexion.Open()
            adaptador.InsertCommand.Connection = conexion
            adaptador.InsertCommand.ExecuteNonQuery()
        Catch ex As Exception
            estado = False
        Finally
            Desconectado()
        End Try
        Return estado
    End Function
    Public Function Actualizar_Datos(ByVal datos As Datos) As Boolean
        Dim estado As Boolean = True
        Try
            Conexionn()
            adaptador.UpdateCommand = New SqlCommand("update usuario set Nombres=@nomb,Apellidos=@apel,Direccion=@direc,usuario=@log,contraseña=@pas where  CodRol=@rol", conexion)
            adaptador.UpdateCommand.Parameters.Add("@rol", SqlDbType.Int).Value = datos.rolusuario
            adaptador.UpdateCommand.Parameters.Add("@nomb", SqlDbType.VarChar, 50).Value = datos.nombres
            adaptador.UpdateCommand.Parameters.Add("@apel", SqlDbType.VarChar, 50).Value = datos.apellidos
            adaptador.UpdateCommand.Parameters.Add("@direc", SqlDbType.VarChar, 40).Value = datos.direcionn
            adaptador.UpdateCommand.Parameters.Add("@log", SqlDbType.VarChar, 50).Value = datos.nomusuario
            adaptador.UpdateCommand.Parameters.Add("@pas", SqlDbType.VarChar, 30).Value = datos.pass
            conexion.Open()
            adaptador.UpdateCommand.Connection = conexion
            adaptador.UpdateCommand.ExecuteNonQuery()
        Catch ex As Exception
            estado = False
        Finally
            Desconectado()
        End Try
        Return estado
    End Function
    Public Function eliminar_Datos(ByVal datos As Datos) As Boolean
        Dim estado As Boolean = True
        Try
            Conexionn()
            adaptador.DeleteCommand = New SqlCommand("delete from usuario where Codusuario=@rol", conexion)
            adaptador.DeleteCommand.Parameters.Add("@rol", SqlDbType.Int).Value = datos.coddroll
            conexion.Open()
            adaptador.DeleteCommand.Connection = conexion
            adaptador.DeleteCommand.ExecuteNonQuery()
        Catch ex As Exception
            estado = False
        Finally
            Desconectado()
        End Try
        Return estado
    End Function
    Public Function consultar_Hoteles_Internacionales() As Boolean
        Dim estado As Boolean = True
        Try
            adaptador.SelectCommand = New SqlCommand("select COdRoll, Nombre_Del_Hotel, Nombre_Del_Cliente, Direccion_Del_Hotel, pais, Ciudad, Estrellas from Hoteles_Internacinales", cnn)
            adaptador.Fill(tabla)
        Catch ex As SqlException
            estado = False
        Finally
            Desconectado()
        End Try
        Return estado
    End Function


    'Tabla de Usuarios'
    Public Function insertar_Datos(ByVal datos As Datos) As Boolean
        Dim estado As Boolean = True
        Try
            Conexionn()
            adaptador.InsertCommand = New SqlCommand("insert into usuario (CodRol,Nombres,Apellidos,Direccion,usuario,contraseña) values (@rol , @nomb , @apel , @direc , @log , @pas)", conexion)

            adaptador.InsertCommand.Parameters.Add("@rol", SqlDbType.Int).Value = datos.rolusuario
            adaptador.InsertCommand.Parameters.Add("@nomb", SqlDbType.VarChar, 50).Value = datos.nombres
            adaptador.InsertCommand.Parameters.Add("@apel", SqlDbType.VarChar, 50).Value = datos.apellidos
            adaptador.InsertCommand.Parameters.Add("@direc", SqlDbType.VarChar, 40).Value = datos.direcionn
            adaptador.InsertCommand.Parameters.Add("@log", SqlDbType.VarChar, 50).Value = datos.nomusuario
            adaptador.InsertCommand.Parameters.Add("@pas", SqlDbType.VarChar, 30).Value = datos.pass
            conexion.Open()
            adaptador.InsertCommand.Connection = conexion
            adaptador.InsertCommand.ExecuteNonQuery()
        Catch ex As Exception
            estado = False
        Finally
            Desconectado()
        End Try
        Return estado
    End Function
    Public Function Actualizar_Datos(ByVal datos As Datos) As Boolean
        Dim estado As Boolean = True
        Try
            Conexionn()
            adaptador.UpdateCommand = New SqlCommand("update usuario set Nombres=@nomb,Apellidos=@apel,Direccion=@direc,usuario=@log,contraseña=@pas where  CodRol=@rol", conexion)
            adaptador.UpdateCommand.Parameters.Add("@rol", SqlDbType.Int).Value = datos.rolusuario
            adaptador.UpdateCommand.Parameters.Add("@nomb", SqlDbType.VarChar, 50).Value = datos.nombres
            adaptador.UpdateCommand.Parameters.Add("@apel", SqlDbType.VarChar, 50).Value = datos.apellidos
            adaptador.UpdateCommand.Parameters.Add("@direc", SqlDbType.VarChar, 40).Value = datos.direcionn
            adaptador.UpdateCommand.Parameters.Add("@log", SqlDbType.VarChar, 50).Value = datos.nomusuario
            adaptador.UpdateCommand.Parameters.Add("@pas", SqlDbType.VarChar, 30).Value = datos.pass
            conexion.Open()
            adaptador.UpdateCommand.Connection = conexion
            adaptador.UpdateCommand.ExecuteNonQuery()
        Catch ex As Exception
            estado = False
        Finally
            Desconectado()
        End Try
        Return estado
    End Function
    Public Function eliminar_Datos(ByVal datos As Datos) As Boolean
        Dim estado As Boolean = True
        Try
            Conexionn()
            adaptador.DeleteCommand = New SqlCommand("delete from usuario where Codusuario=@rol", conexion)
            adaptador.DeleteCommand.Parameters.Add("@rol", SqlDbType.Int).Value = datos.coddroll
            conexion.Open()
            adaptador.DeleteCommand.Connection = conexion
            adaptador.DeleteCommand.ExecuteNonQuery()
        Catch ex As Exception
            estado = False
        Finally
            Desconectado()
        End Try
        Return estado
    End Function
    Public Function consultar_todosss() As Boolean
        Dim estado As Boolean = True
        Try
            adaptador.SelectCommand = New SqlCommand("select Codusuario,CodRol,Nombres,Apellidos,Direccion from usuario", cnn)
            adaptador.Fill(tabla)
        Catch ex As SqlException
            estado = False
        Finally
            Desconectado()
        End Try
        Return estado
    End Function
    'Tabla de Vuelos Internacionales'
    Public Function consultar_todoss() As Boolean
        Dim estado As Boolean = True
        Try
            adaptador.SelectCommand = New SqlCommand("select * from Destino_Internacional", cnn)
            adaptador.Fill(tabla)
        Catch ex As SqlException
            estado = False
        Finally
            Desconectado()
        End Try
        Return estado
    End Function
    Public Function insertar_Datoss(ByVal datos As Datos) As Boolean
        Dim estado As Boolean = True
        Try
            Conexionn()
            adaptador.InsertCommand = New SqlCommand("insert into Destino_Internacional (Nombre_Empresa_De_Vuelo, Nombre_Del_Pasajero, Nombre_Del_Aeropuerto, Pais, Ciudad, Fecha) values (@nomb , @nombpas , @nombaer , @paiss, @ciud, @Fecha )", conexion)
            adaptador.InsertCommand.Parameters.Add("@nomb", SqlDbType.VarChar, 50).Value = datos.NombreEmpresaDeVuelo
            adaptador.InsertCommand.Parameters.Add("@nombpas", SqlDbType.VarChar, 80).Value = datos.NombreDePasajero
            adaptador.InsertCommand.Parameters.Add("@nombaer", SqlDbType.VarChar, 80).Value = datos.NombreDeAeropuerto
            adaptador.InsertCommand.Parameters.Add("@paiss", SqlDbType.VarChar, 50).Value = datos.Pais1
            adaptador.InsertCommand.Parameters.Add("@ciud", SqlDbType.VarChar, 50).Value = datos.Ciudades
            adaptador.InsertCommand.Parameters.Add("@Fecha", SqlDbType.VarChar, 60).Value = datos.Fechas
            conexion.Open()
            adaptador.InsertCommand.Connection = conexion
            adaptador.InsertCommand.ExecuteNonQuery()
        Catch ex As Exception
            estado = False
        Finally
            Desconectado()
        End Try
        Return estado
    End Function
    Public Function Actualizar_Datoss(ByVal datos As Datos) As Boolean
        Dim estado As Boolean = True
        Try
            Conexionn()
            adaptador.UpdateCommand = New SqlCommand("update Destino_Internacional set Nombre_Empresa_De_Vuelo=@nedv, Nombre_Del_Pasajero=@ndp, Nombre_Del_Aeropuerto=@nda, Pais=@p, Ciudad=@c, Hora_De_Salida=@hds, Fecha=@f, Hora_Del_Despegue=@hdd where Tiempo_Aproximadao_De_Vuelo=@tadv", conexion)
            adaptador.UpdateCommand.Parameters.Add("@nedv", SqlDbType.VarChar, 50).Value = datos.NombreEmpresaDeVuelo
            adaptador.UpdateCommand.Parameters.Add("@ndp", SqlDbType.VarChar, 80).Value = datos.NombreDePasajero
            adaptador.UpdateCommand.Parameters.Add("@nda", SqlDbType.VarChar, 80).Value = datos.NombreDeAeropuerto
            adaptador.UpdateCommand.Parameters.Add("@p", SqlDbType.VarChar, 50).Value = datos.Pais1
            adaptador.UpdateCommand.Parameters.Add("@c", SqlDbType.VarChar, 50).Value = datos.Ciudades
            adaptador.UpdateCommand.Parameters.Add("@hds", SqlDbType.VarChar, 50).Value = datos.HoraDeSalidass
            adaptador.UpdateCommand.Parameters.Add("@f", SqlDbType.VarChar, 60).Value = datos.Fechas
            adaptador.UpdateCommand.Parameters.Add("@hdd", SqlDbType.VarChar, 50).Value = datos.TiempoDeDespegue
            adaptador.UpdateCommand.Parameters.Add("@tadv", SqlDbType.VarChar, 25).Value = datos.TiempoAporoximado
            conexion.Open()
            adaptador.UpdateCommand.Connection = conexion
            adaptador.UpdateCommand.ExecuteNonQuery()
        Catch ex As Exception
            estado = False
        Finally
            Desconectado()
        End Try
        Return estado
    End Function
    Public Function eliminar_Datoss(ByVal datos As Datos) As Boolean
        Dim estado As Boolean = True
        Try
            Conexionn()
            adaptador.DeleteCommand = New SqlCommand("delete from Destino_Internacional where COdRoll=@Cr ", conexion)
            adaptador.DeleteCommand.Parameters.Add("@Cr", SqlDbType.Int).Value = datos.CODROLes
            conexion.Open()
            adaptador.DeleteCommand.Connection = conexion
            adaptador.DeleteCommand.ExecuteNonQuery()
        Catch ex As Exception
            estado = False
        Finally
            Desconectado()
        End Try
        Return estado
    End Function
    'Tabla de Vuelos Nacionales'
    Public Function consultar_vuelosnacionales() As Boolean
        Dim estado As Boolean = True
        Try
            adaptador.SelectCommand = New SqlCommand("select * from Destino_Nacional", cnn)
            adaptador.Fill(tabla)
        Catch ex As SqlException
            estado = False
        Finally
            Desconectado()
        End Try
        Return estado
    End Function
    Public Function insertar_vuelosnacionales(ByVal datos As Datos) As Boolean
        Dim estado As Boolean = True
        Try
            Conexionn()
            adaptador.InsertCommand = New SqlCommand("insert into Destino_Nacional (CodRol, Nombre_Empresa_De_Vuelo, Nombre_Del_Pasajero, Nombre_Del_Aeropuerto, Ciudad, Hora_De_Salida, Fecha, Hora_Del_Despegue) values (@Cd,@NEDV , @NDP , @NDA , @CI, @HDS, @Fecha,@HDD )", conexion)
            adaptador.InsertCommand.Parameters.Add("@Cd", SqlDbType.Int).Value = datos.CodRool
            adaptador.InsertCommand.Parameters.Add("@NEDV", SqlDbType.VarChar, 50).Value = datos.NombreEmpresaDeVueloo
            adaptador.InsertCommand.Parameters.Add("@NDP", SqlDbType.VarChar, 80).Value = datos.Nombredelpasajero
            adaptador.InsertCommand.Parameters.Add("@NDA", SqlDbType.VarChar, 80).Value = datos.NombreDelAeropuertoo
            adaptador.InsertCommand.Parameters.Add("@CI", SqlDbType.VarChar, 50).Value = datos.cciudad
            adaptador.InsertCommand.Parameters.Add("@HDS", SqlDbType.VarChar, 50).Value = datos.horadesalidas
            adaptador.InsertCommand.Parameters.Add("@Fecha", SqlDbType.VarChar, 60).Value = datos.fechass
            adaptador.InsertCommand.Parameters.Add("@HDD", SqlDbType.VarChar, 60).Value = datos.Hora_Del_Despegues
            conexion.Open()
            adaptador.InsertCommand.Connection = conexion
            adaptador.InsertCommand.ExecuteNonQuery()
        Catch ex As Exception
            estado = False
        Finally
            Desconectado()
        End Try
        Return estado
    End Function
    Public Function BORRAR_vuelosnacionales(ByVal datos As Datos) As Boolean
        Dim estado As Boolean = True
        Try
            Conexionn()
            adaptador.DeleteCommand = New SqlCommand("delete from Destino_Nacional where COdRolll=@cd ", conexion)
            adaptador.DeleteCommand.Parameters.Add("@Cd", SqlDbType.Int).Value = datos.CodRooll
           
            conexion.Open()
            adaptador.DeleteCommand.Connection = conexion
            adaptador.DeleteCommand.ExecuteNonQuery()
        Catch ex As Exception
            estado = False
        Finally
            Desconectado()
        End Try
        Return estado
    End Function
    Public Function Actualizar_vuelosnacionales(ByVal datos As Datos) As Boolean
        Dim estado As Boolean = True
        Try
            Conexionn()
            adaptador.UpdateCommand = New SqlCommand("update Destino_Nacional set CodRol=@Cd, Nombre_Empresa_De_Vuelo=@NEDV, Nombre_Del_Pasajero=@NDP, Nombre_Del_Aeropuerto=@NDA, Ciudad=@CI, Hora_De_Salida=@HDS, Fecha=@Fecha, Hora_Del_Despegue=@HDD, Tiempo_Aproximadao_De_Vuelo=@TADV", conexion)
            adaptador.UpdateCommand.Parameters.Add("@Cd", SqlDbType.Int).Value = datos.CodRool
            adaptador.UpdateCommand.Parameters.Add("@NEDV", SqlDbType.VarChar, 50).Value = datos.NombreEmpresaDeVueloo
            adaptador.UpdateCommand.Parameters.Add("@NDP", SqlDbType.VarChar, 80).Value = datos.Nombredelpasajero
            adaptador.UpdateCommand.Parameters.Add("@NDA", SqlDbType.VarChar, 80).Value = datos.NombreDelAeropuertoo
            adaptador.UpdateCommand.Parameters.Add("@CI", SqlDbType.VarChar, 50).Value = datos.cciudad
            adaptador.UpdateCommand.Parameters.Add("@HDS", SqlDbType.VarChar, 50).Value = datos.horadesalidas
            adaptador.UpdateCommand.Parameters.Add("@Fecha", SqlDbType.VarChar, 60).Value = datos.fechass
            adaptador.UpdateCommand.Parameters.Add("@HDD", SqlDbType.VarChar, 60).Value = datos.Hora_Del_Despegues
            adaptador.UpdateCommand.Parameters.Add("@TADV", SqlDbType.VarChar, 60).Value = datos.TiempoAproximadaoDeVuelos
            conexion.Open()
            adaptador.UpdateCommand.Connection = conexion
            adaptador.UpdateCommand.ExecuteNonQuery()
        Catch ex As Exception
            estado = False
        Finally
            Desconectado()
        End Try
        Return estado
    End Function



    Public Shared Function Conectado()
        Try
            cnn = New SqlConnection("Data Source=A411S003;Initial Catalog=volarseguro;Integrated Security=True")
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Shared Function Desconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
