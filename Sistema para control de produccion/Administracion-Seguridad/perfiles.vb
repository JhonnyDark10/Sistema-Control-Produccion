Imports System.Data.SqlClient

Public Class perfiles

    Private Sub frm_categoria_evento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox5.Enabled = False
        txt_ingresa_datos.Text = ""
        txt_perdes.Text = ""
        RadioButton1.Checked = False

        llenar_data_grip()
    End Sub


    Private Sub llenar_data_grip()
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try
            sql = "select per_id as Codigo, per_nombre As Registros, per_descripcion as Descripción from seg_perfil where per_estado = 'A'"
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
 
    Private Sub dgv_cat_evento_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_cat_evento.CellMouseClick
        Try
            If e.RowIndex > -1 Then
                int_id_perfil = dgv_cat_evento.Rows(e.RowIndex).Cells(0).Value
                txt_ingresa_datos.Text = dgv_cat_evento.Rows(e.RowIndex).Cells(1).Value
                txt_perdes.Text = dgv_cat_evento.Rows(e.RowIndex).Cells(2).Value
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            GroupBox5.Enabled = True
        Else
            GroupBox5.Enabled = False
        End If
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()

    End Sub

    
    Private Sub btn_eliminar_Click_1(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim sql As String
        Try
            sql = "UPDATE seg_perfil SET per_estado ='I' WHERE per_id= " & int_id_perfil
            Dim com As New SqlCommand(sql, mycon)
            Dim x As Integer
            x = com.ExecuteNonQuery
            MessageBox.Show(" Categoria Eliminada", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txt_ingresa_datos.Text = ""
            txt_perdes.Text = ""
            llenar_data_grip()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub

    Private Sub btn_añadir_Click(sender As Object, e As EventArgs) Handles btn_añadir.Click
        Dim sql As String
        If (txt_ingresa_datos.Text = "") Then
            MessageBox.Show("Debe llenar las campos obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_ingresa_datos.BackColor = Color.Red

        Else
            Try
                sql = "INSERT INTO seg_perfil(per_nombre,per_descripcion,per_estado) VALUES ("
                sql = sql & "'" & txt_ingresa_datos.Text & "', "
                sql = sql & "'" & txt_perdes.Text & "', "
                sql = sql & "'A" & "')"
                Dim com As New SqlCommand(sql, mycon)
                Dim x As Integer
                x = com.ExecuteNonQuery
                MessageBox.Show(" Categoria Almacenada", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_ingresa_datos.Text = ""
                txt_perdes.Text = ""
                txt_ingresa_datos.BackColor = Color.White
                llenar_data_grip()
            Catch ex As Exception
                MessageBox.Show("No es Posible Registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
        End If
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        Dim sql As String
        Try
            sql = "UPDATE seg_perfil SET per_nombre ='" & txt_ingresa_datos.Text & "', per_descripcion ='" & txt_perdes.Text & "' WHERE per_id= " & int_id_perfil
            Dim com As New SqlCommand(sql, mycon)
            Dim x As Integer
            x = com.ExecuteNonQuery
            MessageBox.Show(" Categoria Actualizada", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_ingresa_datos.Text = ""
            txt_perdes.Text = ""
            llenar_data_grip()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub
End Class