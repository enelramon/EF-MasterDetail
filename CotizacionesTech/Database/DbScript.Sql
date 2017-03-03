/*Tabla Cotizaciones --Raidy Duran-- */
create table Cotizaciones(
CotizacionId int identity(1,1) primary key,
Fecha Date,
ClienteId int,
Monto decimal
);
