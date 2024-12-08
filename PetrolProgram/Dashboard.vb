Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports PetrolProgram.Controls

Public Class Dashboard
    Public Shared UpdatedPetrol As Int16
    Public Shared UpdatedDiesel As Int16
    Public Shared UpdatedUsername As String = ""
    Public Shared UpdatedPassword As String = ""

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Menu.Show()
        Me.Close()
    End Sub

    Private Sub btnUptFul_Click(sender As Object, e As EventArgs) Handles btnUptFul.Click
        UpdatedPetrol = txtPtl.Text
        UpdatedDiesel = txtDsl.Text
        LabelUpdate()
    End Sub

    Private Sub btnUptLgn_Click(sender As Object, e As EventArgs) Handles btnUptLgn.Click
        UpdatedUsername = txtUsr.Text
        UpdatedPassword = txtPsw.Text
        LabelUpdate()
        MsgBox("Updated the Password." & vbCrLf & "The new Username is: " & UpdatedUsername & vbCrLf & "The new Password is: " & UpdatedPassword)
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelUpdate()
    End Sub

    Private Sub LabelUpdate()
        If Dashboard.UpdatedUsername = "" Then
            lblUsrVal.Text = "123" 'The defualt Username
        Else
            lblUsrVal.Text = Dashboard.UpdatedUsername
        End If

        If Dashboard.UpdatedPassword = "" Then
            lblPwdVal.Text = "123" 'The defualt Password
        Else
            lblPwdVal.Text = Dashboard.UpdatedPassword
        End If

        If Dashboard.UpdatedPetrol = 0 Then
            lblPtlCst.Text = "£" & Maths(Game.PetrolCost) & " /L" 'The defualt Petrol Cost
        Else
            lblPtlCst.Text = "£" & Maths(Dashboard.UpdatedPetrol) & " /L"
        End If

        If Dashboard.UpdatedDiesel = 0 Then
            lblDslCst.Text = "£" & Maths(Game.DieselCost) & " /L" 'The defualt Diesel Cost 
        Else
            lblDslCst.Text = "£" & Maths(Dashboard.UpdatedPetrol) & " /L"
        End If
    End Sub

    Private Sub btnFulChge_Click(sender As Object, e As EventArgs) Handles btnFulChge.Click
        FuelChange.Show()
    End Sub

    Private Sub btnLgnChge_Click(sender As Object, e As EventArgs) Handles btnLgnChge.Click
        PasswordChange.Show()
    End Sub

    Private Sub btnRpt_Click(sender As Object, e As EventArgs) Handles btnRpt.Click
        Report.Show()
    End Sub
End Class