using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5
{
    public partial class Inscripcion
    {
        public void reemplazarJugador(Jugador reemplazo)
        {
            Jugador = reemplazo;
            Fecha = System.DateTime.Now;
        }

        public override string ToString()
        {
            return Jugador.ToString() + " - " + Fecha;
        }

        public decimal getPrioridad()
        {
            return this.Prioridad;
        }
    }
}
