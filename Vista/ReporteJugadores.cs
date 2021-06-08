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
    public partial class ReporteJugadores : Form
    {
        jugadorBD j = new jugadorBD();
        public ReporteJugadores()
        {
            InitializeComponent();
            dataGridView1.DataSource = j.Getjugadores();
        }

        private void ReporteJugadores_Load(object sender, EventArgs e)
        {

        }
    }
}
