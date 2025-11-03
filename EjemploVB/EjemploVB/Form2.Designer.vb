<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnIniSes = New System.Windows.Forms.Button()
        Me.btnCan = New System.Windows.Forms.Button()
        Me.btnAggU = New System.Windows.Forms.Button()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.ctUs = New System.Windows.Forms.TextBox()
        Me.ctContra = New System.Windows.Forms.TextBox()
        Me.lblContra = New System.Windows.Forms.Label()
        Me.lblRol = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.ctRol = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnIniSes
        '
        Me.btnIniSes.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnIniSes.Location = New System.Drawing.Point(54, 360)
        Me.btnIniSes.Name = "btnIniSes"
        Me.btnIniSes.Size = New System.Drawing.Size(100, 53)
        Me.btnIniSes.TabIndex = 0
        Me.btnIniSes.Text = "Iniciar Sesión"
        Me.btnIniSes.UseVisualStyleBackColor = False
        '
        'btnCan
        '
        Me.btnCan.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnCan.Location = New System.Drawing.Point(194, 360)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(100, 53)
        Me.btnCan.TabIndex = 1
        Me.btnCan.Text = "Cancelar"
        Me.btnCan.UseVisualStyleBackColor = False
        '
        'btnAggU
        '
        Me.btnAggU.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnAggU.Location = New System.Drawing.Point(327, 360)
        Me.btnAggU.Name = "btnAggU"
        Me.btnAggU.Size = New System.Drawing.Size(100, 53)
        Me.btnAggU.TabIndex = 2
        Me.btnAggU.Text = "Nuevo Usuario"
        Me.btnAggU.UseVisualStyleBackColor = False
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(54, 179)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(125, 16)
        Me.lblNom.TabIndex = 3
        Me.lblNom.Text = "Nombre de Usuario"
        '
        'ctUs
        '
        Me.ctUs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ctUs.Location = New System.Drawing.Point(207, 172)
        Me.ctUs.Name = "ctUs"
        Me.ctUs.Size = New System.Drawing.Size(172, 22)
        Me.ctUs.TabIndex = 4
        '
        'ctContra
        '
        Me.ctContra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ctContra.Location = New System.Drawing.Point(207, 229)
        Me.ctContra.Name = "ctContra"
        Me.ctContra.Size = New System.Drawing.Size(172, 22)
        Me.ctContra.TabIndex = 6
        '
        'lblContra
        '
        Me.lblContra.AutoSize = True
        Me.lblContra.Location = New System.Drawing.Point(54, 236)
        Me.lblContra.Name = "lblContra"
        Me.lblContra.Size = New System.Drawing.Size(76, 16)
        Me.lblContra.TabIndex = 5
        Me.lblContra.Text = "Contraseña"
        '
        'lblRol
        '
        Me.lblRol.AutoSize = True
        Me.lblRol.Location = New System.Drawing.Point(54, 292)
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Size = New System.Drawing.Size(28, 16)
        Me.lblRol.TabIndex = 7
        Me.lblRol.Text = "Rol"
        Me.lblRol.Visible = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Modern No. 20", 28.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(72, 52)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(338, 48)
        Me.lblTitulo.TabIndex = 9
        Me.lblTitulo.Text = "Inicio de Sesión"
        '
        'ctRol
        '
        Me.ctRol.FormattingEnabled = True
        Me.ctRol.Items.AddRange(New Object() {"administrador", "vendedor"})
        Me.ctRol.Location = New System.Drawing.Point(207, 292)
        Me.ctRol.Name = "ctRol"
        Me.ctRol.Size = New System.Drawing.Size(172, 24)
        Me.ctRol.TabIndex = 10
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 450)
        Me.Controls.Add(Me.ctRol)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblRol)
        Me.Controls.Add(Me.ctContra)
        Me.Controls.Add(Me.lblContra)
        Me.Controls.Add(Me.ctUs)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.btnAggU)
        Me.Controls.Add(Me.btnCan)
        Me.Controls.Add(Me.btnIniSes)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnIniSes As Button
    Friend WithEvents btnCan As Button
    Friend WithEvents btnAggU As Button
    Friend WithEvents lblNom As Label
    Friend WithEvents ctUs As TextBox
    Friend WithEvents ctContra As TextBox
    Friend WithEvents lblContra As Label
    Friend WithEvents lblRol As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents ctRol As ComboBox
End Class
