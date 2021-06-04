using Administracion_Torneos.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administracion_Torneos.BD
{
    public class LoginDB
    {
        private string connectionstring = ("Server=DESKTOP-EJ193JG;Database=Proyecto_AdministracionTorneosFutbol;User Id=capacitacion;Password=12345;");


        

        public Boolean GetEstado(string user, string contraseña)
        {
            Boolean estado = false;
            string query = $"EXEC JCGO_estadouser '{user}', '{contraseña}'";
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
                        estado = reader.GetBoolean(0);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Usuario incorrecto o no existente");
                }
            }
            return estado;
        }

        public int GetId(string user, string contraseña)
        {
            int id = 1;
            string query = $"EXEC JCGO_estadoid '{user}', '{contraseña}'";
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
                        id = reader.GetInt32(0);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception)
                {
                    //MessageBox.Show("Usuario incorrecto o no existente");
                }
            }
            return id;
        }

        public void AddBitacora(int ID_USUARIO, string FECHA, string HORA_ENTRADA)
        {
            string query = "EXEC JCGO_INSERTBITACORA  @ID_USUARIO, @FECHA,@HORA_ENTRADA";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(query, connection);
                //Envia parametros al Proceso Almacenado
                command.Parameters.AddWithValue("@ID_USUARIO", ID_USUARIO);
                command.Parameters.AddWithValue("@FECHA", FECHA);
                command.Parameters.AddWithValue("@HORA_ENTRADA", HORA_ENTRADA);
                try
                {
                    connection.Open();
                        //Ejecuta el Query
                        command.ExecuteNonQuery();
                        MessageBox.Show("Bienvenido");
 
                    connection.Close();                   
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error" + error.Message, "ERROR");
                }
            }
        }

        public int GetIdBitacora(int ID_USUARIO, string FECHA, string HORA_ENTRADA)
        {
            int idBitacora = 1;
            string query = $"SELECT B.ID FROM BITACORA B WHERE B.ID_USUARIO = '{ID_USUARIO}' AND B.FECHA = '{FECHA}' AND B.HORA_ENTRADA = '{HORA_ENTRADA}' ";
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
                        idBitacora = reader.GetInt32(0);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Usuario incorrecto o no existente");
                }
            }
            return idBitacora;
        }

    }
}
