using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5.Clases
{
    public class Administrador
    {
        //public int id {get; private set;}
        public String nombre { get; private set; }
        public String mail { get; private set; }

        public Administrador(String unNombre, String unMail) 
        {
            nombre = unNombre;
            mail = unMail;
        }

        public override string ToString()
        {
            return nombre + " (" + mail + ")";
        }
    }

}
