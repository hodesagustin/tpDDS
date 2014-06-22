using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5.Clases
{
    public class Notificador
    {
        private int cantidadDeNotificacionesEnviadas;

        public void notify(string mensaje, Persona jugador)
        {
            cantidadDeNotificacionesEnviadas ++; 
        }

        public int getCantidadDeNotificacionesEnviadas()
        {
            return cantidadDeNotificacionesEnviadas;
        }
    }
}
