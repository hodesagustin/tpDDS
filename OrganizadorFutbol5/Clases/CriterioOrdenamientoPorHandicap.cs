using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5
{
    public class CriterioOrdenamientoPorHandicap:CriterioOrdenamiento
    {
        #region CriterioOrdenamiento Members

        public double getPuntaje(Jugador jugador)
        {
            return jugador.Handicap;
        }

        #endregion
    }
}
