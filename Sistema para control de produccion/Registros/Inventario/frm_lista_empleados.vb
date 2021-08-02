Imports System.Data.SqlClient

Public Class frm_lista_empleados


    Private Sub frm_lista_empleados_usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_data_grip()
    End Sub


    Private Sub llenar_data_grip()
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try
            sql = ""
            sql = sql & "select emp_id,emp_cedula as Cedula,emp_nombre as Nombre,emp_apellidopaterno + ' ' + emp_apellidomaterno as Apellidos,"
            sql = sql & "emp_celular as Celular,emp_direccion as Dirección, emp_email as Email"
            sql = sql & " From Sis_Empleados e"
            sql = sql & " WHERE e.emp_estado = 'A' "

            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            dgv_cliente.DataSource = dt
            dgv_cliente.RowHeadersVisible = False
            Me.dgv_cliente.Columns(0).Visible = False

        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub

    Dim int_id_perfil As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub txt_lista_TextChanged(sender As Object, e As EventArgs) Handles txt_lista.TextChanged
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try

            sql = ""
            sql = sql & "select emp_id,emp_cedula as Cedula,emp_nombre as Nombre,emp_apellidopaterno + ' ' + emp_apellidomaterno as Apellidos,"
            sql = sql & "emp_celular as Celular,emp_direccion as Dirección, emp_email as Email"
            sql = sql & " From Sis_Empleados e"
            sql = sql & " WHERE e.emp_estado = 'A' and (e.emp_cedula like '" & txt_lista.Text & "%' or e.emp_apellidopaterno +' '+ e.emp_apellidomaterno like'" & txt_lista.Text & "%')"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            dgv_cliente.DataSource = dt
            dgv_cliente.RowHeadersVisible = False
            Me.dgv_cliente.Columns(0).Visible = False

        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try

    End Sub

    Private Sub dgv_cliente_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cliente.CellDoubleClick
        Try
            If e.RowIndex > -1 Then
                int_id_perfil = dgv_cliente.Rows(e.RowIndex).Cells(0).Value
                frm_inventario.txt_codigo.Text = int_id_perfil
                frm_inventario.txt_piloto.Text = dgv_cliente.Rows(e.RowIndex).Cells(2).Value & " " & dgv_cliente.Rows(e.RowIndex).Cells(3).Value

                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
End Class