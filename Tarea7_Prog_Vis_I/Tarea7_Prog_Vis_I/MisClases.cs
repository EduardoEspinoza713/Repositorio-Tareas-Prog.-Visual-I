using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Tarea7_Prog_Vis_I
{
    public class datoUs
    {
        public string usuario;
        public string contra;
        public string nombre;
        public datoUs()
        {
            usuario = "";
            contra = "";
            nombre = "";
        }
        public datoUs(string u, string c)
        {
            usuario = u;
            contra = c;
        }
    }
    public static class exp
    {
        public static void limp(this TextBox ct)
        {
            ct.Text = "";
        }
    }
    class BD_SetGet
    {
        private static MySqlConnection conn;
        private static MySqlCommand comm;
        private static MySqlDataAdapter adapt;

        public BD_SetGet()
        {
            conn = null;
            comm = null;
            adapt = null;
        }

        public static bool EstablecerConexion(string cx)
        {
            try
            {
                conn = new MySqlConnection(cx);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK,
MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static DataTable EjecutarOrdenSelect(string orden)
        {
            DataTable table = new DataTable();
            try
            {
                conn.Open();
                comm = new MySqlCommand(orden, conn);
                adapt = new MySqlDataAdapter();
                adapt.SelectCommand = comm;
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapt.Fill(table);
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK,
MessageBoxIcon.Error);
            }
            return table;
        }

        public static int EjecutarOrden(string orden)
        {
            int n = 0;
            try
            {
                conn.Open();
                comm = new MySqlCommand(orden, conn);
                n = comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK,
MessageBoxIcon.Error);
            }
            return n;
        }

    }
}
