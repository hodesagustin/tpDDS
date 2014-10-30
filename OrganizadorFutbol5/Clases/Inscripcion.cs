using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5
{
    public partial class Inscripcion
    {
        /*
        public InscripcionTipo tipo { get; private set; }
        public Jugador jugador {get; private set;}
        public DateTime fecha  {get; private set;}
        */
        /*
        public Inscripcion(InscripcionTipo unTipo, Jugador unJugador)
        {
            tipo = unTipo;
            jugador = unJugador;
            fecha =  System.DateTime.Now;
        }
        */
        public void reemplazarJugador(Jugador reemplazo)
        {
            Jugador = reemplazo;
        }

        public override string ToString()
        {
            //return Jugador.ToString() + " - " + tipo + " - " + fecha;
            return Jugador.ToString() + " - " + Fecha;
        }

        public int getPrioridad()
        {
            throw new NotImplementedException();//return tipo.prioridad;
        }
    }
}
