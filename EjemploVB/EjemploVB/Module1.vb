Imports Microsoft.Office.Interop.Excel
Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader
Imports System.Runtime.CompilerServices
Imports Microsoft.ReportingServices.Rendering.ExcelRenderer
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
    Function GridAExcel(ByVal Datagridview1 As DataGridView) As Boolean
        Dim exapp As New Application
        Dim exlibro As Workbook
        Dim exhoja As Worksheet
        Try
            exlibro = exapp.Workbooks.Add
            exhoja = exlibro.Worksheets.Add()
            'Numero de Filas y columnas 
            Dim ncol As Integer = Datagridview1.ColumnCount
            Dim nrow As Integer = Datagridview1.RowCount
            For i As Integer = 1 To ncol
                exhoja.Cells.Item(1, i) = Datagridview1.Columns(i - 1).Name.ToString
                exhoja.Cells.Item(1, i).horizontalalignment = 3
            Next
            For fila As Integer = 0 To nrow - 1
                For col As Integer = 0 To ncol - 1
                    exhoja.Cells.Item(fila + 2, col + 1) =
Datagridview1.Rows(fila).Cells(col).Value
                Next
            Next
            'Titulo en negrita alineado al centro y que el tamaño de la columna se ajuste al texto 
            exhoja.Rows.Item(1).font.bold = 1
            exhoja.Rows.Item(1).horizontalalignment = 3

            exhoja.Columns.AutoFit()
            exapp.Application.Visible = True
            exhoja = Nothing
            exlibro = Nothing
            exapp = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al Exportar a Excel")
            Return False
        End Try
        Return True
    End Function
    Function GridAExcelV2(ByVal Datagridview1 As DataGridView, ByVal Encabezado As String) As Boolean
        Dim exapp As New Microsoft.Office.Interop.Excel.Application
        Dim exlibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exhoja As Microsoft.Office.Interop.Excel.Worksheet

        Try
            exlibro = exapp.Workbooks.Add
            exhoja = exlibro.Worksheets.Add()
            'Numero de Filas y columnas
            Dim ncol As Integer = Datagridview1.ColumnCount
            Dim RangoEncabezado As Microsoft.Office.Interop.Excel.Range
            RangoEncabezado = exhoja.Range("A1", exhoja.Cells(1, ncol))
            RangoEncabezado.Merge()

            RangoEncabezado.Value = Encabezado

            With RangoEncabezado
                .HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
                .VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                .Font.Bold = True
                .Font.Size = 14
                .Interior.Color = RGB(173, 216, 230)
                .RowHeight = 25
            End With

            For i As Integer = 1 To ncol
                exhoja.Cells.Item(2, i) = Datagridview1.Columns(i - 1).HeaderText.ToString
                exhoja.Cells.Item(2, i).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
            Next

            With exhoja.Rows.Item(2).Font
                .Bold = True
            End With

            Dim nrow As Integer = Datagridview1.RowCount
            For fila As Integer = 0 To nrow - 1
                For col As Integer = 0 To ncol - 1
                    exhoja.Cells.Item(fila + 3, col + 1) = Datagridview1.Rows(fila).Cells(col).Value
                Next
            Next
            'Titulo en negrita alineado al centro y que el tamaño de la columna se ajuste al texto
            exhoja.Columns.AutoFit()

            exapp.Application.Visible = True

            System.Runtime.InteropServices.Marshal.ReleaseComObject(exhoja)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(exlibro)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(exapp)

            exhoja = Nothing
            exlibro = Nothing
            exapp = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al Exportar a Excel")

            If Not exapp Is Nothing Then
                exapp.Quit()
            End If

            Return False
        End Try
        Return True
    End Function

    Private Function RGB(ByVal R As Integer, ByVal G As Integer, ByVal B As Integer) As Integer
        Return R Or (&H100 * G) Or (&H10000 * B)
    End Function
    Public Function tablaVacia(ByVal nom As String, ByVal con As MySqlConnection) As Boolean
        If (EjecutarSelect($"select * from {nom}", con)) Then
            Return False
        End If
        Return True
    End Function
    Public Sub crearUsr(ByVal nom As String, ByVal cont As String, ByVal rol As Integer, ByVal con As MySqlConnection)
        If (EjecutarOrden($"select * from Usuarios where username='{nom}';", con) > 0) Then
            MessageBox.Show("ERROR al crear el Usuarion el nombre ya estaba ocupado")
            Exit Sub
        End If

        Select Case rol
            Case 1
                EjecutarOrden($"insert into Usuarios(username, password, rol) values('{nom}', MD5('{cont}'), 'administrador');", con)
            Case Else
                EjecutarOrden($"insert into Usuarios(username, password, rol) values('{nom}', MD5('{cont}'), 'vendedor');", con)
        End Select
        MessageBox.Show($"Usuario {nom} creado exitosamente")
    End Sub
End Module
