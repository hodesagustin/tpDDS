using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5.Clases
{
    interface CriterioDivision
    {
        void dividir(List<Jugador> jugadores, List<Jugador> equipoA, List<Jugador> equipoB);
    }
}
