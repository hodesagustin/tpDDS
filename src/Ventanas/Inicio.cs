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

namespace OrganizadorFutbol5
{
    public partial class Inicio : Form
    {
        public static Partido nuevoPartido;

        public Inicio()
        {
            InitializeComponent();
        }

        private void bt_crearPartido_Click(object sender, EventArgs e)
        {
            CrearPartido crearPartido = new CrearPartido();
            crearPartido.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void lb_listaPartidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_partidoSeleccionado.Text = lb_listaPartidos.Text;
        }

        private void Inicio_Activated(object sender, EventArgs e)
        {
           if(nuevoPartido != null)
               if (lb_listaPartidos.Items.Contains(nuevoPartido.getNombre()))
               {
                   nuevoPartido = null;            
               }
               else
                   lb_listaPartidos.Items.Add(nuevoPartido.getNombre());
           this.Show();
        }

        private void bt_inscribirse_Click(object sender, EventArgs e)
        {
            Inscripcion inscripcion = new Inscripcion();
            inscripcion.setPartido(nuevoPartido);
            inscripcion.Show();
            this.Hide();
        }
     }
}
