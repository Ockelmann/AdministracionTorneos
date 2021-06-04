using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administracion_Torneos.Vista
{
    public partial class View_IngresoCancha : Form
    {
        private string connectionstring = ("Server=DESKTOP-EJ193JG;Database=Proyecto_AdministracionTorneosFutbol;User Id=capacitacion;Password=12345;");
        public int usuario;
        public int bitacora;
        public View_IngresoCancha(int id_bitacora, int id_user)
        {
            InitializeComponent();
            usuario = id_user;
            bitacora = id_bitacora;
        }

        private void GetIngresos(string query)
        {

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
                    listIngresos.DataSource = data;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No se pudo realizar la consulta");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string inicio = fecha.Value.Year + "-" + fecha.Value.Month + "-" + fecha.Value.Day;
            string fin = fecha2.Value.Year + "-" + fecha2.Value.Month + "-" + fecha2.Value.Day;
            string query = "EXEC REPORTE_INGRESO_CANCHA '" + inicio + "','" + fin + "'";
            GetIngresos(query);
        }

        private void View_IngresoCancha_FormClosing(object sender, FormClosingEventArgs e)
        {
            Reportes reportes = new Reportes(bitacora, usuario);
            reportes.Show();
        }
    }
}
