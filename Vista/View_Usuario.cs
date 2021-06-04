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
    public partial class Usuario : Form
    {
        UsuariosDB UsuarioContext = new UsuariosDB();
        public int accion = 1;
        public int idbitacora;
        public int usuario;
        public Usuario(int id_bitacora, int id_user)
        {
            InitializeComponent();
            usuario = id_user;
            idbitacora = id_bitacora;
            listUusarios.AllowUserToAddRows = false;
            listUusarios.AllowDrop = false;
            listUusarios.AllowUserToDeleteRows = false;
            listUusarios.MultiSelect = false;
            Get_Usuario();
        }

        private void Get_Usuario()
        {
            listUusarios.DataSource = UsuarioContext.GetUsuarios();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (accion)
            {
                case 1:
                    //Validacion de Espacios en Blanco
                    if (txtDPI.Text == "" || txtName.Text == "" || txtLatName.Text == "" || txtPhone.Text == "" || txtCorreo.Text == "" || txtPhone.Text == "" || txtPuesto.Text == "" || txtUser.Text == ""|| txtContraseña.Text == "")
                    {
                        MessageBox.Show("Valores en blanco", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        //Guarda los datos en el modelo
                        Usuarios Usuario = new Usuarios();
                        Usuario.dpi = txtDPI.Text;
                        Usuario.Nombres = txtName.Text;
                        Usuario.Apellidos = txtLatName.Text;
                        Usuario.user = txtUser.Text;
                        Usuario.contraseña = txtContraseña.Text;
                        Usuario.Telefono = txtPhone.Text;
                        Usuario.Direccion = txtDireccion.Text;
                        Usuario.Correo = txtCorreo.Text;
                        Usuario.Puesto = txtPuesto.Text;
                        Usuario.Rol = cbRol.Text;

                        UsuarioContext.AddUsuarios(Usuario);

                        //Limpia el texbox
                        txtDPI.Clear();
                        txtName.Clear();
                        txtLatName.Clear();
                        txtPhone.Clear();
                        txtDireccion.Clear();
                        txtCorreo.Clear();
                        txtPuesto.Clear();
                        txtUser.Clear();
                        txtContraseña.Clear();
                        Get_Usuario();
                    }
                    break;
                case 2:
                    //Validacion de Espacios en Blanco
                    if (txtDPI.Text == "" || txtName.Text == "" || txtLatName.Text == "" || txtPhone.Text == "" || txtCorreo.Text == "" || txtPhone.Text == "" || txtPuesto.Text == "" || txtUser.Text == "" || txtContraseña.Text == "")
                    {
                        MessageBox.Show("Valores en blanco", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //Guarda los datos en el modelo
                        Usuarios Usuario = new Usuarios();
                        Usuario.dpi = txtDPI.Text;
                        Usuario.Nombres = txtName.Text;
                        Usuario.Apellidos = txtLatName.Text;
                        Usuario.user = txtUser.Text;
                        Usuario.contraseña = txtContraseña.Text;
                        Usuario.Telefono = txtPhone.Text;
                        Usuario.Direccion = txtDireccion.Text;
                        Usuario.Correo = txtCorreo.Text;
                        Usuario.Puesto = txtPuesto.Text;
                        Usuario.Rol = cbRol.Text;

                        UsuarioContext.UpdateUsuario(Usuario);

                        //Limpia el texbox
                        txtDPI.Clear();
                        txtName.Clear();
                        txtLatName.Clear();
                        txtPhone.Clear();
                        txtDireccion.Clear();
                        txtCorreo.Clear();
                        txtPuesto.Clear();
                        txtUser.Clear();
                        txtContraseña.Clear();
                        Get_Usuario();
                    }
                        break;
            }


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons eliminar = MessageBoxButtons.YesNo;
            DialogResult dr2 = MessageBox.Show("¿SEGURO DE QUE DESEA Actualizar Usuario", "ALERTA", eliminar, MessageBoxIcon.Warning);
            if (dr2 == DialogResult.Yes)
            {
                accion = 2;
                //Se muestra en el texbox los datos del Torneo Seleccionado

                int ID_Usuario = GetID();

                Usuarios Usuario = UsuarioContext.GetUsuario(ID_Usuario);
                txtDPI.Text = Usuario.dpi;
                txtName.Text = Usuario.Nombres;
                txtLatName.Text = Usuario.Apellidos;
                txtUser.Text = Usuario.user;
                txtContraseña.Text = Usuario.contraseña;
                txtPhone.Text = Usuario.Telefono;
                txtDireccion.Text = Usuario.Direccion;
                txtCorreo.Text = Usuario.Correo;
                txtPuesto.Text = Usuario.Puesto;
                cbRol.Text = Usuario.Rol;
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
                    listUusarios.Rows[listUusarios.CurrentRow.Index].Cells[0].Value.ToString()
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
            DialogResult dr = MessageBox.Show("¿SEGURO DE QUE DESEA Deshabilitar Usuario?", "ALERTA", eliminar, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                UsuarioContext.DesactivarUser(GetID());
                Get_Usuario();
            }
            else if (dr == DialogResult.No)
            {
                MessageBox.Show("Se cancelo el Deshabilitar Usuario correctamente");
            }
        }

        private void Usuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menucontrol menucontrol = new Menucontrol(idbitacora,usuario);
            menucontrol.Show();
        }
    }
}
