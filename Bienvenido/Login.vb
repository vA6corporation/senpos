Public Class Login
	
    Private conex As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=senposDB.accdb")
    Private comm As New OleDb.OleDbCommand
    Private comm2 As New OleDb.OleDbCommand
    Private dr As OleDb.OleDbDataReader
    Private stCaja, stStock, stUser, stinfo As Boolean
    
    Private Sub Login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            conex.Open()
            comm.Connection = conex
            comm.CommandType = CommandType.Text
            comm2.Connection = conex
            comm2.CommandType = CommandType.Text
        Catch ex As Exception
            MessageBox.Show("No se encontro la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub
    
    Private Sub btIngresar_Click(sender As Object, e As EventArgs) Handles btIngresar.Click
        Try
            If tbUser.Text <> "" And tbPass.Text <> "" Then
                If CheckUsuario(tbUser.Text, tbPass.Text) = True Then
                    MessageBox.Show("Inicio Exitoso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If stCaja = True Then
                        Bienvenido.btCaja.Enabled = True
                    End If
                    If stStock = True Then
                        Bienvenido.btStock.Enabled = True
                    End If
                    If stUser = True Then
                        Bienvenido.btUsuarios.Enabled = True
                    End If
                    If stinfo = True Then
                        Bienvenido.btInformes.Enabled = True
                    End If
                    Bienvenido.lUser.Text = Bienvenido.mainUsuario
                    Bienvenido.lUser.Show()
                    Bienvenido.lMain.Text = "Sistema de control de ventas y stock"
                    Bienvenido.btLogout.Show()
                    Bienvenido.btLogin.Enabled = False
                    conex.Close()
                    Me.Close()
                End If
            Else
                MessageBox.Show("Campo vacio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Catch ex As Exception
            MessageBox.Show("El Usuario no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    
    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
        conex.Close()
    End Sub

    Private Function CheckUsuario(ByRef id As Integer, pass As String)
        Dim a, b, c As Boolean
        comm.CommandText = "SELECT * FROM REGUSUARIO WHERE id=" & id & ""
        Try
            dr = comm.ExecuteReader()

            If dr.HasRows Then
                dr.Read()
                Bienvenido.mainUsuario = dr(2)
                stCaja = dr(6)
                stStock = dr(7)
                stUser = dr(8)
                stinfo = dr(9)
                a = True
            Else
                MessageBox.Show("El Usuario no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            dr.Close()
            
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        comm2.CommandText = "SELECT * FROM REGUSUARIO WHERE pass='" & pass & "'"
        Try
            dr = comm2.ExecuteReader()

            If dr.HasRows Then
                b = True
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        If a = True And b = False Then
            MessageBox.Show("Contraseña incorrecta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        c = a And b = True
        Return c
    End Function

End Class
