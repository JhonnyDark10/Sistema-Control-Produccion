Imports System.Data.SqlClient

Public Class frm_modificaimplemento

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()

    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim sql As String
        Try
            sql = ""
            sql = "UPDATE Sis_Implementos SET imp_fk_tipo =" & cbo_tipo.SelectedValue & ","
            sql = sql & " imp_nombre = '" & txt_nombre.Text & "',"
            sql = sql & "imp_estadoO ='" & cbo_estado.Text & "', imp_fechaAdquisicion ='" & dtp_fechas.Text & "',"
            sql = sql & "imp_precio = " & Trim(Str(CDbl(txt_valor.Text))) & ",imp_cantidad= " & nd_cantidad.Text & ", imp_estado = 'A' ,"
            sql = sql & "imp_total = " & (Trim(Str(CDbl(txt_valor.Text))) * Val(nd_cantidad.Text)) & ""
            sql = sql & " WHERE imp_id = " & int_id_implementos

            Dim com As New SqlCommand(sql, mycon)
            Dim x As Integer
            x = com.ExecuteNonQuery
            MessageBox.Show(" Datos Actualizados", "Modifica", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub

    Private Sub frm_modificaimplemento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        recupera_tipo()
        recupera_datos(int_id_implementos)
    End Sub

    Sub recupera_datos(datos As Integer)
        Dim sql As String
        Dim dr As SqlDataReader
        Try
            sql = ""
            sql = sql & "select p.imp_id,p.imp_fk_tipo,c.tipimpl_nombre,p.imp_nombre,"
            sql = sql & "p.imp_estadoO,p.imp_fechaAdquisicion,"
            sql = sql & "p.imp_precio, p.imp_cantidad, p.imp_total"
            sql = sql & " From Sis_Implementos p"
            sql = sql & " INNER JOIN Sis_TipoImplementos c"
            sql = sql & " ON p.imp_fk_tipo = c.tipimpl_id "
            sql = sql & " WHERE p.imp_estado = 'A' and p.imp_id = " & datos

            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    cbo_tipo.SelectedValue = dr("imp_fk_tipo")
                    cbo_estado.Text = dr("imp_estadoO")
                    txt_nombre.Text = dr("imp_nombre")
                    txt_valor.Text = dr("imp_precio")
                    dtp_fechas.Text = dr("imp_fechaAdquisicion")
                    nd_cantidad.Text = dr("imp_cantidad")
                End While
            Else
                MsgBox("Implementos no se encuentra ....Registre")
            End If
            dr.Close()

        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub

    Sub recupera_tipo()
        Dim sql As String
        Dim dr As SqlDataReader
        Try
            sql = "SELECT *from Sis_TipoImplementos where tipimp_estado = 'A'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            Dim d1 As New DataTable
            d1.Load(dr)
            cbo_tipo.DataSource = d1
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        End Try
    End Sub
End Class