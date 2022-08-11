--Usando los comandos vistos en clase seguir los siguientes pasos:
--1. Crear una base de datos con nombre "CursoNet"
CREATE DATABASE CursoNet
--2. Dentro de la base generada crear una tabla llamada "Instructores" que contenga los campos:
		--Id: clave principal auto incremental
		--Nombre
		--Apellido
USE CursoNet
CREATE TABLE Instructores (
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Nombre VARCHAR(50) NOT NULL,
	Apellido VARCHAR(50) NOT NULL
	);
--3. Cargar en la tabla todos los instructores de este curso
INSERT INTO Instructores (Nombre, Apellido)
VALUES 
('Ruben', 'Benegas'),
('Ezequiel', 'Etchecoin'),
('Joaquin', 'Mateos'),
('Eugenio', 'Serrano'),
('Carlos', 'Moscoso')
--4. Consultar la lista completa de instructores.
SELECT * FROM Instructores
--Compartir todos los comandos utilizados.