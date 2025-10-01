namespace Tarea5_Prog_Vis_I
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnForm2 = new System.Windows.Forms.ToolStripButton();
            this.btnForm3 = new System.Windows.Forms.ToolStripButton();
            this.btnF4 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnForm2,
            this.btnForm3,
            this.btnF4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(924, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnForm2
            // 
            this.btnForm2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnForm2.Image = global::Tarea5_Prog_Vis_I.Properties.Resources._117885;
            this.btnForm2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(29, 28);
            this.btnForm2.Text = "Agregar estudiante";
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // btnForm3
            // 
            this.btnForm3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnForm3.Image = global::Tarea5_Prog_Vis_I.Properties.Resources._1063373;
            this.btnForm3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnForm3.Name = "btnForm3";
            this.btnForm3.Size = new System.Drawing.Size(29, 28);
            this.btnForm3.Text = "Ver estudiante";
            this.btnForm3.Click += new System.EventHandler(this.btnForm3_Click);
            // 
            // btnF4
            // 
            this.btnF4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnF4.Image = global::Tarea5_Prog_Vis_I.Properties.Resources.Statistic_finance_logo_vector_by_Mansel_Brist_1_580x406;
            this.btnF4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnF4.Name = "btnF4";
            this.btnF4.Size = new System.Drawing.Size(29, 28);
            this.btnF4.Text = "Gráfico Mejores Promedios";
            this.btnF4.Click += new System.EventHandler(this.btnF4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 644);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Registro de Estudiantes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnForm2;
        private System.Windows.Forms.ToolStripButton btnForm3;
        private System.Windows.Forms.ToolStripButton btnF4;
    }
}

