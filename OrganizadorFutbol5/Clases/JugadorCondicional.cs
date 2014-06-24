using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5.Clases
{
    public class JugadorCondicional : Jugador
    {
        public JugadorCondicional(string nombreNuevo, decimal calif, Condicion unaCondicion)
            : base(nombreNuevo, calif)
        {
            condicion = unaCondicion;
        }

        private Condicion condicion;

        /*
        void inscripcionCondicional()
        {
            if (condicion.cumple(this.partido))
                this.partido.inscribirCondicional(this);
        }
        */
        public Condicion getCondicion() { return condicion; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
