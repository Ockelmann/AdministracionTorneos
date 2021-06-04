
namespace Administracion_Torneos.Vista
{
    partial class View_Bitacora
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
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.fecha2 = new System.Windows.Forms.DateTimePicker();
            this.cbxUser = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.listBitacora = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listBitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(134, 191);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(203, 20);
            this.fecha.TabIndex = 25;
            // 
            // fecha2
            // 
            this.fecha2.Location = new System.Drawing.Point(387, 191);
            this.fecha2.Name = "fecha2";
            this.fecha2.Size = new System.Drawing.Size(203, 20);
            this.fecha2.TabIndex = 26;
            // 
            // cbxUser
            // 
            this.cbxUser.FormattingEnabled = true;
            this.cbxUser.Location = new System.Drawing.Point(304, 140);
            this.cbxUser.Name = "cbxUser";
            this.cbxUser.Size = new System.Drawing.Size(117, 21);
            this.cbxUser.TabIndex = 27;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(304, 235);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(117, 47);
            this.btnBuscar.TabIndex = 28;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // listBitacora
            // 
            this.listBitacora.AllowUserToAddRows = false;
            this.listBitacora.AllowUserToDeleteRows = false;
            this.listBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listBitacora.Location = new System.Drawing.Point(25, 316);
            this.listBitacora.Name = "listBitacora";
            this.listBitacora.ReadOnly = true;
            this.listBitacora.Size = new System.Drawing.Size(701, 173);
            this.listBitacora.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 46);
            this.label1.TabIndex = 34;
            this.label1.Text = "Bitacora";
            // 
            // View_Bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(753, 493);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBitacora);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbxUser);
            this.Controls.Add(this.fecha2);
            this.Controls.Add(this.fecha);
            this.Name = "View_Bitacora";
            this.Text = "View_Bitacora";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.View_Bitacora_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.listBitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.DateTimePicker fecha2;
        private System.Windows.Forms.ComboBox cbxUser;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView listBitacora;
        private System.Windows.Forms.Label label1;
    }
}