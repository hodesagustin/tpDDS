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
       
        public VisualizarJugador(int id)
        {
            int ID = id;

            InitializeComponent();

            Negocio.Commons commons = new Negocio.Commons();
            DataBaseDataContext db = new DataBaseDataContext();

            var query = from x in db.vw_Jugadors
                        where x.ID == ID
                        select x;

            vw_Jugador jugador = query.First();

            Nombre.Text = jugador.Nombre;

            Handicap.Text = jugador.Handicap.ToString();

            commons.colorear(Nombre, int.Parse(Handicap.Text));

            PromedioUltimoPartido.Text = jugador.PromedioUltimoPartido.ToString();

           PromedioTodos.Text = jugador.Promedio.ToString();

           FechaDeNacimiento.Text = jugador.FechaNacimiento.ToShortDateString();

           int cantidadPartidosJugados = (from x in db.Inscripcions
                                         where x.JugadorID == ID
                                         select x).Count();

           CantPartidos.Text = cantidadPartidosJugados.ToString();

           var infracciones = from x in db.Infraccions
                              where x.JugadorID == ID
                              select new { x.Fecha, x.Motivo };

           dataGridViewInfracciones.DataSource = infracciones;

           int caseSwitch = int.Parse(Handicap.Text);
           switch (caseSwitch)
           {
               case 0:
               case 1:
               case 2:
               case 3: //borrar este y habilitar el de abajo
                   fotoRogelio.Visible= true;
                   break;
               //case 3:
               case 4:
               case 5:
                   fotoRiquelme.Visible = true;
                   break;
               case 6:
               case 7:
               case 8:
                   fotoOzil.Visible = true;
                   break;
               default:
                   fotoMessi.Visible = true;
                   break;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }       
    }
}
