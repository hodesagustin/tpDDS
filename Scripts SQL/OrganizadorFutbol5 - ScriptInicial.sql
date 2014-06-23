---------------------------------------
------------ScritpDeCreacion-----------
---------------------------------------

USE [DDS2014]
GO
CREATE SCHEMA [MEINF�HRER] AUTHORIZATION [OrganizadorFutbol5]
GO

---------------------------------------
-----------CreacionDeTablas------------
---------------------------------------
CREATE TABLE MEINF�HRER.Usuario
(
Id_Usuario numeric(18,0) IDENTITY (1,1) NOT NULL,
Name varchar(255) UNIQUE,
Pass varchar(255),
IsAdmin bit DEFAULT 0,
);

CREATE TABLE MEINF�HRER.Persona
(
Id_Persona numeric(18,0) IDENTITY (1,1) NOT NULL,
Id_Usuario numeric(18,0) UNIQUE,
Nombre varchar(255),
);

CREATE TABLE MEINF�HRER.Interesado
(
Id_Interesado numeric(18,0) IDENTITY (1,1) NOT NULL,
Id_Persona numeric (18,0) UNIQUE,
Apellido varchar(255),
Edad numeric(18,0),
Mail varchar(255),
Modalidad varchar(255),
);
GO

CREATE TABLE MEINF�HRER.Jugador
(
Id_Jugador numeric (18,0) IDENTITY (1,1) NOT NULL,
Id_Interesado numeric (18,0),
Id_Partido numeric (18,0),
);

CREATE TABLE MEINF�HRER.Partido
(
Id_Partido numeric(18,0) IDENTITY (1,1) NOT NULL,
Descripcion varchar(255),
);

CREATE TABLE MEINF�HRER.Posicion
(
Id_Posicion numeric (18,0) IDENTITY (1,1) NOT NULL,
Descripcion varchar(255),
);

CREATE TABLE MEINF�HRER.PosicionXInteresado
(
Id_Posicion numeric (18,0) NOT NULL,
Id_Interesado numeric (18,0) NOT NULL,
);

-------------------------------------------------
--------------CreacionDePK-----------------------
-------------------------------------------------
ALTER TABLE MEINF�HRER.Usuario ADD CONSTRAINT PK_Id_Usuario PRIMARY KEY (Id_Usuario);
ALTER TABLE MEINF�HRER.Persona ADD CONSTRAINT PK_Id_Persona PRIMARY KEY (Id_Persona);
ALTER TABLE MEINF�HRER.Interesado ADD CONSTRAINT PK_Id_Interesado PRIMARY KEY (Id_Interesado);
ALTER TABLE MEINF�HRER.Jugador ADD CONSTRAINT PK_Id_Jugador PRIMARY KEY (Id_Jugador);
ALTER TABLE MEINF�HRER.Partido ADD CONSTRAINT PK_Id_Partido PRIMARY KEY (Id_Partido);
ALTER TABLE MEINF�HRER.Posicion ADD CONSTRAINT PK_Id_Posicion PRIMARY KEY (Id_Posicion);
ALTER TABLE MEINF�HRER.PosicionXInteresado ADD CONSTRAINT PK_Id_Posicion_Interesado PRIMARY KEY (Id_Posicion,Id_Interesado);

-------------------------------------------------
--------------CreacionDeFK-----------------------
-------------------------------------------------
ALTER TABLE MEINF�HRER.Persona ADD CONSTRAINT FK_Persona_to_Usuario FOREIGN KEY (Id_Usuario)
REFERENCES MEINF�HRER.Usuario (Id_Usuario);
ALTER TABLE MEINF�HRER.Interesado ADD CONSTRAINT FK_Interesado_to_Persona FOREIGN KEY (Id_Persona)
REFERENCES MEINF�HRER.Persona (Id_Persona);
ALTER TABLE MEINF�HRER.Jugador ADD CONSTRAINT FK_Jugador_to_Interesado FOREIGN KEY (Id_Interesado)
REFERENCES MEINF�HRER.Interesado (Id_Interesado);
ALTER TABLE MEINF�HRER.PosicionXInteresado ADD CONSTRAINT FK_PosicionXInteresado_to_Posicion FOREIGN KEY (Id_Posicion)
REFERENCES MEINF�HRER.Posicion (Id_Posicion);
ALTER TABLE MEINF�HRER.PosicionXInteresado ADD CONSTRAINT FK_PosicionXInteresado_to_Interesado FOREIGN KEY (Id_Interesado)
REFERENCES MEINF�HRER.Interesado(Id_Interesado);

