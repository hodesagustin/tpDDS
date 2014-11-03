using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using OrganizadorFutbol5;

namespace OrganizadorFutbol5.Negocio
{
    class BusquedaJugadores
    {
        DataBaseDataContext db = new DataBaseDataContext(); 
        
        public void buscar(DataGridView dg, string comienzaNombre, DateTime fechaAnterior, int handicapDesde, int handicapHasta, float promDesde, float promHasta, string infraccion)
        {
            var consulta = from x in db.Jugadors
                           join y in db.Promedio_Ultimo_Partidos on x.ID equals y.Jugador
                           select new {x.ID, x.Nombre, x.FechaNacimiento,x.Handicap, y.Promedio} ;

            if (comienzaNombre != "")
            {
                consulta = consulta.Where(p => p.Nombre.StartsWith(comienzaNombre));
            }
            consulta = consulta.Where(p => p.FechaNacimiento <= fechaAnterior);
            if (!(handicapDesde == 0 && handicapHasta == 0))
            {
                consulta = consulta.Where(p => p.Handicap >= handicapDesde);
                consulta = consulta.Where(p => p.Handicap <= handicapHasta);
            }

            if (infraccion == "Si")
            {
                consulta = from x in consulta
                           join y in db.Infraccions on x.ID equals y.JugadorID
                           select x;
            }
            else
            {
                if (infraccion == "No")
                {
                    consulta = from x in consulta
                               from y in db.Infraccions
                               where x.ID != y.JugadorID
                               select x;
                }
            }

            if (!(promDesde == 0.00 && promHasta == 0.00))
            {

                consulta = from x in consulta
                           where x.Promedio >= promDesde && x.Promedio <= promHasta
                           select x;
            }

            int cantidad = consulta.Count();
            if (cantidad != 0)
            {
                dg.DataSource = consulta;
                dg.Columns["ID"].Visible = false;
                dg.Columns["FechaNacimiento"].Visible = false;

                int i;
                for (i = 0; i == 0 || i < dg.Rows.Count; i++)
                {
                    if (int.Parse(dg.Rows[i].Cells[3].Value.ToString()) > 2)
                    {
                        dg.Rows[i].Cells[1].Style.ForeColor = Color.Blue;
                    }
                }
            }
            else
            {
                dg.DataSource = null;
                MessageBox.Show("No se han encontrado Jugadores","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        public void limpiarGroupbox(GroupBox gb)
        {
            try
            {
                foreach (GroupBox g in gb.Controls.OfType<GroupBox>())
                    limpiarGroupbox(g);
                foreach (TextBox t in gb.Controls.OfType<TextBox>())
                    t.Text = "";
                foreach (DateTimePicker dtp in gb.Controls.OfType<DateTimePicker>())
                    dtp.Text = DateTime.Now.ToLongDateString();
                foreach (RadioButton rb in gb.Controls.OfType<RadioButton>())
                    rb.Checked = false;
                foreach (NumericUpDown nud in gb.Controls.OfType<NumericUpDown>())
                    nud.Text = "0";
                foreach (DataGridView dg in gb.Controls.OfType<DataGridView>())
                    dg.DataSource = null;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
