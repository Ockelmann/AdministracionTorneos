
namespace Administracion_Torneos.Vista
{
    partial class Lista_de_arbitross
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
            this.listArbitros = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listArbitros)).BeginInit();
            this.SuspendLayout();
            // 
            // listArbitros
            // 
            this.listArbitros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listArbitros.Location = new System.Drawing.Point(33, 188);
            this.listArbitros.Margin = new System.Windows.Forms.Padding(4);
            this.listArbitros.Name = "listArbitros";
            this.listArbitros.RowHeadersWidth = 51;
            this.listArbitros.Size = new System.Drawing.Size(729, 235);
            this.listArbitros.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(187, 84);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(455, 55);
            this.label6.TabIndex = 18;
            this.label6.Text = "Reporte de arbitros";
            // 
            // Lista_de_arbitross
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listArbitros);
            this.Name = "Lista_de_arbitross";
            this.Text = "Lista_de_arbitross";
            this.Load += new System.EventHandler(this.Lista_de_arbitross_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listArbitros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView listArbitros;
        private System.Windows.Forms.Label label6;
    }
}