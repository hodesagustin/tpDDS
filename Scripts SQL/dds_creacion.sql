USE [DDS2014]
GO

CREATE SCHEMA [dds_esquema] AUTHORIZATION [dds]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- Tabla ADMINISTRADOR
CREATE TABLE [dds_esquema].[Administrador](
	[ID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Mail] [nvarchar](100) NULL,
 CONSTRAINT [PK_Administrador] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
-----------------------------------------------------

-- Tabla JUGADOR
CREATE TABLE [dds_esquema].[Jugador](
	[ID] [numeric](18, 0) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Mail] [nvarchar](100) NOT NULL,
	[Handicap] [tinyint] NOT NULL,
 CONSTRAINT [PK_Jugador] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
-------------------------------------------------------

-- Tabla PARTIDO
CREATE TABLE [dds_esquema].[Partido](
	[ID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[AdministradorID] [numeric](18, 0) NOT NULL,
	[Fecha] [datetime] NOT NULL,
 CONSTRAINT [PK_Partido] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dds_esquema].[Partido]  WITH CHECK ADD  CONSTRAINT [fk_Partido_AdministradorID] FOREIGN KEY([AdministradorID])
REFERENCES [dds_esquema].[Administrador] ([ID])
GO
ALTER TABLE [dds_esquema].[Partido] CHECK CONSTRAINT [fk_Partido_AdministradorID]
GO
----------------------------------------------

-- Tabla INSCRIPCION
CREATE TABLE [dds_esquema].[Inscripcion](
	[PartidoID] [numeric](18, 0) NOT NULL,
	[JugadorID] [numeric](18, 0) NOT NULL,
	[Fecha] [datetime] NOT NULL,
 CONSTRAINT [PK_Inscripcion] PRIMARY KEY CLUSTERED 
(
	[PartidoID] ASC,
	[JugadorID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dds_esquema].[Inscripcion]  WITH CHECK ADD  CONSTRAINT [fk_Inscripcion_JugadorID] FOREIGN KEY([JugadorID])
REFERENCES [dds_esquema].[Jugador] ([ID])
GO
ALTER TABLE [dds_esquema].[Inscripcion] CHECK CONSTRAINT [fk_Inscripcion_JugadorID]
GO

ALTER TABLE [dds_esquema].[Inscripcion]  WITH CHECK ADD  CONSTRAINT [fk_Inscripcion_PartidoID] FOREIGN KEY([PartidoID])
REFERENCES [dds_esquema].[Partido] ([ID])
GO
ALTER TABLE [dds_esquema].[Inscripcion] CHECK CONSTRAINT [fk_Inscripcion_PartidoID]
GO
---------------------------------------------------------

-- Tabla PARTIDO_EQUIPO
CREATE TABLE [dds_esquema].[PartidoEquipo](
	[PartidoID] [numeric](18, 0) NOT NULL,
	[JugadorID] [numeric](18, 0) NOT NULL,
	[Equipo] [char](1) NOT NULL,
 CONSTRAINT [PK_PartidoEquipo] PRIMARY KEY CLUSTERED 
(
	[PartidoID] ASC,
	[JugadorID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dds_esquema].[PartidoEquipo]  WITH CHECK ADD  CONSTRAINT [fk_PartidoEquipo_JugadorID] FOREIGN KEY([JugadorID])
REFERENCES [dds_esquema].[Jugador] ([ID])
GO
ALTER TABLE [dds_esquema].[PartidoEquipo] CHECK CONSTRAINT [fk_PartidoEquipo_JugadorID]
GO
ALTER TABLE [dds_esquema].[PartidoEquipo]  WITH CHECK ADD  CONSTRAINT [fk_PartidoEquipo_PartidoID] FOREIGN KEY([PartidoID])
REFERENCES [dds_esquema].[Partido] ([ID])
GO
ALTER TABLE [dds_esquema].[PartidoEquipo] CHECK CONSTRAINT [fk_PartidoEquipo_PartidoID]
GO
-----------------------------------------------------------

-- Tabla INSCRIPCION_PENDIENTE
CREATE TABLE [dds_esquema].[InscripcionPendiente](
	[PartidoID] [numeric](18, 0) NOT NULL,
	[PersonaNombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_InscripcionPendiente] PRIMARY KEY CLUSTERED 
(
	[PartidoID] ASC,
	[PersonaNombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dds_esquema].[InscripcionPendiente]  WITH CHECK ADD  CONSTRAINT [fk_InscripcionPendiente_PartidoID] FOREIGN KEY([PartidoID])
REFERENCES [dds_esquema].[Partido] ([ID])
GO
ALTER TABLE [dds_esquema].[InscripcionPendiente] CHECK CONSTRAINT [fk_InscripcionPendiente_PartidoID]
GO
-----------------------------------------------------------

-- Tabla RECHAZO
CREATE TABLE [dds_esquema].[Rechazo](
	[PartidoID] [numeric](18, 0) NOT NULL,
	[PersonaNombre] [nvarchar](50) NOT NULL,
	[Fecha] [date] NOT NULL,
	[Motivo] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Rechazo] PRIMARY KEY CLUSTERED 
(
	[PartidoID] ASC,
	[PersonaNombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dds_esquema].[Rechazo]  WITH CHECK ADD  CONSTRAINT [fk_Rechazo_PartidoID] FOREIGN KEY([PartidoID])
REFERENCES [dds_esquema].[Partido] ([ID])
GO
ALTER TABLE [dds_esquema].[Rechazo] CHECK CONSTRAINT [fk_Rechazo_PartidoID]
GO
------------------------------------------

-- Tabla JUGADOR_AMIGO
CREATE TABLE [dds_esquema].[JugadorAmigo](
	[JugadorID] [numeric](18, 0) NOT NULL,
	[AmigoNombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_JugadorAmigo] PRIMARY KEY CLUSTERED 
(
	[JugadorID] ASC,
	[AmigoNombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dds_esquema].[JugadorAmigo]  WITH CHECK ADD  CONSTRAINT [fk_JugadorAmigo_JugadorID] FOREIGN KEY([JugadorID])
REFERENCES [dds_esquema].[Jugador] ([ID])
GO
ALTER TABLE [dds_esquema].[JugadorAmigo] CHECK CONSTRAINT [fk_JugadorAmigo_JugadorID]
GO
----------------------------------------------

-- Tabla INFRACCION
CREATE TABLE [dds_esquema].[Infraccion](
	[PartidoID] [numeric](18, 0) NOT NULL,
	[JugadorID] [numeric](18, 0) NOT NULL,
	[Fecha] [date] NOT NULL,
	[Motivo] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Infraccion] PRIMARY KEY CLUSTERED 
(
	[PartidoID] ASC,
	[JugadorID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dds_esquema].[Infraccion]  WITH CHECK ADD  CONSTRAINT [fk_Infraccion_JugadorID] FOREIGN KEY([JugadorID])
REFERENCES [dds_esquema].[Jugador] ([ID])
GO
ALTER TABLE [dds_esquema].[Infraccion] CHECK CONSTRAINT [fk_Infraccion_JugadorID]
GO
ALTER TABLE [dds_esquema].[Infraccion]  WITH CHECK ADD  CONSTRAINT [fk_Infraccion_PartidoID] FOREIGN KEY([PartidoID])
REFERENCES [dds_esquema].[Partido] ([ID])
GO
ALTER TABLE [dds_esquema].[Infraccion] CHECK CONSTRAINT [fk_Infraccion_PartidoID]
GO
--------------------------------------------------

-- Tabla CALIFICACION
CREATE TABLE [dds_esquema].[Calificacion](
	[CalificadorID] [numeric](18, 0) NOT NULL,
	[PartidoID] [numeric](18, 0) NOT NULL,
	[JugadorID] [numeric](18, 0) NOT NULL,
	[Puntaje] [tinyint] NOT NULL,
	[Descripcion] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Calificacion] PRIMARY KEY CLUSTERED 
(
	[CalificadorID] ASC,
	[PartidoID] ASC,
	[JugadorID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dds_esquema].[Calificacion]  WITH CHECK ADD  CONSTRAINT [fk_Calificacion_CalificadorID] FOREIGN KEY([CalificadorID])
REFERENCES [dds_esquema].[Jugador] ([ID])
GO
ALTER TABLE [dds_esquema].[Calificacion] CHECK CONSTRAINT [fk_Calificacion_CalificadorID]
GO
ALTER TABLE [dds_esquema].[Calificacion]  WITH CHECK ADD  CONSTRAINT [fk_Calificacion_JugadorID] FOREIGN KEY([JugadorID])
REFERENCES [dds_esquema].[Jugador] ([ID])
GO
ALTER TABLE [dds_esquema].[Calificacion] CHECK CONSTRAINT [fk_Calificacion_JugadorID]
GO
ALTER TABLE [dds_esquema].[Calificacion]  WITH CHECK ADD  CONSTRAINT [fk_Calificacion_PartidoID] FOREIGN KEY([PartidoID])
REFERENCES [dds_esquema].[Partido] ([ID])
GO
ALTER TABLE [dds_esquema].[Calificacion] CHECK CONSTRAINT [fk_Calificacion_PartidoID]
GO
-----------------------------------------------

-- Tabla CALIFICACION_PENDIENTE
CREATE TABLE [dds_esquema].[CalificacionPendiente](
	[CalificadorID] [numeric](18, 0) NOT NULL,
	[PartidoID] [numeric](18, 0) NOT NULL,
	[JugadorID] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_CalificacionPendiente] PRIMARY KEY CLUSTERED 
(
	[CalificadorID] ASC,
	[PartidoID] ASC,
	[JugadorID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dds_esquema].[CalificacionPendiente]  WITH CHECK ADD  CONSTRAINT [fk_CalificacionPendiente_CalificadorID] FOREIGN KEY([CalificadorID])
REFERENCES [dds_esquema].[Jugador] ([ID])
GO
ALTER TABLE [dds_esquema].[CalificacionPendiente] CHECK CONSTRAINT [fk_CalificacionPendiente_CalificadorID]
GO
ALTER TABLE [dds_esquema].[CalificacionPendiente]  WITH CHECK ADD  CONSTRAINT [fk_CalificacionPendiente_JugadorID] FOREIGN KEY([JugadorID])
REFERENCES [dds_esquema].[Jugador] ([ID])
GO
ALTER TABLE [dds_esquema].[CalificacionPendiente] CHECK CONSTRAINT [fk_CalificacionPendiente_JugadorID]
GO
ALTER TABLE [dds_esquema].[CalificacionPendiente]  WITH CHECK ADD  CONSTRAINT [fk_CalificacionPendiente_PartidoID] FOREIGN KEY([PartidoID])
REFERENCES [dds_esquema].[Partido] ([ID])
GO
ALTER TABLE [dds_esquema].[CalificacionPendiente] CHECK CONSTRAINT [fk_CalificacionPendiente_PartidoID]
GO
----------------------------------------------------------

CREATE FUNCTION [dds_esquema].[fx_UltimoPartidoJugador] (@Id_Jugador int)
RETURNS datetime
AS 
BEGIN
	Declare @Max datetime = (SELECT MAX(P.Fecha) 
						from [dds_esquema].Partido P
						JOIN [dds_esquema].Calificacion C ON C.PartidoID = P.ID
						where @Id_Jugador = C.JugadorID)
	RETURN @Max
END
GO

-- Vista PROMEDIO TODOS LOS PARTIDOS

CREATE VIEW [dds_esquema].[vw_JugadorPromedio]
AS
SELECT C.JugadorID as JugadorID, AVG(CAST(C.Puntaje as float)) as Promedio
FROM [dds_esquema].Calificacion C
GROUP BY C.JugadorID
GO
-------------------------------------------------------

CREATE VIEW [dds_esquema].[vw_JugadorPromedioUltimoPartido]
AS
SELECT C.JugadorID as JugadorID, AVG(CAST(C.Puntaje as float)) as PromedioUltimoPartido
FROM [dds_esquema].Calificacion C
JOIN [dds_esquema].Partido P ON P.ID = C.PartidoID
WHERE P.Fecha = (SELECT [dds_esquema].[fx_UltimoPartidoJugador](C.JugadorID))
GROUP BY C.JugadorID
go

CREATE VIEW [dds_esquema].vw_Jugador
AS
SELECT J.*, JP.Promedio, JPUP.PromedioUltimoPartido
FROM [dds_esquema].Jugador J
JOIN [dds_esquema].vw_JugadorPromedio JP ON J.ID=JP.JugadorID
JOIN [dds_esquema].vw_JugadorPromedioUltimoPartido JPUP ON J.ID=JPUP.JugadorID
GO

SELECT * FROM [dds_esquema].vw_Jugador