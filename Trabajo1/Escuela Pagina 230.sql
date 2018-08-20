create database EscuelaMatricula;

use EscuelaMatricula;

create table Curso(
	id_curso int primary key identity not null,
	NomCurso varchar(50) not null,
	DuracionMes int ,
	observaciones varchar(100)
);

create table Usuarios(
	id_usuario int primary key identity not null,
	Nombre varchar(50),
	Clave varchar(30),
	Permiso varchar(30)
);

create table DatosP(
	id_datosP int primary key identity not null,
	nombre varchar(100),
	apellido varchar(100),
	edad int,
	sexo bit,
	NomPadre varchar(100),
	NomMadre varchar(100),
	Telefono varchar(30),
	Celular varchar(30),
	Email varchar(30),
	Obseraciones varchar(100)
);


create table Matricula(
	curso int not null,
	alumno int not null,
	fecha_matricula datetime default sysdatetime(),
	año int,
	ObservacionMatricula varchar(200),
	foreign key(curso) references Curso(id_curso),
	foreign key(alumno) references DatosP(id_datosP)
);