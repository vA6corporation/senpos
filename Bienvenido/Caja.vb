Public Class Caja
	
    Private conex As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=senposDB.accdb")
    Private comm As New OleDb.OleDbCommand
    Private dr As OleDb.OleDbDataReader
    Private matris(,)
    Private row = 0
    Private fecha = DateTime.Now.ToString("dd/MM/yyyy")
    Private ObtenerStatus As Boolean
    Private ingresoStatus As Boolean
    
    Private Sub Caja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conex.Open()
            comm.Connection = conex
            comm.CommandType = CommandType.Text
            tbBuscar.Text = "Buscar"
        Catch ex As Exception
            If Err.Number = 5 Then
                MessageBox.Show("No se encontro la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
        End Try
        tbCodigo.Select()
        tbFecha.Text = fecha
        tbUsuario.Text = Bienvenido.usuarioLogin
        getLista()
        btCobrar.Enabled = False
    End Sub

    Private Sub ObtenerProducto()
        If tbCodigo.Text() <> "" Then
            ObtenerStatus = getRegistro(tbCodigo.Text)
            If ObtenerStatus = True Then
                setVenta()
                tbCodigo.Select()
                tbCodigo.SelectAll()
                'Else
                'MessageBox.Show("Registro no encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            tbCodigo.Select()
        End If
    End Sub

    Private Sub getLista()
        dgvLista.Rows.Clear()
        Dim sqlSelect As String = "SELECT * FROM REGSTOCK"
        comm.CommandText = sqlSelect
        Try
            dr = comm.ExecuteReader()
            If dr.HasRows Then
                While dr.Read()
                    dgvLista.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(5))
                End While
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub clearVenta()
        tbCodigo.Clear()
        tbNombre.Clear()
        tbReferencia.Clear()
        tbLaboratorio.Clear()
        tbPrecio.Clear()
        tbCantidad.Text() = 1
    End Sub

    Private Sub setVenta()
        tbNombre.Text = matris(1, row)
        tbReferencia.Text = matris(2, row)
        tbLaboratorio.Text = matris(3, row)
        tbPrecio.Text = matris(4, row)
    End Sub

    Private Sub setGrid()
        Try
            MsgBox("ingresamos al grid")
            matris(6, row) = matris(4, row) * tbCantidad.Text 'sub total
            DataGridView.Rows.Add(matris(1, row), matris(2, row), matris(3, row), tbCantidad.Text, matris(4, row), matris(6, row))
            tbCodigo.Select()
            matris(7, row) = tbCantidad.Text 'la cantidad
            matris(8, row) = matris(5, row) - tbCantidad.Text 'nuevo stock
            tbTotal.Text = Val(tbTotal.Text) + (matris(4, row) * Val(tbCantidad.Text))
        Catch ex As Exception
            MessageBox.Show("Procedimiento inadecuado, revise campos vacios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub setRegistro()
        row -= 1
        For z = 0 To row
            Try
                MsgBox("ingresamos una venta")
                comm.CommandText = "INSERT INTO regVenta (id,nombre,referencia,laboratorio,precio,cantidad,montocobrado,fecha,usuario) VALUES (" & matris(0, z) &
                    ",'" & matris(1, z) & "','" & matris(2, z) & "','" & matris(3, z) & "'," & matris(4, z) & "," & matris(7, z) & "," & matris(6, z) & ",'" & fecha & "','" & Bienvenido.usuarioLogin & "')"
                comm.ExecuteNonQuery()
                comm.CommandText = "UPDATE regStock SET stock=" & matris(8, z) & " WHERE id =" & matris(0, z)
                comm.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Biblioteca")
            End Try
        Next
    End Sub

    Private Function getRegistro(codigo As Integer)
        Dim sqlSelect As String = "SELECT * FROM REGSTOCK WHERE ID=" & codigo
        Dim b As Boolean
        comm.CommandText = sqlSelect
        Try
            dr = comm.ExecuteReader()
            If dr.HasRows Then
                ReDim Preserve matris(8, row)
                While dr.Read()
                    matris(0, row) = dr(0) 'id
                    matris(1, row) = dr(1) 'nombre
                    matris(2, row) = dr(2) 'referencia
                    matris(3, row) = dr(3) 'laboratorio
                    matris(4, row) = dr(4) 'precio
                    matris(5, row) = dr(5) 'stock
                End While
                b = True
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return b
    End Function

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub

    Private Sub btMas_Click(sender As Object, e As EventArgs) Handles btMas.Click
        tbCantidad.Text += 1
    End Sub

    Private Sub btVender_Click(sender As Object, e As EventArgs) Handles btCobrar.Click
        Try
            If ingresoStatus = True Then
                setRegistro()
                getLista()
                DataGridView.Rows.Clear()
                ObtenerStatus = False
                ingresoStatus = False
                btCobrar.Enabled = False
                row = 0
                tbTotal.Clear()
                ReDim matris(8, 0)
            Else
                MessageBox.Show("Ingrese un Producto ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Procedimiento inadecuado, revise campos vacios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub dgvLista_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLista.CellContentClick
        Dim codigo As Integer
        If e.ColumnIndex = 0 Then
            codigo = dgvLista.CurrentRow.Cells(0).Value
            getRegistro(codigo)
            tbCodigo.Text = codigo
            setVenta()
            tbCodigo.Select()
            tbCodigo.SelectAll()
        End If
    End Sub

    Private Sub tbCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbCodigo.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 13 Then
            Try
                If ObtenerStatus = True Then
                    matris(8, row) = matris(5, row) - tbCantidad.Text
                    If matris(8, row) <= (-1) Then
                        MessageBox.Show("Este producto se a agotado o exede la cantidad de stock", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'ObtenerStatus = False
                    Else
                        setGrid()
                        tbCantidad.Text = 1
                        ingresoStatus = True
                        clearVenta()
                        row += 1
                        btCobrar.Enabled = True
                    End If
                    'MessageBox.Show("Seleccione un producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'tbCodigo.Select()
                End If

            Catch ex As Exception
                MessageBox.Show("Seleccione un producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
        If Asc(e.KeyChar) = 43 Then
            tbCantidad.Text += 1
        End If
        If Asc(e.KeyChar) = 45 Then
            tbCantidad.Text -= 1
            If tbCantidad.Text = 0 Then
                tbCantidad.Text = 1
            End If
        End If
    End Sub

    Private Sub tbCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles tbCodigo.KeyDown
        If e.Control And e.KeyCode = Keys.Enter Then
            Try
                If ingresoStatus = True Then
                    setRegistro()
                    getLista()
                    DataGridView.Rows.Clear()
                    ObtenerStatus = False
                    ingresoStatus = False
                    btCobrar.Enabled = False
                    row = 0
                    tbTotal.Clear()
                    ReDim matris(8, 0)
                Else
                    MessageBox.Show("Ingrese un Producto ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("Procedimiento inadecuado, revise campos vacios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
        If e.KeyCode = Keys.Delete Then
            If DataGridView.Rows.Count.ToString >= 1 Then
                row -= 1
                DataGridView.Rows.RemoveAt(row)
                ObtenerStatus = False
            End If
        End If
    End Sub

    Private Sub btIngresar_Click(sender As Object, e As EventArgs) Handles btIngresar.Click
        Try
            If ObtenerStatus = True Then
                matris(7, row) = matris(5, row) - tbCantidad.Text
                If matris(7, row) <= (-1) Then
                    MessageBox.Show("Este producto se a agotado o exede la cantidad de stock", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'ObtenerStatus = False
                Else
                    setGrid()
                    tbCantidad.Text = 1
                    ingresoStatus = True
                    clearVenta()
                    row += 1
                    btCobrar.Enabled = True
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Seleccione un producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tbHora.Text = Date.Now.ToLongTimeString
    End Sub

    Private Sub btMenos_Click_1(sender As Object, e As EventArgs) Handles btMenos.Click
        tbCantidad.Text -= 1
        If tbCantidad.Text = 0 Then
            tbCantidad.Text = 1
        End If
    End Sub

    Private Sub tbCodigo_TextChanged(sender As Object, e As EventArgs) Handles tbCodigo.TextChanged
        If tbCodigo.Text = "" Then
            clearVenta()
        Else
            ObtenerProducto()
        End If
    End Sub

    Private Sub tbBuscar_TextChanged(sender As Object, e As EventArgs) Handles tbBuscar.TextChanged

    End Sub

    Private Sub Caja_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'MessageBox.Show("nos bemos")
        Me.Hide()
        conex.Close()
        e.Cancel = True
    End Sub
End Class