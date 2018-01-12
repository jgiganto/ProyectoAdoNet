namespace ProyectoAdoNet.Desconectado
{
    partial class Form01PrimerDataSet
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
            this.btncargardepartamento = new System.Windows.Forms.Button();
            this.btncargarempleados = new System.Windows.Forms.Button();
            this.btnmostrardatosxml = new System.Windows.Forms.Button();
            this.btnmostraresquemaxsd = new System.Windows.Forms.Button();
            this.gridtabla = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumerodetablas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridtabla)).BeginInit();
            this.SuspendLayout();
            // 
            // btncargardepartamento
            // 
            this.btncargardepartamento.Location = new System.Drawing.Point(50, 31);
            this.btncargardepartamento.Name = "btncargardepartamento";
            this.btncargardepartamento.Size = new System.Drawing.Size(150, 99);
            this.btncargardepartamento.TabIndex = 0;
            this.btncargardepartamento.Text = "Cargar departamentos";
            this.btncargardepartamento.UseVisualStyleBackColor = true;
            this.btncargardepartamento.Click += new System.EventHandler(this.btncargardepartamento_Click);
            // 
            // btncargarempleados
            // 
            this.btncargarempleados.Location = new System.Drawing.Point(217, 31);
            this.btncargarempleados.Name = "btncargarempleados";
            this.btncargarempleados.Size = new System.Drawing.Size(150, 99);
            this.btncargarempleados.TabIndex = 1;
            this.btncargarempleados.Text = "Cargar Empleados";
            this.btncargarempleados.UseVisualStyleBackColor = true;
            this.btncargarempleados.Click += new System.EventHandler(this.btncargarempleados_Click);
            // 
            // btnmostrardatosxml
            // 
            this.btnmostrardatosxml.Location = new System.Drawing.Point(382, 31);
            this.btnmostrardatosxml.Name = "btnmostrardatosxml";
            this.btnmostrardatosxml.Size = new System.Drawing.Size(150, 99);
            this.btnmostrardatosxml.TabIndex = 2;
            this.btnmostrardatosxml.Text = "Mostrar Datos xml";
            this.btnmostrardatosxml.UseVisualStyleBackColor = true;
            this.btnmostrardatosxml.Click += new System.EventHandler(this.btnmostrardatosxml_Click);
            // 
            // btnmostraresquemaxsd
            // 
            this.btnmostraresquemaxsd.Location = new System.Drawing.Point(549, 31);
            this.btnmostraresquemaxsd.Name = "btnmostraresquemaxsd";
            this.btnmostraresquemaxsd.Size = new System.Drawing.Size(150, 99);
            this.btnmostraresquemaxsd.TabIndex = 3;
            this.btnmostraresquemaxsd.Text = "Mostrar Esquema xsd";
            this.btnmostraresquemaxsd.UseVisualStyleBackColor = true;
            this.btnmostraresquemaxsd.Click += new System.EventHandler(this.btnmostraresquemaxsd_Click);
            // 
            // gridtabla
            // 
            this.gridtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridtabla.Location = new System.Drawing.Point(29, 218);
            this.gridtabla.Name = "gridtabla";
            this.gridtabla.Size = new System.Drawing.Size(717, 327);
            this.gridtabla.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "tabla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Número de tablas del DataSet:";
            // 
            // txtnumerodetablas
            // 
            this.txtnumerodetablas.Location = new System.Drawing.Point(257, 183);
            this.txtnumerodetablas.Name = "txtnumerodetablas";
            this.txtnumerodetablas.Size = new System.Drawing.Size(100, 22);
            this.txtnumerodetablas.TabIndex = 7;
            // 
            // Form01PrimerDataSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 573);
            this.Controls.Add(this.txtnumerodetablas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridtabla);
            this.Controls.Add(this.btnmostraresquemaxsd);
            this.Controls.Add(this.btnmostrardatosxml);
            this.Controls.Add(this.btncargarempleados);
            this.Controls.Add(this.btncargardepartamento);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form01PrimerDataSet";
            this.Text = "Form01PrimerDataSet";
            this.Load += new System.EventHandler(this.Form01PrimerDataSet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridtabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncargardepartamento;
        private System.Windows.Forms.Button btncargarempleados;
        private System.Windows.Forms.Button btnmostrardatosxml;
        private System.Windows.Forms.Button btnmostraresquemaxsd;
        private System.Windows.Forms.DataGridView gridtabla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnumerodetablas;
    }
}