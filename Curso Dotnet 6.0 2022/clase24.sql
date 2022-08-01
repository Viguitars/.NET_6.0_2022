--COMANDOS DE DEFINICION

--Comando para crear una BD nueva
CREATE DATABASE Agenda

--Commando para seleccionar la BD con la cual vamos a trabajar
USE Agenda

DROP  Agenda
-- Comando para eliminar la BD

CREATE TABLE Personas (
--Comando para crear una tabla y sus columnas
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Nombre VARCHAR(50) NOT NULL,
	Apellido VARCHAR(50) NOT NULL
	);

ALTER TABLE Personas
--Comando para modificar una tabla
ADD Edad INT NOT NULL
--Agregar nuevo campo

ALTER TABLE Personas
--Comando para modificar una tabla
ADD Edad2 INT NOT NULL
--Agregar nuevo campo

ALTER TABLE Personas
--Comando para modificar una tabla
DROP COLUMN Edad2
--Eliminar campo

--COMANDOS DE MANIPULACION

INSERT INTO Personas (Nombre, Apellido, Edad)
VALUES ('Ruben', 'Benegas', 26)
--Comando para insertar un registro en la tabla

INSERT INTO Personas (Nombre, Apellido, Edad)
VALUES ('Joaquin', 'Mateos', 19)

UPDATE Personas
SET Nombre = 'JuanEditado',
	Apellido = 'PerezEditado',
	Edad = 23
--Comando para modificar un registro de tabla
WHERE Id = 1
--Comando para seleccionar que Id debe modificar

DELETE FROM Personas
--Comando para eliminar
--El mismo no rinicia el contador de Id's.
WHERE Id = 1
--Con la palabra reservada WHERE es muy importante seleccionar el Id a modificar.
--De no hacerlo lo realiza en todos los Id.
--En este caso elimina todos los Id.

TRUNCATE TABLE Personas
--Comando para vaciar todos los datos de la planilla
--El mismo si reinicia el contador de Id's.

SELECT * FROM Personas
--Comando para consultar los datos
--Usando '*' muestra todos los campos

SELECT Id, Nombre FROM Personas
--Aqui muestra el Id y nombre


SELECT Id, Nombre + ' ' + Apellido As Descripcion FROM Personas
--As (como) dice que este campo se llama 'Descripcion'
--Aqui muestra el Id y en una columna llamada 'Descripcion', concatena el nombre y el apellido con un espacio de separacion usando ''.
WHERE Id = 1
--Y con la palabra reservada WHERE, se selecciona el campo a consulatar

SELECT Id, Nombre + ' ' + Apellido As Descripcion FROM Personas
WHERE Nombre = 'Ruben'