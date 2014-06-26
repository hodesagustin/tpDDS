---------------------------------------
--------------ScritpDeDrop-------------
---------------------------------------

--DropFKs
ALTER TABLE MEINFÜHRER.PersonaXJugador DROP CONSTRAINT FK_PersonaXJugador_to_Persona;
ALTER TABLE MEINFÜHRER.PersonaXJugador DROP CONSTRAINT FK_PersonaXJugador_to_Jugador;
ALTER TABLE MEINFÜHRER.Notificacion DROP CONSTRAINT FK_Notificacion_to_Receptor;
ALTER TABLE MEINFÜHRER.Notificacion DROP CONSTRAINT FK_Notificacion_to_Emisor;
ALTER TABLE MEINFÜHRER.Infraccion DROP CONSTRAINT FK_Infraccion_to_Jugador;
ALTER TABLE MEINFÜHRER.Calificacion DROP CONSTRAINT FK_Calificacion_to_Jugador;
ALTER TABLE MEINFÜHRER.Partido DROP CONSTRAINT FK_Partido_to_Administrador;
ALTER TABLE MEINFÜHRER.Jugador DROP CONSTRAINT FK_Jugador_to_Modalidad;
ALTER TABLE MEINFÜHRER.Jugador DROP CONSTRAINT FK_Jugador_to_Partido;
ALTER TABLE MEINFÜHRER.Jugador DROP CONSTRAINT FK_Jugador_to_Persona;
ALTER TABLE MEINFÜHRER.Persona DROP CONSTRAINT FK_Persona_to_Usuario;

--DropTablas
DROP TABLE MEINFÜHRER.PersonaXJugador;
DROP TABLE MEINFÜHRER.Denegacion;
DROP TABLE MEINFÜHRER.Notificacion;
DROP TABLE MEINFÜHRER.Infraccion;
DROP TABLE MEINFÜHRER.Calificacion;
DROP TABLE MEINFÜHRER.Partido;
DROP TABLE MEINFÜHRER.Modalidad;
DROP TABLE MEINFÜHRER.Jugador;
DROP TABLE MEINFÜHRER.Persona;
DROP TABLE MEINFÜHRER.Usuario;

--DropStoredProcedures
DROP PROCEDURE MEINFÜHRER.LoginUsuario;
DROP PROCEDURE MEINFÜHRER.InsertarInteresado;
DROP PROCEDURE MEINFÜHRER.EsAdmin;

--DropSchema
USE [DDS2014]
GO
DROP SCHEMA MEINFÜHRER
GO