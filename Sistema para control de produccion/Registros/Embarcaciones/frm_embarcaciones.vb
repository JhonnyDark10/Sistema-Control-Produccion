Imports System.Data.SqlClient

Public Class frm_embarcaciones

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()

    End Sub

    Private Sub frm_embarcaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_data_grip()

    End Sub

    Private Sub llenar_data_grip()
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try
            sql = ""
            sql = sql & "select p.emb_id,p.emb_fk_tipoEmbarcacion,c.tipemb_nombre as Tipo,p.emb_numMatricula as 'N° Matricula',p.emb_nombre as Nombre,"
            sql = sql & "p.emb_descripcion as Descripcion,p.emb_estadoO as Estado,p.emb_fechaAdquisicion as 'Fecha Compra',"
            sql = sql & "p.emb_precio as Valor"
            sql = sql & " From Sis_Embarcaciones p"
            sql = sql & " INNER JOIN Sis_TipoEmbarcaciones c"
            sql = sql & " ON p.emb_fk_tipoEmbarcacion = c.tipemb_id "
            sql = sql & " WHERE p.emb_estado = 'A' "

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


    Private Sub txt_lista_TextChanged(sender As Object, e As EventArgs) Handles txt_lista.TextChanged
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try

             sql = ""
            sql = sql & "select p.emb_id,p.emb_fk_tipoEmbarcacion,c.tipemb_nombre as Tipo,p.emb_numMatricula as 'N° Matricula',p.emb_nombre as Nombre,"
            sql = sql & "p.emb_descripcion as Descripcion,p.emb_estadoO as Estado,p.emb_fechaAdquisicion as 'Fecha Compra',"
            sql = sql & "p.emb_precio as Valor"
            sql = sql & " From Sis_Embarcaciones p"
            sql = sql & " INNER JOIN Sis_TipoEmbarcaciones c"
            sql = sql & " ON p.emb_fk_tipoEmbarcacion = c.tipemb_id "
            sql = sql & " WHERE P.emb_estado = 'A' and (p.emb_numMatricula like '" & txt_lista.Text & "%' or p.emb_nombre like'" & txt_lista.Text & "%')"
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
                sql = "UPDATE Sis_embarcaciones SET emb_estado ='I' WHERE emb_id= " & int_id_perfil
                Dim com As New SqlCommand(sql, mycon)
                Dim x As Integer
                x = com.ExecuteNonQuery
                MessageBox.Show("  Eliminada", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                llenar_data_grip()
                int_id_perfil = 0
            Else
                MessageBox.Show("  Seleccione Primero", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_añadirEmbarcacion.ShowDialog()
        llenar_data_grip()
    End Sub

    
    Private Sub dgv_cliente_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cliente.CellDoubleClick
        Try
            If e.RowIndex > -1 Then
                int_id_embarcaciones = dgv_cliente.Rows(e.RowIndex).Cells(0).Value
                txt_cli_asig.Text = int_id_embarcaciones
                frm_modificarEmbarcaciones.ShowDialog()
                llenar_data_grip()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class