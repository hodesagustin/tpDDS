--administrador

insert into dds_esquema.Administrador (Nombre,Mail) values ('a','admin@gmail.com')

--partidos

insert into dds_esquema.Partido (AdministradorID,Fecha) values (1,01-01-2000)
insert into dds_esquema.Partido (AdministradorID,Fecha) values (1,01-02-2000)

--jugadores

insert into dds_esquema.Jugador (ID,Nombre,FechaNacimiento,Mail,Handicap) values (1,'nico' ,'2000-01-01', 'nico@gmail.com',3)
insert into dds_esquema.Jugador (ID,Nombre,FechaNacimiento,Mail,Handicap) values (2,'eze' ,'2000-01-01', 'eze@gmail.com',5)

--infraccion

insert into dds_esquema.Infraccion (PartidoID,JugadorID,Fecha,Motivo) values (2,1,'2000-01-01','cono')

-- calificacion

insert into dds_esquema.Calificacion (CalificadorID,PartidoID,JugadorID,Puntaje,Descripcion) values (1,2,1,1,'cono')

insert into dds_esquema.Calificacion (CalificadorID,PartidoID,JugadorID,Puntaje,Descripcion) values (2,2,1,4,'cono')

insert into dds_esquema.Calificacion (CalificadorID,PartidoID,JugadorID,Puntaje,Descripcion) values (2,2,2,1,'conazo')

insert into dds_esquema.Calificacion (CalificadorID,PartidoID,JugadorID,Puntaje,Descripcion) values (1,2,2,2,'muy bueno')

insert into dds_esquema.Calificacion (CalificadorID,PartidoID,JugadorID,Puntaje,Descripcion) values (1,3,1,7,'bue')

insert into dds_esquema.Calificacion (CalificadorID,PartidoID,JugadorID,Puntaje,Descripcion) values (2,3,1,2,'cono')

insert into dds_esquema.Calificacion (CalificadorID,PartidoID,JugadorID,Puntaje,Descripcion) values (2,3,2,9,'la movió')

insert into dds_esquema.Calificacion (CalificadorID,PartidoID,JugadorID,Puntaje,Descripcion) values (1,3,2,10,'muy bueno')

-- inscripciones

insert into dds_esquema.Inscripcion (PartidoID,JugadorID,Fecha) values (2,1,'2000-01-01')
insert into dds_esquema.Inscripcion (PartidoID,JugadorID,Fecha) values (2,2,'2000-01-01')

insert into dds_esquema.Inscripcion (PartidoID,JugadorID,Fecha) values (3,1,'2000-01-02')
insert into dds_esquema.Inscripcion (PartidoID,JugadorID,Fecha) values (3,2,'2000-01-02')