Imports System.Data.SqlClient

Public Class usuarios

    Private Sub usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_contraseña.Text = ""
        txt_usuario.Text = ""
        txt_participante.Text = ""
        txt_codigo.Text = ""
        llenar_perfiles()
        llenar_informacion()

    End Sub

    Sub llenar_informacion()
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try
            sql = ""
            sql = sql & "select usu_id,per_id,fk_empleados,usu_usuario as Usuario,usu_clave as Contraseña,cedula,nombre,apellido_paterno + ' '+apellido_materno as Apellidos,celular  from seg_Usuarios u"
            sql = sql & " inner join PARTICIPANTES p"
            sql = sql & " on u.fk_empleados = p.DNI_PARTICIPANTES "
            sql = sql & " where u.usu_estado = 'A' and p.ESTADO_P = 'A'"



            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            dgv_llenar.DataSource = dt
            dgv_llenar.RowHeadersVisible = False
            Me.dgv_llenar.Columns(0).Visible = False
            Me.dgv_llenar.Columns(1).Visible = False
            Me.dgv_llenar.Columns(2).Visible = False
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try

    End Sub



    Sub llenar_perfiles()
        Dim sql As String
        Dim dr As SqlDataReader
        Try
            sql = "SELECT *from seg_perfil where per_estado = 'A'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            Dim d1 As New DataTable
            d1.Load(dr)
            cbo_combo_perfiles.DataSource = d1
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        End Try
    End Sub


    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()

    End Sub

    Private Sub btn_escoger_Click(sender As Object, e As EventArgs) Handles btn_escoger.Click
        frm_lista_empleados_p.ShowDialog()

    End Sub

    Private Sub btn_añadir_Click(sender As Object, e As EventArgs) Handles btn_añadir.Click

        Dim sql As String
        If (txt_usuario.Text = "" Or txt_contraseña.Text = "" Or txt_codigo.Text = "") Then
            MessageBox.Show("Debe llenar las campos obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_usuario.BackColor = Color.Red

        Else
            Try
                sql = "INSERT INTO seg_usuarios(per_id,fk_empleados,usu_usuario,usu_clave,usu_estado) VALUES ("
                sql = sql & cbo_combo_perfiles.SelectedValue & ", "
                sql = sql & txt_codigo.Text & ", "
                sql = sql & "'" & txt_usuario.Text & "', "
                sql = sql & "'" & txt_contraseña.Text & "', "
                sql = sql & "'A" & "')"
                Dim com As New SqlCommand(sql, mycon)
                Dim x As Integer
                x = com.ExecuteNonQuery
                MessageBox.Show(" Categoria Almacenada", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_contraseña.Text = ""
                txt_usuario.Text = ""
                txt_participante.Text = ""
                txt_codigo.Text = ""
                llenar_informacion()
            Catch ex As Exception
                MessageBox.Show("No es Posible Registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
        End If
    End Sub

   

  
    Private Sub dgv_llenar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_llenar.CellContentClick
        seg_usuario = 0
        txt_contraseña.Text = ""
        txt_usuario.Text = ""
        txt_participante.Text = ""
        txt_codigo.Text = ""
    End Sub

    Public seg_usuario As Integer = 0
    Public seg_perfil As Integer
    Public seg_participante As Integer
    Private Sub dgv_llenar_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_llenar.CellDoubleClick
        Try
            If e.RowIndex > -1 Then
                seg_usuario = dgv_llenar.Rows(e.RowIndex).Cells(0).Value
                seg_perfil = dgv_llenar.Rows(e.RowIndex).Cells(1).Value
                seg_participante = dgv_llenar.Rows(e.RowIndex).Cells(2).Value
                txt_codigo.Text = seg_participante
                txt_usuario.Text = dgv_llenar.Rows(e.RowIndex).Cells(3).Value
                txt_contraseña.Text = dgv_llenar.Rows(e.RowIndex).Cells(4).Value
                cbo_combo_perfiles.SelectedValue = seg_perfil
                txt_participante.Text = dgv_llenar.Rows(e.RowIndex).Cells(6).Value & " " & dgv_llenar.Rows(e.RowIndex).Cells(7).Value
            End If
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub dgv_llenar_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_llenar.CellEndEdit

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim sql As String
        If seg_usuario = 0 Then
            MessageBox.Show("  Debe Seleccionar Primero", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                sql = "UPDATE seg_usuarios SET usu_estado ='I' WHERE usu_id= " & seg_usuario
                Dim com As New SqlCommand(sql, mycon)
                Dim x As Integer
                x = com.ExecuteNonQuery
                MessageBox.Show("  Eliminada", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)

                llenar_informacion()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
            End Try
        End If
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        Dim sql As String
        If seg_usuario = 0 Then
            MessageBox.Show("  Debe Seleccionar Primero", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                sql = "UPDATE seg_usuarios SET per_id =" & seg_perfil & ", fk_empleados=" & txt_codigo.Text & ",usu_usuario = '" & txt_usuario.Text & "',usu_clave = '" & txt_contraseña.Text & "' WHERE usu_id= " & seg_usuario
                Dim com As New SqlCommand(sql, mycon)
                Dim x As Integer
                x = com.ExecuteNonQuery
                MessageBox.Show("  Actualizada", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information)

                llenar_informacion()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
            End Try
        End If
        
    End Sub
End Class