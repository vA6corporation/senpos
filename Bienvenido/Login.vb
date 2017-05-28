Imports System.Data.SqlClient
Public Class Login
    Dim conex As New SqlConnection("Data Source=USUARIO-PC\SQLEXPRESS;Initial Catalog=senpos;Integrated Security=True")
    Private stCaja, stStock, stUser, stinfo As Boolean

    Private Sub Login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btIngresar_Click(sender As Object, e As EventArgs) Handles btIngresar.Click
        Try
            If tbUser.Text <> "" And tbPass.Text <> "" Then
                Dim comando As New SqlCommand("login_usuarios", conex)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.Add("@id", SqlDbType.VarChar, 24, ParameterDirection.Input).Value = tbUser.Text
                comando.Parameters.Add("@pass", SqlDbType.VarChar, 24, ParameterDirection.Input).Value = tbPass.Text
                comando.Parameters.Add("@respuesta", SqlDbType.Bit).Direction = ParameterDirection.Output
                Dim respuesta As Boolean
                conex.Open() : respuesta = comando.ExecuteNonQuery() : conex.Close()
                respuesta = comando.Parameters("@respuesta").Value.ToString()
                If respuesta = True Then
                    MessageBox.Show("Inicio exitoso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Bienvenido.btCaja.Enabled = True
                    Bienvenido.btProductos.Enabled = True
                    Bienvenido.btUsuarios.Enabled = True
                    Bienvenido.btInformes.Enabled = True
                    Bienvenido.btLogin.Enabled = False
                    Bienvenido.btLogout.Show()
                    Me.Close()
                Else
                    MessageBox.Show("Usuario o contraseña incorrectos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show("Campo vacio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Catch ex As Exception
            MsgBox("error inesperado")
        End Try


    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
        conex.Close()
    End Sub
End Class
