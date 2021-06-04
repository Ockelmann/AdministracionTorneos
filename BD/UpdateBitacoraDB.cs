using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administracion_Torneos.BD
{
    public class UpdateBitacoraDB
    {
        private string connectionstring = ("Server=DESKTOP-EJ193JG;Database=Proyecto_AdministracionTorneosFutbol;User Id=capacitacion;Password=12345;");

        public string GetRol(int id_user)
        {
            string rol = "";
            string query = $"EXEC JCGO_USER {id_user}";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    //Ejecuta el query
                    SqlDataReader reader = sql.ExecuteReader();
                    while (reader.Read())
                    {
                        rol = reader.GetString(0);

                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Usuario incorrecto o no existente");
                }
            }
            return rol;
        }

        public void UpdateTorneo(int ID_BITACORA)
        {
            string query = $"UPDATE BITACORA SET TORNEO = 1 WHERE ID = '{ID_BITACORA}'";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    //Ejecuta el Query
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error" + error.Message, "ERROR");
                }
            }
        }

        public void UpdateEquipo(int ID_BITACORA)
        {
            string query = $"UPDATE BITACORA SET EQUIPO = 1 WHERE ID = '{ID_BITACORA}'";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    //Ejecuta el Query
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error" + error.Message, "ERROR");
                }
            }
        }

        public void UpdateEntrenador(int ID_BITACORA)
        {
            string query = $"UPDATE BITACORA SET ENTRENADOR = 1 WHERE ID = '{ID_BITACORA}'";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    //Ejecuta el Query
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error" + error.Message, "ERROR");
                }
            }
        }

        public void UpdateUsuarios(int ID_BITACORA)
        {
            string query = $"UPDATE BITACORA SET USUARIOS = 1 WHERE ID = '{ID_BITACORA}'";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    //Ejecuta el Query
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error" + error.Message, "ERROR");
                }
            }
        }


        public void UpdateArbitros(int ID_BITACORA)
        {
            string query = $"UPDATE BITACORA SET ARBITROS = 1 WHERE ID = '{ID_BITACORA}'";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    //Ejecuta el Query
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error" + error.Message, "ERROR");
                }
            }
        }

        public void UpdateAmonestaciones(int ID_BITACORA)
        {
            string query = $"UPDATE BITACORA SET AMONESTACIONES = 1 WHERE ID = '{ID_BITACORA}'";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    //Ejecuta el Query
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error" + error.Message, "ERROR");
                }
            }
        }

        public void UpdatePagoAmonestacion(int ID_BITACORA)
        {
            string query = $"UPDATE BITACORA SET PAGO_AMONESTACIONES = 1 WHERE ID = '{ID_BITACORA}'";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    //Ejecuta el Query
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error" + error.Message, "ERROR");
                }
            }
        }

        public void UpdateClientes(int ID_BITACORA)
        {
            string query = $"UPDATE BITACORA SET CLIENTES = 1 WHERE ID = '{ID_BITACORA}'";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    //Ejecuta el Query
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error" + error.Message, "ERROR");
                }
            }
        }

        public void UpdateJugadores(int ID_BITACORA)
        {
            string query = $"UPDATE BITACORA SET JUGADORES = 1 WHERE ID = '{ID_BITACORA}'";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    //Ejecuta el Query
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error" + error.Message, "ERROR");
                }
            }
        }

        public void UpdateCanchas(int ID_BITACORA)
        {
            string query = $"UPDATE BITACORA SET CANCHAS = 1 WHERE ID = '{ID_BITACORA}'";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    //Ejecuta el Query
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error" + error.Message, "ERROR");
                }
            }
        }

        public void UpdateReportes(int ID_BITACORA)
        {
            string query = $"UPDATE BITACORA SET REPORTES = 1 WHERE ID = '{ID_BITACORA}'";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    //Ejecuta el Query
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error" + error.Message, "ERROR");
                }
            }
        }

        public void UpdateAlquiler(int ID_BITACORA)
        {
            string query = $"UPDATE BITACORA SET ALQUILER_CANCHA = 1 WHERE ID = '{ID_BITACORA}'";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    //Ejecuta el Query
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error" + error.Message, "ERROR");
                }
            }
        }


    }
}
