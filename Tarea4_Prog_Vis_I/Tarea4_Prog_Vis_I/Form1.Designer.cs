namespace Tarea4_Prog_Vis_I
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bMenu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escalaDeGrisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tamañoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bHerr = new System.Windows.Forms.ToolStrip();
            this.HerrImgNor = new System.Windows.Forms.ToolStripButton();
            this.HerrImgEscG = new System.Windows.Forms.ToolStripButton();
            this.HerrImgCen = new System.Windows.Forms.ToolStripButton();
            this.HerrImgAju = new System.Windows.Forms.ToolStripButton();
            this.HerrImgZoom = new System.Windows.Forms.ToolStripButton();
            this.bInfo = new System.Windows.Forms.StatusStrip();
            this.lblInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbVis = new System.Windows.Forms.GroupBox();
            this.checkEscG = new System.Windows.Forms.CheckBox();
            this.checkNor = new System.Windows.Forms.CheckBox();
            this.gbTam = new System.Windows.Forms.GroupBox();
            this.rbZoom = new System.Windows.Forms.RadioButton();
            this.rbAju = new System.Windows.Forms.RadioButton();
            this.rbCen = new System.Windows.Forms.RadioButton();
            this.lblImg = new System.Windows.Forms.Label();
            this.cbImg = new System.Windows.Forms.ComboBox();
            this.btnIni = new System.Windows.Forms.Button();
            this.btnRet = new System.Windows.Forms.Button();
            this.btnAvzr = new System.Windows.Forms.Button();
            this.btnUlt = new System.Windows.Forms.Button();
            this.VisImg = new System.Windows.Forms.PictureBox();
            this.conMen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.girarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girar90GradosALaDerechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bMenu.SuspendLayout();
            this.bHerr.SuspendLayout();
            this.bInfo.SuspendLayout();
            this.gbVis.SuspendLayout();
            this.gbTam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VisImg)).BeginInit();
            this.conMen.SuspendLayout();
            this.SuspendLayout();
            // 
            // bMenu
            // 
            this.bMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.visiónToolStripMenuItem,
            this.tamañoToolStripMenuItem});
            this.bMenu.Location = new System.Drawing.Point(0, 0);
            this.bMenu.Name = "bMenu";
            this.bMenu.Size = new System.Drawing.Size(885, 28);
            this.bMenu.TabIndex = 0;
            this.bMenu.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // visiónToolStripMenuItem
            // 
            this.visiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalToolStripMenuItem,
            this.escalaDeGrisesToolStripMenuItem});
            this.visiónToolStripMenuItem.Name = "visiónToolStripMenuItem";
            this.visiónToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.visiónToolStripMenuItem.Text = "Visión";
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // escalaDeGrisesToolStripMenuItem
            // 
            this.escalaDeGrisesToolStripMenuItem.Name = "escalaDeGrisesToolStripMenuItem";
            this.escalaDeGrisesToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.escalaDeGrisesToolStripMenuItem.Text = "Escala de Grises";
            this.escalaDeGrisesToolStripMenuItem.Click += new System.EventHandler(this.escalaDeGrisesToolStripMenuItem_Click);
            // 
            // tamañoToolStripMenuItem
            // 
            this.tamañoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centradaToolStripMenuItem,
            this.ajustarToolStripMenuItem,
            this.zoomToolStripMenuItem});
            this.tamañoToolStripMenuItem.Name = "tamañoToolStripMenuItem";
            this.tamañoToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.tamañoToolStripMenuItem.Text = "Tamaño";
            // 
            // centradaToolStripMenuItem
            // 
            this.centradaToolStripMenuItem.Name = "centradaToolStripMenuItem";
            this.centradaToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.centradaToolStripMenuItem.Text = "Centrada";
            this.centradaToolStripMenuItem.Click += new System.EventHandler(this.centradaToolStripMenuItem_Click);
            // 
            // ajustarToolStripMenuItem
            // 
            this.ajustarToolStripMenuItem.Name = "ajustarToolStripMenuItem";
            this.ajustarToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.ajustarToolStripMenuItem.Text = "Ajustar";
            this.ajustarToolStripMenuItem.Click += new System.EventHandler(this.ajustarToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.zoomToolStripMenuItem.Text = "Zoom";
            this.zoomToolStripMenuItem.Click += new System.EventHandler(this.zoomToolStripMenuItem_Click);
            // 
            // bHerr
            // 
            this.bHerr.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bHerr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HerrImgNor,
            this.HerrImgEscG,
            this.HerrImgCen,
            this.HerrImgAju,
            this.HerrImgZoom});
            this.bHerr.Location = new System.Drawing.Point(0, 28);
            this.bHerr.Name = "bHerr";
            this.bHerr.Size = new System.Drawing.Size(885, 27);
            this.bHerr.TabIndex = 1;
            this.bHerr.Text = "toolStrip1";
            // 
            // HerrImgNor
            // 
            this.HerrImgNor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HerrImgNor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HerrImgNor.Image = ((System.Drawing.Image)(resources.GetObject("HerrImgNor.Image")));
            this.HerrImgNor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HerrImgNor.Name = "HerrImgNor";
            this.HerrImgNor.Size = new System.Drawing.Size(29, 24);
            this.HerrImgNor.Text = "Normal";
            this.HerrImgNor.Click += new System.EventHandler(this.HerrImgNor_Click);
            // 
            // HerrImgEscG
            // 
            this.HerrImgEscG.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HerrImgEscG.Image = global::Tarea4_Prog_Vis_I.Properties.Resources.istockphoto_1302508560_612x612;
            this.HerrImgEscG.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HerrImgEscG.Name = "HerrImgEscG";
            this.HerrImgEscG.Size = new System.Drawing.Size(29, 24);
            this.HerrImgEscG.Text = "Escala de Grises";
            this.HerrImgEscG.Click += new System.EventHandler(this.HerrImgEscG_Click);
            // 
            // HerrImgCen
            // 
            this.HerrImgCen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HerrImgCen.Image = global::Tarea4_Prog_Vis_I.Properties.Resources._1256150;
            this.HerrImgCen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HerrImgCen.Name = "HerrImgCen";
            this.HerrImgCen.Size = new System.Drawing.Size(29, 24);
            this.HerrImgCen.Text = "Centrada";
            this.HerrImgCen.Click += new System.EventHandler(this.HerrCen_Click);
            // 
            // HerrImgAju
            // 
            this.HerrImgAju.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HerrImgAju.Image = global::Tarea4_Prog_Vis_I.Properties.Resources._80998;
            this.HerrImgAju.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HerrImgAju.Name = "HerrImgAju";
            this.HerrImgAju.Size = new System.Drawing.Size(29, 24);
            this.HerrImgAju.Text = "Ajustada";
            this.HerrImgAju.Click += new System.EventHandler(this.HerrImgAju_Click);
            // 
            // HerrImgZoom
            // 
            this.HerrImgZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HerrImgZoom.Image = global::Tarea4_Prog_Vis_I.Properties.Resources.istockphoto_1488326578_612x612;
            this.HerrImgZoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HerrImgZoom.Name = "HerrImgZoom";
            this.HerrImgZoom.Size = new System.Drawing.Size(29, 24);
            this.HerrImgZoom.Text = "Zoom";
            this.HerrImgZoom.Click += new System.EventHandler(this.HerrImgZoom_Click);
            // 
            // bInfo
            // 
            this.bInfo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblInfo});
            this.bInfo.Location = new System.Drawing.Point(0, 682);
            this.bInfo.Name = "bInfo";
            this.bInfo.Size = new System.Drawing.Size(885, 22);
            this.bInfo.TabIndex = 2;
            this.bInfo.Text = "statusStrip1";
            // 
            // lblInfo
            // 
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 16);
            // 
            // gbVis
            // 
            this.gbVis.Controls.Add(this.checkEscG);
            this.gbVis.Controls.Add(this.checkNor);
            this.gbVis.Location = new System.Drawing.Point(23, 74);
            this.gbVis.Name = "gbVis";
            this.gbVis.Size = new System.Drawing.Size(419, 100);
            this.gbVis.TabIndex = 3;
            this.gbVis.TabStop = false;
            this.gbVis.Text = "Visión";
            // 
            // checkEscG
            // 
            this.checkEscG.AutoSize = true;
            this.checkEscG.Location = new System.Drawing.Point(212, 38);
            this.checkEscG.Name = "checkEscG";
            this.checkEscG.Size = new System.Drawing.Size(132, 20);
            this.checkEscG.TabIndex = 1;
            this.checkEscG.Text = "Escala de Grises";
            this.checkEscG.UseVisualStyleBackColor = true;
            this.checkEscG.CheckedChanged += new System.EventHandler(this.checkEscG_CheckedChanged);
            // 
            // checkNor
            // 
            this.checkNor.AutoSize = true;
            this.checkNor.Location = new System.Drawing.Point(17, 38);
            this.checkNor.Name = "checkNor";
            this.checkNor.Size = new System.Drawing.Size(73, 20);
            this.checkNor.TabIndex = 0;
            this.checkNor.Text = "Normal";
            this.checkNor.UseVisualStyleBackColor = true;
            this.checkNor.CheckedChanged += new System.EventHandler(this.checkNor_CheckedChanged);
            // 
            // gbTam
            // 
            this.gbTam.Controls.Add(this.rbZoom);
            this.gbTam.Controls.Add(this.rbAju);
            this.gbTam.Controls.Add(this.rbCen);
            this.gbTam.Location = new System.Drawing.Point(497, 74);
            this.gbTam.Name = "gbTam";
            this.gbTam.Size = new System.Drawing.Size(341, 140);
            this.gbTam.TabIndex = 4;
            this.gbTam.TabStop = false;
            this.gbTam.Text = "Tamaño";
            // 
            // rbZoom
            // 
            this.rbZoom.AutoSize = true;
            this.rbZoom.Location = new System.Drawing.Point(27, 91);
            this.rbZoom.Name = "rbZoom";
            this.rbZoom.Size = new System.Drawing.Size(63, 20);
            this.rbZoom.TabIndex = 2;
            this.rbZoom.Text = "Zoom";
            this.rbZoom.UseVisualStyleBackColor = true;
            this.rbZoom.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbAju
            // 
            this.rbAju.AutoSize = true;
            this.rbAju.Location = new System.Drawing.Point(27, 64);
            this.rbAju.Name = "rbAju";
            this.rbAju.Size = new System.Drawing.Size(81, 20);
            this.rbAju.TabIndex = 1;
            this.rbAju.Text = "Ajustada";
            this.rbAju.UseVisualStyleBackColor = true;
            this.rbAju.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbCen
            // 
            this.rbCen.AutoSize = true;
            this.rbCen.Checked = true;
            this.rbCen.Location = new System.Drawing.Point(27, 37);
            this.rbCen.Name = "rbCen";
            this.rbCen.Size = new System.Drawing.Size(83, 20);
            this.rbCen.TabIndex = 0;
            this.rbCen.TabStop = true;
            this.rbCen.Text = "Centrada";
            this.rbCen.UseVisualStyleBackColor = true;
            this.rbCen.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // lblImg
            // 
            this.lblImg.AutoSize = true;
            this.lblImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImg.Location = new System.Drawing.Point(23, 181);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(96, 18);
            this.lblImg.TabIndex = 6;
            this.lblImg.Text = "ImagenActual";
            // 
            // cbImg
            // 
            this.cbImg.FormattingEnabled = true;
            this.cbImg.Location = new System.Drawing.Point(139, 181);
            this.cbImg.Name = "cbImg";
            this.cbImg.Size = new System.Drawing.Size(303, 24);
            this.cbImg.TabIndex = 7;
            this.cbImg.SelectedIndexChanged += new System.EventHandler(this.cbImg_SelectedIndexChanged);
            // 
            // btnIni
            // 
            this.btnIni.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIni.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIni.Location = new System.Drawing.Point(65, 610);
            this.btnIni.Name = "btnIni";
            this.btnIni.Size = new System.Drawing.Size(156, 47);
            this.btnIni.TabIndex = 8;
            this.btnIni.Text = "<<";
            this.btnIni.UseVisualStyleBackColor = false;
            this.btnIni.Click += new System.EventHandler(this.btnImgIni_Click);
            // 
            // btnRet
            // 
            this.btnRet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRet.Location = new System.Drawing.Point(248, 610);
            this.btnRet.Name = "btnRet";
            this.btnRet.Size = new System.Drawing.Size(156, 47);
            this.btnRet.TabIndex = 9;
            this.btnRet.Text = "<";
            this.btnRet.UseVisualStyleBackColor = false;
            this.btnRet.Click += new System.EventHandler(this.btnImgRet_Click);
            // 
            // btnAvzr
            // 
            this.btnAvzr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAvzr.Location = new System.Drawing.Point(431, 610);
            this.btnAvzr.Name = "btnAvzr";
            this.btnAvzr.Size = new System.Drawing.Size(156, 47);
            this.btnAvzr.TabIndex = 10;
            this.btnAvzr.Text = ">";
            this.btnAvzr.UseVisualStyleBackColor = false;
            this.btnAvzr.Click += new System.EventHandler(this.btnImgAvzr_Click);
            // 
            // btnUlt
            // 
            this.btnUlt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUlt.Location = new System.Drawing.Point(625, 610);
            this.btnUlt.Name = "btnUlt";
            this.btnUlt.Size = new System.Drawing.Size(156, 47);
            this.btnUlt.TabIndex = 11;
            this.btnUlt.Text = ">>";
            this.btnUlt.UseVisualStyleBackColor = false;
            this.btnUlt.Click += new System.EventHandler(this.btnImgUlt_Click);
            // 
            // VisImg
            // 
            this.VisImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VisImg.Location = new System.Drawing.Point(23, 220);
            this.VisImg.Name = "VisImg";
            this.VisImg.Size = new System.Drawing.Size(815, 370);
            this.VisImg.TabIndex = 5;
            this.VisImg.TabStop = false;
            this.VisImg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.VisImg_MouseClick);
            // 
            // conMen
            // 
            this.conMen.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.conMen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girarToolStripMenuItem,
            this.girar90GradosALaDerechaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.copiarToolStripMenuItem});
            this.conMen.Name = "conMen";
            this.conMen.Size = new System.Drawing.Size(275, 82);
            // 
            // girarToolStripMenuItem
            // 
            this.girarToolStripMenuItem.Name = "girarToolStripMenuItem";
            this.girarToolStripMenuItem.Size = new System.Drawing.Size(274, 24);
            this.girarToolStripMenuItem.Text = "Girar 90 grados a la izquierda";
            this.girarToolStripMenuItem.Click += new System.EventHandler(this.girarToolStripMenuItem_Click);
            // 
            // girar90GradosALaDerechaToolStripMenuItem
            // 
            this.girar90GradosALaDerechaToolStripMenuItem.Name = "girar90GradosALaDerechaToolStripMenuItem";
            this.girar90GradosALaDerechaToolStripMenuItem.Size = new System.Drawing.Size(274, 24);
            this.girar90GradosALaDerechaToolStripMenuItem.Text = "Girar 90 grados a la derecha";
            this.girar90GradosALaDerechaToolStripMenuItem.Click += new System.EventHandler(this.girar90GradosALaDerechaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(271, 6);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(274, 24);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 704);
            this.Controls.Add(this.btnUlt);
            this.Controls.Add(this.btnAvzr);
            this.Controls.Add(this.btnRet);
            this.Controls.Add(this.btnIni);
            this.Controls.Add(this.cbImg);
            this.Controls.Add(this.lblImg);
            this.Controls.Add(this.VisImg);
            this.Controls.Add(this.gbTam);
            this.Controls.Add(this.gbVis);
            this.Controls.Add(this.bInfo);
            this.Controls.Add(this.bHerr);
            this.Controls.Add(this.bMenu);
            this.MainMenuStrip = this.bMenu;
            this.Name = "Form1";
            this.Text = "Visor de Imágenes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bMenu.ResumeLayout(false);
            this.bMenu.PerformLayout();
            this.bHerr.ResumeLayout(false);
            this.bHerr.PerformLayout();
            this.bInfo.ResumeLayout(false);
            this.bInfo.PerformLayout();
            this.gbVis.ResumeLayout(false);
            this.gbVis.PerformLayout();
            this.gbTam.ResumeLayout(false);
            this.gbTam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VisImg)).EndInit();
            this.conMen.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip bMenu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tamañoToolStripMenuItem;
        private System.Windows.Forms.ToolStrip bHerr;
        private System.Windows.Forms.ToolStripButton HerrImgNor;
        private System.Windows.Forms.ToolStripButton HerrImgEscG;
        private System.Windows.Forms.ToolStripButton HerrImgCen;
        private System.Windows.Forms.ToolStripButton HerrImgAju;
        private System.Windows.Forms.ToolStripButton HerrImgZoom;
        private System.Windows.Forms.StatusStrip bInfo;
        private System.Windows.Forms.GroupBox gbVis;
        private System.Windows.Forms.GroupBox gbTam;
        private System.Windows.Forms.PictureBox VisImg;
        private System.Windows.Forms.CheckBox checkEscG;
        private System.Windows.Forms.CheckBox checkNor;
        private System.Windows.Forms.Label lblImg;
        private System.Windows.Forms.ComboBox cbImg;
        private System.Windows.Forms.Button btnIni;
        private System.Windows.Forms.Button btnRet;
        private System.Windows.Forms.Button btnAvzr;
        private System.Windows.Forms.Button btnUlt;
        private System.Windows.Forms.RadioButton rbZoom;
        private System.Windows.Forms.RadioButton rbAju;
        private System.Windows.Forms.RadioButton rbCen;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escalaDeGrisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajustarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblInfo;
        private System.Windows.Forms.ContextMenuStrip conMen;
        private System.Windows.Forms.ToolStripMenuItem girarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girar90GradosALaDerechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
    }
}

