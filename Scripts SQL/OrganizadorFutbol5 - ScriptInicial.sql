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
Name varchar(255) UNIQUE, --El Name del Administrador es 'admin'.
Pass varchar(255),
);

CREATE TABLE MEINF�HRER.Persona --Seran los amigos sin jugar. (Ponele, sacados del Facebook (?)
(
Id_Persona numeric(18,0) IDENTITY (1,1) NOT NULL,
Id_Usuario numeric(18,0), --Un amigo puede no ser usuario del sistema. Recibe el User al registrarse.
Nombre varchar(255),
Apellido varchar(255),
Edad numeric(18,0),
Mail varchar(255),
Telefono varchar(255),
Ciudad varchar(255),
--Pueden agregarse m�s cosas, lo que se considere necesario (Facebook, Twitter, ID de Line (? )
);

CREATE TABLE MEINF�HRER.Jugador
(
Id_Jugador numeric (18,0) IDENTITY (1,1) NOT NULL,
Id_Persona numeric (18,0) NOT NULL, --De aca se sacan los Datos Personales.
Id_Partido numeric (18,0), --Puede ser NULL si no se inscribi� a ningun partido.
Id_Modalidad numeric(18,0), -- Guardamos la modalidad con la que se inscribio. NULL si no esta inscripto en ningun partido.
--Pueden agregarse cosas, como las posiciones especiales, habilidades onda PES, y muchas cosas mas (?
);

CREATE TABLE MEINF�HRER.Modalidad	--Por ahora hay solo tres modalidades.
(
Id_Modalidad numeric(18,0) IDENTITY (1,1) NOT NULL,
Tipo varchar(255),
Condicion varchar(255),--Si el Tipo es CONDICIONAL, guardamos la condicion
);

CREATE TABLE MEINF�HRER.Partido
(
Id_Partido numeric(18,0) IDENTITY (1,1) NOT NULL,
Id_Administrador numeric (18,0), -- Es una Id_Usuario. En un principio seria siempre el mismo.
Descripcion varchar(255),
);

CREATE TABLE MEINF�HRER.Calificacion
(
Id_Calificacion numeric (18,0) IDENTITY (1,1) NOT NULL,
Id_Jugador numeric(18,0) NOT NULL,
Valor numeric(18,1), --El valor de la calificacion (del 1 al 10 - Chequear desde C#).
Descripcion varchar(255), --Texto a modo de critica.
);

CREATE TABLE MEINF�HRER.Infraccion
(
Id_Infraccion numeric(18,0) IDENTITY (1,1) NOT NULL,
Id_Jugador numeric(18,0) NOT NULL,
Descripcion varchar(255),
)

CREATE TABLE MEINF�HRER.Notificacion
(
Id_Notificacion numeric(18,0) IDENTITY (1,1) NOT NULL,
Id_Receptor numeric(18,0) NOT NULL, --Admin, Jugador o Amigo que recibe la notificacion. (Buzon de Entrada)
Id_Emisor numeric(18,0), --otra Id_Usuario. Es quien la envia: Admin, Jugador, o nadie. (Buzon de Salida)
Mensaje varchar(255),
);

CREATE TABLE MEINF�HRER.Denegacion --No guardamos la Id_Administrador/Usuario porque tenemos 1 solo admin. (Supuestamente)
(
Id_Denegacion numeric(18,0) IDENTITY (1,1) NOT NULL,
Motivo varchar(255),
Fecha datetime,
);

CREATE TABLE MEINF�HRER.PersonaXJugador	--Tabla de amigos, que pueden o no ser jugadores.
(
Id_Jugador numeric(18,0) NOT NULL,
Id_Persona numeric(18,0) NOT NULL,
);



-------------------------------------------------
--------------CreacionDePK-----------------------
-------------------------------------------------
ALTER TABLE MEINF�HRER.Usuario ADD CONSTRAINT PK_Id_Usuario PRIMARY KEY (Id_Usuario);
ALTER TABLE MEINF�HRER.Persona ADD CONSTRAINT PK_Id_Persona PRIMARY KEY (Id_Persona);
ALTER TABLE MEINF�HRER.Jugador ADD CONSTRAINT PK_Id_Jugador PRIMARY KEY (Id_Jugador);
ALTER TABLE MEINF�HRER.Modalidad ADD CONSTRAINT PK_Id_Modalidad PRIMARY KEY (Id_Modalidad);
ALTER TABLE MEINF�HRER.Partido ADD CONSTRAINT PK_Id_Partido PRIMARY KEY (Id_Partido);
ALTER TABLE MEINF�HRER.Calificacion ADD CONSTRAINT PK_Id_Calificacion PRIMARY KEY (Id_Calificacion);
ALTER TABLE MEINF�HRER.Infraccion ADD CONSTRAINT PK_Id_Infraccion PRIMARY KEY (Id_Infraccion);
ALTER TABLE MEINF�HRER.Notificacion ADD CONSTRAINT PK_Id_Notificacion PRIMARY KEY (Id_Notificacion);
ALTER TABLE MEINF�HRER.Denegacion ADD CONSTRAINT PK_Id_Denegacion PRIMARY KEY (Id_Denegacion);
ALTER TABLE MEINF�HRER.PersonaXJugador ADD CONSTRAINT PK_Id_Persona_Jugador PRIMARY KEY (Id_Jugador,Id_Persona);

-------------------------------------------------
--------------CreacionDeFK-----------------------
-------------------------------------------------
ALTER TABLE MEINF�HRER.Persona ADD CONSTRAINT FK_Persona_to_Usuario FOREIGN KEY (Id_Usuario)
REFERENCES MEINF�HRER.Usuario (Id_Usuario);
ALTER TABLE MEINF�HRER.Jugador ADD CONSTRAINT FK_Jugador_to_Persona FOREIGN KEY (Id_Persona)
REFERENCES MEINF�HRER.Persona (Id_Persona);
ALTER TABLE MEINF�HRER.Jugador ADD CONSTRAINT FK_Jugador_to_Partido FOREIGN KEY (Id_Partido)
REFERENCES MEINF�HRER.Partido (Id_Partido);
ALTER TABLE MEINF�HRER.Jugador ADD CONSTRAINT FK_Jugador_to_Modalidad FOREIGN KEY (Id_Modalidad)
REFERENCES MEINF�HRER.Modalidad (Id_Modalidad);
ALTER TABLE MEINF�HRER.Partido ADD CONSTRAINT FK_Partido_to_Administrador FOREIGN KEY (Id_Administrador)
REFERENCES MEINF�HRER.Usuario (Id_Usuario);
ALTER TABLE MEINF�HRER.Calificacion ADD CONSTRAINT FK_Calificacion_to_Jugador FOREIGN KEY (Id_Jugador)
REFERENCES MEINF�HRER.Jugador (Id_Jugador);
ALTER TABLE MEINF�HRER.Infraccion ADD CONSTRAINT FK_Infraccion_to_Jugador FOREIGN KEY (Id_Jugador)
REFERENCES MEINF�HRER.Jugador (Id_Jugador);
ALTER TABLE MEINF�HRER.Notificacion ADD CONSTRAINT FK_Notificacion_to_Emisor FOREIGN KEY (Id_Emisor)
REFERENCES MEINF�HRER.Usuario (Id_Usuario);
ALTER TABLE MEINF�HRER.Notificacion ADD CONSTRAINT FK_Notificacion_to_Receptor FOREIGN KEY (Id_Receptor)
REFERENCES MEINF�HRER.Usuario (Id_Usuario);
ALTER TABLE MEINF�HRER.PersonaXJugador ADD CONSTRAINT FK_PersonaXJugador_to_Persona FOREIGN KEY (Id_Persona)
REFERENCES MEINF�HRER.Persona(Id_Persona);
ALTER TABLE MEINF�HRER.PersonaXJugador ADD CONSTRAINT FK_PersonaXJugador_to_Jugador FOREIGN KEY (Id_Jugador)
REFERENCES MEINF�HRER.Jugador(Id_Jugador);

-------------------------------------------------
-------------CargaDatosIniciales-----------------
-------------------------------------------------

INSERT INTO MEINF�HRER.Usuario (Name,Pass) VALUES ('admin','1234')

-------------------------------------------------
-------------StoredProcedures--------------------
-------------------------------------------------

--LoginUsuario
--Chequea si el Usuario y la Contrasenia son correctas
GO
CREATE PROCEDURE MEINF�HRER.LoginUsuario(@Usuario VARCHAR(255),@Contrasenia VARCHAR(255),@Respuesta VARCHAR(255) OUTPUT)
AS
BEGIN
	DECLARE @Existencia INT = (SELECT COUNT(*) FROM MEINF�HRER.Usuario WHERE Name=@Usuario AND Pass=@Contrasenia)
	IF (@Existencia = 1)
		BEGIN
			SET @Respuesta = 'Abrir Sesion'
		END
	ELSE
		BEGIN
			SET @Respuesta = 'Contrasenia incorrecta o usuario incorrecto, intenteo nuevamente'
		END
END
GO

--InsertarInteresado
--Mas adelante se usara para que el admin carge un nuevo User.
--Le deber�a mandar un mail o etc con el User y Pass nuevo.

GO
CREATE PROCEDURE MEINF�HRER.InsertarInteresado(@Usuario VARCHAR(255),@Contrasenia VARCHAR(255), @Nombre VARCHAR(255), @Apellido VARCHAR(255),
												@Edad NUMERIC(18,0), @Mail VARCHAR(255), @Respuesta VARCHAR(255) OUTPUT)
AS
BEGIN
BEGIN TRY
BEGIN TRANSACTION
	DECLARE @Existencia INT = (SELECT COUNT(*) FROM MEINF�HRER.Usuario WHERE Name=@Usuario AND Pass=@Contrasenia)
	IF (@Existencia = 1 )
		BEGIN
			SET @Respuesta = 'El Usuario ya existe'
		END
	ELSE
		BEGIN
			INSERT INTO MEINF�HRER.Usuario (Name,Pass) VALUES (@Usuario,@Contrasenia)
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

--EsAdmin
--Lo hace para saber que Home abrir.

GO
CREATE PROCEDURE MEINF�HRER.EsAdmin (@IdUsuario numeric(18,0),@Respuesta VARCHAR(255) output)
AS
BEGIN
	IF ((SELECT Name FROM MEINF�HRER.Usuario WHERE Id_Usuario = @IdUsuario) = 'admin')
	BEGIN
		SET @Respuesta = 'Is Admin'
	END
	ELSE
	BEGIN
		SET @Respuesta = 'Is not Admin'
	END
END
GO