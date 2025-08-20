namespace Tarea_prog_visual
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.IMC = new System.Windows.Forms.TabPage();
            this.limpIMC = new System.Windows.Forms.Button();
            this.calcIMC = new System.Windows.Forms.Button();
            this.catIMC = new System.Windows.Forms.Label();
            this.resIMC = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.estatura = new System.Windows.Forms.TextBox();
            this.peso = new System.Windows.Forms.TextBox();
            this.CClick = new System.Windows.Forms.TabPage();
            this.btReCont = new System.Windows.Forms.Button();
            this.cont = new System.Windows.Forms.Label();
            this.clicks = new System.Windows.Forms.Button();
            this.Conversor = new System.Windows.Forms.TabPage();
            this.limp = new System.Windows.Forms.Button();
            this.btConvertir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctGF = new System.Windows.Forms.TextBox();
            this.ctGC = new System.Windows.Forms.TextBox();
            this.registro = new System.Windows.Forms.TabPage();
            this.btSesion = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ctClave = new System.Windows.Forms.TextBox();
            this.ctUsuario = new System.Windows.Forms.TextBox();
            this.TabControl.SuspendLayout();
            this.IMC.SuspendLayout();
            this.CClick.SuspendLayout();
            this.Conversor.SuspendLayout();
            this.registro.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.IMC);
            this.TabControl.Controls.Add(this.CClick);
            this.TabControl.Controls.Add(this.Conversor);
            this.TabControl.Controls.Add(this.registro);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(825, 402);
            this.TabControl.TabIndex = 0;
            // 
            // IMC
            // 
            this.IMC.Controls.Add(this.limpIMC);
            this.IMC.Controls.Add(this.calcIMC);
            this.IMC.Controls.Add(this.catIMC);
            this.IMC.Controls.Add(this.resIMC);
            this.IMC.Controls.Add(this.label4);
            this.IMC.Controls.Add(this.label3);
            this.IMC.Controls.Add(this.estatura);
            this.IMC.Controls.Add(this.peso);
            this.IMC.Location = new System.Drawing.Point(4, 25);
            this.IMC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IMC.Name = "IMC";
            this.IMC.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IMC.Size = new System.Drawing.Size(817, 373);
            this.IMC.TabIndex = 0;
            this.IMC.Text = "IMC";
            this.IMC.UseVisualStyleBackColor = true;
            // 
            // limpIMC
            // 
            this.limpIMC.BackColor = System.Drawing.Color.DarkGray;
            this.limpIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpIMC.Location = new System.Drawing.Point(83, 263);
            this.limpIMC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.limpIMC.Name = "limpIMC";
            this.limpIMC.Size = new System.Drawing.Size(149, 32);
            this.limpIMC.TabIndex = 7;
            this.limpIMC.Text = "Limpiar";
            this.limpIMC.UseVisualStyleBackColor = false;
            this.limpIMC.Click += new System.EventHandler(this.limpIMC_Click);
            // 
            // calcIMC
            // 
            this.calcIMC.BackColor = System.Drawing.Color.DarkGray;
            this.calcIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcIMC.Location = new System.Drawing.Point(77, 190);
            this.calcIMC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calcIMC.Name = "calcIMC";
            this.calcIMC.Size = new System.Drawing.Size(149, 32);
            this.calcIMC.TabIndex = 6;
            this.calcIMC.Text = "Calcular IMC";
            this.calcIMC.UseVisualStyleBackColor = false;
            this.calcIMC.Click += new System.EventHandler(this.calcIMC_Click);
            // 
            // catIMC
            // 
            this.catIMC.AutoSize = true;
            this.catIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catIMC.Location = new System.Drawing.Point(272, 258);
            this.catIMC.Name = "catIMC";
            this.catIMC.Size = new System.Drawing.Size(257, 32);
            this.catIMC.TabIndex = 5;
            this.catIMC.Text = "Tu Categoría es: -";
            // 
            // resIMC
            // 
            this.resIMC.AutoSize = true;
            this.resIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resIMC.Location = new System.Drawing.Point(272, 190);
            this.resIMC.Name = "resIMC";
            this.resIMC.Size = new System.Drawing.Size(177, 32);
            this.resIMC.TabIndex = 4;
            this.resIMC.Text = "Tu IMC es: -";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tu Estatura en m";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tu Peso en Kg";
            // 
            // estatura
            // 
            this.estatura.Location = new System.Drawing.Point(277, 103);
            this.estatura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.estatura.Name = "estatura";
            this.estatura.Size = new System.Drawing.Size(364, 22);
            this.estatura.TabIndex = 1;
            // 
            // peso
            // 
            this.peso.Location = new System.Drawing.Point(277, 39);
            this.peso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(364, 22);
            this.peso.TabIndex = 0;
            // 
            // CClick
            // 
            this.CClick.Controls.Add(this.btReCont);
            this.CClick.Controls.Add(this.cont);
            this.CClick.Controls.Add(this.clicks);
            this.CClick.Location = new System.Drawing.Point(4, 25);
            this.CClick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CClick.Name = "CClick";
            this.CClick.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CClick.Size = new System.Drawing.Size(817, 373);
            this.CClick.TabIndex = 1;
            this.CClick.Text = "Cont. Clicks";
            this.CClick.UseVisualStyleBackColor = true;
            // 
            // btReCont
            // 
            this.btReCont.BackColor = System.Drawing.Color.DarkGray;
            this.btReCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReCont.Location = new System.Drawing.Point(40, 188);
            this.btReCont.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btReCont.Name = "btReCont";
            this.btReCont.Size = new System.Drawing.Size(219, 121);
            this.btReCont.TabIndex = 2;
            this.btReCont.Text = "Reiniciar";
            this.btReCont.UseVisualStyleBackColor = false;
            this.btReCont.Click += new System.EventHandler(this.btReCont_Click);
            // 
            // cont
            // 
            this.cont.AutoSize = true;
            this.cont.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cont.Location = new System.Drawing.Point(276, 122);
            this.cont.Name = "cont";
            this.cont.Size = new System.Drawing.Size(464, 91);
            this.cont.TabIndex = 1;
            this.cont.Text = "Contador: 0";
            // 
            // clicks
            // 
            this.clicks.BackColor = System.Drawing.Color.DarkGray;
            this.clicks.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clicks.Location = new System.Drawing.Point(40, 41);
            this.clicks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clicks.Name = "clicks";
            this.clicks.Size = new System.Drawing.Size(219, 121);
            this.clicks.TabIndex = 0;
            this.clicks.Text = "Click";
            this.clicks.UseVisualStyleBackColor = false;
            this.clicks.Click += new System.EventHandler(this.clicks_Click);
            // 
            // Conversor
            // 
            this.Conversor.Controls.Add(this.limp);
            this.Conversor.Controls.Add(this.btConvertir);
            this.Conversor.Controls.Add(this.label2);
            this.Conversor.Controls.Add(this.label1);
            this.Conversor.Controls.Add(this.ctGF);
            this.Conversor.Controls.Add(this.ctGC);
            this.Conversor.Location = new System.Drawing.Point(4, 25);
            this.Conversor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Conversor.Name = "Conversor";
            this.Conversor.Size = new System.Drawing.Size(817, 373);
            this.Conversor.TabIndex = 2;
            this.Conversor.Text = "Conv. Temperatura";
            this.Conversor.UseVisualStyleBackColor = true;
            // 
            // limp
            // 
            this.limp.BackColor = System.Drawing.Color.DarkGray;
            this.limp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limp.Location = new System.Drawing.Point(219, 247);
            this.limp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.limp.Name = "limp";
            this.limp.Size = new System.Drawing.Size(160, 62);
            this.limp.TabIndex = 5;
            this.limp.Text = "Limpiar";
            this.limp.UseVisualStyleBackColor = false;
            this.limp.Click += new System.EventHandler(this.limp_Click);
            // 
            // btConvertir
            // 
            this.btConvertir.BackColor = System.Drawing.Color.DarkGray;
            this.btConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConvertir.Location = new System.Drawing.Point(31, 247);
            this.btConvertir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btConvertir.Name = "btConvertir";
            this.btConvertir.Size = new System.Drawing.Size(160, 62);
            this.btConvertir.TabIndex = 4;
            this.btConvertir.Text = "Convertir";
            this.btConvertir.UseVisualStyleBackColor = false;
            this.btConvertir.Click += new System.EventHandler(this.btConvertir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Temperatura Fahrenheit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Temperatura Celsius";
            // 
            // ctGF
            // 
            this.ctGF.Location = new System.Drawing.Point(251, 144);
            this.ctGF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctGF.Name = "ctGF";
            this.ctGF.Size = new System.Drawing.Size(457, 22);
            this.ctGF.TabIndex = 1;
            // 
            // ctGC
            // 
            this.ctGC.Location = new System.Drawing.Point(251, 69);
            this.ctGC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctGC.Name = "ctGC";
            this.ctGC.Size = new System.Drawing.Size(457, 22);
            this.ctGC.TabIndex = 0;
            // 
            // registro
            // 
            this.registro.BackColor = System.Drawing.Color.Transparent;
            this.registro.Controls.Add(this.btSesion);
            this.registro.Controls.Add(this.label7);
            this.registro.Controls.Add(this.label6);
            this.registro.Controls.Add(this.label5);
            this.registro.Controls.Add(this.ctClave);
            this.registro.Controls.Add(this.ctUsuario);
            this.registro.Location = new System.Drawing.Point(4, 25);
            this.registro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registro.Name = "registro";
            this.registro.Size = new System.Drawing.Size(817, 373);
            this.registro.TabIndex = 3;
            this.registro.Text = "Registro";
            // 
            // btSesion
            // 
            this.btSesion.BackColor = System.Drawing.Color.Black;
            this.btSesion.Enabled = false;
            this.btSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSesion.Location = new System.Drawing.Point(88, 277);
            this.btSesion.Margin = new System.Windows.Forms.Padding(4);
            this.btSesion.Name = "btSesion";
            this.btSesion.Size = new System.Drawing.Size(185, 57);
            this.btSesion.TabIndex = 5;
            this.btSesion.Text = "Iniciar Sesión";
            this.btSesion.UseVisualStyleBackColor = false;
            this.btSesion.Click += new System.EventHandler(this.btSesion_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(84, 202);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(84, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nombre de Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 65);
            this.label5.TabIndex = 2;
            this.label5.Text = "REGISTRO";
            // 
            // ctClave
            // 
            this.ctClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctClave.Enabled = false;
            this.ctClave.Location = new System.Drawing.Point(293, 202);
            this.ctClave.Margin = new System.Windows.Forms.Padding(4);
            this.ctClave.Name = "ctClave";
            this.ctClave.PasswordChar = '*';
            this.ctClave.Size = new System.Drawing.Size(297, 22);
            this.ctClave.TabIndex = 1;
            this.ctClave.TextChanged += new System.EventHandler(this.ctClave_TextChanged);
            // 
            // ctUsuario
            // 
            this.ctUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctUsuario.Location = new System.Drawing.Point(293, 117);
            this.ctUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.ctUsuario.Name = "ctUsuario";
            this.ctUsuario.Size = new System.Drawing.Size(297, 22);
            this.ctUsuario.TabIndex = 0;
            this.ctUsuario.TextChanged += new System.EventHandler(this.ctUsuario_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 402);
            this.Controls.Add(this.TabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Tarea #1 Prog. Visual I";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl.ResumeLayout(false);
            this.IMC.ResumeLayout(false);
            this.IMC.PerformLayout();
            this.CClick.ResumeLayout(false);
            this.CClick.PerformLayout();
            this.Conversor.ResumeLayout(false);
            this.Conversor.PerformLayout();
            this.registro.ResumeLayout(false);
            this.registro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage IMC;
        private System.Windows.Forms.TabPage CClick;
        private System.Windows.Forms.TabPage Conversor;
        private System.Windows.Forms.Label cont;
        private System.Windows.Forms.Button clicks;
        private System.Windows.Forms.Button btConvertir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ctGF;
        private System.Windows.Forms.TextBox ctGC;
        private System.Windows.Forms.Button limp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox estatura;
        private System.Windows.Forms.TextBox peso;
        private System.Windows.Forms.Button limpIMC;
        private System.Windows.Forms.Button calcIMC;
        private System.Windows.Forms.Label catIMC;
        private System.Windows.Forms.Label resIMC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btReCont;
        private System.Windows.Forms.TabPage registro;
        private System.Windows.Forms.TextBox ctClave;
        private System.Windows.Forms.TextBox ctUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btSesion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

