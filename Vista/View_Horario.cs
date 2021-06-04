using Administracion_Torneos.BD;
using Administracion_Torneos.Modelo;
using System;
using System.Windows.Forms;

namespace Administracion_Torneos.Vista
{
    public partial class View_Horario : Form
    {
        HorarioDB horarioDB = new HorarioDB();
        public int opciones = 1;
        public int usuario;
        public int bitacora;
        public View_Horario(int id_bitacora, int id_user)
        {
            InitializeComponent();
            cbxDias.Items.Add("Lunes");
            cbxDias.Items.Add("Martes");
            cbxDias.Items.Add("Miércoles");
            cbxDias.Items.Add("Jueves");
            cbxDias.Items.Add("Viernes");
            cbxDias.Items.Add("Sabado");
            cbxDias.Items.Add("Domingo");
            Get_horario();
            usuario = id_user;
            bitacora = id_bitacora;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TimeSpan Abierto = new TimeSpan(Hora_Inicia.Value.Hour, Hora_Inicia.Value.Minute, 0);
            TimeSpan Cerrado = new TimeSpan(Hora_Cierre.Value.Hour, Hora_Cierre.Value.Minute, 0);
            Horario horario = new Horario();


            switch (opciones)
            {
                case 1:
                    
                    horario.dia = Convert.ToString(cbxDias.SelectedItem);
                    horario.Hora_Apertura = Abierto;
                    horario.Hora_Cierre = Cerrado;

                    horarioDB.AddHorario(horario);
                    Get_horario();
                    break;
                case 2:

                    horario.dia = GetDia();
                    horario.Hora_Apertura = Abierto;
                    horario.Hora_Cierre = Cerrado;

                    horarioDB.UpdateHorario(horario);
                    Get_horario();

                    opciones = 1;
                    break;
            }
            
        }

        private void Get_horario()
        {
            horarioDB.GetHorario(dataGridView1);
        }

        private string GetDia()
        {
            try
            {
                return 
                    dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()
                    ;
            }
            catch
            {
                return "";
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons eliminar = MessageBoxButtons.YesNo;
            DialogResult dr2 = MessageBox.Show("¿SEGURO DE QUE DESEA Actualizar Usuario", "ALERTA", eliminar, MessageBoxIcon.Warning);
            if (dr2 == DialogResult.Yes)
            {
                opciones = 2;
                //Se muestra en el texbox los datos del Torneo Seleccionado

                string Dia = GetDia();

                Horario horario = horarioDB.Horaio(Dia);

            }
            else if (dr2 == DialogResult.No)
            {
                MessageBox.Show("Se cancelo correctamnete la actualizacion de datos");
            }
        }

        private void View_Horario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menucontrol menucontrol = new Menucontrol(bitacora, usuario);
            menucontrol.Show();
        }
    }
}
