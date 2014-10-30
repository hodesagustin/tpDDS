using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5
{
    public class InscripcionTipoCondicional : InscripcionTipo
    {
        Condicion condicion;

        public InscripcionTipoCondicional(Condicion cond) : base("Condicional",3)
        {
            condicion = cond;
        }
    }
}
