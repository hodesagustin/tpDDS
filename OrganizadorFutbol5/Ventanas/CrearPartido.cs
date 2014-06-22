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
        public CrearPartido()
        {
            InitializeComponent();
        }

        private void bt_aplicar_Click(object sender, EventArgs e)
        {
            Partido partido = new Partido (tb_nombrePartido.Text);
            Inicio.partidos.Add(partido);
            this.Close();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
