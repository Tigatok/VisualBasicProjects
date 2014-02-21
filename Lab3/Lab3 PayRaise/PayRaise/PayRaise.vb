Public Class PayRaiseForm

    Private Sub calculateButton_Click(sender As System.Object, e As System.EventArgs) Handles calculateButton.Click
        Dim output As String
        output = "Year" & ControlChars.Tab & "Amount" & ControlChars.CrLf
        Dim rate As Double = percentUpDown.Value
        Dim principal As Decimal = wageTextBox.Text * 52 * 40
        Dim amount As Decimal



        For yearCounter As Integer = 0 To yearsUpDown.Value
            If yearCounter = 0 Then
                amount =
                    principal
            Else
                amount =
                    principal * ((1 + rate / 100) ^ yearCounter)
            End If
            output &= yearCounter + 1 & ControlChars.Tab & String.Format("{0:C}", amount) & ControlChars.CrLf
        Next
        earningsTextBox.Text = output
    End Sub

End Class ' PayRaiseForm
