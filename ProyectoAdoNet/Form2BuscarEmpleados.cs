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
    public partial class Form2BuscarEmpleados : Form
    {
        //1 declaramos los objetos
        String cadenaconexion;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader lector;
        public Form2BuscarEmpleados()
        {
            InitializeComponent();
            //2 instanciar objetos
            this.cadenaconexion = @"Data Source=LOCALHOST\SQLTAJAMAR;Initial Catalog=HOSPITAL;User ID=SA";
            this.cn = new SqlConnection(this.cadenaconexion);
            this.com = new SqlCommand();

        }

        private void btnbuscarempleados_Click(object sender, EventArgs e)
        {
            string salario = this.txtsalario.Text;
            String consulta = "SELECT APELLIDO,SALARIO FROM EMP WHERE SALARIO >" + salario;
            //configuramos el commando
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text; //es porque la consulta esta en el codigo de C#
            this.com.CommandText = consulta;
            //abrimos la conexion
            this.cn.Open();
            this.lstempleados.Items.Clear();
            //ejecutamos el comando
            this.lector = this.com.ExecuteReader(); // siempre que falle el reader es culpa de la consulta.
            //leemos los registros
            while(this.lector.Read())
            {
                String apellido = this.lector["APELLIDO"].ToString();
                String sal = this.lector["SALARIO"].ToString();
                this.lstempleados.Items.Add(apellido + " - " + sal);
            }
            //liberamos recursos
            this.lector.Close();
            this.cn.Close();
            
        }
    }
}
