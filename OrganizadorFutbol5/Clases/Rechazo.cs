using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5.Clases
{
    class Rechazo
    {
        public String descripcion {get; private set;}
        public DateTime fecha { get; private set; }

        public Rechazo(String unaDescripcion)
        {
            descripcion = unaDescripcion;
            fecha = DateTime.Now;
        }

        public override string ToString()
        {
            return descripcion;
        }
    }
}
