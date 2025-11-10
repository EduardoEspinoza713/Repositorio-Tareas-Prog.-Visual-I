<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ventas
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnIngreso = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalVenta = New System.Windows.Forms.TextBox()
        Me.dgvVenta = New System.Windows.Forms.DataGridView()
        Me.Producto = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbxCliente = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnImp = New System.Windows.Forms.Button()
        Me.btnLimp = New System.Windows.Forms.Button()
        CType(Me.dgvVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Productos de Venta"
        '
        'btnIngreso
        '
        Me.btnIngreso.Location = New System.Drawing.Point(27, 261)
        Me.btnIngreso.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnIngreso.Name = "btnIngreso"
        Me.btnIngreso.Size = New System.Drawing.Size(93, 35)
        Me.btnIngreso.TabIndex = 4
        Me.btnIngreso.Text = "Guardar"
        Me.btnIngreso.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Total"
        '
        'txtTotalVenta
        '
        Me.txtTotalVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalVenta.Enabled = False
        Me.txtTotalVenta.Location = New System.Drawing.Point(38, 146)
        Me.txtTotalVenta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTotalVenta.Name = "txtTotalVenta"
        Me.txtTotalVenta.Size = New System.Drawing.Size(167, 22)
        Me.txtTotalVenta.TabIndex = 14
        '
        'dgvVenta
        '
        Me.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Producto, Me.Cantidad})
        Me.dgvVenta.Location = New System.Drawing.Point(284, 42)
        Me.dgvVenta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvVenta.Name = "dgvVenta"
        Me.dgvVenta.RowHeadersWidth = 62
        Me.dgvVenta.RowTemplate.Height = 28
        Me.dgvVenta.Size = New System.Drawing.Size(632, 254)
        Me.dgvVenta.TabIndex = 15
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
        'cbxCliente
        '
        Me.cbxCliente.FormattingEnabled = True
        Me.cbxCliente.Location = New System.Drawing.Point(14, 39)
        Me.cbxCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxCliente.Name = "cbxCliente"
        Me.cbxCliente.Size = New System.Drawing.Size(191, 24)
        Me.cbxCliente.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(72, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Cliente"
        '
        'btnImp
        '
        Me.btnImp.Location = New System.Drawing.Point(513, 313)
        Me.btnImp.Name = "btnImp"
        Me.btnImp.Size = New System.Drawing.Size(145, 23)
        Me.btnImp.TabIndex = 19
        Me.btnImp.Text = "Imprimir Factura"
        Me.btnImp.UseVisualStyleBackColor = True
        '
        'btnLimp
        '
        Me.btnLimp.Location = New System.Drawing.Point(149, 261)
        Me.btnLimp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLimp.Name = "btnLimp"
        Me.btnLimp.Size = New System.Drawing.Size(93, 35)
        Me.btnLimp.TabIndex = 20
        Me.btnLimp.Text = "Limpiar"
        Me.btnLimp.UseVisualStyleBackColor = True
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 360)
        Me.Controls.Add(Me.btnLimp)
        Me.Controls.Add(Me.btnImp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbxCliente)
        Me.Controls.Add(Me.dgvVenta)
        Me.Controls.Add(Me.txtTotalVenta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnIngreso)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Ventas"
        Me.Text = "Ventas"
        CType(Me.dgvVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents btnIngreso As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotalVenta As TextBox
    Friend WithEvents dgvVenta As DataGridView
    Friend WithEvents cbxCliente As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Producto As DataGridViewComboBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents btnImp As Button
    Friend WithEvents btnLimp As Button
End Class
