using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5.Clases
{
    class CriterioOrdenamientoPorPromedio:CriterioOrdenamiento
    {
        public int cantidadPartidos {get; private set;}

        public CriterioOrdenamientoPorPromedio(int unaCantidad)
        {
            cantidadPartidos = unaCantidad;
        }

        #region CriterioOrdenamiento Members

        public double getPuntaje(Jugador jugador)
        {
            return jugador.getPromedio(cantidadPartidos);
        }

        #endregion
    }
}
