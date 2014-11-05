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

        int jugadorID;
        DataBaseDataContext db = new DataBaseDataContext();

        public HomeJugador(int id)
        {
            jugadorID = id;

            InitializeComponent();

            

            var partidos = from x in db.Partidos
                               select new {x.ID , x.Fecha };

            dataGridView1.DataSource = partidos;

            var amigos = from x in db.JugadorAmigos
                         where x.JugadorID == jugadorID
                         select x.AmigoNombre;

            listBoxAmigos.DataSource = amigos;

            dataGridView2.DataSource = partidos;



        }

        private void HomeJugador_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = commons.preguntaCierreSesion();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Inscripcion inscripccion = new Inscripcion();
            inscripccion.Fecha = System.DateTime.Now;
            inscripccion.JugadorID = jugadorID;
            inscripccion.PartidoID = (decimal) dataGridView1.Rows[e.RowIndex].Cells["ID"].Value;
            if (standard.Checked)
                inscripccion.Prioridad = 1;
            if (solidaria.Checked)
                inscripccion.Prioridad = 2;
            else
                inscripccion.Prioridad = 3;


            Partido partido = (from p in db.Partidos
                              where p.ID == inscripccion.PartidoID
                              select p).First();
            partido.inscribir(inscripccion);

            MessageBox.Show("La inscripción al partido fue exitosa");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            VisualizarJugador visualizacion = new VisualizarJugador(jugadorID);
            visualizacion.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int partidoID = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["ID"].Value);

            Partido partido = (from p in db.Partidos
                               where p.ID == partidoID 
                               select p).First();

            string test = listBoxAmigos.SelectedItem.ToString();

            partido.proponerAmigo(listBoxAmigos.SelectedItem.ToString());

            MessageBox.Show("El amigo ha sido propuesto al partido seleccionado");
        }
    }
}
