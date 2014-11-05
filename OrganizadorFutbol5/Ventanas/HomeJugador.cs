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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
