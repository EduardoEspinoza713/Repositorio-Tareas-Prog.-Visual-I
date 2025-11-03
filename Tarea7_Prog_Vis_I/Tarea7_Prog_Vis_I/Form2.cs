using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea7_Prog_Vis_I
{
    public partial class Form2 : Form
    {
        bool fac, cat, cont;
        datoUs usr = null;
        public Form2()
        {
            InitializeComponent();
            fac=cat=cont=false;
        }
        public void datoUsr(datoUs dato)
        {
            usr= dato;
        }
        public datoUs retDato()
        {
            return usr;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 nForm = new Form1();
            nForm.padre = this;
            if (!nForm.mostrar())
            {
                this.Close();
                return;
            }
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void catalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!cat)
            {
                Form4 nForm = new Form4();
                nForm.MdiParent = this;
                nForm.Show();
            }
            else
            {
                MessageBox.Show("La ventana de catálogo ya está abierta.");
            }
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!cont)
            {
                Form5 nForm = new Form5();
                nForm.MdiParent = this;
                nForm.Show();
            }
            else
            {
                MessageBox.Show("La ventana de cambiar contraseña ya está abierta.");
            }
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form6().ShowDialog();
        }

        public void abierto(bool est, string sel)
        {
            switch (sel)
            {
                case "fac":
                    fac = est;
                    break;
                case "cat":
                    cat = est;
                    break;
                case "cont":
                    cont = est;
                    break;
            }
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!fac)
            {
                Form3 nForm = new Form3();
                nForm.MdiParent = this;
                nForm.Show();
            }
            else
            {
                MessageBox.Show("La ventana de facturas ya está abierta.");
            }

        }
    }
}
