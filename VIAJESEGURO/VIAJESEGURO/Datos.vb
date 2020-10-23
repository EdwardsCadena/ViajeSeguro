Public Class Datos
    'Tabla de Hoteles Internacionales'
    Private COdRollll As Integer
    Private Nombre_Del_Hotel As String
    Private Nombre_Del_Cliente As String
    Private Direccion_Del_Hotel As String
    Private paises As String
    Private Ciudades As String
    Private Estrellas As Integer
    'Tabla Usuario'
    Private Codusuario As Integer
    Private usuario As String
    Private contraseña As String
    Private rol As Integer
    Private nombre As String
    Private apellido As String
    Private Direccion As String
    'Tabla Vuelos Internacionales'
    Private COdRoll As Integer
    Private Nombre_Empresa_De_Vuelo As String
    Private Nombre_Del_Pasajero As String
    Private Nombre_Del_Aeropuerto As String
    Private Pais As String
    Private Hora_De_Salida As String
    Private Fecha As String
    Private Tiempo_De_Vuelo As String
    Private Tiempo_Del_Despegue As String
    Private Ciudad As String
    Private Tiempo_Aproximadao_De_Vuelo As String
    'Tabla Vuelos Nacionales'
    Private COdRolll As Integer
    Private CodRol As Integer
    Private NombreEmpresaDeVuelos As String
    Private NombreDel_Pasajero As String
    Private NombreDelAeropuerto As String
    Private Ciudadd As String
    Private HoraDeSalida As String
    Private Fechaa As String
    Private Hora_Del_Despegue As String
    Private TiempoAproximadaoDeVuelo As String

    'Tabla Hoteles Internacionales'
    Public Property Codigo() As Integer
        Get
            Return COdRollll
        End Get
        Set(ByVal value As Integer)
            COdRollll = value
        End Set
    End Property
    Public Property NombreDelHotel() As String
        Get
            Return Nombre_Del_Hotel
        End Get
        Set(ByVal value As String)
            Nombre_Del_Hotel = value

        End Set
    End Property
    Public Property NombreDelCliente() As String
        Get
            Return Nombre_Del_Cliente
        End Get
        Set(ByVal value As String)
            Nombre_Del_Cliente = value

        End Set
    End Property
    Public Property DireccionDelHotel() As String
        Get
            Return Direccion_Del_Hotel
        End Get
        Set(ByVal value As String)
            Direccion_Del_Hotel = value

        End Set
    End Property
    Public Property Paiss() As String
        Get
            Return paises
        End Get
        Set(ByVal value As String)
            paises = value

        End Set
    End Property
    Public Property Ciudaddd() As String
        Get
            Return Ciudades
        End Get

        Set(ByVal value As String)
            Ciudades = value

        End Set
    End Property
    Public Property Estrellass() As Integer
        Get
            Return Estrellas
        End Get
        Set(ByVal value As Integer)
            Estrellas = value
        End Set
    End Property
    'Tabla Vuelos Nacionales'
    Public Property CodRooll() As Integer
        Get
            Return COdRolll
        End Get
        Set(ByVal value As Integer)
            COdRolll = value
        End Set
    End Property

    Public Property CodRool() As Integer
        Get
            Return CodRol
        End Get
        Set(ByVal value As Integer)
            CodRol = value
        End Set
    End Property
    Public Property NombreEmpresaDeVueloo() As String
        Get
            Return NombreEmpresaDeVuelos
        End Get
        Set(ByVal value As String)
            NombreEmpresaDeVuelos = value

        End Set
    End Property
    Public Property Nombredelpasajero() As String
        Get
            Return NombreDel_Pasajero
        End Get
        Set(ByVal value As String)
            NombreDel_Pasajero = value

        End Set
    End Property
    Public Property NombreDelAeropuertoo() As String
        Get
            Return NombreDelAeropuerto
        End Get
        Set(ByVal value As String)
            NombreDelAeropuerto = value

        End Set
    End Property
    Public Property cciudad() As String
        Get
            Return Ciudadd
        End Get
        Set(ByVal value As String)
            Ciudadd = value

        End Set
    End Property
    Public Property horadesalidas() As String
        Get
            Return HoraDeSalida
        End Get
        Set(ByVal value As String)
            HoraDeSalida = value

        End Set
    End Property
    Public Property fechass() As String
        Get
            Return Fechaa
        End Get
        Set(ByVal value As String)
            Fechaa = value

        End Set
    End Property
    Public Property Hora_Del_Despegues() As String
        Get
            Return Hora_Del_Despegue
        End Get
        Set(ByVal value As String)
            Hora_Del_Despegue = value

        End Set
    End Property
    Public Property TiempoAproximadaoDeVuelos() As String
        Get
            Return TiempoAproximadaoDeVuelo
        End Get
        Set(ByVal value As String)
            TiempoAproximadaoDeVuelo = value

        End Set
    End Property


    'Tabla Vuelos Internacionales'
    Public Property CODROLes() As Integer
        Get
            Return CODROLl
        End Get
        Set(ByVal value As Integer)
            COdRoll = value
        End Set
    End Property
    Public Property NombreEmpresaDeVuelo() As String
        Get
            Return Nombre_Empresa_De_Vuelo
        End Get
        Set(ByVal value As String)
            Nombre_Empresa_De_Vuelo = value

        End Set
    End Property
    Public Property NombreDePasajero() As String
        Get
            Return Nombre_Del_Pasajero
        End Get
        Set(ByVal value As String)
            Nombre_Del_Pasajero = value

        End Set
    End Property
    Public Property NombreDeAeropuerto() As String
        Get
            Return Nombre_Del_Aeropuerto
        End Get
        Set(ByVal value As String)
            Nombre_Del_Aeropuerto = value

        End Set
    End Property
    Public Property Pais1() As String
        Get
            Return Pais
        End Get
        Set(ByVal value As String)
            Pais = value

        End Set
    End Property
    Public Property HoraDeSalidass() As String
        Get
            Return Hora_De_Salida
        End Get
        Set(ByVal value As String)
            Hora_De_Salida = value

        End Set
    End Property
    Public Property Fechas() As String
        Get
            Return Fecha
        End Get
        Set(ByVal value As String)
            Fecha = value

        End Set
    End Property
    Public Property TiempoDevuelo() As Integer
        Get
            Return Tiempo_De_Vuelo
        End Get
        Set(ByVal value As Integer)
            Tiempo_De_Vuelo = value
        End Set
    End Property
    Public Property TiempoDeDespegue() As String
        Get
            Return Tiempo_Del_Despegue
        End Get
        Set(ByVal value As String)
            Tiempo_Del_Despegue = value

        End Set
    End Property
    Public Property Ciudadess() As String
        Get
            Return Ciudad
        End Get
        Set(ByVal value As String)
            Ciudad = value

        End Set
    End Property
    Public Property TiempoAporoximado() As String
        Get
            Return Tiempo_Aproximadao_De_Vuelo
        End Get
        Set(ByVal value As String)
            Tiempo_Aproximadao_De_Vuelo = value

        End Set
    End Property

    'Tabla Usuario'

    Public Property nombres() As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value

        End Set
    End Property
    Public Property apellidos() As String
        Get
            Return apellido
        End Get
        Set(ByVal value As String)
            apellido = value

        End Set
    End Property
    Public Property direcionn() As String
        Get
            Return Direccion
        End Get
        Set(ByVal value As String)
            Direccion = value

        End Set
    End Property
    Public Property nomusuario() As String
        Get
            Return usuario
        End Get
        Set(ByVal value As String)
            usuario = value

        End Set
    End Property
    Public Property pass() As String
        Get
            Return contraseña
        End Get
        Set(ByVal value As String)
            contraseña = value
        End Set
    End Property
    Public Property rolusuario() As Integer
        Get
            Return rol
        End Get
        Set(ByVal value As Integer)
            rol = value
        End Set
    End Property
    Public Property coddroll() As Integer
        Get
            Return Codusuario
        End Get
        Set(ByVal value As Integer)
            Codusuario = value
        End Set
    End Property


    Public Sub New(ByVal usuaio As String, ByVal pasword As String, ByVal rol As String)
        'Tabla Hoteles Internacionales'
        Codigo = COdRollll
        NombreDelHotel = Nombre_Del_Hotel
        NombreDelCliente = Nombre_Del_Cliente
        Nombre_Del_Hotel = Nombre_Del_Hotel
        Paiss = paises
        Ciudaddd = Ciudades
        Estrellass = Estrellas

        'Tabla Usuario'
        usuario = nomusuario
        contraseña = pass
        rolusuario = rol
        Direccion = Direccion
        nombre = nombre
        apellidos = apellido

        'Tabla De Vuelos Internacionales'
        CODROL = COdRoll
        NombreEmpresaDeVuelo = Nombre_Empresa_De_Vuelo
        NombreDePasajero = Nombre_Del_Pasajero
        NombreDeAeropuerto = Nombre_Del_Aeropuerto
        Pais1 = Pais
        HoraDeSalida = Hora_De_Salida
        Fechas = Fecha
        TiempoDevuelo = Tiempo_De_Vuelo
        TiempoDeDespegue = Tiempo_Del_Despegue
        Ciudades = Ciudad
        TiempoAporoximado = Tiempo_Aproximadao_De_Vuelo


    End Sub
    Public Sub New()

    End Sub
End Class
