using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5.Clases
{
    public class Jugador : Persona
    {
        private List<Calificacion> calificaciones = new List<Calificacion>();
        //private List<Partido> partidos = new List<Partido>();
        public Notificador notificador = new Notificador();
        public List<Jugador> amigos = new List<Jugador>();
        List<Infraccion> infraccciones = new List<Infraccion>();

        public Jugador(string nombreNuevo)
            : base(nombreNuevo) { }

        /*CONSTRUCTOR PARA CREACION INICIAL*/
        public Jugador(string nombreNuevo, decimal calificacion) 
            :base(nombreNuevo)
        {
            this.agregarCalificacion("Calificacion Inicial",calificacion);
        }
        /*******************************************************/
        public void avisarInscripcion(Partido partido)
        {
            string mensaje = "Me he anotado para " + partido.ToString();

            foreach (Jugador amigo in amigos)
            {
                notificador.notify(mensaje, amigo);
            }
        }

        public void agregarCalificacion(String descripcion,decimal calificacion)
        {
            calificaciones.Add(new Calificacion(descripcion,calificacion));
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
            return this.getNombre() + " (" + this.getCalificacion()  + ")";
        }
        
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            else
                return this.ToString().Equals(obj.ToString());
        }

        public bool Equals(Jugador otroJugador)
        {
            if ((object)otroJugador == null)
                return false;
            else
                return this.ToString().Equals(otroJugador.ToString());
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public decimal getCalificacion() {
            decimal calificacion = 0;

            if (calificaciones.Count != 0)
            {
                foreach (Calificacion calif in calificaciones)
                    calificacion += calif.getPuntaje();
                return calificacion / calificaciones.Count ;
            }
            else
                return 0;
        }
        
        public List<Infraccion> getInfracciones() { return infraccciones; }
        public List<Jugador> getAmigos() { return amigos; }
        public Notificador getNotificador() { return notificador; }

        private void fill<T>(System.Windows.Forms.ListBox listBox, List<T> list)
        {
            listBox.Items.Clear();
            foreach (T elem in list)
            {
                listBox.Items.Add(elem);
            }
        }

        internal void fillWithInfracciones(System.Windows.Forms.ListBox listInfracciones)
        {
            this.fill(listInfracciones, this.infraccciones);
        }

        internal void fillWithNotificaciones(System.Windows.Forms.ListBox listNotificaciones)
        {
            this.fill(listNotificaciones,notificador.getNotificaciones());
        }

        internal void fillWithCalificaciones(System.Windows.Forms.ListBox listCalificaciones)
        {
            this.fill(listCalificaciones, calificaciones);
        }
    }
}
