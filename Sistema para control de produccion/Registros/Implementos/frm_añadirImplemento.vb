Imports System.Data.SqlClient

Public Class frm_añadirImplemento

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()

    End Sub

    Private Sub frm_añadirImplemento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        recupera_tipo()
        limpiar()

    End Sub

    Sub limpiar()
        nd_cantidad.Text = 0
        txt_nombre.Text = ""
        txt_valor.Text = ""

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

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim sql As String

        If (txt_nombre.Text = "" Or txt_nombre.Text = "" Or cbo_estado.Text = "" Or txt_valor.Text = "") Then
            MessageBox.Show("Debe llenar las campos obligatorios-->(*)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Try
                sql = ""
                sql = "INSERT INTO Sis_Implementos(imp_fk_tipo,imp_nombre,"
                sql = sql & "imp_estadoO,imp_fechaAdquisicion,imp_precio,imp_cantidad,imp_total,imp_estado) VALUES("
                sql = sql & Val(cbo_tipo.SelectedValue) & ", "
                sql = sql & "'" & txt_nombre.Text & "',"
                sql = sql & "'" & cbo_estado.Text & "',"
                sql = sql & "'" & dtp_fechas.Text & "',"
                sql = sql & Trim(Str(CDbl(txt_valor.Text))) & ","
                sql = sql & nd_cantidad.Text & ","
                sql = sql & (Trim(Str(CDbl(txt_valor.Text))) * Val(nd_cantidad.Text)) & ","
                sql = sql & "'A" & "')"

                Dim com As New SqlCommand(sql, mycon)
                Dim x As Integer
                x = com.ExecuteNonQuery

                MessageBox.Show(" Implemento Almacenado", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'txt_nombre.Text = ""

                Me.Close()

            Catch ex As Exception
                MsgBox(" NO SE A PODIDO ALMACENAR LOS DATOS" & ex.Message)
            End Try
        End If

    End Sub
End Class