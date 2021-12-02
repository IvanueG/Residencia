Create Database Señales_Mioelectricas
use Señales_Mioelectricas

create table Usuario(
ID_User int primary key identity(1,1),
Usuario varchar(20),
Contraseña varchar(10))

create table Medico(
ID_Medico int primary key identity(1,1),
Nombre varchar(15),
Apellido_Paterno varchar(20),
Apellido_Materno varchar(20),
ID_User int foreign key references Usuario(ID_User))


create table Paciente(
ID_Paciente int primary key identity(1,1),
Nombre varchar(15),
Apellido_Paterno varchar(20),
Apellido_Materno varchar(20),
Sexo varchar(6),
ID_Medico int foreign key references Medico(ID_Medico))

create table documentos(
ID_Documento int primary key identity(1,1),
Nombre_Documento varchar(100),
Nombre_Real varchar(100),
Doc varbinary(max),
ID_Paciente int foreign key references Paciente(ID_Paciente))


insert into Usuario values('Ivanue','1234')
insert into Medico values('Ivanue','Garcia','Ramirez',1)

Select*From Paciente
Select*From Usuario
Select*From Medico