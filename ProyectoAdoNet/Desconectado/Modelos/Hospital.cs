using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAdoNet.Desconectado.Modelos
{
    public class Hospital
    {
        public int HospitalCod { get; set; }
        public String Nombre { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        public int Camas { get; set; }
    }
}
