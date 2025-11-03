namespace Tarea7_Prog_Vis_I
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ctTotal = new System.Windows.Forms.TextBox();
            this.lblTot = new System.Windows.Forms.Label();
            this.dgvVis = new System.Windows.Forms.DataGridView();
            this.ctFacML = new System.Windows.Forms.TextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.cbCod = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvVisN = new System.Windows.Forms.DataGridView();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.ctCli = new System.Windows.Forms.TextBox();
            this.ctFac = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNCli = new System.Windows.Forms.Label();
            this.lblcod_Fact = new System.Windows.Forms.Label();
            this.Producto = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVis)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisN)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ctTotal);
            this.tabPage1.Controls.Add(this.lblTot);
            this.tabPage1.Controls.Add(this.dgvVis);
            this.tabPage1.Controls.Add(this.ctFacML);
            this.tabPage1.Controls.Add(this.lblCod);
            this.tabPage1.Controls.Add(this.cbCod);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Visualizar";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // ctTotal
            // 
            this.ctTotal.Location = new System.Drawing.Point(488, 378);
            this.ctTotal.Multiline = true;
            this.ctTotal.Name = "ctTotal";
            this.ctTotal.Size = new System.Drawing.Size(239, 34);
            this.ctTotal.TabIndex = 5;
            // 
            // lblTot
            // 
            this.lblTot.AutoSize = true;
            this.lblTot.Location = new System.Drawing.Point(413, 397);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(38, 16);
            this.lblTot.TabIndex = 4;
            this.lblTot.Text = "Total";
            // 
            // dgvVis
            // 
            this.dgvVis.AllowUserToAddRows = false;
            this.dgvVis.AllowUserToDeleteRows = false;
            this.dgvVis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVis.Location = new System.Drawing.Point(58, 136);
            this.dgvVis.Name = "dgvVis";
            this.dgvVis.ReadOnly = true;
            this.dgvVis.RowHeadersWidth = 51;
            this.dgvVis.RowTemplate.Height = 24;
            this.dgvVis.Size = new System.Drawing.Size(669, 236);
            this.dgvVis.TabIndex = 3;
            // 
            // ctFacML
            // 
            this.ctFacML.Location = new System.Drawing.Point(400, 23);
            this.ctFacML.Multiline = true;
            this.ctFacML.Name = "ctFacML";
            this.ctFacML.Size = new System.Drawing.Size(327, 74);
            this.ctFacML.TabIndex = 2;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(58, 23);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(134, 16);
            this.lblCod.TabIndex = 1;
            this.lblCod.Text = "Seleccione el código";
            // 
            // cbCod
            // 
            this.cbCod.FormattingEnabled = true;
            this.cbCod.Location = new System.Drawing.Point(58, 73);
            this.cbCod.Name = "cbCod";
            this.cbCod.Size = new System.Drawing.Size(192, 24);
            this.cbCod.TabIndex = 0;
            this.cbCod.SelectedIndexChanged += new System.EventHandler(this.cbCod_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.dtpFecha);
            this.tabPage2.Controls.Add(this.ctCli);
            this.tabPage2.Controls.Add(this.ctFac);
            this.tabPage2.Controls.Add(this.lblFecha);
            this.tabPage2.Controls.Add(this.lblNCli);
            this.tabPage2.Controls.Add(this.lblcod_Fact);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nueva";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.dgvVisN);
            this.groupBox1.Location = new System.Drawing.Point(33, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(725, 195);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione Producto y Cantidad";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(628, 80);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvVisN
            // 
            this.dgvVisN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Cantidad});
            this.dgvVisN.Location = new System.Drawing.Point(29, 30);
            this.dgvVisN.Name = "dgvVisN";
            this.dgvVisN.RowHeadersWidth = 51;
            this.dgvVisN.RowTemplate.Height = 24;
            this.dgvVisN.Size = new System.Drawing.Size(559, 150);
            this.dgvVisN.TabIndex = 0;
            this.dgvVisN.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvVisN_CellBeginEdit);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(139, 107);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(283, 22);
            this.dtpFecha.TabIndex = 5;
            // 
            // ctCli
            // 
            this.ctCli.Location = new System.Drawing.Point(139, 65);
            this.ctCli.Name = "ctCli";
            this.ctCli.Size = new System.Drawing.Size(283, 22);
            this.ctCli.TabIndex = 4;
            // 
            // ctFac
            // 
            this.ctFac.Location = new System.Drawing.Point(139, 25);
            this.ctFac.Name = "ctFac";
            this.ctFac.Size = new System.Drawing.Size(283, 22);
            this.ctFac.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(30, 107);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(96, 16);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha Compra";
            // 
            // lblNCli
            // 
            this.lblNCli.AutoSize = true;
            this.lblNCli.Location = new System.Drawing.Point(30, 68);
            this.lblNCli.Name = "lblNCli";
            this.lblNCli.Size = new System.Drawing.Size(100, 16);
            this.lblNCli.TabIndex = 1;
            this.lblNCli.Text = "Nombre Cliente";
            // 
            // lblcod_Fact
            // 
            this.lblcod_Fact.AutoSize = true;
            this.lblcod_Fact.Location = new System.Drawing.Point(27, 25);
            this.lblcod_Fact.Name = "lblcod_Fact";
            this.lblcod_Fact.Size = new System.Drawing.Size(94, 16);
            this.lblcod_Fact.TabIndex = 0;
            this.lblcod_Fact.Text = "Código factura";
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form3";
            this.Text = "Facturas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVis)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.ComboBox cbCod;
        private System.Windows.Forms.DataGridView dgvVis;
        private System.Windows.Forms.TextBox ctFacML;
        private System.Windows.Forms.TextBox ctTotal;
        private System.Windows.Forms.Label lblTot;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox ctCli;
        private System.Windows.Forms.TextBox ctFac;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNCli;
        private System.Windows.Forms.Label lblcod_Fact;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvVisN;
        private System.Windows.Forms.DataGridViewComboBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}