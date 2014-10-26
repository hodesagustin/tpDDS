using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5.Clases
{
    class Partido{

        public DateTime fecha { get; private set; }
        public List<Inscripcion> inscripciones { get; private set; }
        public List<String> pendientes { get; private set; }
        public List<Rechazo> rechazos { get; private set; }
        public List<Jugador> equipoA { get; private set; }
        public List<Jugador> equipoB { get; private set; }
        public Administrador administrador { get; private set; }
        public Notificador notificador {get; private set;}
        public PartidoEstado estado { get; private set; }

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

        public void inscribir(Inscripcion unaInscripcion)
        {
            int mayorPrioridad;

            if (inscripciones.Count < 10)
            {
                inscribirYordenar(unaInscripcion);
                if (inscripciones.Count == 10)
                    notificador.notify(administrador.ToString(),"Llegamos a 10");
            }
            else
            {
                mayorPrioridad = getMayorPrioridadInscriptos();
                if (unaInscripcion.getPrioridad() < mayorPrioridad)
                {
                    inscripciones.Remove(inscripciones.Last());
                    inscribirYordenar(unaInscripcion);
                }
                else
                    notificador.notify(unaInscripcion.jugador.mail,"Ya hay 10 Jugadores con mayor o igual prioridad");
            }
        }

        private int getMayorPrioridadInscriptos()
        {
            return inscripciones.Max(inscripcion => inscripcion.getPrioridad());
        }

        private void inscribirYordenar(Inscripcion unaInscripcion)
        {
            inscripciones.Add(unaInscripcion);
            inscripciones = inscripciones.OrderBy(i => i.getPrioridad()).ThenBy(i => i.fecha).ToList();
        }

        public List<Jugador> getJugadoresInscriptos()
        {
            return inscripciones.ConvertAll(inscripcion => inscripcion.jugador);
        }

        public void baja(Jugador jugador)
        {
            Infraccion infraccion = new Infraccion("Baja sin Reemplazo", this);

            jugador.addInfraccion(infraccion);
            inscripciones.Remove(getInscripcionByJugador(jugador));
            if (inscripciones.Count == 9)
                notificador.notify(administrador.mail,"Ya NO somos 10");
        }

        public void baja(Jugador jugador, Jugador reemplazo) 
        {
            Inscripcion inscripcion = getInscripcionByJugador(jugador);
            inscripcion.reemplazarJugador(reemplazo);
        }

        private Inscripcion getInscripcionByJugador(Jugador jugador)
        {
            return inscripciones.Find(i => i.jugador.Equals(jugador));
        }

        public void generarEquipos(CriterioOrdenamiento ordenamiento,CriterioDivision division)
        {
            List<Jugador> jugadores = this.getJugadoresInscriptos();

            jugadores = jugadores.OrderByDescending(jugador => ordenamiento.getPuntaje(jugador)).ToList();
            division.dividir(jugadores, equipoA, equipoB);
        }

        public void aceptarPendiente(Jugador jugadorAceptado, InscripcionTipo inscripcionTipo)
        {
            inscribir(new Inscripcion(inscripcionTipo,jugadorAceptado));
            pendientes.Remove(jugadorAceptado.nombre);
        }

        public void rechazarPendiente(String nombre, String motivo)
        {
            Rechazo rechazo = new Rechazo(motivo);

            rechazos.Add(rechazo);
            pendientes.Remove(nombre);
        }

        public void proponerAmigo(String nombre)
        {
            pendientes.Add(nombre);
        }
    }
}
