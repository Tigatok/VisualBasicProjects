' Exercise 8.12 Solution
' FuzzyDiceOrderForm.vb

Public Class FuzzyDiceOrderForm
    Private Sub calculateButton_Click(sender As System.Object,
        e As System.EventArgs) Handles calculateButton.Click
        Dim name As String = nameTextBox.Text 'name = nametextbox field
        Dim address1 As String = addressLine1TextBox.Text 'address1 = address1 field
        Dim cityStateZip As String = cityStateZipTextBox.Text 'citystatezip = citystatezip field
        Dim orderNumber = orderNumberTextBox.Text 'ordernumber = order number field
        Dim count As Integer = 0 'Read below
        'EXPLAINING WHAT THE COUNTER ACCOMPLISHES
        'When the If statement is false, it will add one to count. 
        'When 1 is added to count, it violates the terms for the If statement below.
        'The if statement below controls the rest of the program.
        'This allows the user to correct their mistake, WITHOUT the data calculating anyways.
        'I.E., WITHOUT COUNTER if you didn't enter a name, it would display error message, and then 
        '                      calculate the rest of the info. With counter, it avoids that problem.
        If (name = "" OrElse address1 = "" OrElse cityStateZip = "" OrElse orderNumber = "") Then
            MessageBox.Show("Please Enter: Order Number, Name, Address 1 and City State Zip", "Missing Information",
            MessageBoxButtons.OK, MessageBoxIcon.Warning) 'Displays dialog box
            count += 1 'adds count by 1, see above comment for what it does.
        End If
        If (CheckBox1.Checked = False And whiteBlackQuantityTextBox.Text <> "" And whiteBlackQuantityTextBox.Text > 0) Then
            MessageBox.Show("Please check item you wish to purchase", "No Item Selected",
          MessageBoxButtons.OK, MessageBoxIcon.Error) 'Displays dialog box
            count += 1 'adds count by 1, see above comment for what it does.
        End If
        If (CheckBox2.Checked = False And redBlackQuantityTextBox.Text <> "" And redBlackQuantityTextBox.Text > 0) Then
            MessageBox.Show("Please check item you wish to purchase", "No Item Selected",
          MessageBoxButtons.OK, MessageBoxIcon.Error) 'Displays dialog box
            count += 1 'adds count by 1, see above comment for what it does.
        End If
        If (CheckBox3.Checked = False And blueBlackQuantityTextBox.Text <> "" And blueBlackQuantityTextBox.Text > 0) Then
            MessageBox.Show("Please check item you wish to purchase", "No Item Selected",
          MessageBoxButtons.OK, MessageBoxIcon.Error) 'Displays dialog box
            count += 1 'adds count by 1, see above comment for what it does.
        End If
        If count = 0 Then 'Continues the process if no errors were comitted.
            Const whiteBlackDicePrice = 6.25 'Sets a constant value for the price the White/Black Dice
            Const redBlackDicePrice = 5.0 'Sets a constant value for the price of the Red/Black Dice
            Const blueBlackDicePrice = 7.5 'Sets a constant value for the price of the Blue/Black Dice
            Const tax = 0.05 'Sets the tax as a constant for 5%

            Dim whiteBlackSubTotal As Double = whiteBlackQuantityTextBox.Text * whiteBlackDicePrice 'Creates a subtotal for White/Black
            Dim redBlackSubTotal As Double = redBlackQuantityTextBox.Text * redBlackDicePrice 'Creates a subtotal for Red/Black
            Dim blueBlackSubtotal As Double = blueBlackQuantityTextBox.Text * blueBlackDicePrice 'Creates a subtotal for blue/black

            Dim totalWhite As Integer = whiteBlackQuantityTextBox.Text 'Counts total amount of white dice
            Dim totalRed As Integer = redBlackQuantityTextBox.Text 'Counts total amount of red dice
            Dim totalBlue As Integer = blueBlackQuantityTextBox.Text 'Counts total amount of blue dice
            Dim totalQuantity As Integer = totalWhite + totalRed + totalBlue 'Counts total amount of all the dice.


            Dim subtotal As Double = whiteBlackSubTotal + redBlackSubTotal + blueBlackSubtotal 'Adds the amount of all dice, without tax and shipping
            Dim afterTax As Decimal = (subtotal * tax) 'creates an after tax value by multiplying the subtotal by the tax amount, which is a constant

            Dim afterShipping As Double = 1.5 'Creates a afterShipping variable and sets it to 1.50 for each dice
            If (totalQuantity > 20) Then 'If there are more than 20 dice ordered, shipping does not apply.
                afterShipping = 0 'Sets the shipping to 0
            Else
                afterShipping *= totalQuantity 'Sets shipping amount to the amount of dice * shipping price
            End If

            Dim total As Decimal = afterTax + afterShipping + subtotal 'Creates total value, by adding afterTax + afterShipping + subtotal

            'Printing all things required in a Currency format, with 2 decimal places. 

            whiteBlackTotalsLabel.Text = String.Format("{0:C2}", whiteBlackSubTotal)
            redBlackTotalsLabel.Text = String.Format("{0:C2}", redBlackSubTotal)
            blueBlackTotalsLabel.Text = String.Format("{0:C2}", blueBlackSubtotal)

            subtotalResultLabel.Text = String.Format("{0:C2}", subtotal)

            taxResultLabel.Text = String.Format("{0:C2}", afterTax)

            shippingResultLabel.Text = String.Format("{0:C2}", afterShipping)

            totalResultLabel.Text = String.Format("{0:C2}", total)
        End If
    End Sub

    ''' <summary>
    ''' Clears the texbox's if the orderTextBox is altered.
    ''' </summary>
    Private Sub orderNumberTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles orderNumberTextBox.TextChanged
        nameTextBox.Text = ""
        addressLine1TextBox.Text = ""
        addressLine2TextBox.Text = ""
        cityStateZipTextBox.Text = ""
        whiteBlackTotalsLabel.Text = ""
        redBlackTotalsLabel.Text = ""
        blueBlackTotalsLabel.Text = ""
        subtotalResultLabel.Text = ""
        taxResultLabel.Text = ""
        shippingResultLabel.Text = ""
        totalResultLabel.Text = ""
    End Sub
End Class