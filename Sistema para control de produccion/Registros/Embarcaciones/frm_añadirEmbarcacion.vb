Imports System.Data.SqlClient

Public Class frm_añadirEmbarcacion

    Private Sub frm_añadirEmbarcacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        recupera_tipo()
        limpiar()
    End Sub

    Sub limpiar()
        txt_matricula.Text = ""
        txt_nombre.Text = ""
        txt_descrip.Text = ""
        txt_valor.Text = ""

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

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()

    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim sql As String

        If (txt_nombre.Text = "" Or txt_descrip.Text = "" Or cbo_estado.Text = "" Or txt_valor.Text = "") Then
            MessageBox.Show("Debe llenar las campos obligatorios-->(*)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Try
                sql = ""
                sql = "INSERT INTO Sis_Embarcaciones(emb_fk_tipoEmbarcacion,emb_numMatricula,emb_nombre,emb_descripcion,"
                sql = sql & "emb_estadoO,emb_fechaAdquisicion,emb_precio,emb_estado) VALUES("
                sql = sql & Val(cbo_tipo.SelectedValue) & ", "
                sql = sql & "'" & txt_matricula.Text & "',"
                sql = sql & "'" & txt_nombre.Text & "',"
                sql = sql & "'" & txt_descrip.Text & "',"
                sql = sql & "'" & cbo_estado.Text & "',"
                sql = sql & "'" & dtp_fechas.Text & "',"
                sql = sql & Trim(Str(CDbl(txt_valor.Text))) & ","
                sql = sql & "'A" & "')"

                Dim com As New SqlCommand(sql, mycon)
                Dim x As Integer
                x = com.ExecuteNonQuery

                MessageBox.Show(" Embarcación Almacenada", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'txt_nombre.Text = ""

                Me.Close()

            Catch ex As Exception
                MsgBox(" NO SE A PODIDO ALMACENAR LOS DATOS" & ex.Message)
            End Try
        End If
    End Sub
End Class