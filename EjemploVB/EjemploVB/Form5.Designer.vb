<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
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
        Me.ct_idCliente = New System.Windows.Forms.TextBox()
        Me.ct_nombre = New System.Windows.Forms.TextBox()
        Me.ct_direccion = New System.Windows.Forms.TextBox()
        Me.ct_telefono = New System.Windows.Forms.TextBox()
        Me.ct_correo = New System.Windows.Forms.TextBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblDir = New System.Windows.Forms.Label()
        Me.lblTelf = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btsalir = New System.Windows.Forms.Button()
        Me.btborrar = New System.Windows.Forms.Button()
        Me.btguardar = New System.Windows.Forms.Button()
        Me.btnuevo = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(92, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(581, 203)
        Me.DataGridView1.TabIndex = 0
        '
        'ct_idCliente
        '
        Me.ct_idCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ct_idCliente.Location = New System.Drawing.Point(302, 247)
        Me.ct_idCliente.Name = "ct_idCliente"
        Me.ct_idCliente.Size = New System.Drawing.Size(168, 22)
        Me.ct_idCliente.TabIndex = 1
        Me.ct_idCliente.Visible = False
        '
        'ct_nombre
        '
        Me.ct_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ct_nombre.Location = New System.Drawing.Point(302, 288)
        Me.ct_nombre.Name = "ct_nombre"
        Me.ct_nombre.Size = New System.Drawing.Size(168, 22)
        Me.ct_nombre.TabIndex = 1
        '
        'ct_direccion
        '
        Me.ct_direccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ct_direccion.Location = New System.Drawing.Point(302, 330)
        Me.ct_direccion.Name = "ct_direccion"
        Me.ct_direccion.Size = New System.Drawing.Size(168, 22)
        Me.ct_direccion.TabIndex = 2
        '
        'ct_telefono
        '
        Me.ct_telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ct_telefono.Location = New System.Drawing.Point(302, 372)
        Me.ct_telefono.Name = "ct_telefono"
        Me.ct_telefono.Size = New System.Drawing.Size(168, 22)
        Me.ct_telefono.TabIndex = 3
        '
        'ct_correo
        '
        Me.ct_correo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ct_correo.Location = New System.Drawing.Point(302, 416)
        Me.ct_correo.Name = "ct_correo"
        Me.ct_correo.Size = New System.Drawing.Size(168, 22)
        Me.ct_correo.TabIndex = 4
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
        Me.lblDir.Size = New System.Drawing.Size(64, 16)
        Me.lblDir.TabIndex = 7
        Me.lblDir.Text = "Dirección"
        '
        'lblTelf
        '
        Me.lblTelf.AutoSize = True
        Me.lblTelf.Location = New System.Drawing.Point(199, 378)
        Me.lblTelf.Name = "lblTelf"
        Me.lblTelf.Size = New System.Drawing.Size(61, 16)
        Me.lblTelf.TabIndex = 8
        Me.lblTelf.Text = "Telefono"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(199, 422)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(48, 16)
        Me.lblCorreo.TabIndex = 9
        Me.lblCorreo.Text = "Correo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btborrar)
        Me.GroupBox1.Controls.Add(Me.btguardar)
        Me.GroupBox1.Controls.Add(Me.btnuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(519, 246)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 148)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'btsalir
        '
        Me.btsalir.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btsalir.Location = New System.Drawing.Point(606, 400)
        Me.btsalir.Name = "btsalir"
        Me.btsalir.Size = New System.Drawing.Size(75, 23)
        Me.btsalir.TabIndex = 3
        Me.btsalir.Text = "Salir"
        Me.btsalir.UseVisualStyleBackColor = False
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
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(800, 475)
        Me.Controls.Add(Me.btsalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.lblTelf)
        Me.Controls.Add(Me.lblDir)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.ct_correo)
        Me.Controls.Add(Me.ct_telefono)
        Me.Controls.Add(Me.ct_direccion)
        Me.Controls.Add(Me.ct_nombre)
        Me.Controls.Add(Me.ct_idCliente)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ct_idCliente As TextBox
    Friend WithEvents ct_nombre As TextBox
    Friend WithEvents ct_direccion As TextBox
    Friend WithEvents ct_telefono As TextBox
    Friend WithEvents ct_correo As TextBox
    Friend WithEvents lblNom As Label
    Friend WithEvents lblDir As Label
    Friend WithEvents lblTelf As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btsalir As Button
    Friend WithEvents btborrar As Button
    Friend WithEvents btguardar As Button
    Friend WithEvents btnuevo As Button
End Class
