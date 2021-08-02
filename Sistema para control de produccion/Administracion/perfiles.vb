Imports System.Data.SqlClient

Public Class perfiles


    Private WithEvents ListBox1 As New ListBox()
    Private Sub btn_añadir_Click(sender As Object, e As EventArgs) Handles btn_añadir.Click

        Dim sql As String
        If (txt_ingresa_datos.Text = "") Then
            MessageBox.Show("Debe llenar las campos obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_ingresa_datos.BackColor = Color.Red

        Else
            Try
                sql = "INSERT INTO seg_perfil(per_nombre,per_estado) VALUES ("
                sql = sql & "'" & Trim(txt_ingresa_datos.Text) & "', "
                sql = sql & "'A" & "')"
                Dim com As New SqlCommand(sql, mycon)
                Dim x As Integer
                x = com.ExecuteNonQuery
                MessageBox.Show(" Categoria Almacenada", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_ingresa_datos.Text = ""
                txt_ingresa_datos.BackColor = Color.White
                llenar_data_grip()
            Catch ex As Exception
                MessageBox.Show("No es Posible Registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyDialog As New ColorDialog()
        ' Keeps the user from selecting a custom color.
        MyDialog.AllowFullOpen = False
        ' Allows the user to get help. (The default is false.)
        MyDialog.ShowHelp = True
        ' Sets the initial color select to the current text color,
        MyDialog.Color = Button1.BackColor

        ' Update the text box color if the user clicks OK 
        If (MyDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Button1.BackColor = MyDialog.Color
            'dgv_categoria.BackgroundColor = MyDialog.Color
            ' lb_lista.ForeColor = MyDialog.Color

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim MyDialog As New ColorDialog()
        ' Keeps the user from selecting a custom color.
        MyDialog.AllowFullOpen = False
        ' Allows the user to get help. (The default is false.)
        MyDialog.ShowHelp = True
        ' Sets the initial color select to the current text color,
        MyDialog.Color = Button2.BackColor

        ' Update the text box color if the user clicks OK 
        If (MyDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Button2.BackColor = MyDialog.Color
        End If

    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()

    End Sub

    Private Sub lb_lista_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim sql As String
        Try
            sql = "UPDATE seg_perfil SET per_estado ='I' WHERE per_id= " & int_id_perfil
            Dim com As New SqlCommand(sql, mycon)
            Dim x As Integer
            x = com.ExecuteNonQuery
            MessageBox.Show(" Categoria Eliminada", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txt_ingresa_datos.Text = ""
            llenar_data_grip()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub



    Private Sub frm_categoria_evento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox4.Enabled = False

        llenar_data_grip()
    End Sub


    Private Sub llenar_data_grip()
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try
            sql = "select per_id as Codigo, per_nombre As Registros from seg_perfil where per_estado = 'A'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            dgv_cat_evento.DataSource = dt

            dgv_cat_evento.RowHeadersVisible = False
            Me.dgv_cat_evento.Columns(0).Visible = False
            Dim row3 As DataGridViewColumn = dgv_cat_evento.Columns(1)
            row3.Width = 205

        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub

    Dim int_id_perfil As Integer
    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        Dim sql As String
        Try
            sql = "UPDATE seg_perfil SET per_nombre ='" & txt_ingresa_datos.Text & "' WHERE per_id= " & int_id_perfil
            Dim com As New SqlCommand(sql, mycon)
            Dim x As Integer
            x = com.ExecuteNonQuery
            MessageBox.Show(" Categoria Actualizada", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_ingresa_datos.Text = ""
            llenar_data_grip()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub

    Private Sub dgv_cat_evento_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_cat_evento.CellMouseClick
        Try
            If e.RowIndex > -1 Then
                int_id_perfil = dgv_cat_evento.Rows(e.RowIndex).Cells(0).Value
                txt_ingresa_datos.Text = dgv_cat_evento.Rows(e.RowIndex).Cells(1).Value
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub dgv_cat_evento_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cat_evento.CellContentClick

    End Sub

    Private Sub txt_ingresa_datos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ingresa_datos.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_ingresa_datos_TextChanged(sender As Object, e As EventArgs) Handles txt_ingresa_datos.TextChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            GroupBox4.Enabled = True
        Else
            GroupBox4.Enabled = False
        End If
    End Sub
End Class