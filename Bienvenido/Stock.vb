Public Class Stock
	
    Private conex As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=senposDB.accdb")
    Private comm As New OleDb.OleDbCommand
    Private dr As OleDb.OleDbDataReader
    Private ds As New DataSet
    Private dt As New DataTable
    
    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getRegistro()
    End Sub

    Private Sub getRegistro()
        Dim strSql As String = "SELECT * FROM REGSTOCK"
        Dim adp As New OleDb.OleDbDataAdapter(strSql, conex)
        ds.Tables.Add("tabla")
        adp.Fill(ds.Tables("tabla"))
        Me.DataGridView1.DataSource = ds.Tables("tabla")
    End Sub

    Private Sub setRegistro()
        'Dim sqlInsert As String = "INSERT INTO regVentas (referencia,precio,cantidad) VALUES ('" & tbReferencia.Text & "'," & tbPreciou.Text & "," & tbCantidad.Text & ")"
        'comm.CommandText = sqlInsert
        Try
            comm.ExecuteNonQuery()
            MessageBox.Show("Registro ingresado")
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Biblioteca")
        End Try
    End Sub

    Private Function Coneccion()
        Try
            conex.Open()
            comm.Connection = conex
            comm.CommandType = CommandType.Text
            Return True
        Catch ex As Exception
            If Err.Number = 5 Then
                MessageBox.Show("No se encontro la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
            Return False
        End Try

    End Function

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Button1.Click
    	Me.Close()
    	ds.Tables.Clear
        conex.Close()
        'Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                Dim Sqlguardar As String
                Sqlguardar = "insert into regstock (id,referencia,marca,precio,stock) VALUES (" & DataGridView1.Rows(i).Cells(0).Value() & ",'" & DataGridView1.Rows(i).Cells(1).Value() & "','" & DataGridView1.Rows(i).Cells(2).Value() & "'," & DataGridView1.Rows(i).Cells(3).Value() & "," & DataGridView1.Rows(i).Cells(4).Value() & ")"
                Dim cmd As New OleDb.OleDbCommand(Sqlguardar, conex)
                cmd.CommandType = CommandType.Text
                'cmd.Parameters.AddWithValue("id", DataGridView1.Rows(i).Cells(0).Value())
                'cmd.Parameters.AddWithValue("referencia", DataGridView1.Rows(i).Cells(1).Value())
                'cmd.Parameters.AddWithValue("marca", DataGridView1.Rows(i).Cells(2).Value())
                'cmd.Parameters.AddWithValue("precio", DataGridView1.Rows(i).Cells(3).Value())
                'cmd.Parameters.AddWithValue("stock", DataGridView1.Rows(i).Cells(4).Value())
                cmd.ExecuteNonQuery()
            Next
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Biblioteca")
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("Delete * from regstock", conex)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        getRegistro()
    End Sub
    
End Class
