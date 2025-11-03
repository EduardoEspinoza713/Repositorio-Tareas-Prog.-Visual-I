Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader
Imports System.Runtime.CompilerServices
Imports MySql.Data.MySqlClient
Module Module1
    Public Function conectar()
        Dim conexion = New MySqlConnection
        Try
            conexion.ConnectionString = "server=localhost;userid=root;password=1234;database=inventario;"
            conexion.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido realizar la conexion a la base de 
datos.")
            End
        End Try
        conexion.Close()
        Return conexion
    End Function
    Public Function crear_vistas(ByVal consulta As String, ByRef con As MySqlConnection, ByVal nom As String)
        con.Open()
        Dim vista = $"drop view if exists {nom}; create view {nom} as {consulta};"
        Dim com As MySqlCommand
        com = New MySqlCommand(vista, con)
        com.ExecuteNonQuery()
        con.Close()
        Return 0
    End Function
    Function cargar_grid(ByVal sql As String, ByVal conn As MySqlConnection)
        Dim da As New MySqlDataAdapter(sql, conn)
        Dim ds As New DataSet
        da.Fill(ds)
        Return ds.Tables(0)
    End Function
    Function cargar_combo(ByVal sql As String, ByVal conn As MySqlConnection)
        Dim lista As List(Of String) = New List(Of String)
        Dim ord As MySqlCommand
        ord = New MySqlCommand(sql, conn)
        conn.Open()
        ord.CommandType = CommandType.Text
        Dim lectura As MySqlDataReader = ord.ExecuteReader()
        While lectura.Read()
            lista.Add(lectura(0).ToString())
        End While
        Return lista
    End Function
    Function EjecutarSelect(ByVal orden As String, ByVal con As MySqlConnection)
        con.Open()
        Dim ord As MySqlCommand
        ord = New MySqlCommand(orden, con)
        ord.CommandType = CommandType.Text
        Dim lectura As MySqlDataReader = ord.ExecuteReader()
        If lectura.HasRows Then
            con.Close()
            Return True
        Else
            con.Close()
            Return False
        End If
    End Function
    Function EjecutarOrden(ByVal orden As String, ByVal con As MySqlConnection)
        Dim ord As MySqlCommand
        Dim colAfectadas As Integer
        ord = New MySqlCommand(orden, con)
        con.Open()
        ord.CommandType = CommandType.Text
        colAfectadas = ord.ExecuteNonQuery()
        con.Close()
        Return colAfectadas
    End Function

End Module
