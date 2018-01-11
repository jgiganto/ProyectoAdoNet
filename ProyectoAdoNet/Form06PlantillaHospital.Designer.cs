namespace ProyectoAdoNet
{
    partial class Form06PlantillaHospital
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
            this.lshospitales = new System.Windows.Forms.ListBox();
            this.Plantilla = new System.Windows.Forms.Label();
            this.lsplantilla = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospitales";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lshospitales
            // 
            this.lshospitales.FormattingEnabled = true;
            this.lshospitales.ItemHeight = 17;
            this.lshospitales.Location = new System.Drawing.Point(30, 99);
            this.lshospitales.Name = "lshospitales";
            this.lshospitales.Size = new System.Drawing.Size(206, 276);
            this.lshospitales.TabIndex = 1;
            this.lshospitales.SelectedIndexChanged += new System.EventHandler(this.lshospitales_SelectedIndexChanged);
            // 
            // Plantilla
            // 
            this.Plantilla.AutoSize = true;
            this.Plantilla.Location = new System.Drawing.Point(299, 32);
            this.Plantilla.Name = "Plantilla";
            this.Plantilla.Size = new System.Drawing.Size(57, 17);
            this.Plantilla.TabIndex = 2;
            this.Plantilla.Text = "Plantilla";
            this.Plantilla.Click += new System.EventHandler(this.Plantilla_Click);
            // 
            // lsplantilla
            // 
            this.lsplantilla.FormattingEnabled = true;
            this.lsplantilla.ItemHeight = 17;
            this.lsplantilla.Location = new System.Drawing.Point(302, 99);
            this.lsplantilla.Name = "lsplantilla";
            this.lsplantilla.Size = new System.Drawing.Size(211, 276);
            this.lsplantilla.TabIndex = 3;
            this.lsplantilla.SelectedIndexChanged += new System.EventHandler(this.lsplantilla_SelectedIndexChanged);
            // 
            // Form06PlantillaHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(563, 460);
            this.Controls.Add(this.lsplantilla);
            this.Controls.Add(this.Plantilla);
            this.Controls.Add(this.lshospitales);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form06PlantillaHospital";
            this.Text = "Form06PlantillaHospital";
            this.Load += new System.EventHandler(this.Form06PlantillaHospital_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lshospitales;
        private System.Windows.Forms.Label Plantilla;
        private System.Windows.Forms.ListBox lsplantilla;
    }
}