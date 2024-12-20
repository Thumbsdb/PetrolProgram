﻿Imports System.Reflection.Emit
Imports System.Text
Imports System.Xml
Imports Microsoft.VisualBasic.Devices
Imports PetrolProgram.Controls

Public Class Game
    Public bMouseDown As Boolean


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
                PicPump.BackColor = Color.LightGreen
                Counting()
            End If
        End If
    End Sub

    Private Sub btnFul_MouseUp(sender As Object, e As MouseEventArgs) Handles btnFul.MouseUp
        If e.Button = MouseButtons.Left Then
            bMouseDown = False
            PicPump.BackColor = Color.RebeccaPurple
        End If
    End Sub

    'Custom Sub & Functions
    'Private Function FuelPriceCalculator(ByVal Cost As Decimal)
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
            lblCstNum.Text = FuelPriceCalculator(FuelCost)
        End If

        If rdoDiesel.Checked Then
            FuelCost = Counter * DieselCost
            lblCstNum.Text = FuelPriceCalculator(FuelCost)
        End If
        Return (FuelCost)
    End Function
    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If UpdatedPetrol > 0 Then
            lblPtlNum.Text = FuelPriceCalculator(UpdatedPetrol)
        Else
            lblPtlNum.Text = FuelPriceCalculator(PetrolCost)
        End If

        'Displaying the corrct number and if it's the Default Number do FuelPriceCalculator to have decimal
        If UpdatedDiesel > 0 Then
            lblDslNum.Text = FuelPriceCalculator(UpdatedDiesel)
        Else
            lblDslNum.Text = FuelPriceCalculator(DieselCost)
        End If
    End Sub
End Class