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
            tb_nombre.Text = jugador.getNombre();
            nd_calificacion.Value = jugador.getCalificacion();

            bt_crear.Visible = false;

            this.ShowDialog();
        }

        private void bt_crear_Click(object sender, EventArgs e)
        {
            HomeAdministrador.jugadores.Add(new Jugador(tb_nombre.Text, nd_calificacion.Value));
            this.Close();
        }
    }
}
