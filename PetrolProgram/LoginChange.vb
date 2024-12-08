Imports PetrolProgram.Controls
Public Class LoginChange
    Private Sub btnUptLgn_Click(sender As Object, e As EventArgs) Handles btnUptLgn.Click
        UpdatedUsername = txtUsr.Text
        UpdatedPassword = txtPsw.Text
        LabelUpdate()
        MsgBox("Updated the Password." & vbCrLf & "The new Username is: " & UpdatedUsername & vbCrLf & "The new Password is: " & UpdatedPassword)
    End Sub

    Private Sub LoginChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelUpdate()
    End Sub
End Class