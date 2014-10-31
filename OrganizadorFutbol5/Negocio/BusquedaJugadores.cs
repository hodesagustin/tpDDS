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
            //Comentado hasta tener la View:
            var consulta = from x in db.Jugadors//O la view en otro caso :P
                           select x;

            if (comienzaNombre != "")
            {
                consulta = consulta.Where(p => p.Nombre.StartsWith(comienzaNombre));
            }
            consulta = consulta.Where(p => p.FechaNacimiento <= fechaAnterior);
            if (!(handicapDesde == 0 && handicapHasta == 0)) //Chequear el valor mínimo y máximo de Handicap
            {
                consulta = consulta.Where(p => p.Handicap >= handicapDesde);
                consulta = consulta.Where(p => p.Handicap <= handicapHasta);
            }
          /*  if (!(promDesde == 0.00 && promHasta == 0.00)) //Chequear el valor mínimo y máximo de Promedio
            {
                consulta = consulta.Where(p => p.promedio >= promDesde);
                consulta = consulta.Where(p => p.promedio <= promHasta);
            } */
           
            /*
            if (infraccion == "Si")
            {
                consulta = consulta.Where(p => p.Infraccions == true);
            }
            else
            {
                if (infraccion == "No")
                {
                    consulta = consulta.Where(p => p.Infraccions == false);
                }
            }*/
            dg.DataSource = consulta;

            int i;
            for (i = 0; i == 0 || i < dg.Rows.Count - 1; i++)
            {
                if (int.Parse(dg.Rows[i].Cells[0].Value.ToString()) > 0)
                {
                    dg.Rows[i].Cells[1].Style.ForeColor = Color.Blue;
                }
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
