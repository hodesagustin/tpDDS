---------------------------------------
--------------ScritpDeDrop-------------
---------------------------------------

--DropFKs
ALTER TABLE MEINF�HRER.PosicionXInteresado DROP CONSTRAINT FK_PosicionXInteresado_to_Posicion;
ALTER TABLE MEINF�HRER.PosicionXInteresado DROP CONSTRAINT FK_PosicionXInteresado_to_Interesado;
ALTER TABLE MEINF�HRER.Jugador DROP CONSTRAINT FK_Jugador_to_Interesado;
ALTER TABLE MEINF�HRER.Interesado DROP CONSTRAINT FK_Interesado_to_Persona;
ALTER TABLE MEINF�HRER.Persona DROP CONSTRAINT FK_Persona_to_Usuario;

--DropCKs
ALTER TABLE MEINF�HRER.Interesado DROP CONSTRAINT CK_Modalidad;

--DropTablas
DROP TABLE MEINF�HRER.PosicionXInteresado;
DROP TABLE MEINF�HRER.Posicion;
DROP TABLE MEINF�HRER.Partido;
DROP TABLE MEINF�HRER.Jugador;
DROP TABLE MEINF�HRER.Interesado;
DROP TABLE MEINF�HRER.Persona;
DROP TABLE MEINF�HRER.Usuario;

--DropStoredProcedures
DROP PROCEDURE MEINF�HRER.LoginUsuario;
DROP PROCEDURE MEINF�HRER.InsertarInteresado;
DROP PROCEDURE MEINF�HRER.EsAdmin;
DROP PROCEDURE MEINF�HRER.InsertarPosicion;

--DropSchema
USE [DDS2014]
GO
DROP SCHEMA MEINF�HRER
GO