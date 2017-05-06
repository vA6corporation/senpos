<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Detalles
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
    	Me.Label8 = New System.Windows.Forms.Label()
    	Me.cbStock = New System.Windows.Forms.CheckBox()
    	Me.cbInfo = New System.Windows.Forms.CheckBox()
    	Me.cbUser = New System.Windows.Forms.CheckBox()
    	Me.cbCaja = New System.Windows.Forms.CheckBox()
    	Me.Label1 = New System.Windows.Forms.Label()
    	Me.Label2 = New System.Windows.Forms.Label()
    	Me.tbPass = New System.Windows.Forms.TextBox()
    	Me.Label3 = New System.Windows.Forms.Label()
    	Me.tbId = New System.Windows.Forms.TextBox()
    	Me.Label4 = New System.Windows.Forms.Label()
    	Me.tbCeluar = New System.Windows.Forms.TextBox()
    	Me.Label6 = New System.Windows.Forms.Label()
    	Me.tbDni = New System.Windows.Forms.TextBox()
    	Me.Label7 = New System.Windows.Forms.Label()
    	Me.tbApellido = New System.Windows.Forms.TextBox()
    	Me.tbNombre = New System.Windows.Forms.TextBox()
    	Me.SuspendLayout
    	'
    	'Label8
    	'
    	Me.Label8.AutoSize = true
    	Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.Label8.Location = New System.Drawing.Point(12, 251)
    	Me.Label8.Name = "Label8"
    	Me.Label8.Size = New System.Drawing.Size(89, 25)
    	Me.Label8.TabIndex = 39
    	Me.Label8.Text = "Permisos"
    	'
    	'cbStock
    	'
    	Me.cbStock.AutoSize = true
    	Me.cbStock.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.cbStock.Location = New System.Drawing.Point(232, 292)
    	Me.cbStock.Name = "cbStock"
    	Me.cbStock.Size = New System.Drawing.Size(154, 29)
    	Me.cbStock.TabIndex = 38
    	Me.cbStock.Text = "Manejar Stock"
    	Me.cbStock.UseVisualStyleBackColor = true
    	'
    	'cbInfo
    	'
    	Me.cbInfo.AutoSize = true
    	Me.cbInfo.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.cbInfo.Location = New System.Drawing.Point(232, 337)
    	Me.cbInfo.Name = "cbInfo"
    	Me.cbInfo.Size = New System.Drawing.Size(142, 29)
    	Me.cbInfo.TabIndex = 37
    	Me.cbInfo.Text = "Ver Informes"
    	Me.cbInfo.UseVisualStyleBackColor = true
    	'
    	'cbUser
    	'
    	Me.cbUser.AutoSize = true
    	Me.cbUser.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.cbUser.Location = New System.Drawing.Point(15, 337)
    	Me.cbUser.Name = "cbUser"
    	Me.cbUser.Size = New System.Drawing.Size(179, 29)
    	Me.cbUser.TabIndex = 36
    	Me.cbUser.Text = "Registar Usuarios"
    	Me.cbUser.UseVisualStyleBackColor = true
    	'
    	'cbCaja
    	'
    	Me.cbCaja.AutoSize = true
    	Me.cbCaja.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.cbCaja.Location = New System.Drawing.Point(15, 292)
    	Me.cbCaja.Name = "cbCaja"
    	Me.cbCaja.Size = New System.Drawing.Size(144, 29)
    	Me.cbCaja.TabIndex = 35
    	Me.cbCaja.Text = "Manejar Caja"
    	Me.cbCaja.UseVisualStyleBackColor = true
    	'
    	'Label1
    	'
    	Me.Label1.AutoSize = true
    	Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.Label1.Location = New System.Drawing.Point(15, 9)
    	Me.Label1.Name = "Label1"
    	Me.Label1.Size = New System.Drawing.Size(91, 25)
    	Me.Label1.TabIndex = 23
    	Me.Label1.Text = "Nombres"
    	'
    	'Label2
    	'
    	Me.Label2.AutoSize = true
    	Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.Label2.Location = New System.Drawing.Point(15, 49)
    	Me.Label2.Name = "Label2"
    	Me.Label2.Size = New System.Drawing.Size(91, 25)
    	Me.Label2.TabIndex = 24
    	Me.Label2.Text = "Apellidos"
    	'
    	'tbPass
    	'
    	Me.tbPass.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.tbPass.Location = New System.Drawing.Point(144, 209)
    	Me.tbPass.MaxLength = 20
    	Me.tbPass.Name = "tbPass"
    	Me.tbPass.Size = New System.Drawing.Size(253, 33)
    	Me.tbPass.TabIndex = 34
    	'
    	'Label3
    	'
    	Me.Label3.AutoSize = true
    	Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.Label3.Location = New System.Drawing.Point(15, 89)
    	Me.Label3.Name = "Label3"
    	Me.Label3.Size = New System.Drawing.Size(79, 25)
    	Me.Label3.TabIndex = 25
    	Me.Label3.Text = "DNI. N°"
    	'
    	'tbId
    	'
    	Me.tbId.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.tbId.Location = New System.Drawing.Point(144, 169)
    	Me.tbId.MaxLength = 4
    	Me.tbId.Name = "tbId"
    	Me.tbId.Size = New System.Drawing.Size(253, 33)
    	Me.tbId.TabIndex = 33
    	'
    	'Label4
    	'
    	Me.Label4.AutoSize = true
    	Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.Label4.Location = New System.Drawing.Point(15, 129)
    	Me.Label4.Name = "Label4"
    	Me.Label4.Size = New System.Drawing.Size(72, 25)
    	Me.Label4.TabIndex = 26
    	Me.Label4.Text = "Celular"
    	'
    	'tbCeluar
    	'
    	Me.tbCeluar.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.tbCeluar.Location = New System.Drawing.Point(144, 129)
    	Me.tbCeluar.MaxLength = 9
    	Me.tbCeluar.Name = "tbCeluar"
    	Me.tbCeluar.Size = New System.Drawing.Size(253, 33)
    	Me.tbCeluar.TabIndex = 32
    	'
    	'Label6
    	'
    	Me.Label6.AutoSize = true
    	Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.Label6.Location = New System.Drawing.Point(15, 169)
    	Me.Label6.Name = "Label6"
    	Me.Label6.Size = New System.Drawing.Size(64, 25)
    	Me.Label6.TabIndex = 27
    	Me.Label6.Text = "ID. N°"
    	'
    	'tbDni
    	'
    	Me.tbDni.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.tbDni.Location = New System.Drawing.Point(144, 89)
    	Me.tbDni.MaxLength = 8
    	Me.tbDni.Name = "tbDni"
    	Me.tbDni.Size = New System.Drawing.Size(253, 33)
    	Me.tbDni.TabIndex = 31
    	'
    	'Label7
    	'
    	Me.Label7.AutoSize = true
    	Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.Label7.Location = New System.Drawing.Point(12, 209)
    	Me.Label7.Name = "Label7"
    	Me.Label7.Size = New System.Drawing.Size(102, 25)
    	Me.Label7.TabIndex = 28
    	Me.Label7.Text = "Contaseña"
    	'
    	'tbApellido
    	'
    	Me.tbApellido.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.tbApellido.Location = New System.Drawing.Point(144, 49)
    	Me.tbApellido.MaxLength = 30
    	Me.tbApellido.Name = "tbApellido"
    	Me.tbApellido.Size = New System.Drawing.Size(253, 33)
    	Me.tbApellido.TabIndex = 30
    	'
    	'tbNombre
    	'
    	Me.tbNombre.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.tbNombre.Location = New System.Drawing.Point(144, 9)
    	Me.tbNombre.MaxLength = 30
    	Me.tbNombre.Name = "tbNombre"
    	Me.tbNombre.Size = New System.Drawing.Size(253, 33)
    	Me.tbNombre.TabIndex = 29
    	'
    	'Detalles
    	'
    	Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    	Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    	Me.ClientSize = New System.Drawing.Size(414, 412)
    	Me.Controls.Add(Me.Label8)
    	Me.Controls.Add(Me.cbStock)
    	Me.Controls.Add(Me.cbInfo)
    	Me.Controls.Add(Me.cbUser)
    	Me.Controls.Add(Me.cbCaja)
    	Me.Controls.Add(Me.Label1)
    	Me.Controls.Add(Me.Label2)
    	Me.Controls.Add(Me.tbPass)
    	Me.Controls.Add(Me.Label3)
    	Me.Controls.Add(Me.tbId)
    	Me.Controls.Add(Me.Label4)
    	Me.Controls.Add(Me.tbCeluar)
    	Me.Controls.Add(Me.Label6)
    	Me.Controls.Add(Me.tbDni)
    	Me.Controls.Add(Me.Label7)
    	Me.Controls.Add(Me.tbApellido)
    	Me.Controls.Add(Me.tbNombre)
    	Me.Name = "Detalles"
    	Me.Text = "Detalles"
    	Me.ResumeLayout(false)
    	Me.PerformLayout
    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents cbStock As CheckBox
    Friend WithEvents cbInfo As CheckBox
    Friend WithEvents cbUser As CheckBox
    Friend WithEvents cbCaja As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbPass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbId As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbCeluar As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbDni As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbApellido As TextBox
    Friend WithEvents tbNombre As TextBox
End Class
