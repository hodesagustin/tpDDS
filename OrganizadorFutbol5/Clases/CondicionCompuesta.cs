using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5.Clases
{
    class CondicionCompuesta : Condicion
    {
        private List<Condicion> condiciones = new List<Condicion>();

        public CondicionCompuesta() : base() { }
        public CondicionCompuesta(List<Condicion> unasCondiciones)
        {
            condiciones = unasCondiciones;
        }

        public void agregarCondicion(Condicion unaCondicion)
        {
            condiciones.Add(unaCondicion);
        }

        public bool cumple(Partido partido)
        {
            return condiciones.All(condicion => condicion.cumple(partido));
        }
    }
}
