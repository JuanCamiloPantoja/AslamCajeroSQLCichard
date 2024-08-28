create database CajeroSqlCichard
create table Registrar(
NumCuenta int primary key identity, 
Nombre varchar (45),
Apellido varchar (45), 
TipDocumento varchar (2), 
Documento varchar (10), 
clave int);

select * from Registrar