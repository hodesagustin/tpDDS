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
        DataBaseDataContext db = new DataBaseDataContext();
        int ID;

        public HomeAdmin(int id)
        {
            ID = id;
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

        private void HomeAdmin_Activated(object sender, EventArgs e)
        {
            var consulta = from x in db.Partidos
                           select x;
            dataGridView1.DataSource = consulta;
            dataGridView1.Columns["AdministradorID"].Visible = false;
            dataGridView1.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss.fff";
            dataGridView1.Columns["ID"].Width = 150; 
            dataGridView1.Columns["Fecha"].Width = 170;
            dataGridView1.Columns["Administrador"].Visible = false;
            dataGridView1.Columns[0].HeaderCell.Value = "Numero de Partido";
            dataGridView1.Columns[2].HeaderCell.Value = "Fecha y Hora del Partido";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new AltaPartido(ID)).ShowDialog();
        }



    }
}
