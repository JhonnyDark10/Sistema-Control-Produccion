<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_inventario
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_inventario))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_escoger = New System.Windows.Forms.Button()
        Me.cbo_embarcaciones = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_piloto = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtp_inicio_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.gbo_recursos_a = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgv_listaimplementos2 = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Detalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_listaimplementos = New System.Windows.Forms.DataGridView()
        Me.txt_listaImplementos = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_regresar = New System.Windows.Forms.Button()
        Me.btn_mover = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgv_personal2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_personal1 = New System.Windows.Forms.DataGridView()
        Me.txt_personal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_2 = New System.Windows.Forms.Button()
        Me.btn_1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gbo_recursos_a.SuspendLayout()
        CType(Me.dgv_listaimplementos2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_listaimplementos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgv_personal2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_personal1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(845, 422)
        Me.TabControl1.TabIndex = 41
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.txt_descripcion)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(837, 396)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "General"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.btn_guardar)
        Me.GroupBox4.Controls.Add(Me.PictureBox2)
        Me.GroupBox4.Controls.Add(Me.btn_salir)
        Me.GroupBox4.Location = New System.Drawing.Point(657, 20)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(167, 364)
        Me.GroupBox4.TabIndex = 69
        Me.GroupBox4.TabStop = False
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.Blue
        Me.btn_guardar.BackgroundImage = Global.Sistema_para_control_de_produccion.My.Resources.Resources.Black_Floppy_icon
        Me.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_guardar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.ForeColor = System.Drawing.Color.White
        Me.btn_guardar.Location = New System.Drawing.Point(26, 192)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(114, 40)
        Me.btn_guardar.TabIndex = 13
        Me.btn_guardar.Text = "     &Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Sistema_para_control_de_produccion.My.Resources.Resources._1492531743_icon_sets_school_outline_hand_drawn_iconfinder02_832031
        Me.PictureBox2.Location = New System.Drawing.Point(60, 57)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(53, 54)
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.Blue
        Me.btn_salir.BackgroundImage = Global.Sistema_para_control_de_produccion.My.Resources.Resources.volver
        Me.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_salir.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.ForeColor = System.Drawing.Color.White
        Me.btn_salir.Location = New System.Drawing.Point(26, 255)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(114, 40)
        Me.btn_salir.TabIndex = 9
        Me.btn_salir.Text = "   &Volver"
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(616, 192)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.btn_escoger)
        Me.GroupBox3.Controls.Add(Me.cbo_embarcaciones)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.txt_piloto)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 76)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(604, 101)
        Me.GroupBox3.TabIndex = 67
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Recursos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(369, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 20)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "*"
        '
        'btn_escoger
        '
        Me.btn_escoger.BackColor = System.Drawing.Color.Blue
        Me.btn_escoger.BackgroundImage = Global.Sistema_para_control_de_produccion.My.Resources.Resources.Male_user_search_icon
        Me.btn_escoger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_escoger.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_escoger.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_escoger.ForeColor = System.Drawing.Color.Red
        Me.btn_escoger.Location = New System.Drawing.Point(324, 56)
        Me.btn_escoger.Name = "btn_escoger"
        Me.btn_escoger.Size = New System.Drawing.Size(39, 39)
        Me.btn_escoger.TabIndex = 73
        Me.btn_escoger.Text = " "
        Me.btn_escoger.UseVisualStyleBackColor = False
        '
        'cbo_embarcaciones
        '
        Me.cbo_embarcaciones.DisplayMember = "emb_nombre"
        Me.cbo_embarcaciones.FormattingEnabled = True
        Me.cbo_embarcaciones.Location = New System.Drawing.Point(88, 26)
        Me.cbo_embarcaciones.Name = "cbo_embarcaciones"
        Me.cbo_embarcaciones.Size = New System.Drawing.Size(224, 21)
        Me.cbo_embarcaciones.TabIndex = 66
        Me.cbo_embarcaciones.ValueMember = "emb_id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Embarcación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Piloto"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(320, 26)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(15, 20)
        Me.Label20.TabIndex = 72
        Me.Label20.Text = "*"
        '
        'txt_piloto
        '
        Me.txt_piloto.Location = New System.Drawing.Point(88, 72)
        Me.txt_piloto.Name = "txt_piloto"
        Me.txt_piloto.Size = New System.Drawing.Size(224, 20)
        Me.txt_piloto.TabIndex = 71
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_codigo)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.dtp_inicio_fecha)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(604, 60)
        Me.GroupBox2.TabIndex = 66
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tiempo"
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(159, 24)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(100, 20)
        Me.txt_codigo.TabIndex = 66
        Me.txt_codigo.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(365, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Fecha de Asignación"
        '
        'dtp_inicio_fecha
        '
        Me.dtp_inicio_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_inicio_fecha.Location = New System.Drawing.Point(482, 21)
        Me.dtp_inicio_fecha.Name = "dtp_inicio_fecha"
        Me.dtp_inicio_fecha.Size = New System.Drawing.Size(94, 20)
        Me.dtp_inicio_fecha.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(580, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 20)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(94, 215)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(15, 20)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 220)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Descripción:"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(30, 240)
        Me.txt_descripcion.Multiline = True
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(616, 144)
        Me.txt_descripcion.TabIndex = 16
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gbo_recursos_a)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(837, 396)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Implementos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'gbo_recursos_a
        '
        Me.gbo_recursos_a.Controls.Add(Me.Label6)
        Me.gbo_recursos_a.Controls.Add(Me.dgv_listaimplementos2)
        Me.gbo_recursos_a.Controls.Add(Me.dgv_listaimplementos)
        Me.gbo_recursos_a.Controls.Add(Me.txt_listaImplementos)
        Me.gbo_recursos_a.Controls.Add(Me.Label7)
        Me.gbo_recursos_a.Controls.Add(Me.btn_regresar)
        Me.gbo_recursos_a.Controls.Add(Me.btn_mover)
        Me.gbo_recursos_a.Location = New System.Drawing.Point(19, 11)
        Me.gbo_recursos_a.Name = "gbo_recursos_a"
        Me.gbo_recursos_a.Size = New System.Drawing.Size(792, 379)
        Me.gbo_recursos_a.TabIndex = 20
        Me.gbo_recursos_a.TabStop = False
        Me.gbo_recursos_a.Text = "Escoger"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(372, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 20)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "*"
        '
        'dgv_listaimplementos2
        '
        Me.dgv_listaimplementos2.AllowUserToAddRows = False
        Me.dgv_listaimplementos2.AllowUserToDeleteRows = False
        Me.dgv_listaimplementos2.AllowUserToResizeColumns = False
        Me.dgv_listaimplementos2.AllowUserToResizeRows = False
        Me.dgv_listaimplementos2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_listaimplementos2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_listaimplementos2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listaimplementos2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Detalle})
        Me.dgv_listaimplementos2.Location = New System.Drawing.Point(450, 89)
        Me.dgv_listaimplementos2.Name = "dgv_listaimplementos2"
        Me.dgv_listaimplementos2.ReadOnly = True
        Me.dgv_listaimplementos2.RowHeadersVisible = False
        Me.dgv_listaimplementos2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_listaimplementos2.ShowEditingIcon = False
        Me.dgv_listaimplementos2.ShowRowErrors = False
        Me.dgv_listaimplementos2.Size = New System.Drawing.Size(250, 270)
        Me.dgv_listaimplementos2.TabIndex = 10
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Visible = False
        '
        'Detalle
        '
        Me.Detalle.HeaderText = "Detalle"
        Me.Detalle.Name = "Detalle"
        Me.Detalle.ReadOnly = True
        Me.Detalle.Width = 246
        '
        'dgv_listaimplementos
        '
        Me.dgv_listaimplementos.AllowUserToAddRows = False
        Me.dgv_listaimplementos.AllowUserToDeleteRows = False
        Me.dgv_listaimplementos.AllowUserToResizeColumns = False
        Me.dgv_listaimplementos.AllowUserToResizeRows = False
        Me.dgv_listaimplementos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_listaimplementos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_listaimplementos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listaimplementos.Location = New System.Drawing.Point(116, 89)
        Me.dgv_listaimplementos.Name = "dgv_listaimplementos"
        Me.dgv_listaimplementos.ReadOnly = True
        Me.dgv_listaimplementos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_listaimplementos.ShowEditingIcon = False
        Me.dgv_listaimplementos.ShowRowErrors = False
        Me.dgv_listaimplementos.Size = New System.Drawing.Size(250, 270)
        Me.dgv_listaimplementos.TabIndex = 9
        '
        'txt_listaImplementos
        '
        Me.txt_listaImplementos.Location = New System.Drawing.Point(75, 46)
        Me.txt_listaImplementos.Name = "txt_listaImplementos"
        Me.txt_listaImplementos.Size = New System.Drawing.Size(152, 20)
        Me.txt_listaImplementos.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(48, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Filtro"
        '
        'btn_regresar
        '
        Me.btn_regresar.Location = New System.Drawing.Point(395, 258)
        Me.btn_regresar.Name = "btn_regresar"
        Me.btn_regresar.Size = New System.Drawing.Size(30, 23)
        Me.btn_regresar.TabIndex = 5
        Me.btn_regresar.Text = "<"
        Me.btn_regresar.UseVisualStyleBackColor = True
        '
        'btn_mover
        '
        Me.btn_mover.Location = New System.Drawing.Point(395, 225)
        Me.btn_mover.Name = "btn_mover"
        Me.btn_mover.Size = New System.Drawing.Size(30, 23)
        Me.btn_mover.TabIndex = 3
        Me.btn_mover.Text = ">"
        Me.btn_mover.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(837, 396)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "Personal"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.dgv_personal2)
        Me.GroupBox5.Controls.Add(Me.dgv_personal1)
        Me.GroupBox5.Controls.Add(Me.txt_personal)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.btn_2)
        Me.GroupBox5.Controls.Add(Me.btn_1)
        Me.GroupBox5.Location = New System.Drawing.Point(22, 9)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(792, 379)
        Me.GroupBox5.TabIndex = 21
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Escoger"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(372, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 20)
        Me.Label9.TabIndex = 73
        Me.Label9.Text = "*"
        '
        'dgv_personal2
        '
        Me.dgv_personal2.AllowUserToAddRows = False
        Me.dgv_personal2.AllowUserToDeleteRows = False
        Me.dgv_personal2.AllowUserToResizeColumns = False
        Me.dgv_personal2.AllowUserToResizeRows = False
        Me.dgv_personal2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_personal2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_personal2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_personal2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.dgv_personal2.Location = New System.Drawing.Point(450, 89)
        Me.dgv_personal2.Name = "dgv_personal2"
        Me.dgv_personal2.ReadOnly = True
        Me.dgv_personal2.RowHeadersVisible = False
        Me.dgv_personal2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_personal2.ShowEditingIcon = False
        Me.dgv_personal2.ShowRowErrors = False
        Me.dgv_personal2.Size = New System.Drawing.Size(250, 270)
        Me.dgv_personal2.TabIndex = 10
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Detalle"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 246
        '
        'dgv_personal1
        '
        Me.dgv_personal1.AllowUserToAddRows = False
        Me.dgv_personal1.AllowUserToDeleteRows = False
        Me.dgv_personal1.AllowUserToResizeColumns = False
        Me.dgv_personal1.AllowUserToResizeRows = False
        Me.dgv_personal1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_personal1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_personal1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_personal1.Location = New System.Drawing.Point(116, 89)
        Me.dgv_personal1.Name = "dgv_personal1"
        Me.dgv_personal1.ReadOnly = True
        Me.dgv_personal1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_personal1.ShowEditingIcon = False
        Me.dgv_personal1.ShowRowErrors = False
        Me.dgv_personal1.Size = New System.Drawing.Size(250, 270)
        Me.dgv_personal1.TabIndex = 9
        '
        'txt_personal
        '
        Me.txt_personal.Location = New System.Drawing.Point(75, 46)
        Me.txt_personal.Name = "txt_personal"
        Me.txt_personal.Size = New System.Drawing.Size(152, 20)
        Me.txt_personal.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Filtro"
        '
        'btn_2
        '
        Me.btn_2.Location = New System.Drawing.Point(395, 258)
        Me.btn_2.Name = "btn_2"
        Me.btn_2.Size = New System.Drawing.Size(30, 23)
        Me.btn_2.TabIndex = 5
        Me.btn_2.Text = "<"
        Me.btn_2.UseVisualStyleBackColor = True
        '
        'btn_1
        '
        Me.btn_1.Location = New System.Drawing.Point(395, 225)
        Me.btn_1.Name = "btn_1"
        Me.btn_1.Size = New System.Drawing.Size(30, 23)
        Me.btn_1.TabIndex = 3
        Me.btn_1.Text = ">"
        Me.btn_1.UseVisualStyleBackColor = True
        '
        'frm_inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(860, 437)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_inventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignación de Recursos"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.gbo_recursos_a.ResumeLayout(False)
        Me.gbo_recursos_a.PerformLayout()
        CType(Me.dgv_listaimplementos2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_listaimplementos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dgv_personal2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_personal1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtp_inicio_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents gbo_recursos_a As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_listaimplementos2 As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_listaimplementos As System.Windows.Forms.DataGridView
    Friend WithEvents txt_listaImplementos As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_regresar As System.Windows.Forms.Button
    Friend WithEvents btn_mover As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_embarcaciones As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_piloto As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Detalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_personal2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_personal1 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_personal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_2 As System.Windows.Forms.Button
    Friend WithEvents btn_1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_escoger As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
End Class
