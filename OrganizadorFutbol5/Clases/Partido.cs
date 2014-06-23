using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5.Clases
{
    public class Partido
    {
        string nombre;
        List<Jugador> inscriptosStandard = new List<Jugador>();
        List<JugadorCondicional> inscriptosCondicionales = new List<JugadorCondicional>();
        List<Jugador> inscriptosSolidarios = new List<Jugador>();
        List<Jugador> equipoA = new List<Jugador>();
        List<Jugador> equipoB = new List<Jugador>();
        public DateTime fecha;
        Notificador notificador = new Notificador();
        Administrador admin = new Administrador();

        public Partido(string nuevoNombre, DateTime unaFecha)
        {
           nombre = nuevoNombre;
           fecha = unaFecha;
        }

        public void inscribirStandard(Jugador jugador)
        {
            if (aceptaInscripcion())
            {
                anotar(jugador,inscriptosStandard);
            }
        }

        public void inscribirSolidario(Jugador jugador)
        {
            if (aceptaInscripcion())
            {
                anotar(jugador,inscriptosSolidarios);
            }
        }

        public void inscribirCondicional(JugadorCondicional jugadorCondicional)
        {
            if (aceptaInscripcion())
            {
                anotar(jugadorCondicional,inscriptosCondicionales);
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
            if (getCantidadDeInscriptos() == 10)
                notificador.notify("Se ha llegado a los 10 jugadores inscriptos", admin);
        }
        void anotar(JugadorCondicional jugadorCondicional, List<JugadorCondicional> lista)
        {
            lista.Add(jugadorCondicional);
            if (getCantidadDeInscriptos() == 10)
                notificador.notify("Se ha llegado a los 10 jugadores inscriptos", admin);
        }

        public void darDeBaja(Jugador jugador)
        {
            Infraccion infraccion = new Infraccion("Baja sin reemplazo");
            List<Jugador> lista = getListaSegunJugador(jugador);

            lista.Remove(jugador);
            jugador.agregarInfraccion(infraccion);
            if (getCantidadDeInscriptos() == 9)
                notificador.notify("Ha dejado de haber 10 jugadores inscriptos", admin);
        }
        public void darDeBaja(JugadorCondicional jugadorCondicional)
        {
            Infraccion infraccion = new Infraccion("Baja sin reemplazo");
            List<JugadorCondicional> lista = getListaSegunJugador(jugadorCondicional);

            lista.Remove(jugadorCondicional);
            jugadorCondicional.agregarInfraccion(infraccion);
            if (getCantidadDeInscriptos() == 9)
                notificador.notify("Ha dejado de haber 10 jugadores inscriptos", admin);
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

        public String getNombre()
        { return nombre; }

        public List<Jugador> getInscriptosStandard()
        { return inscriptosStandard; }
        public List<Jugador> getInscriptosSolidarios()
        { return inscriptosSolidarios; }
        public List<JugadorCondicional> getInscriptosCondicionales()
        { return inscriptosCondicionales; }
    }
}
