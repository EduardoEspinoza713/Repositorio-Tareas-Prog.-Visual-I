Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports MySql.Data.MySqlClient

Public Class Form2
    Dim log As Integer = 0
    Dim aggu As Integer = 0
    Dim formPrin As Form3
    Private Sub btnIniSes_Click(sender As Object, e As EventArgs) Handles btnIniSes.Click
        'btnAggU.Enabled = False
        Dim con As MySqlConnection
        con = conectar()
        'con.Close()

        If (EjecutarSelect($"select * from usuarios where username='{ctUs.Text}' and password=md5('{ctContra.Text}')", con) = True) Then
            MessageBox.Show("Ha iniciado sesión correctamente")
            formPrin = New Form3()
            formPrin.Padre(Me)
            Me.Visible = False
            'Me.Close()
            Dim odr As MySqlCommand
            con.Open()
            odr = New MySqlCommand($"select rol from usuarios where username='{ctUs.Text}' and password=md5('{ctContra.Text}')", con)
            Dim lectura As MySqlDataReader = odr.ExecuteReader()
            lectura.Read()
            If (lectura("rol").ToString() = "administrador") Then
                log = 1
                MessageBox.Show("Su sesión tiene permisos administrativos")
            Else
                log = 2
            End If
            formPrin.Show()
        Else
            MessageBox.Show("Error en el inicio de sesión")
            btnCan_Click(sender, e)
        End If
    End Sub
    Public Function LogIn()
        Return log
    End Function
    Private Sub btnCan_Click(sender As Object, e As EventArgs) Handles btnCan.Click
        btnAggU.Enabled = True
        btnIniSes.Enabled = True
        ctContra.Text = ""
        ctRol.Text = ""
        ctUs.Text = ""
        lblRol.Visible = False
        ctRol.Visible = False
    End Sub

    Private Sub btnAggU_Click(sender As Object, e As EventArgs) Handles btnAggU.Click
        If aggu = 0 Then
            btnCan_Click(sender, e)
            btnIniSes.Enabled = False
            btnAggU.Text = "Guardar Usuario"
            ctRol.Text = "vendedor"
            lblRol.Visible = True
            ctRol.Visible = True
            aggu = 1
        End If
        If (ctRol.Text = "" Or ctContra.Text = "" Or ctUs.Text = "") Then
            MessageBox.Show("Por favor LLene todos los campos")
            ctRol.Focus()
            Exit Sub
        End If
        If (aggu = 1) Then
            If (EjecutarSelect($"Select * from usuarios where username='{ctUs.Text}'", conectar())) Then
                MessageBox.Show("El nombre de usuario ya existe, por favor elija otro.")
                ctUs.Focus()
                Exit Sub
            Else
                EjecutarOrden($"insert into usuarios (username, password, rol) values ('{ctUs.Text}', md5('{ctContra.Text}'), '{ctRol.Text}')", conectar())
                MessageBox.Show("Usuario agregado correctamente.")
                aggu = 0
            End If
        End If
        btnCan_Click(sender, e)
        btnAggU.Text = "Agregar Usuario"
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (tablaVacia("Usuarios", conectar())) Then
            MessageBox.Show("Se ha detectado que no hay usuarios, se crearan 2 usuarios por defecto, ambos con contraseña 1234")
            crearUsr("admin", "1234", 1, conectar())
            crearUsr("vend", "1234", 2, conectar())
        End If
        If (EjecutarOrden($"select * from Usuarios where rol='administrador';", conectar()) = 0) Then
            MessageBox.Show("Se ha detectado que no hay usuarios administradores, se creará2 un admin. por defecto,con contraseña 1234")
            crearUsr("admin", "1234", 1, conectar())
        End If
        If (EjecutarOrden($"select * from Usuarios where rol='vendedor';", conectar()) = 0) Then
            MessageBox.Show("Se ha detectado que no hay usuarios vendedores, se creará un vendedor por defecto,con contraseña 1234")
            crearUsr("vend", "1234", 2, conectar())
        End If
        btnCan_Click(sender, e)
    End Sub
End Class