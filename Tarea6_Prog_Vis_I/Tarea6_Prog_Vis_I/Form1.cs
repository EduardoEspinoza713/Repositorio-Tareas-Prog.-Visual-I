using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace Tarea6_Prog_Vis_I
{
    public partial class Form1 : Form
    {
        private List<int> listaOriginal;
        private List<int> listaBurbuja;
        private List<int> listaSS;
        private List<int> listaQuick;
        private List<int> listaMS;
        private List<List<int>> colaQuick = new List<List<int>>();
        private List<List<int>> colaMS = new List<List<int>>();
        private List<int> progresoQ = new List<int>();
        private List<int> progresoMS = new List<int>();
        private Thread hiloBurbuja;
        private Thread hiloMS;
        private Stopwatch relojBurbuja = new Stopwatch();
        private Stopwatch relojQuick = new Stopwatch();
        private Stopwatch relojMerge = new Stopwatch();
        private Stopwatch relojSelection = new Stopwatch();
        public bool QS, Burb, MS, SS;
        public int hB, hQ, hM, hS;
        int estB, estQ, estM, estS;
        private ManualResetEvent DC= new ManualResetEvent(true);
        private ManualResetEvent DC2 = new ManualResetEvent(true);
        public Form1()
        {
            InitializeComponent();
            QS = Burb = MS = SS = true;
            hB = hQ = hM = hS = 0;
            estB = estQ = estM = estS = 0;
        }
        public delegate void escribir(string aux, List<List<int>> lista, List<int> progreso, ref int est);
        private void Esc (string nombreArch, List<List<int>> numeros, List<int> Progreso, ref int est)
        {
            int cont = 0;
            int cp = 0;
            bool fin = false;
            while (true)
            {
                if ((cont<numeros.Count))
                {
                    Word.EscribirEnWord(nombreArch, numeros[cont], Progreso[cp]);
                    if(cp< Progreso.Count)
                    {
                        cp++;
                    }
                    cont++;
                    //MessageBox.Show($"{nombreArch} Cont {cont} Tot {numeros.Count}");
                    Console.WriteLine($"{nombreArch} Cont {cont} Tot {numeros.Count}");
                }
                if (est == 2)
                {
                    fin = true;
                }
                if (fin && (cont==numeros.Count))
                {
                    MessageBox.Show($"Documento {nombreArch}.doc guardado en el escritorio.");
                    break;
                }
            }
        }
        private void btnGraf_Click(object sender, EventArgs e)
        {
            if (Burb && QS && MS && SS)
            {
                charGraf.Visible = true;
                charGraf.Series.Clear();
                var serie = new System.Windows.Forms.DataVisualization.Charting.Series("Tiempos");
                serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                int tiempoBurbuja = (int)relojBurbuja.ElapsedMilliseconds;
                int tiempoQuick = (int)relojQuick.ElapsedMilliseconds;
                int tiempoMerge = (int)relojMerge.ElapsedMilliseconds;
                int tiempoSelection = (int)relojSelection.ElapsedMilliseconds;
                serie.Points.AddXY("Burbuja", tiempoBurbuja);
                serie.Points.AddXY("QuickSort", tiempoQuick);
                serie.Points.AddXY("MergeSort", tiempoMerge);
                serie.Points.AddXY("SelectionSort", tiempoSelection);
                serie.Points[0].Label = $"{tiempoBurbuja} ms";
                serie.Points[1].Label = $"{tiempoQuick} ms";
                serie.Points[2].Label = $"{tiempoMerge} ms";
                serie.Points[3].Label = $"{tiempoSelection} ms";
                charGraf.Series.Add(serie);
                charGraf.ChartAreas[0].AxisY.Title = "Tiempo (ms)";
                charGraf.ChartAreas[0].AxisX.Title = "Algoritmo";
            }
            else
            {
                MessageBox.Show("Espere que todos los algoritmos hayan terminado de ordenar.");
            }
        }

        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            Word.EliminarDocumentoDeWord("Quicksort");
            listaQuick = new List<int>(listaOriginal);
            btnQuicksortDC.Enabled = true;
            btnNum.Enabled = false;
            btnQuickSort.Enabled = false;
            QS = false;
            hQ = 1;
            listaQuick = new List<int>(listaOriginal);
            relojQuick.Restart();
            pbQuicksort.Value = 0;
            backgroundWorkerQuickSort.RunWorkerAsync();
            escribir escQ = new escribir(Esc);
            colaQuick.Add(new List<int>(listaQuick));
            progresoQ.Add(0);
            Thread hEscQ = new Thread(() => escQ("Quicksort", colaQuick, progresoQ, ref estQ));
            backgroundWorkerQuickSort.Aggsubhilo(hEscQ);
            (backgroundWorkerQuickSort.miSubhilo()).Start();
        }
        private void QuickSort(List<int> lista, int izquierda, int derecha, BackgroundWorker worker)
        {
            //DC.WaitOne();
            int ciclo=0;
            DC.WaitOne();
            if (izquierda < derecha)
            {
                int pivot = Particionar(lista, izquierda, derecha);
                QuickSort(lista, izquierda, pivot - 1, worker);
                QuickSort(lista, pivot + 1, derecha, worker);
            }
            if (lista.Count <1000) { 
                ciclo=(int)(lista.Count/10);
                if(ciclo==0) { ciclo=1; }
            }
            else
            {
                ciclo = 1000;
            }
            if (derecha % ciclo == 0) // reporte periódico
            {
                int progreso = (int)((derecha / (float)lista.Count) * 100);
                //worker.ReportProgress(Math.Min(progreso, 100));
                BeginInvoke(new Action(() =>
                {
                    worker.ReportProgress(Math.Min(progreso, 100));
                    if (progreso < 0)
                    {
                        pbQuicksort.Value = 0;
                    }
                    else
                    {
                        pbQuicksort.Value = Math.Min(progreso, 100);
                        progresoQ.Add(progreso);
                        colaQuick.Add(new List<int>(lista));
                    }
                    txtQS($"Quicksort: {progreso}%");
                }));
            }
        }
        public void txtQS(string aux)
        {
            lblQuicksort.Text = aux;
        }
        private int Particionar(List<int> lista, int izquierda, int derecha)
        {
            //DC.WaitOne();
            int pivote = lista[derecha];
            int i = izquierda - 1;
            for (int j = izquierda; j < derecha; j++)
            {
                if (lista[j] <= pivote)
                {
                    i++;
                    int temp = lista[i];
                    lista[i] = lista[j];
                    lista[j] = temp;
                }
            }
            int temp2 = lista[i + 1];
            lista[i + 1] = lista[derecha];
            lista[derecha] = temp2;
            return i + 1;
        }

        private void backgroundWorkerQuickSort_DoWork(object sender, DoWorkEventArgs e)
        {
            btnQuicksortDC.Enabled = true;
            QuickSort(listaQuick, 0, listaQuick.Count - 1, sender as BackgroundWorker);
            relojQuick.Stop();
            this.Invoke(new Action(() =>
            {
                hQ = 0;
                pbQuicksort.Value = 100;
                progresoQ.Add(100);
                colaQuick.Add(new List<int>(listaQuick));
                estQ = 2;
                lblQuicksort.Text = $"Comp. en {relojQuick.ElapsedMilliseconds}ms";
                //impOrd(listaQuick);
                btnQuicksortDC.Enabled = false;
                QS= true;
            }));
        }

        private void backgroundWorkerQuickSort_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Ordenado por quicksort, salida guardada en escritorio");
            
        }
        void impOrd(List<int> lista)
        {
            string aux = "";
            for (int i = 0; i < lista.Count; i++)
            {
                aux += $"{lista[i]}, ";
            }
            MessageBox.Show($"Lista ordenada:\n{aux}");
        }

        private void btnQuicksortDC_Click(object sender, EventArgs e)
        {
            backgroundWorkerQuickSort.WorkerSupportsCancellation = true;
            if (hQ == 1)
            {
                //backgroundWorkerQuickSort.;
                btnQuicksortDC.Text = "Continuar";
                hQ = 2;
                relojQuick.Stop();
                DC.Reset();
            }
            else
            {
                DC.Set();
                btnQuicksortDC.Text = "Detener";
                relojQuick.Start();
                hQ = 1;
            }
        }
        private void ordMerge_Sort()
        {
            if (listaMS == null || listaMS.Count <= 1)
            {
                return;
            }
            relojMerge.Start();
            int[] aux = new int[listaMS.Count];
            escribir escMS = new escribir(Esc);
            colaMS.Add(new List<int>(listaMS));
            progresoMS.Add(0);
            Thread hEscMS = new Thread(() => escMS("MergeSort", colaMS, progresoMS, ref estM));
            hiloMS.Aggsubhilo(hEscMS);
            (hiloMS.miSubhilo()).Start();
            MS2(listaMS, aux, 0, listaMS.Count - 1);
            relojMerge.Stop();
            this.Invoke(new Action(() =>
            {
                pbMergeSort.Value = 100;
                progresoMS.Add(100);
                colaMS.Add(new List<int>(listaMS));
                btnMergeSortDC.Enabled = false;
                hM = 0;
                btnGraf.Enabled = true;
                lblMergeSort.Text = $"Comp. en {relojMerge.ElapsedMilliseconds}ms";
                //impOrd(listaMS);
                estM = 2;
                MessageBox.Show("Ordenado por MergeSort, salida a ser guardada en escritorio");
                MS = true;
            }));
        }
        private void MS2 (List<int> lista, int[] aux, int ini, int fin)
        {
            
            if (ini >= fin)
            {
                return;
            }
            int medio = ini + (fin - ini) / 2;
            MS2(lista, aux, ini, medio);
            MS2(lista, aux, medio+1, fin);
            MS3(lista, aux,ini, medio, fin);
        }
        private void MS3(List<int> lista, int[] aux, int ini, int medio, int fin)
        {
            int indIzq = ini;
            int indDer = medio + 1;
            int indPrin = ini;
            int cont= 0;
            for (int i = ini; i <= fin; i++)
            {
                aux[i] = lista[i];
            }
            while (indIzq <= medio && indDer <= fin)
            {
                if (aux[indIzq] <= aux[indDer])
                {
                    lista[indPrin] = aux[indIzq];
                    indIzq++;
                }
                else
                {
                    lista[indPrin] = aux[indDer];
                    indDer++;
                }
                indPrin++;
                if(cont % 1000 == 0){
                        int progreso = (int)((indPrin / (float)lista.Count) * 100);
                        progresoMS.Add(progreso);
                        colaMS.Add(new List<int>(lista));
                        this.Invoke(new Action(() =>
                        {
                            pbMergeSort.Value = Math.Min(progreso, 100);
                            lblMergeSort.Text = $"MergeSort: {progreso}%";
                        }));
                }
                cont++;
            }
            while (indIzq <= medio)
            {
                lista[indPrin] = aux[indIzq];
                indPrin++;
                indIzq++;
                if (cont % 1000 == 0)
                {
                    int progreso = (int)((indPrin / (float)lista.Count) * 100);
                    progresoMS.Add(progreso);
                    colaMS.Add(new List<int>(lista));
                    this.Invoke(new Action(() =>
                    {
                        pbMergeSort.Value = Math.Min(progreso, 100);
                        lblMergeSort.Text = $"MergeSort: {progreso}%";
                    }));
                }
                cont++;
            }
        }
        private void btnTotalDC_Click(object sender, EventArgs e)
        {
            if(hB == 0 && hM == 0 && hQ == 0 && hS == 0)
            {
                MessageBox.Show("Ningún hilo está en ejecución.");
                if(listaOriginal== null)
                {
                    MessageBox.Show("Genere una lista de numeros aleatorios primero.");
                    return;
                }
                MessageBox.Show("Se iniciaran todos los hilos");
                if (btnBurbuja.Enabled == true)
                {
                    btnBurbuja_Click(sender, e);
                }
                if (btnQuickSort.Enabled == true)
                {
                    btnQuickSort_Click(sender, e);
                }
                if (btnMergeSort.Enabled == true)
                {
                    btnMergeSort_Click(sender, e);
                }
                if (btnSelectionSort.Enabled == true)
                {
                    btnSelectionSort_Click(sender, e);
                }
                return;
            }
            if (hB == 1)
            {
                hiloBurbuja.Suspend();
                relojBurbuja.Stop();
                btnBurbujaDC.Text = "Continuar";
                hB = 2;
            }
            else
            {
                if (hB == 2)
                {
                    hiloBurbuja.Resume();
                    relojBurbuja.Start();
                    btnBurbujaDC.Text = "Detener";
                    hB = 1;
                }
            }
            if (hQ==1)
            {
                DC.Reset();
                relojQuick.Stop();
                btnQuicksortDC.Text = "Continuar";
                hQ = 2;
            }
            else
            {
                if (hQ == 2)
                {
                    DC.Set();
                    relojQuick.Start();
                    btnQuicksortDC.Text = "Detener";
                    hQ = 1;
                }
            }
            if (hM == 1)
            {
                hiloMS.Suspend();
                relojMerge.Stop();
                btnMergeSortDC.Text = "Continuar";
                hM = 2;
            }
            else
            {
                if (hM == 2)
                {
                    hiloMS.Resume();
                    relojMerge.Start();
                    btnMergeSortDC.Text = "Detener";
                    hM = 1;
                }
            }
            if (hS == 1)
            {
                DC2.Reset();
                relojSelection.Stop();
                btnSelectionSortDC.Text = "Continuar";
                hS = 2;
            }
            else
            {
                if (hS == 2)
                {
                    DC2.Set();
                    relojSelection.Start();
                    btnSelectionSortDC.Text = "Detener";
                    hS = 1;
                }
            }
        }

        private void btnMergeSort_Click(object sender, EventArgs e)
        {
            btnNum.Enabled = false;
            btnMergeSortDC.Enabled = true;
            MS = false;
            btnMergeSort.Enabled = false;
            hM = 1;
            listaMS = new List<int>(listaOriginal);
            hiloMS = new Thread(new ThreadStart(ordMerge_Sort));
            relojMerge.Restart();
            hiloMS.Start();
        }

        private void btnMergeSortDC_Click(object sender, EventArgs e)
        {
            if(hM == 1)
            {
                hiloMS.Suspend();
                relojMerge.Stop();
                btnMergeSortDC.Text = "Continuar";
                hM = 2;
            }
            else
            {
                hiloMS.Resume();
                relojMerge.Start();
                btnMergeSortDC.Text = "Detener";
                hM = 1;
            }
        }
        private void OrdSelectionSort()
        {
            if (listaSS == null || listaSS.Count <= 1)
            {
                return;
            }
            List<List<int>> colaSS = new List<List<int>>();
            escribir escSS = new escribir(Esc);
            colaSS.Add(new List<int>(listaSS));
            estS = 0;
            List<int> progresoSS = new List<int>();
            progresoSS.Add(0);
            Thread hEscSS = new Thread(() => escSS("SelectionSort", colaSS, progresoSS, ref estS));
            backgroundWorkerSelectionSort.Aggsubhilo(hEscSS);
            (backgroundWorkerSelectionSort.miSubhilo()).Start();
            int n = listaSS.Count;
            for (int i = 0; i < n - 1; i++)
            {
                DC2.WaitOne();
                int indiceMinimo = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (listaSS[j] < listaSS[indiceMinimo])
                    {
                        indiceMinimo = j;
                    }
                }
                if (indiceMinimo != i)
                {
                    int temp = listaSS[i];
                    listaSS[i] = listaSS[indiceMinimo];
                    listaSS[indiceMinimo] = temp;
                }
                if (i % 1000 == 0)
                {
                    int progreso = (int)((i / (float)n) * 100);
                    progresoSS.Add(progreso);
                    this.Invoke(new Action(() =>
                    {
                        pbSelectionSort.Value = Math.Min(progreso, 100);
                        lblSelectionSort.Text = $"SelectionSort: {progreso}%";
                        colaSS.Add(new List<int>(listaSS));
                    }));
                }
            }
            this.Invoke(new Action(() =>
            {
                pbSelectionSort.Value = 100;
                progresoSS.Add(100);
                colaSS.Add(new List<int>(listaSS));
                btnSelectionSortDC.Enabled = false;
                hS = 0;
                btnGraf.Enabled = true;
                estS = 2;
                lblSelectionSort.Text = $"Comp. en {relojSelection.ElapsedMilliseconds}ms";
                //MessageBox.Show("Ordenado por SelectionSort, salida a ser guardada en escritorio");
                estS = 2;
            }));
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(hB!=0)
            {
                hiloBurbuja.DetCasc();
            }
            if(hM!=0)
            {
                hiloMS.DetCasc();
            }
            if(hQ!=0)
            {
                backgroundWorkerQuickSort.WorkerSupportsCancellation = true;
                backgroundWorkerQuickSort.DetCasc();
            }
            if(hS!=0)
            {
                backgroundWorkerQuickSort.WorkerSupportsCancellation = true;
                backgroundWorkerSelectionSort.DetCasc();
            }
        }

        private void btnSelectionSort_Click(object sender, EventArgs e)
        {
            btnSelectionSortDC.Enabled = true;
            btnSelectionSort.Enabled = false;
            btnNum.Enabled = false;
            SS = false;
            hS = 1;
            listaSS = new List<int>(listaOriginal);
            relojSelection.Restart();
            backgroundWorkerSelectionSort.RunWorkerAsync();
        }

        private void backgroundWorkerSelectionSort_DoWork(object sender, DoWorkEventArgs e)
        {
            OrdSelectionSort();
            relojSelection.Stop();
            this.Invoke(new Action(() =>
            {
                /*hS = 0;
                pbSelectionSort.Value = 100;
                lblSelectionSort.Text = $"Comp. en {relojSelection.ElapsedMilliseconds}ms";
                //impOrd(listaSS);
                btnSelectionSortDC.Enabled = false;*/
                MessageBox.Show("Ordenado por SelectionSort, salida a ser guardada en escritorio");
                SS= true;
            }));
        }

        private void btnSelectionSortDC_Click(object sender, EventArgs e)
        {
            if(hS == 1)
            {
                DC2.Reset();
                btnSelectionSortDC.Text = "Continuar";
                relojSelection.Stop();
                hS = 2;
            }
            else
            {
                DC2.Set();
                btnSelectionSortDC.Text = "Detener";
                relojSelection.Start();
                hS = 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Word.EliminarDocumentoDeWord("Burbuja");
            Word.EliminarDocumentoDeWord("Quicksort");
            Word.EliminarDocumentoDeWord("MergeSort");
            Word.EliminarDocumentoDeWord("SelectionSort");
        }

        private void btnBurbuja_Click(object sender, EventArgs e)
        {
            Word.EliminarDocumentoDeWord("Burbuja");
            listaBurbuja = new List<int>(listaOriginal);
            btnNum.Enabled = false;
            btnBurbujaDC.Enabled = true;
            Burb = false;
            btnBurbuja.Enabled = false;
            hB = 1;
            hiloBurbuja = new Thread(new ThreadStart(OrdenarBurbuja));
            relojBurbuja.Restart();
            hiloBurbuja.Start();
        }

        public List<int> Listado()
        {
            return listaOriginal;
        }

        private void btnBurbujaDC_Click(object sender, EventArgs e)
        {
            if (hB == 1)
            {
                hiloBurbuja.Suspend();
                relojBurbuja.Stop();
                btnBurbujaDC.Text = "Continuar";
                hB = 2;
            }
            else
            {
                hiloBurbuja.Resume();
                relojBurbuja.Start();
                btnBurbujaDC.Text = "Detener";
                hB = 1;
            }

        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            if((nudNumeros.Value > 0) == false )
            {
                MessageBox.Show("El número de elementos debe ser mayor a 0.");
                return;
            }
            Random rnd = new Random();
            listaOriginal = new List<int>();
            for (int i = 0; i < nudNumeros.Value; i++)
                listaOriginal.Add(rnd.Next(0, 1000000));

            MessageBox.Show($"Lista generada correctamente con {nudNumeros.Value} números.");
            //impOrd(listaOriginal);
            btnBurbuja.Enabled = true;
            btnQuickSort.Enabled = true;
            btnMergeSort.Enabled = true;
            btnSelectionSort.Enabled = true;
            btnGraf.Enabled = false;
            // Copiamos la lista para cada algoritmo
            listaBurbuja = new List<int>(listaOriginal);
            listaQuick = new List<int>(listaOriginal);
        }
        private void OrdenarBurbuja()
        {
            int est = 1;
            relojBurbuja.Restart();
            List<List<int>> colaBurb= new List<List<int>>();
            escribir escBurb = new escribir(Esc);
            colaBurb.Add(new List<int>(listaBurbuja));
            List<int>prog=new List<int>();
            prog.Add(0);
            Thread hEscBur= new Thread(() => escBurb("Burbuja", colaBurb, prog, ref est));
            hiloBurbuja.Aggsubhilo(hEscBur);
            hEscBur.Start();
            int n = listaBurbuja.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (listaBurbuja[j] > listaBurbuja[j + 1])
                    {
                        int temp = listaBurbuja[j];
                        listaBurbuja[j] = listaBurbuja[j + 1];
                        listaBurbuja[j + 1] = temp;
                    }
                }

                // Reportar progreso (cada 1000 iteraciones)
                if (i % 1000 == 0)
                {
                    int progreso = (int)((i / (float)n) * 100);
                    prog.Add(progreso);
                    this.Invoke(new Action(() =>
                    {
                        pbBurbuja.Value = Math.Min(progreso, 100);
                        lblBurbuja.Text = $"Burbuja: {progreso}%";
                        colaBurb.Add(new List<int>(listaBurbuja));
                    }));
                }
            }

            relojBurbuja.Stop();
            this.Invoke(new Action(() =>
            {
                pbBurbuja.Value = 100;
                prog.Add(100);
                btnBurbujaDC.Enabled = false;
                hB = 0;
                btnGraf.Enabled = true;
                lblBurbuja.Text = $"Comp. en {relojBurbuja.ElapsedMilliseconds}ms";
                colaBurb.Add(new List<int>(listaBurbuja));
                est = 2;
               // impOrd(listaBurbuja);
               // impOrd(colaBurb[colaBurb.Count - 1]);
            }));
            Burb = true;
            //impOrd(listaBurbuja);
            MessageBox.Show("Ordenado por burbuja, salida a ser guardada en escritorio");
        }
        private void nudNumeros_ValueChanged(object sender, EventArgs e)
        {
            if(nudNumeros.Value > 0)
            {
                btnNum.Enabled = true;
            }
            else
            {
                btnNum.Enabled = false;
            }
        }
    }
}
