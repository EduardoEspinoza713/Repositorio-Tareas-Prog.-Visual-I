namespace Tarea3_Prog_Vis_I
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
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblLugar = new System.Windows.Forms.Label();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.titulo = new System.Windows.Forms.Label();
            this.cuadroBus = new System.Windows.Forms.GroupBox();
            this.cmbBusEst = new System.Windows.Forms.ComboBox();
            this.checkFecha = new System.Windows.Forms.CheckBox();
            this.dtpBusFMax = new System.Windows.Forms.DateTimePicker();
            this.dtpBusFMin = new System.Windows.Forms.DateTimePicker();
            this.lblBusF3 = new System.Windows.Forms.Label();
            this.lblBusF2 = new System.Windows.Forms.Label();
            this.lblBusF = new System.Windows.Forms.Label();
            this.lblBusEst = new System.Windows.Forms.Label();
            this.txtBusCod = new System.Windows.Forms.TextBox();
            this.lblBusCod = new System.Windows.Forms.Label();
            this.btnBus = new System.Windows.Forms.Button();
            this.limpVisor = new System.Windows.Forms.Button();
            this.limpT = new System.Windows.Forms.Button();
            this.limpC = new System.Windows.Forms.Button();
            this.limpCBus = new System.Windows.Forms.Button();
            this.VisorTitulo = new System.Windows.Forms.Label();
            this.btnMTodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.cuadroBus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(13, 49);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(51, 16);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Location = new System.Drawing.Point(154, 46);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(215, 22);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 84);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(154, 84);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(215, 22);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(13, 125);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(79, 16);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(154, 119);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(215, 22);
            this.txtDescripcion.TabIndex = 5;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(13, 159);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(132, 16);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha de realización";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Location = new System.Drawing.Point(154, 159);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(215, 22);
            this.dtpFecha.TabIndex = 7;
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(13, 198);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(41, 16);
            this.lblLugar.TabIndex = 8;
            this.lblLugar.Text = "Lugar";
            // 
            // txtLugar
            // 
            this.txtLugar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLugar.Enabled = false;
            this.txtLugar.Location = new System.Drawing.Point(154, 198);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(215, 22);
            this.txtLugar.TabIndex = 9;
            this.txtLugar.TextChanged += new System.EventHandler(this.txtLugar_TextChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(11, 237);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(50, 16);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.Enabled = false;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "No realizada",
            "En Proceso",
            "Terminada"});
            this.cmbEstado.Location = new System.Drawing.Point(154, 237);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(215, 24);
            this.cmbEstado.TabIndex = 11;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(14, 282);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(89, 34);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar Tarea";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(109, 282);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(89, 33);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar Tarea";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(204, 282);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 35);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar Tarea";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvTareas
            // 
            this.dgvTareas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTareas.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Location = new System.Drawing.Point(419, 26);
            this.dgvTareas.MultiSelect = false;
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.RowHeadersWidth = 51;
            this.dgvTareas.RowTemplate.Height = 24;
            this.dgvTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTareas.Size = new System.Drawing.Size(471, 396);
            this.dgvTareas.TabIndex = 15;
            this.dgvTareas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTareas_CellClick);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Jokerman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(102, 4);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(179, 26);
            this.titulo.TabIndex = 16;
            this.titulo.Text = "Gestor de Tareas";
            // 
            // cuadroBus
            // 
            this.cuadroBus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cuadroBus.Controls.Add(this.cmbBusEst);
            this.cuadroBus.Controls.Add(this.checkFecha);
            this.cuadroBus.Controls.Add(this.dtpBusFMax);
            this.cuadroBus.Controls.Add(this.dtpBusFMin);
            this.cuadroBus.Controls.Add(this.lblBusF3);
            this.cuadroBus.Controls.Add(this.lblBusF2);
            this.cuadroBus.Controls.Add(this.lblBusF);
            this.cuadroBus.Controls.Add(this.lblBusEst);
            this.cuadroBus.Controls.Add(this.txtBusCod);
            this.cuadroBus.Controls.Add(this.lblBusCod);
            this.cuadroBus.Enabled = false;
            this.cuadroBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuadroBus.Location = new System.Drawing.Point(14, 322);
            this.cuadroBus.Name = "cuadroBus";
            this.cuadroBus.Size = new System.Drawing.Size(355, 209);
            this.cuadroBus.TabIndex = 17;
            this.cuadroBus.TabStop = false;
            this.cuadroBus.Text = "Cuadro De Búsqueda";
            // 
            // cmbBusEst
            // 
            this.cmbBusEst.FormattingEnabled = true;
            this.cmbBusEst.Items.AddRange(new object[] {
            "No realizada",
            "En Proceso",
            "Terminada"});
            this.cmbBusEst.Location = new System.Drawing.Point(161, 66);
            this.cmbBusEst.Name = "cmbBusEst";
            this.cmbBusEst.Size = new System.Drawing.Size(178, 26);
            this.cmbBusEst.TabIndex = 10;
            this.cmbBusEst.SelectedIndexChanged += new System.EventHandler(this.cmbBusEst_SelectedIndexChanged);
            // 
            // checkFecha
            // 
            this.checkFecha.AutoSize = true;
            this.checkFecha.Location = new System.Drawing.Point(161, 107);
            this.checkFecha.Name = "checkFecha";
            this.checkFecha.Size = new System.Drawing.Size(151, 22);
            this.checkFecha.TabIndex = 9;
            this.checkFecha.Text = "Habilitar Campo";
            this.checkFecha.UseVisualStyleBackColor = true;
            this.checkFecha.CheckedChanged += new System.EventHandler(this.checkFecha_CheckedChanged);
            // 
            // dtpBusFMax
            // 
            this.dtpBusFMax.Enabled = false;
            this.dtpBusFMax.Location = new System.Drawing.Point(161, 168);
            this.dtpBusFMax.Name = "dtpBusFMax";
            this.dtpBusFMax.Size = new System.Drawing.Size(178, 24);
            this.dtpBusFMax.TabIndex = 8;
            // 
            // dtpBusFMin
            // 
            this.dtpBusFMin.Enabled = false;
            this.dtpBusFMin.Location = new System.Drawing.Point(161, 133);
            this.dtpBusFMin.Name = "dtpBusFMin";
            this.dtpBusFMin.Size = new System.Drawing.Size(178, 24);
            this.dtpBusFMin.TabIndex = 7;
            // 
            // lblBusF3
            // 
            this.lblBusF3.AutoSize = true;
            this.lblBusF3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusF3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBusF3.Location = new System.Drawing.Point(38, 176);
            this.lblBusF3.Name = "lblBusF3";
            this.lblBusF3.Size = new System.Drawing.Size(74, 16);
            this.lblBusF3.TabIndex = 6;
            this.lblBusF3.Text = "y la fecha";
            // 
            // lblBusF2
            // 
            this.lblBusF2.AutoSize = true;
            this.lblBusF2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusF2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBusF2.Location = new System.Drawing.Point(38, 141);
            this.lblBusF2.Name = "lblBusF2";
            this.lblBusF2.Size = new System.Drawing.Size(102, 16);
            this.lblBusF2.TabIndex = 5;
            this.lblBusF2.Text = "Entre la fecha";
            // 
            // lblBusF
            // 
            this.lblBusF.AutoSize = true;
            this.lblBusF.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBusF.Location = new System.Drawing.Point(18, 116);
            this.lblBusF.Name = "lblBusF";
            this.lblBusF.Size = new System.Drawing.Size(93, 16);
            this.lblBusF.TabIndex = 4;
            this.lblBusF.Text = "Según fecha";
            // 
            // lblBusEst
            // 
            this.lblBusEst.AutoSize = true;
            this.lblBusEst.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusEst.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBusEst.Location = new System.Drawing.Point(18, 75);
            this.lblBusEst.Name = "lblBusEst";
            this.lblBusEst.Size = new System.Drawing.Size(103, 16);
            this.lblBusEst.TabIndex = 2;
            this.lblBusEst.Text = "Según estado";
            // 
            // txtBusCod
            // 
            this.txtBusCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusCod.Location = new System.Drawing.Point(161, 34);
            this.txtBusCod.Name = "txtBusCod";
            this.txtBusCod.Size = new System.Drawing.Size(178, 24);
            this.txtBusCod.TabIndex = 1;
            this.txtBusCod.TextChanged += new System.EventHandler(this.txtBusCod_TextChanged);
            // 
            // lblBusCod
            // 
            this.lblBusCod.AutoSize = true;
            this.lblBusCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusCod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBusCod.Location = new System.Drawing.Point(18, 34);
            this.lblBusCod.Name = "lblBusCod";
            this.lblBusCod.Size = new System.Drawing.Size(103, 16);
            this.lblBusCod.TabIndex = 0;
            this.lblBusCod.Text = "Según código";
            // 
            // btnBus
            // 
            this.btnBus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBus.Enabled = false;
            this.btnBus.Location = new System.Drawing.Point(16, 537);
            this.btnBus.Name = "btnBus";
            this.btnBus.Size = new System.Drawing.Size(119, 37);
            this.btnBus.TabIndex = 18;
            this.btnBus.Text = "BUSCAR";
            this.btnBus.UseVisualStyleBackColor = false;
            this.btnBus.Click += new System.EventHandler(this.btnBus_Click);
            // 
            // limpVisor
            // 
            this.limpVisor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.limpVisor.Location = new System.Drawing.Point(581, 455);
            this.limpVisor.Name = "limpVisor";
            this.limpVisor.Size = new System.Drawing.Size(145, 59);
            this.limpVisor.TabIndex = 19;
            this.limpVisor.Text = "Limpiar Visor de Datos";
            this.limpVisor.UseVisualStyleBackColor = false;
            this.limpVisor.Click += new System.EventHandler(this.limpVisor_Click);
            // 
            // limpT
            // 
            this.limpT.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.limpT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.limpT.Location = new System.Drawing.Point(431, 455);
            this.limpT.Name = "limpT";
            this.limpT.Size = new System.Drawing.Size(144, 59);
            this.limpT.TabIndex = 20;
            this.limpT.Text = "Limpiar Todo";
            this.limpT.UseVisualStyleBackColor = false;
            this.limpT.Click += new System.EventHandler(this.limpT_Click);
            // 
            // limpC
            // 
            this.limpC.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.limpC.Location = new System.Drawing.Point(299, 282);
            this.limpC.Name = "limpC";
            this.limpC.Size = new System.Drawing.Size(70, 35);
            this.limpC.TabIndex = 21;
            this.limpC.Text = "Limpiar Campos";
            this.limpC.UseVisualStyleBackColor = false;
            this.limpC.Click += new System.EventHandler(this.limpC_Click);
            // 
            // limpCBus
            // 
            this.limpCBus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.limpCBus.Enabled = false;
            this.limpCBus.Location = new System.Drawing.Point(250, 537);
            this.limpCBus.Name = "limpCBus";
            this.limpCBus.Size = new System.Drawing.Size(119, 37);
            this.limpCBus.TabIndex = 22;
            this.limpCBus.Text = "LIMPIAR";
            this.limpCBus.UseVisualStyleBackColor = false;
            this.limpCBus.Click += new System.EventHandler(this.limpCBus_Click);
            // 
            // VisorTitulo
            // 
            this.VisorTitulo.AutoSize = true;
            this.VisorTitulo.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisorTitulo.Location = new System.Drawing.Point(591, 3);
            this.VisorTitulo.Name = "VisorTitulo";
            this.VisorTitulo.Size = new System.Drawing.Size(123, 20);
            this.VisorTitulo.TabIndex = 23;
            this.VisorTitulo.Text = "Visor de datos";
            // 
            // btnMTodo
            // 
            this.btnMTodo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMTodo.Location = new System.Drawing.Point(732, 455);
            this.btnMTodo.Name = "btnMTodo";
            this.btnMTodo.Size = new System.Drawing.Size(145, 59);
            this.btnMTodo.TabIndex = 24;
            this.btnMTodo.Text = "Mostrar todos los Datos";
            this.btnMTodo.UseVisualStyleBackColor = false;
            this.btnMTodo.Click += new System.EventHandler(this.btnMTodo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 586);
            this.Controls.Add(this.btnMTodo);
            this.Controls.Add(this.VisorTitulo);
            this.Controls.Add(this.limpCBus);
            this.Controls.Add(this.limpC);
            this.Controls.Add(this.limpT);
            this.Controls.Add(this.limpVisor);
            this.Controls.Add(this.btnBus);
            this.Controls.Add(this.cuadroBus);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.dgvTareas);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtLugar);
            this.Controls.Add(this.lblLugar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblcodigo);
            this.Name = "Form1";
            this.Text = "Gestor de Tareas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.cuadroBus.ResumeLayout(false);
            this.cuadroBus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.GroupBox cuadroBus;
        private System.Windows.Forms.Button btnBus;
        private System.Windows.Forms.Label lblBusF;
        private System.Windows.Forms.Label lblBusEst;
        private System.Windows.Forms.TextBox txtBusCod;
        private System.Windows.Forms.Label lblBusCod;
        private System.Windows.Forms.DateTimePicker dtpBusFMin;
        private System.Windows.Forms.Label lblBusF3;
        private System.Windows.Forms.Label lblBusF2;
        private System.Windows.Forms.DateTimePicker dtpBusFMax;
        private System.Windows.Forms.CheckBox checkFecha;
        private System.Windows.Forms.ComboBox cmbBusEst;
        private System.Windows.Forms.Button limpVisor;
        private System.Windows.Forms.Button limpT;
        private System.Windows.Forms.Button limpC;
        private System.Windows.Forms.Button limpCBus;
        private System.Windows.Forms.Label VisorTitulo;
        private System.Windows.Forms.Button btnMTodo;
    }
}

