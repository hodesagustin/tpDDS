﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrganizadorFutbol5.Ventanas
{
    public partial class HomeJugador : Form
    {
        public HomeJugador(int id)
        {
            InitializeComponent();
        }

        private void HomeJugador_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Desea salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogo == DialogResult.Yes)
                (new Login()).Show();
        }
    }
}
