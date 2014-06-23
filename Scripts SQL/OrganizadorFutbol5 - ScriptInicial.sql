---------------------------------------
------------ScritpDeCreacion-----------
---------------------------------------

USE [DDS2014]
GO
CREATE SCHEMA [MEINFÜHRER] AUTHORIZATION [OrganizadorFutbol5]
GO

---------------------------------------
-----------CreacionDeTablas------------
---------------------------------------
CREATE TABLE MEINFÜHRER.Usuario
(
Id_Usuario numeric(18,0) IDENTITY (1,1) NOT NULL,
Name varchar(255) UNIQUE,
Pass varchar(255),
IsAdmin bit DEFAULT 0,
);

CREATE TABLE MEINFÜHRER.Persona
(
Id_Persona numeric(18,0) IDENTITY (1,1) NOT NULL,
Id_Usuario numeric(18,0) UNIQUE,
Nombre varchar(255),
);

CREATE TABLE MEINFÜHRER.Interesado
(
Id_Interesado numeric(18,0) IDENTITY (1,1) NOT NULL,
Id_Persona numeric (18,0) UNIQUE,
Apellido varchar(255),
Edad numeric(18,0),
Mail varchar(255),
Modalidad varchar(255),
);
GO

CREATE TABLE MEINFÜHRER.Jugador
(
Id_Jugador numeric (18,0) IDENTITY (1,1) NOT NULL,
Id_Interesado numeric (18,0),
Id_Partido numeric (18,0),
);

CREATE TABLE MEINFÜHRER.Partido
(
Id_Partido numeric(18,0) IDENTITY (1,1) NOT NULL,
Descripcion varchar(255),
);

CREATE TABLE MEINFÜHRER.Posicion
(
Id_Posicion numeric (18,0) IDENTITY (1,1) NOT NULL,
Descripcion varchar(255),
);

CREATE TABLE MEINFÜHRER.PosicionXInteresado
(
Id_Posicion numeric (18,0) NOT NULL,
Id_Interesado numeric (18,0) NOT NULL,
);

-------------------------------------------------
--------------CreacionDePK-----------------------
-------------------------------------------------
ALTER TABLE MEINFÜHRER.Usuario ADD CONSTRAINT PK_Id_Usuario PRIMARY KEY (Id_Usuario);
ALTER TABLE MEINFÜHRER.Persona ADD CONSTRAINT PK_Id_Persona PRIMARY KEY (Id_Persona);
ALTER TABLE MEINFÜHRER.Interesado ADD CONSTRAINT PK_Id_Interesado PRIMARY KEY (Id_Interesado);
ALTER TABLE MEINFÜHRER.Jugador ADD CONSTRAINT PK_Id_Jugador PRIMARY KEY (Id_Jugador);
ALTER TABLE MEINFÜHRER.Partido ADD CONSTRAINT PK_Id_Partido PRIMARY KEY (Id_Partido);
ALTER TABLE MEINFÜHRER.Posicion ADD CONSTRAINT PK_Id_Posicion PRIMARY KEY (Id_Posicion);
ALTER TABLE MEINFÜHRER.PosicionXInteresado ADD CONSTRAINT PK_Id_Posicion_Interesado PRIMARY KEY (Id_Posicion,Id_Interesado);

-------------------------------------------------
--------------CreacionDeFK-----------------------
-------------------------------------------------
ALTER TABLE MEINFÜHRER.Persona ADD CONSTRAINT FK_Persona_to_Usuario FOREIGN KEY (Id_Usuario)
REFERENCES MEINFÜHRER.Usuario (Id_Usuario);
ALTER TABLE MEINFÜHRER.Interesado ADD CONSTRAINT FK_Interesado_to_Persona FOREIGN KEY (Id_Persona)
REFERENCES MEINFÜHRER.Persona (Id_Persona);
ALTER TABLE MEINFÜHRER.Jugador ADD CONSTRAINT FK_Jugador_to_Interesado FOREIGN KEY (Id_Interesado)
REFERENCES MEINFÜHRER.Interesado (Id_Interesado);
ALTER TABLE MEINFÜHRER.PosicionXInteresado ADD CONSTRAINT FK_PosicionXInteresado_to_Posicion FOREIGN KEY (Id_Posicion)
REFERENCES MEINFÜHRER.Posicion (Id_Posicion);
ALTER TABLE MEINFÜHRER.PosicionXInteresado ADD CONSTRAINT FK_PosicionXInteresado_to_Interesado FOREIGN KEY (Id_Interesado)
REFERENCES MEINFÜHRER.Interesado(Id_Interesado);

