<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ct_nombre = New System.Windows.Forms.TextBox()
        Me.ct_descripcion = New System.Windows.Forms.TextBox()
        Me.ct_PC = New System.Windows.Forms.TextBox()
        Me.ct_PorcGan = New System.Windows.Forms.TextBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblDir = New System.Windows.Forms.Label()
        Me.lblPC = New System.Windows.Forms.Label()
        Me.lblPorcGan = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btborrar = New System.Windows.Forms.Button()
        Me.btguardar = New System.Windows.Forms.Button()
        Me.btnuevo = New System.Windows.Forms.Button()
        Me.btsalir = New System.Windows.Forms.Button()
        Me.lblProv = New System.Windows.Forms.Label()
        Me.lblSt = New System.Windows.Forms.Label()
        Me.ctSt = New System.Windows.Forms.TextBox()
        Me.lblStMin = New System.Windows.Forms.Label()
        Me.ctStMin = New System.Windows.Forms.TextBox()
        Me.cb_idproveedor = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(776, 203)
        Me.DataGridView1.TabIndex = 0
        '
        'ct_nombre
        '
        Me.ct_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ct_nombre.Location = New System.Drawing.Point(302, 288)
        Me.ct_nombre.Name = "ct_nombre"
        Me.ct_nombre.Size = New System.Drawing.Size(168, 22)
        Me.ct_nombre.TabIndex = 1
        '
        'ct_descripcion
        '
        Me.ct_descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ct_descripcion.Location = New System.Drawing.Point(302, 330)
        Me.ct_descripcion.Name = "ct_descripcion"
        Me.ct_descripcion.Size = New System.Drawing.Size(168, 22)
        Me.ct_descripcion.TabIndex = 2
        '
        'ct_PC
        '
        Me.ct_PC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ct_PC.Location = New System.Drawing.Point(302, 372)
        Me.ct_PC.Name = "ct_PC"
        Me.ct_PC.Size = New System.Drawing.Size(168, 22)
        Me.ct_PC.TabIndex = 3
        '
        'ct_PorcGan
        '
        Me.ct_PorcGan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ct_PorcGan.Location = New System.Drawing.Point(302, 416)
        Me.ct_PorcGan.Name = "ct_PorcGan"
        Me.ct_PorcGan.Size = New System.Drawing.Size(168, 22)
        Me.ct_PorcGan.TabIndex = 4
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(199, 288)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(56, 16)
        Me.lblNom.TabIndex = 6
        Me.lblNom.Text = "Nombre"
        '
        'lblDir
        '
        Me.lblDir.AutoSize = True
        Me.lblDir.Location = New System.Drawing.Point(199, 336)
        Me.lblDir.Name = "lblDir"
        Me.lblDir.Size = New System.Drawing.Size(79, 16)
        Me.lblDir.TabIndex = 7
        Me.lblDir.Text = "Descripción"
        '
        'lblPC
        '
        Me.lblPC.AutoSize = True
        Me.lblPC.Location = New System.Drawing.Point(199, 378)
        Me.lblPC.Name = "lblPC"
        Me.lblPC.Size = New System.Drawing.Size(97, 16)
        Me.lblPC.TabIndex = 8
        Me.lblPC.Text = "Precio Compra"
        '
        'lblPorcGan
        '
        Me.lblPorcGan.AutoSize = True
        Me.lblPorcGan.Location = New System.Drawing.Point(199, 422)
        Me.lblPorcGan.Name = "lblPorcGan"
        Me.lblPorcGan.Size = New System.Drawing.Size(73, 16)
        Me.lblPorcGan.TabIndex = 9
        Me.lblPorcGan.Text = "% Ganacia"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btborrar)
        Me.GroupBox1.Controls.Add(Me.btguardar)
        Me.GroupBox1.Controls.Add(Me.btnuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(560, 302)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 150)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'btborrar
        '
        Me.btborrar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btborrar.Location = New System.Drawing.Point(87, 114)
        Me.btborrar.Name = "btborrar"
        Me.btborrar.Size = New System.Drawing.Size(75, 23)
        Me.btborrar.TabIndex = 2
        Me.btborrar.Text = "Borrar"
        Me.btborrar.UseVisualStyleBackColor = False
        '
        'btguardar
        '
        Me.btguardar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btguardar.Location = New System.Drawing.Point(87, 74)
        Me.btguardar.Name = "btguardar"
        Me.btguardar.Size = New System.Drawing.Size(75, 23)
        Me.btguardar.TabIndex = 5
        Me.btguardar.Text = "Guardar"
        Me.btguardar.UseVisualStyleBackColor = False
        '
        'btnuevo
        '
        Me.btnuevo.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnuevo.Location = New System.Drawing.Point(87, 32)
        Me.btnuevo.Name = "btnuevo"
        Me.btnuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnuevo.TabIndex = 0
        Me.btnuevo.Text = "Nuevo"
        Me.btnuevo.UseVisualStyleBackColor = False
        '
        'btsalir
        '
        Me.btsalir.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btsalir.Location = New System.Drawing.Point(647, 458)
        Me.btsalir.Name = "btsalir"
        Me.btsalir.Size = New System.Drawing.Size(75, 23)
        Me.btsalir.TabIndex = 3
        Me.btsalir.Text = "Salir"
        Me.btsalir.UseVisualStyleBackColor = False
        '
        'lblProv
        '
        Me.lblProv.AutoSize = True
        Me.lblProv.Location = New System.Drawing.Point(202, 246)
        Me.lblProv.Name = "lblProv"
        Me.lblProv.Size = New System.Drawing.Size(87, 16)
        Me.lblProv.TabIndex = 11
        Me.lblProv.Text = "ID Proveedor"
        '
        'lblSt
        '
        Me.lblSt.AutoSize = True
        Me.lblSt.Location = New System.Drawing.Point(199, 465)
        Me.lblSt.Name = "lblSt"
        Me.lblSt.Size = New System.Drawing.Size(41, 16)
        Me.lblSt.TabIndex = 13
        Me.lblSt.Text = "Stock"
        '
        'ctSt
        '
        Me.ctSt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ctSt.Location = New System.Drawing.Point(302, 463)
        Me.ctSt.Name = "ctSt"
        Me.ctSt.Size = New System.Drawing.Size(168, 22)
        Me.ctSt.TabIndex = 12
        '
        'lblStMin
        '
        Me.lblStMin.AutoSize = True
        Me.lblStMin.Location = New System.Drawing.Point(199, 512)
        Me.lblStMin.Name = "lblStMin"
        Me.lblStMin.Size = New System.Drawing.Size(87, 16)
        Me.lblStMin.TabIndex = 15
        Me.lblStMin.Text = "Stock Mínimo"
        '
        'ctStMin
        '
        Me.ctStMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ctStMin.Location = New System.Drawing.Point(302, 510)
        Me.ctStMin.Name = "ctStMin"
        Me.ctStMin.Size = New System.Drawing.Size(168, 22)
        Me.ctStMin.TabIndex = 14
        '
        'cb_idproveedor
        '
        Me.cb_idproveedor.FormattingEnabled = True
        Me.cb_idproveedor.Location = New System.Drawing.Point(302, 246)
        Me.cb_idproveedor.Name = "cb_idproveedor"
        Me.cb_idproveedor.Size = New System.Drawing.Size(168, 24)
        Me.cb_idproveedor.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button1.Location = New System.Drawing.Point(647, 497)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Imprimir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(800, 567)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cb_idproveedor)
        Me.Controls.Add(Me.btsalir)
        Me.Controls.Add(Me.lblStMin)
        Me.Controls.Add(Me.ctStMin)
        Me.Controls.Add(Me.lblSt)
        Me.Controls.Add(Me.ctSt)
        Me.Controls.Add(Me.lblProv)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblPorcGan)
        Me.Controls.Add(Me.lblPC)
        Me.Controls.Add(Me.lblDir)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.ct_PorcGan)
        Me.Controls.Add(Me.ct_PC)
        Me.Controls.Add(Me.ct_descripcion)
        Me.Controls.Add(Me.ct_nombre)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ct_nombre As TextBox
    Friend WithEvents ct_descripcion As TextBox
    Friend WithEvents ct_PC As TextBox
    Friend WithEvents ct_PorcGan As TextBox
    Friend WithEvents lblNom As Label
    Friend WithEvents lblDir As Label
    Friend WithEvents lblPC As Label
    Friend WithEvents lblPorcGan As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btsalir As Button
    Friend WithEvents btborrar As Button
    Friend WithEvents btguardar As Button
    Friend WithEvents btnuevo As Button
    Friend WithEvents lblProv As Label
    Friend WithEvents lblSt As Label
    Friend WithEvents ctSt As TextBox
    Friend WithEvents lblStMin As Label
    Friend WithEvents ctStMin As TextBox
    Friend WithEvents cb_idproveedor As ComboBox
    Friend WithEvents Button1 As Button
End Class
