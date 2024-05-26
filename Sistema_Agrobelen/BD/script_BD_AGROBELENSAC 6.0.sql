create database BD_AgrobelenSAC
go

use BD_AgrobelenSAC
go

--Creacion de Tablas

create table Almacen(
idAlmacen int identity(1,1) primary key,
sucursal varchar(50) not null,
descripcion varchar(50) not null
);
go

create table Categoria_Producto(
idCategoria int identity(1,1) primary key,
descripcion varchar(50) not null
);
go

create table Proveedor(
idProveedor varchar(11) primary key,
nombre varchar(50) not null,
tipoDocumento varchar(20) not null,
direccion varchar(50) not null,
correo varchar(50),
telefono nchar(9),
estado varchar(20) not null
);
go

create table Producto(
idProducto int identity(1,1) primary key,
nombre varchar(50) not null,
estado varchar(20) not null,
precio float not null,
costo float not null,
idCategoria int,
idProveedor varchar(11)
);
go

create table Cliente(
idCliente varchar(11) primary key,
nombre varchar(50) not null,
apPaterno varchar(50) not null,
apMaterno varchar(50) not null,
telefono nchar(9),
correo varchar(50),
direccion varchar(50) not null,
tipodocumento varchar(20) not null);
go

create table Categoria_Usuario(
idCategoriaUsuario int identity(1,1) primary key,
descripcion varchar(50) not null
);
go

create table Empleado(
idEmpleado nchar(10) primary key,
nombres varchar(50) not null,
apPaterno varchar(50) not null,
apMaterno varchar(50) not null,
fechaIngreso date not null,
sueldo float not null, 
);
go

create table Usuario(
idEmpleado nchar(10),
idUsuario varchar(100),
clave varchar(20) not null,
idCategoriaUsuario int not null,
estado varchar(20) not null,
primary key(idEmpleado, idUsuario)
);
go

create table Compra(
idCompra int identity(1,1) primary key,
fecha date not null,
formaPago varchar(50) not null,
total float not null,
igv float not null,
numCompra varchar(4) not null,
serieCompra varchar(8) not null,
subtotal float not null,
tipoComprobante varchar(50) not null,
diasCredito int not null,
fechaPago date,
idProveedor varchar(11),
idEmpleado nchar(10),
idUsuario varchar(100)
);
go

create table Detalle_Compra(
idDetalleCompra int identity(1,1) primary key,
cantidad int not null,
subtotal float not null,
idProducto int,
idCompra int
);
go

create table Venta(
idVenta int identity(1,1) primary key,
fecha date not null,
formaPago varchar(50) not null,
subtotal float not null,
igv float not null,
total float not null,
estado varchar(20) not null,
diasCredito int not null,
fechaPago date,
idCliente varchar(11),
idEmpleado nchar(10));
go

create table Detalle_Venta(
idDetalleVenta int identity(1,1) primary key,
cantidad int not null,
subtotal float not null,
idVenta int,
idProducto int);

create table Comprobante(
idVenta int primary key,
numComprobante varchar(8) not null,
tipoComprobante varchar(50),
numTalonario int);
go

create table Kardex(
idKardex int identity(1,1) primary key,
fecha date,
tipoMovimiento varchar(20) not null,
descripcion varchar(50),
sucursalRef varchar(50),
stockRef float not null,
docReferencia varchar(50),
precioRef float not null,
responsable varchar(50),
destino varchar(50),
idProducto int,
idAlmacen int);
go

create table Inventario(
idProducto int,
idAlmacen int,
stockMinimo int not null,
stockMaximo int not null,
stockReal int not null,
primary key(idProducto, idAlmacen)
);
go

create table Talonario(
numTalonario int identity(1,1) primary key,
tipoTalonario varchar(20),
serieTalonario nchar(8));
go

--Creacion FK
alter table Venta
add constraint fk_idCliente
foreign key(idCliente)
references Cliente(idCliente);
go

alter table Venta
add constraint fk_idEmpleado
foreign key(idEmpleado)
references Empleado(idEmpleado);
go 
--LOOK UP
alter table Detalle_Venta
add constraint fk_idVenta
foreign key(idVenta)
references Venta(idVenta);
go

