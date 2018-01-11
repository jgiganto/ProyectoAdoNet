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
    public partial class Form4EliminarEnfermos : Form
    {
        String cadenaconexion;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader lector;
        public Form4EliminarEnfermos()
        {
            InitializeComponent();
            this.cadenaconexion = @"Data Source=LOCALHOST\SQLTAJAMAR;Initial Catalog=HOSPITAL;User ID=SA";
            this.cn = new SqlConnection(cadenaconexion);
            this.com = new SqlCommand();
            this.CargarEnfermos();
        }
        //metodo para cargar los datos de los enfermos
        public void CargarEnfermos()
        {
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = "SELECT INSCRIPCION, APELLIDO FROM ENFERMO";
            this.lstenfermos.Items.Clear();
            this.cn.Open();
            this.lector = this.com.ExecuteReader();
            while(this.lector.Read())
            {
                String ape = this.lector["APELLIDO"].ToString();
                String inscripccion =
                    this.lector["INSCRIPCION"].ToString();
                this.lstenfermos.Items.Add(inscripccion + " - " + ape);

            }
            this.lector.Close();
            this.cn.Close();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            String inscripcion = this.txtinscripcion.Text;
            String consulta = "DELETE FROM ENFERMO WHERE INSCRIPCION = " + inscripcion;
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = consulta;
            this.cn.Open();
            //las consultas de accion devuelven un int
            //con el numero de registros afectados
            int eliminados = this.com.ExecuteNonQuery();//insert update y delete
            this.cn.Close();
            this.lbmensaje.Text = "Eliminados" + eliminados.ToString();
            this.CargarEnfermos();
        }
    }
}
