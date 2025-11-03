namespace Tarea7_Prog_Vis_I
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUs = new System.Windows.Forms.Label();
            this.lblContra = new System.Windows.Forms.Label();
            this.ctUs = new System.Windows.Forms.TextBox();
            this.ctContra = new System.Windows.Forms.TextBox();
            this.btIniSes = new System.Windows.Forms.Button();
            this.btCan = new System.Windows.Forms.Button();
            this.ctNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Tarea7_Prog_Vis_I.Properties.Resources._43cc80b4c098e43a988c535eaba42c53_icono_de_usuario_de_persona;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(270, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Size = new System.Drawing.Size(151, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblUs
            // 
            this.lblUs.AutoSize = true;
            this.lblUs.Location = new System.Drawing.Point(124, 274);
            this.lblUs.Name = "lblUs";
            this.lblUs.Size = new System.Drawing.Size(54, 16);
            this.lblUs.TabIndex = 1;
            this.lblUs.Text = "Usuario";
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Location = new System.Drawing.Point(127, 316);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(76, 16);
            this.lblContra.TabIndex = 2;
            this.lblContra.Text = "Contraseña";
            // 
            // ctUs
            // 
            this.ctUs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctUs.Location = new System.Drawing.Point(213, 274);
            this.ctUs.Name = "ctUs";
            this.ctUs.Size = new System.Drawing.Size(288, 22);
            this.ctUs.TabIndex = 3;
            // 
            // ctContra
            // 
            this.ctContra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctContra.Location = new System.Drawing.Point(213, 316);
            this.ctContra.Name = "ctContra";
            this.ctContra.PasswordChar = '*';
            this.ctContra.Size = new System.Drawing.Size(288, 22);
            this.ctContra.TabIndex = 4;
            // 
            // btIniSes
            // 
            this.btIniSes.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btIniSes.Location = new System.Drawing.Point(193, 369);
            this.btIniSes.Name = "btIniSes";
            this.btIniSes.Size = new System.Drawing.Size(121, 59);
            this.btIniSes.TabIndex = 5;
            this.btIniSes.Text = "Iniciar sesión";
            this.btIniSes.UseVisualStyleBackColor = false;
            this.btIniSes.Click += new System.EventHandler(this.btIniSes_Click);
            // 
            // btCan
            // 
            this.btCan.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btCan.Location = new System.Drawing.Point(369, 369);
            this.btCan.Name = "btCan";
            this.btCan.Size = new System.Drawing.Size(121, 59);
            this.btCan.TabIndex = 6;
            this.btCan.Text = "Cancelar";
            this.btCan.UseVisualStyleBackColor = false;
            this.btCan.Click += new System.EventHandler(this.btCan_Click);
            // 
            // ctNom
            // 
            this.ctNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctNom.Location = new System.Drawing.Point(213, 229);
            this.ctNom.Name = "ctNom";
            this.ctNom.Size = new System.Drawing.Size(288, 22);
            this.ctNom.TabIndex = 9;
            this.ctNom.Visible = false;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(124, 229);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(56, 16);
            this.lblNom.TabIndex = 8;
            this.lblNom.Text = "Nombre";
            this.lblNom.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(241, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Inicio de Sesión";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ctNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btCan);
            this.Controls.Add(this.btIniSes);
            this.Controls.Add(this.ctContra);
            this.Controls.Add(this.ctUs);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.lblUs);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUs;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.TextBox ctUs;
        private System.Windows.Forms.TextBox ctContra;
        private System.Windows.Forms.Button btIniSes;
        private System.Windows.Forms.Button btCan;
        private System.Windows.Forms.TextBox ctNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label label4;
    }
}