alter table Detalle_Venta
add constraint fk_idProducto
foreign key(idProducto)
references Producto(idProducto);
go

alter table Comprobante
add constraint fk_idVentaComprobante
foreign key(idVenta)
references Venta(idVenta);
go


alter table Comprobante
add constraint fk_numTalonario
foreign key(numTalonario)
references Talonario(numTalonario);
go



alter table Kardex
add constraint fk_idProductokardex
foreign key(idProducto)
references Producto(idProducto);
go


alter table Kardex
add constraint fk_idAlmacen
foreign key(idAlmacen)
references Almacen(idAlmacen);
go

alter table Usuario
add constraint fk_CategoriaUsuario
foreign key(idCategoriaUsuario)
references Categoria_Usuario(idCategoriaUsuario);
go

alter table Usuario
add constraint fk_EmpleadoUsuario
foreign key(idEmpleado)
references Empleado(idEmpleado);
go

alter table Inventario
add constraint fk_ProductoInventario
foreign key(idProducto)
references Producto(idProducto);
go

alter table Inventario
add constraint fk_AlmacenInventario
foreign key(idAlmacen)
references Almacen(idAlmacen);
go

alter table Compra
add constraint fk_ProveedorCompra
foreign key(idProveedor)
references Proveedor(idProveedor);
go

alter table Compra
add constraint fk_EmpleadoCompra
foreign key(idEmpleado, idUsuario)
references Usuario(idEmpleado, idUsuario);
go

alter table Producto
add constraint fk_CategoriaProducto
foreign key(idCategoria)
references Categoria_Producto(idCategoria);
go

alter table Producto
add constraint fk_Proveedor
foreign key(idProveedor)
references Proveedor(idProveedor);
go

alter table Detalle_Compra
add constraint fk_ProductoDetalle
foreign key(idProducto)
references Producto(idProducto);
go

alter table Detalle_Compra
add constraint fk_CompraDetalle
foreign key(idCompra)
references Compra(idCompra);
go

--Ingreso de datos

--ALMACEN
insert into Almacen values ('Reque','Av. La Merced N° 633');
insert into Almacen values ('Monsefu','Jiron Guzman Barrón');
insert into Almacen values ('Callanca','Jirón Santa N° 8');
insert into Almacen values ('Jayanca','Plaza Bolívar - Mercado de Abastos');
insert into Almacen values ('Chiclayo','Av. Luis Gonzales');
insert into Almacen values ('Tuman','Calle Rivero N° 107');
insert into Almacen values ('Eten','Av. Sebastián Barranca N° 1100');
insert into Almacen values ('Pomalca','Jirón Pachacútec N° 118');
insert into Almacen values ('Chongoyape','Calle 7 de Junio N° 641');
insert into Almacen values ('Patapo','Av. Riva Agüero N° 1358');
--PROVEEDOR
insert into Proveedor values ('P-0001','Marcos','DNI','Jacarandas 245','MarcTel64@gmail.com','644834557','Activo');
insert into Proveedor values ('P-0002','Pedro','Pasaporte','Olivos 123','PedCor@gmail.com','184091155','Activo');
insert into Proveedor values ('P-0003','Juan','DNI','Celada 189','JDLi41@gmail.com','690537835','Activo');
insert into Proveedor values ('P-0004','Lucas','Pasaporte','Teatro 685','LuBor97@gmail.com','364946713','Activo');
insert into Proveedor values ('P-0005','Mateo','DNI','Gwandong 749','MatOl@gmail.com','35441523','No activo');
insert into Proveedor values ('P-0006','Maria','Pasaporte','Park Twane 486','MarTe15@gmail.com','611204552','Activo');
insert into Proveedor values ('P-0007','Ana','DNI','Rough 345','AVert18@gmail.com','119539748','Activo');
insert into Proveedor values ('P-0008','Lucia','Pasaporte','Plantec 581','LuCu@gmail.com','900592600','No activo');
insert into Proveedor values ('P-0009','Carla','DNI','Suttern 648','CMart@gmail.com','632836240','Activo');
insert into Proveedor values ('P-0010','Marta','Pasaporte','Locudea 951','MaGo48@gmail.com','362984752','Activo');
--CATEGORIA_PRODUCTO
insert into Categoria_Producto values ('Herbicidas');
insert into Categoria_Producto values ('Fungicidas');
insert into Categoria_Producto values ('Insecticidas');
insert into Categoria_Producto values ('Acaricidas');
insert into Categoria_Producto values ('Nematicidas');
insert into Categoria_Producto values ('Rodenticidas');
insert into Categoria_Producto values ('Fertilizantes');
insert into Categoria_Producto values ('Fitorreguladores');
insert into Categoria_Producto values ('Semillas');
insert into Categoria_Producto values ('Potenciadores');
--PRODUCTO
insert into Producto values ('Atrazina','Activo',25,100,1,'P-0004');
insert into Producto values ('Fitoklin','Activo',40,80,2,'P-0004');
insert into Producto values ('DDT','Activo',26,52,3,'P-0004');
insert into Producto values ('Kenyo','Activo',58,58,4,'P-0004');
insert into Producto values ('Tervigo','Activo',14,42,5,'P-0004');
insert into Producto values ('Nogat','Activo',23,46,6,'P-0004');
insert into Producto values ('Cloruro Potasico','Activo',74,74,7,'P-0004');
insert into Producto values ('etileno','Activo',34,68,8,'P-0004');
insert into Producto values ('Semillas de amapola','Inactivo',61,122,9,'P-0004');
insert into Producto values ('Epimedium','Inactivo',42,126,10,'P-0004');

