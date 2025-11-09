Imports MySql.Data.MySqlClient
Public Class Form4
    Dim conn As New MySqlConnection
    Dim id_producto As String = "0"
    Dim formpadre As Form3
    Public Sub Padre(formulario As Form3)
        formpadre = formulario
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = conectar()
        'cargar el datagridview con los datos del dataset 
        Dim SQL As String
        SQL = "SELECT * from Productos"
        DataGridView1.DataSource = cargar_grid(SQL, conn)
        'Dim logIn As Form2
        'logIn = New Form2()
        'While logIn.LogIn = 0
        'logIn.ShowDialog()
        'End While
        cb_idproveedor.DataSource = cargar_combo("SELECT id_proveedor FROM proveedores", conn)
        CType(formpadre, Form3).Est(True, "CProd")
        If CType(formpadre, Form3).ObtPadre().LogIn() = 2 Then
            GroupBox1.Visible = False
            btsalir.Visible = True
            cb_idproveedor.Enabled = False
            ct_descripcion.Enabled = False
            ct_nombre.Enabled = False
            ct_PC.Enabled = False
            ct_PorcGan.Enabled = False
            ctSt.Enabled = False
            ctStMin.Enabled = False
        End If
    End Sub
    Public Sub Show2(ByRef est As Boolean)
        Me.Show()
        est = True
    End Sub
    Private Sub btnuevo_Click(sender As Object, e As EventArgs) Handles btnuevo.Click
        Me.cb_idproveedor.Text = ""
        Me.ct_nombre.Text = ""
        Me.ct_descripcion.Text = ""
        Me.ct_PC.Text = ""
        Me.ct_PorcGan.Text = ""
        Me.ctSt.Text = ""
        Me.ctStMin.Text = ""
        Me.ct_nombre.Focus()
    End Sub

    Private Sub btguardar_Click(sender As Object, e As EventArgs) Handles btguardar.Click
        If ct_nombre.Text = "" Then
            MessageBox.Show("Digite el nombre del proveedor")
            ct_nombre.Focus()
            Exit Sub
        End If
        If ct_descripcion.Text = "" Then
            MessageBox.Show("Digite la descripción")
            ct_descripcion.Focus()
            Exit Sub
        End If
        If ct_PC.Text = "" Then
            MessageBox.Show("Digite el Precio de Compra")
            ct_PC.Focus()
            Exit Sub
        End If
        If ct_PorcGan.Text = "" Then
            MessageBox.Show("Digite el Porcentaje de Ganacia")
            ct_PorcGan.Focus()
            Exit Sub
        End If
        If cb_idproveedor.Text = "" Then
            MessageBox.Show("El ID del proveedor no puede estar vacío")
            cb_idproveedor.Focus()
            Exit Sub
        End If
        If ctSt.Text = "" Then
            MessageBox.Show("El Stock no puede estar vacío")
            ctSt.Focus()
        End If
        If ctStMin.Text = "" Then
            MessageBox.Show("El Stock Mínimo no puede estar vacío")
            ctStMin.Focus()
        End If
        If Double.Parse(ctStMin.Text) <= 0 Or Double.Parse(ctSt.Text) <= 0 Or Double.Parse(ct_PC.Text) <= 0 Or Double.Parse(ct_PorcGan.Text) <= 0 Then
            MessageBox.Show("ERROR no puede introducir números negativos")
            Exit Sub
        End If
        If MessageBox.Show("Desea guardar el registro?", "Sistema de Inventario",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question,
       MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        conn.Close()
        Dim SQL, var As String
        SQL = "select id_proveedor from productos WHERE id_producto = " & id_producto
        conn.Open()
        Dim cmd As New MySqlCommand(SQL, conn)
        cmd.CommandType = CommandType.Text
        Dim lectura As MySqlDataReader = cmd.ExecuteReader()
        Dim precio_venta As Double
        precio_venta = Val(ct_PC.Text) + (Val(ct_PC.Text) * Val(ct_PorcGan.Text) / 100)
        If lectura.HasRows Then
            var = "Actualizado"
            SQL = "UPDATE productos set nombre='" & ct_nombre.Text & "' " &
            ",descripcion='" & ct_descripcion.Text &
            "',precio_compra=" & ct_PC.Text &
             ",porcentaje_ganancia=" & ct_PorcGan.Text &
             ",stock=" & ctSt.Text &
             ",stock_minimo=" & ctStMin.Text &
             ",precio_venta=" & CType(precio_venta, String) &
             ",id_proveedor= " & cb_idproveedor.Text &
            " where id_producto=" & id_producto
        Else
            var = "Guardado"
            SQL = "INSERT INTO productos values(null,'" & ct_nombre.Text & "','" &
    ct_descripcion.Text & "','" & ct_PC.Text & "','" & ct_PorcGan.Text & "'," & CType(precio_venta, String) & "," & ctSt.Text & "," & ctStMin.Text & "," & cb_idproveedor.Text & ")"

        End If
        lectura.Close()
        cmd.CommandText = SQL
        cmd.ExecuteNonQuery()
        MessageBox.Show("Registro " & var)
        btnuevo_Click(Nothing, Nothing)
        SQL = "SELECT * from productos order by nombre"
        DataGridView1.DataSource = cargar_grid(SQL, conn)
        conn.Close()
        id_producto = "0"
    End Sub

    Private Sub btborrar_Click(sender As Object, e As EventArgs) Handles btborrar.Click
        If id_producto = "" Then
            MessageBox.Show("Seleccione un producto")
            Exit Sub
        End If
        If MessageBox.Show("Desea eliminar el registro?",
"Sistema de 
Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
       MessageBoxDefaultButton.Button1) =
Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Dim SQL As String
        SQL = "delete from productos WHERE id_producto = '" &
id_producto & "'"
        conn.Open()
        Dim cmd As New MySqlCommand(SQL, conn)
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        MessageBox.Show("Registro borrado")
        btnuevo_Click(Nothing, Nothing)
        SQL = "SELECT * from productos order by nombre"
        DataGridView1.DataSource = cargar_grid(SQL, conn)
        conn.Close()
        id_producto = "0"
    End Sub

    Private Sub btsalir_Click(sender As Object, e As EventArgs) Handles btsalir.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim producto As String
        conn.Close()
        producto = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Dim SQL As String
        conn.Open()
        SQL = "SELECT * FROM productos WHERE id_producto = '" & producto &
        "'"
        Dim cmd As New MySqlCommand(SQL, conn)
        cmd.CommandType = CommandType.Text
        Dim lectura As MySqlDataReader = cmd.ExecuteReader()
        If lectura.Read = True Then
            Me.id_producto = lectura("id_producto").ToString
            Me.ct_nombre.Text = lectura("nombre").ToString
            Me.ct_descripcion.Text = lectura("descripcion").ToString
            Me.ct_PC.Text = lectura("precio_compra").ToString
            Me.ct_PorcGan.Text = lectura("porcentaje_ganancia").ToString
            Me.ctSt.Text = lectura("stock").ToString
            Me.ctStMin.Text = lectura("stock_minimo").ToString
            Me.cb_idproveedor.Text = lectura("id_proveedor").ToString
        End If
        lectura.Close()
        conn.Close()
    End Sub

    Private Sub Form4_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CType(formpadre, Form3).Est(False, "CProd")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GridAExcelV2(DataGridView1, "Catalogo de Productos")
    End Sub
End Class
