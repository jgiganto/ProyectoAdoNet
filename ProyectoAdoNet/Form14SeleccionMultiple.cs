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
#region proc almacenados
/*CREATE PROCEDURE MOSTRARSALA
(@CODSALA INT)
AS
SELECT * FROM SALA
WHERE SALA_COD = @CODSALA
GO
------------------------------------
alter PROCEDURE PLANTILLAPERSONASSUMA
(@CODSALA INT, @NPERSONAS INT OUT,@SUMASALARIO INT OUT)
as
SELECT * FROM PLANTILLA
WHERE SALA_COD = @CODSALA 
SELECT @NPERSONAS = COUNT(EMPLEADO_NO),
@SUMASALARIO = isnull (SUM(SALARIO),0) --si es nulo devuelve un 0 NUNCA DEBEMOS DEVOLVER NULL, COMO NORMA
FROM PLANTILLA
WHERE SALA_COD = @CODSALA 
go
     */
#endregion

namespace ProyectoAdoNet
{
 
    public partial class Form14SeleccionMultiple : Form
    {
        String cadenaconexion;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader lector;
        List<int> codigosalas;
      
        public Form14SeleccionMultiple()
        {
            InitializeComponent();
            this.codigosalas = new List<int>();
           
            this.cadenaconexion = @"Data Source=LOCALHOST\SQLTAJAMAR;Initial Catalog=HOSPITAL;User ID=SA";
            this.cn = new SqlConnection(this.cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
           // this.CargarSalas();
        }

        private void CargarSalas(int codigo)
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "MOSTRARSALA";
            this.cn.Open();
            this.lector = this.com.ExecuteReader();
            this.lssalas.Items.Clear();
            this.codigosalas.Clear();
            while (this.lector.Read())
            {
                this.codigosalas.Add(int.Parse(this.lector["SALA_COD"].ToString()));
                this.lssalas.Items.Add(this.lector["NOMBRE"].ToString());
            }
            this.lector.Close();
            this.cn.Close();

        }

        private void Form14SeleccionMultiple_Load(object sender, EventArgs e)
        {

        }

        private void lssalas_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lsplantilla.Items.Clear();
            this.txpersonas.Text = "0";
            this.txsumasalarial.Text = "0";
            //NOS INTERESAN LOS INDICES DE LOS ELEMENTOS SELECCIONADOS
            foreach (int seleccionado in this.lsplantilla.SelectedIndices)
            {
                int codigo = this.codigosalas[seleccionado];
                this.CargarSalas(codigo);
            }

            if (this.lssalas.SelectedIndex != -1)
            {
                this.lsplantilla.Items.Clear();
                int codsala = this.codigosalas[this.lssalas.SelectedIndex];
                SqlParameter pamcodigosala = new SqlParameter("@CODSALA", codsala);
                this.com.Parameters.Add(pamcodigosala);

                SqlParameter pampersonas = new SqlParameter("@NPERSONAS", 0);
                pampersonas.Direction = ParameterDirection.Output;
                this.com.Parameters.Add(pampersonas);


                SqlParameter pamsumasalario = new SqlParameter("@SUMASALARIO", 0);
                pamsumasalario.Direction = ParameterDirection.Output;
                this.com.Parameters.Add(pamsumasalario);

                this.com.CommandType = CommandType.StoredProcedure;
                this.com.CommandText = "PLANTILLAPERSONASSUMA";
                this.cn.Open();
                this.lector = this.com.ExecuteReader();
                while (this.lector.Read())
                {
                    this.lsplantilla.Items.Add(this.lector["APELLIDO"].ToString());
                }
                this.lector.Close();
                int suma = int.Parse(this.txsumasalarial.Text);
                int personas = int.Parse(this.txpersonas.Text);
                suma += int.Parse(pamsumasalario.Value.ToString());
                personas += int.Parse(pampersonas.Value.ToString());
                this.txsumasalarial.Text = suma.ToString();
                this.txpersonas.Text = txpersonas.ToString();
                this.com.Parameters.Clear();
                this.cn.Close();


                //SqlParameter pampersonas = new SqlParameter("@PERSONAS", 0);
                //pampersonas.Direction = ParameterDirection.Output;
                //this.com.Parameters.Add(pampersonas);
                //@CODSALA INT, @NPERSONAS INT OUT,@SUMASALARIO INT OUT


            }
        }
    }
}
