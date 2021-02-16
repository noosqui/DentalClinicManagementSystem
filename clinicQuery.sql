

create database clinica
use clinica

select * from empleado 
create table empleado(
id_e varchar(50),
nombre varchar(50),
apellido varchar(50),
telefono bigint,
correo varchar(50),
puesto varchar(30),
genero varchar(20),
contraseña varchar(20),
constraint pk_id primary key(id_e)  
)


create table pacientes(
id_p varchar(50),
nombre varchar(50),
apellido varchar(50),
telefono bigint,
edad int,
genero varchar(20),
constraint pk_idp primary key(id_p)
)



create table tratamiento(
id_t int IDENTITY(1,1) not null,
nombre varchar(50),
precio int,
constraint pk_idt primary key(id_t)
)



create table inventario(
id_material int IDENTITY(1,1) not null,
nombre varchar(50),
cantidad int,
constraint pk_idm primary key(id_material)
)

create table tratamiento_inventario(
id_material1 int,
id_t1 int,
cantidad int,
constraint fk_idm foreign key(id_material1) references inventario(id_material),
constraint fk_idt foreign key(id_t1) references tratamiento(id_t)
)



create table historial(
id_h int IDENTITY(1,1) not null,
id_paciente varchar(50),
fecha date,
id_t2 int,
constraint pk_idh primary key(id_h),
constraint fk_idp foreign key(id_paciente) references pacientes(id_p),
constraint fk_idt2 foreign key(id_t2) references tratamiento(id_t)
)

create table transaccion(
id_trans int IDENTITY(1,1) not null,
tipo_transacción varchar(15),
cantidad int,
fecha date,
dinero_dispobible int,
constraint pk_idtrans primary key(id_trans)
)

-----PROCEDIMIENTOS
-----TABLA EMPLEADOS
create proc IngresoEmpleados
@id varchar(50),
@nombre varchar(50),
@apellido varchar(50),
@telefono bigint,
@correo varchar(50),
@puesto varchar(30),
@genero varchar(20),
@contraseña varchar(20)
as
insert into empleado values(@id,@nombre,@apellido,@telefono,@correo,@puesto,@genero,@contraseña)
go


create proc	empesp
@user varchar(50)
as 
select * from empleado where id_e=@user
go

create proc autent 
@user varchar(50),
@pass varchar(50)
as
select *from empleado where id_e=@user and contraseña=@pass
go

create proc MostrarEmpleados
as
select *from empleado
go

create proc EditarEmpleados
@id varchar(50),
@nombre varchar(50),
@apellido varchar(50),
@telefono bigint,
@correo varchar(50),
@puesto varchar(30),
@genero varchar(20),
@contraseña varchar(20)
as
update empleado set nombre=@nombre,apellido=@apellido,telefono=@telefono,correo=@correo,puesto=@puesto,genero=@genero,contraseña=@contraseña where id_e=@id
go

create proc EliminarEmp
@id varchar(50)
as
delete empleado where id_e=@id
go




----TABLA PACIENTES

create proc IngresoPacientes
@id varchar(50),
@nombre varchar(50),
@apellido varchar(50),
@telefono bigint,
@edad int,
@genero varchar(20)
as
insert into pacientes values(@id,@nombre,@apellido,@telefono,@edad,@genero)
go




create proc Mostrarpacientes
as
select * from pacientes 
go 


create proc Mostrarpac
@id varchar(50)
as
select *from pacientes where id_p=@id
go


create proc EditarPacientes
@id varchar(50),
@nombre varchar(50),
@apellido varchar(50),
@telefono bigint,
@edad int,
@genero varchar(20)
as
update pacientes set nombre=@nombre,apellido=@apellido,telefono=@telefono,edad=@edad,genero=@genero where id_p=@id
go





----TABLA TRATAMIENTO
create proc IngresoTratamiento
@nombre varchar(50),
@precio int
as
insert into tratamiento values(@nombre,@precio)
go

create proc MostrarTratamiento
as
select *from tratamiento
go

create proc mostrarT
@name varchar(50)
as
select *from tratamiento where @name=nombre
go

create proc EditarTratamiento
@nombre varchar(50),
@precio int,
@id int
as
update tratamiento set nombre=@nombre,precio=@precio where id_t=@id
go

