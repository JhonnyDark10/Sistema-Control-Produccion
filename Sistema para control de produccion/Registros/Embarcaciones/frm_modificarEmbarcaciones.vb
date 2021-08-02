Imports System.Data.SqlClient

Public Class frm_modificarEmbarcaciones

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()

    End Sub

    Private Sub frm_modificarEmbarcaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        recupera_tipo()
        recupera_datos(int_id_embarcaciones)

    End Sub
    Sub limpiar()
        txt_matricula.Text = ""
        txt_nombre.Text = ""
        txt_descrip.Text = ""
        txt_valor.Text = ""

    End Sub
    Sub recupera_datos(datos As Integer)
        Dim sql As String
        Dim dr As SqlDataReader
        Try
            sql = ""
            sql = sql & "select p.emb_id,p.emb_fk_tipoEmbarcacion,p.emb_numMatricula,p.emb_nombre,"
            sql = sql & "p.emb_descripcion,p.emb_estadoO,p.emb_fechaAdquisicion,"
            sql = sql & "p.emb_precio"
            sql = sql & " From Sis_Embarcaciones p"
            sql = sql & " WHERE p.emb_estado = 'A' and p.emb_id = " & datos

            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    cbo_tipo.SelectedValue = dr("emb_fk_tipoEmbarcacion")
                    cbo_estado.Text = dr("emb_estadoO")
                    txt_matricula.Text = dr("emb_numMatricula")
                    txt_nombre.Text = dr("emb_nombre")
                    txt_descrip.Text = dr("emb_descripcion")
                    txt_valor.Text = dr("emb_precio")
                    dtp_fechas.Text = dr("emb_fechaAdquisicion")
                End While
            Else
                MsgBox("Embarcación no se encuentra ....Registre")
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
            sql = "SELECT *from Sis_TipoEmbarcaciones where tipemb_estado = 'A'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            Dim d1 As New DataTable
            d1.Load(dr)
            cbo_tipo.DataSource = d1
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        End Try
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim sql As String
        Try
            sql = ""
            sql = "UPDATE Sis_Embarcaciones SET emb_fk_tipoEmbarcacion =" & cbo_tipo.SelectedValue & ", emb_numMatricula = '" & txt_matricula.Text & "',"
            sql = sql & " emb_nombre = '" & txt_nombre.Text & "',emb_descripcion = ' " & txt_descrip.Text & "',"
            sql = sql & "emb_estadoO='" & cbo_estado.Text & "', emb_fechaAdquisicion ='" & dtp_fechas.Text & "',"
            sql = sql & "emb_precio = " & Trim(Str(CDbl(txt_valor.Text))) & ", emb_estado = 'A'"
            sql = sql & " WHERE emb_id = " & int_id_embarcaciones

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
End Class