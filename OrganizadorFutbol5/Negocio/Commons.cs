using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using OrganizadorFutbol5;
using OrganizadorFutbol5.Ventanas;

namespace OrganizadorFutbol5.Negocio
{
    public class Commons
    {
        public const int handicap = 4;

        public void colorear(DataGridView dg, int i)
        {
            if (int.Parse(dg.Rows[i].Cells[4].Value.ToString()) > handicap)
            {
                dg.Rows[i].Cells[1].Style.ForeColor = Color.Blue;
            }
        }

        public void colorear(Control txt, int i)
        {
            if (i> handicap)
            {
                txt.ForeColor = Color.Blue;
            }
        }

        public bool preguntaCierreSesion()
        {
            DialogResult dialogo = MessageBox.Show("Desea cerrar sesión?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.Yes)
            {
                return false;
            }
            else
                return true;
        }
    }
}
