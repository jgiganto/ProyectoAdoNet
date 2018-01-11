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

#region PROCEDIMIENTOS ALMACENADOS

//CREATE PROCEDURE MOSTRARDEPARTAMENTOS
//AS

//    SELECT* FROM DEPT
//GO
//CREATE PROCEDURE BUSCARDEPARTAMENTO
//(@NUM INT)
//AS

//    SELECT* FROM DEPT
//   WHERE DEPT_NO = @NUM
//GO
//CREATE PROCEDURE INSERTARDEPARTAMENTO
//(@NUM INT, @NOM NVARCHAR(30), @LOC NVARCHAR(30))
//AS
//    INSERT INTO DEPT VALUES(@NUM, @NOM, @LOC)
//GO
//CREATE PROCEDURE MODIFICARDEPARTAMENTO
//(@NUM INT, @NOM NVARCHAR(30), @LOC NVARCHAR(30))
//AS
//    UPDATE DEPT SET DNOMBRE=@NOM, LOC=@LOC
//    WHERE DEPT_NO = @NUM
//GO
//CREATE PROCEDURE ELIMINARDEPARTAMENTO
//(@NUM INT)
//AS
//    DELETE FROM DEPT WHERE DEPT_NO = @NUM
//GO

#endregion

namespace ProyectoAdoNet
{
    public partial class Form12MensajesServidor : Form
    {
        String cadenaconexion;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader lector;
        List<int> codigosdept;
        
        public Form12MensajesServidor()
        {
            InitializeComponent();
            this.codigosdept = new List<int>();
            this.cadenaconexion = @"Data Source=LOCALHOST\SQLTAJAMAR;Initial Catalog=HOSPITAL;User ID=SA";
            this.cn = new SqlConnection(this.cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            //PARA CAPTURAR MENSAJES DEL SERVIDOR DE BBDD DEBEMOS CREAR UN 
            //EVENTO DELEGADO SOBRE CN CON EL EVENTO INFOMESSAGE += y tab
            this.cn.InfoMessage += Cn_InfoMessage;
            this.CargarDepartamentos();
        }

        private void Cn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            //solo entra si existe message
            this.lblmensaje.Text = e.Message;
        }

        private void CargarDepartamentos()
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "MOSTRARDEPARTAMENTOS";
            this.cn.Open();
            this.lector = this.com.ExecuteReader();
            this.lstdepartamentos.Items.Clear();
            this.codigosdept.Clear();
            while (this.lector.Read())
            {
                int num = int.Parse(this.lector["DEPT_NO"].ToString());
                String nom = this.lector["DNOMBRE"].ToString();
                String loc = this.lector["LOC"].ToString();
                this.codigosdept.Add(num);
                this.lstdepartamentos.Items.Add(nom + "-" + loc);
            }
            this.lector.Close();
            this.cn.Close();
        }

        private void lstdepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstdepartamentos.SelectedIndex != -1)
            {
                int num =
                  this.codigosdept[this.lstdepartamentos.SelectedIndex];
                SqlParameter pamnum =
                    new SqlParameter("@NUM", num);
                this.com.Parameters.Add(pamnum);
                this.com.CommandType = CommandType.StoredProcedure;
                this.com.CommandText = "BUSCARDEPARTAMENTO";
                this.cn.Open();
                this.lector = this.com.ExecuteReader();
                this.lector.Read();
                this.txtnumero.Text = this.lector["DEPT_NO"].ToString();
                this.txtnombre.Text = this.lector["DNOMBRE"].ToString();
                this.txtlocalidad.Text =
                    this.lector["LOC"].ToString();
                this.lector.Close();
                this.com.Parameters.Clear();
                this.cn.Close();
            }
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            this.lblmensaje.Text = "";
            int num = int.Parse(this.txtnumero.Text);
            String nom = this.txtnombre.Text;
            String loc = this.txtlocalidad.Text;
            SqlParameter pamnum = new SqlParameter("@NUM", num);
            SqlParameter pamnom = new SqlParameter("@NOM", nom);
            SqlParameter pamloc = new SqlParameter("@LOC", loc);
            this.com.Parameters.Add(pamnum);
            this.com.Parameters.Add(pamnom);
            this.com.Parameters.Add(pamloc);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "INSERTARDEPARTAMENTO2";
            this.cn.Open();
            this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            this.CargarDepartamentos();
            this.LimpiarCajas();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            int num =
                this.codigosdept[this.lstdepartamentos.SelectedIndex];
            String nom = this.txtnombre.Text;
            String loc = this.txtlocalidad.Text;
            SqlParameter pamnum = new SqlParameter("@NUM", num);
            SqlParameter pamnom = new SqlParameter("@NOM", nom);
            SqlParameter pamloc = new SqlParameter("@LOC", loc);
            this.com.Parameters.Add(pamnum);
            this.com.Parameters.Add(pamnom);
            this.com.Parameters.Add(pamloc);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "MODIFICARDEPARTAMENTO";
            this.cn.Open();
            this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            this.CargarDepartamentos();
            this.LimpiarCajas();
        }

        private void LimpiarCajas()
        {
            this.txtnumero.Clear();
            this.txtnombre.Clear();
            this.txtlocalidad.Clear();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int num =
                this.codigosdept[this.lstdepartamentos.SelectedIndex];
            SqlParameter pamnum = new SqlParameter("@NUM", num);
            this.com.Parameters.Add(pamnum);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "ELIMINARDEPARTAMENTO";
            this.cn.Open();
            this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            this.CargarDepartamentos();
            this.LimpiarCajas();
        }

        private void Form12MensajesServidor_Load(object sender, EventArgs e)
        {

        }
    }
}
