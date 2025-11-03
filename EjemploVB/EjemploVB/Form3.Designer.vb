<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.BarraHerramientas = New System.Windows.Forms.MenuStrip()
        Me.CatálogosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExistenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GananciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExistenciasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ComprasPorRangoDeFechasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasPorRangoDeFechasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtrasOpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExistenciasAlMínimoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdmUs = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarraHerramientas.SuspendLayout()
        Me.SuspendLayout()
        '
        'BarraHerramientas
        '
        Me.BarraHerramientas.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BarraHerramientas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatálogosToolStripMenuItem, Me.ExistenciasToolStripMenuItem, Me.OtrasOpcionesToolStripMenuItem})
        Me.BarraHerramientas.Location = New System.Drawing.Point(0, 0)
        Me.BarraHerramientas.Name = "BarraHerramientas"
        Me.BarraHerramientas.Size = New System.Drawing.Size(800, 30)
        Me.BarraHerramientas.TabIndex = 0
        Me.BarraHerramientas.Text = "MenuStrip1"
        '
        'CatálogosToolStripMenuItem
        '
        Me.CatálogosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ProveedoresToolStripMenuItem})
        Me.CatálogosToolStripMenuItem.Name = "CatálogosToolStripMenuItem"
        Me.CatálogosToolStripMenuItem.Size = New System.Drawing.Size(90, 24)
        Me.CatálogosToolStripMenuItem.Text = "Catálogos"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(174, 26)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(174, 26)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(174, 26)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'ExistenciasToolStripMenuItem
        '
        Me.ExistenciasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GananciasToolStripMenuItem, Me.ExistenciasToolStripMenuItem1, Me.ToolStripMenuItem1, Me.ComprasPorRangoDeFechasToolStripMenuItem, Me.VentasPorRangoDeFechasToolStripMenuItem})
        Me.ExistenciasToolStripMenuItem.Name = "ExistenciasToolStripMenuItem"
        Me.ExistenciasToolStripMenuItem.Size = New System.Drawing.Size(82, 26)
        Me.ExistenciasToolStripMenuItem.Text = "Reportes"
        '
        'GananciasToolStripMenuItem
        '
        Me.GananciasToolStripMenuItem.Name = "GananciasToolStripMenuItem"
        Me.GananciasToolStripMenuItem.Size = New System.Drawing.Size(294, 26)
        Me.GananciasToolStripMenuItem.Text = "Ganancias"
        '
        'ExistenciasToolStripMenuItem1
        '
        Me.ExistenciasToolStripMenuItem1.Name = "ExistenciasToolStripMenuItem1"
        Me.ExistenciasToolStripMenuItem1.Size = New System.Drawing.Size(294, 26)
        Me.ExistenciasToolStripMenuItem1.Text = "Existencias"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(291, 6)
        '
        'ComprasPorRangoDeFechasToolStripMenuItem
        '
        Me.ComprasPorRangoDeFechasToolStripMenuItem.Name = "ComprasPorRangoDeFechasToolStripMenuItem"
        Me.ComprasPorRangoDeFechasToolStripMenuItem.Size = New System.Drawing.Size(294, 26)
        Me.ComprasPorRangoDeFechasToolStripMenuItem.Text = "Compras por Rango de Fechas"
        '
        'VentasPorRangoDeFechasToolStripMenuItem
        '
        Me.VentasPorRangoDeFechasToolStripMenuItem.Name = "VentasPorRangoDeFechasToolStripMenuItem"
        Me.VentasPorRangoDeFechasToolStripMenuItem.Size = New System.Drawing.Size(294, 26)
        Me.VentasPorRangoDeFechasToolStripMenuItem.Text = "Ventas por Rango de Fechas"
        '
        'OtrasOpcionesToolStripMenuItem
        '
        Me.OtrasOpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExistenciasAlMínimoToolStripMenuItem, Me.ToolStripMenuItem2, Me.SaToolStripMenuItem, Me.AdmUs})
        Me.OtrasOpcionesToolStripMenuItem.Name = "OtrasOpcionesToolStripMenuItem"
        Me.OtrasOpcionesToolStripMenuItem.Size = New System.Drawing.Size(124, 26)
        Me.OtrasOpcionesToolStripMenuItem.Text = "Otras Opciones"
        '
        'ExistenciasAlMínimoToolStripMenuItem
        '
        Me.ExistenciasAlMínimoToolStripMenuItem.Name = "ExistenciasAlMínimoToolStripMenuItem"
        Me.ExistenciasAlMínimoToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.ExistenciasAlMínimoToolStripMenuItem.Text = "Existencias al mínimo"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(231, 6)
        '
        'SaToolStripMenuItem
        '
        Me.SaToolStripMenuItem.Name = "SaToolStripMenuItem"
        Me.SaToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.SaToolStripMenuItem.Text = "Salir"
        '
        'AdmUs
        '
        Me.AdmUs.Name = "AdmUs"
        Me.AdmUs.Size = New System.Drawing.Size(234, 26)
        Me.AdmUs.Text = "Administrar Usuarios"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BarraHerramientas)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.BarraHerramientas
        Me.Name = "Form3"
        Me.Text = "Gestor Tienda"
        Me.BarraHerramientas.ResumeLayout(False)
        Me.BarraHerramientas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarraHerramientas As MenuStrip
    Friend WithEvents CatálogosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExistenciasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GananciasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OtrasOpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExistenciasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ComprasPorRangoDeFechasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasPorRangoDeFechasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExistenciasAlMínimoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents SaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdmUs As ToolStripMenuItem
End Class
