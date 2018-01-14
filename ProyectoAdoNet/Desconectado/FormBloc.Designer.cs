namespace ProyectoAdoNet.Desconectado
{
    partial class FormBloc
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
            this.txtdatos = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtdatos
            // 
            this.txtdatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtdatos.Location = new System.Drawing.Point(0, 0);
            this.txtdatos.Name = "txtdatos";
            this.txtdatos.Size = new System.Drawing.Size(716, 543);
            this.txtdatos.TabIndex = 0;
            this.txtdatos.Text = "";
            this.txtdatos.TextChanged += new System.EventHandler(this.txtdatos_TextChanged);
            // 
            // FormBloc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 543);
            this.Controls.Add(this.txtdatos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormBloc";
            this.Text = "FormBloc";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox txtdatos;
    }
}