-----TABLA INVENTARIO
create proc IngresoMaterial
@nombre varchar(50),
@cantidad int
as
insert into inventario values(@nombre,@cantidad)
go

create proc MostrarInventario
as
select *from inventario
go

create proc EditarInventario
@nombre varchar(50),
@cantidad int,
@id int
as
update inventario set nombre=@nombre,cantidad=@cantidad where id_material=@id
go
 
---------TABLA TRANSACCION
create proc IngresoTransaccion
@tipo varchar(15),
@cantidad int,
@fecha date,
@dd int
as
insert into transaccion values(@tipo,@cantidad,@fecha,@dd)
go



create proc MostrarTransaccion
as
select *from transaccion
go

------TABLA HISTORIAL
create proc IngresoHistorial
@idpaciente varchar(50),
@fecha date,
@idtratamiento int
as
insert into historial values(@idpaciente,@fecha,@idtratamiento)
go

create proc MostrarHistorial
@idpac varchar(50)
as
select id_paciente,tratamiento.nombre,fecha from historial inner join tratamiento on historial.id_t2=tratamiento.id_t where @idpac=id_paciente
go
 



create proc EditarHistorial
@idpaciente bigint,
@fecha date,
@idtratamiento int,
@id int
as
update historial set id_paciente=@idpaciente, id_t2=@idtratamiento, fecha=@fecha where id_h=@id
go

create proc MostrarUso
@id int
as
select tratamiento.nombre,tratamiento.precio,tratamiento_inventario.cantidad from tratamiento_inventario inner join tratamiento on tratamiento_inventario.id_t1=tratamiento.id_t inner join inventario on tratamiento_inventario.id_material1=inventario.id_material where @id=id_material;
go


create proc matnec
@id bigint
as
select inventario.nombre, tratamiento_inventario.cantidad from tratamiento_inventario inner join tratamiento on tratamiento_inventario.id_t1=tratamiento.id_t inner join inventario on tratamiento_inventario.id_material1=inventario.id_material where @id=tratamiento.id_t
go



/*Ingreso de empleados*/
insert into empleado values('050120020224','Nallely','Reyes',98756824,'nalle@gmail.com','Dr','Femenino','123')
insert into empleado values('2020','Javier','Castro',98756845,'Javi@gmail.com','Dr','Masculino','123')
insert into empleado values('2007','Andres','Martinez',98934532,'andres@gmail.com','Dr','Masculino','123')
insert into empleado values ('admin','Admin','Admin',00000000,'admin@admin.com','Admin','Otro','admin')
/*Ingreso de tratamiento*/
insert into tratamiento values('Restauración',500)
insert into tratamiento values('Extracción',300)
insert into tratamiento values('Ortodoncia',1000)



/*Ingreso de material*/

insert into inventario values('Recinas',100)
insert into inventario values('Gazas',80)
insert into inventario values('Anestecia',50)
insert into inventario values('Agujas',100)
insert into inventario values('Brackets',300)
insert into inventario values('Alambre',100)
insert into inventario values('Ules',500)
insert into inventario values('adhesivo',40)
insert into inventario values('Acido',50)



/*Ingreso de relacion tratamiento y material*/


insert into tratamiento_inventario values(1,1,2)
insert into tratamiento_inventario values(2,2,3)

insert into tratamiento_inventario values(4,3,1)
insert into tratamiento_inventario values(5,3,28)
insert into tratamiento_inventario values(6,3,2)
insert into tratamiento_inventario values(7,3,28)
insert into tratamiento_inventario values(8,3,4)
insert into tratamiento_inventario values(9,3,1)
insert into tratamiento_inventario values(3,3,1)
insert into tratamiento_inventario values(3,2,1)
insert into tratamiento_inventario values(3,1,1)
insert into tratamiento_inventario values(4,2,1)
insert into tratamiento_inventario values(4,1,1)

 
create proc actCantidad
@cantidad int,
@mat varchar(50)
as
update inventario set cantidad=cantidad-@cantidad where nombre=@mat
go

create proc derechos
@id varchar(50)
as
update empleado set puesto='Admin' where id_e=@id
go

create proc actmaterial
@material varchar(50),
@cantidad int
as
update inventario set cantidad=@cantidad where nombre=@material
go

