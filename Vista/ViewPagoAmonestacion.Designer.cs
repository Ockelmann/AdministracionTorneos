
namespace Administracion_Torneos.Vista
{
    partial class ViewPagoAmonestacion
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.listTarjetas = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTarjetaPagada = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.listTarjetas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(479, 304);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(103, 63);
            this.btnModificar.TabIndex = 40;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(599, 304);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(106, 63);
            this.btnAgregar.TabIndex = 33;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // listTarjetas
            // 
            this.listTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listTarjetas.Location = new System.Drawing.Point(77, 80);
            this.listTarjetas.Name = "listTarjetas";
            this.listTarjetas.Size = new System.Drawing.Size(628, 201);
            this.listTarjetas.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "PAGO DE TARJETAS";
            // 
            // cbTarjetaPagada
            // 
            this.cbTarjetaPagada.AutoSize = true;
            this.cbTarjetaPagada.Location = new System.Drawing.Point(319, 328);
            this.cbTarjetaPagada.Name = "cbTarjetaPagada";
            this.cbTarjetaPagada.Size = new System.Drawing.Size(99, 17);
            this.cbTarjetaPagada.TabIndex = 41;
            this.cbTarjetaPagada.Text = "Tarjeta Pagada";
            this.cbTarjetaPagada.UseVisualStyleBackColor = true;
            // 
            // ViewPagoAmonestacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(776, 414);
            this.Controls.Add(this.cbTarjetaPagada);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.listTarjetas);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewPagoAmonestacion";
            this.Text = "Pago de tarjetas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewPagoAmonestacion_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.listTarjetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView listTarjetas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbTarjetaPagada;
    }
}