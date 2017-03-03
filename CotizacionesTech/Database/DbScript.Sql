/*Tabla de Clientes - Pedro De Jesus */
create table Clientes(ClienteId int identity(1,1) primary key, 
Nombres varchar(80), 
Direccion varchar(100),
Email varchar(50),
Telefono varchar(15),
Celular varchar(15),
LimiteCredito int);

/*Tabla Tipo de productos  --Anthony Santana-- */
create table TiposProductos(TipoId int identity primary key ,
Tipo varchar(100),
esActivo  bit  );

/*Tabla Cotizaciones --Raidy Duran-- */
create table Cotizaciones(
CotizacionId int identity(1,1) primary key,
Fecha Date,
ClienteId int,
Monto decimal
);
