using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoAdoNet.Desconectado.Modelos
{
    public class ModeloSQLHospital
    {
        String cadenaconexion;
        SqlConnection cn;
        SqlCommand com;
        SqlDataAdapter adhosp;
        DataSet ds;
        public ModeloSQLHospital()
        {
            this.cadenaconexion = 
                ConfigurationManager.ConnectionStrings["tajamar"].ConnectionString;
            this.cn = new SqlConnection(this.cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.ds = new DataSet();
            this.adhosp = new SqlDataAdapter();

        }
        //METODO PARA DEVOLVER UN CONJUNTO DE HOSPITALES, COLECCION
        public List<Hospital> GetHospitales()
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "MOSTRARHOSPITALES";
            this.adhosp.SelectCommand = this.com;

            if (this.ds.Tables.Contains("HOSPITAL"))
            {
                this.ds.Tables["HOSPITAL"].Rows.Clear();
            }

            this.adhosp.Fill(this.ds, "HOSPITAL");

            //construimos los datos a POO
            List<Hospital> lista = new List<Hospital>();
            foreach(DataRow f in this.ds.Tables["HOSPITAL"].Rows)
            {
                Hospital h = new Hospital();
                h.HospitalCod = int.Parse(f["HOSPITAL_COD"].ToString());
                h.Nombre = f["NOMBRE"].ToString();
                h.Direccion = f["DIRECCION"].ToString();
                h.Telefono = f["TELEFONO"].ToString();
                h.Camas = int.Parse(f["NUM_CAMA"].ToString());
                lista.Add(h);
            }
            return lista;
        }
        //METODO PARA BUSCAR UN HOSPITAL POR SU CODIGO
        public Hospital BuscarHospital(int hospitalcod)
        {
            SqlParameter pamcod = new SqlParameter("@HOSPITALCOD", hospitalcod);
            this.com.Parameters.Add(pamcod);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "DATOSHOSPITAL";
            this.adhosp.SelectCommand = this.com;
            if (this.ds.Tables.Contains("HOSPITAL"))
            {
                this.ds.Tables["HOSPITAL"].Rows.Clear();

            }
            this.adhosp.Fill(this.ds, "HOSPITAL");
            this.com.Parameters.Clear();
            //CONVERTIMOS A OBJETOS POO
            DataRow fila = this.ds.Tables["HOSPITAL"].Rows[0];
            Hospital hospital = new Hospital();
            hospital.HospitalCod =
                int.Parse(fila["HOSPITAL_COD"].ToString());
            hospital.Nombre = fila["NOMBRE"].ToString();
            hospital.Direccion = fila["DIRECCION"].ToString();
            hospital.Telefono = fila["TELEFONO"].ToString();
            hospital.Camas = int.Parse(fila["NUM_CAMA"].ToString());
            return hospital;
        }
    }
}
