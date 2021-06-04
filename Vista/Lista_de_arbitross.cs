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
using Administracion_Torneos.BD;
namespace Administracion_Torneos.Vista
{
    public partial class Lista_de_arbitross : Form
    {
        public arbitroDB arbitrosContext = new arbitroDB();
        public Lista_de_arbitross()
        {
            InitializeComponent();
            mostrar();
        }
        public void mostrar()
        {
            listArbitros.DataSource = arbitrosContext.manejoArbitros();
        }

        private void Lista_de_arbitross_Load(object sender, EventArgs e)
        {

        }
    }
}
