namespace ProyectoAdoNet
{
    partial class PrimerAdo
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
            this.btnConectar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btndesconectar = new System.Windows.Forms.Button();
            this.btnleerregistros = new System.Windows.Forms.Button();
            this.lstapellidos = new System.Windows.Forms.ListBox();
            this.lstcolumnas = new System.Windows.Forms.ListBox();
            this.Columnas = new System.Windows.Forms.Label();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.lsttipos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(53, 97);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(109, 32);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Apellidos";
            // 
            // btndesconectar
            // 
            this.btndesconectar.Location = new System.Drawing.Point(53, 154);
            this.btndesconectar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndesconectar.Name = "btndesconectar";
            this.btndesconectar.Size = new System.Drawing.Size(109, 37);
            this.btndesconectar.TabIndex = 2;
            this.btndesconectar.Text = "Desconectar";
            this.btndesconectar.UseVisualStyleBackColor = true;
            this.btndesconectar.Click += new System.EventHandler(this.btndesconectar_Click);
            // 
            // btnleerregistros
            // 
            this.btnleerregistros.Location = new System.Drawing.Point(53, 208);
            this.btnleerregistros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnleerregistros.Name = "btnleerregistros";
            this.btnleerregistros.Size = new System.Drawing.Size(109, 81);
            this.btnleerregistros.TabIndex = 3;
            this.btnleerregistros.Text = "Leer registros";
            this.btnleerregistros.UseVisualStyleBackColor = true;
            this.btnleerregistros.Click += new System.EventHandler(this.btnleerregistros_Click);
            // 
            // lstapellidos
            // 
            this.lstapellidos.FormattingEnabled = true;
            this.lstapellidos.ItemHeight = 16;
            this.lstapellidos.Location = new System.Drawing.Point(290, 81);
            this.lstapellidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstapellidos.Name = "lstapellidos";
            this.lstapellidos.Size = new System.Drawing.Size(132, 292);
            this.lstapellidos.TabIndex = 4;
            // 
            // lstcolumnas
            // 
            this.lstcolumnas.FormattingEnabled = true;
            this.lstcolumnas.ItemHeight = 16;
            this.lstcolumnas.Location = new System.Drawing.Point(463, 81);
            this.lstcolumnas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstcolumnas.Name = "lstcolumnas";
            this.lstcolumnas.Size = new System.Drawing.Size(132, 292);
            this.lstcolumnas.TabIndex = 6;
            // 
            // Columnas
            // 
            this.Columnas.AutoSize = true;
            this.Columnas.Location = new System.Drawing.Point(460, 50);
            this.Columnas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Columnas.Name = "Columnas";
            this.Columnas.Size = new System.Drawing.Size(68, 16);
            this.Columnas.TabIndex = 5;
            this.Columnas.Text = "Columnas";
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Location = new System.Drawing.Point(50, 412);
            this.lblmensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(45, 16);
            this.lblmensaje.TabIndex = 7;
            this.lblmensaje.Text = "label3";
            // 
            // lsttipos
            // 
            this.lsttipos.FormattingEnabled = true;
            this.lsttipos.ItemHeight = 16;
            this.lsttipos.Location = new System.Drawing.Point(635, 81);
            this.lsttipos.Margin = new System.Windows.Forms.Padding(4);
            this.lsttipos.Name = "lsttipos";
            this.lsttipos.Size = new System.Drawing.Size(132, 292);
            this.lsttipos.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tipos:";
            // 
            // PrimerAdo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 437);
            this.Controls.Add(this.lsttipos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.lstcolumnas);
            this.Controls.Add(this.Columnas);
            this.Controls.Add(this.lstapellidos);
            this.Controls.Add(this.btnleerregistros);
            this.Controls.Add(this.btndesconectar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConectar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PrimerAdo";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.PrimerAdo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndesconectar;
        private System.Windows.Forms.Button btnleerregistros;
        private System.Windows.Forms.ListBox lstapellidos;
        private System.Windows.Forms.ListBox lstcolumnas;
        private System.Windows.Forms.Label Columnas;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.ListBox lsttipos;
        private System.Windows.Forms.Label label2;
    }
}