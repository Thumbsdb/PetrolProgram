Public Class Controls
    Public Shared FuelCost As Int32
    Public Shared FuelAmount As Int16 = 0
    Public Shared Function Maths(ByVal Cost As Decimal)
        Dim Output As Decimal
        Output = Cost / 100
        Return ("£" & Output & " /L")
    End Function
End Class