--INVENTARIO
insert into Inventario values (1,5,20,100,80)
insert into Inventario values (2,2,10,90,95)
insert into Inventario values (2,5,50,200,70)
insert into Inventario values (3,1,10,100,76)
insert into Inventario values (3,5,50,200,189)
insert into Inventario values (3,7,10,80,45)
insert into Inventario values (4,1,25,150,90)
insert into Inventario values (5,8,30,300,270)
insert into Inventario values (7,1,70,200,180)
insert into Inventario values (10,9,30,300,325)


--CLIENTE
insert into Cliente values ('75159342','Marcos','Zapata','Medina','937312401','MzapataM@gmail.com','Jiron Viña KM5','DNI');
insert into Cliente values ('74153265','Yessenia','Vasquez','Silva','93138270','yvasquezs@gmail.com','Pasaje Peñalon','DNI');
insert into Cliente values ('17440213','Angel','Santamaria','Herrera','994497261','Angel11@gmail.com','La Araucania 251','DNI');
insert into Cliente values ('1014852367','Piero','Salazar','Calle',	'929731221','Pieromental@gmail.com','Peñalon 521',	'RUC');
insert into Cliente values ('14756584','Paola','Vidarte','Vidaurre','915024820','MSaral@gmail.com','Tarapacá 219','DNI');
insert into Cliente values ('2015478236','Heidy','Campos','Requejo','914252164','Fabiolac5@gmail.com','Cercado de Lima 452','RUC ');
insert into Cliente values ('85421756','Janira','Vasquez','Campos',	'970128456','JaniraC08@gmail.com','Texas 235','DNI');
insert into Cliente values ('85426482','Jordy','Vasquez','Martinez','900592600','J060901@gmail.com','Pucon 411','DNI');
insert into Cliente values ('20154781234','Carla','Mejia','Muñoz','910420021','CMejia@gmail.com','Los lagos 645','RUC ');
insert into Cliente values ('145201254','Ronaldo','Vertiz','Estevez','971524605','VRonaldo0@gmail.com','Vitacora 112','DNI');




--CATEGORIA DE USUARIO
insert into Categoria_Usuario values ('Administrador');
insert into Categoria_Usuario values ('Empleado');
insert into Categoria_Usuario values ('Gerente');
insert into Categoria_Usuario values ('Programador');
insert into Categoria_Usuario values ('Usuario directo');



