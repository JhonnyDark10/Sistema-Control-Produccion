Imports System.Data.SqlClient

Public Class frm_inventario

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()

    End Sub

    Private Sub frm_inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_embarcacion()
        llenar_participante()
        llenar_implementos()
        limpiar()
    End Sub

    Sub limpiar()
        txt_descripcion.Text = ""
        txt_codigo.Text = ""
        txt_personal.Text = ""
        txt_piloto.Text = ""
        txt_listaImplementos.Text = ""

        'dgv_listaimplementos2.DataSource = "" : dgv_listaimplementos2.DataMember = ""
        'dgv_personal2.DataSource = "" : dgv_personal2.DataMember = ""

    End Sub
    Sub llenar_implementos()
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try
            sql = ""
            sql = "SELECT imp_id,imp_nombre from Sis_Implementos where imp_estado = 'A'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            dgv_listaimplementos.DataSource = dt
            dgv_listaimplementos.RowHeadersVisible = False
            Me.dgv_listaimplementos.Columns(0).Visible = False
            Dim row3 As DataGridViewColumn = dgv_listaimplementos.Columns(1)
            row3.Width = 260

        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub
    Sub llenar_participante()
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try
            sql = ""
            sql = "SELECT emp_id,emp_nombre + ' '+ emp_apellidoPaterno + ' '+ emp_apellidoMaterno as Nombres from Sis_Empleados where emp_estado = 'A'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            dgv_personal1.DataSource = dt
            dgv_personal1.RowHeadersVisible = False
            Me.dgv_personal1.Columns(0).Visible = False
            Dim row3 As DataGridViewColumn = dgv_personal1.Columns(1)
            row3.Width = 260

        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
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

    Private Sub btn_escoger_Click(sender As Object, e As EventArgs) Handles btn_escoger.Click
        frm_lista_empleados.ShowDialog()
    End Sub

    Private Sub txt_personal_TextChanged(sender As Object, e As EventArgs) Handles txt_personal.TextChanged
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try

            sql = ""
            sql = "SELECT emp_id,emp_nombre + ' '+ emp_apellidoPaterno + ' '+ emp_apellidoMaterno as Nombres from Sis_Empleados where emp_estado = 'A'"
            sql = sql & " and (emp_nombre + ' '+ emp_apellidoPaterno + ' '+ emp_apellidoMaterno like '" & txt_personal.Text & "%')"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            dgv_personal1.DataSource = dt
            dgv_personal1.RowHeadersVisible = False
            Me.dgv_personal1.Columns(0).Visible = False
            Dim row3 As DataGridViewColumn = dgv_personal1.Columns(1)
            row3.Width = 260
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub

    Dim int_id_perfil As Integer
    Dim nombres As String
    Private Sub dgv_personal1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_personal1.CellMouseClick
        Try
            If e.RowIndex > -1 Then
                int_id_perfil = dgv_personal1.Rows(e.RowIndex).Cells(0).Value
                nombres = dgv_personal1.Rows(e.RowIndex).Cells(1).Value
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click
        Try

            dgv_personal2.Rows.Add(int_id_perfil, nombres)
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub

    
    Dim int_id_perfil2 As Integer
    Private Sub dgv_personal2_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_personal2.CellMouseClick
        Try
            If e.RowIndex > -1 Then
                int_id_perfil2 = dgv_personal1.Rows(e.RowIndex).Cells(0).Value
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_2_Click(sender As Object, e As EventArgs) Handles btn_2.Click

        Try
            Dim fil As Integer
            fil = dgv_personal2.CurrentRow.Index
            dgv_personal2.Rows.RemoveAt(fil)
        Catch ex As Exception
            MsgBox("Error  " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub

    Private Sub txt_listaImplementos_TextChanged(sender As Object, e As EventArgs) Handles txt_listaImplementos.TextChanged
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try

            sql = ""
            sql = "SELECT imp_id,imp_nombre from Sis_Implementos where imp_estado = 'A'"
            sql = sql & " and (imp_nombre like '" & txt_listaImplementos.Text & "%')"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            dgv_listaimplementos.DataSource = dt
            dgv_listaimplementos.RowHeadersVisible = False
            Me.dgv_listaimplementos.Columns(0).Visible = False
            Dim row3 As DataGridViewColumn = dgv_listaimplementos.Columns(1)
            row3.Width = 260
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub

    Dim int_id_perfil_i As Integer
    Dim nombres_i As String
    Private Sub dgv_listaimplementos_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_listaimplementos.CellMouseClick
        Try
            If e.RowIndex > -1 Then
                int_id_perfil_i = dgv_listaimplementos.Rows(e.RowIndex).Cells(0).Value
                nombres_i = dgv_listaimplementos.Rows(e.RowIndex).Cells(1).Value
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub btn_mover_Click(sender As Object, e As EventArgs) Handles btn_mover.Click

        Try
            dgv_listaimplementos2.Rows.Add(int_id_perfil_i, nombres_i)
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub



    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btn_regresar.Click
        Try
            Dim fil As Integer
            fil = dgv_listaimplementos2.CurrentRow.Index
            dgv_listaimplementos2.Rows.RemoveAt(fil)
        Catch ex As Exception
            MsgBox("Error  " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub

    Dim int_id_perfil3 As Integer
    Private Sub dgv_listaimplementos2_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_listaimplementos2.CellMouseClick
        Try
            If e.RowIndex > -1 Then
                int_id_perfil3 = dgv_listaimplementos.Rows(e.RowIndex).Cells(0).Value
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim sql As String


        If (txt_piloto.Text = "" Or txt_descripcion.Text = "") Then
            MessageBox.Show("Debe llenar las campos obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Try

                sql = "INSERT INTO Sis_AsignaRecursos(rec_fk_embarcaciones,rec_fecha,rec_descripcion,rec_estado) VALUES ("
                sql = sql & cbo_embarcaciones.SelectedValue & ",' "
                sql = sql & dtp_inicio_fecha.Text & "',' "
                sql = sql & txt_descripcion.Text & "', "
                sql = sql & "'A" & "')"
                Dim com As New SqlCommand(sql, mycon)
                Dim x As Integer
                x = com.ExecuteNonQuery

                Dim codigo As Integer

                '----PARA OBTENER EL ULTIMO ID DEL  ALMACENADO-------

                sql = "SELECT MAX(rec_Id) as codigo FROM Sis_AsignaRecursos "
                Dim re As SqlDataReader
                Dim con As New SqlCommand(sql, mycon)

                Dim dt As New DataTable
                re = con.ExecuteReader()
                dt.Load(re)

                If dt.Rows.Count > 0 Then
                    codigo = dt.Rows(0)("codigo")
                End If
                re.Close()

                '-----------------------------------------------------
                guardar_participantes(codigo)
                guardar_implementos(codigo)

                MessageBox.Show(" Dato Registrado", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                limpiar()
                dgv_listaimplementos2.Rows.Clear()
                dgv_personal2.Rows.Clear()
            Catch ex As Exception
                MessageBox.Show("No es Posible Registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
        End If
    End Sub

    Sub guardar_participantes(c As Integer)

        Dim sql As String
        Try
            Dim Codigo As Integer
            For Each row As DataGridViewRow In Me.dgv_personal2.Rows
                'obtenemos el valor de la columna en la variable declarada
                Codigo = row.Cells(0).Value 'donde (0) es la columna a recorrer
                sql = ""
                sql = "INSERT INTO Sis_AsignaRecursosempleado(recemp_fk_empleados, recemp_fk_recursos,rec_estado) VALUES ("
                sql = sql & Codigo & ", "
                sql = sql & c & ", "
                sql = sql & "'A" & "')"
                Dim com As New SqlCommand(sql, mycon)
                Dim x As Integer
                x = com.ExecuteNonQuery
            Next
        Catch ex As Exception
            MessageBox.Show("No es Posible Registrar varios participantes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Sub guardar_implementos(c As Integer)

        Dim sql As String

        Try
            Dim Codigo1 As Integer
            For Each row As DataGridViewRow In Me.dgv_personal2.Rows
                'obtenemos el valor de la columna en la variable declarada
                Codigo1 = row.Cells(0).Value 'donde (0) es la columna a recorrer
                sql = ""
                sql = "INSERT INTO Sis_AsignaRecursoimplementos(recimp_fk_implementos, recimp_fk_recursos,rec_estado) VALUES ("
                sql = sql & Codigo1 & ", "
                sql = sql & c & ", "
                sql = sql & "'A" & "')"
                Dim com As New SqlCommand(sql, mycon)
                Dim x As Integer
                x = com.ExecuteNonQuery
            Next
        Catch ex As Exception
            MessageBox.Show("No es Posible Registrar varios implementos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        End Try
    End Sub


End Class