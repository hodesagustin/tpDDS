using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace OrganizadorFutbol5.ConexionBase
{
    class ConexionDB
    {
        public static SqlConnection getConexion()
        {
            SqlConnection conexion = new SqlConnection(@"Data Source = localhost\SQLSERVER2008; Initial Catalog =DDS2014; User Id =OrganizadorFutbol5; Password =dds");
            conexion.Open();
            return conexion;
        }
    }
}
