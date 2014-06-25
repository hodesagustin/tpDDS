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
    public partial class FormCalificacion : Form
    {
        private Jugador jugador;

        public FormCalificacion(Jugador unJugador)
        {
            InitializeComponent();
            jugador = unJugador;
        }

        private void FormCalificacion_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            jugador.agregarCalificacion(txtDescripcion.Text, numPuntaje.Value);
            this.Close();
        }
    }
}
