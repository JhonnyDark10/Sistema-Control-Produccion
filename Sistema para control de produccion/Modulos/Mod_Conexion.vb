Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Configuration
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Text.RegularExpressions

Module Mod_Conexion
    Public mycon As New SqlConnection
    Public str_cadena As String
    Dim str_servidor As String
    Dim str_Base As String
    Dim str_usuario As String
    Dim str_clave As String

    Function fun_leerdatos() As Boolean
        Try
            fun_leerdatos = False
            Dim directorio, cadena As String
            directorio = System.AppDomain.CurrentDomain.BaseDirectory() & "DatosSistema.txt"
            'Dim objReader As New StreamReader("C:\Windows\sisboleteria.txt")
            Dim objReader As New StreamReader(directorio)

            Dim sLine As String = ""
            Dim arrText As New ArrayList()
            Do
                sLine = objReader.ReadLine()
                If Not sLine Is Nothing Then
                    arrText.Add(sLine)
                End If
            Loop Until sLine Is Nothing
            objReader.Close()

            cadena = ""
            For Each sLine In arrText
                cadena = cadena & sLine
            Next

            Dim arr = cadena.Split(":")
            str_servidor = arr(1) 'servidor
            str_Base = arr(3) 'Base de Datos
            str_usuario = arr(5) 'usuario
            str_clave = arr(7) 'clave
            If str_usuario <> "" Then
                str_cadena = "Data Source=" & str_servidor & ";Initial Catalog=" & str_Base & ";User ID=" & str_usuario & ";password=" & str_clave
            Else
                str_cadena = "Data Source=" & str_servidor & ";Initial Catalog=" & str_Base & " ;Integrated Security=true;"
            End If
            fun_leerdatos = True
        Catch ex As Exception
            ' MsgBox(ex.Message)
            fun_leerdatos = False
        End Try
    End Function





    Function conectar_base() As Boolean
        conectar_base = False
        Try
            mycon.ConnectionString = str_cadena
            mycon.Open()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error en el Módulo de conexión")
        End Try
        conectar_base = True
        Return conectar_base
    End Function


    Sub main()
        fun_leerdatos()
        If conectar_base() = False Then
            MsgBox(" No se pudo conectar con la Base de Datos")
        Else
            frm_splash.ShowDialog()
            frm_acceso.ShowDialog()
        End If
    End Sub
End Module
