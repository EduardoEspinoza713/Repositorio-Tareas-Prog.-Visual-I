namespace Tarea7_Prog_Vis_I
{
    partial class Form5
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
            this.ctConAct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctContN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ctContN2 = new System.Windows.Forms.TextBox();
            this.btnCam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctConAct
            // 
            this.ctConAct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctConAct.Location = new System.Drawing.Point(270, 30);
            this.ctConAct.Name = "ctConAct";
            this.ctConAct.PasswordChar = '*';
            this.ctConAct.Size = new System.Drawing.Size(256, 22);
            this.ctConAct.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escriba su contraseña actual";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Escriba su nueva contraseña";
            // 
            // ctContN
            // 
            this.ctContN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctContN.Location = new System.Drawing.Point(270, 79);
            this.ctContN.Name = "ctContN";
            this.ctContN.PasswordChar = '*';
            this.ctContN.Size = new System.Drawing.Size(256, 22);
            this.ctContN.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Repita su nueva Contraseña";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ctContN2
            // 
            this.ctContN2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctContN2.Location = new System.Drawing.Point(270, 128);
            this.ctContN2.Name = "ctContN2";
            this.ctContN2.PasswordChar = '*';
            this.ctContN2.Size = new System.Drawing.Size(256, 22);
            this.ctContN2.TabIndex = 4;
            this.ctContN2.TextChanged += new System.EventHandler(this.ctContN2_TextChanged);
            // 
            // btnCam
            // 
            this.btnCam.Location = new System.Drawing.Point(194, 175);
            this.btnCam.Name = "btnCam";
            this.btnCam.Size = new System.Drawing.Size(179, 59);
            this.btnCam.TabIndex = 6;
            this.btnCam.Text = "Cambiar";
            this.btnCam.UseVisualStyleBackColor = true;
            this.btnCam.Click += new System.EventHandler(this.btnCam_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 254);
            this.Controls.Add(this.btnCam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ctContN2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctContN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctConAct);
            this.Name = "Form5";
            this.Text = "Cambio de Contraseña";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ctConAct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ctContN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ctContN2;
        private System.Windows.Forms.Button btnCam;
    }
}