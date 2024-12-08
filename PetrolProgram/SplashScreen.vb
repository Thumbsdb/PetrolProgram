Public Class SplashScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProBar.Increment(3)
        If ProBar.Value = 100 Then
            Me.Hide()
            Menu.Show()
            Timer1.Stop()
        End If
        Timer1.Interval += 10
    End Sub

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 20
        Timer1.Start()
    End Sub
End Class
