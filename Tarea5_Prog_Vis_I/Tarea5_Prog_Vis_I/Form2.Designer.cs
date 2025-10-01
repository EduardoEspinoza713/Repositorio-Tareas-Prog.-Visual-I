namespace Tarea5_Prog_Vis_I
{
    partial class Form2
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblCarnet = new System.Windows.Forms.Label();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.dgvDatosF2 = new System.Windows.Forms.DataGridView();
            this.Asignaturas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosF2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(109, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(283, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(22, 39);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(56, 16);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nombre";
            // 
            // lblCarnet
            // 
            this.lblCarnet.AutoSize = true;
            this.lblCarnet.Location = new System.Drawing.Point(22, 84);
            this.lblCarnet.Name = "lblCarnet";
            this.lblCarnet.Size = new System.Drawing.Size(46, 16);
            this.lblCarnet.TabIndex = 3;
            this.lblCarnet.Text = "Carnet";
            // 
            // txtCarnet
            // 
            this.txtCarnet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCarnet.Location = new System.Drawing.Point(109, 79);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(283, 22);
            this.txtCarnet.TabIndex = 2;
            // 
            // dgvDatosF2
            // 
            this.dgvDatosF2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosF2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Asignaturas,
            this.Nota});
            this.dgvDatosF2.Location = new System.Drawing.Point(72, 156);
            this.dgvDatosF2.Name = "dgvDatosF2";
            this.dgvDatosF2.RowHeadersWidth = 51;
            this.dgvDatosF2.RowTemplate.Height = 24;
            this.dgvDatosF2.Size = new System.Drawing.Size(303, 154);
            this.dgvDatosF2.TabIndex = 4;
            // 
            // Asignaturas
            // 
            this.Asignaturas.HeaderText = "Asignaturas";
            this.Asignaturas.MinimumWidth = 6;
            this.Asignaturas.Name = "Asignaturas";
            this.Asignaturas.Width = 125;
            // 
            // Nota
            // 
            this.Nota.HeaderText = "Nota";
            this.Nota.MinimumWidth = 6;
            this.Nota.Name = "Nota";
            this.Nota.Width = 125;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(158, 382);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(137, 56);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvDatosF2);
            this.Controls.Add(this.lblCarnet);
            this.Controls.Add(this.txtCarnet);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form2";
            this.Text = "Registrar un nuevo estudiante";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosF2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblCarnet;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.DataGridView dgvDatosF2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignaturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.Button btnGuardar;
    }
}