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
    public partial class Form1 : Form
    {
        List<Estudiante> estudiantes = new List<Estudiante>();
        public bool f1, f2, f3, f4;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            f1 = f2 = f3 = f4 = false;
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            if(f3)
            {
                MessageBox.Show("La ventana ya está abierta");
                return;
            }
            Form3 form3 = new Form3();
            form3.MdiParent = this;
            f3 = true;
            form3.Show(this, estudiantes);
            //form3.mostrarDatos(estudiantes[0]);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado=MessageBox.Show("¿Está seguro que desea salir?","confirmar Cierre", MessageBoxButtons.OKCancel);
            if (resultado == DialogResult.Cancel)
            {
                e.Cancel = true;
                return;
            }
        }

        private void btnF4_Click(object sender, EventArgs e)
        {
            if (f4)
            {
                MessageBox.Show("La ventana ya está abierta");
                return;
            }
            if(estudiantes.Count == 0)
            {
                MessageBox.Show("No hay estudiantes registrados");
                return;
            }
            Form4 form4 = new Form4();
            form4.MdiParent = this;
            f4= true;
            form4.Show(this, DatosCompartidos.mejoresProm(estudiantes));
        }

        public void agregarEstudiante(Estudiante estudiante)
        {
            estudiantes.Add(estudiante);
        }
        public List<Estudiante> retEst()
        {
            return estudiantes;
        }
        private void btnForm2_Click(object sender, EventArgs e)
        {
            if(f2)
            {
                MessageBox.Show("La ventana ya está abierta");
                return;
            }
            Form2 form2 = new Form2();
            Form1 form = this;
            f2 = true;
            form2.MdiParent = form;
            form2.mostrar(ref form);
        }
    }
}
