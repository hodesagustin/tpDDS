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
    public partial class CrearPartido : Form
    {
        string nombreNuevoPartido;

        public CrearPartido()
        {
            InitializeComponent();
        }

        private void tb_nombrePartido_TextChanged(object sender, EventArgs e)
        {
            nombreNuevoPartido = tb_nombrePartido.Text;
        }

        private void bt_aplicar_Click(object sender, EventArgs e)
        {
            Partido partido = new Partido (nombreNuevoPartido);
            Inicio.nuevoPartido = partido;
            this.Close();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
