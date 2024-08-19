using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendarEvento
{
    public class ClienteDAL
    {
        public static int AgregarCliente(Cliente cliente)
        {
            int retorna = 0;

            using (SqlConnection conexion = DBGeneral.ObtenerConexion())
            {
                string query = "insert into Clientes (nombre, email, Cedula, telefono, Direccion, Otro_Contacto) values('" + cliente.Nombre + "' , '" + cliente.Email + "' , '" + cliente.Cedula + "' , '" + cliente.Telefono + "' , '" + cliente.Direccion + "' , '" + cliente.OtroContacto + "')";
                SqlCommand comando = new SqlCommand(query, conexion);

                retorna = comando.ExecuteNonQuery();
            }

            return retorna;

        }


        public static List<Cliente> PresentarClientes()
        {
            List<Cliente> Lista = new List<Cliente>();

            using (SqlConnection conexion = DBGeneral.ObtenerConexion())
            {

                string query = "Select * from Clientes";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.ClienteId = reader.GetInt32(0);
                    cliente.Nombre = reader.GetString(1);
                    cliente.Email = reader.GetString(2);
                    cliente.Cedula = reader.GetString(3);
                    cliente.Telefono = reader.GetString(4);
                    cliente.Direccion = reader.GetString(5);
                    cliente.OtroContacto = reader.GetString(6);
                    Lista.Add(cliente);


                }

                conexion.Close();
                return Lista;

            }


        }

        public static int ModificarCliente(Cliente cliente)
        {
            int result = 0;
            using (SqlConnection conexion = DBGeneral.ObtenerConexion())
            {
                string query = "update clientes set nombre='"+cliente.Nombre+ "' , email='" + cliente.Email + "' , Cedula='" + cliente.Cedula + "' , telefono='" + cliente.Telefono + "' , Direccion='" + cliente.Direccion + "' , Otro_Contacto='" + cliente.OtroContacto + "' where clienteid= "+cliente.ClienteId+"    ";
                SqlCommand comando = new SqlCommand(query,conexion);

                result = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return result;

        }

        public static int EliminarCliente(int clienteid)
        {
            int retorna = 0;

            using (SqlConnection conexion = DBGeneral.ObtenerConexion())
            {
                string query = "delete from clientes where clienteid=" + clienteid + "";
                SqlCommand comando = new SqlCommand(query, conexion);

                retorna = comando.ExecuteNonQuery();
            }

            return retorna;

        }




    }
}
