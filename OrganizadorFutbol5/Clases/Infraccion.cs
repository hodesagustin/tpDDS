using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5
{
    public partial class Infraccion
    {

        public override string ToString()
        {
            return Fecha.ToString() + ": " + Motivo;
        }
    }
}
