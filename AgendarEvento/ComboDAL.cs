using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendarEvento
{
    public class ComboDAL
    {
        public static int AgregarCombo(Combo combo)
        {
            int retorna = 0;

            using (SqlConnection conexion = DBGeneral.ObtenerConexion())
            {
                string query = "insert into Combo (nombre_Combo, descripcion) values('" + combo.Nombre + "' , '" + combo.Descripcion + "')";
                SqlCommand comando = new SqlCommand(query, conexion);

                retorna = comando.ExecuteNonQuery();
            }

            return retorna;

        }

        public static List<Combo> PresentarCombo()
        {
            List<Combo> Lista = new List<Combo>();

            using (SqlConnection conexion = DBGeneral.ObtenerConexion())
            {

                string query = "Select * from Combo";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Combo combo = new Combo();
                    combo.Comboid = reader.GetInt32(0);
                    combo.Nombre = reader.GetString(1);
                    combo.Descripcion = reader.GetString(2);
        
                    Lista.Add(combo);

                }

                conexion.Close();
                return Lista;

            }
        }

        public static int ModificarCombo(Combo combo)
        {
            int result = 0;
            using (SqlConnection conexion = DBGeneral.ObtenerConexion())
            {
                string query = "update Combo set nombre_Combo='" + combo.Nombre + "' , descripcion='" + combo.Descripcion + "' where comboid= "+combo.Comboid+"  ";
                SqlCommand comando = new SqlCommand(query, conexion);

                result = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return result;

        }

        public static int EliminarCombo(int comboid)
        {
            int retorna = 0;

            using (SqlConnection conexion = DBGeneral.ObtenerConexion())
            {
                string query = "delete from Combo where comboid=" + comboid + "";
                SqlCommand comando = new SqlCommand(query, conexion);

                retorna = comando.ExecuteNonQuery();
            }

            return retorna;

        }



    }
}
