Imports System.Data.SqlClient

Public Class frm_añadirEmpleado

    Private Sub frm_añadirEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        recupera_tipo()
        recupera_estadoCivil()
        limpiar()
    End Sub

    Sub limpiar()
        txt_cedula.Text = ""
        txt_nombre.Text = ""
        txt_apellido1.Text = ""
        txt_apelldio2.Text = ""
        txt_direccion.Text = ""
        txt_Celular.Text = ""
        txt_carnet.Text = ""
        txt_carnetdescrip.Text = ""
        txt_email.Text = ""
        txt_telefono.Text = ""
    End Sub
    Sub recupera_tipo()
        Dim sql As String
        Dim dr As SqlDataReader
        Try
            sql = "SELECT *from Sis_tipoEmpleado where tip_estado = 'A'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            Dim d1 As New DataTable
            d1.Load(dr)
            cbo_tipo.DataSource = d1
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        End Try
    End Sub

    Sub recupera_estadoCivil()
        Dim sql As String
        Dim dr As SqlDataReader
        Try
            sql = "SELECT *from Sis_EstadoCivil where est_civil_estado = 'A'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            Dim d1 As New DataTable
            d1.Load(dr)
            cbo_estado_c.DataSource = d1
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        End Try
    End Sub
    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()

    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim sql As String

        ' retorna true o false   
        If txt_email.Text = "" Then
        Else
            If ValidateEmail(txt_email.Text) = True Then
            Else
                MessageBox.Show("Formato de correo incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If
       

        If (txt_Celular.Text = "" Or txt_direccion.Text = "" Or txt_carnet.Text = "" Or txt_cedula.Text = "" Or txt_nombre.Text = "" Or txt_apellido1.Text = "" Or txt_apelldio2.Text = "" Or txt_carnetdescrip.Text = "") Then
            MessageBox.Show("Debe llenar las campos obligatorios-->(*)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Try
                sql = ""
                sql = "INSERT INTO Sis_Empleados(emp_fk_estado_civil,emp_fk_tipo,emp_cedula,emp_nombre,"
                sql = sql & " emp_apellidoPaterno,emp_apellidoMaterno,emp_direccion,emp_celular,emp_numCarnets,"
                sql = sql & "  emp_descripcionCarnets,emp_email,emp_telefono,emp_estado)  VALUES("
                sql = sql & Val(cbo_estado_c.SelectedValue) & ", "
                sql = sql & Val(cbo_tipo.SelectedValue) & ", "
                sql = sql & "'" & txt_cedula.Text & "',"
                sql = sql & "'" & txt_nombre.Text & "',"
                sql = sql & "'" & txt_apellido1.Text & "',"
                sql = sql & "'" & txt_apelldio2.Text & "',"
                sql = sql & "'" & txt_direccion.Text & "',"
                sql = sql & "'" & txt_Celular.Text & "',"
                sql = sql & txt_carnet.Text & ","
                sql = sql & "'" & txt_carnetdescrip.Text & "',"
                sql = sql & "'" & txt_email.Text & "',"
                sql = sql & "'" & txt_telefono.Text & "',"
                sql = sql & "'A" & "')"

                Dim com As New SqlCommand(sql, mycon)
                Dim x As Integer
                x = com.ExecuteNonQuery

                MessageBox.Show(" Empleado Almacenado", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'txt_nombre.Text = ""

                Me.Close()

            Catch ex As Exception
                MsgBox(" NO SE A PODIDO ALMACENAR LOS DATOS" & ex.Message)
            End Try
        End If
    End Sub


    Function ValidateEmail(ByVal email As String) As Boolean
        Dim emailRegex As New System.Text.RegularExpressions.Regex(
            "^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As System.Text.RegularExpressions.Match =
           emailRegex.Match(email)
        Return emailMatch.Success
    End Function

    Private Sub txt_cedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cedula.KeyPress
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = CChar("")
        ElseIf e.KeyChar = "." Then
            If txt_cedula.Text = "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_cedula.Text, ".") <> 0 Then
                    e.KeyChar = CChar("")
                End If

            End If
        ElseIf e.KeyChar = "-" Then
            If txt_cedula.Text <> "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_cedula.Text, "-") <> 0 Then
                    e.KeyChar = CChar("")
                End If
            End If
        End If
    End Sub

   
End Class