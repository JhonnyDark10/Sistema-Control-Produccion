Imports System.Data.SqlClient

Public Class frm_caja

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()

    End Sub

    Private Sub frm_caja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_embarcacion()
        txt_total_pagar.Text = Format(0, "##,##0.00")
        txt_efectivo.Text = Format(0, "##,##0.00")
        txt_cambio.Text = Format(0, "##,##0.00")
        limpiar()
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

   

    Private Sub cbo_embarcaciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_embarcaciones.SelectedIndexChanged
        txt_as.Text = cbo_embarcaciones.SelectedValue
    End Sub


    Sub llenar_emple()
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try
            sql = ""
            sql = sql & "SELECT em.emp_nombre as Nombre, em.emp_apellidoPaterno +' '+ em.emp_apellidoMaterno as Apellidos from Sis_Embarcaciones e "
            sql = sql & "inner join Sis_asignarecursos a on e.emb_id = a.rec_fk_embarcaciones "
            sql = sql & "inner join sis_asignarecursosempleado r on r.recemp_fk_recursos = a.rec_id "
            sql = sql & "inner join sis_empleados em on em.emp_id = r.recemp_fk_empleados "
            sql = sql & "where a.rec_fk_embarcaciones =" & Val(txt_as.Text)

            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)

            drg_jaja.DataSource = dt

         

        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub

    

    Private Sub btn_escoger_Click(sender As Object, e As EventArgs) Handles btn_escoger.Click
        llenar_emple()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click

        Dim sql As String


        If (txt_alimentacion.Text = "" Or txt_gasolina.Text = "") Then
            MessageBox.Show("Debe llenar las campos obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try

                sql = "INSERT INTO Sis_Zarpe(zar_fk_embarcacion,zar_alimentacion,zar_gasolina,zar_carnada,zar_hielo,zar_otros,zar_contras,zar_total,zar_estado) VALUES ("
                sql = sql & cbo_embarcaciones.SelectedValue & ","
                sql = sql & Trim(Str(CDbl(txt_alimentacion.Text))) & ", "
                sql = sql & Trim(Str(CDbl(txt_gasolina.Text))) & ", "
                sql = sql & Trim(Str(CDbl(txt_carnada.Text))) & ", "
                sql = sql & Trim(Str(CDbl(txt_hielo.Text))) & ","
                sql = sql & Trim(Str(CDbl(txt_otros.Text))) & ", "
                sql = sql & Trim(Str(CDbl(txt_contras.Text))) & ", "
                sql = sql & Trim(Str(CDbl(txt_total_pagar.Text))) & ","
                sql = sql & "'A" & "')"
                Dim com As New SqlCommand(sql, mycon)
                Dim x As Integer
                x = com.ExecuteNonQuery


                MessageBox.Show(" Dato Registrado", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiar()
            Catch ex As Exception
                'MessageBox.Show("No es Posible Registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
        End If

    End Sub


    Sub limpiar()
        txt_alimentacion.Text = Format(0, "##,##0.00")
        txt_gasolina.Text = Format(0, "##,##0.00")
        txt_carnada.Text = Format(0, "##,##0.00")
        txt_contras.Text = Format(0, "##,##0.00")
        txt_otros.Text = Format(0, "##,##0.00")
        txt_hielo.Text = Format(0, "##,##0.00")
        txt_total_pagar.Text = Format(0, "##,##0.00")
        drg_jaja.Rows.Clear()
    End Sub

    Private Sub txt_alimentacion_TextChanged(sender As Object, e As EventArgs) Handles txt_alimentacion.TextChanged
        
    End Sub

    Dim dbl_total As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dbl_total = CDbl(txt_alimentacion.Text) + CDbl(txt_gasolina.Text) + CDbl(txt_carnada.Text) + CDbl(txt_hielo.Text) + CDbl(txt_otros.Text) + CDbl(txt_contras.Text)
        txt_total_pagar.Text = Format(dbl_total, "##,##0.00")
    End Sub
End Class