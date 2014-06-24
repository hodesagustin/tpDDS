using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5.Clases
{
    public class Persona
    {
        private string nombre;

        public Persona(String unNombre)
        { nombre = unNombre; }

        public String getNombre() { return nombre; }

        public override string ToString()
        {
            return nombre;
        }
    }
}
