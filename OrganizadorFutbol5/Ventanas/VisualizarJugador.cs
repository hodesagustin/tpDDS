using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrganizadorFutbol5.Ventanas
{
    public partial class VisualizarJugador : Form
    {
        public VisualizarJugador()
        {
            int ID = 1;

            InitializeComponent();

            DataBaseDataContext db = new DataBaseDataContext();

            var query = from x in db.Jugadors
                        where x.ID == ID
                        select x;

            Nombre.Text = query.First().Nombre;

            Handicap.Text = query.First().Handicap.ToString();

            var promedioUltimoPartido = from x in db.Promedio_Ultimo_Partidos
                                        where x.Jugador == ID
                                        select x;

            PromedioUltimoPartido.Text = promedioUltimoPartido.First().Promedio.ToString();

           var promedioTodosLosPartidos = from x in db.Promedio_todos_los_partidos
                                          where x.Jugador == ID
                                          select x;


           PromedioTodos.Text = promedioTodosLosPartidos.First().Promedio.ToString();

           FechaDeNacimiento.Text = query.First().FechaNacimiento.ToShortDateString();

           int cantidadPartidosJugados = (from x in db.Inscripcions
                                         where x.JugadorID == ID
                                         select x).Count();

           CantPartidos.Text = cantidadPartidosJugados.ToString();

           var infracciones = from x in db.Infraccions
                              where x.JugadorID == ID
                              select new { x.Fecha, x.Motivo };



           dataGridViewInfracciones.DataSource = infracciones;

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }


        


        
    }
}
