using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
//using MySqlConnector;
using MySql;
using Org.BouncyCastle.Asn1;

namespace Tarea7_Prog_Vis_I
{
    public partial class Form1 : Form
    {
        int cont = 0;
        bool iniSes= false;
        public Form2 padre { get; set; }
        public Form1()
        {
            InitializeComponent();
        }
        public bool mostrar()
        {
            this.ShowDialog();
            return iniSes;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btIniSes_Click(object sender, EventArgs e)
        {
            cont++;
            if (LINQtoDataSet.ComprobarLogin(ctUs.Text, ctContra.Text))
            {
                MessageBox.Show("¡Inicio de sesión exitoso!");
                padre.datoUsr(new datoUs(ctUs.Text, ctContra.Text));
                cont = 0;
                this.Close();
                iniSes = true;
            }
            else
            {
                MessageBox.Show($"ERROR en el inicio de sesión, le resta {3 - cont} intentos");
                ctContra.limp();
                ctUs.limp();
            }
            if (cont == 3)
            {
                MessageBox.Show("Número máximo de intentos alcanzado. La aplicación se cerrará.");
                Application.Exit();
            }
        }

        private void btCreC_Click(object sender, EventArgs e)
        {

        }

        private void btCan_Click(object sender, EventArgs e)
        {
            ctContra.Text = "";
            ctNom.Text = "";
            ctUs.Text = "";
        }
    }
    public class LINQtoDataSet
    {
        //string cc = "server=localhost;user=root;passwor='1234';database='bd_login'";
        MySqlConnection conn = null;
        public static DataSet Llenar_DataSEt(string cad_con, string tabla)
        {
            DataSet ds = new DataSet();
            MySqlConnection conn = new MySqlConnection(cad_con);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM {tabla}", conn);
            ds.Tables.Add(tabla);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds, tabla);
            conn.Close();
            return ds;
        }
        public static bool ComprobarLogin(string usuario, string contra)
        {
            IEnumerable<DataRow> consulta = from datos in LINQtoDataSet.Llenar_DataSEt("server=localhost;user=root;password='1234';database='bd_login'", "tb_login").Tables["tb_login"].AsEnumerable()
                                 where datos.Field<string>("usuario") == usuario && datos.Field<string>("clave") == contra
                                 select datos;
            if (consulta.Count() > 0) { return true; }
            return false;
        }
    }
}
