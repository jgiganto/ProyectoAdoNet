namespace ProyectoAdoNet.Desconectado
{
    partial class Form06ModeloCapas
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
            this.txtcamas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lsvhospitales = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtcamas
            // 
            this.txtcamas.Location = new System.Drawing.Point(506, 441);
            this.txtcamas.Name = "txtcamas";
            this.txtcamas.Size = new System.Drawing.Size(100, 22);
            this.txtcamas.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Camas";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(340, 502);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(126, 22);
            this.txttelefono.TabIndex = 20;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(238, 441);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(228, 22);
            this.txtdireccion.TabIndex = 19;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(47, 441);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(123, 22);
            this.txtnombre.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 502);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Hospitales";
            // 
            // lsvhospitales
            // 
            this.lsvhospitales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lsvhospitales.FullRowSelect = true;
            this.lsvhospitales.HideSelection = false;
            this.lsvhospitales.Location = new System.Drawing.Point(47, 58);
            this.lsvhospitales.Name = "lsvhospitales";
            this.lsvhospitales.Size = new System.Drawing.Size(567, 266);
            this.lsvhospitales.TabIndex = 12;
            this.lsvhospitales.UseCompatibleStateImageBehavior = false;
            this.lsvhospitales.View = System.Windows.Forms.View.Details;
            this.lsvhospitales.SelectedIndexChanged += new System.EventHandler(this.lsvhospitales_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "NOMBRE";
            this.columnHeader1.Width = 248;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "DIRECCION";
            this.columnHeader2.Width = 451;
            // 
            // Form06ModeloCapas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 593);
            this.Controls.Add(this.txtcamas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsvhospitales);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form06ModeloCapas";
            this.Text = "Form06ModeloCapas";
            this.Load += new System.EventHandler(this.Form06ModeloCapas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcamas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsvhospitales;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}