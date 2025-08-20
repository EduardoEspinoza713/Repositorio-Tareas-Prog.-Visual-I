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
            this.button15 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.btlog = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.btExpo = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btIgual = new System.Windows.Forms.Button();
            this.btdecimal = new System.Windows.Forms.Button();
            this.btRaiz = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pantalla
            // 
            this.pantalla.Location = new System.Drawing.Point(33, 34);
            this.pantalla.Multiline = true;
            this.pantalla.Name = "pantalla";
            this.pantalla.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pantalla.Size = new System.Drawing.Size(317, 90);
            this.pantalla.TabIndex = 0;
            // 
            // btMmas
            // 
            this.btMmas.Location = new System.Drawing.Point(44, 151);
            this.btMmas.Name = "btMmas";
            this.btMmas.Size = new System.Drawing.Size(54, 54);
            this.btMmas.TabIndex = 1;
            this.btMmas.Text = "M+";
            this.btMmas.UseVisualStyleBackColor = true;
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
            this.btMmenos.Location = new System.Drawing.Point(104, 151);
            this.btMmenos.Name = "btMmenos";
            this.btMmenos.Size = new System.Drawing.Size(54, 54);
            this.btMmenos.TabIndex = 3;
            this.btMmenos.Text = "M-";
            this.btMmenos.UseVisualStyleBackColor = true;
            // 
            // btMC
            // 
            this.btMC.Location = new System.Drawing.Point(164, 151);
            this.btMC.Name = "btMC";
            this.btMC.Size = new System.Drawing.Size(54, 54);
            this.btMC.TabIndex = 4;
            this.btMC.Text = "MC";
            this.btMC.UseVisualStyleBackColor = true;
            // 
            // btMR
            // 
            this.btMR.Location = new System.Drawing.Point(224, 151);
            this.btMR.Name = "btMR";
            this.btMR.Size = new System.Drawing.Size(54, 54);
            this.btMR.TabIndex = 5;
            this.btMR.Text = "MR";
            this.btMR.UseVisualStyleBackColor = true;
            this.btMR.Click += new System.EventHandler(this.button4_Click);
            // 
            // btBA
            // 
            this.btBA.Location = new System.Drawing.Point(284, 151);
            this.btBA.Name = "btBA";
            this.btBA.Size = new System.Drawing.Size(54, 54);
            this.btBA.TabIndex = 6;
            this.btBA.Text = "BA";
            this.btBA.UseVisualStyleBackColor = true;
            // 
            // btsum
            // 
            this.btsum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsum.Location = new System.Drawing.Point(44, 211);
            this.btsum.Name = "btsum";
            this.btsum.Size = new System.Drawing.Size(54, 54);
            this.btsum.TabIndex = 7;
            this.btsum.Text = "+";
            this.btsum.UseVisualStyleBackColor = true;
            // 
            // btRes
            // 
            this.btRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRes.Location = new System.Drawing.Point(104, 211);
            this.btRes.Name = "btRes";
            this.btRes.Size = new System.Drawing.Size(54, 54);
            this.btRes.TabIndex = 8;
            this.btRes.Text = "-";
            this.btRes.UseVisualStyleBackColor = true;
            // 
            // btmult
            // 
            this.btmult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmult.Location = new System.Drawing.Point(162, 212);
            this.btmult.Name = "btmult";
            this.btmult.Size = new System.Drawing.Size(54, 54);
            this.btmult.TabIndex = 9;
            this.btmult.Text = "*";
            this.btmult.UseVisualStyleBackColor = true;
            // 
            // btDiv
            // 
            this.btDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDiv.Location = new System.Drawing.Point(224, 211);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(54, 54);
            this.btDiv.TabIndex = 10;
            this.btDiv.Text = "/";
            this.btDiv.UseVisualStyleBackColor = true;
            // 
            // btCE
            // 
            this.btCE.Location = new System.Drawing.Point(284, 211);
            this.btCE.Name = "btCE";
            this.btCE.Size = new System.Drawing.Size(54, 54);
            this.btCE.TabIndex = 11;
            this.btCE.Text = "CE";
            this.btCE.UseVisualStyleBackColor = true;
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(44, 271);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(54, 54);
            this.bt1.TabIndex = 12;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(104, 271);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(54, 54);
            this.bt2.TabIndex = 13;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(164, 272);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(54, 54);
            this.bt3.TabIndex = 14;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            // 
            // btPi
            // 
            this.btPi.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPi.Location = new System.Drawing.Point(224, 272);
            this.btPi.Name = "btPi";
            this.btPi.Size = new System.Drawing.Size(54, 54);
            this.btPi.TabIndex = 15;
            this.btPi.Text = "π";
            this.btPi.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(284, 271);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(54, 54);
            this.button15.TabIndex = 16;
            this.button15.Text = "button15";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(44, 331);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(54, 54);
            this.bt4.TabIndex = 17;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(104, 331);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(54, 54);
            this.bt5.TabIndex = 18;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(164, 332);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(54, 54);
            this.bt6.TabIndex = 19;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            // 
            // btlog
            // 
            this.btlog.Location = new System.Drawing.Point(224, 332);
            this.btlog.Name = "btlog";
            this.btlog.Size = new System.Drawing.Size(54, 54);
            this.btlog.TabIndex = 20;
            this.btlog.Text = "log";
            this.btlog.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(284, 331);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(54, 54);
            this.button20.TabIndex = 21;
            this.button20.Text = "button20";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(44, 391);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(54, 54);
            this.bt7.TabIndex = 22;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(104, 391);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(54, 54);
            this.bt8.TabIndex = 23;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(164, 392);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(54, 54);
            this.bt9.TabIndex = 24;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            // 
            // btExpo
            // 
            this.btExpo.Location = new System.Drawing.Point(224, 392);
            this.btExpo.Name = "btExpo";
            this.btExpo.Size = new System.Drawing.Size(54, 54);
            this.btExpo.TabIndex = 25;
            this.btExpo.Text = "^";
            this.btExpo.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(284, 391);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(54, 54);
            this.button25.TabIndex = 26;
            this.button25.Text = "button25";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(44, 451);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(112, 54);
            this.bt0.TabIndex = 27;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            // 
            // btIgual
            // 
            this.btIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIgual.Location = new System.Drawing.Point(46, 514);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(292, 54);
            this.btIgual.TabIndex = 28;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = true;
            // 
            // btdecimal
            // 
            this.btdecimal.Location = new System.Drawing.Point(162, 451);
            this.btdecimal.Name = "btdecimal";
            this.btdecimal.Size = new System.Drawing.Size(54, 54);
            this.btdecimal.TabIndex = 29;
            this.btdecimal.Text = ",";
            this.btdecimal.UseVisualStyleBackColor = true;
            // 
            // btRaiz
            // 
            this.btRaiz.Location = new System.Drawing.Point(222, 451);
            this.btRaiz.Name = "btRaiz";
            this.btRaiz.Size = new System.Drawing.Size(54, 54);
            this.btRaiz.TabIndex = 30;
            this.btRaiz.Text = "√";
            this.btRaiz.UseVisualStyleBackColor = true;
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(282, 451);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(54, 54);
            this.button30.TabIndex = 31;
            this.button30.Text = "button30";
            this.button30.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 580);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.btRaiz);
            this.Controls.Add(this.btdecimal);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.btExpo);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.btlog);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.button15);
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
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button btlog;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button btExpo;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btIgual;
        private System.Windows.Forms.Button btdecimal;
        private System.Windows.Forms.Button btRaiz;
        private System.Windows.Forms.Button button30;
    }
}

