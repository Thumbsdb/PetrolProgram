﻿Imports System.Reflection.Emit
Imports System.Text
Imports Microsoft.VisualBasic.Devices
Imports PetrolProgram.Controls

Public Class Game
    Public bMouseDown As Boolean
    Public Shared PetrolCost As Int16 = 129
    Public Shared DieselCost As Int16 = 158

    Private Sub btnCut_Click(sender As Object, e As EventArgs) Handles btnCut.Click
        Checkout.Show()
        Me.Close()
    End Sub
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMnu.Click
        Menu.Show()
        Me.Close()
    End Sub

    Private Sub btnFul_MouseDown(sender As Object, e As MouseEventArgs) Handles btnFul.MouseDown
        If rdoDiesel.Checked = False And rdoPetrol.Checked = False Then
            MsgBox("Please select a fuel type")
        Else
            rdoPetrol.Enabled = False
            rdoDiesel.Enabled = False
            If e.Button = MouseButtons.Left Then
                bMouseDown = True
                Counting()
            End If
        End If
    End Sub

    Private Sub btnFul_MouseUp(sender As Object, e As MouseEventArgs) Handles btnFul.MouseUp
        If e.Button = MouseButtons.Left Then
            bMouseDown = False
        End If
    End Sub

    'Custom Sub & Functions
    'Private Function Maths(ByVal Cost As Decimal)
    'Dim Output As Decimal
    '   Output = Cost / 100
    'Return ("£" & Output & " /L")
    'End Function

    Private Sub Counting()
        Dim Timer As New Timer()
        Timer.Interval = 61
        'This Creats a new timer and adds the handler to it I think
        AddHandler Timer.Tick, Sub(sender, e)
                                   ' This checks wither or not the mouse is actually being held down and if True increase the timer by 100, if not sDec timer
                                   If bMouseDown = True Then
                                       FuelAmount += 1
                                       lblFulNum.Text = FuelAmount & " /L"
                                       FuelCostCounter(FuelAmount)
                                       'System.Diagnostics.Debug.WriteLine(Counter)
                                   Else
                                       Timer.Stop()
                                   End If
                               End Sub
        ' Starts timer here because aids
        Timer.Start()
    End Sub
    Private Function FuelCostCounter(ByRef Counter As Int32)
        If rdoPetrol.Checked Then
            FuelCost = Counter * PetrolCost
            lblCstNum.Text = Maths(FuelCost)
        End If

        If rdoDiesel.Checked Then
            FuelCost = Counter * DieselCost
            lblCstNum.Text = Maths(FuelCost)
        End If
        Return (FuelCost)
    End Function
    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Dashboard.UpdatedPetrol > 0 Then
            lblPtlNum.Text = Maths(Dashboard.UpdatedPetrol)
        Else
            lblPtlNum.Text = Maths(PetrolCost)
        End If

        'Displaying the corrct number and if it's the Default Number do maths to have decimal
        If Dashboard.UpdatedDiesel > 0 Then
            lblDslNum.Text = Maths(Dashboard.UpdatedDiesel)
        Else
            lblDslNum.Text = Maths(DieselCost)
        End If
    End Sub

End Class