--EMPLEADO
insert into Empleado values ('12498537','Soafia','Slazar','Martinez','02/11/2019',930);
insert into Empleado values ('14587392','Danuska','Vasquez','Silva','03/12/2020',930);
insert into Empleado values ('75984684','Maria','Santamaria','Peña','03/11/2020', 930);
insert into Empleado values ('85743215','Omar','Herrera','Santamaria','08/10/2021',930);
insert into Empleado values ('85216479','Kevin','Silva','Calle','08/02/2021',930);
insert into Empleado values ('76498216'	,'Miguel','Requejo','Vidaurre','08/12/2021',930);
insert into Empleado values ('17842659','Brayan','Vasquez'	,'Campos',	'09/10/2021',930);
insert into Empleado values ('15487964'	,'Junior','Estevez','Martinez','09/03/2021',930);
insert into Empleado values ('13498572','Marlita','Herrera','Muñoz','09/04/2021',930);
insert into Empleado values ('13548927','Milagros','Campos','Estevez','09/05/2021',930);

--USARIO
insert into Usuario values ('12498537','U-0001','Marco147*',1,'Activo');
insert into Usuario values ('14587392','U-0002','Silva123',2,'Activo');
insert into Usuario values ('75984684','U-0003','14578A',3,'Activo');
insert into Usuario values ('85743215','U-0004','145Piero',2,'No Activo');
insert into Usuario values ('85216479','U-0005','Sofia1045',5,'Activo');
insert into Usuario values ('76498216','U-0006','Requejo',2,'Activo');
insert into Usuario values ('17842659','U-0007','14587JN',2,'Activo');
insert into Usuario values ('15487964','U-0008','145*AS5',2,'No Activo');
insert into Usuario values ('13498572','U-0009','154887*',1,'Activo');
insert into Usuario values ('13548927','U-0010','A5a4a54',3,'Activo');

--TALONARIO
insert into Talonario values ('facturas','S001');
insert into Talonario values ('cheques','S002');
insert into Talonario values ('recibos','S003');
insert into Talonario values ('facturas','S004');
insert into Talonario values ('facturas','S005');
insert into Talonario values ('cheques','S006');
insert into Talonario values ('recibos','S007');
insert into Talonario values ('recibos','S008');
insert into Talonario values ('cheques','S009');
insert into Talonario values ('cheques','S010');


--
--VENTA
insert into Venta values ('06/02/2021','CONTADO',50.85,9.15,60,'VIGENTE',0,'06/02/2021','75159342','85743215');
insert into Venta values ('06/03/2021','CONTADO',33.9,6.1,40,'VIGENTE',0,'06/03/2021','74153265','85216479');
insert into Venta values ('06/03/2021','CONTADO',33.9,6.1,40,'VIGENTE',0,'06/03/2021','17440213','76498216');
insert into Venta values ('06/04/2021','CONTADO',16.95,3.05,20,'VIGENTE',0,'06/04/2021','1014852367','17842659');
insert into Venta values ('06/04/2021','CONTADO',88.14,15.86,104,'VIGENTE',0,'06/04/2021','17440213','15487964');
insert into Venta values ('06/04/2021','CONTADO',67.8,12.2,80,'VIGENTE',0,'06/04/2021','1014852367','76498216');
insert into Venta values ('09/07/2021','CREDITO',76.27,13.73,90,'ANULADA',5,'09/12/2021','14756584','17842659');
insert into Venta values ('09/08/2021','CREDITO',59.32,20.68,80,'ANULADA',8,'09/10/2021','2015478236','15487964');
insert into Venta values ('09/09/2021','CREDITO',21.18,3.82,25,'VIGENTE',50,'10/05/2021','85421756','13498572');
insert into Venta values ('09/10/2021','CREDITO',101.7,18.3,120,'VIGENTE',15,'09/12/2021','85426482','13548927');

--DETALLE VENTA
insert into Detalle_Venta values (3,30,1,1);
insert into Detalle_Venta values (2,30,1,3);
insert into Detalle_Venta values (2,10,2,4);
insert into Detalle_Venta values (1,10,2,1);
insert into Detalle_Venta values (4,20,2,2);
insert into Detalle_Venta values (8,40,3,2);
insert into Detalle_Venta values (5,20,4,7);
insert into Detalle_Venta values (10,100,5,1);
insert into Detalle_Venta values (1,4,5,9);
insert into Detalle_Venta values (1,25,9,10);
--COMPROBANTE
insert into Comprobante values (1,'00000001','BV|BOLETA DE VENTA',1);
insert into Comprobante values (2,'00000002','BV|BOLETA DE VENTA',1);
insert into Comprobante values (3,'00000003','BV|BOLETA DE VENTA',1);
insert into Comprobante values (4,'00000004','BV|BOLETA DE VENTA',1);
insert into Comprobante values (5,'00000005','BV|BOLETA DE VENTA',1);
insert into Comprobante values (6,'00000006','BV|BOLETA DE VENTA',1);
insert into Comprobante values (7,'00000007','TK|TICKET DE VENTA',2);
insert into Comprobante values (8,'00000008','TK|TICKET DE VENTA',2);
insert into Comprobante values (9,'00000009','FT| FACTURA DE VENTA',3);
insert into Comprobante values (10,'00000010','FT| FACTURA DE VENTA',3);
--

