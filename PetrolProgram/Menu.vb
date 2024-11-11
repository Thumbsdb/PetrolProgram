Public Class Menu
    Private Sub btnExt_Click(sender As Object, e As EventArgs) Handles btnExt.Click
        Application.Exit()
    End Sub

    Private Sub btnLgn_Click(sender As Object, e As EventArgs) Handles btnLgn.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub btnDebug_Click(sender As Object, e As EventArgs) Handles btnDebug.Click
        Debug.Show()
        Me.Close()
    End Sub

    Private Sub btnStr_Click(sender As Object, e As EventArgs) Handles btnStr.Click
        Game.Show()
        Me.Close()
    End Sub
End Class