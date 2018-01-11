namespace ProyectoAdoNet
{
    partial class Form4EliminarEnfermos
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
            this.txtinscripcion = new System.Windows.Forms.TextBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstenfermos = new System.Windows.Forms.ListBox();
            this.lbmensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inscripción";
            // 
            // txtinscripcion
            // 
            this.txtinscripcion.Location = new System.Drawing.Point(186, 47);
            this.txtinscripcion.Name = "txtinscripcion";
            this.txtinscripcion.Size = new System.Drawing.Size(216, 22);
            this.txtinscripcion.TabIndex = 1;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(158, 119);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(244, 23);
            this.btneliminar.TabIndex = 2;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enfermos";
            // 
            // lstenfermos
            // 
            this.lstenfermos.FormattingEnabled = true;
            this.lstenfermos.ItemHeight = 16;
            this.lstenfermos.Location = new System.Drawing.Point(77, 269);
            this.lstenfermos.Name = "lstenfermos";
            this.lstenfermos.Size = new System.Drawing.Size(494, 228);
            this.lstenfermos.TabIndex = 4;
            // 
            // lbmensaje
            // 
            this.lbmensaje.AutoSize = true;
            this.lbmensaje.Location = new System.Drawing.Point(77, 526);
            this.lbmensaje.Name = "lbmensaje";
            this.lbmensaje.Size = new System.Drawing.Size(45, 16);
            this.lbmensaje.TabIndex = 5;
            this.lbmensaje.Text = "label3";
            // 
            // Form4EliminarEnfermos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 551);
            this.Controls.Add(this.lbmensaje);
            this.Controls.Add(this.lstenfermos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.txtinscripcion);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form4EliminarEnfermos";
            this.Text = "Form4EliminarEnfermos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtinscripcion;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstenfermos;
        private System.Windows.Forms.Label lbmensaje;
    }
}