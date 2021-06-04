
namespace Administracion_Torneos.Vista
{
    partial class View_AlquilerCancha
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHora_Final = new System.Windows.Forms.DateTimePicker();
            this.cbArbitraje = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHora_Inicia = new System.Windows.Forms.DateTimePicker();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.cbxCanchas = new System.Windows.Forms.ComboBox();
            this.txtFecha_Apartada = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listAlquiler = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listAlquiler)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtHora_Final);
            this.groupBox2.Controls.Add(this.cbArbitraje);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtHora_Inicia);
            this.groupBox2.Controls.Add(this.cbxCliente);
            this.groupBox2.Controls.Add(this.cbxCanchas);
            this.groupBox2.Controls.Add(this.txtFecha_Apartada);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(553, 48);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(426, 438);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alquilar Cancha";
            // 
            // txtHora_Final
            // 
            this.txtHora_Final.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtHora_Final.Location = new System.Drawing.Point(181, 122);
            this.txtHora_Final.Name = "txtHora_Final";
            this.txtHora_Final.Size = new System.Drawing.Size(203, 26);
            this.txtHora_Final.TabIndex = 26;
            this.txtHora_Final.ValueChanged += new System.EventHandler(this.txtHora_Final_ValueChanged);
            // 
            // cbArbitraje
            // 
            this.cbArbitraje.AutoSize = true;
            this.cbArbitraje.Location = new System.Drawing.Point(165, 311);
            this.cbArbitraje.Name = "cbArbitraje";
            this.cbArbitraje.Size = new System.Drawing.Size(87, 24);
            this.cbArbitraje.TabIndex = 18;
            this.cbArbitraje.Text = "Arbitraje";
            this.cbArbitraje.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cliente:";
            // 
            // txtHora_Inicia
            // 
            this.txtHora_Inicia.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtHora_Inicia.Location = new System.Drawing.Point(181, 80);
            this.txtHora_Inicia.Name = "txtHora_Inicia";
            this.txtHora_Inicia.Size = new System.Drawing.Size(203, 26);
            this.txtHora_Inicia.TabIndex = 25;
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(181, 154);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(203, 28);
            this.cbxCliente.TabIndex = 13;
            this.cbxCliente.SelectedIndexChanged += new System.EventHandler(this.cbxCliente_SelectedIndexChanged);
            // 
            // cbxCanchas
            // 
            this.cbxCanchas.Enabled = false;
            this.cbxCanchas.FormattingEnabled = true;
            this.cbxCanchas.Location = new System.Drawing.Point(181, 199);
            this.cbxCanchas.Name = "cbxCanchas";
            this.cbxCanchas.Size = new System.Drawing.Size(203, 28);
            this.cbxCanchas.TabIndex = 17;
            this.cbxCanchas.SelectedIndexChanged += new System.EventHandler(this.cbxCanchas_SelectedIndexChanged);
            // 
            // txtFecha_Apartada
            // 
            this.txtFecha_Apartada.Location = new System.Drawing.Point(181, 41);
            this.txtFecha_Apartada.Name = "txtFecha_Apartada";
            this.txtFecha_Apartada.Size = new System.Drawing.Size(203, 26);
            this.txtFecha_Apartada.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(80, 199);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cancha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 244);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Precio por Hora:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(181, 244);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(203, 28);
            this.txtTotal.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hora Final:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hora Inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha Apartada:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(149, 376);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 47);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Guardar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listAlquiler);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(63, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(469, 345);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Horario Apartado";
            // 
            // listAlquiler
            // 
            this.listAlquiler.AllowUserToAddRows = false;
            this.listAlquiler.AllowUserToDeleteRows = false;
            this.listAlquiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listAlquiler.Location = new System.Drawing.Point(16, 41);
            this.listAlquiler.Margin = new System.Windows.Forms.Padding(2);
            this.listAlquiler.Name = "listAlquiler";
            this.listAlquiler.ReadOnly = true;
            this.listAlquiler.RowHeadersWidth = 51;
            this.listAlquiler.RowTemplate.Height = 24;
            this.listAlquiler.Size = new System.Drawing.Size(434, 219);
            this.listAlquiler.TabIndex = 0;
            // 
            // View_AlquilerCancha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1042, 541);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "View_AlquilerCancha";
            this.Text = "Alquiler_Cancha";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.View_AlquilerCancha_FormClosing);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listAlquiler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView listAlquiler;
        private System.Windows.Forms.ComboBox cbxCanchas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbArbitraje;
        private System.Windows.Forms.DateTimePicker txtHora_Final;
        private System.Windows.Forms.DateTimePicker txtHora_Inicia;
        private System.Windows.Forms.DateTimePicker txtFecha_Apartada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxCliente;
    }
}