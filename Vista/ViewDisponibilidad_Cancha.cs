using Administracion_Torneos.BD;
using Administracion_Torneos.Modelo;
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
    public partial class ViewDisponibilidad_Cancha : Form
    {
        DisponibilidadCanchaDB disponibilidadCanchaDB = new DisponibilidadCanchaDB();
        string[,] disponibilidad;
        DateTime[] fechas;
        int usuario;
        int bitacora;
        public ViewDisponibilidad_Cancha(int id_bitacora, int id_user)
        {
            InitializeComponent();
            disponibilidadCanchaDB.GetCanchas(cbxCancha);
            usuario = id_user;
            bitacora = id_bitacora;
        }

        private string connectionString = "Server=DESKTOP-EJ193JG;Database=Proyecto_AdministracionTorneosFutbol;User Id=capacitacion;Password=12345;";

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listBitacora.Rows.Clear();
            listBitacora.Refresh();
            Llenar_Matiz();    
        }


        private void Llenar_Matiz()
        {

            string stringCancha = Convert.ToString(cbxCancha.SelectedItem);
            string[] ArrelgoCancha = stringCancha.Split('-');

            int NoCancha = Convert.ToInt32( ArrelgoCancha[0]);


            List<Horario> horario = disponibilidadCanchaDB.GetHorario();

            TimeSpan diferencia = fecha2.Value.Date - fecha.Value.Date;
            int dias = diferencia.Days;

            TimeSpan hora_mayor = horario[0].Hora_Cierre - horario[0].Hora_Apertura;
            int horas_mayor = hora_mayor.Hours;

            DateTime inicio = fecha.Value.Date;
            DateTime fin = fecha2.Value.Date;

            TimeSpan Apertura = horario[0].Hora_Apertura;
            TimeSpan Cierre = horario[0].Hora_Cierre;
            int contador = 0;
            fechas = new DateTime[dias + 1];
            while (inicio <= fin) //Asumiendo un ámbito inclusivo de ambos valores.
            {
                fechas[contador] = inicio;
                inicio += new TimeSpan(1, 0, 0, 0);
                Console.WriteLine(fechas[contador]);
                contador++;

            }


            for (int i = 1; i < horario.Count; i++)
            {
                TimeSpan diferencia2 = horario[i].Hora_Cierre - horario[i].Hora_Apertura;
                int horas = diferencia2.Hours;

                if (horas > horas_mayor)
                {
                    horas_mayor = horas;
                    Apertura = horario[i].Hora_Apertura;
                    Cierre = horario[i].Hora_Cierre;
                }

            }

            TimeSpan Inicial = Apertura;
            disponibilidad = new string[horas_mayor + 1, dias + 2];

            disponibilidad[0, 0] = "|";

            for (int f = 1; f <= horas_mayor; f++)
            {
                disponibilidad[f, 0] = $"{Apertura}-{Apertura + new TimeSpan(1, 0, 0)}";

                Apertura += new TimeSpan(1, 0, 0);

                Console.WriteLine(disponibilidad[f, 0]);
            }

            int contador2 = 0;
            for (int j = 1; j <= dias + 1; j++)
            {
                disponibilidad[0, j] = $"{fechas[contador2]}";

                Console.WriteLine(disponibilidad[0, j]);
                contador2++;
            }

            
            for (int j = 1 ; j <= horas_mayor ; j++)
            {
                string stringhorario = Convert.ToString(disponibilidad[j, 0]);
                string[] Arrelgohorario = stringhorario.Split('-');
                
                for (int f = 1; f <= dias + 1; f++)
                {
                    DateTime Horauno = new DateTime(Convert.ToDateTime(disponibilidad[0, f]).Year, Convert.ToDateTime(disponibilidad[0, f]).Month, Convert.ToDateTime(disponibilidad[0, f]).Day, Convert.ToDateTime(Arrelgohorario[0]).Hour, Convert.ToDateTime(Arrelgohorario[0]).Minute,0,0);
                    DateTime Horados = new DateTime(Convert.ToDateTime(disponibilidad[0, f]).Year, Convert.ToDateTime(disponibilidad[0, f]).Month, Convert.ToDateTime(disponibilidad[0, f]).Day, Convert.ToDateTime(Arrelgohorario[1]).Hour, Convert.ToDateTime(Arrelgohorario[1]).Minute, 0, 0);

                    disponibilidad[j, f] = GetDisponibilidad(disponibilidad[0,f],Horauno ,Horados, NoCancha);
                }
            }

            int heigth =  horas_mayor;
            int width = dias + 2;

            this.listBitacora.ColumnCount = width;

                for (int f = 0; f <= heigth; f++)
                {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.listBitacora);
                    for (int c = 0; c < width; c++)
                    {
                    row.Cells[c].Value = disponibilidad[f, c];
                    }
                this.listBitacora.Rows.Add(row);
                }


            for (int f = 0; f <= horas_mayor ; f++)
            {
                for (int c = 0; c <= dias + 1; c++)
                {
                    Console.Write(disponibilidad[f, c] + " ");
                }
                Console.WriteLine();
            }



        }

        public string GetDisponibilidad(string Fecha,  DateTime Hora_Inicio, DateTime Hora_Fin,int NoCancha)
        {
            string query = "EXEC DISPONIBILIDAD_CANCHA @Fecha, @Hora_Inicio,@Hora_Fin,@NoCancha";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                sql.Parameters.AddWithValue("@Fecha",Convert.ToDateTime( Fecha));
                sql.Parameters.AddWithValue("@Hora_Inicio", Hora_Inicio);
                sql.Parameters.AddWithValue("@Hora_Fin", Hora_Fin);
                sql.Parameters.AddWithValue("@NoCancha", NoCancha);

                    connection.Open();
                    //Ejecuta el query
                    SqlDataReader reader = sql.ExecuteReader();
                    if (!reader.HasRows) 
                    {
                        reader.Close();
                        connection.Close();
                        return "Diponible";
                    }
                    else
                    {
                        reader.Close();
                        connection.Close();
                        return "No Diponible";
                    }
                   
            }



        }

        private void ViewDisponibilidad_Cancha_FormClosing(object sender, FormClosingEventArgs e)
        {
            Reportes reportes = new Reportes(bitacora, usuario);
            reportes.Show();
        }

    }
}
