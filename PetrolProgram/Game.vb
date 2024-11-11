Imports System.Reflection.Emit

Public Class Game
    Public Counter As Int16 = 0
    Public bMouseDown As Boolean
    Public Shared PetrolCost As Int16 = 1129
    Public Shared DieselCost As Int16 = 1158
    Dim FuelCost As Decimal
    Dim Dec As Decimal
    Private Sub Counting()
        Dim Timer As New Timer()
        Timer.Interval = 1
        ' I have no clue what this does
        AddHandler Timer.Tick, Sub(sender, e)
                                   ' This checks wither or not the mouse is actually being held down and if True increase the timer by 100, if not sDec timer
                                   If bMouseDown = True Then
                                       Counter += 10
                                       lblFulNum.Text = Counter
                                       System.Diagnostics.Debug.WriteLine(Counter)
                                   Else
                                       Timer.Stop()
                                   End If
                               End Sub
        ' Starts timer here because aids
        Timer.Start()
    End Sub

    Private Sub btnFul_MouseDown(sender As Object, e As MouseEventArgs) Handles btnFul.MouseDown
        If e.Button = MouseButtons.Left Then
            bMouseDown = True
            Counting()
        End If
    End Sub

    Private Sub btnFul_MouseUp(sender As Object, e As MouseEventArgs) Handles btnFul.MouseUp
        If e.Button = MouseButtons.Left Then
            bMouseDown = False
        End If

    End Sub

    Private Sub btnFul_Click(sender As Object, e As EventArgs) Handles btnFul.Click
        'Generats a random Int number form 1 - 9999 and then converts to a float so that it displays at $99.99
        'We do this becuse it meanse when calucalting we don't do floating arithmetic and do int arithmetic
        'Dim upperbound As Integer = 9999
        'Dim lowerbound As Integer = 1
        'Dim ram As Int32
        'ram = Int((upperbound - lowerbound + 1) * Rnd() + lowerbound)
        'PetrolCost = CDec(ram)
        'lblPtlNum.Text = PetrolCost
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMnu.Click
        Menu.Show()
        Me.Close()
    End Sub

    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Dashboard.UpdatedPetrol > 0 Then
            PetrolCost = Dashboard.UpdatedPetrol
            lblPtlNum.Text = PetrolCost
        Else
            Maths(PetrolCost)
            lblPtlNum.Text = FuelCost
        End If

        'Displaying the corrct number and if it's the Default Number do maths to have decimal
        If Dashboard.UpdatedDiesel > 0 Then
            DieselCost = Dashboard.UpdatedDiesel
            lblDslNum.Text = DieselCost
        Else
            Maths(DieselCost)
            lblDslNum.Text = FuelCost
        End If
    End Sub

    Private Function Maths(Dec As Decimal)
        Dec = DieselCost
        FuelCost = Dec / 100
        Return FuelCost
    End Function
End Class