--COMPRA

insert into Compra values ('05/10/2021','CREDITO',1725,263.14,'1111','0001',1461.86,'BOLETA',60,'07/10/2021','P-0001','12498537','U-0001');
insert into Compra values ('05/08/2021','CONTADO',300,45.76,'1234','0002',254.24,'BOLETA',0,'05/08/2021','P-0002','14587392','U-0002')
insert into Compra values ('05/09/2021','CONTADO',400,61.02,'5678','0003',338.98,'BOLETA',00,'05/09/2021','P-0002','75984684','U-0003')
insert into Compra values ('05/12/2021','CREDITO',450.5,68.72,'9453','0004',381.78,'FACTURA',30,'06/12/2021','P-0002','85743215','U-0004')
insert into Compra values ('05/05/2021','CONTADO',125,19.07,'1276','0005',105.93,'BOLETA',30,'05/05/2021','P-0003','85216479','U-0005')
insert into Compra values ('05/10/2021','CONTADO',100,15.25,'1789','0006',84.75,'FACTURA',0,'05/10/2021','P-0004','76498216','U-0006')
insert into Compra values ('05/11/2021','CONTADO',97,14.28,'8756','0007',82.92,'BOLETA',90,'05/11/2021','P-0004','17842659','U-0007')
insert into Compra values ('05/12/2021','CONTADO',850,129.66,'4547','0008',720.34,'BOLETA',0,'05/12/2021','P-0005','15487964','U-0008')
insert into Compra values ('05/06/2021','CONTADO',200,30.51,'9999','0009',169.49,'FACTURA',45,'05/06/2021','P-0005','13498572','U-0009')
insert into Compra values ('05/07/2021','CONTADO',300,45.76,'2222','0010',254.24,'FACTURA',0,'05/07/2021','P-0008','13548927','U-0010')

--DETALLE_COMPRA
insert into Detalle_Compra values (20,120,1,1);
insert into Detalle_Compra values (15,180,1,1);
insert into Detalle_Compra values (34,578,4,2);
insert into Detalle_Compra values (50,500,3,2);
insert into Detalle_Compra values (3,540,2,2);
insert into Detalle_Compra values (78,390,7,3);
insert into Detalle_Compra values (10,700,2,3);
insert into Detalle_Compra values (20,1400,10,3);
insert into Detalle_Compra values (16,240,4,4);
insert into Detalle_Compra values (14,1092,8,4);

--KARDEX
insert into Kardex values ('06/02/2021','ENTRADA','COMPRA','REQUE',5,'112345678',20,'Angel Santamaria Herrera','REQUE',1,1);
insert into Kardex values ('06/02/2021','SALIDA','VENTA','REQUE',2,'B00100000001',10,'Angel Santamaria Herrera','FABIANA SALAZAR CALLE',1,1);
insert into Kardex values ('06/03/2021','SALIDA','VENTA','REQUE',0,'B00100000002',40,'Angel Santamaria Herrera','ANGELINA SALAZAR CALLE',1,1);
insert into Kardex values ('06/03/2021','ENTRADA','COMPRA','REQUE',3,'1123456342',20,'Angel Santamaria Herrera','REQUE',1,1);
insert into Kardex values ('06/03/2021','SALIDA','VENTA','REQUE',1,'B00100000003',40,'Angel Santamaria Herrera','ANGELINA SALAZAR CALLE',1,1);
insert into Kardex values ('06/04/2021','SALIDA','VENTA','REQUE',0,'B00100000004',40,'Angel Santamaria Herrera','ANGELINA SALAZAR CALLE',1,1);
insert into Kardex values ('06/04/2021','ENTRADA','POR MERCADERIA','REQUE',4,'12464523',0,'Piero Salazar Calle','CLIENTES VARIOS',2,1);
insert into Kardex values ('06/04/2021','ENTRADA','POR JUSTO','CALLANCA',5,'TK-1234548',20,'YESSENIA LISETH VASQUEZ SILVA','OYOTUN',1,2);
insert into Kardex values ('06/04/2021','ENTRADA','COMPRA','REQUE',10,'1312356',25,'Angel Santamaria Herrera','REQUE',1,1);
insert into Kardex values ('06/04/2021','ENTRADA','COMPRA','REQUE',44,'11234367',2,'Angel Santamaria Herrera','REQUE',2,1);



