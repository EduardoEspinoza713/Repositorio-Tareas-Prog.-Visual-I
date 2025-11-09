<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.lbl_IDP = New System.Windows.Forms.Label()
        Me.lbl_NomP = New System.Windows.Forms.Label()
        Me.btnFP = New System.Windows.Forms.Button()
        Me.ctIDP = New System.Windows.Forms.TextBox()
        Me.ctNomP = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(85, 53)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(635, 229)
        Me.DataGridView1.TabIndex = 0
        '
        'lbl_IDP
        '
        Me.lbl_IDP.AutoSize = True
        Me.lbl_IDP.Location = New System.Drawing.Point(85, 333)
        Me.lbl_IDP.Name = "lbl_IDP"
        Me.lbl_IDP.Size = New System.Drawing.Size(87, 16)
        Me.lbl_IDP.TabIndex = 1
        Me.lbl_IDP.Text = "ID Proveedor"
        '
        'lbl_NomP
        '
        Me.lbl_NomP.AutoSize = True
        Me.lbl_NomP.Location = New System.Drawing.Point(85, 369)
        Me.lbl_NomP.Name = "lbl_NomP"
        Me.lbl_NomP.Size = New System.Drawing.Size(113, 16)
        Me.lbl_NomP.TabIndex = 2
        Me.lbl_NomP.Text = "Nombre Producto"
        '
        'btnFP
        '
        Me.btnFP.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnFP.Location = New System.Drawing.Point(88, 403)
        Me.btnFP.Name = "btnFP"
        Me.btnFP.Size = New System.Drawing.Size(632, 35)
        Me.btnFP.TabIndex = 3
        Me.btnFP.Text = "Filtrar por producto"
        Me.btnFP.UseVisualStyleBackColor = False
        '
        'ctIDP
        '
        Me.ctIDP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ctIDP.Location = New System.Drawing.Point(201, 327)
        Me.ctIDP.Name = "ctIDP"
        Me.ctIDP.Size = New System.Drawing.Size(440, 22)
        Me.ctIDP.TabIndex = 4
        '
        'ctNomP
        '
        Me.ctNomP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ctNomP.Location = New System.Drawing.Point(201, 363)
        Me.ctNomP.Name = "ctNomP"
        Me.ctNomP.Size = New System.Drawing.Size(440, 22)
        Me.ctNomP.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button1.Location = New System.Drawing.Point(647, 331)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 53)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Imprimir Reporte"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ctNomP)
        Me.Controls.Add(Me.ctIDP)
        Me.Controls.Add(Me.btnFP)
        Me.Controls.Add(Me.lbl_NomP)
        Me.Controls.Add(Me.lbl_IDP)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form7"
        Me.Text = "Ganancias"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lbl_IDP As Label
    Friend WithEvents lbl_NomP As Label
    Friend WithEvents btnFP As Button
    Friend WithEvents ctIDP As TextBox
    Friend WithEvents ctNomP As TextBox
    Friend WithEvents Button1 As Button
End Class
