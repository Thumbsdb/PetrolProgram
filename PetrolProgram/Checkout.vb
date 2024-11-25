Public Class Checkout
    Private Sub Checkout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLtrNum.Text = Game.FuelCost
        lblFulNum.Text = Game.FuelCost
    End Sub

    Private Sub btnMnu_Click(sender As Object, e As EventArgs) Handles btnMnu.Click
        Menu.Show()
        Me.Close()
    End Sub
End Class