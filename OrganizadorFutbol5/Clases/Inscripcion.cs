using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5.Clases
{
    class Inscripcion
    {
        public InscripcionTipo tipo { get; private set; }
        public Jugador jugador {get; private set;}
        public DateTime fecha  {get; private set;}

        public Inscripcion(InscripcionTipo unTipo, Jugador unJugador)
        {
            tipo = unTipo;
            jugador = unJugador;
            fecha =  System.DateTime.Now;
        }

        public void reemplazarJugador(Jugador reemplazo)
        {
            jugador = reemplazo;
        }

        public override string ToString()
        {
            return jugador.ToString() + " - " + tipo + " - " + fecha;
        }

        public int getPrioridad()
        {
            return tipo.prioridad;
        }
    }
}
