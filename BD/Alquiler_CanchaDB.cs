using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Administracion_Torneos.Modelo;

namespace Administracion_Torneos.BD
{
    public class Alquiler_CanchaDB
    {
        private string connectionString = "Server=DESKTOP-EJ193JG;Database=Proyecto_AdministracionTorneosFutbol;User Id=capacitacion;Password=12345;";

        public void GetAlquiler(DataGridView list)
        {
            string query = "EXEC VIEW_ALQUILER";
            using (SqlConnection connection = new SqlConnection(connectionString))
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



        public void GetClientes(ComboBox cbx)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                cbx.Items.Clear();
                connection.Open();
                //Query de consulta para obtener equipos
                SqlCommand sql = new SqlCommand("SELECT * FROM CLIENTE", connection);
                //Lectura de datos y agregar al combo box los datos
                SqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    //Agregar registros al combo box
                    cbx.Items.Add($"{dr[2]} {dr[3]}");
                }
                connection.Close();
            }
        }

        public void GetCanchas(ComboBox cbx, DateTime Fecha_Apartada, DateTime Hora_Inicio, DateTime Hora_Final)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                cbx.Items.Clear();
                connection.Open();
                //Query de consulta para obtener equipos
                SqlCommand sql = new SqlCommand("EXEC JCGO_CANCHA_DISPONIBLE @Fecha_Apartada, @Hora_Inicio,@Hora_Final", connection);
                sql.Parameters.AddWithValue("@Fecha_Apartada", Fecha_Apartada);
                sql.Parameters.AddWithValue("@Hora_Inicio", Hora_Inicio);
                sql.Parameters.AddWithValue("@Hora_Final", Hora_Final);
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


        public void AddAlquiler(Alquilar_Cancha alquiler_Cancha)
        {
            string query = "EXEC JCGO_ADD_AlQUILER @NoCancha  ,@ID_CLIENTE , @Fecha_Apartada ,@Hora_Inicio ,@Hora_Final ,@Total_Precio";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                //Envia parametros al Proceso Almacenado
                command.Parameters.AddWithValue("@NoCancha", alquiler_Cancha.NoCancha);
                command.Parameters.AddWithValue("@ID_CLIENTE", alquiler_Cancha.Id_Cliente);
                command.Parameters.AddWithValue("@Fecha_Apartada", alquiler_Cancha.Fecha_Apartada);
                command.Parameters.AddWithValue("@Hora_Inicio", alquiler_Cancha.Hora_Inicio);
                command.Parameters.AddWithValue("@Hora_Final", alquiler_Cancha.Hora_Final);
                command.Parameters.AddWithValue("@Total_Precio", alquiler_Cancha.Total);
                try
                {
                    connection.Open();
                    //Ejecuta el Query
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Alquiler Agregado Correctamente");
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al insertar Alquiler" + error.Message, "ERROR");
                }
            }
        }

        public void AddAlquile(Alquilar_Cancha alquiler_Cancha)
        {
            string query = "EXEC JCGO_ADD_AlQUILE @NoCancha  ,@ID_CLIENTE ,@Fecha_Apartada ,@Hora_Inicio ,@Hora_Final ,@Total_Precio";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                //Envia parametros al Proceso Almacenado
                command.Parameters.AddWithValue("@NoCancha", alquiler_Cancha.NoCancha);
                command.Parameters.AddWithValue("@ID_CLIENTE", alquiler_Cancha.Id_Cliente);
                command.Parameters.AddWithValue("@Fecha_Apartada", alquiler_Cancha.Fecha_Apartada);
                command.Parameters.AddWithValue("@Hora_Inicio", alquiler_Cancha.Hora_Inicio);
                command.Parameters.AddWithValue("@Hora_Final", alquiler_Cancha.Hora_Final);
                command.Parameters.AddWithValue("@Total_Precio", alquiler_Cancha.Total);
                try
                {
                    connection.Open();
                    //Ejecuta el Query
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Alquiler Agregado Correctamente");
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al insertar Alquiler" + error.Message, "ERROR");
                }
            }
        }

        public int ID_CLIENTE(string Nombres, string Apellidos)
        {
            int ID = 0;
            string query = "EXEC JCGO_IDCLIENTE @Nombres , @Apellidos";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                sql.Parameters.AddWithValue("@Nombres", Nombres);
                sql.Parameters.AddWithValue("@Apellidos", Apellidos);
                try
                {
                    connection.Open();
                    //Ejecuta el query y lee lo q esta en la tabla
                    SqlDataReader reader = sql.ExecuteReader();
                    reader.Read();

                    //Se guarda lo que esta en la tabla en el modelo
                    ID = reader.GetInt32(0);
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al obtener los datos" + error, "ERROR");
                }
                return ID;
            }

        }

        public decimal GetPrecioCancha(int NOCANCHA)
        {
            decimal precio = 0;
            string query = "EXEC PRECIO_CANCHA @NOCANCHA";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                sql.Parameters.AddWithValue("@NOCANCHA", NOCANCHA);
                try
                {
                    connection.Open();
                    //Ejecuta el query y lee lo q esta en la tabla
                    SqlDataReader reader = sql.ExecuteReader();
                    reader.Read();

                    //Se guarda lo que esta en la tabla en el modelo
                    precio = reader.GetDecimal(0);
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al obtener los datos" + error, "ERROR");
                }
                return precio;
            }

        }

        public decimal Total(DateTime Hora_Inicio, DateTime Hora_Final, int NOCANCHA)
        {
            decimal Total = 0;
            string query = "EXEC PRECIO_TOTAL @Hora_Inicio, @Hora_Final, @NOCANCHA";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                sql.Parameters.AddWithValue("@Hora_Inicio", Hora_Inicio);
                sql.Parameters.AddWithValue("@Hora_Final", Hora_Final);
                sql.Parameters.AddWithValue("@NOCANCHA", NOCANCHA);
                try
                {
                    connection.Open();
                    //Ejecuta el query y lee lo q esta en la tabla
                    SqlDataReader reader = sql.ExecuteReader();
                    reader.Read();

                    //Se guarda lo que esta en la tabla en el modelo
                    Total = reader.GetDecimal(0);
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al obtener los datos" + error, "ERROR");
                }
                return Total;
            }
        }

        public decimal TotalArbitraje(DateTime Hora_Inicio, DateTime Hora_Final, int DPI_ARBITRO)
        {
            decimal TotalAArbitraje = 0;
            string query = "EXEC PRECIO_TOTAL_ARBITRAJE @Hora_Inicio , @Hora_Final , @DPI_ARBITRO";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                sql.Parameters.AddWithValue("@Hora_Inicio", Hora_Inicio);
                sql.Parameters.AddWithValue("@Hora_Final", Hora_Final);
                sql.Parameters.AddWithValue("@DPI_ARBITRO", DPI_ARBITRO);
                try
                {
                    connection.Open();
                    //Ejecuta el query y lee lo q esta en la tabla
                    SqlDataReader reader = sql.ExecuteReader();
                    reader.Read();

                    //Se guarda lo que esta en la tabla en el modelo
                    TotalAArbitraje = reader.GetDecimal(0);
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al obtener los datos" + error, "ERROR");
                }
                return TotalAArbitraje;
            }
        }


        public List<Arbitro_Alquilado> GetArbitroDisponible(DateTime Fecha_Apartada, DateTime Hora_Inicio, DateTime Hora_Final)
        {
            List<Arbitro_Alquilado> Arbitro_alquilado = new List<Arbitro_Alquilado>();
            string query = "EXEC JCGO_ARBITRO_DISPONIBLE @Fecha_Apartada, @Hora_Inicio,@Hora_Final";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                sql.Parameters.AddWithValue("@Fecha_Apartada", Fecha_Apartada);
                sql.Parameters.AddWithValue("@Hora_Inicio", Hora_Inicio);
                sql.Parameters.AddWithValue("@Hora_Final", Hora_Final);
                try
                {
                    connection.Open();
                    //Ejecuta el query
                    SqlDataReader reader = sql.ExecuteReader();
                    while (reader.Read())
                    {
                        Arbitro_Alquilado arbitro_Alquilado = new Arbitro_Alquilado();
                        //Obtiene los datos de la tabla y se guardan en un lista
                        arbitro_Alquilado.dpi = reader.GetInt32(0);
                        arbitro_Alquilado.nombres = reader.GetString(1);
                        arbitro_Alquilado.apellidos = reader.GetString(2);

                        Arbitro_alquilado.Add(arbitro_Alquilado);


                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al obtener los datos" + error, "ERROR");
                }
            }

            return Arbitro_alquilado;

        }







        public void AddArbitroAlquilado(DateTime Fecha_Apartada, DateTime Hora_Inicio, DateTime Hora_Final, int DPI, int ID_Alquiler, Decimal Total_Precio)
        {
            string query = "EXEC INSERT_ARBITRAJE_ALQULADO @Fecha_Apartado , @Hora_Inicio , @Hora_Final , @DPI_Arbitro ,@ID_ALQUILER ,@Total_Precio_Arbitro ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                //Envia parametros al Proceso Almacenado
                command.Parameters.AddWithValue("@Fecha_Apartado", Fecha_Apartada);
                command.Parameters.AddWithValue("@Hora_Inicio", Hora_Inicio);
                command.Parameters.AddWithValue("@Hora_Final", Hora_Final);
                command.Parameters.AddWithValue("@DPI_Arbitro", DPI);
                command.Parameters.AddWithValue("@ID_ALQUILER", ID_Alquiler);
                command.Parameters.AddWithValue("@Total_Precio_Arbitro", Total_Precio);
                try
                {
                    connection.Open();
                    //Ejecuta el Query
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Alquiler Agregado Correctamente");
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al insertar Alquiler" + error.Message, "ERROR");
                }
            }
        }




        public int GETIDALQUILER()
        {
            int ID = 0;
            string query = "SELECT TOP 1 * FROM ALQUILER_CANCHA ORDER BY ID DESC";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    //Ejecuta el query y lee lo q esta en la tabla
                    SqlDataReader reader = sql.ExecuteReader();
                    reader.Read();

                    //Se guarda lo que esta en la tabla en el modelo
                    ID = reader.GetInt32(0);
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al obtener los datos" + error, "ERROR");
                }
                return ID;
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
    
