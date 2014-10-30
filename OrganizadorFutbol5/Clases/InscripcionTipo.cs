using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5
{
    public abstract class InscripcionTipo
    {
        public String nombre { get; protected set; }
        public int prioridad {get; protected set;}

        public InscripcionTipo(String unNombre, int unaPrioridad)
        {
            nombre = unNombre;
            prioridad = unaPrioridad;
        }

        public override string ToString()
        {
            return nombre + "(" + prioridad + ")";
        }
    }
}
