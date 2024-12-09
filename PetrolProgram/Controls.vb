Public Class Controls
    Public Shared FuelCost As Int32
    Public Shared FuelAmount As Int16 = 0
    'Default Fuel Values
    Public Shared PetrolCost As Int16 = 129
    Public Shared DieselCost As Int16 = 158
    'Default Username and Password Values
    Public Shared Username As String
    Public Shared Password As String
    Public Shared DefaultPswUsr As String = "123"
    'Variables for the new petrol cost and setting the default vaules to nothing
    Public Shared UpdatedPetrol As Int16 = 0
    Public Shared UpdatedDiesel As Int16 = 0
    'Variables for the new Usr&Psw and setting the default vaules to nothing
    Public Shared UpdatedUsername As String = ""
    Public Shared UpdatedPassword As String = ""

    'Funny Functions
    Public Shared Function FuelPriceCalculator(ByVal Cost As Decimal)
        Dim Output As Decimal
        Output = Cost / 100
        If Output > 100 Then
            Output = Output * 10
            Return ("£" & Output & " /L")
        Else
            Return ("£" & Output & " /L")
        End If

    End Function
    Public Shared Sub LabelUpdate()
        If UpdatedPetrol = 0 Then
            FuelChange.lblPtlCst.Text = FuelPriceCalculator(PetrolCost) 'The defualt Petrol Cost
        Else
            FuelChange.lblPtlCst.Text = FuelPriceCalculator(UpdatedPetrol)
        End If
        If UpdatedDiesel = 0 Then
            FuelChange.lblDslCst.Text = FuelPriceCalculator(DieselCost) 'The defualt Diesel Cost 
        Else
            FuelChange.lblDslCst.Text = FuelPriceCalculator(UpdatedPetrol)
        End If

        If UpdatedUsername = "" Then
            LoginChange.lblUsrVal.Text = DefaultPswUsr 'The defualt Username
        Else
            LoginChange.lblUsrVal.Text = UpdatedUsername
        End If

        If UpdatedPassword = "" Then
            LoginChange.lblPwdVal.Text = DefaultPswUsr 'The defualt Password
        Else
            LoginChange.lblPwdVal.Text = UpdatedPassword
        End If
    End Sub
End Class