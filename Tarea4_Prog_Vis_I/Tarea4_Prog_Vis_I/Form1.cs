using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4_Prog_Vis_I
{
    public partial class Form1 : Form
    {
        List<Imagen> imagenes = new List<Imagen>();
        int ind = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            imagenes.Add(new Imagen("Img1.jpg", Properties.Resources.Img1));
            imagenes.Add(new Imagen("Img2.jpg", Properties.Resources.Img2));
            imagenes.Add(new Imagen("Img3.jpg", Properties.Resources.Img3));
            imagenes.Add(new Imagen("Img4.jpg", Properties.Resources.Img4));
            imagenes.Add(new Imagen("Img5.jpg", Properties.Resources.Img5));
            imagenes.Add(new Imagen("Img6.jpg", Properties.Resources.Img6));
            imagenes.Add(new Imagen("Img7.jpg", Properties.Resources.Img7));
            imagenes.Add(new Imagen("Img8.jpg", Properties.Resources.Img8));
            imagenes.Add(new Imagen("Img9.jpg", Properties.Resources.Img9));
            imagenes.Add(new Imagen("Img10.jpg", Properties.Resources.Img10));
            for (int i = 0; i < imagenes.Count; i++)
            {
                cbImg.Items.Add(imagenes[i].nombre);
            }
            ind = 0;
            cbImg.SelectedIndex = ind;
            cbImg.Text = imagenes[ind].nombre;
            VisImg.Image = imagenes[ind].img;
            rbAju.Checked = true;
            checkNor.Checked = true;
            lblInfo.Text = $"Mostrando: {imagenes[ind].nombre}";
        }
        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAju.Checked)
            {
                VisImg.Ajustes(2);
                HerrImgAju.BackColor = SystemColors.ActiveCaption;
                HerrImgCen.BackColor = SystemColors.Control;
                HerrImgZoom.BackColor = SystemColors.Control;
            }
            if (rbCen.Checked)
            {
                VisImg.Ajustes(3);
                HerrImgCen.BackColor = SystemColors.ActiveCaption;
                HerrImgAju.BackColor = SystemColors.Control;
                HerrImgZoom.BackColor = SystemColors.Control;
            }
            if (rbZoom.Checked)
            {
                VisImg.Ajustes(5);
                HerrImgZoom.BackColor = SystemColors.ActiveCaption;
                HerrImgAju.BackColor = SystemColors.Control;
                HerrImgCen.BackColor = SystemColors.Control;
            }
        }

        private void checkNor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNor.Checked)
            {
                checkEscG.Checked = false;
                mostImg();
                HerrImgNor.BackColor = SystemColors.ActiveCaption;
                HerrImgEscG.BackColor = SystemColors.Control;
            }
            else
            {
                checkEscG.Checked = true;
            }
        }
        private void checkEscG_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEscG.Checked)
            {
                checkNor.Checked = false;
                //VisImg.Esc_grises();
                if(imagenes[ind].esEscG)
                {
                    VisImg.Image = imagenes[ind].EscG;
                }
                else
                {
                    VisImg.Esc_grises();
                    imagenes[ind].escGrises(VisImg.Image);
                }
                 lblInfo.Text += " (Escala de grises)";
                HerrImgEscG.BackColor = SystemColors.ActiveCaption;
                HerrImgNor.BackColor = SystemColors.Control;
            }
            else
            {
                checkNor.Checked = true;
            }
        }
        void mostImg()
        {
            VisImg.Image = imagenes[ind].img;
            lblInfo.Text = $"Mostrando: {imagenes[ind].nombre}";
            if (checkEscG.Checked)
            {
                checkEscG.Checked = false;
                checkEscG.Checked = true;
            }
            cbImg.SelectedIndex = ind;
            cbImg.Text = imagenes[ind].nombre;
        }
        private void btnImgIni_Click(object sender, EventArgs e)
        {
            ind = 0;
            mostImg();
        }

        private void btnImgUlt_Click(object sender, EventArgs e)
        {
            ind = imagenes.Count - 1;
            mostImg();
        }

        private void btnImgAvzr_Click(object sender, EventArgs e)
        {
            ind++;
            if (ind == imagenes.Count)
            {
                MessageBox.Show("Ha llegado al final");
                ind--;
                return;
            }
            mostImg();
        }

        private void btnImgRet_Click(object sender, EventArgs e)
        {
            ind--;
            if (ind == -1)
            {
                MessageBox.Show("Ha vuelto al comienzo");
                ind++;
                return;
            }
            mostImg();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El programa ha finalizado");
            Close();
        }

        private void cbImg_SelectedIndexChanged(object sender, EventArgs e)
        {
            ind= cbImg.SelectedIndex;
            mostImg();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Imagen JPG|*.jpg|Todos los Archivos|*.*";
            if (checkEscG.Checked)
            {
                guardar.FileName = "(Escala de Grises)";
            }
            else
            {
                guardar.FileName = "";
            }
                guardar.FileName += imagenes[ind].nombre;
            if (guardar.ShowDialog() == DialogResult.OK)
            {
                VisImg.Image.Save(guardar.FileName);
            }
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkNor.Checked = true;
        }

        private void escalaDeGrisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkEscG.Checked = true;
        }

        private void centradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rbCen.Checked = true;
        }

        private void ajustarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rbAju.Checked = true;
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rbZoom.Checked = true;
        }

        private void HerrImgNor_Click(object sender, EventArgs e)
        {
            normalToolStripMenuItem_Click(sender, e);
        }

        private void HerrImgEscG_Click(object sender, EventArgs e)
        {
            escalaDeGrisesToolStripMenuItem_Click(sender, e);
        }
        private void HerrCen_Click(object sender, EventArgs e)
        {
            centradaToolStripMenuItem_Click(sender, e);
        }

        private void HerrImgAju_Click(object sender, EventArgs e)
        {
            ajustarToolStripMenuItem_Click(sender, e);
        }

        private void HerrImgZoom_Click(object sender, EventArgs e)
        {
            zoomToolStripMenuItem_Click(sender, e);
        }

        private void girarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisImg.GirIzq();
        }

        private void girar90GradosALaDerechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisImg.GirDer();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(VisImg.Image);
            MessageBox.Show("Imagen copiada al portapapeles");
        }

        private void VisImg_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                conMen.Show(VisImg, e.Location);
            }
        }
    }
}