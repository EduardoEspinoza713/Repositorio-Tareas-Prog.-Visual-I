using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4_Prog_Vis_I
{
    public static class Exp
    {
        public static void Ajustes(this PictureBox pb, int modo)
        {
            switch (modo)
            {
                case 1:
                    pb.SizeMode = PictureBoxSizeMode.Normal;
                    break;
                case 2:
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pb.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case 4:
                    pb.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case 5:
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                default:
                    pb.SizeMode = PictureBoxSizeMode.Normal;
                    break;
            }
        }
        public static Image Esc_grises(this Image aux)
        {
            Bitmap bmp = new Bitmap(aux.Width, aux.Height);
            for (int i = 0; i < aux.Width; i++)
            {
                for (int j = 0; j < aux.Height; j++)
                {
                    Color c = ((Bitmap)aux).GetPixel(i, j);
                    int a = (c.R + c.G + c.B) / 3;
                    bmp.SetPixel(i, j, Color.FromArgb(a, a, a));
                }
            }
            return ((Image)bmp);
        }
        public static void Esc_grises(this PictureBox aux)
        {
            aux.Image = aux.Image.Esc_grises();
        }
        public static void GirDer(this PictureBox img)
        {
            img.Image =img.Image.GirDer();
        }
        public static void GirIzq(this PictureBox img)
        {
            img.Image = img.Image.GirIzq();
        }
        public static Image GirIzq(this Image img)
        {
            Image aux = img;
            aux.RotateFlip(RotateFlipType.Rotate270FlipNone);
            img = aux;
            return (img);
        }
        public static Image GirDer(this Image img)
        {
            Image aux = img;
            aux.RotateFlip(RotateFlipType.Rotate90FlipNone);
            img = aux;
            return (img);
        }
    }
    public class Imagen
    {
        public Image img { get; set; }
        public string nombre { get; set; }
        public Image EscG { get; set; }
        public bool esEscG { get; set; }
        public Imagen(string nom, Image val)
        {
            img = val;
            nombre = nom;
            //EscG=img.Esc_grises();
            esEscG = false;
        }
        public void escGrises(Image val)
        {
            EscG = val;
            esEscG = true;
        }
    }
}