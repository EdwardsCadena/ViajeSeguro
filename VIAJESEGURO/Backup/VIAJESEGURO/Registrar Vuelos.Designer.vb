<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar_Vuelos
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
        Me.btnnuevo = New System.Windows.Forms.Button
        Me.btngrabar = New System.Windows.Forms.Button
        Me.btnregresar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtnomempresa = New System.Windows.Forms.TextBox
        Me.txtnompasa = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.nda = New System.Windows.Forms.ComboBox
        Me.pdd = New System.Windows.Forms.ComboBox
        Me.ciudad = New System.Windows.Forms.ComboBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.SuspendLayout()
        '
        'btnnuevo
        '
        Me.btnnuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnuevo.Location = New System.Drawing.Point(86, 436)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(114, 57)
        Me.btnnuevo.TabIndex = 0
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'btngrabar
        '
        Me.btngrabar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btngrabar.Location = New System.Drawing.Point(329, 436)
        Me.btngrabar.Name = "btngrabar"
        Me.btngrabar.Size = New System.Drawing.Size(114, 57)
        Me.btngrabar.TabIndex = 1
        Me.btngrabar.Text = "Grabar"
        Me.btngrabar.UseVisualStyleBackColor = True
        Me.btngrabar.Visible = False
        '
        'btnregresar
        '
        Me.btnregresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnregresar.Location = New System.Drawing.Point(546, 436)
        Me.btnregresar.Name = "btnregresar"
        Me.btnregresar.Size = New System.Drawing.Size(114, 57)
        Me.btnregresar.TabIndex = 2
        Me.btnregresar.Text = "Regresar"
        Me.btnregresar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre De Empresa de Vuelo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(422, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre Del Pasajero"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(70, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nombre del Aeropuerto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(447, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha de Vuelo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(105, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Pais de Destino"
        '
        'txtnomempresa
        '
        Me.txtnomempresa.Location = New System.Drawing.Point(219, 35)
        Me.txtnomempresa.Name = "txtnomempresa"
        Me.txtnomempresa.ReadOnly = True
        Me.txtnomempresa.Size = New System.Drawing.Size(100, 20)
        Me.txtnomempresa.TabIndex = 12
        '
        'txtnompasa
        '
        Me.txtnompasa.Location = New System.Drawing.Point(535, 35)
        Me.txtnompasa.Name = "txtnompasa"
        Me.txtnompasa.ReadOnly = True
        Me.txtnompasa.Size = New System.Drawing.Size(100, 20)
        Me.txtnompasa.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(473, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Ciudad"
        '
        'nda
        '
        Me.nda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.nda.FormattingEnabled = True
        Me.nda.Items.AddRange(New Object() {"Barajas"})
        Me.nda.Location = New System.Drawing.Point(220, 119)
        Me.nda.Name = "nda"
        Me.nda.Size = New System.Drawing.Size(121, 21)
        Me.nda.TabIndex = 21
        '
        'pdd
        '
        Me.pdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pdd.FormattingEnabled = True
        Me.pdd.Items.AddRange(New Object() {"España"})
        Me.pdd.Location = New System.Drawing.Point(219, 182)
        Me.pdd.Name = "pdd"
        Me.pdd.Size = New System.Drawing.Size(121, 21)
        Me.pdd.TabIndex = 22
        '
        'ciudad
        '
        Me.ciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ciudad.FormattingEnabled = True
        Me.ciudad.Items.AddRange(New Object() {"Madrid"})
        Me.ciudad.Location = New System.Drawing.Point(546, 275)
        Me.ciudad.Name = "ciudad"
        Me.ciudad.Size = New System.Drawing.Size(121, 21)
        Me.ciudad.TabIndex = 23
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(535, 124)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 24
        '
        'Registrar_Vuelos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(787, 505)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ciudad)
        Me.Controls.Add(Me.pdd)
        Me.Controls.Add(Me.nda)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtnompasa)
        Me.Controls.Add(Me.txtnomempresa)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnregresar)
        Me.Controls.Add(Me.btngrabar)
        Me.Controls.Add(Me.btnnuevo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Registrar_Vuelos"
        Me.Text = "Registrar_Vuelos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents btngrabar As System.Windows.Forms.Button
    Friend WithEvents btnregresar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtnomempresa As System.Windows.Forms.TextBox
    Friend WithEvents txtnompasa As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents nda As System.Windows.Forms.ComboBox
    Friend WithEvents pdd As System.Windows.Forms.ComboBox
    Friend WithEvents ciudad As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
