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

            DataBaseDataContext db = new DataBaseDataContext();

            if (usuario_txt.Text == "")
            {
                MessageBox.Show("Ingrese un nombre de usuario.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var consulta = from x in db.Administradors
                           where x.Nombre.Equals(usuario_txt.Text)
                           select x;

            if (consulta.Count() != 0) //Encontró al Admin
            {
                (new HomeAdmin(int.Parse(consulta.First().ID.ToString()))).ShowDialog();
                usuario_txt.Text = "";
            }
            else
            {
                var consulta2 = from y in db.Jugadors
                                where y.Nombre.Equals(usuario_txt.Text)
                                select y;

                if (consulta2.Count() != 0) //Encontró al Jugador
                {
                    (new HomeJugador(int.Parse(consulta2.First().ID.ToString()))).ShowDialog();
                    usuario_txt.Text = "";
                }
                else
                {
                    MessageBox.Show("El Usuario no existe.","", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usuario_txt.Text = "";
                }
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Desea cerrar la applicación?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (!(dialogo == DialogResult.Yes))
               e.Cancel = true;
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
