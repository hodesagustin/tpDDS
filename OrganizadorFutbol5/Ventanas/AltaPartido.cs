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
    public partial class AltaPartido : Form
    {
        DataBaseDataContext db = new DataBaseDataContext();
        int ID;
        public AltaPartido(int id)
        {
            ID = id;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AltaPartido_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            /*
            var consulta = from x in db.Partidos
                           select x.Fecha;
            foreach (var item in comboBox1.Items)
            {
                if(
            }*/
        }

        public void detemrinarHora(DateTime dt)
        {
            //if(dt.ToString("dd/mm/yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Partido p = new Partido();
            MessageBox.Show(comboBox1.Text);
            string fecha = DateTime.Parse(dateTimePicker1.Text).ToString("yyyy-MM-dd") + " " + comboBox1.Text + ":00,000";
            
            p.Fecha = DateTime.ParseExact(fecha, "yyyy-MM-dd HH:mm:ss,fff", System.Globalization.CultureInfo.InvariantCulture);

            MessageBox.Show(p.Fecha.ToString());
            
            p.AdministradorID = ID;
            db.Partidos.InsertOnSubmit(p);
            db.SubmitChanges();

            MessageBox.Show("El Partido ha sido creado");
            this.Close();
        }
    }
}
