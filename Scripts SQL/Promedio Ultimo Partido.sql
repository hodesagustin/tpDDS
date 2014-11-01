select JugadoresUltimoPartido.Jugador, AVG (C.Puntaje) as Promedio from

(select J.ID as Jugador,I.PartidoID as Partido,MAX(I.Fecha) as Fecha from dds_esquema.Inscripcion as I, dds_esquema.Jugador as J
where I.JugadorID = J.ID
group by J.ID,I.PartidoID) as JugadoresUltimoPartido , dds_esquema.Calificacion as C

where Jugador = C.JugadorID

Group By JugadoresUltimoPartido.Jugador