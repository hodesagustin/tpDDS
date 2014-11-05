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
    public partial class RechazarJugador : Form
    {
        string personaNombre;
        int idPartido;
        DataBaseDataContext db = new DataBaseDataContext();

        public RechazarJugador(string nombre, int id)
        {
            personaNombre = nombre;
            idPartido = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Especifique un motivo de rechazo");
            else
            {
                Rechazo r = new Rechazo();
                r.PartidoID = idPartido;
                r.PersonaNombre = personaNombre;
                r.Fecha = System.DateTime.Now;
                r.Motivo = textBox1.Text;

                db.Rechazos.InsertOnSubmit(r);
                db.SubmitChanges();

                InscripcionPendiente ip = (from x in db.InscripcionPendientes
                                           where x.PersonaNombre == personaNombre && x.PartidoID == idPartido
                                           select x).First();

                db.InscripcionPendientes.DeleteOnSubmit(ip);
                db.SubmitChanges();
                MessageBox.Show("Rechazo realizado con éxito.");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
