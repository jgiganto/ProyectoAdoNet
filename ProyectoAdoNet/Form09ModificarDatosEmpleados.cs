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
    public partial class Form09ModificarDatosEmpleados : Form
    {
        String cadenaconexion;
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader lector;
        List<int> codigoempleado;
        public Form09ModificarDatosEmpleados()
        {
            InitializeComponent();
            this.codigoempleado = new List<int>();
            this.cadenaconexion = @"Data Source=LOCALHOST\SQLTAJAMAR;Initial Catalog=HOSPITAL;User ID=SA";
            this.cn = new SqlConnection(this.cadenaconexion);
            this.cm = new SqlCommand();
            this.cm.Connection = this.cn;
            this.cm.CommandType = CommandType.Text;
            this.cm.CommandText = "SELECT APELLIDO,EMP_NO FROM EMP";
            this.cn.Open();
            this.lector = this.cm.ExecuteReader();
            while (this.lector.Read())
            {
                int codigo =
                    int.Parse(this.lector["EMP_NO"].ToString());
                String empleados = this.lector["APELLIDO"].ToString();
                this.codigoempleado.Add(codigo);
                this.lstempleados.Items.Add(empleados);
            }
            this.lector.Close();
            this.cn.Close();

        }

        private void Form09ModificarDatosEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void lstempleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lstempleados.SelectedIndex != -1)
            {
                this.txcomision.Clear();
                this.txoficio.Clear();
                this.txsalario.Clear();
                int codigoemp = this.codigoempleado[this.lstempleados.SelectedIndex];
                String sql = "SELECT EMP_NO,OFICIO,SALARIO,COMISION FROM EMP WHERE EMP_NO = @NOEMPLEADO";
                SqlParameter pamcodigo = new SqlParameter("@NOEMPLEADO", codigoemp);
                this.cm.Parameters.Add(pamcodigo);

                this.cm.CommandType = CommandType.Text;
                this.cm.CommandText = sql;
                this.cn.Open();
                this.lector = this.cm.ExecuteReader();
                while (this.lector.Read())
                {
                    String oficio = this.lector["OFICIO"].ToString();
                    this.txoficio.Text = oficio;
                    String salario = this.lector["SALARIO"].ToString();
                    this.txsalario.Text = salario;
                    String comision = this.lector["COMISION"].ToString();
                    this.txcomision.Text = comision;

                }
                this.lector.Close();                
                this.cm.Parameters.Clear();
                this.cn.Close();
            }
        }

        //private void CargarDatos()
        //{
        //    this.cm.Connection = this.cn;
        //    this.cm.CommandType = CommandType.Text;
        //    this.cm.CommandText = "SELECT APELLIDO,EMP_NO FROM EMP";
        //    this.cn.Open();
        //    this.lector = this.cm.ExecuteReader();
        //    while (this.lector.Read())
        //    {
        //        int codigo =
        //            int.Parse(this.lector["EMP_NO"].ToString());
        //        String empleados = this.lector["APELLIDO"].ToString();
        //        this.codigoempleado.Add(codigo);
        //        this.lstempleados.Items.Add(empleados);
        //    }
        //    this.lector.Close();
        //    this.cn.Close();
        //}

        private void btnmodificar_Click(object sender, EventArgs e)
        {
           
            if (this.lstempleados.SelectedIndex != -1)
            {                
                int codigoemp = this.codigoempleado[this.lstempleados.SelectedIndex];
                String noficio = this.txoficio.Text;
                //String nsalario = this.txsalario.Text;
                //String ncomision = this.txcomision.Text;
                int nsalario = int.Parse(this.txsalario.Text);
                int ncomision = int.Parse(this.txcomision.Text);
                //int codigo =
                // int.Parse(this.lector["HOSPITAL_COD"].ToString());

                String sql =
               "UPDATE EMP SET OFICIO = @OFICIO,SALARIO = @SALARIO,COMISION = @COMISION WHERE EMP_NO = @EMP_NO";
                SqlParameter pamcodigo = new SqlParameter("@EMP_NO", codigoemp);
                SqlParameter pamnoficio = new SqlParameter("@OFICIO", noficio);
                SqlParameter pamnsalario = new SqlParameter("@SALARIO", nsalario);
                SqlParameter pamncomision = new SqlParameter("@COMISION", ncomision);

                this.cm.Parameters.Add(pamcodigo);
                this.cm.Parameters.Add(pamnoficio);
                this.cm.Parameters.Add(pamnsalario);
                this.cm.Parameters.Add(pamncomision);

                this.cm.Connection = this.cn;
                this.cm.CommandType = CommandType.Text;
                this.cm.CommandText = sql;
                this.cn.Open();
                int afectados = this.cm.ExecuteNonQuery();

                


                this.cn.Close();
                //this.CargarDatos();

                this.lbinfo.Text =  "Registros Modificados: " + afectados;

            }
           


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
