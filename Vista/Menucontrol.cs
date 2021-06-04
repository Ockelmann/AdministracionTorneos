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

namespace Administracion_Torneos.Vista
{
    public partial class Menucontrol : Form
    {
        int id;
        int bitacora;
        string rol_user;
        UpdateBitacoraDB updateBitacora = new UpdateBitacoraDB();
        public Menucontrol(int id_bitacora, int id_user)
        {
            InitializeComponent();
            bitacora = id_bitacora;
            id = id_user;
           
            rol_user = updateBitacora.GetRol(id);
            if (rol_user == "Administrador")
            {
                button4.Enabled = true;
                btnTorneo.Enabled = true;
                btnEquipo.Enabled = true;
                btnEntrenador.Enabled = true;
                button1.Enabled = true;
                btnArbitros.Enabled = true;
                btnAmonestaciones.Enabled = true;
                button2.Enabled = true;
                btnJugadores.Enabled = true;
                btnCanchas.Enabled = true;
                btnReportes.Enabled = true;
                button3.Enabled = true;
            }
            else if (rol_user == "Operador")
            {
                button4.Enabled = false;
                btnTorneo.Enabled = false;
                btnEquipo.Enabled = true;
                btnEntrenador.Enabled = true;
                button1.Enabled = false;
                btnArbitros.Enabled = true;
                btnAmonestaciones.Enabled = true;
                button2.Enabled = true;
                btnJugadores.Enabled = true;
                btnCanchas.Enabled = false;
                btnReportes.Enabled = false;
                button3.Enabled = true;

            }
            else if (rol_user == "Reportes")
            {
                button4.Enabled = false;
                btnTorneo.Enabled = false;
                btnEquipo.Enabled = false;
                btnEntrenador.Enabled = false;
                button1.Enabled = false;
                btnArbitros.Enabled = false;
                btnAmonestaciones.Enabled = false;
                btnPagoAmonestaciones.Enabled = false;
                button2.Enabled = false;
                btnJugadores.Enabled = false;
                btnCanchas.Enabled = false;
                btnReportes.Enabled = true;
                button3.Enabled = false;
            }


        }
        

        private void btnTorneo_Click(object sender, EventArgs e)
        {
            updateBitacora.UpdateTorneo(bitacora);
            this.Hide();
            TorneoCRUD t = new TorneoCRUD(bitacora,id);
            t.Show();
        }

        private void btnEquipo_Click(object sender, EventArgs e)
        {
            updateBitacora.UpdateEquipo(bitacora);
            this.Hide();
            ViewEquipo vq = new ViewEquipo(bitacora,id);
            vq.Show();
        }

        private void btnEntrenador_Click(object sender, EventArgs e)
        {
            updateBitacora.UpdateEntrenador(bitacora);
            this.Hide();
            ViewEntrenador ve = new ViewEntrenador(bitacora,id);
            ve.Show();
        }

        private void btnArbitros_Click(object sender, EventArgs e)
        {
            updateBitacora.UpdateArbitros(bitacora);
            this.Hide();
            VistaArbitro vA = new VistaArbitro(bitacora,id);
            vA.Show();
        }

        private void btnAmonestaciones_Click(object sender, EventArgs e)
        {
            updateBitacora.UpdateAmonestaciones(bitacora);
            this.Hide();
            Amonestacion ar = new Amonestacion(bitacora,id);
            ar.Show();
        }

        private void btnPagoAmonestaciones_Click(object sender, EventArgs e)
        {
            updateBitacora.UpdatePagoAmonestacion(bitacora);
            this.Hide();
            ViewPagoAmonestacion viewPagoAmonestacion = new ViewPagoAmonestacion(bitacora,id);
            viewPagoAmonestacion.Show();
        }

        private void btnJugadores_Click(object sender, EventArgs e)
        {
            updateBitacora.UpdateJugadores(id);
            this.Hide();
            jugadorescrud jrs = new jugadorescrud(bitacora,id);
            jrs.Show();
        }

        private void btnCanchas_Click(object sender, EventArgs e)
        {
            updateBitacora.UpdateCanchas(bitacora);
            this.Hide();
            Canchas c = new Canchas(bitacora,id);
            c.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            updateBitacora.UpdateReportes(bitacora);
            this.Hide();
            Reportes reportes = new Reportes(bitacora,id);
            reportes.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            updateBitacora.UpdateUsuarios(bitacora);
            this.Hide();
            Usuario usuario = new Usuario(bitacora,id);
            usuario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateBitacora.UpdateClientes(bitacora);
            this.Hide();
            View_Cliente cliente = new View_Cliente(bitacora,id);
            cliente.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateBitacora.UpdateAlquiler(bitacora);
            this.Hide();
            View_AlquilerCancha alquilerCancha = new View_AlquilerCancha(bitacora,id);
            alquilerCancha.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Horario horario = new View_Horario(bitacora,id);
            horario.Show();
        }

        private void Menucontrol_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            View_Login login = new View_Login();
            login.Show();
        }
    }
}
