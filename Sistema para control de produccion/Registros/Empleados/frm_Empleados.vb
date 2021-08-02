Imports System.Data.SqlClient

Public Class frm_Empleados

    Private Sub frm_Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_data_grip()
    End Sub


    Private Sub llenar_data_grip()
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try
            sql = ""
            sql = sql & "select p.emp_id,p.emp_fk_estado_civil,p.emp_cedula as Cedula,p.emp_nombre as Nombre,"
            sql = sql & "p.emp_apellidoPaterno +' '+ p.emp_apellidoMaterno as Apelllidos,t.tip_descripción as Tipo,c.est_civil_descripcion as Estado,p.emp_direccion as Dirección,emp_descripcionCarnets as Descripción,p.emp_celular as Celular,"
            sql = sql & "p.emp_email as Correo"
            sql = sql & " From Sis_Empleados p"
            sql = sql & " INNER JOIN Sis_EstadoCivil c"
            sql = sql & " ON p.emp_fk_estado_civil = c.est_civil_id"
            sql = sql & " INNER JOIN Sis_TipoEmpleado t"
            sql = sql & " ON p.emp_fk_tipo = t.tip_id"
            sql = sql & " WHERE P.emp_estado = 'A' "

            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            dgv_cliente.DataSource = dt
            dgv_cliente.RowHeadersVisible = False
            Me.dgv_cliente.Columns(0).Visible = False
            Me.dgv_cliente.Columns(1).Visible = False

        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()

    End Sub

    Private Sub txt_lista_TextChanged(sender As Object, e As EventArgs) Handles txt_lista.TextChanged
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try

            sql = ""
            sql = sql & "select p.emp_id,p.emp_fk_estado_civil,p.emp_cedula as Cedula,p.emp_nombre as Nombre,"
            sql = sql & "p.emp_apellidoPaterno +' '+ p.emp_apellidoMaterno as Apelllidos,t.tip_descripción as Tipo,c.est_civil_descripcion as Estado,p.emp_direccion as Dirección,emp_descripcionCarnets as Descripción,p.emp_celular as Celular,"
            sql = sql & "p.emp_email as Correo"
            sql = sql & " From Sis_Empleados p"
            sql = sql & " INNER JOIN Sis_EstadoCivil c"
            sql = sql & " ON p.emp_fk_estado_civil = c.est_civil_id"
            sql = sql & " INNER JOIN Sis_TipoEmpleado t"
            sql = sql & " ON p.emp_fk_tipo = t.tip_id"
            sql = sql & " WHERE P.emp_estado = 'A' and (p.emp_cedula like '" & txt_lista.Text & "%' or p.emp_apellidoPaterno +' '+ p.emp_apellidoMaterno like'" & txt_lista.Text & "%')"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            dgv_cliente.DataSource = dt
            dgv_cliente.RowHeadersVisible = False
            Me.dgv_cliente.Columns(0).Visible = False
            Me.dgv_cliente.Columns(1).Visible = False
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub
    Dim int_id_perfil As Integer
    Private Sub dgv_cliente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cliente.CellClick
        Try
            If e.RowIndex > -1 Then
                int_id_perfil = dgv_cliente.Rows(e.RowIndex).Cells(0).Value

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    
    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim sql As String
        Try
            If int_id_perfil <> 0 Then
                sql = "UPDATE Sis_empleados SET emp_estado ='I' WHERE emp_id= " & int_id_perfil
                Dim com As New SqlCommand(sql, mycon)
                Dim x As Integer
                x = com.ExecuteNonQuery
                MessageBox.Show("  Eliminada", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                llenar_data_grip()
                elimina_cuentas_usuario()
                int_id_perfil = 0
            Else
                MessageBox.Show("  Seleccione Primero", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub

    Sub elimina_cuentas_usuario()
        Dim sql As String

        Try
            sql = "UPDATE seg_Usuarios  SET usu_estado ='I' WHERE usu_fk_empleados = " & int_id_perfil & " and usu_estado = 'A'"

            Dim com As New SqlCommand(sql, mycon)
            Dim x As Integer
            x = com.ExecuteNonQuery

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_añadirEmpleado.showdialog()
        llenar_data_grip()

    End Sub


    Private Sub dgv_cliente_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cliente.CellDoubleClick
        Try
            If e.RowIndex > -1 Then
                int_id_empleado = dgv_cliente.Rows(e.RowIndex).Cells(0).Value
                txt_cli_asig.Text = int_id_empleado
                frm_modificarEmpleado.ShowDialog()
                llenar_data_grip()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class