Public Class CreditCheckerForm

    Private Sub calculateButton_Click(sender As System.Object, e As System.EventArgs) Handles calculateButton.Click
        Dim startingBalance, charges, credits, creditLimit, newBalance As Decimal

        startingBalance = startBalanceTextBox.Text
        charges = totalChargesTextBox.Text
        credits = totalCreditsTextBox.Text
        creditLimit = creditLimitTextBox.Text
        newBalance = credits - startingBalance + charges
        newBalanceResultLabel.Text = String.Format("{0:C2}", newBalance)

        If (newBalance > creditLimit) Then
            errorLabel.Text = "Balance exceeds credit limit!"

        Else
            errorLabel.Text = ""
        End If
        'errorLabel.Text = ""
    End Sub

    Private Sub accountNumberTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles accountNumberTextBox.TextChanged
        startBalanceTextBox.Text = ""
        totalChargesTextBox.Text = ""
        creditLimitTextBox.Text = ""
        totalCreditsTextBox.Text = ""
        errorLabel.Text = ""
        newBalanceResultLabel.Text = ""


    End Sub
End Class ' CreditCheckerForm

