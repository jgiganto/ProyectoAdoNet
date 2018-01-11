namespace ProyectoAdoNet
{
    partial class Form10AccesoEmpleado
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
            this.txapellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txnoempleado = new System.Windows.Forms.TextBox();
            this.btnacceder = new System.Windows.Forms.Button();
            this.lbmensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txapellido
            // 
            this.txapellido.Location = new System.Drawing.Point(12, 73);
            this.txapellido.Name = "txapellido";
            this.txapellido.Size = new System.Drawing.Size(254, 23);
            this.txapellido.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número de empleado";
            // 
            // txnoempleado
            // 
            this.txnoempleado.Location = new System.Drawing.Point(12, 186);
            this.txnoempleado.Name = "txnoempleado";
            this.txnoempleado.Size = new System.Drawing.Size(254, 23);
            this.txnoempleado.TabIndex = 2;
            // 
            // btnacceder
            // 
            this.btnacceder.Location = new System.Drawing.Point(16, 249);
            this.btnacceder.Name = "btnacceder";
            this.btnacceder.Size = new System.Drawing.Size(173, 113);
            this.btnacceder.TabIndex = 4;
            this.btnacceder.Text = "Acceder";
            this.btnacceder.UseVisualStyleBackColor = true;
            this.btnacceder.Click += new System.EventHandler(this.btnacceder_Click);
            // 
            // lbmensaje
            // 
            this.lbmensaje.AutoSize = true;
            this.lbmensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbmensaje.ForeColor = System.Drawing.Color.Maroon;
            this.lbmensaje.Location = new System.Drawing.Point(12, 453);
            this.lbmensaje.Name = "lbmensaje";
            this.lbmensaje.Size = new System.Drawing.Size(60, 24);
            this.lbmensaje.TabIndex = 5;
            this.lbmensaje.Text = "label3";
            // 
            // Form10AccesoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 546);
            this.Controls.Add(this.lbmensaje);
            this.Controls.Add(this.btnacceder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txnoempleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txapellido);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form10AccesoEmpleado";
            this.Text = "Form10AccesoEmpleado";
            this.Load += new System.EventHandler(this.Form10AccesoEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txapellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txnoempleado;
        private System.Windows.Forms.Button btnacceder;
        private System.Windows.Forms.Label lbmensaje;
    }
}