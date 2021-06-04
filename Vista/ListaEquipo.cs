using Administracion_Torneos.BD;
using Administracion_Torneos.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administracion_Torneos.Vista
{
    public partial class ListaEquipo : Form
    {
        int id, edadMin, edadMax;
        int opcion = 0;
        Equipo_TorneoDB equipo_TorneoDB = new Equipo_TorneoDB();
        public TorneoDB trcontext = new TorneoDB();
        int bitacora, usuario;
        public ListaEquipo(int idtorneo, int edadMinima, int edadMaxima, int id_bitacora, int id_usuario)
        {
            id = idtorneo;
            edadMin = edadMinima;
            edadMax = edadMaxima;
            bitacora = id_bitacora;
            usuario = id_usuario;
            InitializeComponent();
            equipo_TorneoDB.getequipo(comboBox1);
            cargar_lista();
            textBox1.Text = trcontext.Gettorneo(idtorneo).precio.ToString();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int? Id_Equipo = GetId_equipo();
            equipo_TorneoDB.Deleteequipo(Convert.ToInt32(Id_Equipo),id);
            cargar_lista();

        }

        private void btnasignar_Click(object sender, EventArgs e)
        {
            if (opcion == 0)
            {
                string[] equipo = comboBox1.SelectedItem.ToString().Split('|');

                Equipo_Torneo equipo_torneo = new Equipo_Torneo();
                equipo_torneo.id_equipo = Convert.ToInt32(equipo.ElementAt(0));
                equipo_torneo.costoinscripcion = textBox1.Text;
                equipo_TorneoDB.addTorneo_Equipo(equipo_torneo, id);
                cargar_lista();
            }

            else if (opcion == 1) 
            {
                int? Id_Equipo = GetId_equipo();
                Equipo_Torneo equipo_torneo = new Equipo_Torneo();
                equipo_torneo.id_equipo = Convert.ToInt32(Id_Equipo);
                equipo_torneo.id_torneo = id;
                equipo_torneo.costoinscripcion = textBox1.Text;
                equipo_TorneoDB.UpdateTorneo(equipo_torneo);
                opcion = 0;
                comboBox1.Enabled = true;
                cargar_lista();
            }
            comboBox1.SelectedIndex = -1;
        }

        public void cargar_lista() 
        {
            dataGridView1.DataSource = equipo_TorneoDB.Gettorneoequipo(id);
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[0].Visible = false;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            opcion = 1;
            int? Id_Equipo = GetId_equipo();

            Equipo_Torneo  equipo_editado = equipo_TorneoDB.Get_equipo_torneo(Convert.ToInt32(Id_Equipo), id);
            comboBox1.Text = Convert.ToString(Id_Equipo);
            comboBox1.Enabled = false;

        }
        private int? GetId_equipo()
        {
            try
            {
                return int.Parse(
                    dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString()
                    );
            }
            catch
            {
                return null;
            }
        }

        private void ListaEquipo_FormClosing(object sender, FormClosingEventArgs e)
        {
            TorneoCRUD torneoCRUD = new TorneoCRUD(bitacora,usuario);
            torneoCRUD.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ListaEquipo_Load(object sender, EventArgs e)
        {

        }

        private void btnJugadores_Click(object sender, EventArgs e)
        {
            this.Hide();
            int idEquipo = Convert.ToInt32(GetId_equipo());
            int idTorneo = id;
            ViewPosicionJugador viewPosicionJugador = new ViewPosicionJugador(idTorneo, idEquipo, edadMin, edadMax, bitacora,usuario);
            viewPosicionJugador.Show();
        }
    }
}
