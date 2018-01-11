namespace ProyectoAdoNet.Desconectado
{
    partial class Form03BuscadorEmpleadosCorrecto
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
            this.txtoficio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstempleados
            // 
            this.lstempleados.FormattingEnabled = true;
            this.lstempleados.ItemHeight = 16;
            this.lstempleados.Location = new System.Drawing.Point(139, 319);
            this.lstempleados.Name = "lstempleados";
            this.lstempleados.Size = new System.Drawing.Size(320, 180);
            this.lstempleados.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Empleados";
            // 
            // txtoficio
            // 
            this.txtoficio.Location = new System.Drawing.Point(240, 33);
            this.txtoficio.Name = "txtoficio";
            this.txtoficio.Size = new System.Drawing.Size(100, 22);
            this.txtoficio.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Oficio";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Buscar Empleados";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form03BuscadorEmpleadosCorrecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 533);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstempleados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtoficio);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form03BuscadorEmpleadosCorrecto";
            this.Text = "Form03BuscadorEmpleadosCorrecto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstempleados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtoficio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}