using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5.Clases
{
    public class Jugador : Persona
    {
        private List<decimal> calificaciones = new List<decimal>();
        //private List<Partido> partidos = new List<Partido>();
        public Notificador notificador = new Notificador();
        public List<Jugador> amigos = new List<Jugador>();
        List<Infraccion> infraccciones = new List<Infraccion>();

        public Jugador(string nombreNuevo, decimal calificacion) :base(nombreNuevo)
        {
            this.agregarCalificacion(calificacion);
        }

        /*
        void inscripcionStandard()
        {
            partido.inscribirStandard(this);
        }

        void inscripcionSolidaria()
        {
            partido.inscribirSolidario(this);
        }
        */

        public void avisarInscripcion(Partido partido)
        {
            string mensaje = "Me he anotado para " + partido.ToString();

            foreach (Jugador amigo in amigos)
            {
                notificador.notify(mensaje, amigo);
            }
        }

        public void agregarCalificacion(decimal calificacion)
        {
            calificaciones.Add(calificacion);
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
            return this.getNombre() + " (" + this.getCalificacion() + ")";
        }
        public override bool Equals(object obj)
        {
            return this.ToString().Equals(obj.ToString());
        }

        public decimal getCalificacion() { return calificaciones.Average(); }
        public List<Infraccion> getInfracciones() { return infraccciones; }
        public List<Jugador> getAmigos() { return amigos; }
        public Notificador getNotificador() { return notificador; }
    }
}
