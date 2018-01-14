using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

#region PROC ALMACENADOS
/*CREATE PROCEDURE DATOSDOCTORES
AS
SELECT * FROM DOCTOR 
GO

CREATE PROCEDURE BUSCARDOCTOR
(@DOCTORNO NVARCHAR(10) )
AS
SELECT * FROM DOCTOR 
WHERE DOCTOR_NO = @DOCTORNO
GO

CREATE PROCEDURE MODIFICARDOCTOR
(@DOCTORNO NVARCHAR(10),@HOSPITALCOD NVARCHAR(10) OUT, @APELLIDO NVARCHAR(20) OUT, @ESPECIALIDAD NVARCHAR(20) OUT,@SALARIO INT OUT)
AS
 UPDATE DOCTOR 
 SET HOSPITAL_COD = @HOSPITALCOD,
 APELLIDO = @APELLIDO,
 ESPECIALIDAD = @ESPECIALIDAD,
 SALARIO = @SALARIO
 WHERE DOCTOR_NO = @DOCTORNO
 SELECT * FROM DOCTOR    
GO*//*
PRUEBAS EJECUCION---------------------------
 EXEC MODIFICARDOCTOR 386,22,'Jackson M','Baile',2678000

/*HOSPITAL_COD
DOCTOR_NO
APELLIDO
ESPECIALIDAD
SALARIO
*/
     
#endregion

namespace ProyectoAdoNet.Desconectado.Modelos
{
    public class ModeloSqlDoctor
    {
        String cadenaconexion;
        SqlConnection cn;
        SqlCommand com;
        SqlDataAdapter addoc;
        DataSet ds;

        public ModeloSqlDoctor()
        {
            this.cadenaconexion = ConfigurationManager.ConnectionStrings["casa"].ConnectionString;
            this.cn = new SqlConnection(this.cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.ds = new DataSet();
            this.addoc = new SqlDataAdapter();                
        }

        //metodo devuelve la collecion de doctores
        public List<Doctor> GetDoctores()
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "DATOSDOCTORES";
            this.addoc.SelectCommand = this.com;

            //limpiamos laS FILAS DE la tabla
            if (this.ds.Tables.Contains("DOCTOR"))
            {
                this.ds.Tables["DOCTOR"].Rows.Clear();
            }
            this.addoc.Fill(this.ds, "DOCTOR");

            //COSTRUIMOS DATOS EN POO
            List<Doctor> listadoctores = new List<Doctor>();
            foreach(DataRow f in this.ds.Tables["DOCTOR"].Rows)
            {
                Doctor d = new Doctor();
                d.Apellido = f["APELLIDO"].ToString();
                d.DoctorNo = f["DOCTOR_NO"].ToString();
                d.Especialidad = f["ESPECIALIDAD"].ToString();
                d.Salario = int.Parse(f["SALARIO"].ToString());
                d.HospitalCod = f["HOSPITAL_COD"].ToString();
                listadoctores.Add(d);
            }
            return listadoctores;
        }
        //metodo BUSCAR DOCTOR POR DOCTORNO devuelve doctor
        public Doctor BuscarDoctor(String doctorcod)
        {
            SqlParameter pamdocno = new SqlParameter("@DOCTORNO", doctorcod);
            this.com.Parameters.Add(pamdocno);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "BUSCARDOCTOR";
            this.addoc.SelectCommand = this.com;
            //limpiar
            if(this.ds.Tables.Contains("DOCTOR"))
            {
                this.ds.Tables["DOCTOR"].Rows.Clear();
            }

            this.addoc.Fill(this.ds, "DOCTOR");
            this.com.Parameters.Clear();
            DataRow fila = this.ds.Tables["DOCTOR"].Rows[0];
            Doctor doctor = new Doctor();
            doctor.Apellido = fila["APELLIDO"].ToString();
            doctor.DoctorNo = fila["DOCTOR_NO"].ToString();
            doctor.Especialidad = fila["ESPECIALIDAD"].ToString();
            doctor.HospitalCod = fila["HOSPITAL_COD"].ToString();
            doctor.Salario = int.Parse(fila["SALARIO"].ToString());
            return doctor;
        }

        //metodo para modificar doctores


    }
}

/*HOSPITAL_COD
DOCTOR_NO
APELLIDO
ESPECIALIDAD
SALARIO
*/
