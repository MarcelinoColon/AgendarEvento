using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendarEvento
{
    public class Categorias
    {
        DBGeneral cn = new DBGeneral();

        public DataTable CargarClientes()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_CargarClientes",cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public DataTable CargarCombos()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_CargarCombos", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }


    }
}
