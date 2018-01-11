namespace ProyectoAdoNet
{
    partial class Form2BuscarEmpleados
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
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.btnbuscarempleados = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstempleados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(30, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salario:";
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(116, 57);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(261, 22);
            this.txtsalario.TabIndex = 1;
            // 
            // btnbuscarempleados
            // 
            this.btnbuscarempleados.Location = new System.Drawing.Point(116, 109);
            this.btnbuscarempleados.Name = "btnbuscarempleados";
            this.btnbuscarempleados.Size = new System.Drawing.Size(109, 56);
            this.btnbuscarempleados.TabIndex = 2;
            this.btnbuscarempleados.Text = "Buscar empleados";
            this.btnbuscarempleados.UseVisualStyleBackColor = true;
            this.btnbuscarempleados.Click += new System.EventHandler(this.btnbuscarempleados_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Empleados:";
            // 
            // lstempleados
            // 
            this.lstempleados.FormattingEnabled = true;
            this.lstempleados.ItemHeight = 16;
            this.lstempleados.Location = new System.Drawing.Point(116, 275);
            this.lstempleados.Name = "lstempleados";
            this.lstempleados.Size = new System.Drawing.Size(480, 276);
            this.lstempleados.TabIndex = 4;
            // 
            // Form2BuscarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 644);
            this.Controls.Add(this.lstempleados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnbuscarempleados);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2BuscarEmpleados";
            this.Text = "Form2BuscarEmpleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.Button btnbuscarempleados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstempleados;
    }
}