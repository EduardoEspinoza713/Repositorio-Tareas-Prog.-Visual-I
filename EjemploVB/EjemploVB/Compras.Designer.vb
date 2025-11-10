<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Compras
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbProv = New System.Windows.Forms.ComboBox()
        Me.btnImp = New System.Windows.Forms.Button()
        Me.dgvComp = New System.Windows.Forms.DataGridView()
        Me.Producto = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnIngreso = New System.Windows.Forms.Button()
        Me.btnLimp = New System.Windows.Forms.Button()
        Me.numUD = New System.Windows.Forms.NumericUpDown()
        Me.lblTot = New System.Windows.Forms.Label()
        CType(Me.dgvComp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(88, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Proveedor"
        '
        'cbProv
        '
        Me.cbProv.FormattingEnabled = True
        Me.cbProv.Location = New System.Drawing.Point(30, 35)
        Me.cbProv.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbProv.Name = "cbProv"
        Me.cbProv.Size = New System.Drawing.Size(191, 24)
        Me.cbProv.TabIndex = 25
        '
        'btnImp
        '
        Me.btnImp.Location = New System.Drawing.Point(467, 317)
        Me.btnImp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnImp.Name = "btnImp"
        Me.btnImp.Size = New System.Drawing.Size(123, 32)
        Me.btnImp.TabIndex = 24
        Me.btnImp.Text = "Imprimir"
        Me.btnImp.UseVisualStyleBackColor = True
        '
        'dgvComp
        '
        Me.dgvComp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Producto, Me.Cantidad})
        Me.dgvComp.Location = New System.Drawing.Point(300, 38)
        Me.dgvComp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvComp.Name = "dgvComp"
        Me.dgvComp.RowHeadersWidth = 62
        Me.dgvComp.RowTemplate.Height = 28
        Me.dgvComp.Size = New System.Drawing.Size(537, 254)
        Me.dgvComp.TabIndex = 23
        '
        'Producto
        '
        Me.Producto.HeaderText = "Producto"
        Me.Producto.MinimumWidth = 8
        Me.Producto.Name = "Producto"
        Me.Producto.Width = 150
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 8
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 150
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "A cuanto se Compra"
        '
        'btnIngreso
        '
        Me.btnIngreso.Location = New System.Drawing.Point(30, 257)
        Me.btnIngreso.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnIngreso.Name = "btnIngreso"
        Me.btnIngreso.Size = New System.Drawing.Size(93, 35)
        Me.btnIngreso.TabIndex = 20
        Me.btnIngreso.Text = "Guardar"
        Me.btnIngreso.UseVisualStyleBackColor = True
        '
        'btnLimp
        '
        Me.btnLimp.Location = New System.Drawing.Point(155, 257)
        Me.btnLimp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLimp.Name = "btnLimp"
        Me.btnLimp.Size = New System.Drawing.Size(93, 35)
        Me.btnLimp.TabIndex = 27
        Me.btnLimp.Text = "Limpiar"
        Me.btnLimp.UseVisualStyleBackColor = True
        '
        'numUD
        '
        Me.numUD.Location = New System.Drawing.Point(30, 153)
        Me.numUD.Name = "numUD"
        Me.numUD.Size = New System.Drawing.Size(191, 22)
        Me.numUD.TabIndex = 28
        '
        'lblTot
        '
        Me.lblTot.AutoSize = True
        Me.lblTot.Location = New System.Drawing.Point(47, 200)
        Me.lblTot.Name = "lblTot"
        Me.lblTot.Size = New System.Drawing.Size(51, 16)
        Me.lblTot.TabIndex = 29
        Me.lblTot.Text = "Total: 0"
        '
        'Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 360)
        Me.Controls.Add(Me.lblTot)
        Me.Controls.Add(Me.numUD)
        Me.Controls.Add(Me.btnLimp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbProv)
        Me.Controls.Add(Me.btnImp)
        Me.Controls.Add(Me.dgvComp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnIngreso)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Compras"
        Me.Text = "Compras"
        CType(Me.dgvComp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents cbProv As ComboBox
    Friend WithEvents btnImp As Button
    Friend WithEvents dgvComp As DataGridView
    Friend WithEvents Producto As DataGridViewComboBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents btnIngreso As Button
    Friend WithEvents btnLimp As Button
    Friend WithEvents numUD As NumericUpDown
    Friend WithEvents lblTot As Label
End Class
