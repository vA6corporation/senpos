<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bienvenido
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
    	Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bienvenido))
    	Me.btLogin = New System.Windows.Forms.Button()
    	Me.Label1 = New System.Windows.Forms.Label()
    	Me.btCaja = New System.Windows.Forms.Button()
    	Me.btStock = New System.Windows.Forms.Button()
    	Me.btUsuarios = New System.Windows.Forms.Button()
    	Me.btInformes = New System.Windows.Forms.Button()
    	Me.lMain = New System.Windows.Forms.Label()
    	Me.PictureBox1 = New System.Windows.Forms.PictureBox()
    	Me.status = New System.Windows.Forms.Label()
    	Me.btSalir = New System.Windows.Forms.Button()
    	Me.lUser = New System.Windows.Forms.Label()
    	Me.btLogout = New System.Windows.Forms.Button()
    	CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
    	Me.SuspendLayout
    	'
    	'btLogin
    	'
    	Me.btLogin.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.btLogin.Location = New System.Drawing.Point(17, 69)
    	Me.btLogin.Name = "btLogin"
    	Me.btLogin.Size = New System.Drawing.Size(90, 40)
    	Me.btLogin.TabIndex = 0
    	Me.btLogin.Text = "LOGIN"
    	Me.btLogin.UseVisualStyleBackColor = true
    	'
    	'Label1
    	'
    	Me.Label1.AutoSize = true
    	Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.Label1.Location = New System.Drawing.Point(12, 16)
    	Me.Label1.Name = "Label1"
    	Me.Label1.Size = New System.Drawing.Size(119, 30)
    	Me.Label1.TabIndex = 1
    	Me.Label1.Text = "Bienvenido"
    	'
    	'btCaja
    	'
    	Me.btCaja.Enabled = false
    	Me.btCaja.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.btCaja.Location = New System.Drawing.Point(17, 115)
    	Me.btCaja.Name = "btCaja"
    	Me.btCaja.Size = New System.Drawing.Size(90, 40)
    	Me.btCaja.TabIndex = 5
    	Me.btCaja.Text = "CAJA"
    	Me.btCaja.UseVisualStyleBackColor = true
    	'
    	'btStock
    	'
    	Me.btStock.Enabled = false
    	Me.btStock.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.btStock.Location = New System.Drawing.Point(17, 161)
    	Me.btStock.Name = "btStock"
    	Me.btStock.Size = New System.Drawing.Size(90, 40)
    	Me.btStock.TabIndex = 6
    	Me.btStock.Text = "STOCK"
    	Me.btStock.UseVisualStyleBackColor = true
    	'
    	'btUsuarios
    	'
    	Me.btUsuarios.Enabled = false
    	Me.btUsuarios.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.btUsuarios.Location = New System.Drawing.Point(17, 207)
    	Me.btUsuarios.Name = "btUsuarios"
    	Me.btUsuarios.Size = New System.Drawing.Size(90, 40)
    	Me.btUsuarios.TabIndex = 7
    	Me.btUsuarios.Text = "USUARIOS"
    	Me.btUsuarios.UseVisualStyleBackColor = true
    	'
    	'btInformes
    	'
    	Me.btInformes.Enabled = false
    	Me.btInformes.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.btInformes.Location = New System.Drawing.Point(17, 253)
    	Me.btInformes.Name = "btInformes"
    	Me.btInformes.Size = New System.Drawing.Size(90, 40)
    	Me.btInformes.TabIndex = 8
    	Me.btInformes.Text = "INFORMES"
    	Me.btInformes.UseVisualStyleBackColor = true
    	'
    	'lMain
    	'
    	Me.lMain.AutoSize = true
    	Me.lMain.Font = New System.Drawing.Font("Segoe UI Semibold", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.lMain.Location = New System.Drawing.Point(133, 67)
    	Me.lMain.Name = "lMain"
    	Me.lMain.Size = New System.Drawing.Size(276, 42)
    	Me.lMain.TabIndex = 9
    	Me.lMain.Text = "Sistema de control de ventas y stock"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"             Por favor inicie sesion"
    	'
    	'PictureBox1
    	'
    	Me.PictureBox1.Image = Global.Bienvenido.My.Resources.Resources.logoSenPos
    	Me.PictureBox1.Location = New System.Drawing.Point(153, 115)
    	Me.PictureBox1.Name = "PictureBox1"
    	Me.PictureBox1.Size = New System.Drawing.Size(235, 235)
    	Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    	Me.PictureBox1.TabIndex = 10
    	Me.PictureBox1.TabStop = false
    	'
    	'status
    	'
    	Me.status.AutoSize = true
    	Me.status.Font = New System.Drawing.Font("Segoe UI Semibold", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.status.Location = New System.Drawing.Point(164, 23)
    	Me.status.Name = "status"
    	Me.status.Size = New System.Drawing.Size(212, 21)
    	Me.status.TabIndex = 11
    	Me.status.Text = "SERVIDOR DESCONECTADO"
    	Me.status.Visible = false
    	'
    	'btSalir
    	'
    	Me.btSalir.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.btSalir.Location = New System.Drawing.Point(17, 324)
    	Me.btSalir.Name = "btSalir"
    	Me.btSalir.Size = New System.Drawing.Size(90, 40)
    	Me.btSalir.TabIndex = 12
    	Me.btSalir.Text = "SALIR"
    	Me.btSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
    	Me.btSalir.UseVisualStyleBackColor = true
    	'
    	'lUser
    	'
    	Me.lUser.AutoSize = true
    	Me.lUser.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.lUser.Location = New System.Drawing.Point(142, 16)
    	Me.lUser.Name = "lUser"
    	Me.lUser.Size = New System.Drawing.Size(137, 30)
    	Me.lUser.TabIndex = 13
    	Me.lUser.Text = "Desconocido"
    	Me.lUser.Visible = false
    	'
    	'btLogout
    	'
    	Me.btLogout.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.btLogout.Location = New System.Drawing.Point(17, 69)
    	Me.btLogout.Name = "btLogout"
    	Me.btLogout.Size = New System.Drawing.Size(90, 40)
    	Me.btLogout.TabIndex = 14
    	Me.btLogout.Text = "LOGOUT"
    	Me.btLogout.UseVisualStyleBackColor = true
    	Me.btLogout.Visible = false
    	'
    	'Bienvenido
    	'
    	Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    	Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    	Me.ClientSize = New System.Drawing.Size(434, 376)
    	Me.Controls.Add(Me.btLogout)
    	Me.Controls.Add(Me.lUser)
    	Me.Controls.Add(Me.btSalir)
    	Me.Controls.Add(Me.status)
    	Me.Controls.Add(Me.PictureBox1)
    	Me.Controls.Add(Me.lMain)
    	Me.Controls.Add(Me.btInformes)
    	Me.Controls.Add(Me.btUsuarios)
    	Me.Controls.Add(Me.btStock)
    	Me.Controls.Add(Me.btCaja)
    	Me.Controls.Add(Me.Label1)
    	Me.Controls.Add(Me.btLogin)
    	Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    	Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
    	Me.MaximizeBox = false
    	Me.Name = "Bienvenido"
    	Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    	Me.Text = "SenPos"
    	CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
    	Me.ResumeLayout(false)
    	Me.PerformLayout
    End Sub
    'Friend btSalir As System.Windows.Forms.Button
    Friend WithEvents btSalir As Button
    Friend WithEvents btLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btCaja As Button
    Friend WithEvents btStock As Button
    Friend WithEvents btUsuarios As Button
    Friend WithEvents btInformes As Button
    Friend WithEvents lMain As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents status As Label
    Friend WithEvents lUser As Label
    Friend WithEvents btLogout As Button
End Class
