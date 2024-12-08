Public Class SplashScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Timer1.Interval >= 500 Then
            Me.Hide()
            Menu.Show()
            Timer1.Stop()
        End If
        Timer1.Interval += 10
    End Sub

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1
        Timer1.Start()
    End Sub

    Private Sub ProBar_Click(sender As Object, e As EventArgs) Handles ProBar.Click

    End Sub

    'Private Sub btnDebug_Click(sender As Object, e As EventArgs)
    ' Hide
    'Debug.Show
    'Timer1.Stop
    'End Sub
End Class
