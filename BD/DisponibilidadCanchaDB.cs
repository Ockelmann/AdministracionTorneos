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
    public class DisponibilidadCanchaDB
    {
        private string connectionString = "Server=DESKTOP-EJ193JG;Database=Proyecto_AdministracionTorneosFutbol;User Id=capacitacion;Password=12345;";


        public void GetCanchas(ComboBox cbx)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                cbx.Items.Clear();
                connection.Open();
                //Query de consulta para obtener equipos
                SqlCommand sql = new SqlCommand("SELECT * FROM CANCHA", connection);
                //Lectura de datos y agregar al combo box los datos
                SqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    //Agregar registros al combo box
                    cbx.Items.Add($"{dr[0]}- {dr[1]}");
                }
                connection.Close();
            }
        }

        public List<Horario> GetHorario()
        {
            List<Horario> horarios = new List<Horario>();
            string query = "SELECT * FROM HORARIO";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    //Ejecuta el query
                    SqlDataReader reader = sql.ExecuteReader();
                    while (reader.Read())
                    {
                        Horario horario = new Horario();
                        //Obtiene los datos de la tabla y se guardan en un lista
                        horario.dia = reader.GetString(0);
                        horario.Hora_Apertura = reader.GetTimeSpan(1);
                        horario.Hora_Cierre = reader.GetTimeSpan(2);
                        horarios.Add(horario);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al obtener los datos" + error, "ERROR");
                }
            }
            return horarios;
        }


    }
}
