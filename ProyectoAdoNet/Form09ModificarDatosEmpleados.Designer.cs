namespace ProyectoAdoNet
{
    partial class Form09ModificarDatosEmpleados
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
            this.lstempleados = new System.Windows.Forms.ListBox();
            this.Empleados = new System.Windows.Forms.Label();
            this.lbinfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txoficio = new System.Windows.Forms.TextBox();
            this.txsalario = new System.Windows.Forms.TextBox();
            this.txcomision = new System.Windows.Forms.TextBox();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstempleados
            // 
            this.lstempleados.FormattingEnabled = true;
            this.lstempleados.ItemHeight = 17;
            this.lstempleados.Location = new System.Drawing.Point(38, 81);
            this.lstempleados.Name = "lstempleados";
            this.lstempleados.Size = new System.Drawing.Size(155, 293);
            this.lstempleados.TabIndex = 0;
            this.lstempleados.SelectedIndexChanged += new System.EventHandler(this.lstempleados_SelectedIndexChanged);
            // 
            // Empleados
            // 
            this.Empleados.AutoSize = true;
            this.Empleados.Location = new System.Drawing.Point(38, 32);
            this.Empleados.Name = "Empleados";
            this.Empleados.Size = new System.Drawing.Size(78, 17);
            this.Empleados.TabIndex = 1;
            this.Empleados.Text = "Empleados";
            // 
            // lbinfo
            // 
            this.lbinfo.AutoSize = true;
            this.lbinfo.Location = new System.Drawing.Point(41, 514);
            this.lbinfo.Name = "lbinfo";
            this.lbinfo.Size = new System.Drawing.Size(42, 17);
            this.lbinfo.TabIndex = 2;
            this.lbinfo.Text = "lbinfo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Oficio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Salario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Comision";
            // 
            // txoficio
            // 
            this.txoficio.Location = new System.Drawing.Point(393, 95);
            this.txoficio.Name = "txoficio";
            this.txoficio.Size = new System.Drawing.Size(100, 23);
            this.txoficio.TabIndex = 7;
            // 
            // txsalario
            // 
            this.txsalario.Location = new System.Drawing.Point(393, 210);
            this.txsalario.Name = "txsalario";
            this.txsalario.Size = new System.Drawing.Size(100, 23);
            this.txsalario.TabIndex = 8;
            // 
            // txcomision
            // 
            this.txcomision.Location = new System.Drawing.Point(393, 313);
            this.txcomision.Name = "txcomision";
            this.txcomision.Size = new System.Drawing.Size(100, 23);
            this.txcomision.TabIndex = 9;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(393, 375);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(100, 54);
            this.btnmodificar.TabIndex = 10;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // Form09ModificarDatosEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 574);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.txcomision);
            this.Controls.Add(this.txsalario);
            this.Controls.Add(this.txoficio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbinfo);
            this.Controls.Add(this.Empleados);
            this.Controls.Add(this.lstempleados);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form09ModificarDatosEmpleados";
            this.Text = "Form09ModificarDatosEmpleados";
            this.Load += new System.EventHandler(this.Form09ModificarDatosEmpleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstempleados;
        private System.Windows.Forms.Label Empleados;
        private System.Windows.Forms.Label lbinfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txoficio;
        private System.Windows.Forms.TextBox txsalario;
        private System.Windows.Forms.TextBox txcomision;
        private System.Windows.Forms.Button btnmodificar;
    }
}