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
    public class Commons
    {
        public const int handicap = 4;

        public void colorear(DataGridView dg, int i)
        {
            if (int.Parse(dg.Rows[i].Cells[3].Value.ToString()) > handicap)
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
    }
}
