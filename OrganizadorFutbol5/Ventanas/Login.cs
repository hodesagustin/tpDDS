using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrganizadorFutbol5.Ventanas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void entrar_btn_Click(object sender, EventArgs e)
        {
            //CUIDADO: Validar que el nombre del Admin no esté como nombre de un Jugador.
            //Osea, al crear un Jugador debe validarse eso.



        }
    }
}