--SELECT
select * from Almacen;
select * from Cliente;
select * from Empleado;
select * from Venta;
select * from Proveedor;
select * from Categoria_Usuario;
select * from Talonario;
select * from Comprobante;
select * from Categoria_Producto;
select * from Producto;
select * from Detalle_Venta;
select * from Usuario;
select * from Compra;
select * from Detalle_Compra;
select * from Inventario;
select * from Kardex

-- ENUNCIADOS

--Productos en Inventario con Filtro
select P.idProducto AS ID ,P.nombre AS 'NOMBRE' , P.estado as 'ESTADO', P.precio as 'PRECIO', P.costo as 'COSTO',
PO.idProveedor as 'ID PROVEEDOR', PO.nombre as 'NOMBRE PROVEEDOR',
CP.descripcion as DESCRIPCION, I.idAlmacen as 'ALMACEN' from Producto P JOIN Categoria_Producto CP on P.idCategoria = CP.idCategoria
JOIN Proveedor PO on P.idProveedor = PO.idProveedor JOIN Inventario I on P.idProducto=I.idProducto

-- Kardex con Filtro
select K.idKardex as 'ID', K.fecha as 'FECHA EMISION', K.tipoMovimiento as 'TIPO', K.descripcion as 'DESCRIPCION', K.sucursalRef as 'SUCURSAL', P.nombre as 'NOMBRE PRODUCTO', 
K.stockRef as 'STOCK', K.responsable as 'RESPONSABLE' from Kardex K join Producto P on K.idProducto = P.idProducto where K.idAlmacen =1 and K.idProducto = 1

-- Proveedor con LIKE
select * from Proveedor where idProveedor like 'P-%'
-- Empleado con LIKE
select * from Empleado  E JOIN Usuario U ON E.idEmpleado=U.idEmpleado where E.idEmpleado like '17%'
-- Empleado Unido con Usuario
Select * from Empleado E JOIN Usuario U ON E.idEmpleado=U.idEmpleado
go
-- VISTAS
-- Compras realizadas en mes de diciembre del 2021
create view Compras_Diciembre
as
select C.idCompra as 'ID', C.fecha as 'Fecha de Compra', C.total as 'Total', C.numCompra as 'Numero de Compra', C.serieCompra as 'Serie' from Compra C where C.fecha between '2021-12-01' and '2021-12-31'
go

select * from Compras_Diciembre
go
-- Productos en estado ACTIVO
create view Productos_Activos
as
select P.idProducto as 'ID', P.nombre as 'Nombre', P.estado as 'Estado' from Producto P where P.estado = 'ACTIVO'
go

select * from Productos_Activos
go
-- Usuarios en estado ACTIVO
create view Usuarios_Activos
as
select E.idEmpleado as 'ID de Empleado', E.nombres+' '+E.apPaterno+' '+E.apMaterno as 'Nombre de Empleado',U.idUsuario as 'ID de Usuario', CU.descripcion as 'Categoria de Usuario' from Usuario U join Empleado E on U.idEmpleado = E.idEmpleado join Categoria_Usuario CU on U.idCategoriaUsuario = CU.idCategoriaUsuario where U.estado = 'ACTIVO'
go

select * from Usuarios_Activos
go
--FUNCIONES
create Function NombreCompletoEmpleado(@idEmpleado as varchar(10))
returns table 
as
return(select E.nombres+' '+E.apPaterno+' '+E.apMaterno as 'Nombre Completo' from Empleado E where E.idEmpleado = @idEmpleado)
go

