using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5
{
    public class Notificador
    {
        public List<Notificacion> notificaciones { get; private set; }

        public void notify(String unDestinatario,String unMensaje)
        {
            notificaciones.Add(new Notificacion(unDestinatario,unMensaje));
        }

        public int getCantidadNotificacionesEnviadas()
        {
            return notificaciones.Count;
        }

        public class Notificacion
        {
            public String destinatario {get;private set;}
            public String mensaje {get; private set;}

            public Notificacion(String unDestinatario, String unMensaje)
            {
                destinatario = unDestinatario;
                mensaje = unMensaje;
            }
    }

    }
}
