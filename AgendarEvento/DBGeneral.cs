using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;


namespace AgendarEvento
{
    public class DBGeneral
    {
        public SqlConnection LeerCadena()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["unica"].ConnectionString);

            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            else
            {
                cn.Open();
            }
            return cn;
        }


        public static SqlConnection ObtenerConexion() 
        {
            SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Prueba;Data Source=LTP-CCTV-3\\SQLEXPRESS");
            conexion.Open();

            return conexion;
        }


    }
}
