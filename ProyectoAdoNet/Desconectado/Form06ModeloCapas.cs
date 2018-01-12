using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoAdoNet.Desconectado;
using ProyectoAdoNet.Desconectado.Modelos;

namespace ProyectoAdoNet.Desconectado
{
    public partial class Form06ModeloCapas : Form
    {
        ModeloSQLHospital modelo;
        public Form06ModeloCapas()
        {
            InitializeComponent();
            this.modelo = new ModeloSQLHospital();
            this.CargarHospitales();
        }

        private void CargarHospitales()
        {
            List<Hospital> lista = this.modelo.GetHospitales();
            foreach(Hospital h in lista)
            {
                ListViewItem it = new ListViewItem();
                it.Text = h.Nombre;
                it.Tag = h.HospitalCod;
                it.SubItems.Add(h.Direccion);
                this.lsvhospitales.Items.Add(it);
            }
        }
        private void Form06ModeloCapas_Load(object sender, EventArgs e)
        {

        }

        private void lsvhospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lsvhospitales.SelectedItems.Count != 0)
            {
                ListViewItem seleccionado =
                    this.lsvhospitales.SelectedItems[0];
                int codigo = int.Parse(seleccionado.Tag.ToString());
                Hospital hospital = modelo.BuscarHospital(codigo);
                this.txtnombre.Text = hospital.Nombre;
                this.txtdireccion.Text = hospital.Direccion;
                this.txttelefono.Text = hospital.Telefono;
                this.txtcamas.Text = hospital.Camas.ToString();
            }
        }
    }
}
