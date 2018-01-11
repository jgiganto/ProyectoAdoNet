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
    public partial class Form06PlantillaHospital : Form
    {
        String cadenadeconexion;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader lector;

        
        public Form06PlantillaHospital()
        {
            InitializeComponent();
            this.cadenadeconexion = @"Data Source=LOCALHOST\SQLTAJAMAR;Initial Catalog=HOSPITAL;User ID=SA";
            this.cn = new SqlConnection(this.cadenadeconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = "SELECT NOMBRE FROM HOSPITAL";
            this.cn.Open();
            this.lector = this.com.ExecuteReader();
            while(this.lector.Read())
            {
                String nombre = this.lector["NOMBRE"].ToString();
                this.lshospitales.Items.Add(nombre);
            }
            this.lector.Close();
            this.cn.Close();
        }

        private void Form06PlantillaHospital_Load(object sender, EventArgs e)
        {

        }

        private void lsplantilla_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lshospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lshospitales.SelectedIndex != -1)
            {
                this.lsplantilla.Items.Clear();
                String sql =
                    "SELECT PLANTILLA.APELLIDO FROM PLANTILLA"
                    + " INNER JOIN HOSPITAL"
                    + " ON PLANTILLA.HOSPITAL_COD = HOSPITAL.HOSPITAL_COD"
                    + " WHERE HOSPITAL.NOMBRE = @NOMBRE"; //@NOMBRE PRIMER PARAMETRO
                //DEBEMOS DECLARAR TANTOS PARAMETROS COMO HAYA EN LA CONSULTA(no pueden repetirse)
                SqlParameter pamnombre = new SqlParameter();
                pamnombre.ParameterName = "@NOMBRE";
                pamnombre.Value = this.lshospitales.SelectedItem.ToString();
                //estas opciones no son necesarias
                pamnombre.Direction = ParameterDirection.Input;
                pamnombre.DbType = DbType.String;
                //LOS PARAMETROS VAN INCLUIDOS DENTRO DEL COMANDO AL EJECUTAR SU CONSULTA .parameters
                //EN SU COLECCION PARAMETROS
                this.com.Parameters.Add(pamnombre);
                this.com.CommandType = CommandType.Text;
                this.com.CommandText = sql;
                this.cn.Open();
                this.lector = this.com.ExecuteReader();
                while (this.lector.Read())
                {
                    String apellido = this.lector["APELLIDO"].ToString();
                    this.lsplantilla.Items.Add(apellido);
                }
                this.lector.Close();
                //los parametros son de "usar y tirar"
                //siempre hay que limpiar los parametros
                this.com.Parameters.Clear();//borra esta linea para ver el error...
                this.cn.Close();

            }
        }

        private void Plantilla_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
