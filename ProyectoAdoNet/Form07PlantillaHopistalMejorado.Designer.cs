namespace ProyectoAdoNet
{
    partial class Form07PlantillaHopistalMejorado
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
            this.lsplantilla = new System.Windows.Forms.ListBox();
            this.Plantilla = new System.Windows.Forms.Label();
            this.lshospitales = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsplantilla
            // 
            this.lsplantilla.FormattingEnabled = true;
            this.lsplantilla.ItemHeight = 17;
            this.lsplantilla.Location = new System.Drawing.Point(284, 104);
            this.lsplantilla.Name = "lsplantilla";
            this.lsplantilla.Size = new System.Drawing.Size(263, 395);
            this.lsplantilla.TabIndex = 7;
            this.lsplantilla.SelectedIndexChanged += new System.EventHandler(this.lsplantilla_SelectedIndexChanged);
            // 
            // Plantilla
            // 
            this.Plantilla.AutoSize = true;
            this.Plantilla.Location = new System.Drawing.Point(281, 37);
            this.Plantilla.Name = "Plantilla";
            this.Plantilla.Size = new System.Drawing.Size(57, 17);
            this.Plantilla.TabIndex = 6;
            this.Plantilla.Text = "Plantilla";
            // 
            // lshospitales
            // 
            this.lshospitales.FormattingEnabled = true;
            this.lshospitales.ItemHeight = 17;
            this.lshospitales.Location = new System.Drawing.Point(12, 104);
            this.lshospitales.Name = "lshospitales";
            this.lshospitales.Size = new System.Drawing.Size(258, 395);
            this.lshospitales.TabIndex = 5;
            this.lshospitales.SelectedIndexChanged += new System.EventHandler(this.lshospitales_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hospitales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(41, 534);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Plantilla hospital mejorada";
            // 
            // Form07PlantillaHopistalMejorado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(576, 582);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lsplantilla);
            this.Controls.Add(this.Plantilla);
            this.Controls.Add(this.lshospitales);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form07PlantillaHopistalMejorado";
            this.Text = "Form07PlantillaHopistalMejorado";
            this.Load += new System.EventHandler(this.Form07PlantillaHopistalMejorado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsplantilla;
        private System.Windows.Forms.Label Plantilla;
        private System.Windows.Forms.ListBox lshospitales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}