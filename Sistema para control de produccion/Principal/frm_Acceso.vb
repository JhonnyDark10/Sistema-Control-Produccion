Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class frm_acceso
    Dim sql As String
    Dim dr As SqlDataReader
    Dim dt As New DataTable

    Private Sub frm_acceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ind_menu_desactiva = 0
    End Sub

    'Private Sub frm_Principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    '    Try
    '        Dim str_mensage, str_titulo As String
    '        str_mensage = "Realmente desea salir del Sistema?"
    '        str_titulo = "Cerrando Sistema "
    '        Dim respuesta As MsgBoxResult
    '        respuesta = MsgBox(str_mensage, MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question Or MsgBoxStyle.YesNo, str_titulo)
    '        If respuesta = MsgBoxResult.Yes Then
    '            e.Cancel = False
    '        Else

    '            e.Cancel = True

    '        End If


    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
    Private Sub BTN_ACEPTAR_INICIO_Click(sender As Object, e As EventArgs) Handles BTN_ACEPTAR_INICIO.Click
        Dim ACCESO_C As Boolean

        If (txt_usuario_acceso.Text = "" And txt_contraseña_acceso.Text = "") Then
            MessageBox.Show("Debe Ingresar los Datos ", "ACCESO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If


        If (txt_usuario_acceso.Text <> "" And txt_contraseña_acceso.Text <> "") Then
            Try
                sql = "SELECT * FROM seg_Usuarios u INNER JOIN seg_Perfil p ON u.usu_per_Id = p.per_Id  WHERE p.per_Nombre ='" & "administrador" & "' and u.usu_estado = 'A'"
                Dim com As New SqlCommand(sql, mycon)
                dr = com.ExecuteReader
                If dr.HasRows Then
                    While dr.Read

                        If (dr("usu_usuario") = Trim(txt_usuario_acceso.Text) And dr("usu_clave") = Trim(txt_contraseña_acceso.Text)) Then
                            ACCESO_C = True
                            g_str_nombre_usuario = dr("usu_usuario")
                            Exit While
                        Else
                            ACCESO_C = False
                        End If
                    End While
                End If
                dr.Close()

                If ACCESO_C Then
                    MsgBox("Acceso Permitido Como Administrador", MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Sistema")
                    Dim frm As New frm_Principal
                    ind_menu_desactiva = 0
                    Me.Hide()
                    frm.ShowDialog()
                    Exit Sub

                Else


                    Try
                        sql = "SELECT * FROM seg_Usuarios u INNER JOIN seg_Perfil p ON u.usu_per_Id = p.per_Id  WHERE p.per_Nombre ='" & "usuarios" & "' and u.usu_estado = 'A'"
                        Dim com1 As New SqlCommand(sql, mycon)
                        dr = com1.ExecuteReader
                        If dr.HasRows Then
                            While dr.Read

                                If (dr("usu_usuario") = Trim(txt_usuario_acceso.Text) And dr("usu_clave") = Trim(txt_contraseña_acceso.Text)) Then
                                    ACCESO_C = True
                                    g_str_nombre_usuario = dr("usu_usuario")
                                    Exit While
                                Else
                                    ACCESO_C = False
                                End If
                            End While
                        End If
                        dr.Close()

                        If ACCESO_C Then
                            MsgBox("Acceso Permitido Como Usuarios", MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Sistema")

                            Dim frm As New frm_Principal
                            Me.Hide()
                            ind_menu_desactiva = 1
                            frm.ShowDialog()
                            Exit Sub
                        Else
                            MsgBox("Datos Incorrectos", MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Sistema")

                        End If
                    Catch ex As Exception
                        MsgBox("Error al conectar con la BD " & ex.Message)
                    End Try
                End If
            Catch ex As Exception
                MsgBox("Error al conectar con la BD " & ex.Message)
            End Try

        End If
    End Sub

    Private Sub BTN_CANCELAR_INICIO_Click(sender As Object, e As EventArgs) Handles BTN_CANCELAR_INICIO.Click
        Try
            Dim str_mensage, str_titulo As String
            str_mensage = "Realmente desea salir del Sistema?"
            str_titulo = "Cerrando Sistema "
            Dim respuesta As MsgBoxResult
            respuesta = MsgBox(str_mensage, MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question Or MsgBoxStyle.YesNo, str_titulo)
            If respuesta = MsgBoxResult.Yes Then
                Me.Close()
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class