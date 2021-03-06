create database Formulario

use Formulario

create table tb_persona(
	id int identity not null primary key,
	primer_nombre nvarchar(100) not null,
	segundo_nombre nvarchar(100) null,
	primer_apellido nvarchar(100) not null,
	segundo_apellido nvarchar(100) null,
	correo nvarchar(100) not null,
	direccion nvarchar(100) not null, 
	celular nvarchar (20) not null,

)

create table tb_empresa(
	id int identity not null primary key,
	nombre nvarchar(100) not null,
	nit nvarchar(100) null,
	correo nvarchar(100) not null,
	direccion nvarchar(100) not null, 
	celular nvarchar (20) not null,
)

create table tb_formulario(
	id int identity not null primary key,
	especialidad nvarchar(100) not null,
	a?os_experiencia nvarchar(10) null,
	salario nvarchar(100) not null,
	fecha_envio datetime not null,
	correo nvarchar(100) not null,
	direccion nvarchar(100) not null, 
	celular nvarchar (20) not null,
	empresa_id int null,
	foreign Key (empresa_id) references tb_empresa,
	persona_id int null,
	foreign Key (persona_id) references tb_persona,
)
