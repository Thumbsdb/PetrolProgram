Public Class LogedIn
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Menu.Show()
        Login.Close()
        Me.Close()
    End Sub
End Class