Public Class Form3
    Dim formPadre As Form2
    Dim CProv, CProd, CCli, RGan, RExis, RCRF, RVRF, ExMin, AdmiUs As Boolean

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        If (CCli = True) Then
            MessageBox.Show("La ventana ya está abierta.")
        Else
            Dim cli As New Form5
            cli.Padre(Me)
            cli.ShowDialog()
            'Me.LayoutMdi(MdiLayout.TileVertical)
        End If
    End Sub

    Private Sub ComprasPorRangoDeFechasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasPorRangoDeFechasToolStripMenuItem.Click
        If (RCRF = True) Then
            MessageBox.Show("La ventana ya está abierta.")
        Else
            Dim rcrf As New Form6("compras", "fecha_compra", "RCRF")
            rcrf.Padre(Me)
            rcrf.ShowDialog()
            'Me.LayoutMdi(MdiLayout.TileVertical)
        End If
    End Sub

    Private Sub VentasPorRangoDeFechasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasPorRangoDeFechasToolStripMenuItem.Click
        If (RVRF = True) Then
            MessageBox.Show("La ventana ya está abierta.")
        Else
            Dim rvrf As New Form6("ventas", "fecha_venta", "RVRF")
            rvrf.Padre(Me)
            rvrf.ShowDialog()
            'Me.LayoutMdi(MdiLayout.TileVertical)
        End If
    End Sub

    Private Sub GananciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GananciasToolStripMenuItem.Click
        If (RGan = True) Then
            MessageBox.Show("La ventana ya está abierta.")
        Else
            Dim rgan As New Form7("Reporte de Ganancias", "select
    id_producto as id,
    nombre as producto,
    id_proveedor,
    precio_compra,
    precio_venta,
    (precio_venta - precio_compra) as ganancia_prevista
from
    productos
order by
    ganancia_prevista desc;", "RGan")
            rgan.Padre(Me)
            rgan.ShowDialog()
            'Me.LayoutMdi(MdiLayout.TileVertical)
        End If
    End Sub

    Private Sub ExistenciasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExistenciasToolStripMenuItem1.Click
        If (RExis = True) Then
            MessageBox.Show("La ventana ya está abierta.")
        Else
            Dim rex As New Form7("Reporte de Existencias", "select id_producto, nombre as Nombre_Producto, id_proveedor, stock as 'Existencias' from productos;", "RExis")
            rex.Padre(Me)
            rex.ShowDialog()
            'Me.LayoutMdi(MdiLayout.TileVertical)
        End If
    End Sub

    Private Sub ExistenciasAlMínimoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExistenciasAlMínimoToolStripMenuItem.Click
        If (ExMin = True) Then
            MessageBox.Show("La ventana ya está abierta.")
        Else
            Dim exmin As New Form7("Reporte de Existencias por agotarse", "select id_producto, nombre as Nombre_Producto, id_proveedor, stock as 'Existencias', stock_minimo as 'Cantidad minima aceptable de xistencias en almacén' from productos where stock<=stock_minimo;", "ExMin")
            exmin.Padre(Me)
            exmin.Show()
            'Me.LayoutMdi(MdiLayout.TileVertical)
        End If
    End Sub

    Private Sub AdmUs_Click(sender As Object, e As EventArgs) Handles AdmUs.Click
        If (AdmiUs = True) Then
            MessageBox.Show("La ventana ya está abierta.")
        Else
            Dim admus As New Form8
            admus.Padre(Me)
            admus.ShowDialog()
            'Me.LayoutMdi(MdiLayout.TileVertical)
        End If
    End Sub

    Private Sub VentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentaToolStripMenuItem.Click
        Dim venta As New Ventas()
        venta.ShowDialog()
    End Sub

    Private Sub CompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompraToolStripMenuItem.Click
        Dim compra As New Compras()
        compra.ShowDialog()
    End Sub

    Private Sub SaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        If (CProd = True) Then
            MessageBox.Show("La ventana ya está abierta.")
        Else
            Dim prod As New Form4
            prod.Padre(Me)
            prod.ShowDialog()
            'Me.LayoutMdi(MdiLayout.TileVertical)
        End If
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        If (CProv = True) Then
            MessageBox.Show("La ventana ya está abierta.")
        Else
            Dim prov As New Form1
            prov.Padre(Me)
            prov.Show2(CProv)
            'Me.LayoutMdi(MdiLayout.TileVertical)
        End If
    End Sub
    Public Sub Est(ByRef estado As Boolean, ByVal tipo As String)
        Select Case tipo
            Case "CProv"
                CProv = estado
            Case "CProd"
                CProd = estado
            Case "CCli"
                CCli = estado
            Case "RGan"
                RGan = estado
            Case "RExis"
                RExis = estado
            Case "RCRF"
                RCRF = estado
            Case "RVRF"
                RVRF = estado
            Case "ExMin"
                ExMin = estado
            Case "AdmUs"
                AdmiUs = estado
        End Select
    End Sub
    Public Sub Padre(formulario As Form2)
        formPadre = formulario
    End Sub
    Function ObtPadre()
        Return formPadre
    End Function
    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        formPadre.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        CProv = False
        CProd = False
        CCli = False
        RGan = False
        RExis = False
        RCRF = False
        RVRF = False
        ExMin = False
        AdmiUs = False
        'Me.LayoutMdi(MdiLayout.TileHorizontal)
        If formPadre.LogIn() = 2 Then
            AdmUs.Visible = False
            CompraToolStripMenuItem.Visible = False
        End If
    End Sub
End Class