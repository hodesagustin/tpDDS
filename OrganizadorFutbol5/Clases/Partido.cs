using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5.Clases
{
    public class Partido
    {
        private string nombre;
        private List<Jugador> inscriptosStandard = new List<Jugador>();
        private List<JugadorCondicional> inscriptosCondicionales = new List<JugadorCondicional>();
        private List<Jugador> inscriptosSolidarios = new List<Jugador>();
        private List<Jugador> equipoA = new List<Jugador>();
        private List<Jugador> equipoB = new List<Jugador>();
        private List<Rechazo> rechazos = new List<Rechazo>();
        private DateTime fecha;
        private Notificador notificador = new Notificador();
        private Administrador administrador;

        public Partido(string nuevoNombre, DateTime unaFecha,Administrador unAdmin)
        {
           nombre = nuevoNombre;
           fecha = unaFecha;
           administrador = unAdmin;
        }

        private bool estaInscripto(Jugador jugador)
        {
            return inscriptosStandard.Contains(jugador) || inscriptosSolidarios.Contains(jugador);
        }
        private bool estaInscripto(JugadorCondicional jugadorCondicional)
        {
            return inscriptosCondicionales.Contains(jugadorCondicional);
        }

        public void inscribirStandard(Jugador jugador)
        {
            if (aceptaInscripcion())
            {
                if (!estaInscripto(jugador))
                    anotar(jugador, inscriptosStandard);
                else
                    throw new Exception("Ya esta Inscripto");
            }
        }

        public void inscribirSolidario(Jugador jugador)
        {
            if (aceptaInscripcion())
            {
                if (!estaInscripto(jugador))
                    anotar(jugador, inscriptosSolidarios);
                else
                    throw new Exception("Ya esta Inscripto");
            }
        }

        public void inscribirCondicional(JugadorCondicional jugadorCondicional)
        {
            if (aceptaInscripcion())
            {
                if (!estaInscripto(jugadorCondicional))
                    anotar(jugadorCondicional, inscriptosCondicionales);
                else
                    throw new Exception("Ya esta Inscripto");
            } 
        }

        public void proponerJugador(Jugador jugador,String modalidad)
        {
            if (administrador.getAceptaPropuestos())
            {
                if (modalidad.Equals("Standard"))
                    this.inscribirStandard(jugador);
                else if (modalidad.Equals("Solidario"))
                    this.inscribirSolidario(jugador);
                else
                {
                    throw new Exception("Error en Modalidad");
                }
            }
            else
            {
                rechazos.Add(new Rechazo("El Administrador no acepta Propuesto a " + jugador.ToString()));
                throw new Exception("El Administrador no acepta Propuestos");
            }
        }
        public void proponerJugador(JugadorCondicional jugadorCondicional)
        {
            if (administrador.getAceptaPropuestos())
            {
                this.inscribirCondicional(jugadorCondicional);
            }
            else
            {
                {
                    rechazos.Add(new Rechazo("El Administrador no acepta Propuesto a " + jugadorCondicional.ToString()));
                    throw new Exception("El Administrador no acepta Propuestos");
                }
            }
        }

        bool aceptaInscripcion()
        {
            return (inscriptosStandard.Count < 10);
        }

        public int getCantidadDeInscriptos()
        {
            return (inscriptosStandard.Count + inscriptosSolidarios.Count
                    + inscriptosCondicionales.Count);
        }

        void anotar(Jugador jugador, List<Jugador> lista)
        {
            lista.Add(jugador);
            jugador.avisarInscripcion(this);
            if (getCantidadDeInscriptos() == 10)
                notificador.notify("Se ha llegado a los 10 jugadores inscriptos", administrador);
        }
        void anotar(JugadorCondicional jugadorCondicional, List<JugadorCondicional> lista)
        {
            lista.Add(jugadorCondicional);
            jugadorCondicional.avisarInscripcion(this);
            if (getCantidadDeInscriptos() == 10)
                notificador.notify("Se ha llegado a los 10 jugadores inscriptos", administrador);
        }

        public void darDeBaja(Jugador jugador)
        {
            Infraccion infraccion = new Infraccion("Baja sin reemplazo");
            List<Jugador> lista = getListaSegunJugador(jugador);

            lista.Remove(jugador);
            jugador.agregarInfraccion(infraccion);
            if (getCantidadDeInscriptos() == 9)
                notificador.notify("Ha dejado de haber 10 jugadores inscriptos", administrador);
        }
        public void darDeBaja(JugadorCondicional jugadorCondicional)
        {
            Infraccion infraccion = new Infraccion("Baja sin reemplazo");
            List<JugadorCondicional> lista = getListaSegunJugador(jugadorCondicional);

            lista.Remove(jugadorCondicional);
            jugadorCondicional.agregarInfraccion(infraccion);
            if (getCantidadDeInscriptos() == 9)
                notificador.notify("Ha dejado de haber 10 jugadores inscriptos", administrador);
        }

        public void reemplazar(Jugador jugador, Jugador reemplazo)
        {
            List<Jugador> lista = getListaSegunJugador(jugador);
            lista.Remove(jugador);
            lista.Add(reemplazo);
        }
        public void reemplazar(JugadorCondicional jugadorCondicional, JugadorCondicional reemplazoCondicional)
        {
            List<JugadorCondicional> lista = getListaSegunJugador(jugadorCondicional);
            lista.Remove(jugadorCondicional);
            lista.Add(reemplazoCondicional);
        }

        public List<Jugador> getListaSegunJugador(Jugador jugador)
        {
            if (inscriptosStandard.Contains(jugador))
                return inscriptosStandard;
            else
                return inscriptosSolidarios;
        }
        public List<JugadorCondicional> getListaSegunJugador(JugadorCondicional jugadorCondicional)
        { return inscriptosCondicionales; }

        public override string ToString()
        {
            return this.nombre + " : " + this.fecha;
        }

        public String getNombre(){ return nombre; }
        public Administrador getAdministrador() { return this.administrador; }
        public DateTime getFecha() { return this.fecha; }
        public List<Jugador> getInscriptosStandard() { return inscriptosStandard; }
        public List<Jugador> getInscriptosSolidarios() { return inscriptosSolidarios; }
        public List<JugadorCondicional> getInscriptosCondicionales() { return inscriptosCondicionales; }
        public Notificador getNotificador() { return notificador; }
        public List<Rechazo> getRechazos() { return rechazos; }
    }
}