--OtrasConstraints
ALTER TABLE MEINF�HRER.Interesado ADD CONSTRAINT CK_Modalidad CHECK (Modalidad IN ('Standard','Solidario','Condicional'))

-------------------------------------------------
-------------CargaDatosIniciales-----------------
-------------------------------------------------

INSERT INTO MEINF�HRER.Usuario (Name,Pass,IsAdmin) VALUES ('admin','1234',1)
INSERT INTO MEINF�HRER.Posicion (Descripcion) VALUES ('Delantero'),('Mediocampista'),('Defensor'),('Arquero')

-------------------------------------------------
-------------StoredProcedures--------------------
-------------------------------------------------

--LoginUsuario
GO
CREATE PROCEDURE MEINF�HRER.LoginUsuario(@Usuario VARCHAR(255),@Contrase�a VARCHAR(255),@Respuesta VARCHAR(255) OUTPUT)
AS
BEGIN
	DECLARE @Existencia INT = (SELECT COUNT(*) FROM MEINF�HRER.Usuario WHERE Name=@Usuario AND Pass=@Contrase�a)
	IF (@Existencia = 1)
		BEGIN
			SET @Respuesta = 'Abrir Sesion'
		END
	ELSE
		BEGIN
			SET @Respuesta = 'Contrase�a incorrecta, intentel� nuevamente.'
		END
END
GO

--InsertarInteresado

GO
CREATE PROCEDURE MEINF�HRER.InsertarInteresado(@Usuario VARCHAR(255),@Contrase�a VARCHAR(255), @Nombre VARCHAR(255), @Apellido VARCHAR(255),
												@Edad NUMERIC(18,0), @Mail VARCHAR(255), @Respuesta VARCHAR(255) OUTPUT)
AS
BEGIN
BEGIN TRY
BEGIN TRANSACTION
	DECLARE @Existencia INT = (SELECT COUNT(*) FROM MEINF�HRER.Usuario WHERE Name=@Usuario AND Pass=@Contrase�a)
	IF (@Existencia = 1 )
		BEGIN
			SET @Respuesta = 'El Usuario ya existe'
		END
	ELSE
		BEGIN
		
			INSERT INTO MEINF�HRER.Usuario (Name,Pass) VALUES (@Usuario,@Contrase�a)
			
			DECLARE @IdUsuario INT = (SELECT Id_Usuario FROM MEINF�HRER.Usuario WHERE Name=@Usuario)
			INSERT INTO MEINF�HRER.Persona(Id_Usuario,Nombre) VALUES (@IdUsuario,@Nombre)
			
			DECLARE @IdPersona INT = (SELECT Id_Persona FROM MEINF�HRER.Persona WHERE @IdUsuario=Id_Usuario)  
			INSERT INTO MEINF�HRER.Interesado (Id_Persona,Apellido,Edad,Mail) VALUES (@IdPersona,@Apellido,@Edad,@Mail)
				
			SET @Respuesta = 'Cuenta creada!'
		END
COMMIT TRANSACTION
END TRY

BEGIN CATCH
ROLLBACK TRANSACTION
END CATCH
END
GO

--InsertarPosicion

GO
CREATE PROCEDURE MEINF�HRER.InsertarPosicion (@Usuario VARCHAR(255),@Posicion VARCHAR(255))
AS
BEGIN
	DECLARE @IdInteresado INT = (SELECT I.Id_Interesado FROM MEINF�HRER.Usuario U,
									MEINF�HRER.Interesado I, MEINF�HRER.Persona P		
								WHERE U.Name = @Usuario AND P.Id_Usuario= U.Id_Usuario AND I.Id_Persona=P.Id_Persona)
	DECLARE @IdPosicion INT = (SELECT Id_Posicion FROM MEINF�HRER.Posicion WHERE Descripcion = @Posicion)
	INSERT INTO MEINF�HRER.PosicionXInteresado(Id_Interesado, Id_Posicion) VALUES (@IdInteresado,@IdPosicion)
END

--EsAdmin
GO

GO
CREATE PROCEDURE MEINF�HRER.EsAdmin (@IdUsuario numeric(18,0),@Respuesta VARCHAR(255) output)
AS
BEGIN
	IF ((SELECT IsAdmin FROM MEINF�HRER.Usuario WHERE Id_Usuario = @IdUsuario) = 1)
	BEGIN
		SET @Respuesta = 'Is Admin'
	END
	ELSE
	BEGIN
		SET @Respuesta = 'Is not Admin'
	END
END
GO