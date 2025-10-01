using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tarea5_Prog_Vis_I
{
    public partial class Form4 : Form
    {
        Form1 form;
        List<Promedios> promedios;
        public Form4()
        {
            InitializeComponent();
        }
        public void Show(Form1 form1, List<Promedios> prom)
        {
            this.Show();
            form = form1;
            promedios = prom;
            grafMjrsProm();
        }
        private void grafMjrsProm()
        {
            GraficoF4.Series.Clear();
            Series serie = new Series("Mejores Promedios");
            serie.ChartType = SeriesChartType.Column;
            serie.XValueType = ChartValueType.String;
            serie.YValueType = ChartValueType.Double;
            int max = Math.Min(3, promedios.Count);
            for (int i = 0; i < max; i++)
            {
                serie.Points.AddXY(promedios[i].estudiante.Nombre, promedios[i].prom);
            }
            GraficoF4.Series.Add(serie);
        }
        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.f4 = false;
        }
    }
}
