<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.lblFMin = New System.Windows.Forms.Label()
        Me.lblFMax = New System.Windows.Forms.Label()
        Me.dtpFMin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFMax = New System.Windows.Forms.DateTimePicker()
        Me.btnRF = New System.Windows.Forms.Button()
        Me.btnImp = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(100, 32)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(611, 277)
        Me.DataGridView1.TabIndex = 0
        '
        'lblFMin
        '
        Me.lblFMin.AutoSize = True
        Me.lblFMin.Location = New System.Drawing.Point(100, 333)
        Me.lblFMin.Name = "lblFMin"
        Me.lblFMin.Size = New System.Drawing.Size(91, 16)
        Me.lblFMin.TabIndex = 1
        Me.lblFMin.Text = "Fecha Mínima"
        '
        'lblFMax
        '
        Me.lblFMax.AutoSize = True
        Me.lblFMax.Location = New System.Drawing.Point(100, 370)
        Me.lblFMax.Name = "lblFMax"
        Me.lblFMax.Size = New System.Drawing.Size(95, 16)
        Me.lblFMax.TabIndex = 2
        Me.lblFMax.Text = "Fecha máxima"
        '
        'dtpFMin
        '
        Me.dtpFMin.Location = New System.Drawing.Point(255, 326)
        Me.dtpFMin.Name = "dtpFMin"
        Me.dtpFMin.Size = New System.Drawing.Size(367, 22)
        Me.dtpFMin.TabIndex = 3
        '
        'dtpFMax
        '
        Me.dtpFMax.Location = New System.Drawing.Point(255, 364)
        Me.dtpFMax.Name = "dtpFMax"
        Me.dtpFMax.Size = New System.Drawing.Size(367, 22)
        Me.dtpFMax.TabIndex = 4
        '
        'btnRF
        '
        Me.btnRF.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnRF.Location = New System.Drawing.Point(103, 400)
        Me.btnRF.Name = "btnRF"
        Me.btnRF.Size = New System.Drawing.Size(608, 38)
        Me.btnRF.TabIndex = 5
        Me.btnRF.Text = "Filtrar fechas"
        Me.btnRF.UseVisualStyleBackColor = False
        '
        'btnImp
        '
        Me.btnImp.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnImp.Location = New System.Drawing.Point(643, 326)
        Me.btnImp.Name = "btnImp"
        Me.btnImp.Size = New System.Drawing.Size(68, 60)
        Me.btnImp.TabIndex = 6
        Me.btnImp.Text = "Imprimir Reporte"
        Me.btnImp.UseVisualStyleBackColor = False
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnImp)
        Me.Controls.Add(Me.btnRF)
        Me.Controls.Add(Me.dtpFMax)
        Me.Controls.Add(Me.dtpFMin)
        Me.Controls.Add(Me.lblFMax)
        Me.Controls.Add(Me.lblFMin)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form6"
        Me.Text = "Reporte de Compras por Rango de Fechas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblFMin As Label
    Friend WithEvents lblFMax As Label
    Friend WithEvents dtpFMin As DateTimePicker
    Friend WithEvents dtpFMax As DateTimePicker
    Friend WithEvents btnRF As Button
    Friend WithEvents btnImp As Button
End Class
