using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5.Clases
{
    public class Administrador : Persona
    {
        private bool aceptaPropuestos;

        public Administrador(String unNombre,bool dejaProponer) 
            : base(unNombre) 
        {
            aceptaPropuestos = dejaProponer;
        }

        public bool getAceptaPropuestos() { return aceptaPropuestos; }

        public override string ToString()
        {
            return this.getNombre() + " (" + aceptaPropuestos + ")";
        }
    }

}
