Imports PetrolProgram.Controls
Public Class Report
    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblIncome.Text = FuelPriceCalculator(FuelCost)
        lblSolded.Text = FuelAmount & "/L"
    End Sub
End Class