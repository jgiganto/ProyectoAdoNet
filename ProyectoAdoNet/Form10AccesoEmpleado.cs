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

namespace ProyectoAdoNet
{
    public partial class Form10AccesoEmpleado : Form
    {
        //CONEXION, COMANDO, LECTOR
        String cadenaconexion;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader lector;
        public Form10AccesoEmpleado()
        {
            InitializeComponent();
            this.cadenaconexion = @"Data Source=LOCALHOST\SQLTAJAMAR;Initial Catalog=HOSPITAL;User ID=SA";
            this.cn = new SqlConnection(this.cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;


        }

        private void Form10AccesoEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnacceder_Click(object sender, EventArgs e)
        {

            String sql = "SELECT APELLIDO, EMP_NO FROM EMP WHERE APELLIDO = '" + this.txapellido.Text + "' AND EMP_NO = '" + this.txnoempleado.Text + "' ";
            //SE PUEDE INYECTAR SQL SANCHEZ' --



            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.lector = this.com.ExecuteReader();
            if(this.lector.Read())
            {
                this.lbmensaje.Text = "Tiene acceso";
            }
            else
            {
                this.lbmensaje.Text = "No tiene acceso";
            }
            this.lector.Close();
            this.cn.Close();
        }
    }
}
