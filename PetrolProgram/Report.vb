Imports PetrolProgram.Controls
Public Class Report
    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblIncome.Text = FuelAmount & "/L"
        lblSolded.Text = Maths(FuelCost)
    End Sub
End Class