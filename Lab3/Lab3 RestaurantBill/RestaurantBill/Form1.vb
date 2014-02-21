Public Class Form1
    Dim count As Integer = 0
    Private Sub addItemButton_Click(sender As System.Object, e As System.EventArgs) Handles addItemButton.Click
        quantityListBox.Items.Add(quantityTextBox.Text)
        menuItemListBox.Items.Add(menuTextBox.Text)
        priceListBox.Items.Add(quantityTextBox.Text * priceTextBox.Text)
        count += 1
    End Sub

    Private Sub totalBillButton_Click(sender As System.Object, e As System.EventArgs) Handles totalBillButton.Click
        Dim quantitySum As Double = 0
        Dim menuItemSum As Integer = 0
        Dim priceSum As Double = 0
        Dim index As Integer = 0
        Do Until index = count
            priceSum += priceListBox.Items(index)
            index += 1
        Loop
        totalCostLabelBox.Text = String.Format("{0:C2}", priceSum)
        index = 0
    End Sub
End Class