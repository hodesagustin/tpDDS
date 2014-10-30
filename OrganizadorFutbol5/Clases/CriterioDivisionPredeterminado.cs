using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5
{
    public class CriterioDivisionPredeterminado:CriterioDivision
    {
        public String descripcion {get; private set;}

        public CriterioDivisionPredeterminado()
        {
            descripcion = "Predeterminado";
        }

        #region CriterioDivision Members
        
        public void dividir(List<Jugador> jugadores, List<Jugador> equipoA, List<Jugador> equipoB)
        {
            //jugadores[POSICION - offset}
            //Armo el equipoA
            equipoA.Add(jugadores[1 - 1]);
            equipoA.Add(jugadores[4 - 1]);
            equipoA.Add(jugadores[5 - 1]);
            equipoA.Add(jugadores[8 - 1]);
            equipoA.Add(jugadores[9 - 1]);
            //Armo el equipoB
            equipoB.Add(jugadores[2 - 1]);
            equipoB.Add(jugadores[3 - 1]);
            equipoB.Add(jugadores[6 - 1]);
            equipoB.Add(jugadores[7 - 1]);
            equipoB.Add(jugadores[10 - 1]);
        }

        #endregion
    }
}
