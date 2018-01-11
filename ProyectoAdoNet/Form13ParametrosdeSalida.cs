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
/*
CREATE PROCEDURE CARGARHOSPITALES
AS
SELECT* FROM HOSPITAL
GO
----------------------------------------
CREATE PROCEDURE DATOSPLANTILLA
(@CODIGO INT)
AS
SELECT HOSPITAL.HOSPITAL_COD,HOSPITAL.NOMBRE,PLANTILLA.APELLIDO,PLANTILLA.HOSPITAL_COD
FROM HOSPITAL
INNER JOIN PLANTILLA
ON HOSPITAL.HOSPITAL_COD = PLANTILLA.HOSPITAL_COD
WHERE HOSPITAL.HOSPITAL_COD = @CODIGO
GO
---------------------------------------------
ALTER PROCEDURE DATOSPLANTILLA                            ---------MODIFICACION PARA SACAR SUMA,MEDIAPERSONAS
(@CODIGO INT,@SUMA INT OUT,@PERSONAS INT OUT,@MEDIA INT OUT)
AS
SELECT @SUMA = SUM(SALARIO),
@PERSONAS = COUNT(EMPLEADO_NO),
@MEDIA = AVG(SALARIO)
FROM PLANTILLA
SELECT * FROM PLANTILLA
WHERE HOSPITAL_COD = @CODIGO
GO


*/
#endregion

namespace ProyectoAdoNet
{
    public partial class Form13ParametrosdeSalida : Form
    {
        String cadenaconexion;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader lector;
        List<int> codigoshospital;


        public Form13ParametrosdeSalida()
        {
            InitializeComponent();
            this.codigoshospital = new List<int>();
            this.cadenaconexion = @"Data Source=LOCALHOST\SQLTAJAMAR;Initial Catalog=HOSPITAL;User ID=SA";
            this.cn = new SqlConnection(this.cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.CargarHospitales();
            this.cmhospitales.SelectedIndex = 0;// para cargar por defecto,en el combobox, el primer registro
        }

        private void CargarHospitales()
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "CARGARHOSPITALES";
            this.cn.Open();
            this.lector = this.com.ExecuteReader();
            this.cmhospitales.Items.Clear();
            this.codigoshospital.Clear();
            while(this.lector.Read())
            {
                this.codigoshospital.Add(int.Parse(this.lector["HOSPITAL_COD"].ToString()));
                this.cmhospitales.Items.Add(this.lector["NOMBRE"]);
            }
            this.lector.Close();
            this.cn.Close();

        }

        private void Form13ParametrosdeSalida_Load(object sender, EventArgs e)
        {

        }

        private void lstplantilla_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmhospitales_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(this.cmhospitales.SelectedIndex != -1)
            {
                this.lstplantilla.Items.Clear();
                int codigohospital =
                    this.codigoshospital[this.cmhospitales.SelectedIndex];
                SqlParameter pamcodigohospi = new SqlParameter("@CODIGO", codigohospital);
                this.com.Parameters.Add(pamcodigohospi);
                //CONFIGURAMOS LOS PARAMETROS DE SALIDA PARA LA APLICACION
                /*los parametros de salida, aunque no tengamos que enviar un valor, debemos
                 enviarlos al procedimiento con un valor por defecto*/
                SqlParameter pamsuma = new SqlParameter("@SUMA",0);
               // pamsuma.ParameterName = "@SUMA";
                pamsuma.Direction = ParameterDirection.Output;
                this.com.Parameters.Add(pamsuma);

                SqlParameter pampersonas = new SqlParameter("@PERSONAS",0);               
                pampersonas.Direction = ParameterDirection.Output; 
                this.com.Parameters.Add(pampersonas);

                SqlParameter pammedia = new SqlParameter("@MEDIA",0);

                pammedia.Direction = ParameterDirection.Output;
                this.com.Parameters.Add(pammedia);
                // END CONFIGURADOS LOS PARAMETROS DE SALIDA



                this.com.CommandType = CommandType.StoredProcedure;
                this.com.CommandText = "DATOSPLANTILLA";
                this.cn.Open();
                this.lector = this.com.ExecuteReader();
                while (this.lector.Read())
                {
                    this.lstplantilla.Items.Add(this.lector["APELLIDO"].ToString());
                }
                //DIBUJAMOS LOS PARAMETROS DE SALIDA EN LAS CAJAS
                //UNA VEZ QUE HEMOS EJECUTADO EL PROCEDIMIENTO                
                this.lector.Close();
                //solo podemos recuperar el valor de los parametros cuando hayamos cerrado el lector
                this.txsuma.Text = pamsuma.Value.ToString();
                this.txmedia.Text = pammedia.Value.ToString();
                this.txpersonas.Text = pampersonas.Value.ToString();
                this.com.Parameters.Clear();
                this.cn.Close();

            }
            
        }
    }
}
