using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5
{
    public partial class Jugador
    {
        /*
        public String nombre { get; private set; }
        public String mail { get; private set; }
        //public DateTime fechaNacimiento { get; private set; }
        public int edad { get; private set; }
        public List<String> amigos { get; private set; }

        public int handicap { get; private set; }
        public List<Infraccion> infracciones { get; private set; }
        public List<Calificacion> calificaciones { get; private set; }
        public List<CalificacionPendiente> calificacionesPendientes { get; private set; }        
        */

        /*
        public Jugador(String unNombre, String unMail, /*DateTime unaFechaNacimiento,* / int unaEdad, List<String> unosAmigos, int unHandicap) 
        {
            nombre = unNombre;
            mail = unMail;
            //fechaNacimiento = unaFechaNacimiento;
            edad = unaEdad;
            amigos = unosAmigos;

            handicap = unHandicap;
            infracciones = new List<Infraccion>();
            calificaciones = new List<Calificacion>();
            calificacionesPendientes = new List<CalificacionPendiente>();
        }
        */

        public void addInfraccion(Infraccion infraccion)
        {
            /*
            Infraccions.Add(infraccion);
            Infraccions = Infraccions.OrderByDescending(i => i.Fecha).ToList();
            */
        }

        public void addCalificacion(Calificacion calificacion)
        {
            /*
            Calificacions.Add(calificacion);
            Calificacions = Calificacions.OrderByDescending(c => c.Partido.Fecha).ToList();
            */
        }

        public void addCalificacionPendiente(Partido unPartido, Jugador unJugador)
        {
            /*
            CalificacionPendiente calificacionPendiente = new CalificacionPendiente() { Partido = unPartido, Jugador = unJugador };
            CalificacionPendientes.Add(calificacionPendiente);
            */
        }

        public override string ToString()
        {
            return Nombre;
        }

        public bool Equals(Jugador otroJugador)
        {
            return Nombre.Equals(otroJugador.Nombre);
        }

        public double getPromedio(int cantidadPartidos)
        {
            /*
            double promedio = 0.0;
            //FALTA HACER BIEN ESTO. AHORA ES 4 * cantidadPartidos (porque por cada partido, lo califican los 4 que jugaron con el)
            for (int i = 0; i < 4 * cantidadPartidos; i++)
            {
                promedio += (double)calificaciones[i].puntaje;
            }
            promedio /= cantidadPartidos;

            return promedio;
            */

            throw new NotImplementedException();
        }

        public void calificarJugador(CalificacionPendiente calificacionPendiente, int puntaje, String descripcion)
        {
            /*
            calificacionPendiente.jugador.addCalificacion(new Calificacion(descripcion, puntaje, calificacionPendiente.partido));
            calificacionesPendientes.Remove(calificacionPendiente);
            */
        }
    }
}