select * from NombreCompletoEmpleado('13548927')
go

--PROCEDIMIENTOS ALMACENADOS
create procedure pa_agregarEmpleado
@idEmpleado char(10),
@nombres varchar(50),
@apPaterno varchar(50),
@apMaterno varchar(50),
@fechaIngreso date,
@sueldo float
as
begin
insert into Empleado 
values(@idEmpleado,@nombres,@apPaterno,@apMaterno,@fechaIngreso,@sueldo)
end

go
create procedure pa_agregarProducto
@nombre varchar(50),
@estado as varchar(20),
@precio as float,
@costo as float,
@idCategoria as int,
@idProveedor as nchar(11)
as 
begin
insert into Producto
values(@nombre,@estado,@precio,@costo,@idCategoria,@idProveedor)
SELECT SCOPE_IDENTITY();
end

go

create procedure pa_agregarUsuario
@idEmpleado char(10),
@idUsuario varchar(100),
@clave varchar(20),
@idCategoriaUsuario int,
@estado varchar(20)
as
begin
insert into Usuario 
values(@idEmpleado,@idUsuario,@clave,@idCategoriaUsuario,@estado)
end

go

create procedure pa_agregarCategoriaUsuario
@descripcion varchar(50)
as
begin
insert into Categoria_Usuario 
values(@descripcion)
end

go

create procedure pa_agregarCompra
@fecha date,
@formaPago varchar(50),
@total float,
@igv float,
@numCompra varchar(4),
@serieCompra varchar(8),
@subtotal float,
@tipoComprobante varchar(50),
@diasCredito int,
@fechaPago date,
@idProveedor varchar(11),
@idEmpleado nchar(10),
@idUsuario varchar(100)
as
begin
insert into Compra
values(@fecha,@formaPago,@total,@igv,@numCompra,@serieCompra,@subtotal,@tipoComprobante,@diasCredito,@fechaPago,@idProveedor,@idEmpleado,@idUsuario)
SELECT SCOPE_IDENTITY();
end
go

create procedure pa_agregarDetalleCompra
@cantidad int,
@subtotal float,
@idProducto int,
@idCompra int
as
begin
insert into Detalle_Compra
values(@cantidad,@subtotal,@idProducto,@idCompra)
end
go

create procedure pa_modificarCliente
@idCliente varchar(11),
@nombre varchar(50),
@apPaterno varchar(50),
@apMaterno varchar(50),
@telefono nchar(9),
@correo varchar(50),
@direccion varchar(50),
@tipoDocumento varchar(20)
as
begin
update Cliente
	set nombre = @nombre,
		apPaterno = @apPaterno,
		apMaterno = @apMaterno,
		telefono = @telefono,
		correo = @correo,
		direccion = @direccion,
		tipoDocumento = @tipoDocumento
	where idCliente = @idCliente
end

go

create procedure pa_modificarTalonario
@num int,
@tipo varchar(20),
@serie nchar(8)
as
begin
update Talonario
	set tipoTalonario = @tipo,
		serieTalonario = @serie
	where numTalonario = @num
end

go

create procedure pa_modificarCategoriaProducto
@id int,
@descripcion varchar(50)
as
begin
update Categoria_Producto
	set descripcion = @descripcion
	where idCategoria = @id
end

go

create procedure pa_modificarProveedor
@idProveedor varchar(11),
@nombres varchar(50),
@tipoDocumento varchar(20),
@direccion varchar(50),
@correo varchar(50),
@telefono nchar(9),
@estado varchar(20)
as
begin
update Proveedor
	set nombre = @nombres,
		tipoDocumento = @tipoDocumento,
		direccion = @direccion,
		correo = @correo,
		telefono = @telefono,
		estado = @estado
	where idProveedor = @idProveedor  
end

go

--DELETE
--delete from Venta
--delete from Compra
--RESET IDENTITY
--DBCC CHECKIDENT (Categoria_Usuario, RESEED, 0)
--DBCC CHECKIDENT (Venta, RESEED, 0)
--DBCC CHECKIDENT (Compra, RESEED, 0)
