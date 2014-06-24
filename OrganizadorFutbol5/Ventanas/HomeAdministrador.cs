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
        public static List<Administrador> administradores = new List<Administrador>();

        public HomeAdministrador(int idUsuario)
        {
            InitializeComponent();
        }

        private void crearAdministradores()
        {
            administradores.Add(new Administrador("Administrador 1", true));
            administradores.Add(new Administrador("Administrador 2", false));
            administradores.Add(new Administrador("Administrador 3", true));
            administradores.Add(new Administrador("Administrador 4", true));
        }

        private void crearPartidos()
        {
            partidos.Add(new Partido("Partido 1", new DateTime(2014, 01, 10), administradores[0]));
            partidos.Add(new Partido("Partido 2", new DateTime(2014, 01, 15), administradores[1]));
            partidos.Add(new Partido("Partido 3", new DateTime(2014, 01, 31), administradores[2]));
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
            llenarLista(lb_Partidos,partidos);
        }

        private void llenarLista<T>(ListBox listBox, IEnumerable<T> lista)
        {
            listBox.Items.Clear();
            foreach (T elem in lista)
            {
                listBox.Items.Add(elem);
            }
        }

        private void HomeAdministrador_Load(object sender, EventArgs e)
        {
            crearAdministradores();
            crearPartidos();
            crearJugadores();
            crearJugadoresCondicionales();
            llenarLista(lb_Administradores, administradores);
            llenarLista(lb_Partidos, partidos);
            llenarLista(lb_Jugadores, jugadores);
            llenarLista(lb_JugadoresCondicionales,jugadoresCondicionales);
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

        private void bt_inscribirStandard_Click(object sender, EventArgs e)
        {
            if (isPartidoSeleccionado() && isJugadorSeleccionado())
            {
                try
                {
                    Partido partidoSeleccionado = partidos[lb_Partidos.SelectedIndex];
                    Jugador jugadorSeleccionado = jugadores[lb_Jugadores.SelectedIndex];

                    partidoSeleccionado.inscribirStandard(jugadorSeleccionado);
                    MessageBox.Show("Inscripcion Realizada");
                }
                catch (Exception inscripcionException)
                {
                    MessageBox.Show(inscripcionException.Message);
                    return;
                }
            }
            else
                MessageBox.Show("Debe elegir Partido y Jugador");
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
            return lb_Partidos.SelectedIndex != -1;
        }

        private void bt_abrirPartido_Click(object sender, EventArgs e)
        {
            if (isPartidoSeleccionado())
            {
                FormPartido formPartido = new FormPartido();
                formPartido.abrir(partidos[lb_Partidos.SelectedIndex]);

                llenarLista(lb_Partidos,partidos);
                llenarLista(lb_Jugadores,jugadores);
                llenarLista(lb_JugadoresCondicionales,jugadoresCondicionales);
            }
            else
                MessageBox.Show("Debe seleccionar Partido");
        }

        private void bt_abrirJugador_Click(object sender, EventArgs e)
        {
            if (isJugadorSeleccionado())
            {
                FormJugador formJugador = new FormJugador();
                formJugador.abrir(jugadores[lb_Jugadores.SelectedIndex]);
            }
            else
                MessageBox.Show("Debe seleccionar Jugador");
        }

        private void bt_inscribirSolidario_Click(object sender, EventArgs e)
        {
            if (isPartidoSeleccionado() && isJugadorSeleccionado())
            {
                try
                {
                    Partido partidoSeleccionado = partidos[lb_Partidos.SelectedIndex];
                    Jugador jugadorSeleccionado = jugadores[lb_Jugadores.SelectedIndex];

                    partidoSeleccionado.inscribirSolidario(jugadorSeleccionado);
                    MessageBox.Show("Inscripcion Realizada");
                }
                catch (Exception inscripcionException)
                {
                    MessageBox.Show(inscripcionException.Message);
                }
            }
            else
                MessageBox.Show("Debe elegir Partido y Jugador");
        }

        private void bt_crearJugador_Click(object sender, EventArgs e)
        {
            FormJugador formJugador = new FormJugador();
            formJugador.ShowDialog();
            llenarLista(lb_Jugadores,jugadores);
        }

        private void bt_inscribirCondicional_Click(object sender, EventArgs e)
        {
            if (isPartidoSeleccionado() && isJugadorCondicionalSeleccionado())
            {
                try
                {
                    Partido partidoSeleccionado = partidos[lb_Partidos.SelectedIndex];
                    JugadorCondicional jugadorCondicionalSeleccionado = jugadoresCondicionales[lb_JugadoresCondicionales.SelectedIndex];

                    partidoSeleccionado.inscribirCondicional(jugadorCondicionalSeleccionado);
                    MessageBox.Show("Inscripcion Realizada");
                }
                catch (Exception inscripcionException)
                {
                    MessageBox.Show(inscripcionException.Message);
                }
            }
            else
                MessageBox.Show("Debe elegir Partido y Jugador");
        }

        private void btnCrear_ProponerJugadores_Click(object sender, EventArgs e)
        {
            if (isPartidoSeleccionado())
            {
                Partido partidoSeleccionado = partidos[lb_Partidos.SelectedIndex];
                Jugador jugadorPropuestoStandard = new Jugador("Jugador Propuesto Standard", 7);
                Jugador jugadorPropuestoSolidario = new Jugador("Jugador Propuesto Solidario", 4);

                jugadores.Add(jugadorPropuestoStandard);
                jugadores.Add(jugadorPropuestoSolidario);
                llenarLista(lb_Jugadores, jugadores); 

                partidoSeleccionado.proponerJugador(jugadorPropuestoStandard, "Standard");
                partidoSeleccionado.proponerJugador(jugadorPropuestoSolidario, "Solidario");
                
                MessageBox.Show("Jugadores Creados y Propuestos");
            }
            else
                MessageBox.Show("Debe elegir Partido");

        }
    }
}
