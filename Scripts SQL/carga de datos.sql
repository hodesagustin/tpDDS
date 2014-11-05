--administrador

insert into dds_esquema.Administrador (Nombre,Mail) values ('a','admin@gmail.com')

--partidos

insert into dds_esquema.Partido (AdministradorID,Fecha) values (1,'2000-01-01')
insert into dds_esquema.Partido (AdministradorID,Fecha) values (1,'2000-02-01')

--jugadores

insert into dds_esquema.Jugador (Nombre,FechaNacimiento,Mail,Handicap) values ('j1' ,'2000-01-01', 'nico@gmail.com',1)
insert into dds_esquema.Jugador (Nombre,FechaNacimiento,Mail,Handicap) values ('j2' ,'2000-01-01', 'eze@gmail.com',2)
insert into dds_esquema.Jugador (Nombre,FechaNacimiento,Mail,Handicap) values ('j3' ,'2000-01-01', 'nico@gmail.com',3)
insert into dds_esquema.Jugador (Nombre,FechaNacimiento,Mail,Handicap) values ('j4' ,'2000-01-01', 'eze@gmail.com',4)
insert into dds_esquema.Jugador (Nombre,FechaNacimiento,Mail,Handicap) values ('j5' ,'2000-01-01', 'nico@gmail.com',5)
insert into dds_esquema.Jugador (Nombre,FechaNacimiento,Mail,Handicap) values ('j6' ,'2000-01-01', 'eze@gmail.com',6)
insert into dds_esquema.Jugador (Nombre,FechaNacimiento,Mail,Handicap) values ('j7' ,'2000-01-01', 'nico@gmail.com',7)
insert into dds_esquema.Jugador (Nombre,FechaNacimiento,Mail,Handicap) values ('j8' ,'2000-01-01', 'eze@gmail.com',8)
insert into dds_esquema.Jugador (Nombre,FechaNacimiento,Mail,Handicap) values ('j9' ,'2000-01-01', 'nico@gmail.com',9)
insert into dds_esquema.Jugador (Nombre,FechaNacimiento,Mail,Handicap) values ('j10' ,'2000-01-01', 'eze@gmail.com',10)
insert into dds_esquema.Jugador (Nombre,FechaNacimiento,Mail,Handicap) values ('j11' ,'2000-01-01', 'nico@gmail.com',2)
insert into dds_esquema.Jugador (Nombre,FechaNacimiento,Mail,Handicap) values ('j12' ,'2000-01-01', 'eze@gmail.com',6)

--infraccion

insert into dds_esquema.Infraccion (PartidoID,JugadorID,Fecha,Motivo) values (2,1,'2000-01-01','cono')

-- calificacion

insert into dds_esquema.Calificacion (CalificadorID,PartidoID,JugadorID,Puntaje,Descripcion) values (1,2,1,1,'cono')

insert into dds_esquema.Calificacion (CalificadorID,PartidoID,JugadorID,Puntaje,Descripcion) values (2,2,1,4,'cono')

insert into dds_esquema.Calificacion (CalificadorID,PartidoID,JugadorID,Puntaje,Descripcion) values (2,2,2,1,'conazo')

insert into dds_esquema.Calificacion (CalificadorID,PartidoID,JugadorID,Puntaje,Descripcion) values (1,2,2,2,'muy bueno')

insert into dds_esquema.Calificacion (CalificadorID,PartidoID,JugadorID,Puntaje,Descripcion) values (1,1,1,7,'bue')

insert into dds_esquema.Calificacion (CalificadorID,PartidoID,JugadorID,Puntaje,Descripcion) values (2,1,1,2,'cono')

insert into dds_esquema.Calificacion (CalificadorID,PartidoID,JugadorID,Puntaje,Descripcion) values (2,1,2,9,'la movió')

insert into dds_esquema.Calificacion (CalificadorID,PartidoID,JugadorID,Puntaje,Descripcion) values (1,1,2,10,'muy bueno')

-- inscripciones

insert into dds_esquema.Inscripcion (PartidoID,JugadorID,Prioridad,Fecha) values (2,1,1,'2000-01-01')
insert into dds_esquema.Inscripcion (PartidoID,JugadorID,Prioridad,Fecha) values (2,2,1,'2000-01-01')

insert into dds_esquema.Inscripcion (PartidoID,JugadorID,Prioridad,Fecha) values (1,1,1,'2000-01-02')
insert into dds_esquema.Inscripcion (PartidoID,JugadorID,Prioridad,Fecha) values (1,2,1,'2000-01-02')
insert into dds_esquema.Inscripcion (PartidoID,JugadorID,Prioridad,Fecha) values (1,3,1,'2000-01-02')
insert into dds_esquema.Inscripcion (PartidoID,JugadorID,Prioridad,Fecha) values (1,4,1,'2000-01-02')
insert into dds_esquema.Inscripcion (PartidoID,JugadorID,Prioridad,Fecha) values (1,5,1,'2000-01-02')
insert into dds_esquema.Inscripcion (PartidoID,JugadorID,Prioridad,Fecha) values (1,6,1,'2000-01-02')
insert into dds_esquema.Inscripcion (PartidoID,JugadorID,Prioridad,Fecha) values (1,7,1,'2000-01-02')
insert into dds_esquema.Inscripcion (PartidoID,JugadorID,Prioridad,Fecha) values (1,8,1,'2000-01-02')
insert into dds_esquema.Inscripcion (PartidoID,JugadorID,Prioridad,Fecha) values (1,9,1,'2000-01-02')
insert into dds_esquema.Inscripcion (PartidoID,JugadorID,Prioridad,Fecha) values (1,10,1,'2000-01-02')

insert into dds_esquema.InscripcionPendiente(PartidoID,PersonaNombre) values (1,'pepe')
insert into dds_esquema.InscripcionPendiente(PartidoID,PersonaNombre) values (1,'mario')
insert into dds_esquema.InscripcionPendiente(PartidoID,PersonaNombre) values (1,'lucas')
insert into dds_esquema.InscripcionPendiente(PartidoID,PersonaNombre) values (1,'jorge')
insert into dds_esquema.InscripcionPendiente(PartidoID,PersonaNombre) values (1,'raul')
insert into dds_esquema.InscripcionPendiente(PartidoID,PersonaNombre) values (2,'damian')
insert into dds_esquema.InscripcionPendiente(PartidoID,PersonaNombre) values (2,'matias')
insert into dds_esquema.InscripcionPendiente(PartidoID,PersonaNombre) values (2,'roberto')
insert into dds_esquema.InscripcionPendiente(PartidoID,PersonaNombre) values (2,'ramiro')
