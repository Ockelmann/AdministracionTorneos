
namespace Administracion_Torneos.Vista
{
    partial class ReportePartidosAfectados
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
            this.listPartidos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listPartidos)).BeginInit();
            this.SuspendLayout();
            // 
            // listPartidos
            // 
            this.listPartidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listPartidos.Location = new System.Drawing.Point(12, 60);
            this.listPartidos.Name = "listPartidos";
            this.listPartidos.Size = new System.Drawing.Size(726, 289);
            this.listPartidos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "REPORTE DE PARTIDOS AFECTADOS";
            // 
            // ReportePartidosAfectados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(750, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listPartidos);
            this.Name = "ReportePartidosAfectados";
            this.Text = "ReportePartidosAfectados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReportePartidosAfectados_FormClosing);
            this.Load += new System.EventHandler(this.ReportePartidosAfectados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listPartidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listPartidos;
        private System.Windows.Forms.Label label1;
    }
}