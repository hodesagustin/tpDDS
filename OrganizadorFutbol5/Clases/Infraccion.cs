﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5.Clases
{
    public class Infraccion
    {
        public string descripcion;
        DateTime fecha;

        public Infraccion(string causa)
        {
            descripcion = causa;
            fecha = DateTime.Now;
        }

        public override string ToString()
        {
            return fecha.ToString() + ": " + descripcion;
        }
    }
}
