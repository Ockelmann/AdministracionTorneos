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
    public class UsuariosDB
    {
        private string connectionstring = ("Server=DESKTOP-EJ193JG;Database=Proyecto_AdministracionTorneosFutbol;User Id=capacitacion;Password=12345;");

        public List<Usuarios> GetUsuarios()
        {
            List<Usuarios> usuarios = new List<Usuarios>();
            string query = "SELECT * FROM USUARIO";
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
                        Usuarios Usuario = new Usuarios();
                        //Obtiene los datos de la tabla y se guardan en un lista
                        Usuario.Id_usuarios = reader.GetInt32(0);
                        Usuario.dpi = reader.GetString(1);
                        Usuario.Nombres = reader.GetString(2);
                        Usuario.Apellidos = reader.GetString(3);
                        Usuario.user = reader.GetString(4);
                        Usuario.contraseña = reader.GetString(5);
                        Usuario.Telefono = reader.GetString(6);
                        Usuario.Direccion = reader.GetString(7);
                        Usuario.Correo = reader.GetString(8);
                        Usuario.Puesto = reader.GetString(9);
                        Usuario.Rol = reader.GetString(10);
                        Usuario.estado = reader.GetBoolean(11);
                        usuarios.Add(Usuario);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al obtener los datos" + error, "ERROR");
                }
            }
            return usuarios;
        }

        public Usuarios GetUsuario(int ID_USUARIO)
        {
            Usuarios usuarios = new Usuarios();
            string query = "SELECT * FROM USUARIO WHERE ID_USUARIO = @ID_USUARIO";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                sql.Parameters.AddWithValue("@ID_USUARIO", ID_USUARIO);
                try
                {
                    connection.Open();
                    //Ejecuta el query y lee lo q esta en la tabla
                    SqlDataReader reader = sql.ExecuteReader();
                    reader.Read();

                    //Se guarda lo que esta en la tabla en el modelo
                    usuarios.Id_usuarios = reader.GetInt32(0);
                    usuarios.dpi = reader.GetString(1);
                    usuarios.Nombres = reader.GetString(2);
                    usuarios.Apellidos = reader.GetString(3);
                    usuarios.user = reader.GetString(4);
                    usuarios.contraseña = reader.GetString(5);
                    usuarios.Telefono = reader.GetString(6);
                    usuarios.Direccion = reader.GetString(7);
                    usuarios.Correo = reader.GetString(8);
                    usuarios.Puesto = reader.GetString(9);
                    usuarios.Rol = reader.GetString(10);
                    usuarios.estado = reader.GetBoolean(11);
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al obtener los datos" + error, "ERROR");
                }
                return usuarios;
            }
        }

        public Boolean ValidarDPI(string dpi)
        {
            List<Usuarios> usuarios = new List<Usuarios>();
            string query = $"SELECT * FROM USUARIO U WHERE U.DPI = '{dpi}'";
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
                        Usuarios Usuario = new Usuarios();
                        //Obtiene los datos de la tabla y se guardan en un lista
                        Usuario.Id_usuarios = reader.GetInt32(0);
                        Usuario.dpi = reader.GetString(1);
                        usuarios.Add(Usuario);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception error)
                {
                   
                }
            }

            if (usuarios.Count == 1)
            {
                return false;
            }else
            {
                return true;
            }


        }

        public Boolean ValidarCorreo(string correo)
        {
            List<Usuarios> usuarios = new List<Usuarios>();
            string query = $"SELECT * FROM USUARIO U WHERE U.Correo = '{correo}'";
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
                        Usuarios Usuario = new Usuarios();
                        //Obtiene los datos de la tabla y se guardan en un lista
                        Usuario.Id_usuarios = reader.GetInt32(0);
                        Usuario.Correo = reader.GetString(8);
                        usuarios.Add(Usuario);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception error)
                {
                    
                }
            }
            if (usuarios.Count >= 1)
            {
                return false;
            }
            else 
            {
                return true;
            }
        }

        public Boolean ValidarUser(string usario)
        {
            List<Usuarios> usuarios = new List<Usuarios>();
            string query = $"SELECT * FROM USUARIO U WHERE U.UsrName = '{usario}'";
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
                        Usuarios Usuario = new Usuarios();
                        //Obtiene los datos de la tabla y se guardan en un lista
                        Usuario.Id_usuarios = reader.GetInt32(0);
                        Usuario.user = reader.GetString(4);
                        usuarios.Add(Usuario);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception error)
                {

                }
            }
            if (usuarios.Count >= 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public void AddUsuarios(Usuarios usuarios)
        {
            Boolean validar_dpi = ValidarDPI(usuarios.dpi);
            Boolean validar_correo = ValidarCorreo(usuarios.Correo);
            Boolean validar_usario = ValidarUser(usuarios.user);
            string query = "EXEC JCGO_ADD_USUARIO  @DPI, @Nombres,@Apellidos,@UsrName,@Contraseña,@Telefono,@Direccion ,@Correo ,@Puesto ,@Rol ";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(query, connection);
                //Envia parametros al Proceso Almacenado
                command.Parameters.AddWithValue("@DPI", usuarios.dpi);
                command.Parameters.AddWithValue("@Nombres", usuarios.Nombres);
                command.Parameters.AddWithValue("@Apellidos", usuarios.Apellidos);
                command.Parameters.AddWithValue("@UsrName", usuarios.user);
                command.Parameters.AddWithValue("@Contraseña", usuarios.contraseña);
                command.Parameters.AddWithValue("@Telefono", usuarios.Telefono);
                command.Parameters.AddWithValue("@Direccion", usuarios.Direccion);
                command.Parameters.AddWithValue("@Correo", usuarios.Correo);
                command.Parameters.AddWithValue("@Puesto", usuarios.Puesto);
                command.Parameters.AddWithValue("@Rol", usuarios.Rol);
                try
                {
                    connection.Open();

                    if (validar_dpi == true && validar_correo == true && validar_usario == true)
                    {
                        //Ejecuta el Query
                        command.ExecuteNonQuery();
                        MessageBox.Show("Usuario Agregado Correctamente");
                    }
                    else
                    {
                        if(validar_dpi == false && validar_correo == true && validar_usario == true)
                        {
                            MessageBox.Show("DPI EXISTENTE");
                        }else if (validar_correo == false && validar_dpi == true && validar_usario == true)
                        {
                            MessageBox.Show("CORREO EXISTENTE");
                        }else if (validar_usario == false && validar_dpi == true && validar_correo == true)
                        {
                            MessageBox.Show("USUARIO EXISTENTE");
                        }
                        else if (validar_correo == false && validar_dpi == false && validar_usario == false)
                        {
                            MessageBox.Show("CORREO, DPI, USUARIO EXISTENTE");
                        }
                    }
                    connection.Close();                   
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error ya esta agregado este Usuario" + error.Message, "ERROR");
                }
            }
        }


        public void UpdateUsuario(Usuarios usuarios)
        {
            string query = "EXEC JCGO_UPDATE_User @ID_USUARIO,@DPI, @Nombres,@Apellidos,@UsrName,@Contraseña,@Telefono,@Direccion ,@Correo ,@Puesto ,@Rol";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(query, connection);
                //Envia Parametros al Procedimiento
                command.Parameters.AddWithValue("@ID_USUARIO", usuarios.Id_usuarios);
                command.Parameters.AddWithValue("@DPI", usuarios.dpi);
                command.Parameters.AddWithValue("@Nombres", usuarios.Nombres);
                command.Parameters.AddWithValue("@Apellidos", usuarios.Apellidos);
                command.Parameters.AddWithValue("@UsrName", usuarios.user);
                command.Parameters.AddWithValue("@Contraseña", usuarios.contraseña);
                command.Parameters.AddWithValue("@Telefono", usuarios.Telefono);
                command.Parameters.AddWithValue("@Direccion", usuarios.Direccion);
                command.Parameters.AddWithValue("@Correo", usuarios.Correo);
                command.Parameters.AddWithValue("@Puesto", usuarios.Puesto);
                command.Parameters.AddWithValue("@Rol", usuarios.Rol);
                try
                {
                    connection.Open();
                    //Ejecuta el query
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Usuario Actualizado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar Registro", ex.Message);
                }
            }
        }

        public void DesactivarUser(int ID_USUARIO)
        {
            string query = "EXEC Actualizar_User @ID_USUARIO";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(query, connection);
                //Envia parametro al procedimiento
                command.Parameters.AddWithValue("@ID_USUARIO", ID_USUARIO);
                try
                {
                    connection.Open();
                    //Ejecuta el Query
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Deshabilitado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al Deshabilitar Usuario", ex.Message);
                }
            }
        } 


    }
}
