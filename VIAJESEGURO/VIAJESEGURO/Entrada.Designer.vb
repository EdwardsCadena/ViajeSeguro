<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entrada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Entrada))
        Me.acceso = New System.Windows.Forms.Button()
        Me.roles = New System.Windows.Forms.ComboBox()
        Me.contraseña = New System.Windows.Forms.TextBox()
        Me.usuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.banner = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'acceso
        '
        Me.acceso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.acceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acceso.Location = New System.Drawing.Point(338, 425)
        Me.acceso.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.acceso.Name = "acceso"
        Me.acceso.Size = New System.Drawing.Size(228, 31)
        Me.acceso.TabIndex = 16
        Me.acceso.Text = "Entrar"
        Me.acceso.UseVisualStyleBackColor = True
        '
        'roles
        '
        Me.roles.Cursor = System.Windows.Forms.Cursors.PanSouth
        Me.roles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.roles.FormattingEnabled = True
        Me.roles.Items.AddRange(New Object() {""})
        Me.roles.Location = New System.Drawing.Point(338, 251)
        Me.roles.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.roles.Name = "roles"
        Me.roles.Size = New System.Drawing.Size(228, 21)
        Me.roles.TabIndex = 15
        '
        'contraseña
        '
        Me.contraseña.Location = New System.Drawing.Point(338, 387)
        Me.contraseña.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.contraseña.Name = "contraseña"
        Me.contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(163)
        Me.contraseña.Size = New System.Drawing.Size(228, 20)
        Me.contraseña.TabIndex = 14
        '
        'usuario
        '
        Me.usuario.Location = New System.Drawing.Point(338, 347)
        Me.usuario.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(228, 20)
        Me.usuario.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.CausesValidation = False
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(219, 387)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 22)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(234, 344)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 22)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Usuario"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(716, 309)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 20)
        Me.TextBox1.TabIndex = 20
        Me.TextBox1.Visible = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(633, 414)
        Me.Button1.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(233, 119)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Registrarse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(376, 117)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 128)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(344, 514)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 25)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "INICIAR SESION"
        '
        'banner
        '
        Me.banner.Enabled = True
        Me.banner.Location = New System.Drawing.Point(275, 3)
        Me.banner.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.banner.Name = "banner"
        Me.banner.OcxState = CType(resources.GetObject("banner.OcxState"), System.Windows.Forms.AxHost.State)
        Me.banner.Size = New System.Drawing.Size(365, 73)
        Me.banner.TabIndex = 30
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(12, 12)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(253, 156)
        Me.AxWindowsMediaPlayer1.TabIndex = 31
        Me.AxWindowsMediaPlayer1.Visible = False
        '
        'Entrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.VIAJESEGURO.My.Resources.Resources.Bellagio_Las_Vegas
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(895, 565)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.banner)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.acceso)
        Me.Controls.Add(Me.roles)
        Me.Controls.Add(Me.contraseña)
        Me.Controls.Add(Me.usuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.Name = "Entrada"
        Me.Text = "Entrada"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents acceso As System.Windows.Forms.Button
    Friend WithEvents roles As System.Windows.Forms.ComboBox
    Friend WithEvents contraseña As System.Windows.Forms.TextBox
    Friend WithEvents usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents banner As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
End Class
