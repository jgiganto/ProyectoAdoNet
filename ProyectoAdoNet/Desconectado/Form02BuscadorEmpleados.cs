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
    public partial class Form02BuscadorEmpleados : Form
    {
        String cadenaconexion;
        SqlDataAdapter ademp;
        DataSet ds;

        public Form02BuscadorEmpleados()
        {
            InitializeComponent();
            this.cadenaconexion = @"Data Source=LOCALHOST\SQLTAJAMAR;Initial Catalog=HOSPITAL;User ID=SA";
            this.ds = new DataSet();
         //   this.CargarEmpleados();

        }
        private void CargarEmpleados()
        {
            String sql = "SELECT * FROM EMP";
            this.ademp = new SqlDataAdapter(sql,this.cadenaconexion);
            this.ademp.Fill(this.ds, "EMP");//PUEDE SER OTRO NOMBRE
            //DEBEMOS RECORRER TODAS LAS FILAS DE LA TABLA PARA DIBUJARLAS SOBRE EL LISTBOX
            //this.ds.Tables["EMP"].Rows //se compone de DataRow. 
            foreach(DataRow fila in ds.Tables["EMP"].Rows)
            {
                String apellido = fila["APELLIDO"].ToString();
                String salario = fila["SALARIO"].ToString();
                this.lstempleados.Items.Add(apellido + " - " + salario);
            }
        }

        private void Form02BuscadorEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void btnfiltrardesc_Click(object sender, EventArgs e)
        {
            this.lstempleados.Items.Clear();
            //SELECT * FROM EMP WHERE SALARIO > 45222
            //EL OBJETO DATATABLE TIENE UN METODOS DE BUSQUEDA LLAMADO .select
            //que filtra y devuelve un array de objetos DataRow
            //Para el filtro utiliza toda la sintaxis despues del Where, excepto Between..
            String filtro = "SALARIO > " + this.txtsalario.Text;
            DataRow[] filas = this.ds.Tables["EMP"].Select(filtro);
            foreach(DataRow f in filas)
            {
                String apellido = f["APELLIDO"].ToString();
                String salario = f["SALARIO"].ToString();
                this.lstempleados.Items.Add(apellido + " - " + salario);
            }
        }

        private void btnfiltrarconectado_Click(object sender, EventArgs e)
        {
            String sql =
                "SELECT * FROM EMP WHERE SALARIO > " + txtsalario.Text;
            /*EL ADAPTADOR PARA EL METODO FILL(), UTILIZA UN OBJETO Command.
             PARA LAS CONSULTAS DE SELECCION UTILIZA UN COMANDO LLAMADO SelectCommand, 
             es decir SI QUEREMOS TRAER DATOS CON FILL, DEBEMOS CAMBIAR SelectCommand*/
            this.ademp = new SqlDataAdapter();
            this.ademp.SelectCommand = new SqlCommand();
            this.ademp.SelectCommand.Connection =
                new SqlConnection(this.cadenaconexion);
            SqlCommand com = new SqlCommand();

            this.ademp.SelectCommand.CommandText = sql;

            if (this.ds.Tables.Contains("EMP")==true)
            {
                this.ds.Tables["EMP"].Rows.Clear();
            }

        
            this.ds.Tables["EMP"].Rows.Clear();
            this.ademp.Fill(this.ds, "EMP");
            this.lstempleados.Items.Clear();
            foreach(DataRow f in this.ds.Tables["EMP"].Rows)
            {
                string apellido = f["APELLIDO"].ToString();
                string salario = f["SALARIO"].ToString();
                this.lstempleados.Items.Add(apellido + " - " + salario);
            }
        }
    }
}
