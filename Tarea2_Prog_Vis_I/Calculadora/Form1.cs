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
        string simb = String.Empty, auxDec=String.Empty, memoria=String.Empty;
        bool op = false, igual = false;
        public Form1()
        {
            InitializeComponent();

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
        bool opComb(string aux)
        {
            if (aux != simb)
            {
                num2=double.Parse(pantalla.Text);
                switch (simb)
                {
                    case "+":
                        num1 += num2;
                        break;
                    case "-": 
                        num1 -= num2;
                        break ;
                    case "*":
                        num1*=num2;
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            num1/=num2;
                        }
                        else
                        {
                            MessageBox.Show("No puede dividir por cero");
                            num1=num2 = 0;
                            op = false;
                            igual = false;
                            pantalla.Text = "0";
                        }
                        break;
                }
                return (true);
            }
            return false;
        }
        void inhEsp(bool auxi)
        {
            btAbs.Enabled = auxi;
            btlog.Enabled = auxi;
            btRaiz.Enabled = auxi;
            btExpo.Enabled = auxi;
            btPorc.Enabled = auxi;
            btCuadrado.Enabled = auxi;
            btBin.Enabled = auxi;
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
                    inhEsp(false);
                    if(op==false)
                    {
                       num1=double.Parse(pantalla.Text);
                        op = true;
                        limpiar();
                    }
                    else
                    {
                        if (opComb(t))
                        {
                            num2 = 0;
                        }
                        else
                        {
                            num2 = double.Parse(pantalla.Text);
                        }
                        num1=num1 + num2;
                        pantalla.Text = num1.ToString();
                        limpiar();
                    }
                    simb = t;
                break;
                case "-":
                    inhEsp(false);
                    if (pantalla.Text == "0")
                    {
                        pantalla.Text = "-";
                        btAbs.Enabled = true;
                        return;
                    }
                    if (op == false)
                    {
                        num1 = double.Parse(pantalla.Text);
                        op = true;
                        limpiar();
                    }
                    else
                    {
                        if (opComb(t))
                        {
                            num2 = 0;
                        }
                        else
                        {
                            num2 = double.Parse(pantalla.Text);
                        }
                        num1 = num1 - num2;
                        pantalla.Text = num1.ToString();
                        limpiar();
                    }
                    simb = t;
                    break;
                case "*":
                    inhEsp(false);
                    if (op == false)
                    {
                        num1 = double.Parse(pantalla.Text);
                        op = true;
                        limpiar();
                    }
                    else
                    {
                        if (opComb(t))
                        {
                            num2 = 1;
                        }
                        else
                        {
                            num2 = double.Parse(pantalla.Text);
                        }
                        num1 = num1 * num2;
                        pantalla.Text = num1.ToString();
                        limpiar();
                    }
                    simb = t;
                    break;
                case "/":
                    inhEsp(false);
                    if (op == false)
                    {
                        num1 = double.Parse(pantalla.Text);
                        op = true;
                        limpiar();
                    }
                    else
                    {
                        if (opComb(t))
                        {
                            num2 = 1;
                        }
                        else
                        {
                            num2 = double.Parse(pantalla.Text);
                        }
                        if (num2 != 0)
                        {
                            num1 = num1 / num2;
                            pantalla.Text = num1.ToString();
                            limpiar();
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
                case "p":
                    num2=double.Parse(pantalla.Text);
                    num1 = Math.Pow(num1, num2);
                    break;
                case "%":
                    num2 = double.Parse(pantalla.Text);
                    num1 = (num1 / 100) * num2;
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
            inhEsp(true);
        }

        private void btBA_Click(object sender, EventArgs e)
        {

            if (pantalla.Text.Length == 1)
            {
                pantalla.Text = "0";
                num1 = num2 = 0;
                op = false;
                inhEsp(true);
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
            inhEsp(true);
            if( simb == String.Empty){
                return;
            }
            num2 = double.Parse(pantalla.Text);
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
           /* auxDec = pantalla.Text + ",";
            tecleo(".");
            pantalla.Text = auxDec;*/
           pantalla.Text=pantalla.Text + ".";
            btBin.Enabled = false;
        }

        private void btRes_Click(object sender, EventArgs e)
        {
            tecleo("-");
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            tecleo("/");
        }

        private void btMmas_Click(object sender, EventArgs e)
        {
            double auxi;
            if (memoria == String.Empty)
            {
                memoria = pantalla.Text;
                btMC.Enabled = true;
                btMR.Enabled = true;
                btMmenos.Enabled = true;
            }
            else
            {
                auxi=double.Parse(memoria);
                auxi += double.Parse(pantalla.Text);
                memoria = "" + auxi;
            }
        }

        private void btMmenos_Click(object sender, EventArgs e)
        {
            double auxi=double.Parse(memoria);
            auxi-=double.Parse(pantalla.Text);
            memoria = "" + auxi;
        }

        private void btMC_Click(object sender, EventArgs e)
        {
            memoria = String.Empty;
            btMmenos.Enabled = false;
            btMC.Enabled = false;
            btMR.Enabled=false;
        }

        private void btMR_Click(object sender, EventArgs e)
        {
            pantalla.Text = memoria;
            op = false;
            igual=false;
        }

        private void btAbs_Click(object sender, EventArgs e)
        {
            double auxi = double.Parse(pantalla.Text);
            if (auxi < 0)
            {
                auxi *= -1;
                pantalla.Text = "" + auxi;
            }
        }

        private void btBin_Click(object sender, EventArgs e)
        {
            StringBuilder res = new StringBuilder();
            int auxi;
            if(int.TryParse(pantalla.Text, out auxi)){
                while (auxi > 0)
                {
                    int resto = auxi % 2;
                    res.Insert(0, resto);
                    auxi /= 2;
                }
                pantalla.Text=res.ToString();
                btBin.Enabled=false ;
                igual = true;
            }
            else
            {
                MessageBox.Show("ERROR en el formato el numero a convertir a binario debe ser un entero");
                op=false;
                igual = false;
                pantalla.Text = "0";
                return;
            }
            
        }

        private void btRaiz_Click(object sender, EventArgs e)
        {
            double auxi=double.Parse(pantalla.Text);
            auxi=Math.Sqrt(auxi);
            pantalla.Text = $"{auxi:N5}";
            igual = true;
        }
        void teclaOp(bool auxi)
        {
            btsum.Enabled = auxi;
            btRes.Enabled = auxi;
            btDiv.Enabled = auxi;
            btmult.Enabled = auxi;
        }
        private void btExpo_Click(object sender, EventArgs e)
        {
            teclaOp(false);
            inhEsp(false);
            num1=double.Parse(pantalla.Text);
            pantalla.Text = "0";
            simb = "p";
        }

        private void btlog_Click(object sender, EventArgs e)
        {
            double auxi=double.Parse(pantalla.Text);
            auxi = Math.Log(auxi, 10);
            pantalla.Text = $"{auxi:N5}";
            igual = true;
        }

        private void btCuadrado_Click(object sender, EventArgs e)
        {
            double auxi=double.Parse(pantalla.Text) ;
            auxi = Math.Pow(auxi, 2);
            pantalla.Text = $"{auxi:N5}";
        }

        private void btPorc_Click(object sender, EventArgs e)
        {
            teclaOp(false);
            inhEsp(false);
            num1 = double.Parse(pantalla.Text);
            pantalla.Text = "0";
            simb = "%";
        }

        private void btPi_Click(object sender, EventArgs e)
        {
            tecleo($"{Math.PI:N5}");
        }

        private void btmult_Click(object sender, EventArgs e)
        {
            tecleo("*");
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
