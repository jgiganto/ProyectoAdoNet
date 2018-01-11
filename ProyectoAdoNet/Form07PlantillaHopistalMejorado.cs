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
    public partial class Form07PlantillaHopistalMejorado : Form
    {
        String cadenadeconexion;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader lector;
        //coleccion para almacenar los codigos de los hospitales. (por si hay uno con nombre repetido )
        List<int> codigohospital;


        public Form07PlantillaHopistalMejorado()
        {
            InitializeComponent();
            this.codigohospital = new List<int>();
            this.cadenadeconexion = @"Data Source=LOCALHOST\SQLTAJAMAR;Initial Catalog=HOSPITAL;User ID=SA";
            this.cn = new SqlConnection(this.cadenadeconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = "SELECT NOMBRE, HOSPITAL_COD FROM HOSPITAL";
            this.cn.Open();
            this.lector = this.com.ExecuteReader();
            while (this.lector.Read())
            {
                String nombre = this.lector["NOMBRE"].ToString();
                int codigo =
                    int.Parse(this.lector["HOSPITAL_COD"].ToString());
                //ALMACENAMOS LOS CODIGOS DE LA COLECCION
                this.codigohospital.Add(codigo);
                this.lshospitales.Items.Add(nombre);
               
            }
            this.lector.Close();
            this.cn.Close();
        }

        private void Form07PlantillaHopistalMejorado_Load(object sender, EventArgs e)
        {

        }

        private void lshospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lshospitales.SelectedIndex != -1)
            {
                this.lsplantilla.Items.Clear();
                int codigo =
                    this.codigohospital[this.lshospitales.SelectedIndex];
                String sql = "SELECT APELLIDO FROM PLANTILLA WHERE HOSPITAL_COD = @CODIGO";
                SqlParameter pamcodigo =
                    new SqlParameter("@CODIGO", codigo);
                this.com.Parameters.Add(pamcodigo);

               
                
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

        private void lsplantilla_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
