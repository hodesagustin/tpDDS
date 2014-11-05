--administrador

insert into dds_esquema.Administrador (Nombre,Mail) values ('a','admin@gmail.com')

--partidos

insert into dds_esquema.Partido (AdministradorID,Fecha) values (1,'2000-01-01')
insert into dds_esquema.Partido (AdministradorID,Fecha) values (1,'2000-02-01')

--jugadores

insert into dds_esquema.Jugador (ID,Nombre,FechaNacimiento,Mail,Handicap) values (1,'j1' ,'2000-01-01', 'nico@gmail.com',3)
insert into dds_esquema.Jugador (ID,Nombre,FechaNacimiento,Mail,Handicap) values (2,'j2' ,'2000-01-01', 'eze@gmail.com',5)
insert into dds_esquema.Jugador (ID,Nombre,FechaNacimiento,Mail,Handicap) values (3,'j3' ,'2000-01-01', 'nico@gmail.com',3)
insert into dds_esquema.Jugador (ID,Nombre,FechaNacimiento,Mail,Handicap) values (4,'j4' ,'2000-01-01', 'eze@gmail.com',5)
insert into dds_esquema.Jugador (ID,Nombre,FechaNacimiento,Mail,Handicap) values (5,'j5' ,'2000-01-01', 'nico@gmail.com',3)
insert into dds_esquema.Jugador (ID,Nombre,FechaNacimiento,Mail,Handicap) values (6,'j6' ,'2000-01-01', 'eze@gmail.com',5)
insert into dds_esquema.Jugador (ID,Nombre,FechaNacimiento,Mail,Handicap) values (7,'j7' ,'2000-01-01', 'nico@gmail.com',3)
insert into dds_esquema.Jugador (ID,Nombre,FechaNacimiento,Mail,Handicap) values (8,'j8' ,'2000-01-01', 'eze@gmail.com',5)
insert into dds_esquema.Jugador (ID,Nombre,FechaNacimiento,Mail,Handicap) values (9,'j9' ,'2000-01-01', 'nico@gmail.com',3)
insert into dds_esquema.Jugador (ID,Nombre,FechaNacimiento,Mail,Handicap) values (10,'j10' ,'2000-01-01', 'eze@gmail.com',5)
insert into dds_esquema.Jugador (ID,Nombre,FechaNacimiento,Mail,Handicap) values (11,'j11' ,'2000-01-01', 'nico@gmail.com',3)
insert into dds_esquema.Jugador (ID,Nombre,FechaNacimiento,Mail,Handicap) values (12,'j12' ,'2000-01-01', 'eze@gmail.com',5)

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

