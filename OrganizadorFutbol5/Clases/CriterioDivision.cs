using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5
{
    public interface CriterioDivision
    {
        void dividir(List<Jugador> jugadores, List<Jugador> equipoA, List<Jugador> equipoB);
    }
}
