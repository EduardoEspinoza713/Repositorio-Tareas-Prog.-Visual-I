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
    public partial class Form2 : Form
    {
        public Estudiante estudiante { get; set; }
        Form1 form;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(DatosCompartidos.existe(form.retEst(), txtCarnet.Text)!=-1)
            {
                MessageBox.Show("El carnet ya existe, ingrese uno diferente");
                txtCarnet.Text = String.Empty;
                return;
            }
            if (dgvDatosF2.Rows.Count < 2)
            {
                MessageBox.Show("Debe ingresar al menos una asignatura");
                return;
            }
            if(dgvDatosF2.Rows[dgvDatosF2.Rows.Count - 2].Cells[0].Value == null || dgvDatosF2.Rows[dgvDatosF2.Rows.Count - 2].Cells[1].Value == null)
            {
                MessageBox.Show("Debe completar la última fila o eliminarla");
                return;
            }
            for(int i=0; i<dgvDatosF2.Rows.Count -1; i++)
            {
                if(double.Parse(dgvDatosF2.Rows[i].Cells[1].Value.ToString()) < 0 || double.Parse(dgvDatosF2.Rows[i].Cells[1].Value.ToString()) > 100)
                {
                    MessageBox.Show("Las notas deben estar entre 0 y 100");
                    return;
                }
            }
            if (txtCarnet.Text == String.Empty || txtNombre.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar el carnet y nombre del estudiante");
                return;
            }
           estudiante = new Estudiante
            {
                Carnet = txtCarnet.Text,
                Nombre = txtNombre.Text
            };
            foreach (DataGridViewRow fila in dgvDatosF2.Rows)
            {
                if (fila.Cells[0].Value != null && fila.Cells[1].Value != null)
                {
                    estudiante.Asignaturas.Add(new Asignatura(fila.Cells[0].Value.ToString(),Convert.ToDouble(fila.Cells[1].Value)));
                }
            }
            MessageBox.Show("Datos guardados correctamente");
            form.agregarEstudiante(estudiante);
            this.Close();
        }
        public void mostrar(ref Form1 form1)
        {
            this.Show();
            form = form1;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.f2 = false;
        }
    }
}
