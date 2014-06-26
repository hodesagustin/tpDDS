---------------------------------------
--------------ScritpDeDrop-------------
---------------------------------------

--DropFKs
ALTER TABLE MEINF�HRER.PersonaXJugador DROP CONSTRAINT FK_PersonaXJugador_to_Persona;
ALTER TABLE MEINF�HRER.PersonaXJugador DROP CONSTRAINT FK_PersonaXJugador_to_Jugador;
ALTER TABLE MEINF�HRER.Notificacion DROP CONSTRAINT FK_Notificacion_to_Receptor;
ALTER TABLE MEINF�HRER.Notificacion DROP CONSTRAINT FK_Notificacion_to_Emisor;
ALTER TABLE MEINF�HRER.Infraccion DROP CONSTRAINT FK_Infraccion_to_Jugador;
ALTER TABLE MEINF�HRER.Calificacion DROP CONSTRAINT FK_Calificacion_to_Jugador;
ALTER TABLE MEINF�HRER.Partido DROP CONSTRAINT FK_Partido_to_Administrador;
ALTER TABLE MEINF�HRER.Jugador DROP CONSTRAINT FK_Jugador_to_Modalidad;
ALTER TABLE MEINF�HRER.Jugador DROP CONSTRAINT FK_Jugador_to_Partido;
ALTER TABLE MEINF�HRER.Jugador DROP CONSTRAINT FK_Jugador_to_Persona;
ALTER TABLE MEINF�HRER.Persona DROP CONSTRAINT FK_Persona_to_Usuario;

--DropTablas
DROP TABLE MEINF�HRER.PersonaXJugador;
DROP TABLE MEINF�HRER.Denegacion;
DROP TABLE MEINF�HRER.Notificacion;
DROP TABLE MEINF�HRER.Infraccion;
DROP TABLE MEINF�HRER.Calificacion;
DROP TABLE MEINF�HRER.Partido;
DROP TABLE MEINF�HRER.Modalidad;
DROP TABLE MEINF�HRER.Jugador;
DROP TABLE MEINF�HRER.Persona;
DROP TABLE MEINF�HRER.Usuario;

--DropStoredProcedures
DROP PROCEDURE MEINF�HRER.LoginUsuario;
DROP PROCEDURE MEINF�HRER.InsertarInteresado;
DROP PROCEDURE MEINF�HRER.EsAdmin;

--DropSchema
USE [DDS2014]
GO
DROP SCHEMA MEINF�HRER
GO