using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5.Clases
{
    public class Jugador : Persona
    {
        public decimal calificacion;
        public Partido partido;
        public Notificador notificador = new Notificador();
        public List<Jugador> amigos = new List<Jugador>();
        List<Infraccion> infraccciones = new List<Infraccion>();

        public Jugador(string nombreNuevo, decimal calif) :base(nombreNuevo)
        {
            calificacion = calif;
        }

        void inscripcionStandard()
        {
            partido.inscribirStandard(this);
        }

        void inscripcionSolidaria()
        {
            partido.inscribirSolidario(this);
        }

        public void avisarInscripcion(Partido partido)
        {
            //string mensaje = "Me he anotado para un partido el día y hora:" + partido.fecha.ToString();
            string mensaje = "Me he anotado para " + partido.ToString();

            foreach (Jugador amigo in amigos)
            {
                notificador.notify(mensaje, amigo);
            }
        }

        public void agregarInfraccion(Infraccion infraccion)
        {
            infraccciones.Add(infraccion);
        }

        public void agregarAmigo(Jugador amigo)
        { 
            amigos.Add(amigo); 
        }

        override public String ToString()
        {
            return this.nombre + " (" + calificacion + ")";
        }

        public String getNombre() { return this.nombre; }
        public decimal getCalificacion() { return this.calificacion; }
        public List<Infraccion> getInfracciones() { return infraccciones; }
        public List<Jugador> getAmigos() { return amigos; }
        public Notificador getNotificador() { return notificador; }
    }
}
