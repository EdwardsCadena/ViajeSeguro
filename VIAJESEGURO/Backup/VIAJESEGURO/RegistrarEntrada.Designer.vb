<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarEntrada
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
        Me.Button3 = New System.Windows.Forms.Button
        Me.rol = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.usuario = New System.Windows.Forms.TextBox
        Me.contraseña = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.direccion = New System.Windows.Forms.TextBox
        Me.apellido = New System.Windows.Forms.TextBox
        Me.nombre = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Location = New System.Drawing.Point(411, 312)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(162, 47)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "REGRESAR"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'rol
        '
        Me.rol.Location = New System.Drawing.Point(411, 244)
        Me.rol.Name = "rol"
        Me.rol.ReadOnly = True
        Me.rol.Size = New System.Drawing.Size(158, 20)
        Me.rol.TabIndex = 35
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(221, 312)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(162, 47)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "GRABAR"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Location = New System.Drawing.Point(475, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Rol"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Location = New System.Drawing.Point(76, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Contraseña"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(293, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Usuario"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(8, 312)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 47)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "NUEVO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'usuario
        '
        Me.usuario.Location = New System.Drawing.Point(221, 174)
        Me.usuario.Name = "usuario"
        Me.usuario.ReadOnly = True
        Me.usuario.Size = New System.Drawing.Size(162, 20)
        Me.usuario.TabIndex = 27
        '
        'contraseña
        '
        Me.contraseña.Location = New System.Drawing.Point(12, 244)
        Me.contraseña.Name = "contraseña"
        Me.contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(5465)
        Me.contraseña.ReadOnly = True
        Me.contraseña.Size = New System.Drawing.Size(158, 20)
        Me.contraseña.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(465, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Direccion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(93, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Apellido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(313, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Nombre"
        '
        'direccion
        '
        Me.direccion.Location = New System.Drawing.Point(411, 124)
        Me.direccion.Name = "direccion"
        Me.direccion.Size = New System.Drawing.Size(158, 20)
        Me.direccion.TabIndex = 22
        '
        'apellido
        '
        Me.apellido.Location = New System.Drawing.Point(46, 111)
        Me.apellido.Name = "apellido"
        Me.apellido.ReadOnly = True
        Me.apellido.Size = New System.Drawing.Size(158, 20)
        Me.apellido.TabIndex = 21
        '
        'nombre
        '
        Me.nombre.Location = New System.Drawing.Point(252, 56)
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Size = New System.Drawing.Size(162, 20)
        Me.nombre.TabIndex = 20
        '
        'RegistrarEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(633, 383)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.rol)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.usuario)
        Me.Controls.Add(Me.contraseña)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.direccion)
        Me.Controls.Add(Me.apellido)
        Me.Controls.Add(Me.nombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "RegistrarEntrada"
        Me.Text = "RegistrarEntrada"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents rol As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents usuario As System.Windows.Forms.TextBox
    Friend WithEvents contraseña As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents direccion As System.Windows.Forms.TextBox
    Friend WithEvents apellido As System.Windows.Forms.TextBox
    Friend WithEvents nombre As System.Windows.Forms.TextBox
End Class
