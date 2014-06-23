using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5.Clases
{
    public class JugadorCondicional : Jugador
    {
        public JugadorCondicional(string nombreNuevo,decimal calif,Condicion unaCondicion) : base (nombreNuevo,calif)
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
