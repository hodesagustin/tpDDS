using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5
{
    public interface CriterioOrdenamiento
    {

        double getPuntaje(Jugador jugador);
    }
}
