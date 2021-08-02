<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_acceso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_acceso))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTN_CANCELAR_INICIO = New System.Windows.Forms.Button()
        Me.BTN_ACEPTAR_INICIO = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_contraseña_acceso = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_usuario_acceso = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(1, 73)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(435, 116)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BTN_CANCELAR_INICIO)
        Me.GroupBox2.Controls.Add(Me.BTN_ACEPTAR_INICIO)
        Me.GroupBox2.Location = New System.Drawing.Point(310, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(119, 91)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Botones"
        '
        'BTN_CANCELAR_INICIO
        '
        Me.BTN_CANCELAR_INICIO.BackColor = System.Drawing.Color.White
        Me.BTN_CANCELAR_INICIO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTN_CANCELAR_INICIO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_CANCELAR_INICIO.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CANCELAR_INICIO.ForeColor = System.Drawing.Color.Red
        Me.BTN_CANCELAR_INICIO.Image = Global.Sistema_para_control_de_produccion.My.Resources.Resources.Windows_Close_Program_22531
        Me.BTN_CANCELAR_INICIO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_CANCELAR_INICIO.Location = New System.Drawing.Point(11, 49)
        Me.BTN_CANCELAR_INICIO.Name = "BTN_CANCELAR_INICIO"
        Me.BTN_CANCELAR_INICIO.Size = New System.Drawing.Size(99, 36)
        Me.BTN_CANCELAR_INICIO.TabIndex = 8
        Me.BTN_CANCELAR_INICIO.Text = "  Salir"
        Me.BTN_CANCELAR_INICIO.UseVisualStyleBackColor = False
        '
        'BTN_ACEPTAR_INICIO
        '
        Me.BTN_ACEPTAR_INICIO.BackColor = System.Drawing.Color.White
        Me.BTN_ACEPTAR_INICIO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTN_ACEPTAR_INICIO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_ACEPTAR_INICIO.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ACEPTAR_INICIO.ForeColor = System.Drawing.Color.Red
        Me.BTN_ACEPTAR_INICIO.Image = Global.Sistema_para_control_de_produccion.My.Resources.Resources.solicit_accept_check_ok_theaction_6340
        Me.BTN_ACEPTAR_INICIO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_ACEPTAR_INICIO.Location = New System.Drawing.Point(10, 16)
        Me.BTN_ACEPTAR_INICIO.Name = "BTN_ACEPTAR_INICIO"
        Me.BTN_ACEPTAR_INICIO.Size = New System.Drawing.Size(99, 31)
        Me.BTN_ACEPTAR_INICIO.TabIndex = 7
        Me.BTN_ACEPTAR_INICIO.Text = "       Aceptar"
        Me.BTN_ACEPTAR_INICIO.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_contraseña_acceso)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_usuario_acceso)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 91)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(282, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(282, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "*"
        '
        'txt_contraseña_acceso
        '
        Me.txt_contraseña_acceso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_contraseña_acceso.Location = New System.Drawing.Point(120, 51)
        Me.txt_contraseña_acceso.MaxLength = 15
        Me.txt_contraseña_acceso.Name = "txt_contraseña_acceso"
        Me.txt_contraseña_acceso.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_contraseña_acceso.Size = New System.Drawing.Size(155, 20)
        Me.txt_contraseña_acceso.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(7, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "     Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(7, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "     Contraseña"
        Me.Label2.UseWaitCursor = True
        '
        'txt_usuario_acceso
        '
        Me.txt_usuario_acceso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_usuario_acceso.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_usuario_acceso.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_usuario_acceso.Location = New System.Drawing.Point(120, 25)
        Me.txt_usuario_acceso.MaxLength = 15
        Me.txt_usuario_acceso.Name = "txt_usuario_acceso"
        Me.txt_usuario_acceso.Size = New System.Drawing.Size(155, 20)
        Me.txt_usuario_acceso.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.Crimson
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(-3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(367, 72)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = " Sistema De Organización y Planificación" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                                     Ve" & _
    "rsion 1.0 "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sistema_para_control_de_produccion.My.Resources.Resources.folders_red_scheduled_tasks_10933__1_
        Me.PictureBox1.Location = New System.Drawing.Point(370, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 72)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'frm_acceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(463, 190)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_acceso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                                         Seguridad"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BTN_CANCELAR_INICIO As System.Windows.Forms.Button
    Friend WithEvents BTN_ACEPTAR_INICIO As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_contraseña_acceso As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_usuario_acceso As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
