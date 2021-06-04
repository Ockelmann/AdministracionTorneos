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
    public class HorarioDB
    {
        private string connectionstring = ("Server=DESKTOP-EJ193JG;Database=Proyecto_AdministracionTorneosFutbol;User Id=capacitacion;Password=12345;");

        public void AddHorario(Horario horario)
        {
            string query = "EXEC INSERT_HORA @DIA,@HORA_APERTURA, @HORA_CIERRE";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(query, connection);
                //Envia parametros al Proceso Almacenado
                command.Parameters.AddWithValue("@DIA", horario.dia);
                command.Parameters.AddWithValue("@HORA_APERTURA", horario.Hora_Apertura);
                command.Parameters.AddWithValue("@HORA_CIERRE", horario.Hora_Cierre);

                try
                {
                    connection.Open();
                    //Ejecuta el Query
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Horario Agregado Correctamente");
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al insertar Horario" + error.Message, "ERROR");
                }
            }
        }

        public void UpdateHorario(Horario horario)
        {
            string query = "EXEC UPDATE_HORA @DIA,@HORA_APERTURA, @HORA_CIERRE";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(query, connection);
                //Envia parametros al Proceso Almacenado
                command.Parameters.AddWithValue("@DIA", horario.dia);
                command.Parameters.AddWithValue("@HORA_APERTURA", horario.Hora_Apertura);
                command.Parameters.AddWithValue("@HORA_CIERRE", horario.Hora_Cierre);

                try
                {
                    connection.Open();
                    //Ejecuta el Query
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Horario Actualizado Correctamente");
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al insertar Horario" + error.Message, "ERROR");
                }
            }
        }

        public void GetHorario(DataGridView list)
        {
            string query = "SELECT * FROM HORARIO";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                try
                {
                    connection.Open();

                    //Adaptador para almacenar consulta

                    SqlDataAdapter sqll = new SqlDataAdapter(query, connection);
                    DataTable data = new DataTable();

                    //Cargar tabla con la informacion de la consulta
                    sqll.Fill(data);
                    //Cargar datos en lista
                    list.DataSource = data;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No se pudo realizar la consulta");
                }
            }
        }



        public Horario Horaio(string DIA)
        {
            Horario horario = new Horario();
            string query = "SELECT * FROM HORARIO WHERE DIA = @DIA";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                sql.Parameters.AddWithValue("@DIA", DIA);
                try
                {
                    connection.Open();
                    //Ejecuta el query y lee lo q esta en la tabla
                    SqlDataReader reader = sql.ExecuteReader();
                    reader.Read();

                    //Se guarda lo que esta en la tabla en el modelo

                    horario.Hora_Apertura = TimeSpan.FromHours(1);
                    horario.Hora_Cierre = TimeSpan.FromHours(2);

                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al obtener los datos" + error, "ERROR");
                }
                return horario;
            }
        }


    }
}
