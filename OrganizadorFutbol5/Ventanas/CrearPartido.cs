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

        private void button1_Click(object sender, EventArgs e)
        {
            Partido partido = new Partido(textBox1.Text, dateTimePicker1.Value);
            HomeAdministrador.partidos.Add(partido);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
