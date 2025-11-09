Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class Ventas
    Private Const CONNECTION_STRING As String = "Server=localhost;Database=inventario;Uid=root;Pwd=1234;"
    Private idClienteSeleccionado As Integer = 0

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarNombresClientesConID()
        ConfigurarDataGridViewVenta()
        CargarDetalleVenta(0)
    End Sub

    Private Function ObtenerProductosCatalogo() As DataTable
        Dim query As String = "SELECT id_producto, nombre, precio_venta, stock FROM Productos ORDER BY nombre"
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

    Private Sub ConfigurarDataGridViewVenta()
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

    Private Sub CargarNombresClientesConID()
        Dim query As String = "SELECT id_cliente, nombre FROM Clientes ORDER BY nombre"

        Try
            Dim dtClientes As New DataTable()

            Using connection As New MySqlConnection(CONNECTION_STRING)
                Dim adapter As New MySqlDataAdapter(query, connection)
                adapter.Fill(dtClientes)
            End Using

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
            Dim precio As Decimal = foundRows(0).Field(Of Decimal)("precio_venta")

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

    Private Sub btnIngreso_Click(sender As Object, e As EventArgs) Handles btnIngreso.Click
        If idClienteSeleccionado = 0 Then
            MessageBox.Show("Seleccione un cliente.", "Error")
            Exit Sub
        End If

        Dim totalVentaCalculado As Decimal = 0.0D
        Dim productosParaVender As New List(Of DataGridViewRow)()

        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow AndAlso row.Cells("colProducto").Value IsNot Nothing Then
                Dim subtotal As Decimal = 0.0D
                Dim cantidad As Integer = 0

                If Decimal.TryParse(row.Cells("colSubtotal").Value?.ToString(), subtotal) AndAlso
                   Integer.TryParse(row.Cells("colCantidad").Value?.ToString(), cantidad) AndAlso
                   cantidad > 0 Then

                    totalVentaCalculado += subtotal
                    productosParaVender.Add(row)
                ElseIf row.Cells("colProducto").Value IsNot Nothing Then
                    MessageBox.Show("El producto seleccionado requiere una cantidad mayor a cero.", "Error de Cantidad")
                    Exit Sub
                End If
            End If
        Next

        If totalVentaCalculado <= 0 Then
            MessageBox.Show("Debe agregar al menos un producto con cantidad válida.", "Error")
            Exit Sub
        End If

        RegistrarVentaCompleta(idClienteSeleccionado, totalVentaCalculado, productosParaVender)
    End Sub

    Private Sub RegistrarVentaCompleta(ByVal clienteID As Integer, ByVal total As Decimal, ByVal filasVenta As List(Of DataGridViewRow))

        Using connection As New MySqlConnection(CONNECTION_STRING)
            connection.Open()
            Dim transaction As MySqlTransaction = connection.BeginTransaction()

            Try
                Dim queryVenta As String = "INSERT INTO Ventas (fecha_venta, id_cliente, total) VALUES (NOW(), @cliente, @total); SELECT LAST_INSERT_ID();"
                Dim ventaID As Integer

                Using cmdVenta As New MySqlCommand(queryVenta, connection, transaction)
                    cmdVenta.Parameters.AddWithValue("@cliente", clienteID)
                    cmdVenta.Parameters.AddWithValue("@total", total)
                    ventaID = Convert.ToInt32(cmdVenta.ExecuteScalar())
                End Using

                For Each row As DataGridViewRow In filasVenta
                    Dim productoID As Integer = Convert.ToInt32(row.Cells("colProducto").Value)
                    Dim cantidad As Integer = Convert.ToInt32(row.Cells("colCantidad").Value)
                    Dim precioUnitario As Decimal = Convert.ToDecimal(row.Cells("colPrecioUnitario").Value)

                    If VerificarStock(productoID, cantidad) Then
                        RegistrarDetalleYActualizarStock(ventaID, productoID, cantidad, precioUnitario, connection, transaction)
                    Else
                        Throw New Exception($"Stock insuficiente para producto {row.Cells("colProducto").FormattedValue.ToString()}. Cantidad solicitada: {cantidad}")
                    End If
                Next

                transaction.Commit()
                MessageBox.Show("Venta registrada con éxito.", "Éxito")


                ConfigurarDataGridViewVenta()

            Catch ex As Exception
                transaction.Rollback()
                MessageBox.Show("Fallo la transacción: " & ex.Message, "Error de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub RegistrarDetalleYActualizarStock(ByVal ventaID As Integer, ByVal productoID As Integer, ByVal cantidad As Integer, ByVal precio As Decimal, ByVal connection As MySqlConnection, ByVal transaction As MySqlTransaction)

        Dim queryDetalle As String = "INSERT INTO Detalle_Ventas (id_venta, id_producto, cantidad, precio_unitario) VALUES (@ventaId, @productoId, @cantidad, @precio);"
        Using cmdDetalle As New MySqlCommand(queryDetalle, connection, transaction)
            cmdDetalle.Parameters.AddWithValue("@ventaId", ventaID)
            cmdDetalle.Parameters.AddWithValue("@productoId", productoID)
            cmdDetalle.Parameters.AddWithValue("@cantidad", cantidad)
            cmdDetalle.Parameters.AddWithValue("@precio", precio)
            cmdDetalle.ExecuteNonQuery()
        End Using

        Dim queryStock As String = "UPDATE Productos SET stock = stock - @cantidad WHERE id_producto = @id;"
        Using cmdStock As New MySqlCommand(queryStock, connection, transaction)
            cmdStock.Parameters.AddWithValue("@cantidad", cantidad)
            cmdStock.Parameters.AddWithValue("@id", productoID)
            cmdStock.ExecuteNonQuery()
        End Using
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
            DataGridView1.DataSource = Nothing
            Exit Sub
        End If

        Dim query As String = "SELECT P.nombre, D.cantidad, D.precio_unitario, (D.cantidad * D.precio_unitario) AS Subtotal " &
                              "FROM Detalle_Ventas AS D " &
                              "JOIN Productos AS P ON D.id_producto = P.id_producto " &
                              "WHERE D.id_venta = @ventaId;"

        Try
            Dim dtDetalle As New DataTable()

            Using connection As New MySqlConnection(CONNECTION_STRING)
                Using adapter As New MySqlDataAdapter(query, connection)
                    adapter.SelectCommand.Parameters.AddWithValue("@ventaId", ventaID)
                    adapter.Fill(dtDetalle)
                End Using
            End Using

            DataGridView1.DataSource = dtDetalle

        Catch ex As Exception
            MessageBox.Show("Error al mostrar el detalle de la venta: " & ex.Message, "Error DB")
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        CargarNombresClientesConID()
        ConfigurarDataGridViewVenta()
        MessageBox.Show("Vistas actualizadas.", "Éxito")
    End Sub

    Private Sub SeleccionarCliente() Handles cbxCliente.SelectedIndexChanged
        If cbxCliente.SelectedValue IsNot Nothing AndAlso Integer.TryParse(cbxCliente.SelectedValue.ToString(), idClienteSeleccionado) Then
        Else
            idClienteSeleccionado = 0
        End If
    End Sub
End Class