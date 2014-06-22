using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5.Clases
{
    public class JugadorCondicional : Jugador
    {
        public JugadorCondicional(string nombreNuevo,Condicion unaCondicion) : base (nombreNuevo)
        {
            condicion = unaCondicion;
        }
        
        public Condicion condicion;

        void inscripcionCondicional()
        {
            if (condicion.cumple(this.partido))
                this.partido.inscribirCondicional(this);
        }
     }
}
