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

            var p = (from x in db.Partidos
                                where x.ID == partidoID
                                select x).First();
            textBox1.Text = p.Fecha.ToString();
            setEstadoPartido((int) p.Estado);

            cmbCriterioOrdenamiento.SelectedIndex = 0;
            cmbCriterioDivision.SelectedIndex = 0;
        }

        private void setEstadoPartido(int estado)
        {
            switch (estado)
            {
                case 0:
                    textBox3.Text = "Nuevo";
                    break;
                case 1:
                    textBox3.Text = "Confirmado";
                    break;
                default:
                    textBox3.Text = "Finalizado";
                    break;
            }
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
            if (textBox3.Text == "Nuevo")
                if (textBox2.Text != "")
                    (new RechazarJugador(textBox2.Text, partidoID)).ShowDialog();
                else
                    MessageBox.Show("Seleccione una inscripción pendiente.");
            else
                MessageBox.Show("El Estado del Partido no permite rechazar Pendientes.");
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
            if (textBox3.Text == "Nuevo")
            {
                if (textBox2.Text != "")
                    (new AltaJugador(textBox2.Text, partidoID)).ShowDialog();
                else
                    MessageBox.Show("Seleccione una inscripción pendiente.");
            }
            else 
            {
                MessageBox.Show("El Estado del Partido no permite aceptar Pendientes.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox3.Text == "Nuevo")
                if (dataGridView1.RowCount == 10)
                {
                    Partido partido = (from x in db.Partidos
                                       where x.ID == partidoID
                                       select x).First();

                    CriterioDivision criterioDivision;
                    if (cmbCriterioDivision.Text == "Par Impar")
                        criterioDivision = new CriterioDivisionParImpar();
                    else
                        criterioDivision = new CriterioDivisionPredeterminado();
                    
                    partido.equipoA.Clear();
                    partido.equipoB.Clear();
                    partido.generarEquipos(new CriterioOrdenamientoPorHandicap(), criterioDivision);

                    cargarEquipos();
                }
                else
                {
                    MessageBox.Show("Debe haber 10 jugadores inscriptos.");
                }
            else
                MessageBox.Show("El Estado del Partido no permite Generar Equipos.");
        }

        private void cargarEquipos()
        {
            var consulta = from x in db.PartidoEquipos
                           where x.PartidoID == partidoID
                           orderby x.Equipo
                           select x;

            dataGridView3.DataSource = consulta;
        }

        private void btnFinalizarPartido_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "Confirmado")
            {
                var partido = (from p in db.Partidos
                               where p.ID == partidoID
                               select p).First();
                partido.Estado = 2;
                db.SubmitChanges();

                partido.generarCalificacionesPendientes();

                setEstadoPartido(2);

                MessageBox.Show("Partido Finalizado. Se crearon las Calificaciones Pendientes");
                this.Close();
            }
            else
                if (textBox3.Text == "Finalizado")
                    MessageBox.Show("El Partido ya ha Finalizado.");
                else
                    MessageBox.Show("Deben estar Confirmados los equipos para poder Finalizar el Partido.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox3.Text=="Nuevo" && dataGridView3.RowCount == 10)
            {
                var p = (from x in db.Partidos
                         where x.ID == partidoID
                         select x).First();
                p.Estado = 1;
                db.SubmitChanges();
                setEstadoPartido(1);
                MessageBox.Show("Se han confirmado los equipos.");
            }
            else
            {
                if (textBox3.Text == "Finalizado")
                    MessageBox.Show("El Partido ya ha Finalizado.");
                else if (textBox3.Text == "Confirmado")
                    MessageBox.Show("Los equipos ya han sido confirmados.");
                else
                    MessageBox.Show("Debe generar los equipos para poder confirmarlo.");
            }
        }
    }
}
