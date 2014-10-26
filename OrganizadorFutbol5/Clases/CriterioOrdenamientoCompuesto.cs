using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5.Clases
{
    class CriterioOrdenamientoCompuesto:CriterioOrdenamiento
    {
        public List<CriterioOrdenamiento> criteriosOrdenamiento { get; private set; }

        /*public CriterioOrdenamientoCompuesto()
        {
            criteriosOrdenamiento = new List<CriterioOrdenamiento>();
        }
        */

        public CriterioOrdenamientoCompuesto(List<CriterioOrdenamiento> unosCriteriosOrdenamientos)
        {
            criteriosOrdenamiento = unosCriteriosOrdenamientos;
        }

        #region CriterioOrdenamiento Members

        public double getPuntaje(Jugador jugador)
        {
            double puntaje = 0.0;

            foreach (CriterioOrdenamiento criterioOrdenamiento in criteriosOrdenamiento)
            {
                puntaje += criterioOrdenamiento.getPuntaje(jugador);
            }

            return puntaje / criteriosOrdenamiento.Count;
        }

        #endregion
    }
}
