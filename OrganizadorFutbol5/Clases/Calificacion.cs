using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5.Clases
{
    public class Calificacion
    {
        public Calificacion(String unaDescripcion, decimal unPuntaje)
        {
            descripcion = unaDescripcion;
            puntaje = unPuntaje;
        }

        private String descripcion;
        private decimal puntaje;

        public decimal getPuntaje() { return puntaje; }
        public override string ToString()
        {
            return "(" + puntaje + ") " + descripcion;
        }
    }
}
