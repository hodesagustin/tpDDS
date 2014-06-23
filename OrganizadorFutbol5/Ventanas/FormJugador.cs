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
    public partial class FormJugador : Form
    {
        Jugador jugador;

        public FormJugador()
        {
            InitializeComponent();
        }

        public void abrir(Jugador unJugador)
        {
            jugador = unJugador;

            txtNombre.Text = jugador.getNombre();
            numCalificacion.Value = jugador.getCalificacion();

            btnCrear.Visible = false;

            this.ShowDialog();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Inicio.jugadores.Add(new Jugador(txtNombre.Text, numCalificacion.Value));

            this.Close();
        }
    }
}
