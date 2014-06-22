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
    public partial class Inscripcion : Form
    {
        Partido partido;

        public Inscripcion()
        {
            InitializeComponent();
        }
        public void setPartido(Partido unPartido)
        {
            partido = unPartido;
        }

        private void Inscripcion_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Partido: " + partido.getNombre());
        }
    }
}
