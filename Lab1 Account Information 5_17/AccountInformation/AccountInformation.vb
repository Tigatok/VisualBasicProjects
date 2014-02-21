Public Class AccountInformationForm
    Private Sub enterButton_Click(sender As System.Object, e As System.EventArgs) Handles enterButton.Click

        'add, then subtract the values in withdrawl - deposit. update total
        balanceAmountLabel.Text +=
            Val(depositAmountTextBox.Text) - Val(withdrawlAmountTextBox.Text)
        withdrawlAmountTextBox.Text = 0
        depositAmountTextBox.Text = 0

    End Sub
End Class
