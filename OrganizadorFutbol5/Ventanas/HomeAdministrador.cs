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
            partidos.Add(new Partido("Partido 1", new DateTime(2014, 01, 10), "Administrador 1"));
            partidos.Add(new Partido("Partido 2", new DateTime(2014, 01, 15), "Administrador 2"));
            partidos.Add(new Partido("Partido 3", new DateTime(2014, 01, 31), "Administrador 3"));
        }

        private void crearJugadores()
        {
            Jugador jugador1 = new Jugador("Jugador 01", 7);
            Jugador jugador2 = new Jugador("Jugador 02", (decimal) 8.5);
            Jugador jugador3 = new Jugador("Jugador 03", 9);
            Jugador jugador4 = new Jugador("Jugador 04", 4);

            jugador1.agregarAmigo(jugador2);
            jugador1.agregarAmigo(jugador3);
            jugador1.agregarAmigo(jugador4);

            jugadores.Add(jugador1);
            jugadores.Add(jugador2);
            jugadores.Add(jugador3);
            jugadores.Add(jugador4);
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
            lb_jugadores.Items.Clear();
            foreach (Jugador jugador in jugadores)
            {
                lb_jugadores.Items.Add(jugador.ToString());
            }
        }

        private void llenarListaJugadoresCondicionales()
        {
            lb_jugadoresCondicionales.Items.Clear();
            foreach (JugadorCondicional jugadorCondicional in jugadoresCondicionales)
            {
                lb_jugadoresCondicionales.Items.Add(jugadorCondicional.ToString());
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
        //Inscribo Jugadores al 'Partido 1'
            partidos[0].inscribirStandard(jugadores[0]);
            partidos[0].inscribirStandard(jugadores[1]);
            partidos[0].inscribirStandard(jugadores[2]);
            partidos[0].inscribirSolidario(jugadores[3]);
            partidos[0].inscribirSolidario(jugadores[4]);
            partidos[0].inscribirSolidario(jugadores[5]);
            partidos[0].inscribirCondicional(jugadoresCondicionales[0]);
            partidos[0].inscribirCondicional(jugadoresCondicionales[1]);
            //Inscribo Jugadores al 'Partido 2'
            partidos[1].inscribirStandard(jugadores[0]);
            partidos[1].inscribirStandard(jugadores[1]);
            partidos[1].inscribirStandard(jugadores[2]);
            partidos[1].inscribirStandard(jugadores[3]);
            partidos[1].inscribirStandard(jugadores[4]);
            partidos[1].inscribirStandard(jugadores[5]);
            partidos[1].inscribirSolidario(jugadores[6]);
            partidos[1].inscribirSolidario(jugadores[7]);
            partidos[1].inscribirSolidario(jugadores[8]);
            partidos[1].inscribirCondicional(jugadoresCondicionales[0]);
            partidos[1].inscribirCondicional(jugadoresCondicionales[1]);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_partidoSeleccionado.Text = lb_listaPartidos.Text;
        }

        private void bt_inscribirStandard_Click(object sender, EventArgs e)
        {
            if (isPartidoSeleccionado() && isJugadorSeleccionado())
            {
                Partido partidoSeleccionado = partidos[lb_listaPartidos.SelectedIndex];
                Jugador jugadorSeleccionado = jugadores[lb_jugadores.SelectedIndex];

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
            return lb_jugadores.SelectedIndex != -1;
        }

        private bool isJugadorCondicionalSeleccionado()
        {
            return lb_jugadoresCondicionales.SelectedIndex != -1;
        }

        private bool isPartidoSeleccionado()
        {
            return lb_listaPartidos.SelectedIndex != -1;
        }

        private void bt_abrirPartido_Click(object sender, EventArgs e)
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

        private void bt_abrirJugador_Click(object sender, EventArgs e)
        {
            if (isJugadorSeleccionado())
            {
                FormJugador formJugador = new FormJugador();
                formJugador.abrir(jugadores[lb_jugadores.SelectedIndex]);
            }
            else
                MessageBox.Show("Debe seleccionar Jugador");
        }

        private void bt_inscribirSolidario_Click(object sender, EventArgs e)
        {
            if (isPartidoSeleccionado() && isJugadorSeleccionado())
            {
                Partido partidoSeleccionado = partidos[lb_listaPartidos.SelectedIndex];
                Jugador jugadorSeleccionado = jugadores[lb_jugadores.SelectedIndex];

                partidoSeleccionado.inscribirSolidario(jugadorSeleccionado);
                MessageBox.Show("Inscripcion Realizada");
            }
            else
            {
                MessageBox.Show("Debe elegir Partido y Jugador");
            }
        }

        private void bt_crearJugador_Click(object sender, EventArgs e)
        {
            FormJugador formJugador = new FormJugador();
            formJugador.ShowDialog();
            llenarListaJugadores();
        }

        private void bt_inscribirCondicional_Click(object sender, EventArgs e)
        {
            if (isPartidoSeleccionado() && isJugadorCondicionalSeleccionado())
            {
                Partido partidoSeleccionado = partidos[lb_listaPartidos.SelectedIndex];
                JugadorCondicional jugadorCondicionalSeleccionado = jugadoresCondicionales[lb_jugadoresCondicionales.SelectedIndex];

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
