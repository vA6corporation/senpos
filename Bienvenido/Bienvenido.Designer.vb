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
        Me.btProductos = New System.Windows.Forms.Button()
        Me.btUsuarios = New System.Windows.Forms.Button()
        Me.btInformes = New System.Windows.Forms.Button()
        Me.lMain = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.status = New System.Windows.Forms.Label()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.lUser = New System.Windows.Forms.Label()
        Me.btLogout = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btLogin
        '
        Me.btLogin.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLogin.Location = New System.Drawing.Point(17, 69)
        Me.btLogin.Name = "btLogin"
        Me.btLogin.Size = New System.Drawing.Size(101, 40)
        Me.btLogin.TabIndex = 0
        Me.btLogin.Text = "LOGIN"
        Me.btLogin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bienvenido"
        '
        'btCaja
        '
        Me.btCaja.Enabled = False
        Me.btCaja.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCaja.Location = New System.Drawing.Point(17, 115)
        Me.btCaja.Name = "btCaja"
        Me.btCaja.Size = New System.Drawing.Size(101, 40)
        Me.btCaja.TabIndex = 5
        Me.btCaja.Text = "CAJA"
        Me.btCaja.UseVisualStyleBackColor = True
        '
        'btProductos
        '
        Me.btProductos.Enabled = False
        Me.btProductos.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btProductos.Location = New System.Drawing.Point(17, 161)
        Me.btProductos.Name = "btProductos"
        Me.btProductos.Size = New System.Drawing.Size(101, 40)
        Me.btProductos.TabIndex = 6
        Me.btProductos.Text = "PRODUCTOS"
        Me.btProductos.UseVisualStyleBackColor = True
        '
        'btUsuarios
        '
        Me.btUsuarios.Enabled = False
        Me.btUsuarios.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btUsuarios.Location = New System.Drawing.Point(17, 207)
        Me.btUsuarios.Name = "btUsuarios"
        Me.btUsuarios.Size = New System.Drawing.Size(101, 40)
        Me.btUsuarios.TabIndex = 7
        Me.btUsuarios.Text = "USUARIOS"
        Me.btUsuarios.UseVisualStyleBackColor = True
        '
        'btInformes
        '
        Me.btInformes.Enabled = False
        Me.btInformes.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btInformes.Location = New System.Drawing.Point(17, 253)
        Me.btInformes.Name = "btInformes"
        Me.btInformes.Size = New System.Drawing.Size(101, 40)
        Me.btInformes.TabIndex = 8
        Me.btInformes.Text = "INFORMES"
        Me.btInformes.UseVisualStyleBackColor = True
        '
        'lMain
        '
        Me.lMain.AutoSize = True
        Me.lMain.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lMain.Location = New System.Drawing.Point(150, 59)
        Me.lMain.Name = "lMain"
        Me.lMain.Size = New System.Drawing.Size(315, 50)
        Me.lMain.TabIndex = 9
        Me.lMain.Text = "Sistema de control de ventas y stock" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "             Por favor inicie sesion"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(191, 118)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(245, 247)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'status
        '
        Me.status.AutoSize = True
        Me.status.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status.Location = New System.Drawing.Point(150, 16)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(242, 25)
        Me.status.TabIndex = 11
        Me.status.Text = "SERVIDOR DESCONECTADO"
        Me.status.Visible = False
        '
        'btSalir
        '
        Me.btSalir.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalir.Location = New System.Drawing.Point(17, 324)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(101, 40)
        Me.btSalir.TabIndex = 12
        Me.btSalir.Text = "SALIR"
        Me.btSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btSalir.UseVisualStyleBackColor = True
        '
        'lUser
        '
        Me.lUser.AutoSize = True
        Me.lUser.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lUser.Location = New System.Drawing.Point(137, 16)
        Me.lUser.Name = "lUser"
        Me.lUser.Size = New System.Drawing.Size(137, 30)
        Me.lUser.TabIndex = 13
        Me.lUser.Text = "Desconocido"
        Me.lUser.Visible = False
        '
        'btLogout
        '
        Me.btLogout.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLogout.Location = New System.Drawing.Point(17, 69)
        Me.btLogout.Name = "btLogout"
        Me.btLogout.Size = New System.Drawing.Size(101, 40)
        Me.btLogout.TabIndex = 14
        Me.btLogout.Text = "LOGOUT"
        Me.btLogout.UseVisualStyleBackColor = True
        Me.btLogout.Visible = False
        '
        'Bienvenido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 376)
        Me.Controls.Add(Me.btLogout)
        Me.Controls.Add(Me.lUser)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lMain)
        Me.Controls.Add(Me.btInformes)
        Me.Controls.Add(Me.btUsuarios)
        Me.Controls.Add(Me.btProductos)
        Me.Controls.Add(Me.btCaja)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Bienvenido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SenPos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    'Friend btSalir As System.Windows.Forms.Button
    Friend WithEvents btSalir As Button
    Friend WithEvents btLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btCaja As Button
    Friend WithEvents btProductos As Button
    Friend WithEvents btUsuarios As Button
    Friend WithEvents btInformes As Button
    Friend WithEvents lMain As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents status As Label
    Friend WithEvents lUser As Label
    Friend WithEvents btLogout As Button
End Class
