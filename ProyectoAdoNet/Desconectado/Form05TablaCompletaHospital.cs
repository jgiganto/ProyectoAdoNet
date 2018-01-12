using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
#region PROC ALMACENADOS
/*
CREATE PROCEDURE MOSTRARHOSPITALES
AS
SELECT* FROM HOSPITAL
GO
CREATE PROCEDURE DATOSHOSPITAL
(@HOSPITALCOD INT)
AS

    SELECT* FROM HOSPITAL
   WHERE HOSPITAL_COD = @HOSPITALCOD
GO */
#endregion

namespace ProyectoAdoNet.Desconectado
{
    public partial class Form05TablaCompletaHospital : Form
    {
        String colorletra;
        String conexion;
        SqlConnection cn;
        SqlCommand com;
        SqlDataAdapter adhosp;
        DataSet ds;


        public Form05TablaCompletaHospital()
        {
            InitializeComponent();
            this.button1.Click += Button1_Click;
            //PARA RECUPERAR CUALQUIER DATO DEL CONFIG 
            //SE USA LA CLASE ConfigurationManager
            //es case sensitive al recuperar los valores del key
            colorletra = ConfigurationManager.AppSettings["colorletra"];


            conexion = ConfigurationManager.ConnectionStrings["tajamar"].ConnectionString;
            this.ForeColor = Color.FromName(colorletra);
            this.cn = new SqlConnection(this.conexion);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.adhosp = new SqlDataAdapter();
            this.ds = new DataSet();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.CargarHospitales();
        }

        private void CargarHospitales()
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "MOSTRARHOSPITALES";
            this.adhosp.SelectCommand = this.com;
            if (this.ds.Tables.Contains("HOSPITAL"))
            {
                this.ds.Tables["HOSPITAL"].Rows.Clear();
            }
            this.adhosp.Fill(this.ds, "HOSPITAL");
            //DIBUJAMOS EN EL LISTVIEW
            //UN LISTVIEW ESTA COMPUESTO POR FILAS Y COLUMNAS
            //NORMALMENTE SOLO SE BORRAN LAS FILAS
            //Y SE AÑADEN NUEVAS FILAS SIN TOCAR LAS COLUMNNAS
            this.lsvhospitales.Columns.Add("NOMBRE");
            this.lsvhospitales.Columns.Add("DIRECCION");
            /*PODEMOS RECORRER TODAS LAS COLUMNAS DE LA TABLA
             Y DIBUJARLO DINAMICAMENTE*/
             foreach(DataColumn col in this.ds.Tables["HOSPITAL"].Columns)
            {
                //this.lsvhospitales.Columns.Add(col.ColumnName);
            }
             //agregamos filas al listview
             foreach(DataRow f in this.ds.Tables["HOSPITAL"].Rows)
            {
                ListViewItem it = new ListViewItem();
                //columna principal nombre
                it.Text = f["NOMBRE"].ToString();
                //SUNITEMS POR CADA COLUMNA AÑADIDA, DIRECCION
                it.SubItems.Add(f["DIRECCION"].ToString());
                //AÑADIMOS EL ITEM AL LISTVIEW
                this.lsvhospitales.Items.Add(it);
            }
        }

        private void lsvhospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            //indice del elemento seleccionado
            this.lsvhospitales.SelectedItems[0].Text;
        }
    }
}
