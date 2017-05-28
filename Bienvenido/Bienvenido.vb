Imports System.Data.SqlClient
Public Class Bienvenido

    Private login As New Login
    Private caja As New Caja
    Private stock As New Stock
    Private usuarios As New Usuarios
    Public usuarioLogin As String
    Private conex As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=senposDB.accdb")
    Private conexSql As New SqlConnection("Data Source=USUARIO-PC\SQLEXPRESS;Initial Catalog=Senpos;Integrated Security=True")

    Private Sub Bienvenido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexSql.Open()
            conex.Open()
        Catch ex As Exception
            If Err.Number = 5 Then
                MessageBox.Show("No se encontro la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                status.Show()
            End If
        End Try
        conexSql.Close()
        conex.Close()
    End Sub

    Private Sub btLogin_Click(sender As Object, e As EventArgs) Handles btLogin.Click
        Me.Hide()
        login.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btCaja_Click(sender As Object, e As EventArgs) Handles btCaja.Click
        Me.Hide()
        caja.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btStock_Click(sender As Object, e As EventArgs) Handles btProductos.Click
        Me.Hide()
        stock.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btRegistro_Click(sender As Object, e As EventArgs) Handles btUsuarios.Click
        Me.Hide()
        usuarios.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btInformes_Click(sender As Object, e As EventArgs) Handles btInformes.Click
        Me.Hide()
        MsgBox(DateTime.Now.ToString("dd/MM/yyyy"))
        Me.Show()
    End Sub

    Private Sub btLogout_Click(sender As Object, e As EventArgs) Handles btLogout.Click
        Application.Restart()
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        End
    End Sub

End Class
