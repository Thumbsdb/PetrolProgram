Imports PetrolProgram.Controls
Public Class FuelChange

    Private Sub btnUptFul_Click(sender As Object, e As EventArgs) Handles btnUptFul.Click
        UpdatedPetrol = txtPtl.Text
        UpdatedDiesel = txtDsl.Text
        LabelUpdate()
    End Sub

    Private Sub FuelChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelUpdate()
    End Sub

End Class