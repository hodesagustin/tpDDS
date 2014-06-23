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
        public static List<JugadorCondicional> jugadoresCondicionales = new List<JugadorCondicional>();

        public Inicio()
        {
            InitializeComponent();
        }

        private void crearPartidos()
        {
            partidos.Add(new Partido("Partido 1",new DateTime(2014,01,01)));
            partidos.Add(new Partido("Partido 2", new DateTime(2014, 01, 15)));
            partidos.Add(new Partido("Partido 3", new DateTime(2014, 01, 31)));
        }

        private void crearJugadores()
        {
            jugadores.Add(new Jugador("Jugador 01",7));
            jugadores.Add(new Jugador("Jugador 02",(decimal)8.5));
            jugadores.Add(new Jugador("Jugador 03",9));
            jugadores.Add(new Jugador("Jugador 04",4));
            jugadores.Add(new Jugador("Jugador 05",3));
            jugadores.Add(new Jugador("Jugador 06", 9));
            jugadores.Add(new Jugador("Jugador 07", (decimal)6.2));
            jugadores.Add(new Jugador("Jugador 08", (decimal)3.9));
            jugadores.Add(new Jugador("Jugador 09", 8));
            jugadores.Add(new Jugador("Jugador 10", (decimal)9.9));
        }
        private void crearJugadoresCondicionales()
        {
            jugadoresCondicionales.Add(new JugadorCondicional("Jugador Condicional 01", (decimal)4.8,new Condicion()));
            jugadoresCondicionales.Add(new JugadorCondicional("Jugador Condicional 02", (decimal)7.7,new Condicion()));
            jugadoresCondicionales.Add(new JugadorCondicional("Jugador Condicional 03", (decimal)2.1,new Condicion()));
        }

        private void bt_crearPartido_Click(object sender, EventArgs e)
        {
            CrearPartido crearPartido = new CrearPartido();
            crearPartido.ShowDialog();
            llenarListaPartidos();
        }

        private void llenarListaPartidos()
        {
            lb_listaPartidos.Items.Clear();
            foreach (Partido partido in partidos)
            {
                lb_listaPartidos.Items.Add(partido.ToString());
            }
        }

        private void llenarListaJugadores()
        {
            lb_Jugadores.Items.Clear();
            foreach (Jugador jugador in jugadores)
            {
                lb_Jugadores.Items.Add(jugador.ToString());
            }
        }
        
        private void llenarListaJugadoresCondicionales()
        {
            lb_JugadoresCondicionales.Items.Clear();
            foreach (JugadorCondicional jugadorCondicional in jugadoresCondicionales)
            {
                lb_JugadoresCondicionales.Items.Add(jugadorCondicional.ToString());
            }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            crearPartidos();
            crearJugadores();
            crearJugadoresCondicionales();
            llenarListaPartidos();
            llenarListaJugadores();
            llenarListaJugadoresCondicionales();

            partidos[0].inscribirStandard(jugadores[0]);
            partidos[0].inscribirStandard(jugadores[1]);
            partidos[0].inscribirStandard(jugadores[2]);
            partidos[0].inscribirSolidario(jugadores[3]);
            partidos[0].inscribirSolidario(jugadores[4]);
            partidos[0].inscribirSolidario(jugadores[5]);
            partidos[0].inscribirCondicional(jugadoresCondicionales[0]);
            partidos[0].inscribirCondicional(jugadoresCondicionales[1]);
        }

        private void lb_listaPartidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_partidoSeleccionado.Text = lb_listaPartidos.Text;
        }

        private void bt_inscribirse_Click(object sender, EventArgs e)
        {

            if (isPartidoSeleccionado() && isJugadorSeleccionado())
            {
                Partido partidoSeleccionado = partidos[lb_listaPartidos.SelectedIndex];
                Jugador jugadorSeleccionado = jugadores[lb_Jugadores.SelectedIndex];

                partidoSeleccionado.inscribirStandard(jugadorSeleccionado);
                MessageBox.Show("Inscripcion Realizada");
            }
            else
                MessageBox.Show("Debe elegir Partido y Jugador");
            /*Inscripcion inscripcion = new Inscripcion();
            inscripcion.setPartido(partidos[lb_listaPartidos.SelectedIndex]);
            inscripcion.ShowDialog();*/
        }

        private bool isJugadorSeleccionado()
        {
            return lb_Jugadores.SelectedIndex != -1;
        }
        private bool isJugadorCondicionalSeleccionado()
        {
            return lb_JugadoresCondicionales.SelectedIndex != -1;
        }
        private bool isPartidoSeleccionado()
        {
            return lb_listaPartidos.SelectedIndex != -1;
        }

        private void btnAbrirPartido_Click(object sender, EventArgs e)
        {
            if (isPartidoSeleccionado())
            {
                FormPartido formPartido = new FormPartido();
                formPartido.abrir(partidos[lb_listaPartidos.SelectedIndex]);

                llenarListaPartidos();
                llenarListaJugadores();
                llenarListaJugadoresCondicionales();
            }
            else
                MessageBox.Show("Debe seleccionar Partido");
        }

        private void btnAbrirJugador_Click(object sender, EventArgs e)
        {
            if (isJugadorSeleccionado())
            {
                FormJugador formJugador = new FormJugador();
                formJugador.abrir(jugadores[lb_Jugadores.SelectedIndex]);
            }
            else
                MessageBox.Show("Debe seleccionar Jugador");
        }

        private void btnInscribirSolidario_Click(object sender, EventArgs e)
        {
            if (isPartidoSeleccionado() && isJugadorSeleccionado())
            {
                Partido partidoSeleccionado = partidos[lb_listaPartidos.SelectedIndex];
                Jugador jugadorSeleccionado = jugadores[lb_Jugadores.SelectedIndex];

                partidoSeleccionado.inscribirSolidario(jugadorSeleccionado);
                MessageBox.Show("Inscripcion Realizada");
            }
            else
                MessageBox.Show("Debe seleccionar Partido y Jugador");
        }

        private void btnCrearJugador_Click(object sender, EventArgs e)
        {
            FormJugador formJugador = new FormJugador();
            formJugador.ShowDialog();
            llenarListaJugadores();
        }

        private void btnInscribirCondicional_Click(object sender, EventArgs e)
        {
            if (isPartidoSeleccionado() && isJugadorCondicionalSeleccionado())
            {
                Partido partidoSeleccionado = partidos[lb_listaPartidos.SelectedIndex];
                JugadorCondicional jugadorCondicionalSeleccionado = jugadoresCondicionales[lb_JugadoresCondicionales.SelectedIndex];

                partidoSeleccionado.inscribirCondicional(jugadorCondicionalSeleccionado);
                MessageBox.Show("Inscripcion Realizada");
            }
            else
                MessageBox.Show("Debe seleccionar Partido y Jugador");
        }
     }
}
