use master
go
create database dbproductos
go
use dbproductos
go
create table categoria(
	idcategoria integer primary key identity,
	nombre varchar(50) not null unique,
	descripcion varchar(255) null,
	estado bit default(1)
);
go

insert into categoria (nombre,descripcion) 
values ('Equipos de sonido','Todos los equipos de sonido');
go

create table producto(
	idproducto integer primary key identity,
	idcategoria integer not null,
	codigo varchar(64) null,
	nombre varchar(100) not null unique,
	precio_venta decimal(11,2) not null,
	stock integer not null,
	descripcion varchar(255) null,
	estado bit default(1),
	FOREIGN KEY (idcategoria) REFERENCES categoria(idcategoria)
);
go
