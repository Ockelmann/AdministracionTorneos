
namespace Administracion_Torneos.Vista
{
    partial class Reporte_IngresoArbitros
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
            this.listIngresos = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.fecha2 = new System.Windows.Forms.DateTimePicker();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.listIngresos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 46);
            this.label1.TabIndex = 41;
            this.label1.Text = "Ingresos Arbitros";
            // 
            // listIngresos
            // 
            this.listIngresos.AllowUserToAddRows = false;
            this.listIngresos.AllowUserToDeleteRows = false;
            this.listIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listIngresos.Location = new System.Drawing.Point(146, 238);
            this.listIngresos.Name = "listIngresos";
            this.listIngresos.ReadOnly = true;
            this.listIngresos.Size = new System.Drawing.Size(530, 173);
            this.listIngresos.TabIndex = 40;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(356, 168);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(117, 47);
            this.btnBuscar.TabIndex = 39;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // fecha2
            // 
            this.fecha2.Location = new System.Drawing.Point(425, 119);
            this.fecha2.Name = "fecha2";
            this.fecha2.Size = new System.Drawing.Size(203, 20);
            this.fecha2.TabIndex = 38;
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(172, 119);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(203, 20);
            this.fecha.TabIndex = 37;
            // 
            // Reporte_IngresoArbitros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listIngresos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.fecha2);
            this.Controls.Add(this.fecha);
            this.Name = "Reporte_IngresoArbitros";
            this.Text = "Reporte_IngresoArbitros";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reporte_IngresoArbitros_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.listIngresos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listIngresos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker fecha2;
        private System.Windows.Forms.DateTimePicker fecha;
    }
}