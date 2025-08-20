using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double num1=0, num2=0;
        string simb;
        bool op = false, igual = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        bool borrIgual()
        {
            if(igual){
                igual=false;
                limpiar();
                return (true);
            }
            return (false);
        }
        void limpiar()
        {
           pantalla.Text = "0";
        }
        void tecleo (string t)
        {
            if (borrIgual())
            {
                return;
            }
            switch (t)
            {
                case "+":
                    if(op==false)
                    {
                       num1=double.Parse(pantalla.Text);
                        op = true;
                        limpiar();
                    }
                    else
                    {
                        num2= double.Parse(pantalla.Text);
                        num1=num1 + num2;
                        pantalla.Text = num1.ToString();
                    }
                    simb = t;
                break;
                case "-":
                    if (op == false)
                    {
                        num1 = double.Parse(pantalla.Text);
                        op = true;
                        limpiar();
                    }
                    else
                    {
                        num2 = double.Parse(pantalla.Text);
                        num1 = num1 - num2;
                        pantalla.Text = num1.ToString();
                    }
                    simb = t;
                    break;
                case "*":
                    if (op == false)
                    {
                        num1 = double.Parse(pantalla.Text);
                        op = true;
                        limpiar();
                    }
                    else
                    {
                        num2 = double.Parse(pantalla.Text);
                        num1 = num1 * num2;
                        pantalla.Text = num1.ToString();
                    }
                    simb = t;
                    break;
                case "/":
                    if (op == false)
                    {
                        num1 = double.Parse(pantalla.Text);
                        op = true;
                        limpiar();
                    }
                    else
                    {
                        num2 = double.Parse(pantalla.Text);
                        if(num2 != 0)
                        {
                            num1 = num1 / num2;
                            pantalla.Text = num1.ToString();
                        }
                        else
                        {
                            MessageBox.Show("No se puede dividir entre 0");
                            num1 = num2 = 0;
                            op = false;
                            limpiar();
                        }
                    }
                    simb= t;
                    break;
                default:
                    if (pantalla.Text != "0")
                    {
                        pantalla.Text += t;
                    }
                    else
                    {
                        pantalla.Text = t;
                    }
                break;
            }
        }
        private void btCE_Click(object sender, EventArgs e)
        {
            limpiar();
            num1 = num2 = 0;
            op = false;
        }

        private void btBA_Click(object sender, EventArgs e)
        {

            if (pantalla.Text.Length == 1)
            {
                pantalla.Text = "0";
                num1 = num2 = 0;
                op = false;
            }
            else
            {
                pantalla.Text = pantalla.Text.Substring(0, pantalla.Text.Length - 1);
            }
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            tecleo("1");
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            tecleo("2");
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            num2= double.Parse(pantalla.Text);
            tecleo(simb);
            simb=String.Empty;
            pantalla.Text = num1.ToString();
            num1 = num2 = 0;
            op = false;
            igual = true;
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            tecleo("4");
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            tecleo("5");
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            tecleo("6");
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            tecleo("7");
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            tecleo("8");
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            tecleo("9");
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            tecleo("0");
        }

        private void btdecimal_Click(object sender, EventArgs e)
        {
            tecleo(".");
        }

        private void btRes_Click(object sender, EventArgs e)
        {
            tecleo("-");
        }

        private void btsum_Click(object sender, EventArgs e)
        {
            tecleo("+");
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            tecleo("3");
        }
    }
}
