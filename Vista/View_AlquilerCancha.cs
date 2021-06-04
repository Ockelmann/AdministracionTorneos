using Administracion_Torneos.BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Administracion_Torneos.Modelo;

namespace Administracion_Torneos.Vista
{
    public partial class View_AlquilerCancha : Form
    {
        Alquiler_CanchaDB alquiler_CanchaDB = new Alquiler_CanchaDB();
        public int accion = 1;
        public int idbitacora;
        public int usuario;
        public Boolean validacion = false;
        public View_AlquilerCancha(int id_bitacora, int id_user)
        {
            InitializeComponent();
            listAlquiler.AllowUserToAddRows = false;
            listAlquiler.AllowDrop = false;
            listAlquiler.AllowUserToDeleteRows = false;
            listAlquiler.MultiSelect = false;
            cbxCliente.Enabled = false;
            alquiler_CanchaDB.GetClientes(cbxCliente);
            txtTotal.Enabled = false;
            usuario = id_user;
            idbitacora = id_bitacora;
            Get_Alquiler();
        }

        private void Get_Alquiler()
        {
            alquiler_CanchaDB.GetAlquiler(listAlquiler);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime fecha = txtFecha_Apartada.Value.Date;
            DateTime inicio = new DateTime(fecha.Year, fecha.Month, fecha.Day, txtHora_Inicia.Value.Hour, txtHora_Inicia.Value.Minute, 0, 0);
            DateTime fin = new DateTime(fecha.Year, fecha.Month, fecha.Day, txtHora_Final.Value.Hour, txtHora_Final.Value.Minute, 0, 0);

            TimeSpan iniciohora = new TimeSpan(inicio.Hour, inicio.Minute, 0);
            TimeSpan finhora = new TimeSpan(fin.Hour, fin.Minute, 0);

            string dia_nombre = fecha.ToString("dddd");

            
           List<Horario> horario = alquiler_CanchaDB.GetHorario();

            for (int i = 0; i < horario.Count; i++)
            {
                if(horario[i].dia.ToLower() == dia_nombre)
                {
                    if (iniciohora >= horario[i].Hora_Apertura && finhora <=  horario[i].Hora_Cierre)
                    {

                        if (cbxCliente.Text == "" || cbxCanchas.Text == "" || txtFecha_Apartada.Text == "" || txtHora_Inicia.Text == "" || txtHora_Final.Text == "" || txtTotal.Text == "")
                        {
                            MessageBox.Show("Valores en blanco", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string cliente = Convert.ToString(cbxCliente.SelectedItem);
                            string[] clientearray = cliente.Split(' ');
                            //Nombre almacenado en la posicion 0
                            //Apellidos almacenado en la posicion 1
                            string Nombres = "";
                            string Apellidos = "";
                            int ID_CLIENTE = 0;
                            if (clientearray.Length == 2)
                            {
                                Nombres = clientearray[0];
                                Apellidos = clientearray[1];
                                ID_CLIENTE = alquiler_CanchaDB.ID_CLIENTE(Nombres, Apellidos);
                            }
                            else if (clientearray.Length == 4)
                            {
                                Nombres = $"{clientearray[0]} {clientearray[1]}";
                                Apellidos = $"{clientearray[2]} {clientearray[3]}";
                                ID_CLIENTE = alquiler_CanchaDB.ID_CLIENTE(Nombres, Apellidos);
                            }
                            if (cbArbitraje.Checked == true)
                            {

                                List<Arbitro_Alquilado> arbitro_Alquilado = alquiler_CanchaDB.GetArbitroDisponible(fecha, inicio, fin);

                                string cancha = Convert.ToString(cbxCanchas.Text);
                                string[] ArrelgoCancha = cancha.Split('-');

                                int NoCancha = Convert.ToInt32(ArrelgoCancha[0]);

                                decimal TOTALPAGO = alquiler_CanchaDB.Total(txtHora_Inicia.Value, txtHora_Final.Value, NoCancha);

                                Alquilar_Cancha alquilar_Canchas = new Alquilar_Cancha();

                                if (arbitro_Alquilado.Count == 0)
                                {
                                    MessageBox.Show("No hay Arbitros Disponibles");
                                }
                                else
                                {

                                    decimal TotalAArbitraje = alquiler_CanchaDB.TotalArbitraje(inicio, fin, arbitro_Alquilado[0].dpi);
                                    alquilar_Canchas.NoCancha = NoCancha;
                                    alquilar_Canchas.Id_Cliente = ID_CLIENTE;
                                    alquilar_Canchas.Fecha_Apartada = fecha;
                                    alquilar_Canchas.Hora_Inicio = inicio;
                                    alquilar_Canchas.Hora_Final = fin;
                                    alquilar_Canchas.Total = TOTALPAGO;

                                    alquiler_CanchaDB.AddAlquiler(alquilar_Canchas);
                                    alquiler_CanchaDB.AddArbitroAlquilado(fecha, inicio, fin, arbitro_Alquilado[0].dpi, alquiler_CanchaDB.GETIDALQUILER(), TotalAArbitraje);
                                    Get_Alquiler();
                                }

                                txtTotal.Clear();

                            }
                            else
                            {

                                string cancha = Convert.ToString(cbxCanchas.Text);
                                string[] ArrelgoCancha = cancha.Split('-');

                                int NoCancha = Convert.ToInt32(ArrelgoCancha[0]);

                                decimal TOTALPAGO = alquiler_CanchaDB.Total(inicio, fin, NoCancha);

                                Alquilar_Cancha alquilar_Canchas = new Alquilar_Cancha();
                                alquilar_Canchas.NoCancha = NoCancha;
                                alquilar_Canchas.Id_Cliente = ID_CLIENTE;
                                alquilar_Canchas.Fecha_Apartada = fecha;
                                alquilar_Canchas.Hora_Inicio = inicio;
                                alquilar_Canchas.Hora_Final = fin;
                                alquilar_Canchas.Total = TOTALPAGO;

                                alquiler_CanchaDB.AddAlquile(alquilar_Canchas);
                                Get_Alquiler();


                                txtTotal.Clear();
                            }
                        }
      
                    }
                    else
                    {
                        MessageBox.Show("La hora no esta dentro del horario");
                    }
                    break;
                }


            }
        }

        private void cbxCanchas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cancha = Convert.ToString(cbxCanchas.Text);
            string[] ArrelgoCancha = cancha.Split('-');

            int NoCancha = Convert.ToInt32(ArrelgoCancha[0]);

            txtTotal.Text = Convert.ToString(alquiler_CanchaDB.GetPrecioCancha(NoCancha));
        }


        private void View_AlquilerCancha_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menucontrol menucontrol = new Menucontrol(idbitacora,usuario);
            menucontrol.Show();
        }

        private void txtHora_Final_ValueChanged(object sender, EventArgs e)
        {      
            cbxCliente.Enabled = true;     
        }


        private void cbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxCanchas.Enabled = true;
            DateTime fecha = txtFecha_Apartada.Value.Date;
            DateTime inicio = new DateTime(fecha.Year, fecha.Month, fecha.Day, txtHora_Inicia.Value.Hour, txtHora_Inicia.Value.Minute, 0, 0);
            DateTime fin = new DateTime(fecha.Year, fecha.Month, fecha.Day, txtHora_Final.Value.Hour, txtHora_Final.Value.Minute, 0, 0);

            alquiler_CanchaDB.GetCanchas(cbxCanchas, fecha, inicio, fin);
        }
           
    
    }
}
