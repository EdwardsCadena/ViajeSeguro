create database volarseguro
use volarseguro 
create table rol
(
CodRol int identity primary key,
TipoRol varchar (30)
)
insert into rol (TipoRol) values ('Administrador')
insert into rol (TipoRol) values ('cliente')
insert into rol (TipoRol) values ('trabajador')
select * from rol 
create table usuario
(
Codusuario int identity primary key,
CodRol int,
Nombres varchar (50),
Apellidos varchar (50),
Direccion varchar (50),
usuario varchar (40),
contraseña varchar (30)
)
insert into usuario (CodRol,Nombres,Apellidos,Direccion,usuario,contraseña)
values ('1','Edwrad','Cadena','Avenida carrera 30 sur # 30-23','Ases','1996')
insert into usuario (CodRol,Nombres,Apellidos,Direccion,usuario,contraseña)
values ('2','Felipe','Uribe','cll 48 r sur n° 5j 41 apto 202','Fel','456')
insert into usuario (CodRol,Nombres,Apellidos,Direccion,usuario,contraseña)
values ('3','Leandro','Diaz','cr 93 d # 71-49 sur','Lean','456')
select * from usuario
drop table usuario

create table cliente
(
Cod         varchar (50),
C_C         varchar (20), 
Nombre      varchar (30), 
Apellidos   varchar (40),
Direccion   varchar (30), 
Telefeno    varchar (20), 
Usuario     varchar (40), 
Contraseña  varchar (30), 
Reservacion varchar (60) 
)
create table Administrador
(
Nombre     varchar (20), 
C_C        varchar (20), 
Telefeno   varchar (30), 
Usuario    varchar (30), 
Contraseña varchar (40) 
)
create table trabajador
(
COd        varchar (30), 
Nombre     varchar (40), 
Apellido   varchar (30), 
C_C        varchar (30), 
Telefeno   varchar (20),
Usuario    varchar (40), 
Contraseña varchar (30)
)
create table Destino_Internacional
(
COdRoll   int identity primary key,
Nombre_Empresa_De_Vuelo varchar(50),
Nombre_Del_Pasajero varchar(80),
Nombre_Del_Aeropuerto varchar (80),
Pais varchar(50),
Ciudad varchar (50),
Hora_De_Salida varchar (50),
Fecha varchar (60),
Hora_Del_Despegue varchar (50),
Tiempo_Aproximadao_De_Vuelo varchar (25)
)
insert into Destino_Internacional (Nombre_Empresa_De_Vuelo, Nombre_Del_Pasajero, Nombre_Del_Aeropuerto, Pais, Ciudad, Hora_De_Salida, Fecha, Hora_Del_Despegue, Tiempo_Aproximadao_De_Vuelo) 
values ( 'Avianca', 'Felipe', 'El Dorado', 'Italia', 'Roma', '02:30', '27/45/16', '02:30', '06:00') 

select * from Destino_Internacional
create table Destino_Nacional 
(
COdRolll   int identity primary key,
CodRol int , 
Nombre_Empresa_De_Vuelo varchar (50),
Nombre_Del_Pasajero varchar(80),
Nombre_Del_Aeropuerto varchar (80),
Ciudad varchar(50),
Hora_De_Salida VARCHAR (30) ,
Fecha varchar (60),
Hora_Del_Despegue VARCHAR (50),
Tiempo_Aproximadao_De_Vuelo VARCHAR (30)
)
insert into Destino_Nacional (CodRol, Nombre_Empresa_De_Vuelo, Nombre_Del_Pasajero, Nombre_Del_Aeropuerto, Ciudad, Hora_De_Salida, Fecha, Hora_Del_Despegue, Tiempo_Aproximadao_De_Vuelo) 
values ('1','Avianca','Brandon','Rafael Nuñez','Cartagena','23:30','18/SEPT/13','23:15','24:00')
drop table Destino_Nacional
select * from Destino_Nacional
create table Hoteles_Nacionales
(
COdRoll   int identity primary key,
Nombre_Del_Hotel varchar (80), 
Nombre_Del_Cliente varchar (80),
Direccion_Del_Hotel  varchar (80), 
Ciudad varchar (50),
Estrellas int
)
select * from Hoteles_Nacionales
create table Hoteles_Internacinales
(
COdRoll   int identity primary key,
Nombre_Del_Hotel varchar (80), 
Nombre_Del_Cliente varchar (80),
Direccion_Del_Hotel  varchar (80), 
pais varchar (50),
Ciudad    varchar (50),
Estrellas int
)
select * from Hoteles_Internacinales
go
CREATE PROCEDURE validar
@log varchar (40),
@pas varchar (50),
@rol int
as 
select * from usuario
where usuario = @log and contraseña = @pas and CodRol = @rol 
go



