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
        txtPtl.Text = UpdatedPetrol
        txtDsl.Text = UpdatedDiesel
    End Sub

    Private Sub btnUptLgn_Click(sender As Object, e As EventArgs) Handles btnUptLgn.Click
        txtUsr.Text = UpdatedUsername
        txtPsw.Text = UpdatedPassword
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Top As Decimal
        Dim Bottom As Decimal
        Top = Game.PetrolCost
        Bottom = Top / 100
        lblPtlCst.Text = "£" & Bottom & " /L"
        Top = Game.DieselCost
        Bottom = Top / 100
        lblDslCst.Text = "£" & Bottom & " /L"
    End Sub
End Class