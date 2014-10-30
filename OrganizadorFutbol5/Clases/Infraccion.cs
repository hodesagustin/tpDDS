using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5
{
    public partial class Infraccion
    {
        /*
        public String descripcion {get; private set;}
        public DateTime fecha {get; private set;}
        public Partido partido { get; private set; } //CAPAZ ESTá DE MáS
        */
        /*
        public Infraccion(String unaDescripcion,Partido unPartido)
        {
            descripcion = unaDescripcion;
            fecha = DateTime.Now;
            partido = unPartido; //CAPAZ ESTá DE MáS
        }
        */
        public override string ToString()
        {
            return Fecha.ToString() + ": " + Motivo;
        }
    }
}
