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

#region procedimientos almacenados

/*SQL
 CREATE PROCEDURE MOSTRARENFERMOS
AS
SELECT APELLIDO, INSCRIPCION FROM ENFERMO
GO
EXEC MOSTRARENFERMOS

CREATE PROCEDURE ELIMINARENFERMO
(@INSCRIPCION INT)
AS
 DELETE FROM ENFERMO
 WHERE INSCRIPCION = @INSCRIPCION
GO

EXEC ELIMINARENFERMO 14024
     */
#endregion //despliega

namespace ProyectoAdoNet
{
    public partial class Form11EliminarEnfermoProcedimientos : Form
    {
        String cadenaconexion;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader lector;
        List<int> inscripcciones;
        public Form11EliminarEnfermoProcedimientos()
        {
            InitializeComponent();
            this.inscripcciones = new List<int>();
            this.cadenaconexion = @"Data Source=LOCALHOST\SQLTAJAMAR;Initial Catalog=HOSPITAL;User ID=SA";
            this.cn = new SqlConnection(this.cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.CargarEnfermos();
        }

        private void CargarEnfermos()
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "MOSTRARENFERMOS";
            this.cn.Open();
            this.lector = this.com.ExecuteReader();
            this.inscripcciones.Clear();
            this.lsenfermos.Items.Clear();
            while(this.lector.Read())
            {
                String apellido = this.lector["APELLIDO"].ToString();
                int inscripccion =
                    int.Parse(this.lector["INSCRIPCION"].ToString());
                this.lsenfermos.Items.Add(apellido);
                this.inscripcciones.Add(inscripccion);
            }
            this.lector.Close();
            this.cn.Close();
        }

        private void Form11EliminarEnfermoProcedimientos_Load(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int inscripcion =
                this.inscripcciones[this.lsenfermos.SelectedIndex];
            SqlParameter pains =
                new SqlParameter("@INSCRIPCION", inscripcion);
            this.com.Parameters.Add(pains);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "ELIMINARENFERMO";
            this.cn.Open();
            this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            this.CargarEnfermos();
        }

        private void lsenfermos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


