namespace ProyectoAdoNet.Desconectado
{
    partial class Form04DepartamentosEmpleados
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
            this.lstdepartamentos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtlocalidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtempleados = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtoficio = new System.Windows.Forms.TextBox();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.txtcomision = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departamentos";
            // 
            // lstdepartamentos
            // 
            this.lstdepartamentos.FormattingEnabled = true;
            this.lstdepartamentos.ItemHeight = 17;
            this.lstdepartamentos.Location = new System.Drawing.Point(62, 94);
            this.lstdepartamentos.Name = "lstdepartamentos";
            this.lstdepartamentos.Size = new System.Drawing.Size(217, 259);
            this.lstdepartamentos.TabIndex = 1;
            this.lstdepartamentos.SelectedIndexChanged += new System.EventHandler(this.lstdepartamentos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Localidad";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(31, 433);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(133, 23);
            this.txtnombre.TabIndex = 4;
            // 
            // txtlocalidad
            // 
            this.txtlocalidad.Location = new System.Drawing.Point(228, 433);
            this.txtlocalidad.Name = "txtlocalidad";
            this.txtlocalidad.Size = new System.Drawing.Size(143, 23);
            this.txtlocalidad.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Empleados";
            // 
            // txtempleados
            // 
            this.txtempleados.FormattingEnabled = true;
            this.txtempleados.ItemHeight = 17;
            this.txtempleados.Location = new System.Drawing.Point(379, 94);
            this.txtempleados.Name = "txtempleados";
            this.txtempleados.Size = new System.Drawing.Size(195, 259);
            this.txtempleados.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(651, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Oficio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(651, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Salario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(651, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Comision";
            // 
            // txtoficio
            // 
            this.txtoficio.Location = new System.Drawing.Point(654, 116);
            this.txtoficio.Name = "txtoficio";
            this.txtoficio.Size = new System.Drawing.Size(100, 23);
            this.txtoficio.TabIndex = 11;
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(654, 229);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(100, 23);
            this.txtsalario.TabIndex = 12;
            // 
            // txtcomision
            // 
            this.txtcomision.Location = new System.Drawing.Point(654, 330);
            this.txtcomision.Name = "txtcomision";
            this.txtcomision.Size = new System.Drawing.Size(100, 23);
            this.txtcomision.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 517);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(237, 34);
            this.label8.TabIndex = 14;
            this.label8.Text = "EMP USAMOS CONECTADO BBDD \r\nEN DEPT SIN BBDD";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(657, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "SIN BBDD";
            // 
            // Form04DepartamentosEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 640);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtcomision);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.txtoficio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtempleados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtlocalidad);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstdepartamentos);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form04DepartamentosEmpleados";
            this.Text = "Form04DepartamentosEmpleados";
            this.Load += new System.EventHandler(this.Form04DepartamentosEmpleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstdepartamentos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtlocalidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox txtempleados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtoficio;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.TextBox txtcomision;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}