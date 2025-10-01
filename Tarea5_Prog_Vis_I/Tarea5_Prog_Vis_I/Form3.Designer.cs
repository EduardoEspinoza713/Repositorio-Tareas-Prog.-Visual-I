namespace Tarea5_Prog_Vis_I
{
    partial class Form3
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
            this.lblMostCarnet = new System.Windows.Forms.Label();
            this.lblMostNombre = new System.Windows.Forms.Label();
            this.dgvDatosF3 = new System.Windows.Forms.DataGridView();
            this.lblAsignaturas = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimp = new System.Windows.Forms.Button();
            this.txtBus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosF3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMostCarnet
            // 
            this.lblMostCarnet.AutoSize = true;
            this.lblMostCarnet.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostCarnet.Location = new System.Drawing.Point(93, 106);
            this.lblMostCarnet.Name = "lblMostCarnet";
            this.lblMostCarnet.Size = new System.Drawing.Size(100, 30);
            this.lblMostCarnet.TabIndex = 0;
            this.lblMostCarnet.Text = "Carnet: ";
            // 
            // lblMostNombre
            // 
            this.lblMostNombre.AutoSize = true;
            this.lblMostNombre.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostNombre.Location = new System.Drawing.Point(93, 43);
            this.lblMostNombre.Name = "lblMostNombre";
            this.lblMostNombre.Size = new System.Drawing.Size(114, 30);
            this.lblMostNombre.TabIndex = 1;
            this.lblMostNombre.Text = "Nombre: ";
            // 
            // dgvDatosF3
            // 
            this.dgvDatosF3.AllowUserToAddRows = false;
            this.dgvDatosF3.AllowUserToDeleteRows = false;
            this.dgvDatosF3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosF3.Location = new System.Drawing.Point(81, 184);
            this.dgvDatosF3.Name = "dgvDatosF3";
            this.dgvDatosF3.ReadOnly = true;
            this.dgvDatosF3.RowHeadersWidth = 51;
            this.dgvDatosF3.RowTemplate.Height = 24;
            this.dgvDatosF3.Size = new System.Drawing.Size(402, 254);
            this.dgvDatosF3.TabIndex = 2;
            // 
            // lblAsignaturas
            // 
            this.lblAsignaturas.AutoSize = true;
            this.lblAsignaturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignaturas.Location = new System.Drawing.Point(211, 156);
            this.lblAsignaturas.Name = "lblAsignaturas";
            this.lblAsignaturas.Size = new System.Drawing.Size(127, 25);
            this.lblAsignaturas.TabIndex = 3;
            this.lblAsignaturas.Text = "Asignaturas";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Location = new System.Drawing.Point(429, 106);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 30);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimp
            // 
            this.btnLimp.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLimp.Location = new System.Drawing.Point(429, 43);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(75, 30);
            this.btnLimp.TabIndex = 5;
            this.btnLimp.Text = "Limpiar";
            this.btnLimp.UseVisualStyleBackColor = false;
            this.btnLimp.Click += new System.EventHandler(this.btnLimp_Click);
            // 
            // txtBus
            // 
            this.txtBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBus.Location = new System.Drawing.Point(190, 114);
            this.txtBus.Name = "txtBus";
            this.txtBus.Size = new System.Drawing.Size(233, 22);
            this.txtBus.TabIndex = 6;
            this.txtBus.TextChanged += new System.EventHandler(this.txtBus_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.txtBus);
            this.Controls.Add(this.btnLimp);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblAsignaturas);
            this.Controls.Add(this.dgvDatosF3);
            this.Controls.Add(this.lblMostNombre);
            this.Controls.Add(this.lblMostCarnet);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosF3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMostCarnet;
        private System.Windows.Forms.Label lblMostNombre;
        private System.Windows.Forms.DataGridView dgvDatosF3;
        private System.Windows.Forms.Label lblAsignaturas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimp;
        private System.Windows.Forms.TextBox txtBus;
    }
}