using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OrganizadorFutbol5.Ventanas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void salir_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ingresar_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexion = ConexionBase.ConexionDB.getConexion())
            {
                string respuesta = "";
                string respuestaAdmin = "";

                using (SqlCommand cmd = new SqlCommand("MEINFÜHRER.LoginUsuario", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Usuario", usuario_txt.Text);
                    cmd.Parameters.AddWithValue("@Contraseña", contraseña_txt.Text);
                    cmd.Parameters.Add("@Respuesta", SqlDbType.NVarChar, 100).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();

                    respuesta = (cmd.Parameters["@Respuesta"].Value.ToString());
                    if (String.Equals(respuesta, "Abrir Sesion"))
                    {
                        using (SqlCommand cmd2 = new SqlCommand("USE DDS2014 SELECT Id_Usuario FROM MEINFÜHRER.Usuario WHERE Name='" + usuario_txt.Text+"'", conexion))
                        {
                            SqlDataAdapter adaptador = new SqlDataAdapter(cmd2);
                            DataSet dataSet = new DataSet();
                            adaptador.Fill(dataSet, "MEINFÜHRER.Usuario");
                            string idUsuario = dataSet.Tables[0].Rows[0][0].ToString();

                              using (SqlCommand cmd3 = new SqlCommand("MEINFÜHRER.EsAdmin", conexion))
                              {
                                cmd3.CommandType = CommandType.StoredProcedure;
                                cmd3.Parameters.AddWithValue("@IdUsuario", int.Parse(idUsuario));
                                cmd3.Parameters.Add("@Respuesta", SqlDbType.NVarChar, 100).Direction = ParameterDirection.Output;
                                cmd3.ExecuteNonQuery();

                                respuestaAdmin = (cmd3.Parameters["@Respuesta"].Value.ToString());
                                if (String.Equals(respuestaAdmin, "Is Admin"))
                                {
                                    HomeAdministrador homeAdmin = new HomeAdministrador(int.Parse(idUsuario));
                                    homeAdmin.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    HomeInteresado homeInter = new HomeInteresado(int.Parse(idUsuario));
                                    homeInter.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(respuesta);
                    }
                }
                }
        }

        private void registrar_btn_Click(object sender, EventArgs e)
        {
            RegistroUsuario reg = new RegistroUsuario(this);
            reg.Show();
            this.Hide();
        }
    }
}
