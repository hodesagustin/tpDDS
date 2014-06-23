using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using OrganizadorFutbol5.ConexionBase;

namespace OrganizadorFutbol5.Ventanas
{
    public partial class RegistroUsuario : Form
    {
        Ventanas.Login anterior;

        public RegistroUsuario(Ventanas.Login ventana)
        {
            anterior = ventana;
            InitializeComponent();
        }

        private void registrarme_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (contraseña_txt.Text.Equals(confContraseña_txt.Text))
                {
                    using (SqlConnection conexion = ConexionBase.ConexionDB.getConexion())
                    {
                        SqlCommand cmd = new SqlCommand("MEINFÜHRER.InsertarInteresado", conexion);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Usuario", usuario_txt.Text);
                        cmd.Parameters.AddWithValue("@Contraseña", contraseña_txt.Text);
                        cmd.Parameters.AddWithValue("@Nombre", nombre_txt.Text);
                        cmd.Parameters.AddWithValue("@Apellido", apellido_txt.Text);
                        cmd.Parameters.AddWithValue("@Edad", Convert.ToInt32(edad_txt.Text));
                        cmd.Parameters.AddWithValue("@Mail", email_txt.Text);
                        cmd.Parameters.Add("@Respuesta", SqlDbType.NVarChar, 100).Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();

                        string respuesta = (cmd.Parameters["@Respuesta"].Value.ToString());
                        MessageBox.Show(respuesta);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Contraseña no confirmada. Intente nuevamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "/nIngrese todos los datos por favor.");
            }
        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            anterior.Show();
        }
    }
}
