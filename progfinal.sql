CREATE DATABASE progfinal
GO
USE progfinal
--Tabla Inicio
GO
CREATE TABLE inicio(
id INT IDENTITY (1,1) PRIMARY KEY,
usuario VARCHAR(50),
contraseña VARCHAR (50)
);

--Insertar datos
GO
INSERT INTO inicio (usuario,contraseña)
VALUES ('admi',1234);
GO 
SELECT * FROM inicio;

--Tabla Producto
GO
CREATE TABLE producto(
id INT IDENTITY (1,1) PRIMARY KEY,
nombre VARCHAR(50),
precio FLOAT
)
GO
SET identity_insert producto OFF;
INSERT INTO producto (nombre,precio)
VALUES ('Canon', 6000)
SELECT * FROM producto;
--SET identity_insert producto OFF;

--Tabla Cliente
GO
CREATE TABLE cliente (
ID INT PRIMARY KEY IDENTITY,
rnc VARCHAR(50),
nombre VARCHAR(50),
telefono VARCHAR(50),
email VARCHAR(50),
categoria VARCHAR(50)
);
GO
SELECT * FROM cliente;
--Tabla Proveedor
GO
CREATE TABLE proveedor (
ID INT PRIMARY KEY IDENTITY,
rnc INT,
nombre VARCHAR(50),
telefono INT,
email VARCHAR(50)
);
GO
SELECT * FROM proveedor;
GO
INSERT INTO proveedor (rnc,nombre,telefono,email)
VALUES ('052-78945612-5', 'Canon Company', '809-885-9854', 'canoncompany@hotmail.com');
--	Tabla Entrada
GO
CREATE TABLE entrada (
ID INT PRIMARY KEY IDENTITY,
nombre VARCHAR(50),
cantidad INT,
proveedor VARCHAR(50),
fecha VARCHAR(50) );
GO
SELECT * FROM entrada;
GO 
INSERT INTO entrada (nombre,cantidad,proveedor,fecha)
VALUES ('CANON´POWER SHOT',4,'CANON','2020-07-28')

GO
CREATE TABLE facturacion(
ID INT PRIMARY KEY IDENTITY,
nombre VARCHAR(50),
cliente VARCHAR(50),
cantidad INT,
precio INT
);
GO
INSERT INTO facturacion (nombre,cliente,cantidad,precio,fecha)
VALUES ('Canon','Luis', 2,9000, 28-07-2020);
GO
SELECT * FROM facturacion;

