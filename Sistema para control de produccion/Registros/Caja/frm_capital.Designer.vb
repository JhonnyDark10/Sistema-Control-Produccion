<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_capital
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_capital))
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_cambio = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_efectivo = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_total_pagar = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_capital = New System.Windows.Forms.Button()
        Me.txt_montocapital = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbo_embarcaciones = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_pesca = New System.Windows.Forms.Button()
        Me.txt_montoembarcaciones = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbo_recursos = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_detallrecursos = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_egreso = New System.Windows.Forms.Button()
        Me.text_montorecursos = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtp_fechas = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox6.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox6.Controls.Add(Me.PictureBox2)
        Me.GroupBox6.Controls.Add(Me.PictureBox1)
        Me.GroupBox6.Controls.Add(Me.txt_cambio)
        Me.GroupBox6.Controls.Add(Me.Label21)
        Me.GroupBox6.Controls.Add(Me.txt_efectivo)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Controls.Add(Me.txt_total_pagar)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Location = New System.Drawing.Point(-2, 0)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(851, 67)
        Me.GroupBox6.TabIndex = 26
        Me.GroupBox6.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Sistema_para_control_de_produccion.My.Resources.Resources.US_dollar_icon
        Me.PictureBox2.Location = New System.Drawing.Point(424, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox2.TabIndex = 37
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sistema_para_control_de_produccion.My.Resources.Resources.US_dollar_icon
        Me.PictureBox1.Location = New System.Drawing.Point(98, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'txt_cambio
        '
        Me.txt_cambio.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.txt_cambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cambio.Location = New System.Drawing.Point(699, 14)
        Me.txt_cambio.Name = "txt_cambio"
        Me.txt_cambio.ReadOnly = True
        Me.txt_cambio.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_cambio.Size = New System.Drawing.Size(142, 47)
        Me.txt_cambio.TabIndex = 25
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(633, 38)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(69, 13)
        Me.Label21.TabIndex = 24
        Me.Label21.Text = "CAMBIO $:"
        '
        'txt_efectivo
        '
        Me.txt_efectivo.BackColor = System.Drawing.Color.Honeydew
        Me.txt_efectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_efectivo.Location = New System.Drawing.Point(467, 14)
        Me.txt_efectivo.Name = "txt_efectivo"
        Me.txt_efectivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_efectivo.Size = New System.Drawing.Size(162, 47)
        Me.txt_efectivo.TabIndex = 23
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(334, 38)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(82, 13)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "EFECTIVO $:"
        '
        'txt_total_pagar
        '
        Me.txt_total_pagar.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.txt_total_pagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_pagar.Location = New System.Drawing.Point(141, 14)
        Me.txt_total_pagar.Name = "txt_total_pagar"
        Me.txt_total_pagar.ReadOnly = True
        Me.txt_total_pagar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_total_pagar.Size = New System.Drawing.Size(181, 47)
        Me.txt_total_pagar.TabIndex = 6
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(6, 36)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(85, 13)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "TOTAL CAJA:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btn_capital)
        Me.GroupBox1.Controls.Add(Me.txt_montocapital)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(244, 101)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso Capital"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(62, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "&$"
        '
        'btn_capital
        '
        Me.btn_capital.BackColor = System.Drawing.Color.Blue
        Me.btn_capital.BackgroundImage = Global.Sistema_para_control_de_produccion.My.Resources.Resources.Add_icon
        Me.btn_capital.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_capital.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_capital.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_capital.ForeColor = System.Drawing.Color.White
        Me.btn_capital.Location = New System.Drawing.Point(179, 34)
        Me.btn_capital.Name = "btn_capital"
        Me.btn_capital.Size = New System.Drawing.Size(42, 39)
        Me.btn_capital.TabIndex = 80
        Me.btn_capital.UseVisualStyleBackColor = False
        '
        'txt_montocapital
        '
        Me.txt_montocapital.Location = New System.Drawing.Point(81, 43)
        Me.txt_montocapital.Name = "txt_montocapital"
        Me.txt_montocapital.Size = New System.Drawing.Size(77, 20)
        Me.txt_montocapital.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Monto:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbo_embarcaciones)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btn_pesca)
        Me.GroupBox2.Controls.Add(Me.txt_montoembarcaciones)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(287, 92)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(244, 340)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ingreso Pesca"
        '
        'cbo_embarcaciones
        '
        Me.cbo_embarcaciones.DisplayMember = "emb_nombre"
        Me.cbo_embarcaciones.FormattingEnabled = True
        Me.cbo_embarcaciones.Location = New System.Drawing.Point(67, 103)
        Me.cbo_embarcaciones.Name = "cbo_embarcaciones"
        Me.cbo_embarcaciones.Size = New System.Drawing.Size(153, 21)
        Me.cbo_embarcaciones.TabIndex = 84
        Me.cbo_embarcaciones.ValueMember = "emb_id"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "Embarcacion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "&$"
        '
        'btn_pesca
        '
        Me.btn_pesca.BackColor = System.Drawing.Color.Blue
        Me.btn_pesca.BackgroundImage = Global.Sistema_para_control_de_produccion.My.Resources.Resources.Add_icon
        Me.btn_pesca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_pesca.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_pesca.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pesca.ForeColor = System.Drawing.Color.White
        Me.btn_pesca.Location = New System.Drawing.Point(178, 151)
        Me.btn_pesca.Name = "btn_pesca"
        Me.btn_pesca.Size = New System.Drawing.Size(42, 39)
        Me.btn_pesca.TabIndex = 80
        Me.btn_pesca.UseVisualStyleBackColor = False
        '
        'txt_montoembarcaciones
        '
        Me.txt_montoembarcaciones.Location = New System.Drawing.Point(87, 170)
        Me.txt_montoembarcaciones.Name = "txt_montoembarcaciones"
        Me.txt_montoembarcaciones.Size = New System.Drawing.Size(77, 20)
        Me.txt_montoembarcaciones.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Monto:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbo_recursos)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txt_detallrecursos)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.btn_egreso)
        Me.GroupBox3.Controls.Add(Me.text_montorecursos)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(567, 92)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(244, 340)
        Me.GroupBox3.TabIndex = 82
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Egreso"
        '
        'cbo_recursos
        '
        Me.cbo_recursos.DisplayMember = "emb_nombre"
        Me.cbo_recursos.FormattingEnabled = True
        Me.cbo_recursos.Items.AddRange(New Object() {"Implementos", "Empleados", "Embarcaciones", "Otros"})
        Me.cbo_recursos.Location = New System.Drawing.Point(68, 60)
        Me.cbo_recursos.Name = "cbo_recursos"
        Me.cbo_recursos.Size = New System.Drawing.Size(153, 21)
        Me.cbo_recursos.TabIndex = 86
        Me.cbo_recursos.ValueMember = "emb_id"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 85
        Me.Label9.Text = "Recursos:"
        '
        'txt_detallrecursos
        '
        Me.txt_detallrecursos.Location = New System.Drawing.Point(68, 115)
        Me.txt_detallrecursos.Multiline = True
        Me.txt_detallrecursos.Name = "txt_detallrecursos"
        Me.txt_detallrecursos.Size = New System.Drawing.Size(153, 75)
        Me.txt_detallrecursos.TabIndex = 83
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "Detalle:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "&$"
        '
        'btn_egreso
        '
        Me.btn_egreso.BackColor = System.Drawing.Color.Blue
        Me.btn_egreso.BackgroundImage = Global.Sistema_para_control_de_produccion.My.Resources.Resources.Add_icon
        Me.btn_egreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_egreso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_egreso.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_egreso.ForeColor = System.Drawing.Color.White
        Me.btn_egreso.Location = New System.Drawing.Point(179, 222)
        Me.btn_egreso.Name = "btn_egreso"
        Me.btn_egreso.Size = New System.Drawing.Size(42, 39)
        Me.btn_egreso.TabIndex = 80
        Me.btn_egreso.UseVisualStyleBackColor = False
        '
        'text_montorecursos
        '
        Me.text_montorecursos.Location = New System.Drawing.Point(81, 233)
        Me.text_montorecursos.Name = "text_montorecursos"
        Me.text_montorecursos.Size = New System.Drawing.Size(77, 20)
        Me.text_montorecursos.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Monto:"
        '
        'dtp_fechas
        '
        Me.dtp_fechas.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechas.Location = New System.Drawing.Point(688, 73)
        Me.dtp_fechas.Name = "dtp_fechas"
        Me.dtp_fechas.Size = New System.Drawing.Size(123, 20)
        Me.dtp_fechas.TabIndex = 83
        '
        'frm_capital
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(848, 444)
        Me.Controls.Add(Me.dtp_fechas)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_capital"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Capital"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_cambio As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txt_efectivo As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_total_pagar As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_montocapital As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_capital As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_pesca As System.Windows.Forms.Button
    Friend WithEvents txt_montoembarcaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_egreso As System.Windows.Forms.Button
    Friend WithEvents text_montorecursos As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbo_embarcaciones As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_recursos As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_detallrecursos As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtp_fechas As System.Windows.Forms.DateTimePicker
End Class
