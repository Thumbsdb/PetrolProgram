Imports PetrolProgram.Controls
Public Class Login
    'Fuck how long these are

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Menu.Show()
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This checks if the UpdatedX variables has anything in it and the sets it to Password for the login if not will set it to the default values of 123
        'This done on load to make sure the variables are set up correctly
        If UpdatedPassword = "" Then
            Password = DefaultPswUsr
        Else
            Password = UpdatedPassword
        End If

        If UpdatedUsername = "" Then
            Username = DefaultPswUsr
        Else
            Username = UpdatedUsername
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Password and Username checker
        'This output a unqiue message for and incorrect Username or Passworwd
        Dim strUser As String = txtUsr.Text
        Dim strPass As String = txtPsw.Text
        System.Diagnostics.Debug.WriteLine(Password)
        If txtUsr.Text = Username And txtPsw.Text = Password Then
            Dashboard.Show()
            Me.Close()
        ElseIf strUser = Username Then
            MsgBox("Your Password is incorrect", vbDefaultButton1, "Incorrect Password") 'This is here because This is when your Username is correct but the Password is incorrect
        ElseIf strPass = Password Then
            MsgBox("Your Username is incorrect", vbDefaultButton1, "Incorrect Username") 'This is here because this is when you the Password is correct but the username is incorrect
        Else
            MsgBox("Please enter a Username and Passwrod", vbDefaultButton1, "No Username and Password")
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        txtPsw.Text = ""
        txtUsr.Text = ""
    End Sub
End Class