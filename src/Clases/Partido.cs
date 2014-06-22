using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5.Clases
{
    public class Partido
    {
        string nombre;
        List<Jugador> inscriptosStandard;
        List<Jugador> inscriptosCondicionales;
        List<Jugador> inscriptosSolidarios;
        List<Jugador> equipoA;
        List<Jugador> equipoB;
        public DateTime fecha;
        Notificador notificador;
        Administrador admin;

        public Partido(string nuevoNombre)
        {
           nombre = nuevoNombre;     
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

        public void inscribirCondicional(Jugador jugador)
        {
            if (aceptaInscripcion())
            {
                anotar(jugador,inscriptosCondicionales);
            }
        }
                
        bool aceptaInscripcion()
        {
            return (inscriptosStandard.Capacity < 10);
        }

        int cantidadDeInscriptos()
        {
            return (inscriptosStandard.Capacity + inscriptosSolidarios.Capacity
                    + inscriptosCondicionales.Capacity);
        }

        void anotar(Jugador jugador, List<Jugador> lista)
        {
            lista.Add(jugador);
            if (cantidadDeInscriptos() == 10)
                notificador.notify("Se ha llegado a los 10 jugadores inscriptos", admin);
        }

        void darDeBaja(Jugador jugador)
        {
            Infraccion infraccion = new Infraccion("Baja sin reemplazo");
            List<Jugador> lista = getListaSegunJugador(jugador);

            lista.Remove(jugador);
            jugador.agregarInfraccion(infraccion);
            if (cantidadDeInscriptos() == 9)
                notificador.notify("Ha dejado de haber 10 jugadores inscriptos", admin);
        }

        void darDeBaja(Jugador jugador, Jugador reemplazo)
        {
            List<Jugador> lista = getListaSegunJugador(jugador);
            lista.Remove(jugador);
            lista.Add(reemplazo);
        }

        public List<Jugador> getListaSegunJugador(Jugador jugador)
        {
            if(inscriptosStandard.Contains(jugador))
                return inscriptosStandard;
            else
                if(inscriptosSolidarios.Contains(jugador))
                    return inscriptosSolidarios;
                else         
                    return inscriptosCondicionales;
        }

        public String getNombre()
        { return nombre; }
    }
}
