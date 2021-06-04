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
    public class ClienteDB
    {
        private string connectionstring = ("Server=DESKTOP-EJ193JG;Database=Proyecto_AdministracionTorneosFutbol;User Id=capacitacion;Password=12345;");

        public List<Cliente> GetClientes()
        {
            List<Cliente> CLIENTES = new List<Cliente>();
            string query = "SELECT * FROM CLIENTE";
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
                        Cliente Cliente = new Cliente();
                        //Obtiene los datos de la tabla y se guardan en un lista
                        Cliente.id_cliente = reader.GetInt32(0);
                        Cliente.dpi = reader.GetString(1);
                        Cliente.Nombres = reader.GetString(2);
                        Cliente.Apellidos = reader.GetString(3);
                        Cliente.Telefono = reader.GetString(4);
                        Cliente.Correo = reader.GetString(5);
                        CLIENTES.Add(Cliente);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al obtener los datos" + error, "ERROR");
                }
            }
            return CLIENTES;
        }

        public Cliente GetCliente(int ID_CLIENTE)
        {
            Cliente Cliente = new Cliente();
            string query = "SELECT * FROM CLIENTE WHERE ID_CLIENTE = @ID_CLIENTE";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                sql.Parameters.AddWithValue("@ID_CLIENTE", ID_CLIENTE);
                try
                {
                    connection.Open();
                    //Ejecuta el query y lee lo q esta en la tabla
                    SqlDataReader reader = sql.ExecuteReader();
                    reader.Read();

                    //Se guarda lo que esta en la tabla en el modelo
                    Cliente.dpi = reader.GetString(1);
                    Cliente.Nombres = reader.GetString(2);
                    Cliente.Apellidos = reader.GetString(3);
                    Cliente.Telefono = reader.GetString(4);
                    Cliente.Correo = reader.GetString(5);
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al obtener los datos" + error, "ERROR");
                }
                return Cliente;
            }
        }

        public void AddCliente(Cliente cliente)
        {
            string query = "EXEC JCGO_ADD_CLIENTE  @DPI, @Nombres, @Apellidos, @Telefono, @Correo";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(query, connection);
                //Envia parametros al Proceso Almacenado
                command.Parameters.AddWithValue("@DPI", cliente.dpi);
                command.Parameters.AddWithValue("@Nombres", cliente.Nombres);
                command.Parameters.AddWithValue("@Apellidos", cliente.Apellidos);
                command.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                command.Parameters.AddWithValue("@Correo", cliente.Correo);
                try
                {
                    connection.Open();
                    //Ejecuta el Query
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Cliente Agregado Correctamente");
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error ya esta agregado este Cliente" + error.Message, "ERROR");
                }
            }
        }

        public void UpdateCliente(Cliente Cliente)
        {
            string query = "EXEC JCGO_UPDATE_CLIENTE @ID_CLIENTE , @DPI  , @Nombres, @Apellidos,@Telefono  ,@Correo";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(query, connection);
                //Envia Parametros al Procedimiento
                command.Parameters.AddWithValue("@ID_CLIENTE", Cliente.id_cliente);
                command.Parameters.AddWithValue("@DPI", Cliente.dpi);
                command.Parameters.AddWithValue("@Nombres", Cliente.Nombres);
                command.Parameters.AddWithValue("@Apellidos", Cliente.Apellidos);
                command.Parameters.AddWithValue("@Telefono", Cliente.Telefono);
                command.Parameters.AddWithValue("@Correo", Cliente.Correo);
                try
                {
                    connection.Open();
                    //Ejecuta el query
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Cliente Actualizado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar Registro", ex.Message);
                }
            }
        }

        public void DeleteCliente(int ID_CLIENTE)
        {
            string query = "EXEC JCGO_DELETE_CLIENTE @ID_CLIENTE";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(query, connection);
                //Envia parametro al procedimiento
                command.Parameters.AddWithValue("@ID_CLIENTE", ID_CLIENTE);
                try
                {
                    connection.Open();
                    //Ejecuta el Query
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Eliminado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al Eliminar Cliente", ex.Message);
                }
            }
        }

    }
}
