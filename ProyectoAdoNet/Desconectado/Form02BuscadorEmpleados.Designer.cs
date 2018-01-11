namespace ProyectoAdoNet.Desconectado
{
    partial class Form02BuscadorEmpleados
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
            this.btnfiltrardesc = new System.Windows.Forms.Button();
            this.btnfiltrarconectado = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstempleados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "salario";
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(146, 47);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(100, 23);
            this.txtsalario.TabIndex = 1;
            // 
            // btnfiltrardesc
            // 
            this.btnfiltrardesc.Location = new System.Drawing.Point(42, 152);
            this.btnfiltrardesc.Name = "btnfiltrardesc";
            this.btnfiltrardesc.Size = new System.Drawing.Size(216, 32);
            this.btnfiltrardesc.TabIndex = 2;
            this.btnfiltrardesc.Text = "Filtrar DESCONECTADO";
            this.btnfiltrardesc.UseVisualStyleBackColor = true;
            this.btnfiltrardesc.Click += new System.EventHandler(this.btnfiltrardesc_Click);
            // 
            // btnfiltrarconectado
            // 
            this.btnfiltrarconectado.Location = new System.Drawing.Point(42, 206);
            this.btnfiltrarconectado.Name = "btnfiltrarconectado";
            this.btnfiltrarconectado.Size = new System.Drawing.Size(216, 32);
            this.btnfiltrarconectado.TabIndex = 3;
            this.btnfiltrarconectado.Text = "Filtrar CONECTADO";
            this.btnfiltrarconectado.UseVisualStyleBackColor = true;
            this.btnfiltrarconectado.Click += new System.EventHandler(this.btnfiltrarconectado_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Empleados";
            // 
            // lstempleados
            // 
            this.lstempleados.FormattingEnabled = true;
            this.lstempleados.ItemHeight = 17;
            this.lstempleados.Location = new System.Drawing.Point(45, 333);
            this.lstempleados.Name = "lstempleados";
            this.lstempleados.Size = new System.Drawing.Size(320, 191);
            this.lstempleados.TabIndex = 5;
            // 
            // Form02BuscadorEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 592);
            this.Controls.Add(this.lstempleados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnfiltrarconectado);
            this.Controls.Add(this.btnfiltrardesc);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form02BuscadorEmpleados";
            this.Text = "Form02BuscadorEmpleados";
            this.Load += new System.EventHandler(this.Form02BuscadorEmpleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.Button btnfiltrardesc;
        private System.Windows.Forms.Button btnfiltrarconectado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstempleados;
    }
}