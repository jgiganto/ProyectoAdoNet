namespace ProyectoAdoNet
{
    partial class Form11EliminarEnfermoProcedimientos
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
            this.lsenfermos = new System.Windows.Forms.ListBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enfermos";
            // 
            // lsenfermos
            // 
            this.lsenfermos.FormattingEnabled = true;
            this.lsenfermos.Location = new System.Drawing.Point(30, 91);
            this.lsenfermos.Name = "lsenfermos";
            this.lsenfermos.Size = new System.Drawing.Size(176, 303);
            this.lsenfermos.TabIndex = 1;
            this.lsenfermos.SelectedIndexChanged += new System.EventHandler(this.lsenfermos_SelectedIndexChanged);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(258, 91);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(112, 56);
            this.btneliminar.TabIndex = 2;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // Form11EliminarEnfermoProcedimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 563);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.lsenfermos);
            this.Controls.Add(this.label1);
            this.Name = "Form11EliminarEnfermoProcedimientos";
            this.Text = "Form11EliminarEnfermoProcedimientos";
            this.Load += new System.EventHandler(this.Form11EliminarEnfermoProcedimientos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsenfermos;
        private System.Windows.Forms.Button btneliminar;
    }
}