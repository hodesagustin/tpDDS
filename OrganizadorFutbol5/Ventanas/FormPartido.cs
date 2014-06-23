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
    public partial class FormPartido : Form
    {
        Partido partido;

        public FormPartido()
        {
            InitializeComponent();
        }

        public void abrir(Partido unPartido)
        {
            partido = unPartido;

            tb_nombre.Text = partido.getNombre();
            tb_fecha.Text = partido.fecha.ToString();
            llenarListBox(lb_inscriptosStandard, partido.getInscriptosStandard());
            llenarListBox(lb_inscriptosSolidarios, partido.getInscriptosSolidarios());
            llenarListBox(lb_inscriptosCondicionales, partido.getInscriptosCondicionales());
            tb_cantidadInscriptos.Text = partido.getCantidadDeInscriptos().ToString();
            llenarListInfracciones();

            this.ShowDialog();
        }

        private void llenarListInfracciones()
        {
            listNotificaciones.Items.Clear();
            foreach (String notificacion in partido.getNotificador().getNotificaciones())
            {
                listNotificaciones.Items.Add(notificacion);
            }
        }

        private void llenarListBox(ListBox listBox, List<Jugador> jugadores)
        {
            listBox.Items.Clear();
            foreach (Jugador jugador in jugadores)
            {
                listBox.Items.Add(jugador.ToString());
            }
        }


        private void llenarListBox(ListBox listBox, List<JugadorCondicional> jugadoresCondicionales)
        {
            listBox.Items.Clear();
            foreach (JugadorCondicional jugadorCondicional in jugadoresCondicionales)
            {
                listBox.Items.Add(jugadorCondicional.ToString());
            }
        }

        private void bt_darDeBajaStandard_Click(object sender, EventArgs e)
        {
            if (isStandardSeleccionado())
            {
                partido.darDeBaja(partido.getInscriptosStandard()[lb_inscriptosStandard.SelectedIndex]);
                llenarListBox(lb_inscriptosStandard, partido.getInscriptosStandard());
                tb_cantidadInscriptos.Text = partido.getCantidadDeInscriptos().ToString();
                llenarListInfracciones();
            }
            else
                MessageBox.Show("Debe seleccionarl un Jugador Standard");
        }

        private void bt_darDeBajaSolidario_Click(object sender, EventArgs e)
        {
            if (isSolidarioSeleccionado())
            {
                partido.darDeBaja(partido.getInscriptosSolidarios()[lb_inscriptosSolidarios.SelectedIndex]);
                llenarListBox(lb_inscriptosSolidarios, partido.getInscriptosSolidarios());
                tb_cantidadInscriptos.Text = partido.getCantidadDeInscriptos().ToString();
                llenarListInfracciones();
            }
            else
                MessageBox.Show("Debe seleccionarl un Jugador Solidario");
        }

        private void bt_darDeBajaCondicional_Click(object sender, EventArgs e)
        {
            if (isCondicionalSeleccionado())
            {
                partido.darDeBaja(partido.getInscriptosCondicionales()[lb_inscriptosCondicionales.SelectedIndex]);
                llenarListBox(lb_inscriptosCondicionales, partido.getInscriptosCondicionales());
                tb_cantidadInscriptos.Text = partido.getCantidadDeInscriptos().ToString();
                llenarListInfracciones();
            }
            else
                MessageBox.Show("Debe seleccionarl un Jugador Condicional");
        }

        private bool isStandardSeleccionado()
        {
            return lb_inscriptosStandard.SelectedIndex != -1;
        }

        private bool isSolidarioSeleccionado()
        {
            return lb_inscriptosSolidarios.SelectedIndex != -1;
        }

        private bool isCondicionalSeleccionado()
        {
            return lb_inscriptosCondicionales.SelectedIndex != -1;
        }

        private void bt_reemplazarStandard_Click(object sender, EventArgs e)
        {
            if (isStandardSeleccionado())
            {
                Jugador reemplazado = partido.getInscriptosStandard()[lb_inscriptosStandard.SelectedIndex];
                Jugador reemplazo = new Jugador("Reemplazo Standard", (decimal)9.9);
                HomeAdministrador.jugadores.Add(reemplazo);

                partido.reemplazar(reemplazado, reemplazo);
                llenarListBox(lb_inscriptosStandard, partido.getInscriptosStandard());
            }
        }

        private void bt_reemplazarSolidario_Click(object sender, EventArgs e)
        {
            if (isSolidarioSeleccionado())
            {
                Jugador reemplazado = partido.getInscriptosSolidarios()[lb_inscriptosSolidarios.SelectedIndex];
                Jugador reemplazo = new Jugador("Reemplazo Solidario", 5);
                HomeAdministrador.jugadores.Add(reemplazo);

                partido.reemplazar(reemplazado, reemplazo);
                llenarListBox(lb_inscriptosSolidarios, partido.getInscriptosSolidarios());
            }
        }

        private void bt_reemplazarCondicional_Click(object sender, EventArgs e)
        {
            if (isCondicionalSeleccionado())
            {
                JugadorCondicional reemplazado = partido.getInscriptosCondicionales()[lb_inscriptosCondicionales.SelectedIndex];
                JugadorCondicional reemplazo = new JugadorCondicional("Reemplazo Condicional", 1, new Condicion());
                HomeAdministrador.jugadoresCondicionales.Add(reemplazo);

                partido.reemplazar(reemplazado, reemplazo);
                llenarListBox(lb_inscriptosCondicionales, partido.getInscriptosCondicionales());
            }
        }

        private void FormPartido_Load(object sender, EventArgs e)
        {

        }
    }
}
