namespace ProyectoAdoNet
{
    partial class Form13ParametrosdeSalida
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmhospitales = new System.Windows.Forms.ComboBox();
            this.txsuma = new System.Windows.Forms.TextBox();
            this.txpersonas = new System.Windows.Forms.TextBox();
            this.txmedia = new System.Windows.Forms.TextBox();
            this.lPlantilla = new System.Windows.Forms.Label();
            this.lstplantilla = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospitales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Suma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Personas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Media";
            // 
            // cmhospitales
            // 
            this.cmhospitales.FormattingEnabled = true;
            this.cmhospitales.Location = new System.Drawing.Point(45, 124);
            this.cmhospitales.Name = "cmhospitales";
            this.cmhospitales.Size = new System.Drawing.Size(121, 28);
            this.cmhospitales.TabIndex = 4;
            this.cmhospitales.SelectedIndexChanged += new System.EventHandler(this.cmhospitales_SelectedIndexChanged);
            // 
            // txsuma
            // 
            this.txsuma.Location = new System.Drawing.Point(47, 305);
            this.txsuma.Name = "txsuma";
            this.txsuma.Size = new System.Drawing.Size(100, 26);
            this.txsuma.TabIndex = 5;
            // 
            // txpersonas
            // 
            this.txpersonas.Location = new System.Drawing.Point(45, 406);
            this.txpersonas.Name = "txpersonas";
            this.txpersonas.Size = new System.Drawing.Size(100, 26);
            this.txpersonas.TabIndex = 6;
            // 
            // txmedia
            // 
            this.txmedia.Location = new System.Drawing.Point(47, 517);
            this.txmedia.Name = "txmedia";
            this.txmedia.Size = new System.Drawing.Size(100, 26);
            this.txmedia.TabIndex = 7;
            // 
            // lPlantilla
            // 
            this.lPlantilla.AutoSize = true;
            this.lPlantilla.Location = new System.Drawing.Point(405, 73);
            this.lPlantilla.Name = "lPlantilla";
            this.lPlantilla.Size = new System.Drawing.Size(72, 20);
            this.lPlantilla.TabIndex = 8;
            this.lPlantilla.Text = "Plantilla";
            // 
            // lstplantilla
            // 
            this.lstplantilla.FormattingEnabled = true;
            this.lstplantilla.ItemHeight = 20;
            this.lstplantilla.Location = new System.Drawing.Point(409, 144);
            this.lstplantilla.Name = "lstplantilla";
            this.lstplantilla.Size = new System.Drawing.Size(232, 404);
            this.lstplantilla.TabIndex = 9;
            this.lstplantilla.SelectedIndexChanged += new System.EventHandler(this.lstplantilla_SelectedIndexChanged);
            // 
            // Form13ParametrosdeSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 624);
            this.Controls.Add(this.lstplantilla);
            this.Controls.Add(this.lPlantilla);
            this.Controls.Add(this.txmedia);
            this.Controls.Add(this.txpersonas);
            this.Controls.Add(this.txsuma);
            this.Controls.Add(this.cmhospitales);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form13ParametrosdeSalida";
            this.Text = "Form13ParametrosdeSalida";
            this.Load += new System.EventHandler(this.Form13ParametrosdeSalida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmhospitales;
        private System.Windows.Forms.TextBox txsuma;
        private System.Windows.Forms.TextBox txpersonas;
        private System.Windows.Forms.TextBox txmedia;
        private System.Windows.Forms.Label lPlantilla;
        private System.Windows.Forms.ListBox lstplantilla;
    }
}