using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendarEvento
{
    public class EventoDAL
    {
        public static int AgendarEvento(Evento evento)
        {
            int retorna = 0;

            using(SqlConnection conexion = DBGeneral.ObtenerConexion())
            {
                string query = "insert into Evento(clienteid, comboid, Tipo_evento, fecha_evento, hora_inicio, hora_fin, Direccion, descripcion, Paquete, Animacion, Notas_adicionales) values(" + evento.ClienteId + " , " + evento.ComboId + " , '" + evento.TipoEvento + "' , '" + evento.FechaEvento + "' , '" + evento.HoraInicio + "' , '" + evento.HoraFin + "' , '" + evento.Direccion + "' , '" + evento.Descripcion + "' , '" + evento.Paquete + "' , '" + evento.Animacion + "' , '" + evento.NotasAdicionales + "')";
                SqlCommand comando = new SqlCommand(query, conexion);

                retorna= comando.ExecuteNonQuery();
            }
            return retorna;
        }
        public static int EliminarEvento(int eventoid)
        {
            int retorna = 0;

            using (SqlConnection conexion = DBGeneral.ObtenerConexion())
            {
                string query = "delete from Evento where eventoid=" + eventoid + "";
                SqlCommand comando = new SqlCommand(query, conexion);

                retorna = comando.ExecuteNonQuery();
            }

            return retorna;

        }

        public static List<Evento> PresentarEvento()
        {
            List<Evento> Lista = new List<Evento>();

            using (SqlConnection conexion = DBGeneral.ObtenerConexion())
            {

                string query = "Select * from Evento";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Evento Evento = new Evento();
                    Evento.EventoId = reader.GetInt32(0);
                    Evento.ClienteId = reader.GetInt32(1);
                    Evento.ComboId = reader.GetInt32(2);
                    Evento.TipoEvento = reader.GetString(3);
                    Evento.FechaEvento = reader.GetString (4);
                    Evento.HoraInicio = reader.GetString(5);
                    Evento.Direccion = reader.GetString(6);
                    Evento.Descripcion = reader.GetString(7);
                    Evento.Paquete = reader.GetString(8);
                    Evento.Animacion = reader.GetString(9);
                    Evento.NotasAdicionales = reader.GetString(10);
                    Lista.Add(Evento);


                }

                conexion.Close();
                return Lista;

            }


        }


    }
}
