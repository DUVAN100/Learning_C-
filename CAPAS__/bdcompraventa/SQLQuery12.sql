create database compraventa
use compraventa
--instructivo para crear las tablas


--vamos a crear una tabla con clave foranea
create table  factura (
nro_factura int primary key,
fecha_factura date,
)

create table producto (
cod_producto int primary key,
descr_producto varchar (60),
valor_producto money,
cantidad int)
----procedimiento almacenado guardar cita
-------------------------------------------------------------------
create table categoria(
cod_categoria int  primary key,
categoria varchar(60)
)
create procedure guardar_categoria
@cod_categoria varchar(20),
@categoria varchar(20)
as insert into categoria(cod_categoria,categoria) values(@cod_categoria,@categoria)
----actualizar
create procedure actualizar_categoria
@cod_categoria varchar(10),
@categoria varchar(10)
as update categoria set cod_categoria=@cod_categoria, categoria=@categoria where cod_categoria=@cod_categoria
--eliminar 
create procedure eliminar_categoria
@cod_categoria varchar(20)
as delete categoria where cod_categoria= @cod_categoria
--consultar
create procedure consultar_cita
@cod_categoria varchar(10)
as select*from categoria where cod_categoria=@cod_categoria
-------------------------------------------------------------------------------
create table cliente (
ref_cliente int primary key, 
nom_cliente varchar(60),
dir_cliente varchar(60),
tell_cliente varchar(20))
------guardar

create procedure guardar_cliente
@ref_cliente int ,  
@nom_cliente varchar(20),
@dir_cliente varchar(20),
@tell_cliente varchar(20)
as insert into cla