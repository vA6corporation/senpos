Imports System.Data.SqlClient

Public Class Usuarios

    Private conex As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=senposDB.accdb")
    Private comm As New OleDb.OleDbCommand
    Private dr As OleDb.OleDbDataReader
    Private conexSql As New SqlConnection("Data Source=USUARIO-PC\SQLEXPRESS;Initial Catalog=Senpos;Integrated Security=True")

    Private Sub Registro_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            conexSql.Open()
            conex.Open()
        Catch ex As Exception
            If Err.Number = 5 Then
                MessageBox.Show("No se encontro la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
        End Try
        conexSql.Close()
        conex.Close()
        getLista()
    End Sub

    Private Sub getLista()
        Dim sqlSelect As String = "SELECT * FROM REGUSUARIO"
        comm.CommandText = sqlSelect
        Try
            dr = comm.ExecuteReader()
            If dr.HasRows Then
                While dr.Read()
                    dgvLista.Rows.Add("Detalles", dr(2), dr(3), dr(0))
                End While
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub getRegistro()
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim strSql As String = "SELECT * FROM REGUSUARIO"
        Dim adp As New OleDb.OleDbDataAdapter(strSql, conex)
        ds.Tables.Add("tabla")
        adp.Fill(ds.Tables("tabla"))
        Me.dgvLista.DataSource = ds.Tables("tabla")
    End Sub

    Private Sub ButtonRegistro_Click(sender As Object, e As EventArgs) Handles buttonRegistro.Click
        If flCampos() = True Then
            MessageBox.Show("Faltan datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf flDNI() = False Then
            MessageBox.Show("DNI incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf flTelefono() = False Then
            MessageBox.Show("Celular debe contar con 9 digitos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            setRegistro()
        End If
    End Sub

    Private Sub setRegistro()
        MessageBox.Show("Nombres: " + tbNombre.Text() + Chr(13) + "Apellidos: " + tbApellido.Text() + Chr(13) +
                           "DNI. N°: " + tbDni.Text() + Chr(13) + "Telefono: " + tbCeluar.Text() + Chr(13) +
                              "ID: " + tbId.Text() + Chr(13) + "Contraseña: " + tbPass.Text())

        comm.CommandText = "INSERT INTO regUsuario (id,pass,nombre,apellido,dni,cel,caja,stock,usuarios,info) VALUES (" & tbId.Text & ",'" & tbPass.Text &
            "','" & tbNombre.Text & "','" & tbApellido.Text & "'," & tbDni.Text & "," & tbCeluar.Text & "," & cbCaja.Checked & "," & cbStock.Checked &
            "," & cbUser.Checked & "," & cbInfo.Checked & ")"

        Try
            comm.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(Err.Number & "-" & Err.Description)
        End Try

    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        panelRegistro.Hide()
    End Sub

    Private Sub dgvLista_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLista.CellContentClick
        If e.ColumnIndex = 0 Then
            Dim codigo As Integer = dgvLista.CurrentRow.Cells(3).Value
            Dim sqlSelect As String = "SELECT * FROM REGUSUARIO WHERE ID=" & codigo
            comm.CommandText = sqlSelect
            Try
                dr = comm.ExecuteReader()
                If dr.HasRows Then
                    Detalles.ShowDialog()
                    While dr.Read()

                        Detalles.tbId.Text = dr(0)
                        Detalles.tbPass.Text = dr(1)
                        Detalles.tbNombre.Text = dr(2)
                        Detalles.tbApellido.Text = dr(3)
                        Detalles.tbDni.Text = dr(4)
                        Detalles.tbCeluar.Text = dr(5)
                        Detalles.cbCaja.CheckState = dr(6)
                        Detalles.cbStock.CheckState = dr(7)
                        Detalles.cbUser.CheckState = dr(8)
                        Detalles.cbInfo.CheckState = dr(9)
                    End While

                End If
                dr.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Function flCampos()
        Dim a As Boolean

        a = tbNombre.Text() = "" Or tbApellido.Text() = "" Or tbDni.Text() = "" Or tbCeluar.Text() =
            "" Or tbId.Text() = "" Or tbPass.Text() = ""

        Return a
    End Function

    Private Function flDNI()
        Dim a As Boolean

        a = Len(tbDni.Text) = 8

        Return a
    End Function

    Private Function flTelefono()
        Dim a As Boolean
        a = Len(tbCeluar.Text) = 9
        Return a
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        conex.Close()
    End Sub
End Class