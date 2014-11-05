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
                    Inscripcion inscripcion = this.Inscripcions.Where(i => i.Prioridad == mayorPrioridad).OrderBy(i => i.Fecha).Last();
                    inscripcion.JugadorID = unaInscripcion.JugadorID;
                    inscripcion.Fecha = unaInscripcion.Fecha;
                    db.SubmitChanges();
                }
                else
                    notificador.notify(unaInscripcion.Jugador.Mail,"Ya hay 10 Jugadores con mayor o igual prioridad");
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
            Infraccion infraccion = new Infraccion() { Motivo = "Baja sin Reemplazo", Partido = this };

            jugador.addInfraccion(infraccion);
            db.Inscripcions.DeleteOnSubmit(getInscripcionByJugador(jugador));
            db.SubmitChanges();
            if (Inscripcions.Count == 9)
                notificador.notify(Administrador.Mail,"Ya NO somos 10");
        }

        public void baja(Jugador jugador, Jugador reemplazo) 
        {
            Inscripcion inscripcion = getInscripcionByJugador(jugador);
            inscripcion.JugadorID = reemplazo.ID;
            db.SubmitChanges();
        }

        private Inscripcion getInscripcionByJugador(Jugador jugador)
        {
            return this.Inscripcions.Where(i => i.JugadorID == jugador.ID).First();
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
                PartidoEquipo partidoEquipo = new PartidoEquipo() { Partido = this, Jugador = jug, Equipo = 'A'};
                db.PartidoEquipos.InsertOnSubmit(partidoEquipo);
                db.SubmitChanges();
            }

            foreach (Jugador jug in equipoB)
            {
                PartidoEquipo partidoEquipo = new PartidoEquipo() { Partido = this, Jugador = jug, Equipo = 'B'};
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
            InscripcionPendiente pendiente = new InscripcionPendiente() { PersonaNombre = nombre, Partido = this };

            db.InscripcionPendientes.InsertOnSubmit(pendiente);
            db.SubmitChanges();
        }
    }
}
