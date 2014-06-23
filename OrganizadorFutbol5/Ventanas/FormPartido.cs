using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OrganizadorFutbol5.Clases;
using OrganizadorFurbol5.Ventanas;

namespace OrganizadorFutbol5.Ventanas
{
    public partial class FormPartido : Form
    {
        Partido partido;

        public FormPartido()
        {
            InitializeComponent();
        }

        public void abrir(Partido unPartido)
        {
            partido = unPartido;

            textBox1.Text = partido.getNombre();
            textBox2.Text = partido.fecha.ToString();
            llenarListBox(listBox1, partido.getInscriptosStandard());
            llenarListBox(listBox2, partido.getInscriptosSolidarios());
            llenarListBox(listBox3, partido.getInscriptosCondicionales());
            textBox3.Text = partido.getCantidadDeInscriptos().ToString();

            this.ShowDialog();
        }

        private void llenarListBox(ListBox listBox, List<Jugador> jugadores)
        {
            listBox.Items.Clear();
            foreach (Jugador jugador in jugadores)
            {
                listBox.Items.Add(jugador.ToString());
            }
        }


        private void llenarListBox(ListBox listBox, List<JugadorCondicional> jugadoresCondicionales)
        {
            listBox.Items.Clear();
            foreach (JugadorCondicional jugadorCondicional in jugadoresCondicionales)
            {
                listBox.Items.Add(jugadorCondicional.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isStandardSeleccionado())
            {
                partido.darDeBaja(partido.getInscriptosStandard()[listBox1.SelectedIndex]);
                llenarListBox(listBox1, partido.getInscriptosStandard());
                textBox3.Text = partido.getCantidadDeInscriptos().ToString();
            }
            else
                MessageBox.Show("Debe seleccionarl un Jugador Standard");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isSolidarioSeleccionado())
            {
                partido.darDeBaja(partido.getInscriptosSolidarios()[listBox2.SelectedIndex]);
                llenarListBox(listBox2, partido.getInscriptosSolidarios());
                textBox3.Text = partido.getCantidadDeInscriptos().ToString();
            }
            else
                MessageBox.Show("Debe seleccionarl un Jugador Solidario");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isCondicionalSeleccionado())
            {
                partido.darDeBaja(partido.getInscriptosCondicionales()[listBox3.SelectedIndex]);
                llenarListBox(listBox3, partido.getInscriptosCondicionales());
                textBox3.Text = partido.getCantidadDeInscriptos().ToString();
            }
            else
                MessageBox.Show("Debe seleccionarl un Jugador Condicional");
        }

        private bool isStandardSeleccionado()
        {
            return listBox1.SelectedIndex != -1;
        }

        private bool isSolidarioSeleccionado()
        {
            return listBox2.SelectedIndex != -1;
        }

        private bool isCondicionalSeleccionado()
        {
            return listBox3.SelectedIndex != -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isStandardSeleccionado())
            {
                Jugador reemplazado = partido.getInscriptosStandard()[listBox1.SelectedIndex];
                Jugador reemplazo = new Jugador("Reemplazo Standard", (decimal)9.9);
                HomeAdministrador.jugadores.Add(reemplazo);

                partido.reemplazar(reemplazado, reemplazo);
                llenarListBox(listBox1, partido.getInscriptosStandard());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isSolidarioSeleccionado())
            {
                Jugador reemplazado = partido.getInscriptosSolidarios()[listBox2.SelectedIndex];
                Jugador reemplazo = new Jugador("Reemplazo Solidario", 5);
                HomeAdministrador.jugadores.Add(reemplazo);

                partido.reemplazar(reemplazado, reemplazo);
                llenarListBox(listBox2, partido.getInscriptosSolidarios());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isCondicionalSeleccionado())
            {
                JugadorCondicional reemplazado = partido.getInscriptosCondicionales()[listBox3.SelectedIndex];
                JugadorCondicional reemplazo = new JugadorCondicional("Reemplazo Condicional", 1, new Condicion());
                HomeAdministrador.jugadores.Add(reemplazo);

                partido.reemplazar(reemplazado, reemplazo);
                llenarListBox(listBox3, partido.getInscriptosCondicionales());
            }
        }


    }
}
