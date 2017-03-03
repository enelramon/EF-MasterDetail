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
