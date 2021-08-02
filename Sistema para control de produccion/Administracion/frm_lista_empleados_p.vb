Imports System.Data.SqlClient

Public Class frm_lista_empleados_p

    Private Sub frm_lista_empleados_p_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_data_grip()
    End Sub


    Private Sub llenar_data_grip()
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try
            sql = ""
            sql = sql & "select p.DNI_PARTICIPANTES,p.FK_ID_DEPARTAMENTO,p.FK_ID_ESTADO_CIVIL,CEDULA ,"
            sql = sql & "p.NOMBRE, p.APELLIDO_PATERNO as APELLIDO ,d.NOMBRE AS DEPARTAMENTO,cs.DESCRIPCION as COMISION,"
            sql = sql & "c.DESCRIPCION AS 'ESTADO CIVIL',p.CELULAR,p.EMAIL"
            sql = sql & " From PARTICIPANTES p"
            sql = sql & " INNER JOIN ESTADO_CIVIL c"
            sql = sql & " ON p.FK_ID_ESTADO_CIVIL = c.ID_ESTADO_CIVIL"
            sql = sql & " INNER JOIN DEPARTAMENTO d"
            sql = sql & " ON p.FK_ID_DEPARTAMENTO = d.DNI_DEPARTAMENTO "
            sql = sql & " INNER JOIN COMISIONES_PARTICIPANTES cp"
            sql = sql & " ON p.DNI_PARTICIPANTES = cp.fk_participantes "
            sql = sql & " INNER JOIN COMISIONES cs"
            sql = sql & " ON cp.fk_comisiones = cs.ID_COMISIONES "
            sql = sql & " WHERE P.ESTADO_P = 'A' "

            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            dgv_cliente.DataSource = dt
            dgv_cliente.RowHeadersVisible = False
            Me.dgv_cliente.Columns(0).Visible = False
            Me.dgv_cliente.Columns(1).Visible = False
            Me.dgv_cliente.Columns(2).Visible = False


        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub

    Dim int_id_perfil As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub txt_lista_TextChanged(sender As Object, e As EventArgs) Handles txt_lista.TextChanged
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try

            sql = ""
            sql = sql & "select p.DNI_PARTICIPANTES,p.FK_ID_DEPARTAMENTO,p.FK_ID_ESTADO_CIVIL,p.CEDULA ,"
            sql = sql & "p.NOMBRE, p.APELLIDO_PATERNO as APELLIDO ,d.NOMBRE AS DEPARTAMENTO,cs.DESCRIPCION as COMISION,"
            sql = sql & "c.DESCRIPCION AS 'ESTADO CIVIL',p.CELULAR,p.EMAIL"
            sql = sql & " From PARTICIPANTES p"
            sql = sql & " INNER JOIN ESTADO_CIVIL c"
            sql = sql & " ON p.FK_ID_ESTADO_CIVIL = c.ID_ESTADO_CIVIL"
            sql = sql & " INNER JOIN DEPARTAMENTO d"
            sql = sql & " ON p.FK_ID_DEPARTAMENTO = d.DNI_DEPARTAMENTO "
            sql = sql & " INNER JOIN COMISIONES_PARTICIPANTES cp"
            sql = sql & " ON p.DNI_PARTICIPANTES = cp.fk_participantes "
            sql = sql & " INNER JOIN COMISIONES cs"
            sql = sql & " ON cp.fk_comisiones = cs.ID_COMISIONES "
            sql = sql & " WHERE P.ESTADO_P = 'A' and (p.cedula like '" & txt_lista.Text & "%' or p.apellido_paterno + p.apellido_materno like'" & txt_lista.Text & "%')"
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

    Private Sub dgv_cliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cliente.CellContentClick

    End Sub

    Private Sub dgv_cliente_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cliente.CellDoubleClick
        Try
            If e.RowIndex > -1 Then
                int_id_perfil = dgv_cliente.Rows(e.RowIndex).Cells(0).Value
                usuarios.txt_codigo.Text = int_id_perfil
                usuarios.txt_participante.Text = dgv_cliente.Rows(e.RowIndex).Cells(4).Value & " " & dgv_cliente.Rows(e.RowIndex).Cells(5).Value
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class