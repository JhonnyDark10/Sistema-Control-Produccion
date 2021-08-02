Imports System.Data.SqlClient

Public Class frm_modificarEmpleado

    Private Sub frm_modificarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        recupera_tipo()
        recupera_estadoCivil()
        recupera_datos(int_id_empleado)
    End Sub

    Sub recupera_datos(datos As Integer)
        Dim sql As String
        Dim dr As SqlDataReader
        Try
            sql = ""
            sql = sql & "select p.emp_id,p.emp_fk_tipo,p.emp_fk_estado_civil,p.emp_cedula,p.emp_nombre,"
            sql = sql & "p.emp_apellidoPaterno,p.emp_apellidoMaterno,p.emp_direccion,p.emp_descripcionCarnets,p.emp_celular,"
            sql = sql & "p.emp_email,p.emp_numcarnets,p.emp_telefono"
            sql = sql & " From Sis_Empleados p"
            sql = sql & " WHERE P.emp_estado = 'A' and p.emp_id = " & datos

            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    cbo_tipo.SelectedValue = dr("emp_fk_tipo")
                    cbo_estado_c.SelectedValue = dr("emp_fk_estado_civil")
                    txt_cedula.Text = dr("emp_cedula")
                    txt_nombre.Text = dr("emp_nombre")
                    txt_apellido1.Text = dr("emp_apellidoPaterno")
                    txt_apelldio2.Text = dr("emp_apellidoMaterno")
                    txt_direccion.Text = dr("emp_direccion")
                    txt_Celular.Text = dr("emp_celular")
                    txt_carnet.Text = dr("emp_numcarnets")
                    txt_carnetdescrip.Text = dr("emp_descripcionCarnets")
                    txt_email.Text = dr("emp_email")
                    txt_telefono.Text = dr("emp_telefono")



                End While
            Else
                MsgBox("Empleado no se encuentra ....Registre")
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
        Try
            If txt_email.Text = "" Then
            Else
                If ValidateEmail(txt_email.Text) = True Then
                Else
                    MessageBox.Show("Formato de correo incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If

            sql = "UPDATE Sis_Empleados SET emp_fk_estado_civil =" & cbo_estado_c.SelectedValue & ", emp_cedula = '" & txt_cedula.Text & "',"
            sql = sql & " emp_nombre = '" & txt_nombre.Text & "',emp_apellidoPaterno = ' " & txt_apellido1.Text & "',"
            sql = sql & "emp_apellidoMaterno='" & txt_apelldio2.Text & "', emp_direccion ='" & txt_direccion.Text & "',"
            sql = sql & "emp_celular='" & txt_Celular.Text & "',emp_numCarnets='" & txt_carnet.Text & "',emp_email='" & txt_email.Text & "',"
            sql = sql & "emp_telefono='" & txt_telefono.Text & "',emp_descripcionCarnets='" & txt_carnetdescrip.Text & "',"
            sql = sql & "emp_fk_tipo='" & cbo_tipo.SelectedValue & "', emp_estado = 'A'"
            sql = sql & " WHERE emp_id = " & int_id_empleado

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


    Function ValidateEmail(ByVal email As String) As Boolean
        Dim emailRegex As New System.Text.RegularExpressions.Regex(
            "^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As System.Text.RegularExpressions.Match =
           emailRegex.Match(email)
        Return emailMatch.Success
    End Function
End Class