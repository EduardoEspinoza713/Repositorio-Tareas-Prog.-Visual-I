Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class Compras
    Private idProveedorSeleccionado As Integer = 0
    Private precioCompraActual As Decimal = 0.0D

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        numUD.Minimum = 0.0D
        numUD.DecimalPlaces = 2
        numUD.Increment = 0.01D
        numUD.Maximum = 1000000D

        lblTot.Text = "Total: 0.00"

        CargarProveedores()
        ConfigurarDataGridViewCompra()
        btnImp.Enabled = False
    End Sub

    Private Sub numUD_ValueChanged(sender As Object, e As EventArgs) Handles numUD.ValueChanged
        If dgvComp.CurrentCell IsNot Nothing AndAlso dgvComp.CurrentRow.Cells("colProducto").Value IsNot Nothing Then
            CalcularSubtotalFila(dgvComp.CurrentCell.RowIndex)
        Else
            RecalcularTotal()
        End If
    End Sub

    Private Sub cbProv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProv.SelectedIndexChanged
        If cbProv.SelectedValue IsNot Nothing AndAlso Integer.TryParse(cbProv.SelectedValue.ToString(), idProveedorSeleccionado) Then
            LimpiarDataGridView()
            CargarCatalogoProductosDGV()
            numUD.Value = 0.0D
        Else
            idProveedorSeleccionado = 0
        End If
    End Sub

    Private Sub CargarProveedores()
        Dim query As String = "SELECT id_proveedor, nombre FROM Proveedores ORDER BY nombre"
        Try
            Dim dtProveedores As DataTable = Module1.ObtenerDataTable(query)

            cbProv.DataSource = dtProveedores
            cbProv.DisplayMember = "nombre"
            cbProv.ValueMember = "id_proveedor"

            If cbProv.SelectedValue IsNot Nothing Then
                Integer.TryParse(cbProv.SelectedValue.ToString(), idProveedorSeleccionado)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error al cargar proveedores: {ex.Message}", "Error DB", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ConfigurarDataGridViewCompra()
        dgvComp.DataSource = Nothing
        dgvComp.Columns.Clear()

        Dim colProducto As New DataGridViewComboBoxColumn()
        colProducto.HeaderText = "Producto"
        colProducto.Name = "colProducto"
        colProducto.DisplayMember = "nombre"
        colProducto.ValueMember = "id_producto"

        dgvComp.Columns.Add(colProducto)
        dgvComp.Columns.Add("colCantidad", "Cantidad")
        dgvComp.Columns.Add("colSubtotal", "Subtotal")

        dgvComp.Columns.Add("colPrecioUnitario", "Precio_Unitario_Oculto")
        dgvComp.Columns("colPrecioUnitario").Visible = False

        dgvComp.Columns("colSubtotal").DefaultCellStyle.Format = "N2"
        dgvComp.ReadOnly = False
        dgvComp.AllowUserToAddRows = True
    End Sub

    Private Sub CargarCatalogoProductosDGV()
        Dim dtProductos As DataTable = ObtenerProductosPorProveedor(idProveedorSeleccionado)

        For Each col As DataGridViewColumn In dgvComp.Columns
            If col.Name = "colProducto" AndAlso TypeOf col Is DataGridViewComboBoxColumn Then
                DirectCast(col, DataGridViewComboBoxColumn).DataSource = dtProductos
                DirectCast(col, DataGridViewComboBoxColumn).DisplayMember = "nombre"
                DirectCast(col, DataGridViewComboBoxColumn).ValueMember = "id_producto"
                Exit Sub
            End If
        Next
    End Sub

    Private Function ObtenerProductosPorProveedor(ByVal proveedorID As Integer) As DataTable
        Dim query As String = $"SELECT id_producto, nombre, precio_compra, stock FROM Productos WHERE id_proveedor = {proveedorID} ORDER BY nombre"
        Dim dtProductos As New DataTable()

        If proveedorID = 0 Then Return dtProductos

        Try
            dtProductos = Module1.ObtenerDataTable(query)
        Catch ex As Exception
            MessageBox.Show("Error al obtener catálogo filtrado: " & ex.Message)
        End Try
        Return dtProductos
    End Function

    Private Sub dgvComp_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvComp.CellValueChanged
        If e.RowIndex >= 0 Then
            If dgvComp.Columns(e.ColumnIndex).Name = "colProducto" Then
                ActualizarPrecioYCalcular(e.RowIndex)
            End If

            ActualizarEstadoProveedorComboBox()
        End If
    End Sub

    Private Sub dgvComp_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvComp.CellEnter
        If e.RowIndex >= 0 Then
            If dgvComp.Rows(e.RowIndex).Cells("colProducto").Value IsNot Nothing Then
                Dim precioUnitario As Decimal = 0.0D

                If Decimal.TryParse(dgvComp.Rows(e.RowIndex).Cells("colPrecioUnitario").Value?.ToString(), precioUnitario) Then
                    numUD.Value = precioUnitario
                    precioCompraActual = precioUnitario
                End If
            Else
                numUD.Value = 0.0D
                precioCompraActual = 0.0D
            End If
        End If
    End Sub

    Private Sub dgvComp_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvComp.RowsRemoved
        ActualizarEstadoProveedorComboBox()
    End Sub

    Private Sub ActualizarEstadoProveedorComboBox()
        Dim productosEnGrid As Integer = dgvComp.Rows.Cast(Of DataGridViewRow)().Count(Function(r) Not r.IsNewRow AndAlso r.Cells("colProducto").Value IsNot Nothing)

        cbProv.Enabled = (productosEnGrid = 0)
    End Sub

    Private Sub dgvComp_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvComp.CellEndEdit
        If e.RowIndex >= 0 AndAlso dgvComp.Columns(e.ColumnIndex).Name = "colCantidad" Then
            Dim cantidad As Integer = 0

            If Not Integer.TryParse(dgvComp.Rows(e.RowIndex).Cells("colCantidad").Value?.ToString(), cantidad) OrElse cantidad <= 0 Then
                dgvComp.Rows(e.RowIndex).Cells("colCantidad").Value = 1
                MessageBox.Show("La cantidad debe ser un número entero mayor a cero.", "Cantidad Inválida")
            End If
            CalcularSubtotalFila(e.RowIndex)
        End If
    End Sub

    Private Sub ActualizarPrecioYCalcular(ByVal rowIndex As Integer)
        Dim cellProducto As DataGridViewComboBoxCell = DirectCast(dgvComp.Rows(rowIndex).Cells("colProducto"), DataGridViewComboBoxCell)

        numUD.Value = 0.0D

        If cellProducto.Value Is Nothing Then
            dgvComp.Rows(rowIndex).Cells("colPrecioUnitario").Value = 0.0D
            CalcularSubtotalFila(rowIndex)
            Exit Sub
        End If

        Dim idProducto As Integer = Convert.ToInt32(cellProducto.Value)
        Dim queryPrecio As String = $"SELECT precio_compra FROM Productos WHERE id_producto = {idProducto}"
        Dim objPrecio As Object = Module1.ObtenerEscalar(queryPrecio)

        If objPrecio IsNot Nothing AndAlso Not IsDBNull(objPrecio) Then
            Dim precio As Decimal = Convert.ToDecimal(objPrecio)

            If precio < numUD.Maximum Then
                numUD.Value = precio
                precioCompraActual = precio
            Else
                numUD.Value = numUD.Maximum
                precioCompraActual = numUD.Maximum
            End If

            dgvComp.Rows(rowIndex).Cells("colPrecioUnitario").Value = precio

            If dgvComp.Rows(rowIndex).Cells("colCantidad").Value Is Nothing OrElse dgvComp.Rows(rowIndex).Cells("colCantidad").Value.ToString() = "" Then
                dgvComp.Rows(rowIndex).Cells("colCantidad").Value = 1
            End If

            CalcularSubtotalFila(rowIndex)
        Else
            dgvComp.Rows(rowIndex).Cells("colPrecioUnitario").Value = 0.0D
            CalcularSubtotalFila(rowIndex)
        End If
    End Sub

    Private Sub CalcularSubtotalFila(ByVal rowIndex As Integer)
        Dim cantidad As Integer = 0
        Dim precio As Decimal = numUD.Value
        Dim subtotal As Decimal = 0.0D

        If Integer.TryParse(dgvComp.Rows(rowIndex).Cells("colCantidad").Value?.ToString(), cantidad) Then
            subtotal = cantidad * precio
            dgvComp.Rows(rowIndex).Cells("colSubtotal").Value = subtotal

            dgvComp.Rows(rowIndex).Cells("colPrecioUnitario").Value = precio
        Else
            dgvComp.Rows(rowIndex).Cells("colSubtotal").Value = 0.0D
        End If

        RecalcularTotal()
    End Sub

    Private Sub RecalcularTotal()
        Dim totalCompra As Decimal = 0.0D
        For Each row As DataGridViewRow In dgvComp.Rows
            If Not row.IsNewRow AndAlso row.Cells("colSubtotal").Value IsNot Nothing Then
                Dim subtotal As Decimal = 0.0D
                If Decimal.TryParse(row.Cells("colSubtotal").Value?.ToString(), subtotal) Then
                    totalCompra += subtotal
                End If
            End If
        Next
        lblTot.Text = $"Total: {totalCompra.ToString("N2")}"
    End Sub

    Private Sub btnIngreso_Click(sender As Object, e As EventArgs) Handles btnIngreso.Click
        If idProveedorSeleccionado = 0 Then
            MessageBox.Show("Seleccione un proveedor.", "Error")
            Exit Sub
        End If

        If numUD.Value < 0 Then
            MessageBox.Show("El precio de compra no puede ser negativo.", "Error de Validación")
            Exit Sub
        End If

        Dim totalCompraCalculada As Decimal = 0.0D
        Dim productosParaComprar As New List(Of DataGridViewRow)()

        For Each row As DataGridViewRow In dgvComp.Rows
            If Not row.IsNewRow AndAlso row.Cells("colProducto").Value IsNot Nothing Then
                Dim subtotal As Decimal = 0.0D
                Dim cantidad As Integer = 0

                If Decimal.TryParse(row.Cells("colSubtotal").Value?.ToString(), subtotal) AndAlso
                    Integer.TryParse(row.Cells("colCantidad").Value?.ToString(), cantidad) AndAlso
                    cantidad > 0 Then

                    totalCompraCalculada += subtotal
                    productosParaComprar.Add(row)
                ElseIf row.Cells("colProducto").Value IsNot Nothing Then
                    MessageBox.Show("El producto seleccionado requiere una cantidad mayor a cero.", "Error de Cantidad")
                    Exit Sub
                End If
            End If
        Next

        If totalCompraCalculada <= 0 Then
            MessageBox.Show("Debe agregar al menos un producto con cantidad válida.", "Error")
            Exit Sub
        End If

        RegistrarCompraSinTransaccion(idProveedorSeleccionado, totalCompraCalculada, productosParaComprar)
        btnImp.Enabled = True
        btnIngreso.Enabled = False
        dgvComp.Enabled = False
    End Sub

    Private Sub RegistrarCompraSinTransaccion(ByVal proveedorID As Integer, ByVal total As Decimal, ByVal filasCompra As List(Of DataGridViewRow))
        Dim conn As MySqlConnection = Module1.conectar()
        Dim compraID As Integer = 0

        Try
            Dim queryCompra As String = "INSERT INTO Compras (fecha_compra, id_proveedor, total) VALUES (NOW(), @proveedor, @total); SELECT LAST_INSERT_ID();"

            Using cmdCompra As New MySqlCommand(queryCompra, conn)
                cmdCompra.Parameters.AddWithValue("@proveedor", proveedorID)
                cmdCompra.Parameters.AddWithValue("@total", total)

                conn.Open()
                compraID = Convert.ToInt32(cmdCompra.ExecuteScalar())
                conn.Close()
            End Using

            If compraID > 0 Then
                For Each row As DataGridViewRow In filasCompra
                    Dim productoID As Integer = Convert.ToInt32(row.Cells("colProducto").Value)
                    Dim cantidad As Integer = Convert.ToInt32(row.Cells("colCantidad").Value)
                    Dim precioUnitario As Decimal = Convert.ToDecimal(row.Cells("colPrecioUnitario").Value)

                    RegistrarDetalleYActualizarStockSinTransaccion(compraID, productoID, cantidad, precioUnitario)
                Next
            End If

            MessageBox.Show($"Compra #{compraID} registrada con éxito y stock actualizado.", "Éxito")

        Catch ex As Exception
            MessageBox.Show("Fallo el proceso de Compra: " & ex.Message, "Error de Compra", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub RegistrarDetalleYActualizarStockSinTransaccion(ByVal compraID As Integer, ByVal productoID As Integer, ByVal cantidad As Integer, ByVal precioNuevo As Decimal)
        Dim conn As MySqlConnection = Module1.conectar()

        Try
            conn.Open()

            Dim queryDetalle As String = "INSERT INTO Detalle_Compras (id_compra, id_producto, cantidad, precio_compra) VALUES (@compraId, @productoId, @cantidad, @precio);"
            Using cmdDetalle As New MySqlCommand(queryDetalle, conn)
                cmdDetalle.Parameters.AddWithValue("@compraId", compraID)
                cmdDetalle.Parameters.AddWithValue("@productoId", productoID)
                cmdDetalle.Parameters.AddWithValue("@cantidad", cantidad)
                cmdDetalle.Parameters.AddWithValue("@precio", precioNuevo)
                cmdDetalle.ExecuteNonQuery()
            End Using

            Dim queryStock As String = "UPDATE Productos SET stock = stock + @cantidad WHERE id_producto = @id;"
            Using cmdStock As New MySqlCommand(queryStock, conn)
                cmdStock.Parameters.AddWithValue("@cantidad", cantidad)
                cmdStock.Parameters.AddWithValue("@id", productoID)
                cmdStock.ExecuteNonQuery()
            End Using

            Dim queryDatosProducto As String = "SELECT precio_compra, porcentaje_ganancia FROM Productos WHERE id_producto = @id;"

            Dim precioActualDB As Decimal = 0.0D
            Dim porcentajeGanancia As Decimal = 0.0D

            Using cmdDatosProducto As New MySqlCommand(queryDatosProducto, conn)
                cmdDatosProducto.Parameters.AddWithValue("@id", productoID)

                Using reader As MySqlDataReader = cmdDatosProducto.ExecuteReader()
                    If reader.Read() Then
                        precioActualDB = reader.GetDecimal("precio_compra")
                        porcentajeGanancia = reader.GetDecimal("porcentaje_ganancia")
                    End If
                End Using
            End Using

            If precioNuevo > precioActualDB Then
                Dim nuevoPrecioVenta As Decimal = precioNuevo * (1D + (porcentajeGanancia / 100D))

                Dim queryActualizarPrecios As String = "UPDATE Productos SET precio_compra = @precioNuevo, precio_venta = @nuevoPrecioVenta WHERE id_producto = @id;"
                Using cmdUpdatePrecios As New MySqlCommand(queryActualizarPrecios, conn)
                    cmdUpdatePrecios.Parameters.AddWithValue("@precioNuevo", precioNuevo)
                    cmdUpdatePrecios.Parameters.AddWithValue("@nuevoPrecioVenta", nuevoPrecioVenta)
                    cmdUpdatePrecios.Parameters.AddWithValue("@id", productoID)
                    cmdUpdatePrecios.ExecuteNonQuery()
                End Using
            End If

        Catch ex As Exception
            MessageBox.Show("Fallo al procesar el detalle del producto " & productoID & ": " & ex.Message, "Error Detalle")
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then conn.Close()
        End Try

    End Sub

    Private Sub LimpiarDataGridView()
        ConfigurarDataGridViewCompra()
    End Sub

    Private Sub btnLimp_Click(sender As Object, e As EventArgs) Handles btnLimp.Click
        LimpiarDataGridView()

        numUD.Value = 0.0D
        lblTot.Text = "Total: 0.00"

        cbProv.Enabled = True
        CargarCatalogoProductosDGV()
        btnImp.Enabled = False
        btnIngreso.Enabled = True
        dgvComp.Enabled = True
    End Sub

    Private Sub btnImp_Click(sender As Object, e As EventArgs) Handles btnImp.Click
        Dim proveedorNombre As String = If(cbProv.SelectedValue IsNot Nothing, cbProv.Text, "Sin Proveedor")
        Dim fecha As String = Date.Now.ToString("dd-MM-yyyy")
        Module1.GridAExcelV2(dgvComp, $"Compra a {proveedorNombre} por {lblTot.Text} fecha: {fecha}")
    End Sub
End Class