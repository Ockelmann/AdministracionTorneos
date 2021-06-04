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
    public partial class Reportes : Form
    {
        int id_usuario;
        int bitacora;
        public Reportes(int id_bitacora,int id_user)
        {
            InitializeComponent();
            id_usuario = id_user;
            bitacora = id_bitacora;
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            this.Hide();
            tablapos ts = new tablapos(bitacora,id_usuario);
            ts.Show();
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tarjetas tt = new Tarjetas(bitacora,id_usuario);
            tt.Show();
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReporteCanchas reporteCanchas = new ReporteCanchas(bitacora,id_usuario);
            reporteCanchas.Show();
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportePlanillaArbitro reportePlanillaArbitro = new ReportePlanillaArbitro(bitacora, id_usuario);
            reportePlanillaArbitro.Show();
        }

        private void Reportes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menucontrol menucontrol = new Menucontrol(bitacora,id_usuario);
            menucontrol.Show();
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReporteEstadisticasEquipo reporteEstadisticasEquipo = new ReporteEstadisticasEquipo(bitacora, id_usuario);
            reporteEstadisticasEquipo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Bitacora bitacoras = new View_Bitacora(bitacora,id_usuario);
            bitacoras.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_IngresoCancha ingresoCancha = new View_IngresoCancha(bitacora,id_usuario);
            ingresoCancha.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reporte_IngresoArbitros ingresoArbitros = new Reporte_IngresoArbitros(bitacora,id_usuario);
            ingresoArbitros.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewDisponibilidad_Cancha disponibilidad_Cancha = new ViewDisponibilidad_Cancha(bitacora,id_usuario);
            disponibilidad_Cancha.Show();
        }
    }
}
