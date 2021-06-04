using Administracion_Torneos.BD;
using Administracion_Torneos.Modelo;
using System;
using System.Windows.Forms;

namespace Administracion_Torneos.Vista
{
    public partial class View_Cliente : Form
    {
        ClienteDB ClienteContext = new ClienteDB();
        public int accion = 1;
        public int usuario;
        public int Bitacora;
        public View_Cliente(int id_bitacora, int id_user)
        {
            InitializeComponent();
            ListCliente.AllowUserToAddRows = false;
            ListCliente.AllowDrop = false;
            ListCliente.AllowUserToDeleteRows = false;
            ListCliente.MultiSelect = false;
            usuario = id_user;
            Bitacora = id_bitacora;
            GetCliente();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (accion)
            {
                case 1:
                    //Validacion de Espacios en Blanco
                    if(txtDPI.Text == "" || txtName.Text == "" || txtApellidos.Text == "" || txtTelefono.Text == "" || txtCorreo.Text == "")
                    {
                        MessageBox.Show("Valores en blanco", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //Guarda los datos en el modelo
                        Cliente cliente = new Cliente();
                        cliente.dpi = txtDPI.Text;
                        cliente.Nombres = txtName.Text;
                        cliente.Apellidos = txtApellidos.Text;
                        cliente.Telefono = txtTelefono.Text;
                        cliente.Correo = txtCorreo.Text;

                        ClienteContext.AddCliente(cliente);

                        //Limpia el texbox
                        txtDPI.Clear();
                        txtName.Clear();
                        txtApellidos.Clear();
                        txtTelefono.Clear();
                        txtCorreo.Clear();
                        GetCliente();
                    }
                    break;
                case 2:
                    //Validacion de Espacios en Blanco
                    if (txtDPI.Text == "" || txtName.Text == "" || txtApellidos.Text == "" || txtTelefono.Text == "" || txtCorreo.Text == "")
                    {
                        MessageBox.Show("Valores en blanco", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //Guarda los datos en el modelo
                        Cliente cliente = new Cliente();
                        cliente.dpi = txtDPI.Text;
                        cliente.Nombres = txtName.Text;
                        cliente.Apellidos = txtApellidos.Text;
                        cliente.Telefono = txtTelefono.Text;
                        cliente.Correo = txtCorreo.Text;
                        cliente.id_cliente = GetID();

                        ClienteContext.UpdateCliente(cliente);
                        //Limpia el texbox
                        accion = 1;
                        txtDPI.Clear();
                        txtName.Clear();
                        txtApellidos.Clear();
                        txtTelefono.Clear();
                        txtCorreo.Clear();
            
                        GetCliente();

                    }
                    break;
            }
        }

        private void GetCliente()
        {
            ListCliente.DataSource = ClienteContext.GetClientes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons eliminar = MessageBoxButtons.YesNo;
            DialogResult dr2 = MessageBox.Show("¿SEGURO DE QUE DESEA Actualizar Cliente", "ALERTA", eliminar, MessageBoxIcon.Warning);
            if (dr2 == DialogResult.Yes)
            {
                accion = 2;
                //Se muestra en el texbox los datos del Torneo Seleccionado

                int ID_CLIENTE = GetID();

                Cliente cliente = ClienteContext.GetCliente(ID_CLIENTE);
                txtDPI.Text = cliente.dpi;
                txtName.Text = cliente.Nombres;
                txtApellidos.Text = cliente.Apellidos;
                txtTelefono.Text = cliente.Telefono;
                txtCorreo.Text = cliente.Correo;
            }
            else if (dr2 == DialogResult.No)
            {
                MessageBox.Show("Se cancelo correctamnete la actualizacion de datos");
            }
        }

        private int GetID()
        {
            try
            {
                return int.Parse(
                    ListCliente.Rows[ListCliente.CurrentRow.Index].Cells[0].Value.ToString()
                    );
            }
            catch
            {
                return 0;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons eliminar = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("¿SEGURO DE QUE DESEA ELIMINAR AL CLIENTE?", "ALERTA", eliminar, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                ClienteContext.DeleteCliente(GetID());
                GetCliente();
            }
            else if (dr == DialogResult.No)
            {
                MessageBox.Show("Se cancelo la eliminacion correctamente");
            }
        }

        private void View_Cliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menucontrol menucontrol = new Menucontrol(Bitacora, usuario);
            menucontrol.Show();
        }
    }
}
