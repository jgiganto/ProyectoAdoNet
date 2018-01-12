namespace ProyectoAdoNet.Desconectado
{
    partial class btnmodificar
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
            this.txthospital = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.txtespecialidad = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lsvdoctores = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txthospital
            // 
            this.txthospital.Location = new System.Drawing.Point(114, 572);
            this.txthospital.Name = "txthospital";
            this.txthospital.Size = new System.Drawing.Size(126, 22);
            this.txthospital.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 578);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Hospital";
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(114, 512);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(126, 22);
            this.txtsalario.TabIndex = 29;
            // 
            // txtespecialidad
            // 
            this.txtespecialidad.Location = new System.Drawing.Point(114, 439);
            this.txtespecialidad.Name = "txtespecialidad";
            this.txtespecialidad.Size = new System.Drawing.Size(126, 22);
            this.txtespecialidad.TabIndex = 28;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(114, 386);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(126, 22);
            this.txtapellido.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Salario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Especialidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Apellido";
            // 
            // lsvdoctores
            // 
            this.lsvdoctores.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lsvdoctores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lsvdoctores.FullRowSelect = true;
            this.lsvdoctores.HideSelection = false;
            this.lsvdoctores.Location = new System.Drawing.Point(65, 63);
            this.lsvdoctores.Name = "lsvdoctores";
            this.lsvdoctores.Size = new System.Drawing.Size(567, 266);
            this.lsvdoctores.TabIndex = 23;
            this.lsvdoctores.UseCompatibleStateImageBehavior = false;
            this.lsvdoctores.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "APELLIDO";
            this.columnHeader1.Width = 248;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ESPECIALIDAD";
            this.columnHeader2.Width = 451;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 86);
            this.button1.TabIndex = 32;
            this.button1.Text = "MODIFICAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "DOCTORES";
            // 
            // btnmodificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 701);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txthospital);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.txtespecialidad);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lsvdoctores);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "btnmodificar";
            this.Load += new System.EventHandler(this.btnmodificar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txthospital;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.TextBox txtespecialidad;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lsvdoctores;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}