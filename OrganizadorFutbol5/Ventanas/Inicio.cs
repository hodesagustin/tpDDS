using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OrganizadorFutbol5.Ventanas;
using OrganizadorFutbol5.Clases;

namespace OrganizadorFutbol5
{
    public partial class Inicio : Form
    {
        public static List<Partido> partidos = new List<Partido>();
        public static List<Jugador> jugadores = new List<Jugador>();
        //public static Partido nuevoPartido;

        public Inicio()
        {
            InitializeComponent();
            crearJugadores();
        }

        private void crearJugadores()
        {
            jugadores.Add(new Jugador("Jugador 1"));
            jugadores.Add( new Jugador("Jugador 2"));
            jugadores.Add( new Jugador("Jugador 3"));
            jugadores.Add( new Jugador("Jugador 4"));
            jugadores.Add( new Jugador("Jugador 5"));
        }

        private void bt_crearPartido_Click(object sender, EventArgs e)
        {
            CrearPartido crearPartido = new CrearPartido();
            crearPartido.ShowDialog();
            lb_listaPartidos.Items.Clear();
            foreach (Partido partido in partidos)
            {
                lb_listaPartidos.Items.Add(partido.getNombre());
            }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void lb_listaPartidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_partidoSeleccionado.Text = lb_listaPartidos.Text;
        }

        private void bt_inscribirse_Click(object sender, EventArgs e)
        {
            Partido partidoSeleccionado = partidos[lb_listaPartidos.SelectedIndex];

            partidoSeleccionado.inscribirStandard(jugadores[0]);
            partidoSeleccionado.inscribirStandard(jugadores[1]);
            partidoSeleccionado.inscribirStandard(jugadores[2]);
            partidoSeleccionado.inscribirSolidario(jugadores[3]);
            partidoSeleccionado.inscribirSolidario(jugadores[4]);

            MessageBox.Show("Qty Inscriptos: " + partidoSeleccionado.cantidadDeInscriptos());

            /*Inscripcion inscripcion = new Inscripcion();
            inscripcion.setPartido(partidos[lb_listaPartidos.SelectedIndex]);
            inscripcion.ShowDialog();*/
        }
     }
}
