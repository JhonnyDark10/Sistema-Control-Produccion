Imports System.Data.SqlClient

Public Class frm_capital

    Private Sub frm_capital_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_total()
        llenar_embarcacion()
        txt_total_pagar.Text = Format(0, "##,##0.00")
        txt_efectivo.Text = Format(0, "##,##0.00")
        txt_cambio.Text = Format(0, "##,##0.00")
    End Sub

    Sub llenar_total()
     
    End Sub

    Sub llenar_embarcacion()
        Dim sql As String
        Dim dr As SqlDataReader
        Try
            sql = "SELECT *from Sis_Embarcaciones where emb_estado = 'A'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            Dim d1 As New DataTable
            d1.Load(dr)
            cbo_embarcaciones.DataSource = d1
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        End Try
    End Sub

    Private Sub btn_capital_Click(sender As Object, e As EventArgs) Handles btn_capital.Click
        Dim sql As String


        If (txt_montocapital.Text = "") Then
            MessageBox.Show("Debe llenar las campos obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try

                sql = "INSERT INTO Sis_Caja(caja_fecha,caja_total,zar_estado) VALUES ("
                sql = sql & "'" & dtp_fechas.Text & "', "
                sql = sql & Trim(Str(CDbl(txt_montocapital.Text))) & ", "
                sql = sql & "'A" & "')"
                Dim com As New SqlCommand(sql, mycon)
                Dim x As Integer
                x = com.ExecuteNonQuery


                MessageBox.Show(" Dato Registrado", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_montocapital.Text = ""
            Catch ex As Exception
                'MessageBox.Show("No es Posible Registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
        End If

    End Sub

    Private Sub btn_pesca_Click(sender As Object, e As EventArgs) Handles btn_pesca.Click
        Dim sql As String


        If (txt_montoembarcaciones.Text = "") Then
            MessageBox.Show("Debe llenar las campos obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try

                sql = "INSERT INTO Sis_Caja(caja_descripcion,caja_accion,caja_embarcacion,caja_fecha,caja_total,zar_estado) VALUES ("
                sql = sql & "'" & txt_detallrecursos.Text & "', "
                sql = sql & "'" & cbo_recursos.Text & "', "
                sql = sql & cbo_embarcaciones.SelectedValue & ","
                sql = sql & "'" & dtp_fechas.Text & "', "
                sql = sql & Trim(Str(CDbl(txt_montoembarcaciones.Text))) & ", "
                sql = sql & "'A" & "')"
                Dim com As New SqlCommand(sql, mycon)
                Dim x As Integer
                x = com.ExecuteNonQuery

                MessageBox.Show(" Dato Registrado", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_montoembarcaciones.Text = ""
            Catch ex As Exception
                MessageBox.Show("No es Posible Registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
        End If

    End Sub

    Private Sub btn_egreso_Click(sender As Object, e As EventArgs) Handles btn_egreso.Click
        Dim sql As String


        If (text_montorecursos.Text = "") Then
            MessageBox.Show("Debe llenar las campos obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try

                sql = "INSERT INTO Sis_Caja(caja_descripcion,caja_accion,caja_embarcacion,caja_fecha,caja_total,zar_estado) VALUES ("
                sql = sql & "'" & txt_detallrecursos.Text & "', "
                sql = sql & "'" & cbo_recursos.Text & "', "
                sql = sql & cbo_embarcaciones.SelectedValue & ","
                sql = sql & "'" & dtp_fechas.Text & "', "
                sql = sql & Trim(Str(CDbl(text_montorecursos.Text))) & ", "
                sql = sql & "'A" & "')"
                Dim com As New SqlCommand(sql, mycon)
                Dim x As Integer
                x = com.ExecuteNonQuery


                MessageBox.Show(" Dato Registrado", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                text_montorecursos.Text = ""
                txt_detallrecursos.Text = ""
                cbo_recursos.Text = ""
            Catch ex As Exception
                'MessageBox.Show("No es Posible Registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
        End If

    End Sub
End Class