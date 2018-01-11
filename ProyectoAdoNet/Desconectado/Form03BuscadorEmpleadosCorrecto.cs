using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoAdoNet.Desconectado
{
    public partial class Form03BuscadorEmpleadosCorrecto : Form
    {
        String cadenaconexion;
        //tecnologia conectado
        SqlConnection cn;
        SqlCommand com;
        //tecnologia desconectado, un adaptador por cada tabla
        SqlDataAdapter ademp;
        DataSet ds;

        public Form03BuscadorEmpleadosCorrecto()
        {
            InitializeComponent();
            this.cadenaconexion = @"Data Source=DESKTOP-64C2FJI;Initial Catalog=HOSPITAL;Integrated Security=True";
            this.cn = new SqlConnection(this.cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.ds = new DataSet();
            this.ademp = new SqlDataAdapter();
            this.CargarEmpleados();

        }

        private void CargarEmpleados()
        {
            //CONFIGURO COMANDO
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = "SELECT * FROM EMP";
            //INDICAR AL ADAPTADOR LA CONSULTA Y CONEXION
            this.ademp.SelectCommand = this.com;
            //conectamos con la bbdd
            this.ademp.Fill(this.ds, "EMP");
            //BIBUJAMOS LOS EMPLEADOS EN LA LISTA
            foreach(DataRow f in this.ds.Tables["EMP"].Rows)
            {
                string apellido = f["APELLIDO"].ToString();
                string oficio = f["OFICIO"].ToString();
                this.lstempleados.Items.Add(apellido + " - " + oficio);
            }



        }

        private void Form03BuscadorEmpleadosCorrecto_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String oficiotexto = this.txtoficio.Text;
            SqlParameter pamofi = new SqlParameter("@OFICIO", oficiotexto);
            this.com.Parameters.Add(pamofi);
            String sql = "SELECT * FROM EMP WHERE OFICIO = @OFICIO";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.ademp.SelectCommand = com;
            //LA DIFERENCIA ES EN NUESTRO LECTOR (dataset)
            //DEBEMOS COMPROBAR SI YA EXISTEN DATOS PREVIOS PARA ELIMINARLOS ANTES(refrescar)
            if (this.ds.Tables.Contains("EMP"))
            {
                this.ds.Tables["EMP"].Rows.Clear();
            }
            this.ademp.Fill(this.ds, "EMP");
            //pintar
            this.lstempleados.Items.Clear();
            foreach(DataRow f in ds.Tables["EMP"].Rows)
            {
                String oficio = f["OFICIO"].ToString();
                String apellido = f["APELLIDO"].ToString();
                this.lstempleados.Items.Add(apellido + " - " + oficio);
            }
            this.com.Parameters.Clear();
        }
    }
}



/*  SqlParameter pamsuma = new SqlParameter("@SUMA",0);
               // pamsuma.ParameterName = "@SUMA";
                pamsuma.Direction = ParameterDirection.Output;
                this.com.Parameters.Add(pamsuma);*/
