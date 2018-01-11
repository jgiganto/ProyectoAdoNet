namespace ProyectoAdoNet
{
    partial class Form05ModificarSalas
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
            this.Sales = new System.Windows.Forms.Label();
            this.lbmensaje = new System.Windows.Forms.Label();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.txtnuevonombre = new System.Windows.Forms.TextBox();
            this.lstlistarsalas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Sales
            // 
            this.Sales.AutoSize = true;
            this.Sales.Location = new System.Drawing.Point(23, 13);
            this.Sales.Name = "Sales";
            this.Sales.Size = new System.Drawing.Size(45, 18);
            this.Sales.TabIndex = 0;
            this.Sales.Text = "Sales";
            // 
            // lbmensaje
            // 
            this.lbmensaje.AutoSize = true;
            this.lbmensaje.Location = new System.Drawing.Point(26, 428);
            this.lbmensaje.Name = "lbmensaje";
            this.lbmensaje.Size = new System.Drawing.Size(78, 18);
            this.lbmensaje.TabIndex = 2;
            this.lbmensaje.Text = "lblmensaje";
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(353, 88);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(169, 81);
            this.btnmodificar.TabIndex = 3;
            this.btnmodificar.Text = "Modificar Datos";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // txtnuevonombre
            // 
            this.txtnuevonombre.Location = new System.Drawing.Point(353, 224);
            this.txtnuevonombre.Name = "txtnuevonombre";
            this.txtnuevonombre.Size = new System.Drawing.Size(169, 24);
            this.txtnuevonombre.TabIndex = 4;
            // 
            // lstlistarsalas
            // 
            this.lstlistarsalas.FormattingEnabled = true;
            this.lstlistarsalas.ItemHeight = 18;
            this.lstlistarsalas.Location = new System.Drawing.Point(29, 62);
            this.lstlistarsalas.Name = "lstlistarsalas";
            this.lstlistarsalas.Size = new System.Drawing.Size(214, 310);
            this.lstlistarsalas.TabIndex = 5;
            this.lstlistarsalas.SelectedIndexChanged += new System.EventHandler(this.lstlistarsalas_SelectedIndexChanged);
            // 
            // Form05ModificarSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 600);
            this.Controls.Add(this.lstlistarsalas);
            this.Controls.Add(this.txtnuevonombre);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.lbmensaje);
            this.Controls.Add(this.Sales);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form05ModificarSalas";
            this.Text = "Form05ModificarSalas";
            this.Load += new System.EventHandler(this.Form05ModificarSalas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Sales;
        private System.Windows.Forms.Label lbmensaje;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.TextBox txtnuevonombre;
        private System.Windows.Forms.ListBox lstlistarsalas;
    }
}