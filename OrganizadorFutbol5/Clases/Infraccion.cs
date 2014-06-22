using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5.Clases
{
    public class Infraccion
    {
        public string descripcion;

        public Infraccion(string causa)
        {
            descripcion = causa;
        }
    }
}
