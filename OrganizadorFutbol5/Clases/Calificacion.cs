using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5.Clases
{
    class Calificacion
    {
        public String descripcion {get; private set;}
        public decimal puntaje {get; private set;}
        public Partido partido { get; private set; }

        public Calificacion(String unaDescripcion, decimal unPuntaje,Partido unPartido)
        {
            descripcion = unaDescripcion;
            puntaje = unPuntaje;
            partido = unPartido;
        }

        public override string ToString()
        {
            return "(" + puntaje + ") " + descripcion;
        }
    }

    class CalificacionPendiente
    {
        public Partido partido { get; private set; }
        public Jugador jugador { get; private set; }

        public CalificacionPendiente(Partido unPartido, Jugador unJugador)
        {
            partido = unPartido;
            jugador = unJugador;
        }

        public override string ToString()
        {
            return jugador.ToString() + " (" + partido.ToString() + ")";
        }
    }
}
