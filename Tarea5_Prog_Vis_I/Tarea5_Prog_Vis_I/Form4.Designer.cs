namespace Tarea5_Prog_Vis_I
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.GraficoF4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblMjrProm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoF4)).BeginInit();
            this.SuspendLayout();
            // 
            // GraficoF4
            // 
            chartArea2.Name = "ChartArea1";
            this.GraficoF4.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.GraficoF4.Legends.Add(legend2);
            this.GraficoF4.Location = new System.Drawing.Point(75, 76);
            this.GraficoF4.Name = "GraficoF4";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.GraficoF4.Series.Add(series2);
            this.GraficoF4.Size = new System.Drawing.Size(671, 362);
            this.GraficoF4.TabIndex = 0;
            this.GraficoF4.Text = "Gráfico mejores promedios";
            // 
            // lblMjrProm
            // 
            this.lblMjrProm.AutoSize = true;
            this.lblMjrProm.Font = new System.Drawing.Font("Comic Sans MS", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMjrProm.Location = new System.Drawing.Point(256, 9);
            this.lblMjrProm.Name = "lblMjrProm";
            this.lblMjrProm.Size = new System.Drawing.Size(281, 40);
            this.lblMjrProm.TabIndex = 1;
            this.lblMjrProm.Text = "Mejores promedios";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMjrProm);
            this.Controls.Add(this.GraficoF4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.GraficoF4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart GraficoF4;
        private System.Windows.Forms.Label lblMjrProm;
    }
}