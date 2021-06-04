using Administracion_Torneos.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administracion_Torneos.BD
{
    public class BitacoraDB
    {
        private string connectionString = "Server=DESKTOP-EJ193JG;Database=Proyecto_AdministracionTorneosFutbol;User Id=capacitacion;Password=12345;";

        public void GetUsuarios(ComboBox cbx)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                cbx.Items.Clear();
                connection.Open();
                //Query de consulta para obtener equipos
                SqlCommand sql = new SqlCommand("SELECT * FROM USUARIO", connection);
                //Lectura de datos y agregar al combo box los datos
                SqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    //Agregar registros al combo box
                    cbx.Items.Add($"{dr[0]} {dr[2]} {dr[3]}");
                }
                connection.Close();
            }
        }

        public List<Bitacora> GetBitacorass(string FECHA, string FECHA2, int ID_USUARIO)
        {
            List<Bitacora> bitacoras = new List<Bitacora>();
            string query = " EXEC JCGO_REPORTE_BITACORA @FECHA , @FECHA2 , @ID_USUARIO ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                sql.Parameters.AddWithValue("@FECHA", FECHA);
                sql.Parameters.AddWithValue("@FECHA2", FECHA2);
                sql.Parameters.AddWithValue("@ID_USUARIO", ID_USUARIO);
                try
                {
                    connection.Open();
                    //Ejecuta el query
                    SqlDataReader reader = sql.ExecuteReader();
                    while (reader.Read())
                    {
                        Bitacora bitacora = new Bitacora();
                        //Obtiene los datos de la tabla y se guardan en un lista
                        bitacora.id_bitacora = reader.GetInt32(0);
                        bitacora.Id_Usuario = reader.GetInt32(1);
                        bitacora.Fecha = reader.GetDateTime(2);
                        bitacora.Hora_Entrada = reader.GetTimeSpan(3);
                        bitacora.TORNEO = reader.GetBoolean(4);
                        bitacora.EQUIPO = reader.GetBoolean(5);
                        bitacora.ENTRENADOR = reader.GetBoolean(6);
                        bitacora.USUARIOS = reader.GetBoolean(7);
                        bitacora.ARBITROS = reader.GetBoolean(8);
                        bitacora.AMONESTACIONES = reader.GetBoolean(9);
                        bitacora.PAGO_AMONESTACIONES = reader.GetBoolean(10);
                        bitacora.CLIENTES = reader.GetBoolean(11);
                        bitacora.JUGADORES = reader.GetBoolean(12);
                        bitacora.CANCHAS = reader.GetBoolean(13);
                        bitacora.REPORTES = reader.GetBoolean(14);
                        bitacora.ALQUILER_CANCHA = reader.GetBoolean(15);
                        bitacoras.Add(bitacora);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al obtener los datos" + error, "ERROR");
                }

            }
            return bitacoras;
        }

    }
}
