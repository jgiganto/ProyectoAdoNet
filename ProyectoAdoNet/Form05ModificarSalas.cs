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
    public partial class Form05ModificarSalas : Form
    {
        String cadenaconexion; //conexion,comando,lector. Siempre estos objetos
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader lector;
        public Form05ModificarSalas()
        {
            InitializeComponent();
            //instanciamos los objetos
            this.cadenaconexion = @"Data Source=DESKTOP-64C2FJI;Initial Catalog=HOSPITAL;Integrated Security=True";
            this.cn = new SqlConnection(this.cadenaconexion);
            this.com = new SqlCommand();
            this.CargarSalas();//llamamos a cargar salas. 
        }
        private void CargarSalas()//metodo cargar salas
        {
            //caracteristicas del comando para la consulta
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText =
                "SELECT DISTINCT NOMBRE FROM SALA";
            this.cn.Open();
            this.lector = this.com.ExecuteReader(); //al ser consulta select devuelve un lector
            //ya tenemos los datos; ahora hay que pintarlos
            this.lstlistarsalas.Items.Clear();
            while(this.lector.Read())
            {
                String nombre = this.lector["NOMBRE"].ToString();
                this.lstlistarsalas.Items.Add(nombre); //Se recupera el nombre y se añade a la lista
            }
            this.lector.Close();
            this.cn.Close();//cerramos lector y conexion
        }

        private void Form05ModificarSalas_Load(object sender, EventArgs e)
        {

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (this.lstlistarsalas.SelectedIndex != -1)
            {
                String nuevo = this.txtnuevonombre.Text;
                String antiguo = this.lstlistarsalas.SelectedItem.ToString();
                String sql = "UPDATE SALA SET NOMBRE = '"+nuevo+"' WHERE NOMBRE = '" +antiguo +"'";
                this.com.Connection = this.cn;
                this.com.CommandType = CommandType.Text;
                this.com.CommandText = sql;
                this.cn.Open();
                int afectados = this.com.ExecuteNonQuery();
                this.cn.Close();
                this.CargarSalas();
                this.lbmensaje.Text = "Modificados: " + afectados;
            }
        }

        private void lstlistarsalas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
