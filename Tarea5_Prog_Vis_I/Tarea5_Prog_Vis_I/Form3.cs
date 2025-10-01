using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea5_Prog_Vis_I
{
    public partial class Form3 : Form
    {
        Form1 form;
        List<Estudiante> estudiantes;
        public Form3()
        {
            InitializeComponent();
        }
        public void mostrarDatos(Estudiante estudiante)
        {
            //lblMostCarnet.Text = "Carnet: " + estudiante.Carnet;
            lblMostNombre.Text = "Nombre: " + estudiante.Nombre;
            dgvDatosF3.Rows.Clear();
            dgvDatosF3.DataSource = estudiante.Asignaturas;
            /*foreach (var asignatura in estudiante.Asignaturas)
            {
                dgvDatosF3.Rows.Add(asignatura.Nombre, asignatura.Nota);
            }*/
        }
        public void Show(Form1 form1, List<Estudiante> est)
        {
            this.Show();
            form = form1;
            estudiantes = est;
            if(estudiantes.Count == 0)
            {
                form.f3 = false;
                MessageBox.Show("No hay estudiantes registrados");
                this.Close();
            }
        }
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.f3 = false;
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            lblMostNombre.Text = "Nombre: ";
            dgvDatosF3.DataSource = null;
            dgvDatosF3.Rows.Clear();
            txtBus.Text = String.Empty;
        }

        private void txtBus_TextChanged(object sender, EventArgs e)
        {
            if(txtBus.Text == String.Empty)
            {
                btnBuscar.Enabled = false;
            }
            else
            {
                btnBuscar.Enabled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int ind= DatosCompartidos.existe(estudiantes, txtBus.Text);
            if (ind == -1)
            {
                MessageBox.Show("El carnet no existe");
                txtBus.Text = String.Empty;
                return;
            }
            MessageBox.Show("Estudiante encontrado");
            mostrarDatos(estudiantes[ind]);
        }
    }
}