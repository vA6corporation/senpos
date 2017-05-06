Public Class Bienvenido
	
    Private login As New Login
    Private caja As New Caja
    Private stock As New Stock
    Private usuarios As New Usuarios
    Public mainUsuario As String
    
    Private Sub Bienvenido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conex As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=senposDB.accdb")
        Dim comm As New OleDb.OleDbCommand
        Try
            conex.Open()
            comm.Connection = conex
            comm.CommandType = CommandType.Text
            'MsgBox("primero se carga esta parte")
        Catch ex As Exception
            If Err.Number = 5 Then
                MessageBox.Show("No se encontro la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                status.Show()
            End If
        End Try

    End Sub

    Private Sub btLogin_Click(sender As Object, e As EventArgs) Handles btLogin.Click
        login.ShowDialog()
    End Sub

    Private Sub btCaja_Click(sender As Object, e As EventArgs) Handles btCaja.Click
        caja.ShowDialog()
    End Sub

    Private Sub btStock_Click(sender As Object, e As EventArgs) Handles btStock.Click
        stock.ShowDialog()
    End Sub

    Private Sub btRegistro_Click(sender As Object, e As EventArgs) Handles btUsuarios.Click
        usuarios.ShowDialog()
    End Sub

    Private Sub btInformes_Click(sender As Object, e As EventArgs) Handles btInformes.Click
        MsgBox(DateTime.Now.ToString("dd/MM/yyyy"))
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        End
    End Sub

    Private Sub btLogout_Click(sender As Object, e As EventArgs) Handles btLogout.Click
        Application.Restart()
    End Sub
    
End Class
