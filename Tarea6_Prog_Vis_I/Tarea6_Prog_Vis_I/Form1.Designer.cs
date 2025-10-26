namespace Tarea6_Prog_Vis_I
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnNum = new System.Windows.Forms.Button();
            this.pbBurbuja = new System.Windows.Forms.ProgressBar();
            this.pbQuicksort = new System.Windows.Forms.ProgressBar();
            this.btnBurbuja = new System.Windows.Forms.Button();
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.charGraf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSelectionSort = new System.Windows.Forms.Button();
            this.btnMergeSort = new System.Windows.Forms.Button();
            this.pbSelectionSort = new System.Windows.Forms.ProgressBar();
            this.pbMergeSort = new System.Windows.Forms.ProgressBar();
            this.lblBurbuja = new System.Windows.Forms.Label();
            this.lblQuicksort = new System.Windows.Forms.Label();
            this.lblMergeSort = new System.Windows.Forms.Label();
            this.lblSelectionSort = new System.Windows.Forms.Label();
            this.nudNumeros = new System.Windows.Forms.NumericUpDown();
            this.btnBurbujaDC = new System.Windows.Forms.Button();
            this.btnQuicksortDC = new System.Windows.Forms.Button();
            this.btnMergeSortDC = new System.Windows.Forms.Button();
            this.btnSelectionSortDC = new System.Windows.Forms.Button();
            this.btnGraf = new System.Windows.Forms.Button();
            this.backgroundWorkerQuickSort = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerSelectionSort = new System.ComponentModel.BackgroundWorker();
            this.btnTotalDC = new System.Windows.Forms.Button();
            this.estdB = new System.Windows.Forms.Button();
            this.estdQ = new System.Windows.Forms.Button();
            this.estdM = new System.Windows.Forms.Button();
            this.estdS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.charGraf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNum
            // 
            this.btnNum.Enabled = false;
            this.btnNum.Location = new System.Drawing.Point(12, 12);
            this.btnNum.Name = "btnNum";
            this.btnNum.Size = new System.Drawing.Size(184, 57);
            this.btnNum.TabIndex = 0;
            this.btnNum.Text = "Generar # aleatorios";
            this.btnNum.UseVisualStyleBackColor = true;
            this.btnNum.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // pbBurbuja
            // 
            this.pbBurbuja.Location = new System.Drawing.Point(162, 102);
            this.pbBurbuja.Name = "pbBurbuja";
            this.pbBurbuja.Size = new System.Drawing.Size(425, 23);
            this.pbBurbuja.TabIndex = 3;
            // 
            // pbQuicksort
            // 
            this.pbQuicksort.Location = new System.Drawing.Point(162, 207);
            this.pbQuicksort.Name = "pbQuicksort";
            this.pbQuicksort.Size = new System.Drawing.Size(425, 23);
            this.pbQuicksort.TabIndex = 4;
            // 
            // btnBurbuja
            // 
            this.btnBurbuja.Enabled = false;
            this.btnBurbuja.Location = new System.Drawing.Point(225, 146);
            this.btnBurbuja.Name = "btnBurbuja";
            this.btnBurbuja.Size = new System.Drawing.Size(140, 46);
            this.btnBurbuja.TabIndex = 5;
            this.btnBurbuja.Text = "Ordenamiento Burbuja";
            this.btnBurbuja.UseVisualStyleBackColor = true;
            this.btnBurbuja.Click += new System.EventHandler(this.btnBurbuja_Click);
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.Enabled = false;
            this.btnQuickSort.Location = new System.Drawing.Point(225, 253);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(140, 46);
            this.btnQuickSort.TabIndex = 6;
            this.btnQuickSort.Text = "Ordenamiento Quicksort";
            this.btnQuickSort.UseVisualStyleBackColor = true;
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
            // 
            // charGraf
            // 
            chartArea1.Name = "ChartArea1";
            this.charGraf.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.charGraf.Legends.Add(legend1);
            this.charGraf.Location = new System.Drawing.Point(25, 601);
            this.charGraf.Name = "charGraf";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.charGraf.Series.Add(series1);
            this.charGraf.Size = new System.Drawing.Size(543, 300);
            this.charGraf.TabIndex = 7;
            this.charGraf.Text = "Tiempos de ejecución";
            this.charGraf.Visible = false;
            // 
            // btnSelectionSort
            // 
            this.btnSelectionSort.Enabled = false;
            this.btnSelectionSort.Location = new System.Drawing.Point(225, 472);
            this.btnSelectionSort.Name = "btnSelectionSort";
            this.btnSelectionSort.Size = new System.Drawing.Size(140, 46);
            this.btnSelectionSort.TabIndex = 11;
            this.btnSelectionSort.Text = "Ordenamiento SelectionSort";
            this.btnSelectionSort.UseVisualStyleBackColor = true;
            this.btnSelectionSort.Click += new System.EventHandler(this.btnSelectionSort_Click);
            // 
            // btnMergeSort
            // 
            this.btnMergeSort.Enabled = false;
            this.btnMergeSort.Location = new System.Drawing.Point(225, 365);
            this.btnMergeSort.Name = "btnMergeSort";
            this.btnMergeSort.Size = new System.Drawing.Size(140, 46);
            this.btnMergeSort.TabIndex = 10;
            this.btnMergeSort.Text = "Ordenamiento MergeSort";
            this.btnMergeSort.UseVisualStyleBackColor = true;
            this.btnMergeSort.Click += new System.EventHandler(this.btnMergeSort_Click);
            // 
            // pbSelectionSort
            // 
            this.pbSelectionSort.Location = new System.Drawing.Point(162, 426);
            this.pbSelectionSort.Name = "pbSelectionSort";
            this.pbSelectionSort.Size = new System.Drawing.Size(425, 23);
            this.pbSelectionSort.TabIndex = 9;
            // 
            // pbMergeSort
            // 
            this.pbMergeSort.Location = new System.Drawing.Point(162, 321);
            this.pbMergeSort.Name = "pbMergeSort";
            this.pbMergeSort.Size = new System.Drawing.Size(425, 23);
            this.pbMergeSort.TabIndex = 8;
            // 
            // lblBurbuja
            // 
            this.lblBurbuja.AutoSize = true;
            this.lblBurbuja.Location = new System.Drawing.Point(22, 102);
            this.lblBurbuja.Name = "lblBurbuja";
            this.lblBurbuja.Size = new System.Drawing.Size(78, 16);
            this.lblBurbuja.TabIndex = 12;
            this.lblBurbuja.Text = "Burbuja: 0%";
            // 
            // lblQuicksort
            // 
            this.lblQuicksort.AutoSize = true;
            this.lblQuicksort.Location = new System.Drawing.Point(22, 207);
            this.lblQuicksort.Name = "lblQuicksort";
            this.lblQuicksort.Size = new System.Drawing.Size(88, 16);
            this.lblQuicksort.TabIndex = 13;
            this.lblQuicksort.Text = "Quicksort: 0%";
            // 
            // lblMergeSort
            // 
            this.lblMergeSort.AutoSize = true;
            this.lblMergeSort.Location = new System.Drawing.Point(22, 321);
            this.lblMergeSort.Name = "lblMergeSort";
            this.lblMergeSort.Size = new System.Drawing.Size(95, 16);
            this.lblMergeSort.TabIndex = 14;
            this.lblMergeSort.Text = "MergeSort: 0%";
            // 
            // lblSelectionSort
            // 
            this.lblSelectionSort.AutoSize = true;
            this.lblSelectionSort.Location = new System.Drawing.Point(22, 433);
            this.lblSelectionSort.Name = "lblSelectionSort";
            this.lblSelectionSort.Size = new System.Drawing.Size(112, 16);
            this.lblSelectionSort.TabIndex = 15;
            this.lblSelectionSort.Text = "SelectionSort: 0%";
            // 
            // nudNumeros
            // 
            this.nudNumeros.Location = new System.Drawing.Point(202, 30);
            this.nudNumeros.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudNumeros.Name = "nudNumeros";
            this.nudNumeros.Size = new System.Drawing.Size(181, 22);
            this.nudNumeros.TabIndex = 16;
            this.nudNumeros.ValueChanged += new System.EventHandler(this.nudNumeros_ValueChanged);
            // 
            // btnBurbujaDC
            // 
            this.btnBurbujaDC.Enabled = false;
            this.btnBurbujaDC.Location = new System.Drawing.Point(389, 146);
            this.btnBurbujaDC.Name = "btnBurbujaDC";
            this.btnBurbujaDC.Size = new System.Drawing.Size(140, 46);
            this.btnBurbujaDC.TabIndex = 17;
            this.btnBurbujaDC.Text = "Detener";
            this.btnBurbujaDC.UseVisualStyleBackColor = true;
            this.btnBurbujaDC.Click += new System.EventHandler(this.btnBurbujaDC_Click);
            // 
            // btnQuicksortDC
            // 
            this.btnQuicksortDC.Enabled = false;
            this.btnQuicksortDC.Location = new System.Drawing.Point(389, 253);
            this.btnQuicksortDC.Name = "btnQuicksortDC";
            this.btnQuicksortDC.Size = new System.Drawing.Size(140, 46);
            this.btnQuicksortDC.TabIndex = 18;
            this.btnQuicksortDC.Text = "Detener";
            this.btnQuicksortDC.UseVisualStyleBackColor = true;
            this.btnQuicksortDC.Click += new System.EventHandler(this.btnQuicksortDC_Click);
            // 
            // btnMergeSortDC
            // 
            this.btnMergeSortDC.Enabled = false;
            this.btnMergeSortDC.Location = new System.Drawing.Point(389, 365);
            this.btnMergeSortDC.Name = "btnMergeSortDC";
            this.btnMergeSortDC.Size = new System.Drawing.Size(140, 46);
            this.btnMergeSortDC.TabIndex = 19;
            this.btnMergeSortDC.Text = "Detener";
            this.btnMergeSortDC.UseVisualStyleBackColor = true;
            this.btnMergeSortDC.Click += new System.EventHandler(this.btnMergeSortDC_Click);
            // 
            // btnSelectionSortDC
            // 
            this.btnSelectionSortDC.Enabled = false;
            this.btnSelectionSortDC.Location = new System.Drawing.Point(389, 472);
            this.btnSelectionSortDC.Name = "btnSelectionSortDC";
            this.btnSelectionSortDC.Size = new System.Drawing.Size(140, 46);
            this.btnSelectionSortDC.TabIndex = 20;
            this.btnSelectionSortDC.Text = "Detener";
            this.btnSelectionSortDC.UseVisualStyleBackColor = true;
            this.btnSelectionSortDC.Click += new System.EventHandler(this.btnSelectionSortDC_Click);
            // 
            // btnGraf
            // 
            this.btnGraf.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGraf.Enabled = false;
            this.btnGraf.Location = new System.Drawing.Point(25, 530);
            this.btnGraf.Name = "btnGraf";
            this.btnGraf.Size = new System.Drawing.Size(543, 65);
            this.btnGraf.TabIndex = 21;
            this.btnGraf.Text = "Graficar Tiempos de ejecución";
            this.btnGraf.UseVisualStyleBackColor = false;
            this.btnGraf.Click += new System.EventHandler(this.btnGraf_Click);
            // 
            // backgroundWorkerQuickSort
            // 
            this.backgroundWorkerQuickSort.WorkerReportsProgress = true;
            this.backgroundWorkerQuickSort.WorkerSupportsCancellation = true;
            this.backgroundWorkerQuickSort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerQuickSort_DoWork);
            this.backgroundWorkerQuickSort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerQuickSort_RunWorkerCompleted);
            // 
            // backgroundWorkerSelectionSort
            // 
            this.backgroundWorkerSelectionSort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerSelectionSort_DoWork);
            // 
            // btnTotalDC
            // 
            this.btnTotalDC.Location = new System.Drawing.Point(394, 12);
            this.btnTotalDC.Name = "btnTotalDC";
            this.btnTotalDC.Size = new System.Drawing.Size(184, 57);
            this.btnTotalDC.TabIndex = 22;
            this.btnTotalDC.Text = "Detener/Reanudar todos los hilos";
            this.btnTotalDC.UseVisualStyleBackColor = true;
            this.btnTotalDC.Click += new System.EventHandler(this.btnTotalDC_Click);
            // 
            // estdB
            // 
            this.estdB.BackColor = System.Drawing.Color.Red;
            this.estdB.Enabled = false;
            this.estdB.Location = new System.Drawing.Point(54, 154);
            this.estdB.Name = "estdB";
            this.estdB.Size = new System.Drawing.Size(32, 31);
            this.estdB.TabIndex = 23;
            this.estdB.UseVisualStyleBackColor = false;
            this.estdB.Visible = false;
            // 
            // estdQ
            // 
            this.estdQ.BackColor = System.Drawing.Color.Red;
            this.estdQ.Enabled = false;
            this.estdQ.Location = new System.Drawing.Point(54, 261);
            this.estdQ.Name = "estdQ";
            this.estdQ.Size = new System.Drawing.Size(32, 31);
            this.estdQ.TabIndex = 24;
            this.estdQ.UseVisualStyleBackColor = false;
            this.estdQ.Visible = false;
            // 
            // estdM
            // 
            this.estdM.BackColor = System.Drawing.Color.Red;
            this.estdM.Enabled = false;
            this.estdM.Location = new System.Drawing.Point(54, 373);
            this.estdM.Name = "estdM";
            this.estdM.Size = new System.Drawing.Size(32, 31);
            this.estdM.TabIndex = 25;
            this.estdM.UseVisualStyleBackColor = false;
            this.estdM.Visible = false;
            // 
            // estdS
            // 
            this.estdS.BackColor = System.Drawing.Color.Red;
            this.estdS.Enabled = false;
            this.estdS.Location = new System.Drawing.Point(54, 480);
            this.estdS.Name = "estdS";
            this.estdS.Size = new System.Drawing.Size(32, 31);
            this.estdS.TabIndex = 26;
            this.estdS.UseVisualStyleBackColor = false;
            this.estdS.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(613, 913);
            this.Controls.Add(this.estdS);
            this.Controls.Add(this.estdM);
            this.Controls.Add(this.estdQ);
            this.Controls.Add(this.estdB);
            this.Controls.Add(this.btnTotalDC);
            this.Controls.Add(this.btnGraf);
            this.Controls.Add(this.btnSelectionSortDC);
            this.Controls.Add(this.btnMergeSortDC);
            this.Controls.Add(this.btnQuicksortDC);
            this.Controls.Add(this.btnBurbujaDC);
            this.Controls.Add(this.nudNumeros);
            this.Controls.Add(this.lblSelectionSort);
            this.Controls.Add(this.lblMergeSort);
            this.Controls.Add(this.lblQuicksort);
            this.Controls.Add(this.lblBurbuja);
            this.Controls.Add(this.btnSelectionSort);
            this.Controls.Add(this.btnMergeSort);
            this.Controls.Add(this.pbSelectionSort);
            this.Controls.Add(this.pbMergeSort);
            this.Controls.Add(this.charGraf);
            this.Controls.Add(this.btnQuickSort);
            this.Controls.Add(this.btnBurbuja);
            this.Controls.Add(this.pbQuicksort);
            this.Controls.Add(this.pbBurbuja);
            this.Controls.Add(this.btnNum);
            this.Name = "Form1";
            this.Text = "Multihilos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.charGraf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNum;
        private System.Windows.Forms.ProgressBar pbBurbuja;
        private System.Windows.Forms.ProgressBar pbQuicksort;
        private System.Windows.Forms.Button btnBurbuja;
        private System.Windows.Forms.Button btnQuickSort;
        private System.Windows.Forms.DataVisualization.Charting.Chart charGraf;
        private System.Windows.Forms.Button btnSelectionSort;
        private System.Windows.Forms.Button btnMergeSort;
        private System.Windows.Forms.ProgressBar pbSelectionSort;
        private System.Windows.Forms.ProgressBar pbMergeSort;
        private System.Windows.Forms.Label lblBurbuja;
        private System.Windows.Forms.Label lblQuicksort;
        private System.Windows.Forms.Label lblMergeSort;
        private System.Windows.Forms.Label lblSelectionSort;
        private System.Windows.Forms.NumericUpDown nudNumeros;
        private System.Windows.Forms.Button btnBurbujaDC;
        private System.Windows.Forms.Button btnQuicksortDC;
        private System.Windows.Forms.Button btnMergeSortDC;
        private System.Windows.Forms.Button btnSelectionSortDC;
        private System.Windows.Forms.Button btnGraf;
        private System.ComponentModel.BackgroundWorker backgroundWorkerQuickSort;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSelectionSort;
        private System.Windows.Forms.Button btnTotalDC;
        private System.Windows.Forms.Button estdB;
        private System.Windows.Forms.Button estdQ;
        private System.Windows.Forms.Button estdM;
        private System.Windows.Forms.Button estdS;
    }
}

