
namespace Administracion_Torneos.Vista
{
    partial class ViewListaEquipos
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
            this.listEquipos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 39);
            this.label1.TabIndex = 20;
            this.label1.Text = "Listado de Equipos\r\n";
            // 
            // listEquipos
            // 
            this.listEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listEquipos.Location = new System.Drawing.Point(178, 102);
            this.listEquipos.Name = "listEquipos";
            this.listEquipos.RowHeadersWidth = 51;
            this.listEquipos.Size = new System.Drawing.Size(444, 311);
            this.listEquipos.TabIndex = 19;
            // 
            // ViewListaEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listEquipos);
            this.Name = "ViewListaEquipos";
            this.Text = "ViewListaEquipos";
            ((System.ComponentModel.ISupportInitialize)(this.listEquipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView listEquipos;
    }
}