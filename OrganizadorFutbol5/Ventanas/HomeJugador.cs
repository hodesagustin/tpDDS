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
    public partial class HomeJugador : Form
    {
        Commons commons = new Commons();
        
        public HomeJugador(int id)
        {
            InitializeComponent();

            DataBaseDataContext db = new DataBaseDataContext();

            
        }

        private void HomeJugador_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = commons.preguntaCierreSesion();
        }
    }
}
