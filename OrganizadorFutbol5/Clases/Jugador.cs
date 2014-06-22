using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizadorFutbol5.Clases
{
    public class Jugador : Persona
    {
        public Partido partido;
        public Notificador notificador;
        public List<Jugador> amigos;
        List<Infraccion> infraccciones = new List<Infraccion>();

        public Jugador(string nombreNuevo)
        {
            nombre = nombreNuevo;
        }

        void inscripcionStandard()
        {
            partido.inscribirStandard(this);
        }

        void inscripcionSolidaria()
        {
            partido.inscribirSolidario(this);
        }

        void avisarInscripcion(Partido partido)
        {
            string mensaje = "Me he anotado para un partido el día y hora:" + partido.fecha.ToString();

            foreach (Jugador amigo in amigos)
            {
                notificador.notify(mensaje, amigo);
            }
        }

        public void agregarInfraccion(Infraccion infraccion)
        {
            infraccciones.Add(infraccion);
        }
    }
}
