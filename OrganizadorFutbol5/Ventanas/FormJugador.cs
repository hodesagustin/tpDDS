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
            textBox1.Text = jugador.getNombre();
            numericUpDown1.Value = jugador.getCalificacion();

            button1.Visible = false;

            this.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeAdministrador.jugadores.Add(new Jugador(textBox1.Text, numericUpDown1.Value));
            this.Close();
        }
    }
}
