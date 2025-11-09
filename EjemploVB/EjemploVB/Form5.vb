Imports MySql.Data.MySqlClient
Public Class Form5
    Dim conn As New MySqlConnection
    Dim formpadre As Form3
    Public Sub Padre(formulario As Form3)
        formpadre = formulario
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = conectar()
        'cargar el datagridview con los datos del dataset 
        Dim SQL As String
        SQL = "SELECT * from Clientes"
        DataGridView1.DataSource = cargar_grid(SQL, conn)
        'Dim logIn As Form2
        'logIn = New Form2()
        'While logIn.LogIn = 0
        'logIn.ShowDialog()
        'End While
        'CType(Me.MdiParent, Form3).Est(True, "CCli")
        If CType(formpadre, Form3).ObtPadre().LogIn() = 2 Then
            GroupBox1.Visible = False
            btsalir.Visible = True
            ct_correo.Enabled = False
            ct_direccion.Enabled = False
            ct_nombre.Enabled = False
            ct_telefono.Enabled = False
        End If
        ct_idCliente.Text = "0"
    End Sub
    Public Sub Show2(ByRef est As Boolean)
        Me.Show()
        est = True
    End Sub
    Private Sub btnuevo_Click(sender As Object, e As EventArgs) Handles btnuevo.Click
        Me.ct_idCliente.Text = "0"
        Me.ct_nombre.Text = ""
        Me.ct_direccion.Text = ""
        Me.ct_telefono.Text = ""
        Me.ct_correo.Text = ""
        Me.ct_nombre.Focus()
    End Sub

    Private Sub btguardar_Click(sender As Object, e As EventArgs) Handles btguardar.Click
        If ct_nombre.Text = "" Then
            MessageBox.Show("Digite el nombre del cliente")
            ct_nombre.Focus()
            Exit Sub
        End If
        If ct_direccion.Text = "" Then
            MessageBox.Show("Digite la dirección")
            ct_direccion.Focus()
            Exit Sub
        End If
        If ct_telefono.Text = "" Then
            MessageBox.Show("Digite el teléfono")
            ct_telefono.Focus()
            Exit Sub
        End If
        If ct_correo.Text = "" Then
            MessageBox.Show("Digite el correo")
            ct_correo.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Desea guardar el registro?", "Sistema de Inventario",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question,
       MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Dim SQL, var As String
        conn.Open()
        SQL = "select id_cliente from clientes WHERE id_cliente = '" &
       ct_idCliente.Text & "'"
        Dim cmd As New MySqlCommand(SQL, conn)
        cmd.CommandType = CommandType.Text
        Dim lectura As MySqlDataReader = cmd.ExecuteReader()
        If lectura.HasRows Then
            var = "Actualizado"
            SQL = "UPDATE clientes set nombre='" & ct_nombre.Text & "' " &
            ",direccion='" & ct_direccion.Text &
            "',telefono='" & ct_telefono.Text &
             "',email='" & ct_correo.Text &
            "' where id_cliente='" & ct_idCliente.Text & "'"
        Else
            var = "Guardado"
            SQL = "INSERT INTO clientes values(null,'" & ct_nombre.Text & "','" &
    ct_direccion.Text & "','" & ct_telefono.Text & "','" & ct_correo.Text & "')"

        End If
        lectura.Close()
        cmd.CommandText = SQL
        cmd.ExecuteNonQuery()
        MessageBox.Show("Registro " & var)
        btnuevo_Click(sender, e)
        SQL = "SELECT * from clientes order by nombre"
        DataGridView1.DataSource = cargar_grid(SQL, conn)
        conn.Close()
    End Sub

    Private Sub btborrar_Click(sender As Object, e As EventArgs) Handles btborrar.Click
        If ct_idCliente.Text = "" Then
            MessageBox.Show("Seleccione un cliente")
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
        SQL = "delete from clientes WHERE id_cliente = '" &
ct_idCliente.Text & "'"
        conn.Open()
        Dim cmd As New MySqlCommand(SQL, conn)
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        MessageBox.Show("Registro borrado")
        btnuevo_Click(Nothing, Nothing)
        SQL = "SELECT * from clientes order by nombre"
        DataGridView1.DataSource = cargar_grid(SQL, conn)
        conn.Close()
    End Sub

    Private Sub btsalir_Click(sender As Object, e As EventArgs) Handles btsalir.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim proveedor As String
        proveedor = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Dim SQL As String
        SQL = "SELECT * FROM clientes WHERE id_cliente = '" & proveedor &
        "'"
        conn.Open()
        Dim cmd As New MySqlCommand(SQL, conn)
        cmd.CommandType = CommandType.Text
        Dim lectura As MySqlDataReader = cmd.ExecuteReader()
        If lectura.Read = True Then
            Me.ct_idCliente.Text = lectura("id_cliente").ToString
            Me.ct_nombre.Text = lectura("nombre").ToString
            Me.ct_direccion.Text = lectura("direccion").ToString
            Me.ct_telefono.Text = lectura("telefono").ToString
            Me.ct_correo.Text = lectura("email").ToString
        End If
        lectura.Close()
        conn.Close()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'CType(form, Form3).Est(False, "CCli")
    End Sub

    Private Sub btnImp_Click(sender As Object, e As EventArgs) Handles btnImp.Click
        GridAExcelV2(DataGridView1, "Reporte Clientes")
    End Sub
End Class
