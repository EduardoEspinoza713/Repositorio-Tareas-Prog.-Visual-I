Imports MySql.Data.MySqlClient
Public Class Form7
    Dim consulta As String
    Dim conn As MySqlConnection
    Dim est As String
    Dim formpadre As Form3
    Public Sub Padre(formulario As Form3)
        formpadre = formulario
    End Sub
    Public Sub New(ByVal tit As String, ByVal con As String, ByVal estd As String)
        InitializeComponent()
        Me.Text = tit
        consulta = con
        conn = conectar()
        est = estd
    End Sub
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        DataGridView1.DataSource = cargar_grid(consulta, conn)
        conn.Close()
        'CType(Me.MdiParent, Form3).Est(True, est)
        MessageBox.Show("Puede Filtrar ya sea por ID del proveedor o por el nombre del producto, si deja ambos campos vaciós se mostrará por defecto todos los registros de la tabla de ganacias")
    End Sub

    Private Sub Form7_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'CType(Me.MdiParent, Form3).Est(False, est)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnFP_Click(sender As Object, e As EventArgs) Handles btnFP.Click
        crear_vistas(consulta, conn, "mi_vista")
        conn.Open()
        If (ctNomP.Text = "" And ctIDP.Text = "") Then
            DataGridView1.DataSource = cargar_grid(consulta, conn)
            conn.Close()
            Exit Sub
        End If
        If (ctNomP.Text = "" Or (ctNomP.Text <> "" And ctIDP.Text <> "")) Then
            DataGridView1.DataSource = cargar_grid($"select * from mi_vista where id_proveedor={ctIDP.Text}", conn)
            conn.Close()
            Exit Sub
        End If
        If (ctIDP.Text = "") Then
            DataGridView1.DataSource = cargar_grid($"select * from mi_vista where Producto='{ctNomP.Text}'", conn)
            conn.Close()
            Exit Sub
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GridAExcelV2(DataGridView1, $"{Me.Text}")
    End Sub
End Class