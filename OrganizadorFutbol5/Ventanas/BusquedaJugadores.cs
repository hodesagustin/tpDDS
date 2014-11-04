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
    public partial class BusquedaJugadores : Form
    {
        public BusquedaJugadores()
        {
            InitializeComponent();
        }

        Negocio.BusquedaJugadores obj = new Negocio.BusquedaJugadores();
        
        private void buscar_btn_Click(object sender, EventArgs e)
        {
            String infraccion;
            if (infracSi_btn.Checked)
            {
                infraccion = "Si";
            }
            else 
            {
                if (infracNo_btn.Checked)
                {
                    infraccion = "No";
                }
                else
                {
                    infraccion = "Todos";
                }
            }

            obj.buscar(dataGridView1, nombre_txt.Text, DateTime.Parse(fechaNac_dtp.Text), int.Parse(handDesde_nud.Text), int.Parse(handHasta_nud.Text), float.Parse(promDesde_nud.Text), float.Parse(promHasta_nud.Text), infraccion);

        }

        private void limpiar_btn_Click(object sender, EventArgs e)
        {
            obj.limpiarGroupbox(criterios_gbx);
        }

        bool estaChequeadoNo = false;
        private void infracNo_btn_CheckedChanged(object sender, EventArgs e)
        {
            estaChequeadoNo = infracNo_btn.Checked;
        }
        private void infracNo_btn_Click(object sender, EventArgs e)
        {
            if (infracNo_btn.Checked && !estaChequeadoNo)
                infracNo_btn.Checked = false;
            else
            {
                infracNo_btn.Checked = true;
                estaChequeadoNo = false;
            }
        }

        bool estaChequeadoSi = false;
        private void infracSi_btn_CheckedChanged(object sender, EventArgs e)
        {
            estaChequeadoSi = infracSi_btn.Checked;
        }
        private void infracSi_btn_Click(object sender, EventArgs e)
        {
            if (infracSi_btn.Checked && !estaChequeadoSi)
                infracSi_btn.Checked = false;
            else
            {
                infracSi_btn.Checked = true;
                estaChequeadoSi = false;
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex!= -1)
            {
                (new VisualizarJugador(int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()))).ShowDialog();
            }
        }


    }
}
