<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblUs = New System.Windows.Forms.Label()
        Me.ctUs = New System.Windows.Forms.TextBox()
        Me.ctContra = New System.Windows.Forms.TextBox()
        Me.lblContra = New System.Windows.Forms.Label()
        Me.lblRol = New System.Windows.Forms.Label()
        Me.cbRol = New System.Windows.Forms.ComboBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnSal = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(88, 20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(620, 223)
        Me.DataGridView1.TabIndex = 0
        '
        'lblUs
        '
        Me.lblUs.AutoSize = True
        Me.lblUs.Location = New System.Drawing.Point(88, 284)
        Me.lblUs.Name = "lblUs"
        Me.lblUs.Size = New System.Drawing.Size(125, 16)
        Me.lblUs.TabIndex = 1
        Me.lblUs.Text = "Nombre de Usuario"
        '
        'ctUs
        '
        Me.ctUs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ctUs.Location = New System.Drawing.Point(219, 284)
        Me.ctUs.Name = "ctUs"
        Me.ctUs.Size = New System.Drawing.Size(326, 22)
        Me.ctUs.TabIndex = 2
        '
        'ctContra
        '
        Me.ctContra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ctContra.Location = New System.Drawing.Point(219, 336)
        Me.ctContra.Name = "ctContra"
        Me.ctContra.Size = New System.Drawing.Size(326, 22)
        Me.ctContra.TabIndex = 4
        '
        'lblContra
        '
        Me.lblContra.AutoSize = True
        Me.lblContra.Location = New System.Drawing.Point(88, 336)
        Me.lblContra.Name = "lblContra"
        Me.lblContra.Size = New System.Drawing.Size(76, 16)
        Me.lblContra.TabIndex = 3
        Me.lblContra.Text = "Contraseña"
        '
        'lblRol
        '
        Me.lblRol.AutoSize = True
        Me.lblRol.Location = New System.Drawing.Point(88, 392)
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Size = New System.Drawing.Size(28, 16)
        Me.lblRol.TabIndex = 5
        Me.lblRol.Text = "Rol"
        '
        'cbRol
        '
        Me.cbRol.FormattingEnabled = True
        Me.cbRol.Items.AddRange(New Object() {"administrador", "vendedor"})
        Me.cbRol.Location = New System.Drawing.Point(219, 392)
        Me.cbRol.Name = "cbRol"
        Me.cbRol.Size = New System.Drawing.Size(326, 24)
        Me.cbRol.TabIndex = 6
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnNuevo.Location = New System.Drawing.Point(633, 277)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 7
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnGuardar.Location = New System.Drawing.Point(633, 326)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnBorrar.Location = New System.Drawing.Point(633, 369)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 9
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'btnSal
        '
        Me.btnSal.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnSal.Location = New System.Drawing.Point(633, 408)
        Me.btnSal.Name = "btnSal"
        Me.btnSal.Size = New System.Drawing.Size(75, 23)
        Me.btnSal.TabIndex = 10
        Me.btnSal.Text = "Salir"
        Me.btnSal.UseVisualStyleBackColor = False
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSal)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.cbRol)
        Me.Controls.Add(Me.lblRol)
        Me.Controls.Add(Me.ctContra)
        Me.Controls.Add(Me.lblContra)
        Me.Controls.Add(Me.ctUs)
        Me.Controls.Add(Me.lblUs)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form8"
        Me.Text = "Administrar Usuarios"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblUs As Label
    Friend WithEvents ctUs As TextBox
    Friend WithEvents ctContra As TextBox
    Friend WithEvents lblContra As Label
    Friend WithEvents lblRol As Label
    Friend WithEvents cbRol As ComboBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnSal As Button
End Class
