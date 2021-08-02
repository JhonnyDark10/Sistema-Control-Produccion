Public Class frm_Principal

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click

        If EstaAbierto(frm_Empleados) Then
            Exit Sub
        Else
            Dim frm As New frm_Empleados
            frm.MdiParent = Me
            frm.Show()
        End If

    End Sub

    Private Sub frm_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tss_usuario.Text = "Usuario: " & g_str_nombre_usuario
        tss_fecha.Text = "Fecha: " & Format(Now, "dd/MM/yyyy")
        If ind_menu_desactiva = 1 Then

            Me.DatosToolStripMenuItem.Visible = False
            Me.AdministraciónToolStripMenuItem.Visible = False

        End If

        dgv_fechas.Rows.Add("08:00 - 09:00")
        dgv_fechas.Rows.Add("09:00 - 10:00")
        dgv_fechas.Rows.Add("10:00 - 11:00")
        dgv_fechas.Rows.Add("11:00 - 12:00")
        dgv_fechas.Rows.Add("12:00 - 13:00")
        dgv_fechas.Rows.Add("13:00 - 14:00")
        dgv_fechas.Rows.Add("14:00 - 15:00")
        dgv_fechas.Rows.Add("15:00 - 16:00")
        dgv_fechas.Rows.Add("16:00 - 17:00")

        Dim row As DataGridViewRow = dgv_fechas.Rows(0)
        row.Height = 60
        Dim row1 As DataGridViewRow = dgv_fechas.Rows(1)
        row1.Height = 60
        Dim row2 As DataGridViewRow = dgv_fechas.Rows(2)
        row2.Height = 60
        Dim row3 As DataGridViewRow = dgv_fechas.Rows(3)
        row3.Height = 60
        Dim row4 As DataGridViewRow = dgv_fechas.Rows(4)
        row4.Height = 60
        Dim row5 As DataGridViewRow = dgv_fechas.Rows(5)
        row5.Height = 60
        Dim row6 As DataGridViewRow = dgv_fechas.Rows(6)
        row6.Height = 60
        Dim row7 As DataGridViewRow = dgv_fechas.Rows(7)
        row7.Height = 60
        Dim row8 As DataGridViewRow = dgv_fechas.Rows(8)
        row8.Height = 60
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        'If EstaAbierto(usuarios) Then
        '    Exit Sub
        'Else
        '    Dim frm As New usuarios
        '    frm.MdiParent = Me
        '    frm.Show()
        'End If
        usuarios.ShowDialog()

    End Sub

    Private Sub PerfilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerfilesToolStripMenuItem.Click

        'If EstaAbierto(perfiles) Then

        '    Exit Sub
        'Else
        '    Dim frm As New perfiles
        '    frm.MdiParent = Me
        '    frm.Show()
        'End If

        perfiles.ShowDialog()


    End Sub



    Public Function EstaAbierto(ByVal Myform As Form) As Boolean
        Try
            EstaAbierto = False
            For Each objForm In Application.OpenForms

                If (Trim(objForm.Name) = Trim(Myform.Name)) Then
                    EstaAbierto = True
                End If
            Next
            Return EstaAbierto
        Catch ex As Exception
            EstaAbierto = False
        End Try
    End Function

 

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frm_Empleados.ShowDialog()

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        frm_embarcaciones.ShowDialog()

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Implementos.ShowDialog()
    End Sub

   
    Private Sub CerrarSeciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSeciónToolStripMenuItem.Click
        Me.Close()
        frm_acceso.Show()

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click

        frm_inventario.ShowDialog()

    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs)
        frm_asignarrecursos.ShowDialog()
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        frm_caja.ShowDialog()
    End Sub

    Private Sub ToolStripButton5_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        frm_capital.ShowDialog()

    End Sub

    Private Sub EmbarcacionesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmbarcacionesToolStripMenuItem1.Click
        frm_reporte_embarcaciones.ShowDialog()

    End Sub

    Private Sub EmpleadosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem1.Click
        Reporte_Empleados.ShowDialog()

    End Sub
End Class
