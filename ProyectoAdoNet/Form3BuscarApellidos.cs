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
    public partial class Form3BuscarApellidos : Form
    {
        String cadenaconexion;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader lector;




        public Form3BuscarApellidos()
        {
            InitializeComponent();
            this.cadenaconexion = @"Data Source=LOCALHOST\SQLTAJAMAR;Initial Catalog=HOSPITAL;User ID=SA";
            this.cn = new SqlConnection(this.cadenaconexion);
            this.com = new SqlCommand();
        }

        private void Form3BuscarApellidos_Load(object sender, EventArgs e)
        {

        }

        private void btnbuscarempleados_Click(object sender, EventArgs e)
        {
            String apellidos = this.txtapellidos.Text;
            String consulta = "select APELLIDO from emp where apellido like '"+apellidos+"%'";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = consulta;
            this.cn.Open();
            this.lstempleados.Items.Clear();
            this.lector = this.com.ExecuteReader();

            while(this.lector.Read())
            {
                String apellido = this.lector["APELLIDO"].ToString();
                this.lstempleados.Items.Add(apellido);
            }
            this.lector.Close();
            this.cn.Close();

        }
    }
}
