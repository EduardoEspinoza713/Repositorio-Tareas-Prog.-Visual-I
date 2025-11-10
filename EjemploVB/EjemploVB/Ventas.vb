Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class Ventas
    Private Const CONNECTION_STRING As String = "Server=localhost;Database=inventario;Uid=root;Pwd=1234;"
    Private idClienteSeleccionado As Integer = 0
    Private Shared ReadOnly CONEXION As MySqlConnection = Module1.conectar()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTotalVenta.Enabled = False
        txtTotalVenta.Text = "0.00"
        CargarClientes()
        ConfigurarDataGridViewVenta()
        CargarDetalleVenta(0)
        btnImp.Enabled = False
    End Sub
    Private Function ObtenerProductosCatalogo() As System.Data.DataTable
        Dim query As String = "SELECT id_producto, nombre, precio_venta, stock FROM Productos ORDER BY nombre"
        Dim dtProductos As New System.Data.DataTable()

        Try
            Using connection As New MySqlConnection(CONNECTION_STRING)
                Using adapter As New MySqlDataAdapter(query, connection)
                    adapter.Fill(dtProductos)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener catálogo: " & ex.Message)
        End Try
        Return dtProductos
    End Function

    Private Sub ConfigurarDataGridViewVenta()
        dgvVenta.DataSource = Nothing
        dgvVenta.Columns.Clear()
        Dim dtProductos As System.Data.DataTable = ObtenerProductosCatalogo()

        Dim colProducto As New DataGridViewComboBoxColumn()
        colProducto.HeaderText = "Producto"
        colProducto.Name = "colProducto"
        colProducto.DisplayMember = "nombre"
        colProducto.ValueMember = "id_producto"
        colProducto.DataSource = dtProductos

        dgvVenta.Columns.Add(colProducto)
        dgvVenta.Columns.Add("colCantidad", "Cantidad")
        dgvVenta.Columns.Add("colPrecioUnitario", "Precio_Unitario")
        dgvVenta.Columns.Add("colSubtotal", "Subtotal")

        dgvVenta.Columns("colPrecioUnitario").DefaultCellStyle.Format = "N2"
        dgvVenta.Columns("colSubtotal").DefaultCellStyle.Format = "N2"

        dgvVenta.ReadOnly = False
        dgvVenta.AllowUserToAddRows = True
    End Sub

    Private Sub CargarClientes()
        Dim query As String = "SELECT id_cliente, nombre FROM Clientes ORDER BY nombre"

        Try
            Dim dtClientes As System.Data.DataTable = Module1.ObtenerDataTable(query)

            cbxCliente.DataSource = dtClientes
            cbxCliente.DisplayMember = "nombre"
            cbxCliente.ValueMember = "id_cliente"

            If cbxCliente.SelectedValue IsNot Nothing Then
                Integer.TryParse(cbxCliente.SelectedValue.ToString(), idClienteSeleccionado)
            End If

        Catch ex As Exception
            MessageBox.Show($"Error al cargar clientes (MySQL): {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvVenta_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVenta.CellValueChanged
        If e.RowIndex >= 0 Then
            If dgvVenta.Columns(e.ColumnIndex).Name = "colProducto" Then
                ActualizarPrecioYCalcular(e.RowIndex)
            End If
        End If
    End Sub

    Private Sub dgvVenta_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVenta.CellEndEdit
        If e.RowIndex >= 0 AndAlso dgvVenta.Columns(e.ColumnIndex).Name = "colCantidad" Then
            Dim cantidad As Integer = 0

            If Not Integer.TryParse(dgvVenta.Rows(e.RowIndex).Cells("colCantidad").Value?.ToString(), cantidad) OrElse cantidad <= 0 Then
                dgvVenta.Rows(e.RowIndex).Cells("colCantidad").Value = 1
                MessageBox.Show("La cantidad debe ser un número entero mayor a cero.", "Cantidad Inválida")
            End If
            CalcularSubtotalYTotal(e.RowIndex)
        End If
    End Sub

    Private Sub ActualizarPrecioYCalcular(ByVal rowIndex As Integer)
        Dim cellProducto As DataGridViewComboBoxCell = DirectCast(dgvVenta.Rows(rowIndex).Cells("colProducto"), DataGridViewComboBoxCell)

        If cellProducto.Value Is Nothing Then
            dgvVenta.Rows(rowIndex).Cells("colPrecioUnitario").Value = 0.0D
            CalcularSubtotalYTotal(rowIndex)
            Exit Sub
        End If

        Dim idProducto As Integer = Convert.ToInt32(cellProducto.Value)
        Dim queryPrecio As String = $"SELECT precio_venta FROM Productos WHERE id_producto = {idProducto}"
        Dim objPrecio As Object = Module1.ObtenerEscalar(queryPrecio)

        If objPrecio IsNot Nothing AndAlso Not IsDBNull(objPrecio) Then
            Dim precio As Decimal = Convert.ToDecimal(objPrecio)

            If precio < 0 Then
                precio = 0.0D
                MessageBox.Show("Advertencia: El precio del producto era negativo en la BD y se ha establecido a 0.", "Precio Corregido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            dgvVenta.Rows(rowIndex).Cells("colPrecioUnitario").Value = precio

            If dgvVenta.Rows(rowIndex).Cells("colCantidad").Value Is Nothing OrElse dgvVenta.Rows(rowIndex).Cells("colCantidad").Value.ToString() = "" Then
                dgvVenta.Rows(rowIndex).Cells("colCantidad").Value = 1
            End If

            CalcularSubtotalYTotal(rowIndex)
        Else
            dgvVenta.Rows(rowIndex).Cells("colPrecioUnitario").Value = 0.0D
            CalcularSubtotalYTotal(rowIndex)
        End If
    End Sub

    Private Sub CalcularSubtotalYTotal(ByVal rowIndex As Integer)
        Dim cantidad As Integer = 0
        Dim precio As Decimal = 0.0D
        Dim subtotal As Decimal = 0.0D

        If Integer.TryParse(dgvVenta.Rows(rowIndex).Cells("colCantidad").Value?.ToString(), cantidad) AndAlso
         Decimal.TryParse(dgvVenta.Rows(rowIndex).Cells("colPrecioUnitario").Value?.ToString(), precio) Then

            subtotal = cantidad * precio
            dgvVenta.Rows(rowIndex).Cells("colSubtotal").Value = subtotal
        Else
            dgvVenta.Rows(rowIndex).Cells("colSubtotal").Value = 0.0D
        End If

        RecalcularTotal()
    End Sub

    Private Sub RecalcularTotal()
        Dim totalVenta As Decimal = 0.0D
        For Each row As DataGridViewRow In dgvVenta.Rows
            If Not row.IsNewRow AndAlso row.Cells("colSubtotal").Value IsNot Nothing Then
                Dim subtotal As Decimal = 0.0D
                If Decimal.TryParse(row.Cells("colSubtotal").Value?.ToString(), subtotal) Then
                    totalVenta += subtotal
                End If
            End If
        Next
        txtTotalVenta.Text = totalVenta.ToString("N2")
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnIngreso.Click
        If idClienteSeleccionado = 0 Then
            MessageBox.Show("Seleccione un cliente.", "Error")
            Exit Sub
        End If

        Dim totalVenta As Decimal
        Dim productosParaVender As New List(Of DataGridViewRow)()

        If Not Decimal.TryParse(txtTotalVenta.Text, totalVenta) OrElse totalVenta <= 0 Then
            MessageBox.Show("Debe agregar al menos un producto con cantidad válida para generar una venta.", "Error")
            Exit Sub
        End If

        For Each row As DataGridViewRow In dgvVenta.Rows
            If Not row.IsNewRow AndAlso row.Cells("colProducto").Value IsNot Nothing Then
                Dim productoID As Integer = Convert.ToInt32(row.Cells("colProducto").Value)
                Dim cantidad As Integer = 0

                If Integer.TryParse(row.Cells("colCantidad").Value?.ToString(), cantidad) AndAlso cantidad > 0 Then

                    Dim stockActual As Integer = ObtenerStockActual(productoID)

                    If stockActual = 0 Then
                        MessageBox.Show($"ERROR: El producto '{row.Cells("colProducto").FormattedValue.ToString()}' no tiene stock disponible (0).", "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    ElseIf cantidad > stockActual Then
                        MessageBox.Show($"ERROR: Stock insuficiente para '{row.Cells("colProducto").FormattedValue.ToString()}'. Stock disponible: {stockActual}. Cantidad solicitada: {cantidad}.", "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    productosParaVender.Add(row)
                ElseIf row.Cells("colProducto").Value IsNot Nothing Then
                    MessageBox.Show("El producto seleccionado requiere una cantidad mayor a cero.", "Error de Cantidad")
                    Exit Sub
                End If
            End If
        Next

        If productosParaVender.Count = 0 Then
            MessageBox.Show("No hay productos válidos para vender.", "Error")
            Exit Sub
        End If

        RegistrarVentaYDetalle(idClienteSeleccionado, totalVenta, productosParaVender)
        btnIngreso.Enabled = False
        cbxCliente.Enabled = False
        dgvVenta.Enabled = False
    End Sub

    Private Function ObtenerStockActual(ByVal productoID As Integer) As Integer
        Dim query As String = $"SELECT stock FROM Productos WHERE id_producto = {productoID};"
        Dim resultado As Object = Module1.ObtenerEscalar(query)

        If resultado IsNot Nothing AndAlso Not IsDBNull(resultado) Then
            Return Convert.ToInt32(resultado)
        Else
            Return 0
        End If
    End Function

    Private Sub RegistrarVentaYDetalle(ByVal clienteID As Integer, ByVal total As Decimal, ByVal filasVenta As List(Of DataGridViewRow))
        Dim ventaID As Integer = 0
        Dim conn As MySqlConnection = Module1.conectar()

        Try
            Dim queryVenta As String = $"INSERT INTO Ventas (fecha_venta, id_cliente, total) VALUES (NOW(), {clienteID}, {total.ToString().Replace(",", ".")}); SELECT LAST_INSERT_ID();"
            conn.Open()
            Using cmdVenta As New MySqlCommand(queryVenta, conn)
                ventaID = Convert.ToInt32(cmdVenta.ExecuteScalar())
            End Using
            conn.Close()
            If ventaID > 0 Then
                For Each row As DataGridViewRow In filasVenta
                    Dim productoID As Integer = Convert.ToInt32(row.Cells("colProducto").Value)
                    Dim cantidad As Integer = Convert.ToInt32(row.Cells("colCantidad").Value)
                    Dim precioUnitario As Decimal = Convert.ToDecimal(row.Cells("colPrecioUnitario").Value)
                    Dim queryDetalle As String = $"INSERT INTO Detalle_Ventas (id_venta, id_producto, cantidad, precio_unitario) VALUES ({ventaID}, {productoID}, {cantidad}, {precioUnitario.ToString().Replace(",", ".")});"
                    Module1.EjecutarOrden(queryDetalle, conn)
                    Dim queryStock As String = $"UPDATE Productos SET stock = stock - {cantidad} WHERE id_producto = {productoID};"
                    Module1.EjecutarOrden(queryStock, conn)
                Next
            End If

            MessageBox.Show("Venta registrada con éxito y stock actualizado.", "Éxito")
            'ConfigurarDataGridViewVenta()
            'txtTotalVenta.Text = "0.00"
            btnIngreso.Enabled = False
            btnImp.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Fallo en el proceso de venta: " & ex.Message, "Error de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Function VerificarStock(ByVal productoID As Integer, ByVal cantidad As Integer) As Boolean
        Dim stockActual As Integer = 0
        Dim query As String = "SELECT stock FROM Productos WHERE id_producto = @id;"

        Try
            Using connection As New MySqlConnection(CONNECTION_STRING)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@id", productoID)
                    connection.Open()

                    Dim resultado As Object = command.ExecuteScalar()
                    If resultado IsNot DBNull.Value AndAlso resultado IsNot Nothing Then
                        stockActual = Convert.ToInt32(resultado)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al verificar stock: " & ex.Message, "Error DB")
            Return False
        End Try

        Return stockActual >= cantidad
    End Function

    Private Sub CargarDetalleVenta(ByVal ventaID As Integer)
        If ventaID = 0 Then
            dgvVenta.DataSource = Nothing
            Exit Sub
        End If

        Dim query As String = "SELECT P.nombre, D.cantidad, D.precio_unitario, (D.cantidad * D.precio_unitario) AS Subtotal " &
                   "FROM Detalle_Ventas AS D " &
                   "JOIN Productos AS P ON D.id_producto = P.id_producto " &
                   "WHERE D.id_venta = @ventaId;"

        Try
            Dim dtDetalle As New System.Data.DataTable()

            Using connection As New MySqlConnection(CONNECTION_STRING)
                Using adapter As New MySqlDataAdapter(query, connection)
                    adapter.SelectCommand.Parameters.AddWithValue("@ventaId", ventaID)
                    adapter.Fill(dtDetalle)
                End Using
            End Using

            dgvVenta.DataSource = dtDetalle

        Catch ex As Exception
            MessageBox.Show("Error al mostrar el detalle de la venta: " & ex.Message, "Error DB")
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs)
        CargarClientes()
        ConfigurarDataGridViewVenta()
        MessageBox.Show("Vistas actualizadas.", "Éxito")
    End Sub

    Private Sub SeleccionarCliente() Handles cbxCliente.SelectedIndexChanged
        If cbxCliente.SelectedValue IsNot Nothing AndAlso Integer.TryParse(cbxCliente.SelectedValue.ToString(), idClienteSeleccionado) Then
        Else
            idClienteSeleccionado = 0
        End If
    End Sub

    Private Sub btnImp_Click(sender As Object, e As EventArgs) Handles btnImp.Click
        GridAExcelV2(dgvVenta, $"Factura {cbxCliente.Text} Total: {txtTotalVenta.Text}")
    End Sub

    Private Sub btnLimp_Click(sender As Object, e As EventArgs) Handles btnLimp.Click
        ConfigurarDataGridViewVenta()
        txtTotalVenta.Text = "0.00"
        btnImp.Enabled = False
        'btnLimp.Enabled = False
        btnIngreso.Enabled = True
        dgvVenta.Enabled = True
        cbxCliente.Enabled = True
    End Sub
End Class