--OtrasConstraints
ALTER TABLE MEINFÜHRER.Interesado ADD CONSTRAINT CK_Modalidad CHECK (Modalidad IN ('Standard','Solidario','Condicional'))

-------------------------------------------------
-------------CargaDatosIniciales-----------------
-------------------------------------------------

INSERT INTO MEINFÜHRER.Usuario (Name,Pass,IsAdmin) VALUES ('admin','1234',1)
INSERT INTO MEINFÜHRER.Posicion (Descripcion) VALUES ('Delantero'),('Mediocampista'),('Defensor'),('Arquero')

-------------------------------------------------
-------------StoredProcedures--------------------
-------------------------------------------------

--LoginUsuario
GO
CREATE PROCEDURE MEINFÜHRER.LoginUsuario(@Usuario VARCHAR(255),@Contraseña VARCHAR(255),@Respuesta VARCHAR(255) OUTPUT)
AS
BEGIN
	DECLARE @Existencia INT = (SELECT COUNT(*) FROM MEINFÜHRER.Usuario WHERE Name=@Usuario AND Pass=@Contraseña)
	IF (@Existencia = 1)
		BEGIN
			SET @Respuesta = 'Abrir Sesion'
		END
	ELSE
		BEGIN
			SET @Respuesta = 'Contraseña incorrecta, intenteló nuevamente.'
		END
END
GO

--InsertarInteresado

GO
CREATE PROCEDURE MEINFÜHRER.InsertarInteresado(@Usuario VARCHAR(255),@Contraseña VARCHAR(255), @Nombre VARCHAR(255), @Apellido VARCHAR(255),
												@Edad NUMERIC(18,0), @Mail VARCHAR(255), @Respuesta VARCHAR(255) OUTPUT)
AS
BEGIN
BEGIN TRY
BEGIN TRANSACTION
	DECLARE @Existencia INT = (SELECT COUNT(*) FROM MEINFÜHRER.Usuario WHERE Name=@Usuario AND Pass=@Contraseña)
	IF (@Existencia = 1 )
		BEGIN
			SET @Respuesta = 'El Usuario ya existe'
		END
	ELSE
		BEGIN
		
			INSERT INTO MEINFÜHRER.Usuario (Name,Pass) VALUES (@Usuario,@Contraseña)
			
			DECLARE @IdUsuario INT = (SELECT Id_Usuario FROM MEINFÜHRER.Usuario WHERE Name=@Usuario)
			INSERT INTO MEINFÜHRER.Persona(Id_Usuario,Nombre) VALUES (@IdUsuario,@Nombre)
			
			DECLARE @IdPersona INT = (SELECT Id_Persona FROM MEINFÜHRER.Persona WHERE @IdUsuario=Id_Usuario)  
			INSERT INTO MEINFÜHRER.Interesado (Id_Persona,Apellido,Edad,Mail) VALUES (@IdPersona,@Apellido,@Edad,@Mail)
				
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
CREATE PROCEDURE MEINFÜHRER.InsertarPosicion (@Usuario VARCHAR(255),@Posicion VARCHAR(255))
AS
BEGIN
	DECLARE @IdInteresado INT = (SELECT I.Id_Interesado FROM MEINFÜHRER.Usuario U,
									MEINFÜHRER.Interesado I, MEINFÜHRER.Persona P		
								WHERE U.Name = @Usuario AND P.Id_Usuario= U.Id_Usuario AND I.Id_Persona=P.Id_Persona)
	DECLARE @IdPosicion INT = (SELECT Id_Posicion FROM MEINFÜHRER.Posicion WHERE Descripcion = @Posicion)
	INSERT INTO MEINFÜHRER.PosicionXInteresado(Id_Interesado, Id_Posicion) VALUES (@IdInteresado,@IdPosicion)
END

--EsAdmin
GO

GO
CREATE PROCEDURE MEINFÜHRER.EsAdmin (@IdUsuario numeric(18,0),@Respuesta VARCHAR(255) output)
AS
BEGIN
	IF ((SELECT IsAdmin FROM MEINFÜHRER.Usuario WHERE Id_Usuario = @IdUsuario) = 1)
	BEGIN
		SET @Respuesta = 'Is Admin'
	END
	ELSE
	BEGIN
		SET @Respuesta = 'Is not Admin'
	END
END
GO