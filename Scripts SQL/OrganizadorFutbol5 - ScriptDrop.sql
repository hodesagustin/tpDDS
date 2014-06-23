---------------------------------------
--------------ScritpDeDrop-------------
---------------------------------------

--DropFKs
ALTER TABLE MEINFÜHRER.PosicionXInteresado DROP CONSTRAINT FK_PosicionXInteresado_to_Posicion;
ALTER TABLE MEINFÜHRER.PosicionXInteresado DROP CONSTRAINT FK_PosicionXInteresado_to_Interesado;
ALTER TABLE MEINFÜHRER.Jugador DROP CONSTRAINT FK_Jugador_to_Interesado;
ALTER TABLE MEINFÜHRER.Interesado DROP CONSTRAINT FK_Interesado_to_Persona;
ALTER TABLE MEINFÜHRER.Persona DROP CONSTRAINT FK_Persona_to_Usuario;

--DropCKs
ALTER TABLE MEINFÜHRER.Interesado DROP CONSTRAINT CK_Modalidad;

--DropTablas
DROP TABLE MEINFÜHRER.PosicionXInteresado;
DROP TABLE MEINFÜHRER.Posicion;
DROP TABLE MEINFÜHRER.Partido;
DROP TABLE MEINFÜHRER.Jugador;
DROP TABLE MEINFÜHRER.Interesado;
DROP TABLE MEINFÜHRER.Persona;
DROP TABLE MEINFÜHRER.Usuario;

--DropStoredProcedures
DROP PROCEDURE MEINFÜHRER.LoginUsuario;
DROP PROCEDURE MEINFÜHRER.InsertarInteresado;
DROP PROCEDURE MEINFÜHRER.EsAdmin;
DROP PROCEDURE MEINFÜHRER.InsertarPosicion;

--DropSchema
USE [DDS2014]
GO
DROP SCHEMA MEINFÜHRER
GO