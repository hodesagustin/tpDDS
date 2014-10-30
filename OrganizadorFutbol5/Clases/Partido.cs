using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5
{
    public partial class Partido{
        /*
        public DateTime fecha { get; private set; }
        public List<Inscripcion> inscripciones { get; private set; }
        public List<String> pendientes { get; private set; }
        public List<Rechazo> rechazos { get; private set; }
        public List<Jugador> equipoA { get; private set; }
        public List<Jugador> equipoB { get; private set; }
        public Administrador administrador { get; private set; }
        public Notificador notificador {get; private set;}
        public PartidoEstado estado { get; private set; }
        */
        /*
        public Partido(DateTime unaFecha,Administrador unAdministrador)
        {
            fecha = unaFecha;
            inscripciones = new List<Inscripcion>();
            pendientes = new List<String>();
            rechazos = new List<Rechazo>();
            equipoA = new List<Jugador>();
            equipoB = new List<Jugador>();
            administrador = unAdministrador;
            notificador = new Notificador();
            estado = new PartidoEstadoAbierto();
        }
        */

        public Notificador notificador = new Notificador();
        public List<Jugador> equipoA = new List<Jugador>();
        public List<Jugador> equipoB = new List<Jugador>();

        public void inscribir(Inscripcion unaInscripcion)
        {
            int mayorPrioridad;

            if (Inscripcions.Count < 10)
            {
                inscribirYordenar(unaInscripcion);
                if (Inscripcions.Count == 10)
                    notificador.notify(Administrador.ToString(),"Llegamos a 10");
            }
            else
            {
                mayorPrioridad = getMayorPrioridadInscriptos();
                if (unaInscripcion.getPrioridad() < mayorPrioridad)
                {
                    Inscripcions.Remove(Inscripcions.Last());
                    inscribirYordenar(unaInscripcion);
                }
                else
                    notificador.notify(unaInscripcion.Jugador.Mail,"Ya hay 10 Jugadores con mayor o igual prioridad");
            }
        }

        private int getMayorPrioridadInscriptos()
        {
            return Inscripcions.Max(inscripcion => inscripcion.getPrioridad());
        }

        private void inscribirYordenar(Inscripcion unaInscripcion)
        {
            //Inscripcions.Add(unaInscripcion);
            //Inscripcions = Inscripcions.OrderBy(i => i.getPrioridad()).ThenBy(i => i.Fecha).ToList();
            throw new NotImplementedException();
        }

        public List<Jugador> getJugadoresInscriptos()
        {
            //return Inscripcions.ConvertAll(inscripcion => inscripcion.jugador);
            throw new NotImplementedException();
        }

        public void baja(Jugador jugador)
        {
            Infraccion infraccion = new Infraccion() { Motivo = "Baja sin Reemplazo", Partido = this };

            jugador.addInfraccion(infraccion);
            Inscripcions.Remove(getInscripcionByJugador(jugador));
            if (Inscripcions.Count == 9)
                notificador.notify(Administrador.Mail,"Ya NO somos 10");
        }

        public void baja(Jugador jugador, Jugador reemplazo) 
        {
            Inscripcion inscripcion = getInscripcionByJugador(jugador);
            inscripcion.reemplazarJugador(reemplazo);
        }

        private Inscripcion getInscripcionByJugador(Jugador jugador)
        {
            //return Inscripcions.Find(i => i.jugador.Equals(jugador));
            throw new NotImplementedException();
        }

        public void generarEquipos(CriterioOrdenamiento ordenamiento,CriterioDivision division)
        {

            throw new NotImplementedException();
            
            //List<Jugador> jugadores = this.getJugadoresInscriptos();

            //jugadores = jugadores.OrderByDescending(jugador => ordenamiento.getPuntaje(jugador)).ToList();
            //division.dividir(jugadores, equipoA, equipoB);
        }

        public void aceptarPendiente(Jugador jugadorAceptado, InscripcionTipo inscripcionTipo)
        {
            throw new NotImplementedException();
            
            //inscribir(new Inscripcion(inscripcionTipo, jugadorAceptado));
            //InscripcionPendientes.Remove(jugadorAceptado.Nombre);
        }

        public void rechazarPendiente(String nombre, String motivo)
        {

            throw new NotImplementedException();

            //Rechazo rechazo = new Rechazo() { Motivo = motivo };

            //Rechazos.Add(rechazo);
            //InscripcionPendientes.Remove(nombre);
        }

        public void proponerAmigo(String nombre)
        {
            InscripcionPendiente pendiente = new InscripcionPendiente() { PersonaNombre = nombre, Partido = this };
            
            InscripcionPendientes.Add(pendiente);
        }
    }
}
