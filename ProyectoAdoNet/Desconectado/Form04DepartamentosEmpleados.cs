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
    public partial class Form04DepartamentosEmpleados : Form
    {
        String cadenaconexion;
        //usar en conectado
        SqlConnection cn;
        SqlCommand com;
        //usar en desconectado
        SqlDataAdapter adem;
        DataSet ds;
        public Form04DepartamentosEmpleados()
        {
            InitializeComponent();
            this.cadenaconexion = @"Data Source=LOCALHOST\SQLTAJAMAR;Initial Catalog=HOSPITAL;User ID=SA";
            this.cn = new SqlConnection(this.cadenaconexion);
            this.com = new SqlCommand();
            this.adem = new SqlDataAdapter();
            this.com.Connection = this.cn;
            this.ds = new DataSet();
            this.CargarDepartamentos();
        }
        private void CargarDepartamentos()
        { 
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = "SELECT * FROM DEPT";
            this.adem.SelectCommand = this.com;
            this.adem.Fill(this.ds, "DEPT");
            foreach(DataRow f in this.ds.Tables["DEPT"].Rows)
            {
                String departamento = f["DNOMBRE"].ToString();
                this.lstdepartamentos.Items.Add(departamento);
            }            
        }

        private void BuscarEmpleados(int deptno)
        {
            SqlParameter pamnum = new SqlParameter("@DEPTNO", deptno);
            this.com.Parameters.Add(pamnum);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = "SELECT * FROM EMP"
            + "WHERE DEPT_NO = @DEPTNO";
            if(this.ds.Tables.Contains("EMP"))
            {
                this.ds.Tables["EMP"].Rows.Clear();
            }
            this.adem.SelectCommand = this.com;
            this.adem.Fill(this.ds, "EMP");
            this.com.Parameters.Clear();
            this.txtempleados.Items.Clear();
            foreach(DataRow f in this.ds.Tables["EMP"].Rows)
            {
                this.txtempleados.Items.Add(f["APELLIDO"]);
                
            }

        }


        private void Form04DepartamentosEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void lstdepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstdepartamentos.SelectedIndex != -1)
            {
                //necesitamos el codigo del departamento; el indice del elemento seleccionado
                int indice = this.lstdepartamentos.SelectedIndex;
                DataRow filadept = this.ds.Tables["DEPT"].Rows[indice];
                int num = int.Parse(filadept["DEPT_NO"].ToString());
                string nombre = filadept["DNOMBRE"].ToString();
                string localidad = filadept["LOC"].ToString();
                this.txtnombre.Text = nombre;
                this.txtlocalidad.Text = localidad;
              // this.BuscarEmpleados(num);
            }
        }
    }
}
