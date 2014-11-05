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
    public partial class VisualizarPartido : Form
    {
        int partidoID;

        DataBaseDataContext db = new DataBaseDataContext();

        public VisualizarPartido(int id)
        {
            partidoID = id;
            InitializeComponent();

            var consultaFecha = from x in db.Partidos
                                where x.ID == partidoID
                                select x.Fecha;
            textBox1.Text = consultaFecha.First().ToString();

        }

        private void VisualizarPartido_Load(object sender, EventArgs e)
        {
            var consultaInscriptos = from x in db.Inscripcions
                                     from y in db.Jugadors
                                     where x.PartidoID == partidoID && x.JugadorID == y.ID
                                     select new { y.Nombre, y.Mail, x.Prioridad };
            dataGridView1.DataSource = consultaInscriptos;

            var consultaPendientes = from x in db.InscripcionPendientes
                                     where x.PartidoID == partidoID
                                     select x;

            dataGridView2.DataSource = consultaPendientes;
            dataGridView2.Columns["PartidoID"].Visible = false;
            dataGridView2.Columns["Partido"].Visible = false;
            textBox2.Text = "";

            cargarEquipos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
                (new RechazarJugador(textBox2.Text, partidoID)).ShowDialog();
            else
                MessageBox.Show("Seleccione una inscripción pendiente.");
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex != -1 && dataGridView2.Rows[e.RowIndex].Cells[1].Value != null)
            {
                textBox2.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void VisualizarPartido_Activated(object sender, EventArgs e)
        {
            VisualizarPartido_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
                (new AltaJugador(textBox2.Text, partidoID)).ShowDialog();
            else
                MessageBox.Show("Seleccione una inscripción pendiente.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 10)
            {
                Partido partido = (from x in db.Partidos
                                   where x.ID == partidoID
                                   select x).First();

                partido.generarEquipos(new CriterioOrdenamientoPorHandicap(), new CriterioDivisionParImpar());

                cargarEquipos();
            }
            else
            {
                MessageBox.Show("Debe haber al menos 10 jugadores inscriptos.");
            }
        }

        private void cargarEquipos()
        {
            var consulta = from x in db.PartidoEquipos
                           where x.PartidoID == partidoID
                           orderby x.Equipo
                           select x;

            dataGridView3.DataSource = consulta;
        }
    }
}
