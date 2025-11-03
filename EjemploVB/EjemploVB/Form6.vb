Imports MySql.Data.MySqlClient
Public Class Form6
    Dim tabla As String
    Dim var_comparacion As String
    Dim est As String
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(ByVal tabla As String, ByVal comp As String, ByVal estd As String)
        InitializeComponent()
        Me.tabla = tabla
        Me.var_comparacion = comp
        est = estd
        Me.Text = $"Reporte de {tabla} por rango de fechas"
    End Sub
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As MySqlConnection
        con = conectar()
        con.Open()
        Dim SQL As String = $"select * from {tabla}"
        DataGridView1.DataSource = cargar_grid(SQL, con)
        con.Close()
        CType(Me.MdiParent, Form3).Est(True, est)
    End Sub

    Private Sub btnRF_Click(sender As Object, e As EventArgs) Handles btnRF.Click
        Dim con As MySqlConnection
        con = conectar()
        con.Open()
        Dim SQL As String = $"select * from {tabla} where {var_comparacion} BETWEEN '{dtpFMin.Value.ToString("yyyy-MM-dd")}' AND '{dtpFMax.Value.ToString("yyyy-MM-dd")}'"
        DataGridView1.DataSource = cargar_grid(SQL, con)
    End Sub

    Private Sub Form6_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CType(Me.MdiParent, Form3).Est(False, est)
    End Sub

    Private Sub btnImp_Click(sender As Object, e As EventArgs) Handles btnImp.Click

    End Sub
End Class