Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports PetrolProgram.Controls

Public Class Dashboard
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Menu.Show()
        Me.Close()
    End Sub

    Private Sub btnFulChge_Click(sender As Object, e As EventArgs) Handles btnFulChge.Click
        FuelChange.Show()
    End Sub

    Private Sub btnLgnChge_Click(sender As Object, e As EventArgs) Handles btnLgnChge.Click
        LoginChange.Show()
    End Sub

    Private Sub btnRpt_Click(sender As Object, e As EventArgs) Handles btnRpt.Click
        Report.Show()
    End Sub
End Class