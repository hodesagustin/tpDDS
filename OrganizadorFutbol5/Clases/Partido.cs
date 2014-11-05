using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5
{
    public partial class Partido{
        public Notificador notificador = new Notificador();
        public List<Jugador> equipoA = new List<Jugador>();
        public List<Jugador> equipoB = new List<Jugador>();
        DataBaseDataContext db = new DataBaseDataContext();

        public void inscribir(Inscripcion unaInscripcion)
        {
            decimal mayorPrioridad;

            if (Inscripcions.Count < 10)
            {

                db.Inscripcions.InsertOnSubmit(unaInscripcion);
                db.SubmitChanges();

                if (Inscripcions.Count == 10)
                    notificador.notify(Administrador.ToString(),"Llegamos a 10");
            }
            else
            {
                mayorPrioridad = getMayorPrioridadInscriptos();
                if (unaInscripcion.getPrioridad() < mayorPrioridad)
                {
                    Inscripcion aEliminar = (from i in db.Inscripcions
                                                where i.PartidoID == this.ID && i.Prioridad == mayorPrioridad
                                                orderby i.Fecha descending
                                                select i).First();
                    Inscripcion aAgregar = new Inscripcion()
                    {
                        PartidoID = this.ID,
                        JugadorID = unaInscripcion.JugadorID,
                        Prioridad = unaInscripcion.Prioridad,
                        Fecha = System.DateTime.Now
                    };
                    db.Inscripcions.InsertOnSubmit(aAgregar);

                    db.Inscripcions.DeleteOnSubmit(aEliminar);

                    db.SubmitChanges();
                }
                else
                    if (unaInscripcion.Jugador != null)
                        notificador.notify(unaInscripcion.Jugador.Mail, "Ya hay 10 Jugadores con mayor o igual prioridad");
                    else
                    {
                        Jugador jugador = (from j in db.Jugadors
                                           where j.ID == unaInscripcion.JugadorID
                                           select j).First();
                        notificador.notify(jugador.Mail, "Ya hay 10 Jugadores con mejor o igual prioridad");
                    }
            }
        }

        private decimal getMayorPrioridadInscriptos()
        {
            return Inscripcions.Max(inscripcion => inscripcion.getPrioridad());
        }

        public List<Jugador> getJugadoresInscriptos()
        {
            List<Jugador> jugadores = new List<Jugador>();

            foreach (Inscripcion inscripcion in this.Inscripcions)
            {
                jugadores.Add( inscripcion.Jugador);
            };

            return jugadores;
        }

        public void baja(Jugador jugador)
        {
            Infraccion infraccion = new Infraccion() { Motivo = "Baja sin Reemplazo", Partido = this, Fecha = System.DateTime.Now, Jugador = jugador };

            jugador.addInfraccion(infraccion);

            Inscripcion inscripcion = (from i in db.Inscripcions
                                       where i.JugadorID == jugador.ID && i.PartidoID == this.ID
                                       select i).First();
            db.Inscripcions.DeleteOnSubmit(inscripcion);
            db.SubmitChanges();

            if (Inscripcions.Count == 9)
                notificador.notify(Administrador.Mail,"Ya NO somos 10");
        }

        public void baja(Jugador jugador, String reemplazo) 
        {
            Inscripcion inscripcion = (from i in db.Inscripcions
                                       where i.JugadorID == jugador.ID && i.PartidoID == this.ID
                                       select i).First();

            InscripcionPendiente inscripcionPendiente = new InscripcionPendiente()
            {
                PartidoID = this.ID,
                PersonaNombre = reemplazo
            };

            db.Inscripcions.DeleteOnSubmit(inscripcion);
            db.InscripcionPendientes.InsertOnSubmit(inscripcionPendiente);
            db.SubmitChanges();
        }

        public void generarEquipos(CriterioOrdenamiento ordenamiento,CriterioDivision division)
        {
            //Borro los equipos que ya estaban generados
            var partidoEquipos = from pe in db.PartidoEquipos
                           where pe.PartidoID == this.ID
                           select pe;
            db.PartidoEquipos.DeleteAllOnSubmit(partidoEquipos); 
            db.SubmitChanges();

            List<Jugador> jugadores = this.getJugadoresInscriptos();

            jugadores = jugadores.OrderByDescending(jugador => ordenamiento.getPuntaje(jugador)).ToList();
            division.dividir(jugadores, equipoA, equipoB);

            foreach (Jugador jug in equipoA)
            {
                PartidoEquipo partidoEquipo = new PartidoEquipo() { PartidoID = this.ID, JugadorID = jug.ID, Equipo = 'A'};
                db.PartidoEquipos.InsertOnSubmit(partidoEquipo);
                db.SubmitChanges();
            }

            foreach (Jugador jug in equipoB)
            {
                PartidoEquipo partidoEquipo = new PartidoEquipo() { PartidoID = this.ID, JugadorID = jug.ID, Equipo = 'B'};
                db.PartidoEquipos.InsertOnSubmit(partidoEquipo);
                db.SubmitChanges();
            }
        }

        public void aceptarPendiente(Jugador jugadorAceptado, InscripcionTipo inscripcionTipo)
        {
            Inscripcion inscripcion = new Inscripcion() { Jugador = jugadorAceptado, Prioridad = inscripcionTipo.prioridad, Fecha = System.DateTime.Now };
            
            this.inscribir(inscripcion);
        }

        public void rechazarPendiente(String nombre, String motivo)
        {
            //Creo el Rechazo
            Rechazo rechazo = new Rechazo() { Partido = this, PersonaNombre = nombre, Fecha = System.DateTime.Now, Motivo = motivo };
            db.Rechazos.InsertOnSubmit(rechazo);
            db.SubmitChanges();
            //Elimino el Pendiente
            InscripcionPendiente pendienteRechazado = this.InscripcionPendientes.Where(ip => ip.PersonaNombre == nombre).First();
            db.InscripcionPendientes.DeleteOnSubmit(pendienteRechazado);
            db.SubmitChanges();
        }

        public void proponerAmigo(String nombre)
        {
            InscripcionPendiente pendiente = new InscripcionPendiente() { PersonaNombre = nombre, PartidoID=this.ID };

            db.InscripcionPendientes.InsertOnSubmit(pendiente);
            db.SubmitChanges();
        }
    }
}
