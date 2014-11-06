﻿using System;
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

            listBoxAmigosParaReemplazo.DataSource = amigos;

            dataGridView2.DataSource = partidos;

            refrescarDataGridView();

            var inscripciones = from x in db.Inscripcions
                                where x.JugadorID == jugadorID
                                select x;

            dataGridViewBaja.DataSource = inscripciones;

            dataGridViewBaja.Columns["Partido"].Visible = false;
            dataGridViewBaja.Columns["Jugador"].Visible = false;
            dataGridViewBaja.Columns["JugadorID"].Visible = false;
            dataGridViewBaja.Columns["PartidoID"].Width = 130;
            dataGridViewBaja.Columns[2].HeaderCell.Value = "N°Partido";
        }

        private void refrescarDataGridView()
        {
            var calificacionesPendientes = from x in db.CalificacionPendientes
                                           where x.CalificadorID == jugadorID
                                           select x;

            dataGridViewCalificacionesPendientes.DataSource = calificacionesPendientes;
            dataGridViewCalificacionesPendientes.Columns["JugadorID"].Visible = false;
            dataGridViewCalificacionesPendientes.Columns["Partido"].Visible = false;
            dataGridViewCalificacionesPendientes.Columns["CalificadorID"].Visible = false;
            dataGridViewCalificacionesPendientes.Columns["Jugador"].Visible = false;
            dataGridViewCalificacionesPendientes.Columns[2].HeaderCell.Value = "N° Partido";
            dataGridViewCalificacionesPendientes.Columns[5].HeaderCell.Value = "Calificado";

            var calificaciones = from x in db.Calificacions
                                 where x.CalificadorID == jugadorID
                                 select x;

            dataGridViewCalificaciones.DataSource = calificaciones;
            dataGridViewCalificaciones.Columns["Partido"].Visible = false;
            dataGridViewCalificaciones.Columns["JugadorID"].Visible = false;
            dataGridViewCalificaciones.Columns["CalificadorID"].Visible = false;
            dataGridViewCalificaciones.Columns["Jugador"].Visible = false;
            dataGridViewCalificaciones.Columns[1].HeaderCell.Value = "N° Partido";
            dataGridViewCalificaciones.Columns[6].HeaderCell.Value = "Calificado";

            var inscripciones = from x in db.Inscripcions
                                where x.JugadorID == jugadorID
                                select x;

            dataGridViewBaja.DataSource = inscripciones;
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
            else if (solidaria.Checked)
                inscripccion.Prioridad = 2;
            else
                inscripccion.Prioridad = 3;


            Partido partido = (from p in db.Partidos
                              where p.ID == inscripccion.PartidoID
                              select p).First();
            partido.inscribir(inscripccion);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            VisualizarJugador visualizacion = new VisualizarJugador(jugadorID);
            visualizacion.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0)
                return;
            
            int partidoID = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["ID"].Value);

            Partido partido = (from p in db.Partidos
                               where p.ID == partidoID 
                               select p).First();

            if (listBoxAmigos.SelectedItem != null)
            {
                string test = listBoxAmigos.SelectedItem.ToString();
                partido.proponerAmigo(listBoxAmigos.SelectedItem.ToString());
            }
            else
                MessageBox.Show("Debe seleccionar un amigo de la lista");
        }

        private void dataGridViewCalificacionesPendientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int partidoID = Convert.ToInt32(dataGridViewCalificacionesPendientes.Rows[e.RowIndex].Cells["PartidoID"].Value);

            int calificadoID = Convert.ToInt32(dataGridViewCalificacionesPendientes.Rows[e.RowIndex].Cells["JugadorID"].Value);

            Calificacion unaCalificacion = new Calificacion() { CalificadorID = jugadorID, Descripcion = textBox1.Text, JugadorID = calificadoID, PartidoID = partidoID, Puntaje = Convert.ToByte(numericUpDown1.Value) };

            db.Calificacions.InsertOnSubmit(unaCalificacion);
            db.SubmitChanges();

            var calificacionPendiente = (from x in db.CalificacionPendientes
                                        where x.CalificadorID == jugadorID && x.PartidoID == partidoID && x.JugadorID == calificadoID
                                        select x).First();

            db.CalificacionPendientes.DeleteOnSubmit(calificacionPendiente);
            db.SubmitChanges();

            MessageBox.Show("La calificación fue ejecutada correctamente");

            refrescarDataGridView();

        }

        private void dataGridViewJugadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            Partido unPartido = (from i in db.Partidos
                                         where i.ID == Convert.ToInt32(dataGridViewBaja.Rows[e.RowIndex].Cells["PartidoID"].Value)
                                         select i).First();
            Jugador unJugador = (from i in db.Jugadors
                                 where i.ID == jugadorID
                                 select i).First();


            if (e.ColumnIndex == 0) //Baja con reemplazo
            {

                if (listBoxAmigosParaReemplazo.SelectedValue != null)
                {
                    unPartido.baja(unJugador, listBoxAmigosParaReemplazo.SelectedValue.ToString());
                    
                }
                else
                    MessageBox.Show("Debe seleccionar un amigo para proponer como reemplazo");
            }
            if (e.ColumnIndex == 1) //Baja sin reemplazo
            {

                unPartido.baja(unJugador);

                
            }
            refrescarDataGridView();
        }
    }
}
