using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OrganizadorFutbol5.Clases;
using OrganizadorFutbol5.Ventanas;

namespace OrganizadorFutbol5.Ventanas
{
    public partial class HomeAdministrador : Form
    {
        public static List<Partido> partidos = new List<Partido>();
        public static List<Jugador> jugadores = new List<Jugador>();
        public static List<JugadorCondicional> jugadoresCondicionales = new List<JugadorCondicional>();

        public HomeAdministrador(int idUsuario)
        {
            InitializeComponent();
        }

        public void crearPartidos()
        {
            partidos.Add(new Partido("Partido 1", new DateTime(2014, 01, 10)));
            partidos.Add(new Partido("Partido 2", new DateTime(2014, 01, 15)));
            partidos.Add(new Partido("Partido 3", new DateTime(2014, 01, 31)));
        }

        private void crearJugadores()
        {
            jugadores.Add(new Jugador("Jugador 01", 7));
            jugadores.Add(new Jugador("Jugador 02", (decimal) 8.5));
            jugadores.Add(new Jugador("Jugador 03", 9));
            jugadores.Add(new Jugador("Jugador 04", 4));
            jugadores.Add(new Jugador("Jugador 05", 3));
            jugadores.Add(new Jugador("Jugador 06", 9));
            jugadores.Add(new Jugador("Jugador 07", (decimal)6.2));
            jugadores.Add(new Jugador("Jugador 08", (decimal)3.9));
            jugadores.Add(new Jugador("Jugador 09", 3));
            jugadores.Add(new Jugador("Jugador 10", (decimal)9.9));
        }

        private void crearJugadoresCondicionales()
        {
            jugadoresCondicionales.Add(new JugadorCondicional("Jugador Condicional 01", (decimal)4.8, new Condicion()));
            jugadoresCondicionales.Add(new JugadorCondicional("Jugador Condicional 02", (decimal)7.7, new Condicion()));
            jugadoresCondicionales.Add(new JugadorCondicional("Jugador Condicional 03", (decimal)2.1, new Condicion()));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearPartido crearPartido = new CrearPartido();
            crearPartido.ShowDialog();
            llenarListaPartidos();
        }

        private void llenarListaPartidos()
        {
            listBox1.Items.Clear();
            foreach (Partido partido in partidos)
            {
                listBox1.Items.Add(partido.ToString());
            }
        }

        private void llenarListaJugadores()
        {
            listBox2.Items.Clear();
            foreach (Jugador jugador in jugadores)
            {
                listBox2.Items.Add(jugador.ToString());
            }
        }

        private void llenarListaJugadoresCondicionales()
        {
            listBox3.Items.Clear();
            foreach (JugadorCondicional jugadorCondicional in jugadoresCondicionales)
            {
                listBox3.Items.Add(jugadorCondicional.ToString());
            }
        }

        private void HomeAdministrador_Load(object sender, EventArgs e)
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isPartidoSeleccionado() && isJugadorSeleccionado())
            {
                Partido partidoSeleccionado = partidos[listBox1.SelectedIndex];
                Jugador jugadorSeleccionado = jugadores[listBox2.SelectedIndex];

                partidoSeleccionado.inscribirStandard(jugadorSeleccionado);
                MessageBox.Show("Inscripcion Realizada");
            }
            else
            {
                MessageBox.Show("Debe elegir Partido y Jugador");
            }
        }

        private bool isJugadorSeleccionado()
        {
            return listBox2.SelectedIndex != -1;
        }

        private bool isJugadorCondicionalSeleccionado()
        {
            return listBox3.SelectedIndex != -1;
        }

        private bool isPartidoSeleccionado()
        {
            return listBox1.SelectedIndex != -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isPartidoSeleccionado())
            {
                FormPartido formPartido = new FormPartido();
                formPartido.abrir(partidos[listBox1.SelectedIndex]);

                llenarListaPartidos();
                llenarListaJugadores();
                llenarListaJugadoresCondicionales();
            }
            else
                MessageBox.Show("Debe seleccionar Partido");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isJugadorSeleccionado())
            {
                FormJugador formJugador = new FormJugador();
                formJugador.abrir(partidos[listBox2.SelectedIndex]);
            }
            else
                MessageBox.Show("Debe seleccionar Jugador");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isPartidoSeleccionado() && isJugadorSeleccionado())
            {
                Partido partidoSeleccionado = partidos[listBox1.SelectedIndex];
                Jugador jugadorSeleccionado = jugadores[listBox2.SelectedIndex];

                partidoSeleccionado.inscribirSolidario(jugadorSeleccionado);
                MessageBox.Show("Inscripcion Realizada");
            }
            else
            {
                MessageBox.Show("Debe elegir Partido y Jugador");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormJugador formJugador = new FormJugador();
            formJugador.ShowDialog();
            llenarListaJugadores();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (isPartidoSeleccionado() && isJugadorCondicionalSeleccionado())
            {
                Partido partidoSeleccionado = partidos[listBox1.SelectedIndex];
                JugadorCondicional jugadorCondicionalSeleccionado = jugadoresCondicionales[listBox3.SelectedIndex];

                partidoSeleccionado.inscribirCondicional(jugadorCondicionalSeleccionado);
                MessageBox.Show("Inscripcion Realizada");
            }
            else
            {
                MessageBox.Show("Debe elegir Partido y Jugador");
            }
        }   
    }
}
