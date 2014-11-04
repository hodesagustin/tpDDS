using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OrganizadorFutbol5.Negocio;

namespace OrganizadorFutbol5.Ventanas
{
    public partial class HomeAdmin : Form
    {
        Commons commons = new Commons();
        
        public HomeAdmin(int id)
        {
            InitializeComponent();
        }

        private void HomeAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = commons.preguntaCierreSesion();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new BusquedaJugadores()).Show();
        }
    }
}
