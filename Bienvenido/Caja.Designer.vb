<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Caja
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Caja))
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbCodigo = New System.Windows.Forms.TextBox()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.tbPrecio = New System.Windows.Forms.TextBox()
        Me.tbCantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btIngresar = New System.Windows.Forms.Button()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.tbReferencia = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btCobrar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.clmCodigo = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.clmReferencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmMarca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbFecha = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbHora = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbUsuario = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.label = New System.Windows.Forms.Label()
        Me.tbLaboratorio = New System.Windows.Forms.TextBox()
        Me.btMenos = New System.Windows.Forms.Button()
        Me.btMas = New System.Windows.Forms.Button()
        Me.tbBuscar = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.AllowUserToResizeColumns = False
        Me.DataGridView.AllowUserToResizeRows = False
        Me.DataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column3, Me.Column7, Me.Column1, Me.Column4, Me.Column5})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView.EnableHeadersVisualStyles = False
        Me.DataGridView.Location = New System.Drawing.Point(536, 64)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView.RowHeadersVisible = False
        Me.DataGridView.RowTemplate.Height = 25
        Me.DataGridView.Size = New System.Drawing.Size(757, 461)
        Me.DataGridView.TabIndex = 31
        '
        'Column2
        '
        Me.Column2.HeaderText = "NOMBRE"
        Me.Column2.MaxInputLength = 20
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 170
        '
        'Column3
        '
        Me.Column3.HeaderText = "REFERENCIA"
        Me.Column3.MaxInputLength = 20
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 160
        '
        'Column7
        '
        Me.Column7.HeaderText = "LABORATORIO"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 160
        '
        'Column1
        '
        Me.Column1.HeaderText = "CANTIDAD"
        Me.Column1.MaxInputLength = 4
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 75
        '
        'Column4
        '
        Me.Column4.HeaderText = "PRECIO U."
        Me.Column4.MaxInputLength = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 75
        '
        'Column5
        '
        Me.Column5.HeaderText = "SUB TOTAL"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'tbCodigo
        '
        Me.tbCodigo.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCodigo.Location = New System.Drawing.Point(148, 64)
        Me.tbCodigo.MaxLength = 5
        Me.tbCodigo.Name = "tbCodigo"
        Me.tbCodigo.Size = New System.Drawing.Size(236, 33)
        Me.tbCodigo.TabIndex = 1
        '
        'tbNombre
        '
        Me.tbNombre.BackColor = System.Drawing.Color.White
        Me.tbNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbNombre.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombre.ForeColor = System.Drawing.Color.Black
        Me.tbNombre.Location = New System.Drawing.Point(148, 103)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.ReadOnly = True
        Me.tbNombre.Size = New System.Drawing.Size(237, 33)
        Me.tbNombre.TabIndex = 20
        '
        'tbPrecio
        '
        Me.tbPrecio.BackColor = System.Drawing.Color.White
        Me.tbPrecio.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPrecio.ForeColor = System.Drawing.Color.Black
        Me.tbPrecio.Location = New System.Drawing.Point(148, 220)
        Me.tbPrecio.Name = "tbPrecio"
        Me.tbPrecio.ReadOnly = True
        Me.tbPrecio.Size = New System.Drawing.Size(237, 33)
        Me.tbPrecio.TabIndex = 23
        '
        'tbCantidad
        '
        Me.tbCantidad.BackColor = System.Drawing.Color.White
        Me.tbCantidad.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCantidad.Location = New System.Drawing.Point(148, 259)
        Me.tbCantidad.Name = "tbCantidad"
        Me.tbCantidad.ReadOnly = True
        Me.tbCantidad.Size = New System.Drawing.Size(156, 33)
        Me.tbCantidad.TabIndex = 26
        Me.tbCantidad.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "NOMBRE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "CANTIDAD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(344, 45)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "CONTROL DE VENTAS"
        '
        'btIngresar
        '
        Me.btIngresar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btIngresar.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btIngresar.Location = New System.Drawing.Point(152, 540)
        Me.btIngresar.Name = "btIngresar"
        Me.btIngresar.Size = New System.Drawing.Size(133, 41)
        Me.btIngresar.TabIndex = 3
        Me.btIngresar.Text = "INGRESAR"
        Me.btIngresar.UseVisualStyleBackColor = True
        '
        'btSalir
        '
        Me.btSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btSalir.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalir.Location = New System.Drawing.Point(11, 541)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(135, 41)
        Me.btSalir.TabIndex = 28
        Me.btSalir.Text = "SALIR"
        Me.btSalir.UseVisualStyleBackColor = True
        '
        'tbReferencia
        '
        Me.tbReferencia.BackColor = System.Drawing.Color.White
        Me.tbReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbReferencia.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbReferencia.ForeColor = System.Drawing.Color.Black
        Me.tbReferencia.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tbReferencia.Location = New System.Drawing.Point(148, 142)
        Me.tbReferencia.Name = "tbReferencia"
        Me.tbReferencia.ReadOnly = True
        Me.tbReferencia.Size = New System.Drawing.Size(237, 33)
        Me.tbReferencia.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 25)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "REFERENCIA"
        '
        'btCobrar
        '
        Me.btCobrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btCobrar.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCobrar.Location = New System.Drawing.Point(291, 540)
        Me.btCobrar.Name = "btCobrar"
        Me.btCobrar.Size = New System.Drawing.Size(135, 41)
        Me.btCobrar.TabIndex = 4
        Me.btCobrar.Text = "VENDER"
        Me.btCobrar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 223)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 25)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "PRECIO"
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.AllowUserToDeleteRows = False
        Me.dgvLista.AllowUserToResizeRows = False
        Me.dgvLista.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvLista.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvLista.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLista.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmCodigo, Me.clmReferencia, Me.Column6, Me.clmMarca, Me.clmStock})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLista.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvLista.EnableHeadersVisualStyles = False
        Me.dgvLista.Location = New System.Drawing.Point(11, 345)
        Me.dgvLista.MultiSelect = False
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.ReadOnly = True
        Me.dgvLista.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvLista.RowHeadersVisible = False
        Me.dgvLista.RowTemplate.Height = 25
        Me.dgvLista.Size = New System.Drawing.Size(519, 180)
        Me.dgvLista.StandardTab = True
        Me.dgvLista.TabIndex = 32
        '
        'clmCodigo
        '
        Me.clmCodigo.HeaderText = "ID"
        Me.clmCodigo.Name = "clmCodigo"
        Me.clmCodigo.ReadOnly = True
        Me.clmCodigo.Width = 50
        '
        'clmReferencia
        '
        Me.clmReferencia.HeaderText = "NOMBRE"
        Me.clmReferencia.Name = "clmReferencia"
        Me.clmReferencia.ReadOnly = True
        Me.clmReferencia.Width = 170
        '
        'Column6
        '
        Me.Column6.HeaderText = "REFERENCIA"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 130
        '
        'clmMarca
        '
        Me.clmMarca.HeaderText = "LABORATORIO"
        Me.clmMarca.Name = "clmMarca"
        Me.clmMarca.ReadOnly = True
        '
        'clmStock
        '
        Me.clmStock.HeaderText = "STOCK"
        Me.clmStock.Name = "clmStock"
        Me.clmStock.ReadOnly = True
        Me.clmStock.Width = 50
        '
        'tbFecha
        '
        Me.tbFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbFecha.BackColor = System.Drawing.Color.White
        Me.tbFecha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbFecha.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFecha.Location = New System.Drawing.Point(635, 19)
        Me.tbFecha.Name = "tbFecha"
        Me.tbFecha.ReadOnly = True
        Me.tbFecha.Size = New System.Drawing.Size(150, 26)
        Me.tbFecha.TabIndex = 33
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(528, 537)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(362, 45)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "TOTAL A COBRAR :   S/."
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(552, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 30)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "FECHA"
        '
        'tbHora
        '
        Me.tbHora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbHora.BackColor = System.Drawing.Color.White
        Me.tbHora.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbHora.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHora.Location = New System.Drawing.Point(868, 20)
        Me.tbHora.Name = "tbHora"
        Me.tbHora.ReadOnly = True
        Me.tbHora.Size = New System.Drawing.Size(150, 26)
        Me.tbHora.TabIndex = 35
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(791, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 30)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "HORA"
        '
        'tbUsuario
        '
        Me.tbUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbUsuario.BackColor = System.Drawing.Color.White
        Me.tbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbUsuario.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUsuario.Location = New System.Drawing.Point(1133, 20)
        Me.tbUsuario.Name = "tbUsuario"
        Me.tbUsuario.ReadOnly = True
        Me.tbUsuario.Size = New System.Drawing.Size(150, 26)
        Me.tbUsuario.TabIndex = 37
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1024, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 30)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "USUARIO"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(15, 314)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(204, 25)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "LISTA DE PRODUCTOS"
        '
        'tbTotal
        '
        Me.tbTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTotal.BackColor = System.Drawing.Color.White
        Me.tbTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotal.Location = New System.Drawing.Point(960, 537)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.ReadOnly = True
        Me.tbTotal.Size = New System.Drawing.Size(333, 50)
        Me.tbTotal.TabIndex = 41
        Me.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Turquoise
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.tbFecha)
        Me.GroupBox1.Controls.Add(Me.tbHora)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.tbUsuario)
        Me.GroupBox1.Location = New System.Drawing.Point(-3, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1308, 58)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(5, 184)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(140, 25)
        Me.label.TabIndex = 44
        Me.label.Text = "LABORATORIO"
        '
        'tbLaboratorio
        '
        Me.tbLaboratorio.BackColor = System.Drawing.Color.White
        Me.tbLaboratorio.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLaboratorio.ForeColor = System.Drawing.Color.Black
        Me.tbLaboratorio.Location = New System.Drawing.Point(148, 181)
        Me.tbLaboratorio.Name = "tbLaboratorio"
        Me.tbLaboratorio.ReadOnly = True
        Me.tbLaboratorio.Size = New System.Drawing.Size(237, 33)
        Me.tbLaboratorio.TabIndex = 45
        '
        'btMenos
        '
        Me.btMenos.BackgroundImage = Global.Bienvenido.My.Resources.Resources.menos
        Me.btMenos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btMenos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btMenos.Location = New System.Drawing.Point(311, 259)
        Me.btMenos.Name = "btMenos"
        Me.btMenos.Size = New System.Drawing.Size(34, 34)
        Me.btMenos.TabIndex = 29
        Me.btMenos.Text = "-"
        Me.btMenos.UseVisualStyleBackColor = True
        '
        'btMas
        '
        Me.btMas.BackgroundImage = Global.Bienvenido.My.Resources.Resources.mas
        Me.btMas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btMas.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btMas.Location = New System.Drawing.Point(351, 259)
        Me.btMas.Margin = New System.Windows.Forms.Padding(0)
        Me.btMas.Name = "btMas"
        Me.btMas.Size = New System.Drawing.Size(34, 34)
        Me.btMas.TabIndex = 30
        Me.btMas.UseVisualStyleBackColor = True
        '
        'tbBuscar
        '
        Me.tbBuscar.BackColor = System.Drawing.Color.White
        Me.tbBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbBuscar.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBuscar.ForeColor = System.Drawing.Color.Black
        Me.tbBuscar.Location = New System.Drawing.Point(250, 314)
        Me.tbBuscar.Name = "tbBuscar"
        Me.tbBuscar.Size = New System.Drawing.Size(280, 26)
        Me.tbBuscar.TabIndex = 46
        '
        'Caja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1302, 598)
        Me.ControlBox = False
        Me.Controls.Add(Me.tbBuscar)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.tbLaboratorio)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tbTotal)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.dgvLista)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btMenos)
        Me.Controls.Add(Me.btCobrar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbReferencia)
        Me.Controls.Add(Me.btMas)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Me.btIngresar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbCantidad)
        Me.Controls.Add(Me.tbPrecio)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.tbCodigo)
        Me.Controls.Add(Me.DataGridView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Caja"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbCodigo As TextBox
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents tbPrecio As TextBox
    Friend WithEvents tbCantidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btIngresar As Button
    Friend WithEvents btSalir As Button
    Friend WithEvents btMas As Button
    Friend WithEvents tbReferencia As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btCobrar As Button
    Friend WithEvents btMenos As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents dgvLista As DataGridView
    Friend WithEvents tbFecha As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tbHora As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbUsuario As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents clmCodigo As DataGridViewButtonColumn
    Friend WithEvents clmReferencia As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents clmMarca As DataGridViewTextBoxColumn
    Friend WithEvents clmStock As DataGridViewTextBoxColumn
    Friend WithEvents label As Label
    Friend WithEvents tbLaboratorio As TextBox
    Friend WithEvents tbBuscar As TextBox
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
