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
    public partial class Form08EjercicioOficiosEmpleado : Form
    {
        String cadenaconexion;
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader lector;
        

        public Form08EjercicioOficiosEmpleado()
        {
            InitializeComponent();
            this.cadenaconexion = @"Data Source=LOCALHOST\SQLTAJAMAR;Initial Catalog=HOSPITAL;User ID=SA";
            this.conexion = new SqlConnection(this.cadenaconexion);
            this.comando = new SqlCommand();
            this.comando.Connection = this.conexion;
            this.comando.CommandType = CommandType.Text;
            this.comando.CommandText = "SELECT DISTINCT OFICIO FROM EMP ";
            this.conexion.Open();
            this.lector = this.comando.ExecuteReader();
            while (this.lector.Read())
            {
                String oficio = this.lector["OFICIO"].ToString();
                this.lstoficios.Items.Add(oficio);
            }
            this.lector.Close();
            this.conexion.Close();

        }

        private void Form08EjercicioOficiosEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void lstoficios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lstoficios.SelectedIndex != -1)
            {
                this.lstempleados.Items.Clear();
                String sql =
                    "SELECT APELLIDO FROM EMP WHERE OFICIO = @EMPLEADO";
                SqlParameter nombreparametro = new SqlParameter();
                nombreparametro.ParameterName = "@EMPLEADO";
                nombreparametro.Value = this.lstoficios.SelectedItem.ToString();
                //opcional
                nombreparametro.Direction = ParameterDirection.Input;
                nombreparametro.DbType = DbType.String;

                this.comando.Parameters.Add(nombreparametro);
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.conexion.Open();
                this.lector = this.comando.ExecuteReader();
                while (this.lector.Read())
                {
                    String apellido = this.lector["APELLIDO"].ToString();
                    this.lstempleados.Items.Add(apellido);
                }
                this.lector.Close();
                //los parametros son de "usar y tirar"
                //siempre hay que limpiar los parametros
                this.comando.Parameters.Clear();//borra esta linea para ver el error...
                this.conexion.Close();
            }
        }
    }
}
