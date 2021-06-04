
namespace Administracion_Torneos.Vista
{
    partial class View_Horario
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
            this.Hora_Inicia = new System.Windows.Forms.DateTimePicker();
            this.cbxDias = new System.Windows.Forms.ComboBox();
            this.Hora_Cierre = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Hora_Inicia
            // 
            this.Hora_Inicia.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Hora_Inicia.Location = new System.Drawing.Point(517, 144);
            this.Hora_Inicia.Name = "Hora_Inicia";
            this.Hora_Inicia.Size = new System.Drawing.Size(203, 20);
            this.Hora_Inicia.TabIndex = 27;
            // 
            // cbxDias
            // 
            this.cbxDias.FormattingEnabled = true;
            this.cbxDias.Location = new System.Drawing.Point(537, 95);
            this.cbxDias.Name = "cbxDias";
            this.cbxDias.Size = new System.Drawing.Size(160, 21);
            this.cbxDias.TabIndex = 28;
            // 
            // Hora_Cierre
            // 
            this.Hora_Cierre.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Hora_Cierre.Location = new System.Drawing.Point(517, 188);
            this.Hora_Cierre.Name = "Hora_Cierre";
            this.Hora_Cierre.Size = new System.Drawing.Size(203, 20);
            this.Hora_Cierre.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(567, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 26);
            this.label1.TabIndex = 30;
            this.label1.Text = "Horario";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(84, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(368, 131);
            this.dataGridView1.TabIndex = 31;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(572, 233);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 47);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Guardar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(201, 233);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(117, 47);
            this.btnEditar.TabIndex = 33;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // View_Horario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(761, 305);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hora_Cierre);
            this.Controls.Add(this.cbxDias);
            this.Controls.Add(this.Hora_Inicia);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "View_Horario";
            this.Text = "Horario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.View_Horario_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Hora_Inicia;
        private System.Windows.Forms.ComboBox cbxDias;
        private System.Windows.Forms.DateTimePicker Hora_Cierre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEditar;
    }
}