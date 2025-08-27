namespace Calculadora
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
            this.pantalla = new System.Windows.Forms.TextBox();
            this.btMmas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btMmenos = new System.Windows.Forms.Button();
            this.btMC = new System.Windows.Forms.Button();
            this.btMR = new System.Windows.Forms.Button();
            this.btBA = new System.Windows.Forms.Button();
            this.btsum = new System.Windows.Forms.Button();
            this.btRes = new System.Windows.Forms.Button();
            this.btmult = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.btCE = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.btPi = new System.Windows.Forms.Button();
            this.btAbs = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.btlog = new System.Windows.Forms.Button();
            this.btPorc = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.btExpo = new System.Windows.Forms.Button();
            this.btCuadrado = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btIgual = new System.Windows.Forms.Button();
            this.btdecimal = new System.Windows.Forms.Button();
            this.btRaiz = new System.Windows.Forms.Button();
            this.btBin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pantalla
            // 
            this.pantalla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pantalla.Enabled = false;
            this.pantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pantalla.Location = new System.Drawing.Point(33, 34);
            this.pantalla.Multiline = true;
            this.pantalla.Name = "pantalla";
            this.pantalla.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pantalla.Size = new System.Drawing.Size(317, 79);
            this.pantalla.TabIndex = 0;
            this.pantalla.Text = "0";
            this.pantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btMmas
            // 
            this.btMmas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btMmas.Location = new System.Drawing.Point(44, 151);
            this.btMmas.Name = "btMmas";
            this.btMmas.Size = new System.Drawing.Size(54, 54);
            this.btMmas.TabIndex = 1;
            this.btMmas.Text = "M+";
            this.btMmas.UseVisualStyleBackColor = false;
            this.btMmas.Click += new System.EventHandler(this.btMmas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Calculadora";
            // 
            // btMmenos
            // 
            this.btMmenos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btMmenos.Enabled = false;
            this.btMmenos.Location = new System.Drawing.Point(104, 151);
            this.btMmenos.Name = "btMmenos";
            this.btMmenos.Size = new System.Drawing.Size(54, 54);
            this.btMmenos.TabIndex = 3;
            this.btMmenos.Text = "M-";
            this.btMmenos.UseVisualStyleBackColor = false;
            this.btMmenos.Click += new System.EventHandler(this.btMmenos_Click);
            // 
            // btMC
            // 
            this.btMC.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btMC.Enabled = false;
            this.btMC.Location = new System.Drawing.Point(164, 151);
            this.btMC.Name = "btMC";
            this.btMC.Size = new System.Drawing.Size(54, 54);
            this.btMC.TabIndex = 4;
            this.btMC.Text = "MC";
            this.btMC.UseVisualStyleBackColor = false;
            this.btMC.Click += new System.EventHandler(this.btMC_Click);
            // 
            // btMR
            // 
            this.btMR.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btMR.Enabled = false;
            this.btMR.Location = new System.Drawing.Point(224, 151);
            this.btMR.Name = "btMR";
            this.btMR.Size = new System.Drawing.Size(54, 54);
            this.btMR.TabIndex = 5;
            this.btMR.Text = "MR";
            this.btMR.UseVisualStyleBackColor = false;
            this.btMR.Click += new System.EventHandler(this.btMR_Click);
            // 
            // btBA
            // 
            this.btBA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btBA.Location = new System.Drawing.Point(284, 151);
            this.btBA.Name = "btBA";
            this.btBA.Size = new System.Drawing.Size(54, 54);
            this.btBA.TabIndex = 6;
            this.btBA.Text = "BA";
            this.btBA.UseVisualStyleBackColor = false;
            this.btBA.Click += new System.EventHandler(this.btBA_Click);
            // 
            // btsum
            // 
            this.btsum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btsum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsum.Location = new System.Drawing.Point(44, 211);
            this.btsum.Name = "btsum";
            this.btsum.Size = new System.Drawing.Size(54, 54);
            this.btsum.TabIndex = 7;
            this.btsum.Text = "+";
            this.btsum.UseVisualStyleBackColor = false;
            this.btsum.Click += new System.EventHandler(this.btsum_Click);
            // 
            // btRes
            // 
            this.btRes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRes.Location = new System.Drawing.Point(104, 211);
            this.btRes.Name = "btRes";
            this.btRes.Size = new System.Drawing.Size(54, 54);
            this.btRes.TabIndex = 8;
            this.btRes.Text = "-";
            this.btRes.UseVisualStyleBackColor = false;
            this.btRes.Click += new System.EventHandler(this.btRes_Click);
            // 
            // btmult
            // 
            this.btmult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btmult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmult.Location = new System.Drawing.Point(162, 212);
            this.btmult.Name = "btmult";
            this.btmult.Size = new System.Drawing.Size(54, 54);
            this.btmult.TabIndex = 9;
            this.btmult.Text = "*";
            this.btmult.UseVisualStyleBackColor = false;
            this.btmult.Click += new System.EventHandler(this.btmult_Click);
            // 
            // btDiv
            // 
            this.btDiv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDiv.Location = new System.Drawing.Point(224, 211);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(54, 54);
            this.btDiv.TabIndex = 10;
            this.btDiv.Text = "/";
            this.btDiv.UseVisualStyleBackColor = false;
            this.btDiv.Click += new System.EventHandler(this.btDiv_Click);
            // 
            // btCE
            // 
            this.btCE.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btCE.Location = new System.Drawing.Point(284, 211);
            this.btCE.Name = "btCE";
            this.btCE.Size = new System.Drawing.Size(54, 54);
            this.btCE.TabIndex = 11;
            this.btCE.Text = "CE";
            this.btCE.UseVisualStyleBackColor = false;
            this.btCE.Click += new System.EventHandler(this.btCE_Click);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(44, 271);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(54, 54);
            this.bt1.TabIndex = 12;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(104, 271);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(54, 54);
            this.bt2.TabIndex = 13;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(164, 272);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(54, 54);
            this.bt3.TabIndex = 14;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // btPi
            // 
            this.btPi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btPi.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPi.Location = new System.Drawing.Point(224, 272);
            this.btPi.Name = "btPi";
            this.btPi.Size = new System.Drawing.Size(54, 54);
            this.btPi.TabIndex = 15;
            this.btPi.Text = "π";
            this.btPi.UseVisualStyleBackColor = false;
            this.btPi.Click += new System.EventHandler(this.btPi_Click);
            // 
            // btAbs
            // 
            this.btAbs.BackColor = System.Drawing.SystemColors.Highlight;
            this.btAbs.Location = new System.Drawing.Point(284, 271);
            this.btAbs.Name = "btAbs";
            this.btAbs.Size = new System.Drawing.Size(54, 54);
            this.btAbs.TabIndex = 16;
            this.btAbs.Text = "|x|";
            this.btAbs.UseVisualStyleBackColor = false;
            this.btAbs.Click += new System.EventHandler(this.btAbs_Click);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(44, 331);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(54, 54);
            this.bt4.TabIndex = 17;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(104, 331);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(54, 54);
            this.bt5.TabIndex = 18;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(164, 332);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(54, 54);
            this.bt6.TabIndex = 19;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // btlog
            // 
            this.btlog.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btlog.Location = new System.Drawing.Point(224, 332);
            this.btlog.Name = "btlog";
            this.btlog.Size = new System.Drawing.Size(54, 54);
            this.btlog.TabIndex = 20;
            this.btlog.Text = "log";
            this.btlog.UseVisualStyleBackColor = false;
            this.btlog.Click += new System.EventHandler(this.btlog_Click);
            // 
            // btPorc
            // 
            this.btPorc.BackColor = System.Drawing.SystemColors.Highlight;
            this.btPorc.Location = new System.Drawing.Point(284, 331);
            this.btPorc.Name = "btPorc";
            this.btPorc.Size = new System.Drawing.Size(54, 54);
            this.btPorc.TabIndex = 21;
            this.btPorc.Text = "%";
            this.btPorc.UseVisualStyleBackColor = false;
            this.btPorc.Click += new System.EventHandler(this.btPorc_Click);
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(44, 391);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(54, 54);
            this.bt7.TabIndex = 22;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(104, 391);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(54, 54);
            this.bt8.TabIndex = 23;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(164, 392);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(54, 54);
            this.bt9.TabIndex = 24;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // btExpo
            // 
            this.btExpo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btExpo.Location = new System.Drawing.Point(224, 392);
            this.btExpo.Name = "btExpo";
            this.btExpo.Size = new System.Drawing.Size(54, 54);
            this.btExpo.TabIndex = 25;
            this.btExpo.Text = "^";
            this.btExpo.UseVisualStyleBackColor = false;
            this.btExpo.Click += new System.EventHandler(this.btExpo_Click);
            // 
            // btCuadrado
            // 
            this.btCuadrado.BackColor = System.Drawing.SystemColors.Highlight;
            this.btCuadrado.Location = new System.Drawing.Point(284, 391);
            this.btCuadrado.Name = "btCuadrado";
            this.btCuadrado.Size = new System.Drawing.Size(54, 54);
            this.btCuadrado.TabIndex = 26;
            this.btCuadrado.Text = "^2";
            this.btCuadrado.UseVisualStyleBackColor = false;
            this.btCuadrado.Click += new System.EventHandler(this.btCuadrado_Click);
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(44, 451);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(112, 54);
            this.bt0.TabIndex = 27;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // btIgual
            // 
            this.btIgual.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIgual.Location = new System.Drawing.Point(46, 514);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(292, 54);
            this.btIgual.TabIndex = 28;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = false;
            this.btIgual.Click += new System.EventHandler(this.btIgual_Click);
            // 
            // btdecimal
            // 
            this.btdecimal.Location = new System.Drawing.Point(162, 451);
            this.btdecimal.Name = "btdecimal";
            this.btdecimal.Size = new System.Drawing.Size(54, 54);
            this.btdecimal.TabIndex = 29;
            this.btdecimal.Text = ".";
            this.btdecimal.UseVisualStyleBackColor = true;
            this.btdecimal.Click += new System.EventHandler(this.btdecimal_Click);
            // 
            // btRaiz
            // 
            this.btRaiz.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btRaiz.Location = new System.Drawing.Point(222, 451);
            this.btRaiz.Name = "btRaiz";
            this.btRaiz.Size = new System.Drawing.Size(54, 54);
            this.btRaiz.TabIndex = 30;
            this.btRaiz.Text = "√";
            this.btRaiz.UseVisualStyleBackColor = false;
            this.btRaiz.Click += new System.EventHandler(this.btRaiz_Click);
            // 
            // btBin
            // 
            this.btBin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btBin.Location = new System.Drawing.Point(282, 451);
            this.btBin.Name = "btBin";
            this.btBin.Size = new System.Drawing.Size(54, 54);
            this.btBin.TabIndex = 31;
            this.btBin.Text = "Bin";
            this.btBin.UseVisualStyleBackColor = false;
            this.btBin.Click += new System.EventHandler(this.btBin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 580);
            this.Controls.Add(this.btBin);
            this.Controls.Add(this.btRaiz);
            this.Controls.Add(this.btdecimal);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.btCuadrado);
            this.Controls.Add(this.btExpo);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.btPorc);
            this.Controls.Add(this.btlog);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.btAbs);
            this.Controls.Add(this.btPi);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.btCE);
            this.Controls.Add(this.btDiv);
            this.Controls.Add(this.btmult);
            this.Controls.Add(this.btRes);
            this.Controls.Add(this.btsum);
            this.Controls.Add(this.btBA);
            this.Controls.Add(this.btMR);
            this.Controls.Add(this.btMC);
            this.Controls.Add(this.btMmenos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btMmas);
            this.Controls.Add(this.pantalla);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pantalla;
        private System.Windows.Forms.Button btMmas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btMmenos;
        private System.Windows.Forms.Button btMC;
        private System.Windows.Forms.Button btMR;
        private System.Windows.Forms.Button btBA;
        private System.Windows.Forms.Button btsum;
        private System.Windows.Forms.Button btRes;
        private System.Windows.Forms.Button btmult;
        private System.Windows.Forms.Button btDiv;
        private System.Windows.Forms.Button btCE;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button btPi;
        private System.Windows.Forms.Button btAbs;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button btlog;
        private System.Windows.Forms.Button btPorc;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button btExpo;
        private System.Windows.Forms.Button btCuadrado;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btIgual;
        private System.Windows.Forms.Button btdecimal;
        private System.Windows.Forms.Button btRaiz;
        private System.Windows.Forms.Button btBin;
    }
}

