Imports MySql.Data.MySqlClient
Public Class Form6
    Dim tabla As String
    Dim var_comparacion As String
    Dim est As String
    Dim formpadre As Form3
    Public Sub Padre(formulario As Form3)
        formpadre = formulario
    End Sub
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
        'CType(Me.MdiParent, Form3).Est(True, est)
        crear_vistas(SQL, con, "mi_vista1")
        con.Open()
        Dim total As Double
        Dim com As New MySqlCommand("select sum(total) as S_Total from mi_vista1", con)
        Dim lec As MySqlDataReader = com.ExecuteReader()
        lec.Read()
        total = Double.Parse(lec.Item("S_Total").ToString())
        lblTot.Text = $"Total: {total}"
        con.Close()
    End Sub
    Public Property data As DataSet
        Get
            Return CType(DataGridView1.DataSource, DataTable).DataSet
        End Get
        Set(value As DataSet)
            DataGridView1.DataSource = value.Tables(0)
        End Set
    End Property
    Private Sub btnRF_Click(sender As Object, e As EventArgs) Handles btnRF.Click
        Dim con As MySqlConnection
        con = conectar()
        con.Open()
        Dim SQL As String = $"select * from {tabla} where {var_comparacion} BETWEEN '{dtpFMin.Value.ToString("yyyy-MM-dd")}' AND '{dtpFMax.Value.ToString("yyyy-MM-dd")}'"
        DataGridView1.DataSource = cargar_grid(SQL, con)
        con.Close()
        crear_vistas(SQL, con, "mi_vista")
        con.Open()
        Dim total As Double
        Dim com As New MySqlCommand("select sum(total) as S_Total from mi_vista", con)
        Dim lec As MySqlDataReader = com.ExecuteReader()
        lec.Read()
        total = Double.Parse(lec.Item("S_Total").ToString())
        lblTot.Text = $"Total: {total}"
        con.Close()
    End Sub

    Private Sub Form6_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'CType(Me.MdiParent, Form3).Est(False, est)
    End Sub

    Private Sub btnImp_Click(sender As Object, e As EventArgs) Handles btnImp.Click
        GridAExcelV2(DataGridView1, $"{Me.Text}: {lblTot.Text}")
    End Sub
End Class