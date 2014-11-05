using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5
{
    public partial class Jugador
    {
        DataBaseDataContext db = new DataBaseDataContext();

        public void addInfraccion(Infraccion infraccion)
        {
            Infraccion unaInfraccion = new Infraccion() { Fecha = infraccion.Fecha, JugadorID = infraccion.JugadorID, Motivo = infraccion.Motivo, PartidoID = infraccion.PartidoID };
            db.Infraccions.InsertOnSubmit(unaInfraccion);
            db.SubmitChanges();
        }

        public void addCalificacionPendiente(Partido unPartido, Jugador unJugador)
        {
            CalificacionPendiente calificacionPendiente = new CalificacionPendiente() { Partido = unPartido, CalificadorID = this.ID, JugadorID = unJugador.ID};
            
            db.CalificacionPendientes.InsertOnSubmit(calificacionPendiente);
            db.SubmitChanges();
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
            Calificacion calificacion = new Calificacion()
                {
                    CalificadorID = this.ID,
                    PartidoID = calificacionPendiente.PartidoID,
                    JugadorID = calificacionPendiente.JugadorID,
                    Puntaje = (byte)puntaje,
                    Descripcion = descripcion
                };

            db.Calificacions.InsertOnSubmit(calificacion);
            db.CalificacionPendientes.DeleteOnSubmit(calificacionPendiente);
            db.SubmitChanges();
        }
    }
}
