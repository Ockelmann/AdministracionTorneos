
namespace Administracion_Torneos.Vista
{
    partial class TorneoCRUD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.listtorneo = new System.Windows.Forms.DataGridView();
            this.editar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Precio = new System.Windows.Forms.Label();
            this.preciotorneo = new System.Windows.Forms.NumericUpDown();
            this.Back = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.pempatado = new System.Windows.Forms.NumericUpDown();
            this.pganado = new System.Windows.Forms.NumericUpDown();
            this.pperdido = new System.Windows.Forms.NumericUpDown();
            this.cmbjugadores = new System.Windows.Forms.ComboBox();
            this.edmx = new System.Windows.Forms.NumericUpDown();
            this.edmn = new System.Windows.Forms.NumericUpDown();
            this.cmbcategoria = new System.Windows.Forms.ComboBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.fecha_final = new System.Windows.Forms.DateTimePicker();
            this.fechainicio = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listtorneo)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preciotorneo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pempatado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pganado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pperdido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edmx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edmn)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.eliminar);
            this.groupBox1.Controls.Add(this.listtorneo);
            this.groupBox1.Controls.Add(this.editar);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(959, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de Torneos";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(773, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 38);
            this.button3.TabIndex = 27;
            this.button3.Text = "Ver Jornadas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(855, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 38);
            this.button2.TabIndex = 26;
            this.button2.Text = "Crear jornadas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(774, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 38);
            this.button1.TabIndex = 25;
            this.button1.Text = "Agregar Equipos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(855, 20);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(67, 40);
            this.eliminar.TabIndex = 24;
            this.eliminar.Text = "Borrar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // listtorneo
            // 
            this.listtorneo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listtorneo.Location = new System.Drawing.Point(7, 20);
            this.listtorneo.Name = "listtorneo";
            this.listtorneo.Size = new System.Drawing.Size(760, 191);
            this.listtorneo.TabIndex = 0;
            this.listtorneo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listtorneo_CellContentClick);
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(773, 19);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(67, 40);
            this.editar.TabIndex = 23;
            this.editar.Text = "Actualizar";
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Precio);
            this.groupBox2.Controls.Add(this.preciotorneo);
            this.groupBox2.Controls.Add(this.Back);
            this.groupBox2.Controls.Add(this.btnsave);
            this.groupBox2.Controls.Add(this.pempatado);
            this.groupBox2.Controls.Add(this.pganado);
            this.groupBox2.Controls.Add(this.pperdido);
            this.groupBox2.Controls.Add(this.cmbjugadores);
            this.groupBox2.Controls.Add(this.edmx);
            this.groupBox2.Controls.Add(this.edmn);
            this.groupBox2.Controls.Add(this.cmbcategoria);
            this.groupBox2.Controls.Add(this.txtcodigo);
            this.groupBox2.Controls.Add(this.txtname);
            this.groupBox2.Controls.Add(this.fecha_final);
            this.groupBox2.Controls.Add(this.fechainicio);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(14, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(859, 219);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registro de Torneo ";
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.Location = new System.Drawing.Point(531, 85);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(37, 13);
            this.Precio.TabIndex = 25;
            this.Precio.Text = "Precio";
            // 
            // preciotorneo
            // 
            this.preciotorneo.DecimalPlaces = 2;
            this.preciotorneo.Location = new System.Drawing.Point(583, 78);
            this.preciotorneo.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.preciotorneo.Name = "preciotorneo";
            this.preciotorneo.Size = new System.Drawing.Size(67, 20);
            this.preciotorneo.TabIndex = 24;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(739, 175);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(114, 38);
            this.Back.TabIndex = 23;
            this.Back.Text = "Regresar";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(434, 134);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(114, 38);
            this.btnsave.TabIndex = 22;
            this.btnsave.Text = "guardar";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // pempatado
            // 
            this.pempatado.Location = new System.Drawing.Point(272, 127);
            this.pempatado.Name = "pempatado";
            this.pempatado.Size = new System.Drawing.Size(55, 20);
            this.pempatado.TabIndex = 21;
            // 
            // pganado
            // 
            this.pganado.Location = new System.Drawing.Point(762, 78);
            this.pganado.Name = "pganado";
            this.pganado.Size = new System.Drawing.Size(55, 20);
            this.pganado.TabIndex = 20;
            // 
            // pperdido
            // 
            this.pperdido.Location = new System.Drawing.Point(103, 127);
            this.pperdido.Name = "pperdido";
            this.pperdido.Size = new System.Drawing.Size(55, 20);
            this.pperdido.TabIndex = 19;
            // 
            // cmbjugadores
            // 
            this.cmbjugadores.FormattingEnabled = true;
            this.cmbjugadores.Items.AddRange(new object[] {
            "5",
            "7",
            "11"});
            this.cmbjugadores.Location = new System.Drawing.Point(462, 82);
            this.cmbjugadores.Name = "cmbjugadores";
            this.cmbjugadores.Size = new System.Drawing.Size(49, 21);
            this.cmbjugadores.TabIndex = 18;
            // 
            // edmx
            // 
            this.edmx.Location = new System.Drawing.Point(291, 78);
            this.edmx.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edmx.Name = "edmx";
            this.edmx.Size = new System.Drawing.Size(35, 20);
            this.edmx.TabIndex = 17;
            this.edmx.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // edmn
            // 
            this.edmn.Location = new System.Drawing.Point(127, 78);
            this.edmn.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.edmn.Name = "edmn";
            this.edmn.Size = new System.Drawing.Size(35, 20);
            this.edmn.TabIndex = 16;
            this.edmn.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.edmn.ValueChanged += new System.EventHandler(this.edmn_ValueChanged);
            // 
            // cmbcategoria
            // 
            this.cmbcategoria.FormattingEnabled = true;
            this.cmbcategoria.Items.AddRange(new object[] {
            "Juvenil",
            "Niños",
            "Libre"});
            this.cmbcategoria.Location = new System.Drawing.Point(733, 23);
            this.cmbcategoria.Name = "cmbcategoria";
            this.cmbcategoria.Size = new System.Drawing.Size(111, 21);
            this.cmbcategoria.TabIndex = 15;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(60, 23);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.ReadOnly = true;
            this.txtcodigo.Size = new System.Drawing.Size(39, 20);
            this.txtcodigo.TabIndex = 14;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(155, 22);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(105, 20);
            this.txtname.TabIndex = 13;
            // 
            // fecha_final
            // 
            this.fecha_final.Location = new System.Drawing.Point(512, 22);
            this.fecha_final.Name = "fecha_final";
            this.fecha_final.Size = new System.Drawing.Size(157, 20);
            this.fecha_final.TabIndex = 12;
            // 
            // fechainicio
            // 
            this.fechainicio.Location = new System.Drawing.Point(304, 23);
            this.fechainicio.Name = "fechainicio";
            this.fechainicio.Size = new System.Drawing.Size(152, 20);
            this.fechainicio.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(169, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Puntos por Empate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Puntos por perder";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(666, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Puntos por Ganar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(339, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Capacidad del  Campo ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(169, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "edad Maxima Permitida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Edad minima permitida ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(675, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Torneo ";
            // 
            // TorneoCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 467);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TorneoCRUD";
            this.Text = "Torneo";
            this.Load += new System.EventHandler(this.TorneoCRUD_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listtorneo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preciotorneo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pempatado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pganado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pperdido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edmx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edmn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.DataGridView listtorneo;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.NumericUpDown pempatado;
        private System.Windows.Forms.NumericUpDown pganado;
        private System.Windows.Forms.NumericUpDown pperdido;
        private System.Windows.Forms.ComboBox cmbjugadores;
        private System.Windows.Forms.NumericUpDown edmx;
        private System.Windows.Forms.NumericUpDown edmn;
        private System.Windows.Forms.ComboBox cmbcategoria;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.DateTimePicker fecha_final;
        private System.Windows.Forms.DateTimePicker fechainicio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.NumericUpDown preciotorneo;
    }
}