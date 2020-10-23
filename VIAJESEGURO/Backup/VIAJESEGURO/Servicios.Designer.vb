<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Servicios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Servicios))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.VuelosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VuelosInternacionalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VuelosNacionalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HotelesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HotelesInternacionalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HotelesNacionalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConfiguracionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BorrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RegistarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DGDatos = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.banner = New AxShockwaveFlashObjects.AxShockwaveFlash
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DGDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VuelosToolStripMenuItem, Me.HotelesToolStripMenuItem, Me.SesionToolStripMenuItem, Me.ConfiguracionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(990, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VuelosToolStripMenuItem
        '
        Me.VuelosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VuelosInternacionalesToolStripMenuItem, Me.VuelosNacionalesToolStripMenuItem})
        Me.VuelosToolStripMenuItem.Name = "VuelosToolStripMenuItem"
        Me.VuelosToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.VuelosToolStripMenuItem.Text = "Vuelos"
        '
        'VuelosInternacionalesToolStripMenuItem
        '
        Me.VuelosInternacionalesToolStripMenuItem.Name = "VuelosInternacionalesToolStripMenuItem"
        Me.VuelosInternacionalesToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.VuelosInternacionalesToolStripMenuItem.Text = "Vuelos Internacionales"
        '
        'VuelosNacionalesToolStripMenuItem
        '
        Me.VuelosNacionalesToolStripMenuItem.Name = "VuelosNacionalesToolStripMenuItem"
        Me.VuelosNacionalesToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.VuelosNacionalesToolStripMenuItem.Text = "Vuelos Nacionales"
        '
        'HotelesToolStripMenuItem
        '
        Me.HotelesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HotelesInternacionalesToolStripMenuItem, Me.HotelesNacionalesToolStripMenuItem})
        Me.HotelesToolStripMenuItem.Name = "HotelesToolStripMenuItem"
        Me.HotelesToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.HotelesToolStripMenuItem.Text = "Hoteles"
        '
        'HotelesInternacionalesToolStripMenuItem
        '
        Me.HotelesInternacionalesToolStripMenuItem.Name = "HotelesInternacionalesToolStripMenuItem"
        Me.HotelesInternacionalesToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.HotelesInternacionalesToolStripMenuItem.Text = "Hoteles Internacionales"
        '
        'HotelesNacionalesToolStripMenuItem
        '
        Me.HotelesNacionalesToolStripMenuItem.Name = "HotelesNacionalesToolStripMenuItem"
        Me.HotelesNacionalesToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.HotelesNacionalesToolStripMenuItem.Text = "Hoteles Nacionales "
        '
        'SesionToolStripMenuItem
        '
        Me.SesionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesionToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.SesionToolStripMenuItem.Name = "SesionToolStripMenuItem"
        Me.SesionToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.SesionToolStripMenuItem.Text = "Sesion"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar Sesion"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ConfiguracionesToolStripMenuItem
        '
        Me.ConfiguracionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrarToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.RegistarToolStripMenuItem})
        Me.ConfiguracionesToolStripMenuItem.Name = "ConfiguracionesToolStripMenuItem"
        Me.ConfiguracionesToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.ConfiguracionesToolStripMenuItem.Text = "Configuraciones"
        '
        'BorrarToolStripMenuItem
        '
        Me.BorrarToolStripMenuItem.Name = "BorrarToolStripMenuItem"
        Me.BorrarToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.BorrarToolStripMenuItem.Text = "Borrar"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        '
        'RegistarToolStripMenuItem
        '
        Me.RegistarToolStripMenuItem.Name = "RegistarToolStripMenuItem"
        Me.RegistarToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.RegistarToolStripMenuItem.Text = "Registar"
        '
        'DGDatos
        '
        Me.DGDatos.AllowUserToAddRows = False
        Me.DGDatos.AllowUserToDeleteRows = False
        Me.DGDatos.AllowUserToResizeColumns = False
        Me.DGDatos.AllowUserToResizeRows = False
        Me.DGDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGDatos.Location = New System.Drawing.Point(101, 118)
        Me.DGDatos.Name = "DGDatos"
        Me.DGDatos.ReadOnly = True
        Me.DGDatos.Size = New System.Drawing.Size(787, 149)
        Me.DGDatos.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 320)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "CodRol"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 366)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Nombres"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(377, 327)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Apellidos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(377, 366)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Direccion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(698, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Usuario"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(679, 373)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Contraseña" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(432, 283)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(133, 20)
        Me.TextBox1.TabIndex = 28
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(89, 320)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(133, 20)
        Me.TextBox2.TabIndex = 29
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(89, 362)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(133, 20)
        Me.TextBox3.TabIndex = 30
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(432, 327)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(133, 20)
        Me.TextBox4.TabIndex = 31
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(432, 359)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(133, 20)
        Me.TextBox5.TabIndex = 32
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(747, 316)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(133, 20)
        Me.TextBox6.TabIndex = 33
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkBlue
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.Location = New System.Drawing.Point(326, 412)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(103, 89)
        Me.Button4.TabIndex = 35
        Me.Button4.Text = "Guardar"
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Wide Latin", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(354, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(312, 33)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "SERVICIOS"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkBlue
        Me.Button3.BackgroundImage = Global.VIAJESEGURO.My.Resources.Resources.appleupdate
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.Location = New System.Drawing.Point(89, 412)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 89)
        Me.Button3.TabIndex = 34
        Me.Button3.Text = "Actualizar"
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(818, 413)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 89)
        Me.Button2.TabIndex = 21
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(576, 412)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 89)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Registrarse"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'banner
        '
        Me.banner.Enabled = True
        Me.banner.Location = New System.Drawing.Point(301, 516)
        Me.banner.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.banner.Name = "banner"
        Me.banner.OcxState = CType(resources.GetObject("banner.OcxState"), System.Windows.Forms.AxHost.State)
        Me.banner.Size = New System.Drawing.Size(365, 73)
        Me.banner.TabIndex = 37
        '
        'TextBox7
        '
        Me.TextBox7.Enabled = False
        Me.TextBox7.Location = New System.Drawing.Point(747, 370)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(133, 20)
        Me.TextBox7.TabIndex = 38
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(366, 290)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Codusuario"
        '
        'Servicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(990, 601)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.banner)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DGDatos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Servicios"
        Me.Text = "Servicios"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DGDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents VuelosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HotelesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DGDatos As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents SesionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguracionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents VuelosInternacionalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VuelosNacionalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HotelesInternacionalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HotelesNacionalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents banner As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
