Imports MySql.Data.MySqlClient
Public Class Form8
    Dim id As String = ""
    Private Sub btnSal_Click(sender As Object, e As EventArgs) Handles btnSal.Click
        Me.Close()
        CType(Me.MdiParent, Form3).Est(False, "AdmiUs")
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As MySqlConnection
        conn = conectar()
        conn.Open()
        Dim SQL As String
        SQL = "SELECT * from usuarios;"
        DataGridView1.DataSource = cargar_grid(SQL, conn)
        conn.Close()
        CType(Me.MdiParent, Form3).Est(True, "AdmiUs")
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim conn As MySqlConnection
        conn = conectar()
        Dim proveedor As String
        proveedor = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Dim SQL As String
        SQL = "SELECT * FROM usuarios where id_usuario=" & proveedor & ";"
        conn.Open()
        Dim cmd As New MySqlCommand(SQL, conn)
        cmd.CommandType = CommandType.Text
        Dim lectura As MySqlDataReader = cmd.ExecuteReader()
        If lectura.Read = True Then
            ctUs.Text = lectura("username").ToString()
            ctContra.Text = lectura("password").ToString()
            cbRol.Text = lectura("rol").ToString()
            id = lectura("id_usuario").ToString()
        End If
        lectura.Close()
        conn.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ctUs.Text = ""
        ctContra.Text = ""
        cbRol.Text = ""
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim conn As MySqlConnection
        conn = conectar()
        If ctUs.Text = "" Then
            MessageBox.Show("Digite el nombre del usuario")
            ctUs.Focus()
            Exit Sub
        End If
        If ctContra.Text = "" Then
            MessageBox.Show("Digite la contraseña")
            ctContra.Focus()
            Exit Sub
        End If
        If cbRol.Text = "" Then
            MessageBox.Show("Seleccione un rol")
            cbRol.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Desea guardar el registro?", "Sistema de Inventario",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question,
       MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Dim SQL, var As String
        conn.Open()
        SQL = "select * from usuarios WHERE id_usuario = " & id & ";"
        Dim cmd As New MySqlCommand(SQL, conn)
        cmd.CommandType = CommandType.Text
        Dim lectura As MySqlDataReader = cmd.ExecuteReader()
        If lectura.HasRows Then
            var = "Actualizado"
            SQL = "UPDATE usuarios set username='" & ctUs.Text & "' " &
            ",password=md5('" & ctContra.Text &
            "',rol='" & cbRol.Text &
            "' where id_usuario='" & id & "'"
        Else
            var = "Guardado"
            SQL = "INSERT INTO usuarios values(null,'" & ctUs.Text & "','" &
    ctContra.Text & "','" & cbRol.Text & "')"

        End If
        lectura.Close()
        cmd.CommandText = SQL
        cmd.ExecuteNonQuery()
        MessageBox.Show("Registro " & var)
        btnNuevo_Click(Nothing, Nothing)
        SQL = "SELECT * from usuarios order by id_usuario"
        DataGridView1.DataSource = cargar_grid(SQL, conn)
        conn.Close()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim conn As MySqlConnection
        conn = conectar()
        If id = "" Then
            MessageBox.Show("Seleccione un Usuario")
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
        SQL = "delete from usuarios WHERE id_usuario = '" &
id & "'"
        conn.Open()
        Dim cmd As New MySqlCommand(SQL, conn)
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        MessageBox.Show("Registro borrado")
        btnNuevo_Click(Nothing, Nothing)
        SQL = "SELECT * from usuarios order by id_usuario"
        DataGridView1.DataSource = cargar_grid(SQL, conn)
        conn.Close()
    End Sub
End Class