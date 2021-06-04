
namespace Administracion_Torneos.Vista
{
    partial class ViewControlAmonestacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.listTarjetas = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxJugador = new System.Windows.Forms.ComboBox();
            this.cbxTarjeta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTiempo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxEquipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listTarjetas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROL DE TARJETAS";
            // 
            // listTarjetas
            // 
            this.listTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listTarjetas.Location = new System.Drawing.Point(32, 54);
            this.listTarjetas.Name = "listTarjetas";
            this.listTarjetas.Size = new System.Drawing.Size(628, 201);
            this.listTarjetas.TabIndex = 1;
            this.listTarjetas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listTarjetas_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(554, 278);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(106, 63);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jugador";
            // 
            // cbxJugador
            // 
            this.cbxJugador.FormattingEnabled = true;
            this.cbxJugador.Location = new System.Drawing.Point(309, 278);
            this.cbxJugador.Name = "cbxJugador";
            this.cbxJugador.Size = new System.Drawing.Size(121, 21);
            this.cbxJugador.TabIndex = 4;
            // 
            // cbxTarjeta
            // 
            this.cbxTarjeta.FormattingEnabled = true;
            this.cbxTarjeta.Location = new System.Drawing.Point(124, 320);
            this.cbxTarjeta.Name = "cbxTarjeta";
            this.cbxTarjeta.Size = new System.Drawing.Size(121, 21);
            this.cbxTarjeta.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Color de Tarjeta";
            // 
            // cbxTiempo
            // 
            this.cbxTiempo.FormattingEnabled = true;
            this.cbxTiempo.Location = new System.Drawing.Point(309, 320);
            this.cbxTiempo.Name = "cbxTiempo";
            this.cbxTiempo.Size = new System.Drawing.Size(121, 21);
            this.cbxTiempo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tiempo";
            // 
            // cbxEquipo
            // 
            this.cbxEquipo.FormattingEnabled = true;
            this.cbxEquipo.Location = new System.Drawing.Point(124, 278);
            this.cbxEquipo.Name = "cbxEquipo";
            this.cbxEquipo.Size = new System.Drawing.Size(121, 21);
            this.cbxEquipo.TabIndex = 10;
            this.cbxEquipo.SelectedIndexChanged += new System.EventHandler(this.cbxEquipo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Equipo Local/Visita";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(461, 281);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(461, 313);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // ViewControlAmonestacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(691, 369);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.cbxEquipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxTiempo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxTarjeta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxJugador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.listTarjetas);
            this.Controls.Add(this.label1);
            this.Name = "ViewControlAmonestacion";
            this.Text = "Control Amonestacion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewControlAmonestacion_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.listTarjetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listTarjetas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxJugador;
        private System.Windows.Forms.ComboBox cbxTarjeta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxTiempo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxEquipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}