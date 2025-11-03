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
namespace Tarea7_Prog_Vis_I
{
    public partial class Form5 : Form
    {
        datoUs usr = null;
        private string cad_con = "server=localhost;user=root;password='1234';database='bd_login'";
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCam_Click(object sender, EventArgs e)
        {
            if(ctConAct.Text=="" || ctContN.Text=="" || ctContN2.Text=="")
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            if(ctConAct.Text != usr.contra)
            {
                MessageBox.Show("La contraseña actual es incorrecta.");
                ctConAct.limp();
                return;
            }
            if (ctContN.Text != ctContN2.Text)
            {
                MessageBox.Show("Las nuevas contraseñas no coinciden.");
                ctContN.limp();
                ctContN2.limp();
                return;
            }
            usr.contra = ctContN.Text;
            string sql= $"UPDATE tb_login SET clave='{usr.contra}' WHERE usuario='{usr.usuario}'";
            //MySqlConnection conn = new MySqlConnection(cad_con);
            BD_SetGet.EstablecerConexion(cad_con);
            BD_SetGet.EjecutarOrden(sql);
            MessageBox.Show("Contraseña cambiada exitosamente.");
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            usr= ((Form2)this.MdiParent).retDato();
        }

        private void ctContN2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
