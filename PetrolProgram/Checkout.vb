Public Class Checkout
    Private Sub lblLtrNum_Click(sender As Object, e As EventArgs) Handles lblLtrNum.Click

    End Sub

    Private Sub Checkout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLtrNum.Text = Game.FuelCost
        lblFulNum.Text = Game.FuelCost
    End Sub
End Class