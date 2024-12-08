Imports PetrolProgram.Controls
Public Class Checkout
    Private Sub Checkout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLtrNum.Text = FuelAmount & " /L"
        lblFulNum.Text = Maths(FuelCost)
    End Sub

    Private Sub btnMnu_Click(sender As Object, e As EventArgs) Handles btnMnu.Click
        Menu.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Pay.Show()
        Me.Close()
    End Sub
End Class