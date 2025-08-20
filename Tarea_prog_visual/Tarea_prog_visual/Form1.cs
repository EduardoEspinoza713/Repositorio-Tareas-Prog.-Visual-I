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

namespace Tarea_prog_visual
{
    public partial class Form1 : Form
    {
        static int c = 0;
        static int intentos=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            c++;
            cont.Text = "Contador: " + c;
        }

        private void btConvertir_Click(object sender, EventArgs e)
        {
            double celsius=0, fahrenheit=0;
            if (errorCam(ctGC.Text, ctGF.Text))
            {
                return;
            }
            if (ctGC.Text != String.Empty && ctGF.Text != String.Empty)
            {
                MessageBox.Show("ERROR ambos campos están llenos al mismo tiempo, se le dará prioridad a la Conversión Celsius a Fahrenheit");
                ctGF.Text = String.Empty;
            }
            if (ctGC.Text == String.Empty&&ctGF.Text!=String.Empty)
            {
                fahrenheit=double.Parse(ctGF.Text);
                celsius = (fahrenheit - 32) * 5 / 9;
                ctGC.Text = ""+ celsius;
                MessageBox.Show("Conversión a grados Celsius Exitosa");
            }
            else if(ctGC.Text != String.Empty && ctGF.Text == String.Empty)
            {
                celsius=double.Parse(ctGC.Text);
                fahrenheit = (celsius * 9 / 5) + 32;
                ctGF.Text = ""+fahrenheit;
                MessageBox.Show("Conversión a grados Fahrenheit Exitosa");
            }
        }

        private void limp_Click(object sender, EventArgs e)
        {
            ctGC.Text = String.Empty;
            ctGF.Text = String.Empty;
        }
        bool errorCam(string a, string b, Double c)
        {
            bool aux = false;
            if (a == String.Empty || b == String.Empty)
            {
                MessageBox.Show("ERROR no puede dejar ninguno de los campos vacios");
                aux = true;
            }
            if ((double.TryParse(a, out c) == false)&&a!=String.Empty)
            {
                peso.Text = String.Empty;
                MessageBox.Show("ERROR en el formato del campo Peso");
                aux = true;
            }
            if ((Double.TryParse(b, out c) == false)&&b!=String.Empty) 
            {
                estatura.Text = String.Empty;
                MessageBox.Show("ERROR en el formato del campo Estatura");
                aux = true;
            }
            return aux;
        }
        bool errorCam(String a, String b)
        {
            bool aux = false;
            double aux2 = 0;
            if (a == String.Empty && b == String.Empty)
            {
                MessageBox.Show("ERROR los campos están vacíos");
            }
            if ((double.TryParse(a, out aux2) == false) && a != String.Empty)
            {
                ctGC.Text = String.Empty;
                MessageBox.Show("ERROR en el formato del campo Grados Celsius");
                aux = true;
            }
            if ((Double.TryParse(b, out aux2) == false) && b != String.Empty)
            {
                ctGF.Text = String.Empty;
                MessageBox.Show("ERROR en el formato del campo Grados Fahrenheit");
                aux = true;
            }
            return aux;
        }
        private void calcIMC_Click(object sender, EventArgs e)
        {
            double res = 0;
            string aux = String.Empty ;
            if(errorCam(peso.Text, estatura.Text, 1.5))
            {
                return;
            }
            res = 0;
            res=double.Parse(peso.Text)/(double.Parse(estatura.Text)* double.Parse(estatura.Text));
            resIMC.Text = "Tu IMC es: " + res;
            if (res >= 40)
            {
                aux = "Obesidad tipo 3";
            }
            else
            {
                if (res >= 35)
                {
                    aux = "Obesidad tipo 2";
                }
                else if(res >= 30)
                {
                    aux = "Obesidad tipo 1";
                }
                else if( res >= 25)
                {
                    aux = "Sobrepeso";
                }
                else if(res>= 18.5)
                {
                    aux = "Normal";
                }
                else
                {
                    aux = "Mala nutrición";
                }
            }
                catIMC.Text = "Tu Categoría es: " + aux;
        }
        private void btReCont_Click(object sender, EventArgs e)
        {
            c = 0;
            cont.Text = "Contador: " + c;
        }
        private void limpIMC_Click(object sender, EventArgs e)
        {
            peso.Text= String.Empty;
            estatura.Text = String.Empty;
            resIMC.Text = "Tu IMC es: -";
            catIMC.Text = "Tu Categoría es: -";
        }

        private void registro_Click(object sender, EventArgs e)
        {

        }

        private void ctUsuario_TextChanged(object sender, EventArgs e)
        {
            if(ctUsuario.Text!= String.Empty)
            {
                ctClave.Enabled = true;
            }
            else
            {
                ctClave.Enabled = false;
            }
        }

        private void btSesion_Click(object sender, EventArgs e)
        {
            if (ctUsuario.Text == "admin" && ctClave.Text == "admin123")
            {
                intentos = 0;
                MessageBox.Show("El Usuario <<Admin>> ha iniciado sesión correctamente");
                MessageBox.Show("El programa ha finalizado correctamente");
                Close();
            }
            else if (intentos < 2)
            {
                intentos++;
                MessageBox.Show("ERROR en el nombre de usuario o contraseña le quedan " + (3 - intentos) + " intentos más");
                ctClave.Text = String.Empty;
                ctUsuario.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Ha Agotado todos sus intentos, el programa se cerrará");
                Close();
            }
        }

        private void ctClave_TextChanged(object sender, EventArgs e)
        {

            if (ctClave.Text != String.Empty)
            {
                btSesion.Enabled = true;
            }
            else
            {
                btSesion.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
