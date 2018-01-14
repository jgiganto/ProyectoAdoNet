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
using ProyectoAdoNet.Desconectado;

namespace ProyectoAdoNet.Desconectado
{
    public partial class Form01PrimerDataSet : Form
    {
        String cadenaconexion;
        DataSet ds;
        
        public Form01PrimerDataSet()
        {
            InitializeComponent();
            this.cadenaconexion = @"Data Source=DESKTOP-64C2FJI;Initial Catalog=HOSPITAL;Integrated Security=True";
                this.ds = new DataSet();
        }

        private void btncargardepartamento_Click(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM DEPT";
            SqlDataAdapter addept = new SqlDataAdapter(sql, this.cadenaconexion);
            //NOS CONECTAMOS A LA BBDD Y EXTRAEMOS LOS DATOS
            //LOS DATOS SE DEBEN VOLCAR EN OBJETOS DATASET O DATATABLE(LOS REPOSITORIOS)
            //cada vez que hacemos un fill o crea una tabla o la rellena
            //en el momento de traer los datos, debemos indicar siempre un nombre de 
            //tabla donde deseamos volcar los registros
            addept.Fill(this.ds,"DEPT"); //DEPT U OTRO NOMBRE QUE QUIERA
            //pintamos los datos
            //.datasource es una propiedad de objetos windows forms o ASP .NET para dibujar datos
            //a partir de un origen de datos. 
            this.gridtabla.DataSource = this.ds.Tables["DEPT"];
            this.txtnumerodetablas.Text = this.ds.Tables.Count.ToString();


        }

        private void btnmostrardatosxml_Click(object sender, EventArgs e)
        {
            FormBloc f = new FormBloc();
            //los datos de un dataset van en formato xml
            f.txtdatos.Text = this.ds.GetXml();
            f.Show();
        }

        private void btnmostraresquemaxsd_Click(object sender, EventArgs e)
        {
            FormBloc f = new FormBloc();
            //la estructura de la tabla esta en formato Schema(xsd)
            f.txtdatos.Text = this.ds.GetXmlSchema();
            f.Show();
        }

        private void btncargarempleados_Click(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM EMP";
            SqlDataAdapter ademp = new SqlDataAdapter(sql, this.cadenaconexion);
            ademp.Fill(this.ds, "EMP");
            this.gridtabla.DataSource = this.ds.Tables["EMP"];
            this.txtnumerodetablas.Text = this.ds.Tables.Count.ToString();

        }

        private void Form01PrimerDataSet_Load(object sender, EventArgs e)
        {

        }
    }
}
