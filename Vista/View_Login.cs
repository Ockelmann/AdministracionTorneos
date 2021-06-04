using Administracion_Torneos.BD;
using System;
using System.Windows.Forms;

namespace Administracion_Torneos.Vista
{
    public partial class View_Login : Form
    {
        LoginDB loginDB = new LoginDB();
        public string Date = DateTime.Now.ToString("yyyy-MM-dd");
        public string Ingreso = DateTime.Now.ToString("hh:mm");
        public int IDBitacora;

        public View_Login()
        {
            InitializeComponent();
            txtContraseña.PasswordChar = '*';
        }



        private void inciar_Click(object sender, EventArgs e)
        {
            
            int id_user = loginDB.GetId(txtUser.Text, txtContraseña.Text);

            Boolean estado_user = loginDB.GetEstado(txtUser.Text, txtContraseña.Text);
            if (estado_user == true)
            {
                loginDB.AddBitacora(id_user, Date, Ingreso);
                this.Hide();
                 Menucontrol t = new Menucontrol(loginDB.GetIdBitacora(id_user, Date, Ingreso), id_user);
                t.Show();
            }
            else
            {
                MessageBox.Show("Usuario Deshabilitado");
            }
        }

     }
            
            
            
}

