namespace ProyectoAdoNet
{
    partial class Form3BuscarApellidos
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnbuscarempleados = new System.Windows.Forms.Button();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstempleados
            // 
            this.lstempleados.FormattingEnabled = true;
            this.lstempleados.Location = new System.Drawing.Point(111, 254);
            this.lstempleados.Name = "lstempleados";
            this.lstempleados.Size = new System.Drawing.Size(480, 264);
            this.lstempleados.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Empleados:";
            // 
            // btnbuscarempleados
            // 
            this.btnbuscarempleados.Location = new System.Drawing.Point(111, 88);
            this.btnbuscarempleados.Name = "btnbuscarempleados";
            this.btnbuscarempleados.Size = new System.Drawing.Size(109, 56);
            this.btnbuscarempleados.TabIndex = 7;
            this.btnbuscarempleados.Text = "Buscar empleados";
            this.btnbuscarempleados.UseVisualStyleBackColor = true;
            this.btnbuscarempleados.Click += new System.EventHandler(this.btnbuscarempleados_Click);
            // 
            // txtapellidos
            // 
            this.txtapellidos.Location = new System.Drawing.Point(111, 36);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(261, 20);
            this.txtapellidos.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Apellidos:";
            // 
            // Form3BuscarApellidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 584);
            this.Controls.Add(this.lstempleados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnbuscarempleados);
            this.Controls.Add(this.txtapellidos);
            this.Controls.Add(this.label1);
            this.Name = "Form3BuscarApellidos";
            this.Text = "Form3BuscarApellidos";
            this.Load += new System.EventHandler(this.Form3BuscarApellidos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstempleados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnbuscarempleados;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.Label label1;
    }
}