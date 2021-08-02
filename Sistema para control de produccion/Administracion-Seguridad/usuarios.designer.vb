<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usuarios
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usuarios))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv_llenar = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_escoger = New System.Windows.Forms.Button()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.txt_participante = New System.Windows.Forms.TextBox()
        Me.txt_contraseña = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbo_combo_perfiles = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_añadir = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_llenar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgv_llenar)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(615, 401)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'dgv_llenar
        '
        Me.dgv_llenar.AllowUserToAddRows = False
        Me.dgv_llenar.AllowUserToDeleteRows = False
        Me.dgv_llenar.AllowUserToResizeColumns = False
        Me.dgv_llenar.AllowUserToResizeRows = False
        Me.dgv_llenar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_llenar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_llenar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_llenar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_llenar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_llenar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgv_llenar.GridColor = System.Drawing.Color.Blue
        Me.dgv_llenar.Location = New System.Drawing.Point(17, 180)
        Me.dgv_llenar.Name = "dgv_llenar"
        Me.dgv_llenar.ReadOnly = True
        Me.dgv_llenar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_llenar.Size = New System.Drawing.Size(586, 213)
        Me.dgv_llenar.TabIndex = 12
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.btn_escoger)
        Me.GroupBox3.Controls.Add(Me.txt_codigo)
        Me.GroupBox3.Controls.Add(Me.txt_participante)
        Me.GroupBox3.Controls.Add(Me.txt_contraseña)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.cbo_combo_perfiles)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txt_usuario)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(586, 155)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos"
        '
        'btn_escoger
        '
        Me.btn_escoger.BackColor = System.Drawing.Color.Blue
        Me.btn_escoger.BackgroundImage = Global.Sistema_para_control_de_produccion.My.Resources.Resources.Male_user_search_icon
        Me.btn_escoger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_escoger.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_escoger.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_escoger.ForeColor = System.Drawing.Color.Red
        Me.btn_escoger.Location = New System.Drawing.Point(471, 22)
        Me.btn_escoger.Name = "btn_escoger"
        Me.btn_escoger.Size = New System.Drawing.Size(39, 39)
        Me.btn_escoger.TabIndex = 10
        Me.btn_escoger.Text = " "
        Me.ToolTip1.SetToolTip(Me.btn_escoger, "Listado de Empleados")
        Me.btn_escoger.UseVisualStyleBackColor = False
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(305, 85)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(100, 20)
        Me.txt_codigo.TabIndex = 5
        Me.txt_codigo.Visible = False
        '
        'txt_participante
        '
        Me.txt_participante.Enabled = False
        Me.txt_participante.Location = New System.Drawing.Point(305, 37)
        Me.txt_participante.Name = "txt_participante"
        Me.txt_participante.Size = New System.Drawing.Size(160, 20)
        Me.txt_participante.TabIndex = 9
        '
        'txt_contraseña
        '
        Me.txt_contraseña.Location = New System.Drawing.Point(97, 128)
        Me.txt_contraseña.Name = "txt_contraseña"
        Me.txt_contraseña.Size = New System.Drawing.Size(121, 20)
        Me.txt_contraseña.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Perfiles:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(245, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Empleado:"
        '
        'cbo_combo_perfiles
        '
        Me.cbo_combo_perfiles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbo_combo_perfiles.DisplayMember = "per_nombre"
        Me.cbo_combo_perfiles.FormattingEnabled = True
        Me.cbo_combo_perfiles.Location = New System.Drawing.Point(98, 38)
        Me.cbo_combo_perfiles.Name = "cbo_combo_perfiles"
        Me.cbo_combo_perfiles.Size = New System.Drawing.Size(121, 21)
        Me.cbo_combo_perfiles.TabIndex = 1
        Me.cbo_combo_perfiles.ValueMember = "per_id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Usuario:"
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(98, 86)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(121, 20)
        Me.txt_usuario.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Contraseña:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.btn_modificar)
        Me.GroupBox2.Controls.Add(Me.btn_eliminar)
        Me.GroupBox2.Controls.Add(Me.btn_salir)
        Me.GroupBox2.Controls.Add(Me.btn_añadir)
        Me.GroupBox2.Location = New System.Drawing.Point(633, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(167, 401)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sistema_para_control_de_produccion.My.Resources.Resources.Apps_preferences_desktop_user_icon
        Me.PictureBox1.Location = New System.Drawing.Point(60, 57)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(53, 54)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'btn_modificar
        '
        Me.btn_modificar.BackColor = System.Drawing.Color.Blue
        Me.btn_modificar.BackgroundImage = Global.Sistema_para_control_de_produccion.My.Resources.Resources.system_software_update_icon
        Me.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_modificar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar.ForeColor = System.Drawing.Color.White
        Me.btn_modificar.Location = New System.Drawing.Point(33, 237)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(114, 40)
        Me.btn_modificar.TabIndex = 10
        Me.btn_modificar.Text = "       &Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.Blue
        Me.btn_eliminar.BackgroundImage = Global.Sistema_para_control_de_produccion.My.Resources.Resources.Windows_Close_Program_22531
        Me.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_eliminar.FlatAppearance.BorderSize = 4
        Me.btn_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btn_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn_eliminar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.ForeColor = System.Drawing.Color.White
        Me.btn_eliminar.Location = New System.Drawing.Point(33, 293)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(114, 40)
        Me.btn_eliminar.TabIndex = 11
        Me.btn_eliminar.Text = "     &Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.Blue
        Me.btn_salir.BackgroundImage = Global.Sistema_para_control_de_produccion.My.Resources.Resources.volver
        Me.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_salir.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.ForeColor = System.Drawing.Color.White
        Me.btn_salir.Location = New System.Drawing.Point(33, 351)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(114, 40)
        Me.btn_salir.TabIndex = 9
        Me.btn_salir.Text = "   &Volver"
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'btn_añadir
        '
        Me.btn_añadir.BackColor = System.Drawing.Color.Blue
        Me.btn_añadir.BackgroundImage = Global.Sistema_para_control_de_produccion.My.Resources.Resources.add_1_icon
        Me.btn_añadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_añadir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_añadir.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_añadir.ForeColor = System.Drawing.Color.White
        Me.btn_añadir.Location = New System.Drawing.Point(33, 183)
        Me.btn_añadir.Name = "btn_añadir"
        Me.btn_añadir.Size = New System.Drawing.Size(114, 40)
        Me.btn_añadir.TabIndex = 0
        Me.btn_añadir.Text = "   &Añadir"
        Me.btn_añadir.UseVisualStyleBackColor = False
        '
        'usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Sistema_para_control_de_produccion.My.Resources.Resources.datos_generales
        Me.ClientSize = New System.Drawing.Size(808, 425)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "usuarios"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv_llenar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_contraseña As System.Windows.Forms.TextBox
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbo_combo_perfiles As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_escoger As System.Windows.Forms.Button
    Friend WithEvents txt_participante As System.Windows.Forms.TextBox
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_añadir As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents dgv_llenar As System.Windows.Forms.DataGridView
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
