using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//espacio de nombres al proveedor de BBDD
using System.Data.SqlClient;//sql server(nuestro proveedor)



namespace ProyectoAdoNet
{
    public partial class PrimerAdo : Form
    {
        String cadenaconexion; //no igualar aqui la cadena de conexion; hacerlo en el constructor
        //declaracion de objetos de bbdd
        //conexion de datos
        SqlConnection cn;
        //comando(ejecuta las consultas)
        SqlCommand com;
        //reader(lee registros)
        SqlDataReader lector;
    
        public PrimerAdo()
        {
            InitializeComponent();
            this.cadenaconexion = 
                @"Data Source=LOCALHOST\SQLTAJAMAR;Initial Catalog=HOSPITAL;User ID=SA";//cadena conexion con el @ al principio lo pilla como literal
            //todos los objetos se instancian, excepto el reader que solamente puede ser creado
            //a partir de un command
            //la cadena de conexion siempre se establece en la instancia de connection
            this.cn = new SqlConnection(this.cadenaconexion);
            this.com = new SqlCommand();
            /*vamos a recuperar el evento StateChanged para ver los diferentes estados de cn */
            this.cn.StateChange += Cn_StateChange;
        }

        private void Cn_StateChange(object sender, StateChangeEventArgs e)
        {
            this.lblmensaje.Text = "La conexion esta pasando de " + e.OriginalState.ToString() + " a "
                  + e.CurrentState.ToString();
        }

        private void PrimerAdo_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            //siempre debemos inscluir nuestro acceso a bbdd sobre bloques try-catch
            //en clase no lo hacemos para aprender las excepciones
            try
            {
                if (this.cn.State == ConnectionState.Closed)
                {
                    this.cn.Open();
                }
                this.lblmensaje.BackColor = Color.Bisque;

            }
            catch(SqlException ex)
            {
                this.lblmensaje.Text = "Error" + ex;
            }
            //this.lblmensaje.Text 
            /*toda conexion debe tener un connection
             para indicar donde conectarse la BBDD*/
            // this.cn.ConnectionString = this.cadenaconexion;     no hacerlo en los eventos  
            //debemos preguntar por el estado de la conexion antes de abrila
         
            
        }

        private void btndesconectar_Click(object sender, EventArgs e)
        {
            this.cn.Close();
            this.lblmensaje.BackColor = Color.Coral;
        }

        private void btnleerregistros_Click(object sender, EventArgs e)
        {
            //para poder realizar cualquier acción sobre los datos 
            //siempre debemos tener una conexion abierta (sota, caballo y rey...)
            //A un comando siempre debemos darle tres acciones
            //1. La conexion 
            this.com.Connection = this.cn;
            //2. Tipo de consulta (del sql server, en el sqlserver)
            this.com.CommandType = CommandType.Text;
            //3. La propia consulta
            this.com.CommandText = "SELECT * FROM EMP";
            //CUANDO EL COMANDO ESTA CONFIGURADO, EJECUTAMOS LA CONSULTA CON UNA CONEXION ABIERTA
            //SI ES UNA CONSULTA DE SELECCION SE UTILIZA ExecuteReader() que devuelve una objeto datareader (un lector)..
            this.lector = this.com.ExecuteReader();
            //ahora mismo ya tenemos el cursor dentro del lector
          
            //vamos a leer un dato de la primera columna
            //antes de leer un dato, debemos posicionarnos en una fila
            //cada vez que ejecutamos read, nos movemos un registro
            //LAS COLUMNAS SE LEEN CON UN FOR
            for(int i = 0;i<this.lector.FieldCount;i++)
            {
                String columna = this.lector.GetName(i);
                String tipo = this.lector.GetDataTypeName(i);
                this.lstcolumnas.Items.Add(columna);
                this.lsttipos.Items.Add(tipo);


            }
            //LA FORMA DE LEER FILAS ES MEDIANTE WHILE
            while (this.lector.Read())
            {
                //this.lector.Read();
                //String dato = lector.GetInt32(0).ToString();//error no hay datos = fila inaccesible; fijarse tb en el tipo de dato
                //La forma mas comun de recuperar datos es mediante metodos object y luego convertir su tipo especifico 
                // ya que no verifica el tipo de dato del servidor de la bbdd
                //String dato = lector.GetValue(4).ToString(); //4º colummna , fecha
                //Siempre es conveniente recuperar los datos por nombre de columna. ya que por indice, es una app inestable
                //ya que depende del orden de las columnas
                String dato = this.lector["APELLIDO"].ToString();

                this.lstapellidos.Items.Add(dato);
            }
            //Siempre al finalizar la lectura de datos
            //debemos cerrar el lector para liberar recursos
            this.lector.Close();

        }
    }
}
