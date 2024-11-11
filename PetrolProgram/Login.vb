Public Class Login
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Menu.Show()
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim strUser As String = txtUsr.Text
        Dim strPass As String = txtPsw.Text
        Dim Username As String = "123"
        Dim Password As String = "123"

        If strUser = Username And strPass = Password Then
            Dashboard.Show()
            Me.Close()
        ElseIf strUser = Username Then
            MsgBox("Your Password is incorrect", vbDefaultButton1, "Incorrect Password")
        ElseIf strPass = Password Then
            MsgBox("Your Username is incorrect", vbDefaultButton1, "Incorrect Username")
        Else
            MsgBox("Your fucked")
        End If

    End Sub
End Class