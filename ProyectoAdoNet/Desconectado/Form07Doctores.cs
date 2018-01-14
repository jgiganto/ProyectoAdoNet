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

namespace ProyectoAdoNet
{
    public partial class Form07Doctores : Form
    {
        ModeloSqlDoctor modelo;
        public Form07Doctores()
        {
            InitializeComponent();
            this.modelo = new ModeloSqlDoctor();
            this.CargarDoctores();
        }
        public void CargarDoctores()
        {
            List<Doctor> lista = this.modelo.GetDoctores();
            foreach(Doctor d in lista)
            {
                ListViewItem it = new ListViewItem();
                it.Text = d.Apellido;
                it.Tag = d.DoctorNo;
                it.SubItems.Add(d.Especialidad);
                this.lsvdoctores.Items.Add(it);
            }

        }

        private void Form07Doctores_Load(object sender, EventArgs e)
        {

        }

        private void lsvdoctores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lsvdoctores.SelectedItems.Count != 0)
            {
                ListViewItem seleccionado =
                    this.lsvdoctores.SelectedItems[0];
                String codigo =
                    seleccionado.Tag.ToString();
                Doctor doctor = modelo.BuscarDoctor(codigo);
                this.txtapellido.Text = doctor.Apellido;
                this.txtespecialidad.Text = doctor.Especialidad;
                this.txtsalario.Text = doctor.Salario.ToString();
                this.txthospital.Text = doctor.HospitalCod;
            }
        }
    }
}
