namespace ProyectoAdoNet
{
    partial class Form14SeleccionMultiple
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
            this.lssalas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lsplantilla = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txpersonas = new System.Windows.Forms.TextBox();
            this.txsumasalarial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salas";
            // 
            // lssalas
            // 
            this.lssalas.FormattingEnabled = true;
            this.lssalas.ItemHeight = 20;
            this.lssalas.Location = new System.Drawing.Point(17, 94);
            this.lssalas.Name = "lssalas";
            this.lssalas.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lssalas.Size = new System.Drawing.Size(119, 204);
            this.lssalas.TabIndex = 1;
            this.lssalas.SelectedIndexChanged += new System.EventHandler(this.lssalas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Plantilla";
            // 
            // lsplantilla
            // 
            this.lsplantilla.FormattingEnabled = true;
            this.lsplantilla.ItemHeight = 20;
            this.lsplantilla.Location = new System.Drawing.Point(226, 94);
            this.lsplantilla.Name = "lsplantilla";
            this.lsplantilla.Size = new System.Drawing.Size(149, 204);
            this.lsplantilla.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Personas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Suma salarial";
            // 
            // txpersonas
            // 
            this.txpersonas.Location = new System.Drawing.Point(405, 130);
            this.txpersonas.Name = "txpersonas";
            this.txpersonas.Size = new System.Drawing.Size(100, 26);
            this.txpersonas.TabIndex = 6;
            // 
            // txsumasalarial
            // 
            this.txsumasalarial.Location = new System.Drawing.Point(409, 346);
            this.txsumasalarial.Name = "txsumasalarial";
            this.txsumasalarial.Size = new System.Drawing.Size(100, 26);
            this.txsumasalarial.TabIndex = 7;
            // 
            // Form14SeleccionMultiple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 526);
            this.Controls.Add(this.txsumasalarial);
            this.Controls.Add(this.txpersonas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lsplantilla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lssalas);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form14SeleccionMultiple";
            this.Text = "Form14SeleccionMultiple";
            this.Load += new System.EventHandler(this.Form14SeleccionMultiple_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lssalas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsplantilla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txpersonas;
        private System.Windows.Forms.TextBox txsumasalarial;
    }
}