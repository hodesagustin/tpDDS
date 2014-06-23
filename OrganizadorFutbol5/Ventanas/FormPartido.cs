using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OrganizadorFutbol5.Clases;

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
            
            txtNombre.Text = partido.getNombre();
            txtFecha.Text = partido.fecha.ToString();
            llenarListBox(listInscriptosStandard, partido.getInscriptosStandard());
            llenarListBox(listInscriptosSolidarios, partido.getInscriptosSolidarios());
            llenarListBox(listInscriptosCondicionales, partido.getInscriptosCondicionales());
            txtCantidadInscriptos.Text = partido.getCantidadDeInscriptos().ToString();

            this.ShowDialog();
        }

        private void Partido_Load(object sender, EventArgs e)
        {
            
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

        private void listInscriptosStandard_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDarDeBajaStandard_Click(object sender, EventArgs e)
        {
            if (isStandardSeleccionado())
            {
                partido.darDeBaja(partido.getInscriptosStandard()[listInscriptosStandard.SelectedIndex]);

                llenarListBox(listInscriptosStandard, partido.getInscriptosStandard());
                txtCantidadInscriptos.Text = partido.getCantidadDeInscriptos().ToString();
            }
            else
                MessageBox.Show("Debe seleccionar un Jugador Standard");
        }

        private void btnDarDDeBajaSolidario_Click(object sender, EventArgs e)
        {
            if (isSolidarioSeleccionado())
            {
                partido.darDeBaja(partido.getInscriptosSolidarios()[listInscriptosSolidarios.SelectedIndex]);

                llenarListBox(listInscriptosSolidarios, partido.getInscriptosSolidarios());
                txtCantidadInscriptos.Text = partido.getCantidadDeInscriptos().ToString(); 
            }
            else
                MessageBox.Show("Debe seleccionar un Jugador Solidario");
        }

        private void btnDarDeBajaCondicional_Click(object sender, EventArgs e)
        {
            if (isCondicionalSeleccionado())
            {
                partido.darDeBaja(partido.getInscriptosCondicionales()[listInscriptosCondicionales.SelectedIndex]);

                llenarListBox(listInscriptosCondicionales, partido.getInscriptosCondicionales());
                txtCantidadInscriptos.Text = partido.getCantidadDeInscriptos().ToString();
            }
            else
                MessageBox.Show("Debe seleccionar un Jugador Condicional");
        }

        private bool isStandardSeleccionado()
        { return listInscriptosStandard.SelectedIndex != -1; }
        private bool isSolidarioSeleccionado()
        { return listInscriptosSolidarios.SelectedIndex != -1; }
        private bool isCondicionalSeleccionado()
        { return listInscriptosCondicionales.SelectedIndex != -1; }

        private void btnReemplazarStandard_Click(object sender, EventArgs e)
        {
            if (isStandardSeleccionado())
            {
                Jugador reemplazado = partido.getInscriptosStandard()[listInscriptosStandard.SelectedIndex];
                Jugador reemplazo = new Jugador("Reemplazo Standard", (decimal)9.9);
                Inicio.jugadores.Add(reemplazo);

                partido.reemplazar(reemplazado, reemplazo);
                llenarListBox(listInscriptosStandard, partido.getInscriptosStandard());
            }
        }

        private void btnReemplazarSolidario_Click(object sender, EventArgs e)
        {
            if (isSolidarioSeleccionado())
            {
                Jugador reemplazado = partido.getInscriptosSolidarios()[listInscriptosSolidarios.SelectedIndex];
                Jugador reemplazo = new Jugador("Reemplazo Solidario", 5);
                Inicio.jugadores.Add(reemplazo);

                partido.reemplazar(reemplazado, reemplazo);
                llenarListBox(listInscriptosSolidarios, partido.getInscriptosSolidarios());
            }
        }

        private void btnReemplazarCondicional_Click(object sender, EventArgs e)
        {
            if (isCondicionalSeleccionado())
            {
                JugadorCondicional reemplazado = partido.getInscriptosCondicionales()[listInscriptosCondicionales.SelectedIndex];
                JugadorCondicional reemplazo = new JugadorCondicional("Reemplazo Condicional", 1, new Condicion());
                Inicio.jugadoresCondicionales.Add(reemplazo);

                partido.reemplazar(reemplazado, reemplazo);
                llenarListBox(listInscriptosCondicionales, partido.getInscriptosCondicionales());
            }
        }
    }
}
