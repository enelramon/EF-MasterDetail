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

/* Tabla Productos -- Luis Tejada -- */
create table Productos(ProductoId int primary key identity(1,1), Descripcion varchar(60), Medida varchar(30), Itbis bit, Costo decimal, Precio decimal);


