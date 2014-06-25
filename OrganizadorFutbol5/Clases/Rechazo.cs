using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5.Clases
{
    public class Rechazo
    {
        private String motivo;
        private DateTime fecha;

        public Rechazo(String unMotivo)
        {
            motivo = unMotivo;
            fecha = DateTime.Now;
        }

        public override string ToString()
        {
            return fecha + ": " + motivo;
        }
    }
}
