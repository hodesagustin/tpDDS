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
    public partial class AltaJugador : Form
    {
        DataBaseDataContext db = new DataBaseDataContext();
        string personaNombre;
        int partidoID;
        
        public AltaJugador(string nombre, int id)
        {
            personaNombre = nombre;
            partidoID = id;
            InitializeComponent();
            textBox1.Text = personaNombre;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text == "")
            {
                Jugador j = new Jugador();
                j.Nombre = personaNombre;
                j.FechaNacimiento = DateTime.Parse(dateTimePicker1.Text);
                j.Mail = textBox2.Text + comboBox1.Text;

                db.Jugadors.InsertOnSubmit(j);
                db.SubmitChanges();

                Partido partido = (from x in db.Partidos
                                    where x.ID == partidoID
                                    select x).First();

                Inscripcion ins = new Inscripcion()
                {
                    JugadorID = j.ID,
                    PartidoID = partidoID,
                    Fecha = System.DateTime.Now,
                    Prioridad = comboBox2.SelectedIndex +1
                };

                //db.Inscripcions.InsertOnSubmit(ins);
                //db.SubmitChanges();
                partido.inscribir(ins);

                InscripcionPendiente ip = (from x in db.InscripcionPendientes
                                           where x.PersonaNombre == personaNombre && x.PartidoID == partidoID
                                           select x).First();

                db.InscripcionPendientes.DeleteOnSubmit(ip);
                db.SubmitChanges();

                MessageBox.Show("Se ha confirmado el jugador.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ingrese todos los datos.");
            }
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Condicional")
            {
                label5.Visible = true;
                textBox3.Visible = true;
            }
            else
            {
                label5.Visible = false;
                textBox3.Visible = false;
            }
        }
    }
}
