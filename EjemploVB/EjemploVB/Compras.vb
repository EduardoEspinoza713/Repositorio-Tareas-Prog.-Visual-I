Imports MySql.Data.MySqlClient


Public Class Compras
    Private Const CONNECTION_STRING As String = "Server=localhost;Database=inventario;Uid=root;Pwd=1234;"
    Private idProveedorSeleccionado As Integer = 0

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarNombresProveedoresConID()
        ConfigurarDataGridViewCompra()
        CargarDetalleCompra(0)
    End Sub

    Private Function ObtenerProductosCatalogo() As DataTable
        Dim query As String = "SELECT id_producto, nombre, precio_compra, stock FROM Productos ORDER BY nombre"
        Dim dtProductos As New DataTable()

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

    Private Sub ConfigurarDataGridViewCompra()
        DataGridView1.DataSource = Nothing
        DataGridView1.Columns.Clear()

        Dim colProducto As New DataGridViewComboBoxColumn()
        colProducto.HeaderText = "Producto"
        colProducto.Name = "colProducto"
        colProducto.DisplayMember = "nombre"
        colProducto.ValueMember = "id_producto"
        colProducto.DataSource = ObtenerProductosCatalogo()

        DataGridView1.Columns.Add(colProducto)
        DataGridView1.Columns.Add("colCantidad", "Cantidad")
        DataGridView1.Columns.Add("colPrecioUnitario", "Precio_Unitario")
        DataGridView1.Columns.Add("colSubtotal", "Subtotal")

        DataGridView1.Columns("colPrecioUnitario").Visible = False
        DataGridView1.Columns("colSubtotal").Visible = False

        DataGridView1.ReadOnly = False
        DataGridView1.AllowUserToAddRows = True

        AddHandler DataGridView1.CellValueChanged, AddressOf DataGridView1_CellValueChanged
        AddHandler DataGridView1.CellEndEdit, AddressOf DataGridView1_CellEndEdit
    End Sub

    Private Sub CargarNombresProveedoresConID()
        Dim query As String = "SELECT id_proveedor, nombre FROM Proveedores ORDER BY nombre"

        Try
            Dim dtProveedores As New DataTable()

            Using connection As New MySqlConnection(CONNECTION_STRING)
                Dim adapter As New MySqlDataAdapter(query, connection)
                adapter.Fill(dtProveedores)
            End Using

            cbxProveedor.DataSource = dtProveedores
            cbxProveedor.DisplayMember = "nombre"
            cbxProveedor.ValueMember = "id_proveedor"

            If cbxProveedor.SelectedValue IsNot Nothing Then
                Integer.TryParse(cbxProveedor.SelectedValue.ToString(), idProveedorSeleccionado)
            End If

        Catch ex As Exception
            MessageBox.Show($"Error al cargar proveedores (MySQL): {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        If e.RowIndex >= 0 Then
            If e.ColumnIndex = DataGridView1.Columns("colProducto").Index Then
                ActualizarPrecioYStock(e.RowIndex)
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = DataGridView1.Columns("colCantidad").Index Then
            Dim cantidad As Integer = 0

            If Not Integer.TryParse(DataGridView1.Rows(e.RowIndex).Cells("colCantidad").Value?.ToString(), cantidad) OrElse cantidad <= 0 Then
                DataGridView1.Rows(e.RowIndex).Cells("colCantidad").Value = 1
                MessageBox.Show("La cantidad debe ser un número entero mayor a cero.", "Cantidad Inválida")
            End If
            CalcularSubtotal(e.RowIndex)
        End If
    End Sub

    Private Sub ActualizarPrecioYStock(ByVal rowIndex As Integer)
        Dim cellProducto As DataGridViewComboBoxCell = DirectCast(DataGridView1.Rows(rowIndex).Cells("colProducto"), DataGridViewComboBoxCell)

        If cellProducto.Value Is Nothing Then
            DataGridView1.Rows(rowIndex).Cells("colPrecioUnitario").Value = 0.0D
            CalcularSubtotal(rowIndex)
            Exit Sub
        End If

        Dim idProducto As Integer = Convert.ToInt32(cellProducto.Value)
        Dim dtCatalogo As DataTable = ObtenerProductosCatalogo()

        Dim foundRows() As DataRow = dtCatalogo.Select($"id_producto = {idProducto}")

        If foundRows.Length > 0 Then
            ' Para compras, usamos el precio de compra, no el de venta
            Dim precio As Decimal = foundRows(0).Field(Of Decimal)("precio_compra")

            DataGridView1.Rows(rowIndex).Cells("colPrecioUnitario").Value = precio

            CalcularSubtotal(rowIndex)
        End If
    End Sub

    Private Sub CalcularSubtotal(ByVal rowIndex As Integer)
        Dim cantidad As Integer = 0
        Dim precio As Decimal = 0.0D

        If Integer.TryParse(DataGridView1.Rows(rowIndex).Cells("colCantidad").Value?.ToString(), cantidad) AndAlso
           Decimal.TryParse(DataGridView1.Rows(rowIndex).Cells("colPrecioUnitario").Value?.ToString(), precio) Then

            DataGridView1.Rows(rowIndex).Cells("colSubtotal").Value = cantidad * precio
        Else
            DataGridView1.Rows(rowIndex).Cells("colSubtotal").Value = 0.0D
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnIngreso.Click
        If idProveedorSeleccionado = 0 Then
            MessageBox.Show("Seleccione un proveedor.", "Error")
            Exit Sub
        End If

        Dim totalCompraCalculada As Decimal = 0.0D
        Dim productosParaComprar As New List(Of DataGridViewRow)()

        For Each row As DataGridViewRow In DataGridView1.Rows
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

        RegistrarCompraCompleta(idProveedorSeleccionado, totalCompraCalculada, productosParaComprar)
    End Sub

    Private Sub RegistrarCompraCompleta(ByVal proveedorID As Integer, ByVal total As Decimal, ByVal filasCompra As List(Of DataGridViewRow))

        Using connection As New MySqlConnection(CONNECTION_STRING)
            connection.Open()
            Dim transaction As MySqlTransaction = connection.BeginTransaction()

            Try
                Dim queryCompra As String = "INSERT INTO Compras (fecha_compra, id_proveedor, total) VALUES (NOW(), @proveedor, @total); SELECT LAST_INSERT_ID();"
                Dim compraID As Integer

                Using cmdCompra As New MySqlCommand(queryCompra, connection, transaction)
                    cmdCompra.Parameters.AddWithValue("@proveedor", proveedorID)
                    cmdCompra.Parameters.AddWithValue("@total", total)
                    compraID = Convert.ToInt32(cmdCompra.ExecuteScalar())
                End Using

                For Each row As DataGridViewRow In filasCompra
                    Dim productoID As Integer = Convert.ToInt32(row.Cells("colProducto").Value)
                    Dim cantidad As Integer = Convert.ToInt32(row.Cells("colCantidad").Value)
                    Dim precioUnitario As Decimal = Convert.ToDecimal(row.Cells("colPrecioUnitario").Value)

                    RegistrarDetalleYActualizarStock(compraID, productoID, cantidad, precioUnitario, connection, transaction)
                Next

                transaction.Commit()
                MessageBox.Show("Compra registrada con éxito.", "Éxito")

                ConfigurarDataGridViewCompra()
                CargarDetalleCompra(compraID)

            Catch ex As Exception
                transaction.Rollback()
                MessageBox.Show("Fallo la transacción: " & ex.Message, "Error de Compra", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub RegistrarDetalleYActualizarStock(ByVal compraID As Integer, ByVal productoID As Integer, ByVal cantidad As Integer, ByVal precio As Decimal, ByVal connection As MySqlConnection, ByVal transaction As MySqlTransaction)

        Dim queryDetalle As String = "INSERT INTO Detalle_Compras (id_compra, id_producto, cantidad, precio_compra) VALUES (@compraId, @productoId, @cantidad, @precio);"
        Using cmdDetalle As New MySqlCommand(queryDetalle, connection, transaction)
            cmdDetalle.Parameters.AddWithValue("@compraId", compraID)
            cmdDetalle.Parameters.AddWithValue("@productoId", productoID)
            cmdDetalle.Parameters.AddWithValue("@cantidad", cantidad)
            cmdDetalle.Parameters.AddWithValue("@precio", precio)
            cmdDetalle.ExecuteNonQuery()
        End Using

        Dim queryStock As String = "UPDATE Productos SET stock = stock + @cantidad WHERE id_producto = @id;"
        Using cmdStock As New MySqlCommand(queryStock, connection, transaction)
            cmdStock.Parameters.AddWithValue("@cantidad", cantidad)
            cmdStock.Parameters.AddWithValue("@id", productoID)
            cmdStock.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub CargarDetalleCompra(ByVal compraID As Integer)
        If compraID = 0 Then
            DataGridView1.DataSource = Nothing
            Exit Sub
        End If

        Dim query As String = "SELECT P.nombre, D.cantidad, D.precio_compra, (D.cantidad * D.precio_compra) AS Subtotal " &
                              "FROM Detalle_Compras AS D " &
                              "JOIN Productos AS P ON D.id_producto = P.id_producto " &
                              "WHERE D.id_compra = @compraId;"

        Try
            Dim dtDetalle As New DataTable()

            Using connection As New MySqlConnection(CONNECTION_STRING)
                Using adapter As New MySqlDataAdapter(query, connection)
                    adapter.SelectCommand.Parameters.AddWithValue("@compraId", compraID)
                    adapter.Fill(dtDetalle)
                End Using
            End Using

            DataGridView1.DataSource = dtDetalle

        Catch ex As Exception
            MessageBox.Show("Error al mostrar el detalle de la compra: " & ex.Message, "Error DB")
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        CargarNombresProveedoresConID()
        ConfigurarDataGridViewCompra()
        MessageBox.Show("Vistas actualizadas.", "Éxito")
    End Sub

    Private Sub cbxProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxProveedor.SelectedIndexChanged
        If cbxProveedor.SelectedValue IsNot Nothing Then
            Integer.TryParse(cbxProveedor.SelectedValue.ToString(), idProveedorSeleccionado)
        Else
            idProveedorSeleccionado = 0
        End If
    End Sub
End Class