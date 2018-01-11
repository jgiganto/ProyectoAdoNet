namespace ProyectoAdoNet
{
    partial class Form08EjercicioOficiosEmpleado
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
            this.label2 = new System.Windows.Forms.Label();
            this.lstoficios = new System.Windows.Forms.ListBox();
            this.lstempleados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(31, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oficios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Empleado";
            // 
            // lstoficios
            // 
            this.lstoficios.FormattingEnabled = true;
            this.lstoficios.ItemHeight = 17;
            this.lstoficios.Location = new System.Drawing.Point(34, 79);
            this.lstoficios.Name = "lstoficios";
            this.lstoficios.Size = new System.Drawing.Size(168, 293);
            this.lstoficios.TabIndex = 2;
            this.lstoficios.SelectedIndexChanged += new System.EventHandler(this.lstoficios_SelectedIndexChanged);
            // 
            // lstempleados
            // 
            this.lstempleados.FormattingEnabled = true;
            this.lstempleados.ItemHeight = 17;
            this.lstempleados.Location = new System.Drawing.Point(330, 79);
            this.lstempleados.Name = "lstempleados";
            this.lstempleados.Size = new System.Drawing.Size(152, 293);
            this.lstempleados.TabIndex = 3;
            // 
            // Form08EjercicioOficiosEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 600);
            this.Controls.Add(this.lstempleados);
            this.Controls.Add(this.lstoficios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form08EjercicioOficiosEmpleado";
            this.Text = "Form08EjercicioOficiosEmpleado";
            this.Load += new System.EventHandler(this.Form08EjercicioOficiosEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstoficios;
        private System.Windows.Forms.ListBox lstempleados;
    }
}