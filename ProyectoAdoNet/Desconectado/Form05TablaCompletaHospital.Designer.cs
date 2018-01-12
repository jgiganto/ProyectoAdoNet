namespace ProyectoAdoNet.Desconectado
{
    partial class Form05TablaCompletaHospital
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
            this.lsvhospitales = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcamas = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvhospitales
            // 
            this.lsvhospitales.FullRowSelect = true;
            this.lsvhospitales.HideSelection = false;
            this.lsvhospitales.Location = new System.Drawing.Point(25, 75);
            this.lsvhospitales.Name = "lsvhospitales";
            this.lsvhospitales.Size = new System.Drawing.Size(512, 211);
            this.lsvhospitales.TabIndex = 0;
            this.lsvhospitales.UseCompatibleStateImageBehavior = false;
            this.lsvhospitales.View = System.Windows.Forms.View.Details;
            this.lsvhospitales.SelectedIndexChanged += new System.EventHandler(this.lsvhospitales_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hospitales";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cargar Hospitales";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 526);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telefono";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(45, 465);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(123, 22);
            this.txtnombre.TabIndex = 6;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(236, 465);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(228, 22);
            this.txtdireccion.TabIndex = 7;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(338, 526);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(126, 22);
            this.txttelefono.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(501, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Camas";
            // 
            // txtcamas
            // 
            this.txtcamas.Location = new System.Drawing.Point(504, 465);
            this.txtcamas.Name = "txtcamas";
            this.txtcamas.Size = new System.Drawing.Size(100, 22);
            this.txtcamas.TabIndex = 10;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(316, 309);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(148, 54);
            this.btnbuscar.TabIndex = 11;
            this.btnbuscar.Text = "Buscar Hospitales";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // Form05TablaCompletaHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 585);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtcamas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsvhospitales);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form05TablaCompletaHospital";
            this.Text = "Form05TablaCompletaHospital";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvhospitales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcamas;
        private System.Windows.Forms.Button btnbuscar;
    }
}