Public Class FeeCalculatorForm
    Function FeeFunction(inTime As Date, outTime As Date) As Decimal
        Dim TotalTime As TimeSpan = outTime.Subtract(inTime) 'Uses TimeSpan to get the span of time. Like DateDiff, found on VB resources under microsoft website.
        Dim Fee As Decimal = TotalTime.TotalHours * 3 'Gets the value of fee.

        Return Fee 'Returns fee

    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculateButton.Click 'Gets the value in Currency form.

        feeResultLabel.Text = String.Format("{0:C2}", FeeFunction(timeInDateTimePicker.Value, timeOutDateTimePicker.Value))

    End Sub
End Class