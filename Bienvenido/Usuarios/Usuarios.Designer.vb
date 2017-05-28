<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuarios))
        Me.buttonRegistro = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.tbApellido = New System.Windows.Forms.TextBox()
        Me.tbDni = New System.Windows.Forms.TextBox()
        Me.tbCeluar = New System.Windows.Forms.TextBox()
        Me.tbId = New System.Windows.Forms.TextBox()
        Me.tbPass = New System.Windows.Forms.TextBox()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.panelPermisos = New System.Windows.Forms.Panel()
        Me.cbStock = New System.Windows.Forms.CheckBox()
        Me.cbInfo = New System.Windows.Forms.CheckBox()
        Me.cbCaja = New System.Windows.Forms.CheckBox()
        Me.cbUser = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelRegistro = New System.Windows.Forms.Panel()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.buttonNewUser = New System.Windows.Forms.Button()
        Me.panelPermisos.SuspendLayout()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelRegistro.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'buttonRegistro
        '
        Me.buttonRegistro.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonRegistro.Location = New System.Drawing.Point(270, 386)
        Me.buttonRegistro.Name = "buttonRegistro"
        Me.buttonRegistro.Size = New System.Drawing.Size(118, 40)
        Me.buttonRegistro.TabIndex = 0
        Me.buttonRegistro.Text = "REGISTRAR"
        Me.buttonRegistro.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombres"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Apellidos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "DNI. N°"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Celular"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 25)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "ID. N°"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 25)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Contaseña"
        '
        'tbNombre
        '
        Me.tbNombre.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombre.Location = New System.Drawing.Point(135, 3)
        Me.tbNombre.MaxLength = 30
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(253, 33)
        Me.tbNombre.TabIndex = 8
        '
        'tbApellido
        '
        Me.tbApellido.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbApellido.Location = New System.Drawing.Point(135, 43)
        Me.tbApellido.MaxLength = 30
        Me.tbApellido.Name = "tbApellido"
        Me.tbApellido.Size = New System.Drawing.Size(253, 33)
        Me.tbApellido.TabIndex = 9
        '
        'tbDni
        '
        Me.tbDni.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDni.Location = New System.Drawing.Point(135, 83)
        Me.tbDni.MaxLength = 8
        Me.tbDni.Name = "tbDni"
        Me.tbDni.Size = New System.Drawing.Size(253, 33)
        Me.tbDni.TabIndex = 10
        '
        'tbCeluar
        '
        Me.tbCeluar.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCeluar.Location = New System.Drawing.Point(135, 123)
        Me.tbCeluar.MaxLength = 9
        Me.tbCeluar.Name = "tbCeluar"
        Me.tbCeluar.Size = New System.Drawing.Size(253, 33)
        Me.tbCeluar.TabIndex = 11
        '
        'tbId
        '
        Me.tbId.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbId.Location = New System.Drawing.Point(135, 163)
        Me.tbId.MaxLength = 4
        Me.tbId.Name = "tbId"
        Me.tbId.Size = New System.Drawing.Size(253, 33)
        Me.tbId.TabIndex = 15
        '
        'tbPass
        '
        Me.tbPass.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPass.Location = New System.Drawing.Point(135, 203)
        Me.tbPass.MaxLength = 20
        Me.tbPass.Name = "tbPass"
        Me.tbPass.Size = New System.Drawing.Size(253, 33)
        Me.tbPass.TabIndex = 16
        '
        'btCancelar
        '
        Me.btCancelar.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancelar.Location = New System.Drawing.Point(6, 386)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(124, 40)
        Me.btCancelar.TabIndex = 17
        Me.btCancelar.Text = "CANCELAR"
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(248, 30)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "CONTROL DE USUARIOS"
        '
        'panelPermisos
        '
        Me.panelPermisos.BackColor = System.Drawing.Color.Transparent
        Me.panelPermisos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelPermisos.Controls.Add(Me.cbStock)
        Me.panelPermisos.Controls.Add(Me.cbInfo)
        Me.panelPermisos.Controls.Add(Me.cbCaja)
        Me.panelPermisos.Controls.Add(Me.cbUser)
        Me.panelPermisos.Location = New System.Drawing.Point(6, 273)
        Me.panelPermisos.Name = "panelPermisos"
        Me.panelPermisos.Size = New System.Drawing.Size(382, 96)
        Me.panelPermisos.TabIndex = 23
        '
        'cbStock
        '
        Me.cbStock.AutoSize = True
        Me.cbStock.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStock.Location = New System.Drawing.Point(213, 10)
        Me.cbStock.Name = "cbStock"
        Me.cbStock.Size = New System.Drawing.Size(154, 29)
        Me.cbStock.TabIndex = 21
        Me.cbStock.Text = "Manejar Stock"
        Me.cbStock.UseVisualStyleBackColor = True
        '
        'cbInfo
        '
        Me.cbInfo.AutoSize = True
        Me.cbInfo.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbInfo.Location = New System.Drawing.Point(213, 57)
        Me.cbInfo.Name = "cbInfo"
        Me.cbInfo.Size = New System.Drawing.Size(142, 29)
        Me.cbInfo.TabIndex = 20
        Me.cbInfo.Text = "Ver Informes"
        Me.cbInfo.UseVisualStyleBackColor = True
        '
        'cbCaja
        '
        Me.cbCaja.AutoSize = True
        Me.cbCaja.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCaja.Location = New System.Drawing.Point(3, 10)
        Me.cbCaja.Name = "cbCaja"
        Me.cbCaja.Size = New System.Drawing.Size(144, 29)
        Me.cbCaja.TabIndex = 18
        Me.cbCaja.Text = "Manejar Caja"
        Me.cbCaja.UseVisualStyleBackColor = True
        '
        'cbUser
        '
        Me.cbUser.AutoSize = True
        Me.cbUser.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbUser.Location = New System.Drawing.Point(3, 57)
        Me.cbUser.Name = "cbUser"
        Me.cbUser.Size = New System.Drawing.Size(179, 29)
        Me.cbUser.TabIndex = 19
        Me.cbUser.Text = "Registar Usuarios"
        Me.cbUser.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 25)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Permisos"
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.AllowUserToDeleteRows = False
        Me.dgvLista.AllowUserToResizeColumns = False
        Me.dgvLista.AllowUserToResizeRows = False
        Me.dgvLista.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLista.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLista.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLista.EnableHeadersVisualStyles = False
        Me.dgvLista.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgvLista.Location = New System.Drawing.Point(12, 49)
        Me.dgvLista.MultiSelect = False
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.ReadOnly = True
        Me.dgvLista.RightToLeft = System.Windows.Forms.RightToLeft.No
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLista.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvLista.RowHeadersVisible = False
        Me.dgvLista.RowTemplate.Height = 25
        Me.dgvLista.RowTemplate.ReadOnly = True
        Me.dgvLista.Size = New System.Drawing.Size(413, 472)
        Me.dgvLista.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Detalles"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column1.Width = 68
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column2.Width = 90
        '
        'Column3
        '
        Me.Column3.HeaderText = "Apellido"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column3.Width = 160
        '
        'Column4
        '
        Me.Column4.HeaderText = "Id"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column4.Width = 63
        '
        'panelRegistro
        '
        Me.panelRegistro.Controls.Add(Me.panelPermisos)
        Me.panelRegistro.Controls.Add(Me.Label1)
        Me.panelRegistro.Controls.Add(Me.Label8)
        Me.panelRegistro.Controls.Add(Me.tbNombre)
        Me.panelRegistro.Controls.Add(Me.buttonRegistro)
        Me.panelRegistro.Controls.Add(Me.tbApellido)
        Me.panelRegistro.Controls.Add(Me.btCancelar)
        Me.panelRegistro.Controls.Add(Me.Label7)
        Me.panelRegistro.Controls.Add(Me.tbDni)
        Me.panelRegistro.Controls.Add(Me.Label2)
        Me.panelRegistro.Controls.Add(Me.Label6)
        Me.panelRegistro.Controls.Add(Me.tbPass)
        Me.panelRegistro.Controls.Add(Me.tbCeluar)
        Me.panelRegistro.Controls.Add(Me.Label3)
        Me.panelRegistro.Controls.Add(Me.Label4)
        Me.panelRegistro.Controls.Add(Me.tbId)
        Me.panelRegistro.Location = New System.Drawing.Point(12, 49)
        Me.panelRegistro.Name = "panelRegistro"
        Me.panelRegistro.Size = New System.Drawing.Size(392, 479)
        Me.panelRegistro.TabIndex = 20
        Me.panelRegistro.Visible = False
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.Button1)
        Me.panel1.Controls.Add(Me.buttonNewUser)
        Me.panel1.Location = New System.Drawing.Point(12, 72)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(413, 525)
        Me.panel1.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 469)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 41)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'buttonNewUser
        '
        Me.buttonNewUser.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonNewUser.Location = New System.Drawing.Point(286, 455)
        Me.buttonNewUser.Name = "buttonNewUser"
        Me.buttonNewUser.Size = New System.Drawing.Size(124, 63)
        Me.buttonNewUser.TabIndex = 17
        Me.buttonNewUser.Text = "NUEVO USUARIO"
        Me.buttonNewUser.UseVisualStyleBackColor = True
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(435, 597)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelRegistro)
        Me.Controls.Add(Me.dgvLista)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.Label5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        Me.panelPermisos.ResumeLayout(False)
        Me.panelPermisos.PerformLayout()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelRegistro.ResumeLayout(False)
        Me.panelRegistro.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend buttonNewUser As System.Windows.Forms.Button
    Private panel1 As System.Windows.Forms.Panel
    Private panelRegistro As System.Windows.Forms.Panel
    Private panelPermisos As System.Windows.Forms.Panel

    Friend WithEvents buttonRegistro As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents tbApellido As TextBox
    Friend WithEvents tbDni As TextBox
    Friend WithEvents tbCeluar As TextBox
    Friend WithEvents tbId As TextBox
    Friend WithEvents tbPass As TextBox
    Friend WithEvents btCancelar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbStock As CheckBox
    Friend WithEvents cbInfo As CheckBox
    Friend WithEvents cbUser As CheckBox
    Friend WithEvents cbCaja As CheckBox
    Friend WithEvents dgvLista As DataGridView
    Friend WithEvents Column1 As DataGridViewButtonColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
