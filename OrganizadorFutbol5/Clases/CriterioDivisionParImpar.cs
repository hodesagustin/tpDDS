using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5
{
    public class CriterioDivisionParImpar:CriterioDivision
    {
        public String descripcion {get; private set;}

        public CriterioDivisionParImpar()
        {
            descripcion = "Par-Impar";
        }

        #region CriterioDivision Members

        public void dividir(List<Jugador> jugadores, List<Jugador> equipoA, List<Jugador> equipoB)
        {
            for (int i = 0; i < jugadores.Count ;  i++)
            {
                if (i % 2 == 0)
                    equipoA.Add(jugadores[i]);
                else
                    equipoB.Add(jugadores[i]);
            }
        }
        
        #endregion
    }
}
