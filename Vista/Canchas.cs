﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Administracion_Torneos.BD;
using Administracion_Torneos.Modelo;

namespace Administracion_Torneos.Vista
{
    public partial class Canchas : Form
    {
        public CanchaDb canchaContext = new CanchaDb();
        public Modelo.Cancha canchaSeleccionada = new Modelo.Cancha();
        public enum Acciones
        {
            editar = 0,
            guardar = 1
        }
        public int accion = 1;
        public int id_usuario;
        public int bitacora;
        public Canchas(int id_bitacora, int id_user)
        {
            InitializeComponent();
            GetCanchaActualizada();
            canchalist.AllowUserToAddRows = false;
            canchalist.AllowDrop = false;
            canchalist.AllowUserToDeleteRows = false;
            canchalist.MultiSelect = false;
            cbxEstado.Items.Add("Habilitada");
            cbxEstado.Items.Add("Deshabilitada");
            cbxCapacidad.Items.Add("5");
            cbxCapacidad.Items.Add("7");
            cbxCapacidad.Items.Add("11");
            id_usuario = id_user;
            bitacora = id_bitacora;
        }


        public void GetCanchaActualizada()
        {
            canchalist.DataSource = canchaContext.GetCanchas();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (accion == 1)
            {
                Modelo.Cancha nCancha = new Modelo.Cancha();
                nCancha.Nombre = txtNombre.Text;
                nCancha.Capacidad = cbxCapacidad.Text;
                nCancha.estatus = cbxEstado.Text;
                nCancha.precio = Convert.ToDecimal(txtPrecio.Text);
                canchaContext.AddCancha(nCancha);
                GetCanchaActualizada();
            }
            else if (accion == 0)
            {
                int NoCancha = GetID();
                string Nombre = txtNombre.Text;
                string Capacidad = cbxCapacidad.Text;
                string estatus = cbxEstado.Text;
                decimal Precio = Convert.ToDecimal(txtPrecio.Text);
                canchaContext.UpdateCancha(NoCancha, Nombre, Capacidad, estatus, Precio);
                accion = 1;
                GetCanchaActualizada();
            }
            txtNombre.Clear();
            cbxCapacidad.Text = "";
            cbxEstado.Text = "";
            txtPrecio.Clear();
        }

        public int GetID()
        {
            try
            {
                return int.Parse(
                    canchalist.Rows[canchalist.CurrentRow.Index].Cells[0].Value.ToString()
                    );
            }
            catch
            {
                return 0;
            }
        }

        public string GetCapacidad()
        {
            try
            {
                return canchalist.Rows[canchalist.CurrentRow.Index].Cells[2].Value.ToString();
            }
            catch
            {
                return null;
            }
        }

        public string GetEstado()
        {
            try
            {
                return canchalist.Rows[canchalist.CurrentRow.Index].Cells[3].Value.ToString();
            }
            catch
            {
                return null;
            }
        }

        public decimal? GetPrecio()
        {
            try
            {
                return decimal.Parse(
                    canchalist.Rows[canchalist.CurrentRow.Index].Cells[4].Value.ToString()
                    ); 
            }
            catch
            {
                return null;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int NoCancha = GetID();
            canchaContext.DeleteCancha(NoCancha);
            GetCanchaActualizada();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            accion = 0;
            int NoCancha = GetID();
            Modelo.Cancha canchaEditar = canchaContext.GetCancha(NoCancha);
            txtNombre.Text = canchaEditar.Nombre;
            cbxCapacidad.Text = canchaEditar.Capacidad;
            cbxEstado.Text = canchaEditar.estatus;
            txtPrecio.Text = Convert.ToString(canchaEditar.precio);
        }

        private void Canchas_Load(object sender, EventArgs e)
        {

        }

        private void cbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbxCapacidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNoCancha_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbxCapacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbxCapacidad_MouseClick(object sender, MouseEventArgs e)
        {
            cbxCapacidad.DroppedDown = true;
        }

        private void cbxEstado_MouseClick(object sender, MouseEventArgs e)
        {
            cbxEstado.DroppedDown = true;
        }

        private void btnPartidosAfectados_Click(object sender, EventArgs e)
        {
            if (GetEstado() == "Deshabilitada")
            {
                this.Hide();
                ReportePartidosAfectados reportePartidosAfectados = new ReportePartidosAfectados(GetCapacidad(),bitacora, id_usuario);
                reportePartidosAfectados.Show();
            }
            else
            {
                MessageBox.Show("La cancha seleccionada está habilitada, no afecta ningún partido","Error");
            }
            
        }

        private void Canchas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menucontrol menucontrol = new Menucontrol(bitacora,id_usuario);
            menucontrol.Show();
        }
    }
}
