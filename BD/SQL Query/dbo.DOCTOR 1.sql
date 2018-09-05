USE [Optica Industrial]

CREATE TABLE DOCTOR(
	[Id Doctor]     INT           PRIMARY KEY,
	Nombre			VARCHAR(35)   NOT NULL,
	Apellido		VARCHAR(35)   NOT NULL,
	Edad		    INT           NOT NULL,
	Direccion       VARCHAR(55)   NOT NULL,
	Telefono        INT           NOT NULL,
	Matricula	    INT           UNIQUE NOT NULL,
	Especialidad    VARCHAR(20)   NOT NULL,
	Email           VARCHAR(30)   UNIQUE NOT NULL,
	Acceso          VARCHAR(50)	  NOT NULL,
    Usuario         VARCHAR(25)   UNIQUE NOT NULL,
	Contrasena      VARCHAR(20)   UNIQUE NOT NULL
);