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
    public partial class View_Bitacora : Form
    {
        BitacoraDB bitacoraDB = new BitacoraDB();
        public int usuario;
        public int bitacora;
        public View_Bitacora(int id_bitacora, int id_user)
        {
            InitializeComponent();
            bitacoraDB.GetUsuarios(cbxUser);
            usuario = id_user;
            bitacora = id_bitacora;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string Usuario = Convert.ToString(cbxUser.Text);
            string[] ArregloUsuario = Usuario.Split(' ');

            int Id_Usuario = Convert.ToInt32(ArregloUsuario[0]);

            string Date = fecha.Value.ToString("yyyy-MM-dd");
            string Date2 = fecha2.Value.ToString("yyyy-MM-dd");

            listBitacora.DataSource = bitacoraDB.GetBitacorass(Date, Date2, Id_Usuario);
            listBitacora.Columns[0].Visible = false;
            listBitacora.Columns[1].Visible = false;

        }

        private void View_Bitacora_FormClosing(object sender, FormClosingEventArgs e)
        {
            Reportes reportes = new Reportes(bitacora, usuario);
            reportes.Show();
        }


    }
}
