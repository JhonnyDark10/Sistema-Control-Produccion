Public Class frm_splash

    Private Sub frm_splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Label1.Visible = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar2.Increment(1)
        If ProgressBar2.Value = 100 Then
            Me.Close()
        End If
        Label1.Text = ProgressBar2.Value & (" %")
    End Sub

    
    Private Sub ApplicationTitle_Click(sender As Object, e As EventArgs) Handles ApplicationTitle.Click

    End Sub
End Class