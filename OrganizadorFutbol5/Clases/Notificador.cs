using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5.Clases
{
    public class Notificador
    {
        private int cantidadDeNotificacionesEnviadas;
        private List<String> notificaciones = new List<string>();

        public void notify(string mensaje, Persona jugador)
        {
            notificaciones.Add(jugador.ToString() + ": " + mensaje);
            cantidadDeNotificacionesEnviadas ++; 
        }

        public int getCantidadDeNotificacionesEnviadas()
        {
            return cantidadDeNotificacionesEnviadas;
        }
        public List<String> getNotificaciones() { return notificaciones; }
    }
}
