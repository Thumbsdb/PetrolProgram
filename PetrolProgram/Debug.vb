Public Class Debug
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Menu.Show()
        Me.Close()
    End Sub

    Private Sub btnSplash_Click(sender As Object, e As EventArgs) Handles btnSplash.Click
        SplashScreen.Show
        Close
    End Sub

    Private Sub btnLogedIn_Click(sender As Object, e As EventArgs) Handles btnLogedIn.Click
        LogedIn.Show()
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnGame_Click(sender As Object, e As EventArgs) Handles btnGame.Click
        Game.Show()
        Me.Close()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Help.Show()
        Me.Close()
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Pay.Show()
        Me.Close()
    End Sub

    Private Sub btnCeckout_Click(sender As Object, e As EventArgs) Handles btnCeckout.Click
        Checkout.Show()
        Me.Close()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dashboard.Show()
        Me.Close()
    End Sub
End Class