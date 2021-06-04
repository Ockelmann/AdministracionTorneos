
namespace Administracion_Torneos.Vista
{
    partial class ViewDisponibilidad_Cancha
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
            this.listBitacora = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbxCancha = new System.Windows.Forms.ComboBox();
            this.fecha2 = new System.Windows.Forms.DateTimePicker();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listBitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // listBitacora
            // 
            this.listBitacora.AllowUserToAddRows = false;
            this.listBitacora.AllowUserToDeleteRows = false;
            this.listBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listBitacora.Location = new System.Drawing.Point(51, 267);
            this.listBitacora.Name = "listBitacora";
            this.listBitacora.ReadOnly = true;
            this.listBitacora.Size = new System.Drawing.Size(701, 173);
            this.listBitacora.TabIndex = 36;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(330, 186);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(117, 47);
            this.btnBuscar.TabIndex = 35;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbxCancha
            // 
            this.cbxCancha.FormattingEnabled = true;
            this.cbxCancha.Location = new System.Drawing.Point(330, 91);
            this.cbxCancha.Name = "cbxCancha";
            this.cbxCancha.Size = new System.Drawing.Size(117, 21);
            this.cbxCancha.TabIndex = 34;
            // 
            // fecha2
            // 
            this.fecha2.Location = new System.Drawing.Point(413, 142);
            this.fecha2.Name = "fecha2";
            this.fecha2.Size = new System.Drawing.Size(203, 20);
            this.fecha2.TabIndex = 33;
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(160, 142);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(203, 20);
            this.fecha.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 46);
            this.label1.TabIndex = 37;
            this.label1.Text = "Disponibilidad";
            // 
            // ViewDisponibilidad_Cancha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBitacora);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbxCancha);
            this.Controls.Add(this.fecha2);
            this.Controls.Add(this.fecha);
            this.Name = "ViewDisponibilidad_Cancha";
            this.Text = "ViewDisponibilidad_Cancha";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewDisponibilidad_Cancha_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.listBitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listBitacora;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbxCancha;
        private System.Windows.Forms.DateTimePicker fecha2;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label1;
    }
}